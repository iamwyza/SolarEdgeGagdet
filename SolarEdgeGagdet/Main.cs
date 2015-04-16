using SolarEdgeGagdet.Properties;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SolarEdgeGagdet
{
    public partial class Main : Form
    {

        private const int WM_WINDOWPOSCHANGING = 0x0046;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        Timer timer = new Timer();
        Point? prevPosition = null;
        CustomToolTip tooltip = new CustomToolTip();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();

            var tempLocation = Settings.Default.Location.Split('|');
            Location = new Point(Convert.ToInt32(tempLocation[0]), Convert.ToInt32(tempLocation[1]));

            chartWeek.Series[0].XValueType = ChartValueType.DateTime;
            chartWeek.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd";
            chartWeek.ChartAreas[0].AxisX.Interval = 1;
            chartWeek.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chartWeek.ChartAreas[0].AxisX.IntervalOffset = .5;
            chartWeek.ChartAreas[0].AxisX.IntervalOffsetType = DateTimeIntervalType.Hours;

            chartMonth.ChartAreas[0].AxisX.Minimum = .5;
            chartMonth.ChartAreas[0].AxisX.IntervalOffset = .5;
            chartMonth.ChartAreas[0].AxisX.Interval = 1;

            chartYear.ChartAreas[0].AxisX.LabelStyle.Format = "MMM";
            chartYear.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chartYear.ChartAreas[0].AxisX.Interval = 1;
            lblMonthNow.Text = DateTime.Now.ToString("MMMM");
            lblYearNow.Text = DateTime.Now.Year.ToString();
            SetData();

            tooltip.Tag = String.Empty;
            
            timer.Interval = 5 * 60 * 1000;
            timer.Tick += (sender, e) => { SetData(); };
            timer.Start();

        }

        private void SetData()
        {
            try {
                var solarEdge = new SolarEdge();
                var data = solarEdge.GetData();

                var toleranceAdjustment = Settings.Default.ToleranceAdjustment / 100;


                lblCurrentPower.Text = ApplyTolerance(data.overviewData.currentPower, toleranceAdjustment);
                lblCurrentMonth.Text = ApplyTolerance(data.overviewData.lastMonthEnergy, toleranceAdjustment);
                lblLifetimePower.Text = ApplyTolerance(data.overviewData.lifeTimeEnergy, toleranceAdjustment);
                lblTodayPower.Text = ApplyTolerance(data.overviewData.lastDayEnergy, toleranceAdjustment);

                lblLastUpdatedValue.Text = DateTime.Now.ToString();

                chartWeek.ChartAreas[0].AxisX.Minimum = new DateTime(1970, 1, 1).AddMilliseconds(data.energyChartData.start_week).ToOADate();
                chartWeek.ChartAreas[0].AxisX.Maximum = new DateTime(1970, 1, 1).AddMilliseconds(data.energyChartData.start_week + (data.energyChartData.power_chart_week.Count * 1000 * 60 * 15)).ToOADate();

                chartWeek.Series[0].Points.Clear();
                for (var i = 0; i < data.energyChartData.power_chart_week.Count; i++)
                {
                    chartWeek.Series[0].Points.AddXY(new DateTime(1970, 1, 1).AddMilliseconds(data.energyChartData.start_week + (i * 1000 * 60 * 15)), 
                                                    data.energyChartData.power_chart_week[i] == null ? 0.0 : ApplyTolerance(data.energyChartData.power_chart_week[i], toleranceAdjustment));
                }

                chartMonth.Series[0].Points.Clear();
                for (var i = 0; i < data.energyChartData.energy_chart_month_by_day.production.data.Count; i++)
                {
                    chartMonth.Series[0].Points.AddXY(i + 1, ApplyTolerance(data.energyChartData.energy_chart_month_by_day.production.data[i], toleranceAdjustment));
                }

                chartYear.Series[0].Points.Clear();
                for(var i = 0; i< data.energyChartData.energy_chart_year_by_month.production.data.Count; i++)
                {
                    chartYear.Series[0].Points.AddXY(new DateTime(DateTime.Now.Year, i + 1, 1), ApplyTolerance(data.energyChartData.energy_chart_year_by_month.production.data[i], toleranceAdjustment));
                }

            }catch(Exception ex)
            {
                File.WriteAllText("Error.txt", ex.ToString());
                lblLastUpdatedValue.Text = "Offline";
            }

        }

        string ApplyTolerance (string input, decimal tolerance)
        {
            var temp = input.Split(' ');
            return Math.Round(Convert.ToDecimal(temp[0]) * tolerance, 2) + " " + temp[1];
        }

        double ApplyTolerance (double? input, decimal tolerance)
        {
            return (double)Math.Round((decimal)input * tolerance, 3);
        }

        //http://stackoverflow.com/questions/10648828/see-values-of-chart-points-when-the-mouse-is-on-points
        void chart_MouseMove(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;

            prevPosition = pos;
            var results = chart.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            if (results.Any())
            {
                
                foreach (var result in results)
                {
                    if (result.ChartElementType == ChartElementType.DataPoint)
                    {
                        var prop = result.Object as DataPoint;
                        if (prop != null)
                        {
                            if (chart.Name == "chartWeek")
                            {
                                var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                                var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                                // check if the cursor is really close to the point (2 pixels around the point)
                                if (Math.Abs(pos.X - pointXPixel) < 10 &&
                                    Math.Abs(pos.Y - pointYPixel) < 15)
                                {

                                    var text = prop.YValues[0] + " kW @ " + DateTime.FromOADate(prop.XValue).ToShortTimeString();
                                    if ((string)tooltip.Tag != text)
                                    {
                                        tooltip.Tag = text;
                                        tooltip.Show(text, chart, pos.X + 15, pos.Y - 15);
                                    }
                                }
                                else
                                {
                                    tooltip.RemoveAll();
                                    tooltip.Tag = String.Empty;
                                }
                            }
                            else
                            {
                                var text = prop.YValues[0] + " kWh";
                                if ((string)tooltip.Tag != text)
                                {
                                    tooltip.Tag = text;
                                    tooltip.Show(text, chartMonth, pos.X + 15, pos.Y - 15);
                                }
                            }
                        }
                    }else
                    {
                        tooltip.RemoveAll();
                        tooltip.Tag = String.Empty;
                    }
                }
            }
            else
            {
                tooltip.RemoveAll();
                tooltip.Tag = String.Empty;
            }
        }


       

        #region Click Events

        private void lblMonthButton_Click(object sender, EventArgs e)
        {
            pnlMonth.Show();
            pnlWeek.Hide();
            lblMonthButton.ForeColor = Color.FromArgb(0, 131, 255);
            lblWeekButton.ForeColor = lblYearButton.ForeColor = Color.White;
        }

        private void lblWeekButton_Click(object sender, EventArgs e)
        {
            pnlMonth.Hide();
            pnlYear.Hide();
            pnlWeek.Show();
            lblWeekButton.ForeColor = Color.FromArgb(0, 131, 255);
            lblMonthButton.ForeColor = lblYearButton.ForeColor = Color.White;
        }
        
        private void lblYear_Click(object sender, EventArgs e)
        {
            pnlMonth.Hide();
            pnlWeek.Hide();
            pnlYear.Show();
            lblYearButton.ForeColor = Color.FromArgb(0, 131, 255);
            lblMonthButton.ForeColor = lblWeekButton.ForeColor = Color.White;
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SetData();
            timer.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSideBar_MouseLeave(object sender, EventArgs e)
        {
            panelSideBar.Visible = false;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (panelSideBar.Bounds.Contains(e.Location) && !panelSideBar.Visible)
                panelSideBar.Visible = true;
            else if (!panelSideBar.Bounds.Contains(e.Location) && panelSideBar.Visible)
                panelSideBar.Visible = false;
        }

        //http://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        private void MoveIconMouseDown (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Window Backmost
        private void BackMost(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            const short SWP_NOZORDER = 0X0004;
            const short SWP_NOACTIVATE = 0X0010;
            const short SWP_NOOWNERZORDER = 0x0200;
            // Listen for operating system messages. 
            switch (m.Msg)
            {
                case WM_WINDOWPOSCHANGING:
                    SetWindowPos(this.Handle, 0, this.Left, this.Top, this.Width, this.Height, SWP_NOACTIVATE | SWP_NOZORDER | SWP_NOOWNERZORDER);

                    // Invalidate to get new text painted. 
                    this.Invalidate();

                    break;

            }
            base.WndProc(ref m);
        }
        #endregion

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = System.Windows.Forms.Cursor.Position;
            if (form.ShowDialog() == DialogResult.OK)
            {
                timer.Stop();
                SetData();
                timer.Start();
            }
        }

        private void Main_Move(object sender, EventArgs e)
        {
            Settings.Default.Location = Location.X + "|" + Location.Y;
            Settings.Default.Save();
        }

    }
}

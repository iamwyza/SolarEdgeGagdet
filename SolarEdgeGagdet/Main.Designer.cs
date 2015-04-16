namespace SolarEdgeGagdet
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblCurrentHeader = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblLifeTime = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.lblCurrentPower = new System.Windows.Forms.Label();
            this.lblTodayPower = new System.Windows.Forms.Label();
            this.lblCurrentMonth = new System.Windows.Forms.Label();
            this.lblLifetimePower = new System.Windows.Forms.Label();
            this.lblLastUpdatedValue = new System.Windows.Forms.Label();
            this.pnlWeek = new System.Windows.Forms.Panel();
            this.chartWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.chartMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMonthNow = new System.Windows.Forms.Label();
            this.pnlYear = new System.Windows.Forms.Panel();
            this.lblYearNow = new System.Windows.Forms.Label();
            this.chartYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMonthButton = new System.Windows.Forms.Label();
            this.lblWeekButton = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.moveButton = new System.Windows.Forms.PictureBox();
            this.refereshButton = new System.Windows.Forms.PictureBox();
            this.btnConfigure = new System.Windows.Forms.PictureBox();
            this.lblYearButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlWeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeek)).BeginInit();
            this.pnlMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).BeginInit();
            this.pnlYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).BeginInit();
            this.notifyMenu.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfigure)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentHeader
            // 
            this.lblCurrentHeader.AutoSize = true;
            this.lblCurrentHeader.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHeader.ForeColor = System.Drawing.Color.White;
            this.lblCurrentHeader.Location = new System.Drawing.Point(1064, 9);
            this.lblCurrentHeader.Name = "lblCurrentHeader";
            this.lblCurrentHeader.Size = new System.Drawing.Size(79, 24);
            this.lblCurrentHeader.TabIndex = 0;
            this.lblCurrentHeader.Text = "Current";
            this.lblCurrentHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.ForeColor = System.Drawing.Color.White;
            this.lblPower.Location = new System.Drawing.Point(1071, 50);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(64, 22);
            this.lblPower.TabIndex = 1;
            this.lblPower.Text = "Power";
            this.lblPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(1073, 178);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(61, 22);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.Color.White;
            this.lblToday.Location = new System.Drawing.Point(1073, 114);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(61, 22);
            this.lblToday.TabIndex = 3;
            this.lblToday.Text = "Today";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLifeTime
            // 
            this.lblLifeTime.AutoSize = true;
            this.lblLifeTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeTime.ForeColor = System.Drawing.Color.White;
            this.lblLifeTime.Location = new System.Drawing.Point(1064, 242);
            this.lblLifeTime.Name = "lblLifeTime";
            this.lblLifeTime.Size = new System.Drawing.Size(78, 22);
            this.lblLifeTime.TabIndex = 4;
            this.lblLifeTime.Text = "Lifetime";
            this.lblLifeTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdated.ForeColor = System.Drawing.Color.White;
            this.lblLastUpdated.Location = new System.Drawing.Point(1042, 306);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(123, 22);
            this.lblLastUpdated.TabIndex = 5;
            this.lblLastUpdated.Text = "Last Updated";
            this.lblLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentPower
            // 
            this.lblCurrentPower.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.lblCurrentPower.Location = new System.Drawing.Point(1041, 82);
            this.lblCurrentPower.Name = "lblCurrentPower";
            this.lblCurrentPower.Size = new System.Drawing.Size(125, 22);
            this.lblCurrentPower.TabIndex = 6;
            this.lblCurrentPower.Text = "99999 W";
            this.lblCurrentPower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTodayPower
            // 
            this.lblTodayPower.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.lblTodayPower.Location = new System.Drawing.Point(1041, 145);
            this.lblTodayPower.Name = "lblTodayPower";
            this.lblTodayPower.Size = new System.Drawing.Size(125, 22);
            this.lblTodayPower.TabIndex = 7;
            this.lblTodayPower.Text = "999999 kWh";
            this.lblTodayPower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentMonth
            // 
            this.lblCurrentMonth.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.lblCurrentMonth.Location = new System.Drawing.Point(1041, 209);
            this.lblCurrentMonth.Name = "lblCurrentMonth";
            this.lblCurrentMonth.Size = new System.Drawing.Size(125, 22);
            this.lblCurrentMonth.TabIndex = 8;
            this.lblCurrentMonth.Text = "999999 kWh";
            this.lblCurrentMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLifetimePower
            // 
            this.lblLifetimePower.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifetimePower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.lblLifetimePower.Location = new System.Drawing.Point(1041, 273);
            this.lblLifetimePower.Name = "lblLifetimePower";
            this.lblLifetimePower.Size = new System.Drawing.Size(125, 22);
            this.lblLifetimePower.TabIndex = 9;
            this.lblLifetimePower.Text = "999999 kWh";
            this.lblLifetimePower.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLastUpdatedValue
            // 
            this.lblLastUpdatedValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdatedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.lblLastUpdatedValue.Location = new System.Drawing.Point(1030, 337);
            this.lblLastUpdatedValue.Name = "lblLastUpdatedValue";
            this.lblLastUpdatedValue.Size = new System.Drawing.Size(147, 54);
            this.lblLastUpdatedValue.TabIndex = 10;
            this.lblLastUpdatedValue.Text = "07:45:00 PM\r\n01/01/2004";
            this.lblLastUpdatedValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlWeek
            // 
            this.pnlWeek.BackColor = System.Drawing.Color.Transparent;
            this.pnlWeek.Controls.Add(this.chartWeek);
            this.pnlWeek.Location = new System.Drawing.Point(17, 36);
            this.pnlWeek.Name = "pnlWeek";
            this.pnlWeek.Size = new System.Drawing.Size(1011, 341);
            this.pnlWeek.TabIndex = 11;
            this.pnlWeek.Visible = false;
            // 
            // chartWeek
            // 
            this.chartWeek.BackColor = System.Drawing.Color.Transparent;
            this.chartWeek.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            chartArea1.AxisY.Title = "kW";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartWeek.ChartAreas.Add(chartArea1);
            this.chartWeek.Location = new System.Drawing.Point(4, 14);
            this.chartWeek.Name = "chartWeek";
            this.chartWeek.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Blue;
            series1.BorderColor = System.Drawing.Color.Navy;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            this.chartWeek.Series.Add(series1);
            this.chartWeek.Size = new System.Drawing.Size(1004, 324);
            this.chartWeek.TabIndex = 0;
            this.chartWeek.Text = "chart1";
            this.chartWeek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // pnlMonth
            // 
            this.pnlMonth.BackColor = System.Drawing.Color.Transparent;
            this.pnlMonth.Controls.Add(this.chartMonth);
            this.pnlMonth.Location = new System.Drawing.Point(15, 36);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(1011, 355);
            this.pnlMonth.TabIndex = 12;
            // 
            // chartMonth
            // 
            this.chartMonth.BackColor = System.Drawing.Color.Transparent;
            this.chartMonth.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            chartArea2.AxisY.Title = "kWh";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartMonth.ChartAreas.Add(chartArea2);
            this.chartMonth.Location = new System.Drawing.Point(3, 8);
            this.chartMonth.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.chartMonth.Name = "chartMonth";
            this.chartMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.Navy;
            series2.BorderColor = System.Drawing.Color.Navy;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Name = "Series1";
            this.chartMonth.Series.Add(series2);
            this.chartMonth.Size = new System.Drawing.Size(1004, 324);
            this.chartMonth.TabIndex = 1;
            this.chartMonth.Text = "chart2";
            this.chartMonth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // lblMonthNow
            // 
            this.lblMonthNow.AutoSize = true;
            this.lblMonthNow.ForeColor = System.Drawing.Color.White;
            this.lblMonthNow.Location = new System.Drawing.Point(488, 327);
            this.lblMonthNow.Name = "lblMonthNow";
            this.lblMonthNow.Size = new System.Drawing.Size(44, 13);
            this.lblMonthNow.TabIndex = 2;
            this.lblMonthNow.Text = "January";
            // 
            // pnlYear
            // 
            this.pnlYear.BackColor = System.Drawing.Color.Transparent;
            this.pnlYear.Controls.Add(this.lblYearNow);
            this.pnlYear.Controls.Add(this.chartYear);
            this.pnlYear.Location = new System.Drawing.Point(15, 36);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(1011, 355);
            this.pnlYear.TabIndex = 12;
            this.pnlYear.Visible = false;
            // 
            // lblYearNow
            // 
            this.lblYearNow.AutoSize = true;
            this.lblYearNow.ForeColor = System.Drawing.Color.White;
            this.lblYearNow.Location = new System.Drawing.Point(488, 327);
            this.lblYearNow.Name = "lblYearNow";
            this.lblYearNow.Size = new System.Drawing.Size(31, 13);
            this.lblYearNow.TabIndex = 2;
            this.lblYearNow.Text = "2014";
            // 
            // chartYear
            // 
            this.chartYear.BackColor = System.Drawing.Color.Transparent;
            this.chartYear.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            chartArea3.AxisY.Title = "kWh";
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartYear.ChartAreas.Add(chartArea3);
            this.chartYear.Location = new System.Drawing.Point(3, 8);
            this.chartYear.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.chartYear.Name = "chartYear";
            this.chartYear.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series3.BackSecondaryColor = System.Drawing.Color.Navy;
            series3.BorderColor = System.Drawing.Color.Navy;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Name = "Series1";
            this.chartYear.Series.Add(series3);
            this.chartYear.Size = new System.Drawing.Size(1004, 324);
            this.chartYear.TabIndex = 1;
            this.chartYear.Text = "chart2";
            this.chartYear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // lblMonthButton
            // 
            this.lblMonthButton.AutoSize = true;
            this.lblMonthButton.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMonthButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.lblMonthButton.Location = new System.Drawing.Point(223, 9);
            this.lblMonthButton.Name = "lblMonthButton";
            this.lblMonthButton.Size = new System.Drawing.Size(67, 24);
            this.lblMonthButton.TabIndex = 13;
            this.lblMonthButton.Text = "Month";
            this.lblMonthButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonthButton.Click += new System.EventHandler(this.lblMonthButton_Click);
            // 
            // lblWeekButton
            // 
            this.lblWeekButton.AutoSize = true;
            this.lblWeekButton.BackColor = System.Drawing.Color.Transparent;
            this.lblWeekButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWeekButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekButton.ForeColor = System.Drawing.Color.White;
            this.lblWeekButton.Location = new System.Drawing.Point(110, 9);
            this.lblWeekButton.Name = "lblWeekButton";
            this.lblWeekButton.Size = new System.Drawing.Size(65, 24);
            this.lblWeekButton.TabIndex = 14;
            this.lblWeekButton.Text = "Week";
            this.lblWeekButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWeekButton.Click += new System.EventHandler(this.lblWeekButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Solar Edge Tracker";
            this.notifyIcon.Visible = true;
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(114, 48);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.Transparent;
            this.panelSideBar.Controls.Add(this.moveButton);
            this.panelSideBar.Controls.Add(this.refereshButton);
            this.panelSideBar.Controls.Add(this.btnConfigure);
            this.panelSideBar.Location = new System.Drawing.Point(1169, 9);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(37, 355);
            this.panelSideBar.TabIndex = 16;
            this.panelSideBar.Visible = false;
            this.panelSideBar.MouseLeave += new System.EventHandler(this.panelSideBar_MouseLeave);
            // 
            // moveButton
            // 
            this.moveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveButton.Image = global::SolarEdgeGagdet.Properties.Resources.arrow639;
            this.moveButton.Location = new System.Drawing.Point(3, 0);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(32, 32);
            this.moveButton.TabIndex = 17;
            this.moveButton.TabStop = false;
            this.moveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveIconMouseDown);
            // 
            // refereshButton
            // 
            this.refereshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refereshButton.Image = global::SolarEdgeGagdet.Properties.Resources.synchronization1;
            this.refereshButton.Location = new System.Drawing.Point(3, 36);
            this.refereshButton.Margin = new System.Windows.Forms.Padding(0);
            this.refereshButton.Name = "refereshButton";
            this.refereshButton.Size = new System.Drawing.Size(32, 32);
            this.refereshButton.TabIndex = 16;
            this.refereshButton.TabStop = false;
            this.refereshButton.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigure.Image = global::SolarEdgeGagdet.Properties.Resources.wrench1;
            this.btnConfigure.Location = new System.Drawing.Point(3, 72);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(32, 32);
            this.btnConfigure.TabIndex = 15;
            this.btnConfigure.TabStop = false;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // lblYearButton
            // 
            this.lblYearButton.AutoSize = true;
            this.lblYearButton.BackColor = System.Drawing.Color.Transparent;
            this.lblYearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblYearButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearButton.ForeColor = System.Drawing.Color.White;
            this.lblYearButton.Location = new System.Drawing.Point(338, 9);
            this.lblYearButton.Name = "lblYearButton";
            this.lblYearButton.Size = new System.Drawing.Size(53, 24);
            this.lblYearButton.TabIndex = 18;
            this.lblYearButton.Text = "Year";
            this.lblYearButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYearButton.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(865, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Solar Monitoring";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1208, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblYearButton);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.lblWeekButton);
            this.Controls.Add(this.lblMonthButton);
            this.Controls.Add(this.pnlMonth);
            this.Controls.Add(this.pnlYear);
            this.Controls.Add(this.pnlWeek);
            this.Controls.Add(this.lblLastUpdatedValue);
            this.Controls.Add(this.lblLifetimePower);
            this.Controls.Add(this.lblCurrentMonth);
            this.Controls.Add(this.lblTodayPower);
            this.Controls.Add(this.lblCurrentPower);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.lblLifeTime);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblCurrentHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.BackMost);
            this.Shown += new System.EventHandler(this.BackMost);
            this.LocationChanged += new System.EventHandler(this.BackMost);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.Move += new System.EventHandler(this.Main_Move);
            this.Resize += new System.EventHandler(this.BackMost);
            this.pnlWeek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeek)).EndInit();
            this.pnlMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonth)).EndInit();
            this.pnlYear.ResumeLayout(false);
            this.pnlYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYear)).EndInit();
            this.notifyMenu.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refereshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfigure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentHeader;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblLifeTime;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Label lblCurrentPower;
        private System.Windows.Forms.Label lblTodayPower;
        private System.Windows.Forms.Label lblCurrentMonth;
        private System.Windows.Forms.Label lblLifetimePower;
        private System.Windows.Forms.Label lblLastUpdatedValue;
        private System.Windows.Forms.Panel pnlWeek;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeek;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonth;
        private System.Windows.Forms.Panel pnlYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYear;
        private System.Windows.Forms.Label lblMonthButton;
        private System.Windows.Forms.Label lblWeekButton;
        private System.Windows.Forms.Label lblMonthNow;
        private System.Windows.Forms.Label lblYearNow;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnConfigure;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.PictureBox refereshButton;
        private System.Windows.Forms.PictureBox moveButton;
        private System.Windows.Forms.Label lblYearButton;
        private System.Windows.Forms.Label label1;
    }
}


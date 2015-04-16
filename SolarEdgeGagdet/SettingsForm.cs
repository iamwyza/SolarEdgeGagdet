using SolarEdgeGagdet.Properties;
using System;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SolarEdgeGagdet
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            tbSiteId.Text = Settings.Default.SiteId;
            tbUsername.Text = Settings.Default.Username;
            tbTolerance.Text = Settings.Default.ToleranceAdjustment.ToString();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSiteId.Text))
            {
                MessageBox.Show("Site ID cannot be empty.");
                return;
            }

            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Username Cannot Be Empty.");
                return;
            }


            if (string.IsNullOrEmpty(tbTolerance.Text))
            {

                Settings.Default.ToleranceAdjustment = 100;
            }else if (!Regex.Match(tbTolerance.Text, @"^\d+(\.\d+)?$").Success){
                MessageBox.Show("Tolerance must be a number.");
                return;
            }else
            {
                Settings.Default.ToleranceAdjustment = Convert.ToDecimal(tbTolerance.Text);
            }


            Settings.Default.SiteId = tbSiteId.Text;
            if (!string.IsNullOrEmpty(tbPassword.Text))
                Settings.Default.Password = Encryption.EncryptString(tbPassword.SecureText);

            Settings.Default.Username = tbUsername.Text;
            Settings.Default.Save();
            

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_CLick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

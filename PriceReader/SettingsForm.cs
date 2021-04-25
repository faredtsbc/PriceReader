using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceReader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtbxServer.Text = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            string displayId = ConfigurationManager.AppSettings.Get("displayId");
            switch (displayId)
            {
                case "1":
                        rdbtnSmallest.Checked = true;
                    break;
                case "2":
                    rdbtnLargest.Checked = true;
                    break;
                default:
                    rdbtnAll.Checked = true;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["con"].ConnectionString = txtbxServer.Text.Trim();
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            MessageBox.Show("تم الحفظ");
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = "0";
            if (rdbtnSmallest.Checked)
                value = "1";
            if (rdbtnLargest.Checked)
                value = "2";

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["displayId"].Value = value;
            config.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("تم الحفظ");

        }
    }
}

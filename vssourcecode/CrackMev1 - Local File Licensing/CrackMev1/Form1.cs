using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackMev1
{
    public partial class Home : Form
    {
        static LicenseKey licenseKeyPage = null;
        static string licensekey = "AVB89-QQRT6-PO34R-0023H-KKL563";

        public Home()
        {
            InitializeComponent();
        }

        private void insertLicenseKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(licenseKeyPage == null)
            {
                licenseKeyPage = new LicenseKey();
            }

            if (!LicenseKey.shown)
            {
                licenseKeyPage = new LicenseKey();
                licenseKeyPage.Show();
            }
        }

        private void aboutCrackMev1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is simple program to crack. You just need to get the license key in the file named license.key and paste the license key to validate. :)");
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (!File.Exists("validate.key"))
            {
                MessageBox.Show("You cannot start this program. Missing License Key.");
            }
            else
            {
                string validate = File.ReadAllText("validate.key");
                string license = File.ReadAllText("license.key");

                if (validate.Equals(license))
                {
                    MessageBox.Show("You have successfully start this program.");
                }
                else
                {
                    MessageBox.Show("Fail validating your license.");
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (!File.Exists("license.key"))
            {
                File.WriteAllText("license.key", licensekey);
            }
        }
    }
}

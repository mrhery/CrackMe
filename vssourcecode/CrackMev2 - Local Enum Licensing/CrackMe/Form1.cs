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

namespace CrackMe
{
    public partial class Home : Form
    {
        static LicenseKey licenseKeyPage = null;
        static string licensekey = "AVB89-QQRT6-PO34R-0023H-KKL564";

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
            MessageBox.Show("You need to Reverse Engineer this piece of program to get the License Key.");
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

                if (validate.Equals(licensekey))
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
        }
    }
}

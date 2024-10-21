using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackMe
{
    public partial class Home : Form
    {
        static LicenseKey licenseKeyPage = null;
        string url = "http://localhost/crackme-web/v4/get-key.php";

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
            MessageBox.Show("You will need to login to get the key. Use these credentials to make a request to the url or intercept this request to get the license key. Username: FakeAccount, Password: FakePassword");
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

                WebClient wb = new WebClient();

                string reqObject = "{\"username\":\""+ textUsername.Text +"\", \"password\":\""+ textPassword.Text +"\"}";

                string key = wb.UploadString(url, reqObject);

                if (validate.Equals(key))
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

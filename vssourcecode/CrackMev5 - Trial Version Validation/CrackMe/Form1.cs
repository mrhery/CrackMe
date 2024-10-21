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
        string url = "http://localhost/crackme-web/v5/get-time.php";

        public Home()
        {
            InitializeComponent();
        }

        private void aboutCrackMev1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Expiry timestamp is set from the url. You need to build a fake url to extend the time.");
        }

        private void start_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string stime = wb.DownloadString(url);

            long time = Convert.ToInt32(stime);
            
            long epochTime = (DateTime.UtcNow.Ticks - 621355968000000000) / 10000000;

            if (epochTime > time)
            {
                MessageBox.Show("License expired");
            }
            else
            {
                MessageBox.Show("Your program start successfully as trial.");
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }
    }
}

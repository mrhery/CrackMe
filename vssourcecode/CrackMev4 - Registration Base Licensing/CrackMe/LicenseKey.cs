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
    public partial class LicenseKey : Form
    {
        public static bool shown = false;

        public LicenseKey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputLicense = textLicense.Text;

            File.WriteAllText("validate.key", inputLicense);

            MessageBox.Show("License Key inserted, try start your program now.");
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            shown = true;

            if (!File.Exists("validate.key"))
            {
                File.WriteAllText("validate.key", "");
            }

            textLicense.Text = File.ReadAllText("validate.key");
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            
            shown= false;
        }

        private void LicenseKey_Load(object sender, EventArgs e)
        {
            
        }
    }
}

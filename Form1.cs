using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinIconSwap
{
    public partial class Form1 : Form
    {
        public string[] DriveOptions = new string[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "No CD Drive"
        };

        public bool DisableQA;
        public bool UsePapirus;

        public Form1()
        {
            InitializeComponent();
            CDDriveSelect.Items.AddRange(DriveOptions);
        }

        private void CDLetter_Selected(object sender, EventArgs e)
        {

        }

        private void qaEnabled_Checked(object sender, EventArgs e)
        {
            DisableQA = false;
        }

        private void qaDisabled_Checked(object sender, EventArgs e)
        {
            DisableQA = true;
        }

        private void ISPapirus(object sender, EventArgs e)
        {
            UsePapirus = true;
        }

        private void ISWindows(object sender, EventArgs e)
        {
            UsePapirus = false;
        }

        private void IconSwitcheroo(object sender, EventArgs e)
        {

        }
    }
}

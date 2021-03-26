using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Ping
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BrazhnikDA");
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Font = new Font("Microsoft Sans Serif", 15);
            label2.Location = new System.Drawing.Point(200, 54);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font("Microsoft Sans Serif", 11);
            label2.Location = new System.Drawing.Point(205, 58);
        }
    }
}


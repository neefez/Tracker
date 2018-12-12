using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OoT_Tracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ocarina_button_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (ocarina_button.ImageIndex < 2)
                        ocarina_button.ImageIndex++;
                    break;

                case MouseButtons.Right:
                    if (ocarina_button.ImageIndex > 0)
                        ocarina_button.ImageIndex--;
                    break;
            }
        }

        private void bow_button_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (bow_button.ImageIndex < 3)
                        bow_button.ImageIndex++;
                    break;

                case MouseButtons.Right:
                    if (bow_button.ImageIndex > 0)
                        bow_button.ImageIndex--;
                    break;
            }
        }

        private void bow_button_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}

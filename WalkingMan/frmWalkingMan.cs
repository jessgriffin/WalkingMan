using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// pause

using System.Threading;
namespace WalkingMan
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            int counter = 0;

            do
            {
                if (counter == 0)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk1;

                }
                else if (counter == 1)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk2;
                }
                else if (counter == 3)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk3;
                }
                else if (counter == 4)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk4;
                }
                else if (counter == 5)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk5;
                }
                else if (counter == 6)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk6;
                }
                else if (counter == 7)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk7;
                }
                else if (counter == 8)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk8;
                }
                else if (counter == 9)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk9;
                }
                else if (counter == 10)
                {
                    this.picMan.Image = WalkingMan.Properties.Resources.walk10;
                }
                counter = counter + 1;

                //pause
                this.Refresh();
                Thread.Sleep(100);

            } while (counter < 10);
        }
    }
}

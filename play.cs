using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }

        private void projet1(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int ButtonTag = Convert.ToInt32(senderObject.Tag);
            if (ButtonTag == 1)
            {
                var newform = new facile();
                newform.Show();
            }
            else if (ButtonTag == 2)
            {
                var newform = new moyen();
                newform.Show();
            }
            else if (ButtonTag == 3)
            {
                var newform = new defficile();
                newform.Show();
            }
        }
    }
}

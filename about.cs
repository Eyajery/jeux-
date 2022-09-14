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
    
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private void Loadbutton2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadRuturn(object sender, EventArgs e)
        {
            
            Form1 fmr = new Form1();
            
            fmr.Show();
            

            
        }

        
    }
}

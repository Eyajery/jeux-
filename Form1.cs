using System.Threading;
using System.Linq;
using System.Windows.Forms;
namespace menu
{
    public partial class Form1 : Form
    {
        Thread th;
        Thread th1;
        
        public Form1()
        {
            InitializeComponent();
        }
        public void openplay(object obj)
        {
            Application.Run(new Play());
        }
        public void openabout(object obj1)
        {
           
            Application.Run(new About());
        }
        private void LoadPlay(object sender, EventArgs e)
        {
            
            this.Close();
            
            th = new Thread(openplay);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();




        }

        private void LoadExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAbout(object sender, EventArgs e)
        {
            this.Close();
            
            th1 = new Thread(openabout);
            th1.SetApartmentState(ApartmentState.STA);
            th1.Start();

        }
    }
}
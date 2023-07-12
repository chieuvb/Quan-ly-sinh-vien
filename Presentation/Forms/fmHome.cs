using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class fmHome : Form
    {
        public fmHome()
        {
            InitializeComponent();
            tim = new Timer
            {
                Interval = 1000
            };
            tim.Tick += Timer_Tick;
            tim.Start();
        }

        readonly Timer tim;

        private void fmHome_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

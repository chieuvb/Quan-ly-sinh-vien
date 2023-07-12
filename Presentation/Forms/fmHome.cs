using System;
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

            int tim = DateTime.Now.Hour;
            if (tim >= 6 && tim < 11)
                lblWel.Text = "Chào buổi sáng!";
            else if (tim >= 11 && tim < 13)
                lblWel.Text = "Buổi trưa tốt lành!";
            else if (tim >= 13 && tim < 18)
                lblWel.Text = "Chào buổi chiều!";
            else if (tim >= 18 && tim < 22)
                lblWel.Text = "Buổi tối vui vẻ!";
            else
                lblWel.Text = "Chúc ngủ ngon!";
        }
    }
}

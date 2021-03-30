using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandingPage
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            GD_Form gD_Form = new GD_Form();
            this.Hide();
            gD_Form.Show();
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            DV_Form dV_Form = new DV_Form();
            this.Hide();
            dV_Form.Show();
        }
    }
}

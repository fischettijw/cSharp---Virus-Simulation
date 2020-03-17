using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp___Virus_Simulation
{
    public partial class FrmVirusSimulation : Form
    {
        public FrmVirusSimulation()
        {
            InitializeComponent();
        }

        private void FrmVirusSimulation_Load(object sender, EventArgs e)
        {
                       CusttomizeForm();
        }

        private void CusttomizeForm()
        {
            this.Hide();
            this.Text = "Coronavirus - Small Gathering Simulation";

            int clientWidth = 400;
            int clientHeight = clientWidth + 100;
            this.ClientSize = new Size(clientWidth, clientHeight);
            this.MaximizeBox = false;
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimizeBox = true;
            this.MinimumSize = new Size(this.Width, this.Height);

            this.Icon = Properties.Resources.virus_image;

            int sW = Screen.PrimaryScreen.WorkingArea.Width;
            int sH = Screen.PrimaryScreen.WorkingArea.Height;
            int fW = this.Width;
            int fH = this.Height;
            this.Location = new Point((sW - fW) / 2, (sH - fH) / 2);

            this.Show();
        }
    }
}

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
        Button[] btnRC;
        FlowLayoutPanel FlpSimualtionGrid;
        static int clientWidth = 600;
        static int clientHeight = clientWidth + 100;
        static int gridSize = 10;
        static int numberOfButtons = gridSize * gridSize;

        public FrmVirusSimulation()
        {
            InitializeComponent();
        }

        private void FrmVirusSimulation_Load(object sender, EventArgs e)
        {
            CusttomizeForm();
            CreateFlowLayoutPanel();
        }

        private void CusttomizeForm()
        {
            this.Hide();
            this.Text = "Coronavirus - Small Gathering Simulation";

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

        private void CreateFlowLayoutPanel()
        {
            FlpSimualtionGrid = new FlowLayoutPanel()
            {
                Size = new Size(clientWidth, clientWidth),
                Location = new Point(0, 0)
                         };
            this.Controls.Add(FlpSimualtionGrid);

            int btnSize = Convert.ToInt32(clientWidth /gridSize);
            btnRC = new Button[numberOfButtons];
            for (int i = 0; i < numberOfButtons; i++)
            {
                btnRC[i] = new Button()
                {
                    Size = new Size(btnSize, btnSize),
                    BackColor = Color.LightPink,
                    Margin = new Padding(0, 0, 0, 0),
                    Padding = new Padding(0, 0, 0, 0)
                };
                FlpSimualtionGrid.Controls.Add(btnRC[i]);
            }


        }
    }
}

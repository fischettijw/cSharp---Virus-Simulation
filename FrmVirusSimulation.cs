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
        Button[,] btnRC;
        Button btnSimulate;
        FlowLayoutPanel FlpSimualtionGrid;
        static int clientWidth = 600;
        static int clientHeight = clientWidth + 100;
        static int gridSize = 25;
        static int numberOfButtons = gridSize * gridSize;
        Random rnd = new Random();
        int preInfectedPer1000 = 1;

        public FrmVirusSimulation()
        {
            InitializeComponent();
        }

        private void FrmVirusSimulation_Load(object sender, EventArgs e)
        {
            CusttomizeForm();
            CreateFlowLayoutPanel();
            Simulate(preInfectedPer1000);
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

            btnSimulate = new Button()
            {
                Text = "Simulate",
                Size = new Size(200, 40),
                Location = new Point((fW - 200) / 2, clientHeight - 60),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Nightclub BTN", 14),
            };
            this.Controls.Add(btnSimulate);
            btnSimulate.Click += BtnSimulate_Click;

            this.Show();
        }

        private void BtnSimulate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                Simulate(preInfectedPer1000);
            }
        }

        private void CreateFlowLayoutPanel()
        {
            FlpSimualtionGrid = new FlowLayoutPanel()
            {
                Size = new Size(clientWidth, clientWidth),
                Location = new Point(0, 0)
            };
            this.Controls.Add(FlpSimualtionGrid);

            int btnSize = Convert.ToInt32(clientWidth / gridSize);
            btnRC = new Button[gridSize, gridSize];
            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    btnRC[r, c] = new Button()
                    {
                        Size = new Size(btnSize, btnSize),
                        //BackColor = Color.AntiqueWhite,
                        Margin = new Padding(0, 0, 0, 0),
                        Padding = new Padding(0, 0, 0, 0)
                    };
                    FlpSimualtionGrid.Controls.Add(btnRC[r, c]);
                }
            }
        }

        private void Simulate(int infectedPer1000)
        {
            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    if (rnd.Next(0, 1000) <= infectedPer1000)
                    {
                        btnRC[r, c].BackColor = Color.Red;
                    }
                    else
                    {
                        btnRC[r, c].BackColor = Color.Yellow;
                    }
                }
            }

        }
    }
}

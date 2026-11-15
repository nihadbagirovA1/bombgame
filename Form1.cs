namespace panel
{
    public partial class Form1 : Form
    {
        int xal = 0;
        Random random = new Random();
        List<Panel> paneller = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            lblXal.Text = "Xal: " + xal;
            picBomba.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPanelYarat_Click(object sender, EventArgs e)
        {
            Panel yeniPanel = new Panel();

            yeniPanel.Size = new Size(30, 30);

            yeniPanel.BackColor = Color.FromArgb(
                random.Next(256),
                random.Next(256),
                random.Next(256)
            );

            int x = random.Next(pnlOyun.ClientSize.Width - 30);
            int y = random.Next(pnlOyun.ClientSize.Height - 30);

            yeniPanel.Location = new Point(x, y);

            pnlOyun.Controls.Add(yeniPanel);

            paneller.Add(yeniPanel);

            if (yeniPanel.Bounds.IntersectsWith(picBomba.Bounds))
            {
                picBomba.Visible = true;
                picBomba.BringToFront();

                MessageBox.Show("Oyun bitdi!");
                OyunuYenidenBaslat();
                return;
            }

            xal++;
            lblXal.Text = "Xal: " + xal;
        }

        private void OyunuYenidenBaslat()
        {
            foreach (Panel panel in paneller)
            {
                pnlOyun.Controls.Remove(panel);
                panel.Dispose();
            }

            paneller.Clear();

            xal = 0;
            lblXal.Text = "Xal: " + xal;
            picBomba.Visible = false;

            int x = random.Next(pnlOyun.ClientSize.Width - picBomba.Width);
            int y = random.Next(pnlOyun.ClientSize.Height - picBomba.Height);

            picBomba.Location = new Point(x, y);

            picBomba.Visible = false;
        }

        private void btnBombaYeri_Click(object sender, EventArgs e)
        {
            int x = random.Next(pnlOyun.ClientSize.Width - picBomba.Width);
            int y = random.Next(pnlOyun.ClientSize.Height - picBomba.Height);

            picBomba.Location = new Point(x, y);
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

namespace ParkingManagementSystem
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Cars c = new Cars();
            c.TopLevel = false;
            startpnl.Controls.Add(c);
            c.BringToFront();
            c.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Parking p = new Parking();
            p.TopLevel = false;
            startpnl.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void placeslbl_Click(object sender, EventArgs e)
        {
            Places p = new Places();
            p.TopLevel = false;
            startpnl.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void llbl_Click(object sender, EventArgs e)
        {
            Login p = new Login();
            p.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cars c = new Cars();
            c.TopLevel = false;
            startpnl.Controls.Add(c);
            c.BringToFront();
            c.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Parking p = new Parking();
            p.TopLevel = false;
            startpnl.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Places p = new Places();
            p.TopLevel = false;
            startpnl.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login p = new Login();
            p.Show();
            this.Hide();
        }
    }
}

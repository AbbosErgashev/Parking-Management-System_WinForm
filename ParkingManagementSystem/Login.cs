namespace ParkingManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginUser()
        {
            if(utbl.Text == "" || ptbl.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                if(utbl.Text == "Username" && ptbl.Text == "Password")
                {
                    StartPage st = new StartPage();
                    st.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                    utbl.Text = "";
                    ptbl.Text = "";
                }
            }
        }

        private void lbtn_Click(object sender, EventArgs e)
        {
            LoginUser();
        }
    }
}

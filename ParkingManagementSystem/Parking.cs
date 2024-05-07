namespace ParkingManagementSystem
{
    public partial class Parking : Form
    {
        Functions Con;
        int Key = 0;
        public Parking()
        {
            InitializeComponent();
            Con = new Functions();
            GetCars();
            GetPlaces();
            ShowBooking();
        }

        private void GetCars()
        {
            string Query = "select * from CarsTbl";
            ccb.ValueMember = Con.GetData(Query).Columns["CNum"].ToString();
            ccb.DisplayMember = Con.GetData(Query).Columns["PNumber"].ToString();
            ccb.DataSource = Con.GetData(Query);
        }

        private void GetPlaces()
        {
            string PSt = "Free";
            string Query = "select * from PlaceTbl where PStatus='{0}'";
            Query = string.Format(Query, PSt);
            pcb.ValueMember = Con.GetData(Query).Columns["PlNum"].ToString();
            pcb.DisplayMember = Con.GetData(Query).Columns["Pposition"].ToString();
            pcb.DataSource = Con.GetData(Query);
        }

        private void Booking()
        {
            if (ccb.SelectedIndex == -1 || pcb.SelectedIndex == -1 || dtbl.Text == "" || atbl.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    string Car = ccb.SelectedValue.ToString();
                    string Duration = dtbl.Text;
                    int Amount = Convert.ToInt32(atbl.Text);
                    string Place = pcb.SelectedValue.ToString();
                    string Query = "insert into ParkingTbl values('{0}', '{1}', '{2}', '{3}', '{4}')";
                    Query = string.Format(Query, Car, System.DateTime.Today.ToString(), Duration, Amount, Place);
                    Con.SetData(Query);
                    MessageBox.Show("Place Booked");
                    ShowBooking();
                    UpdateStatus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShowBooking()
        {
            string Query = "select * from ParkingTbl";
            parkingDGV.DataSource = Con.GetData(Query);
        }

        private void UpdateStatus()
        {
            try
            {
                string PSt = "Booked";
                string Place = pcb.SelectedValue.ToString(); ;
                string Query = "update PlaceTbl set PStatus = '{0}' where PlNUm = {1}";
                Query = string.Format(Query, PSt, Place);
                Con.SetData(Query);
                MessageBox.Show("Place Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bpbtn_Click(object sender, EventArgs e)
        {
            Booking();
        }

        private void parkingDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ccb.SelectedItem = parkingDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            ccb.SelectedItem = parkingDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            atbl.Text = parkingDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtbl.Text = parkingDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (pcb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(parkingDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void RestoreBooking()
        {
            ccb.Text = "Select Car";
            pcb.Text = "Select Place";
            dtbl.Text = "";
            atbl.Text = "";
            calendar.Text = System.DateTime.Today.ToString();
        }

        private void restore_Click(object sender, EventArgs e)
        {
            RestoreBooking();
        }
    }
}

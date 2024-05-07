using System.Data.SqlClient;
using System.Data;

#nullable disable
namespace ParkingManagementSystem
{
    public partial class Cars : Form
    {
        Functions Con;
        int Key = 0;

        public Cars()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCars();
        }

        private void ShowCars()
        {
            string Query = "select * from CarsTbl";
            CarDGV.DataSource = Con.GetData(Query);
        }

        private void SaveCar()
        {
            if (pntabl.Text == "" || dtbl.Text == "" || ctbl.Text == "" || cttbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string PNumber = pntabl.Text;
                    string Driver = dtbl.Text;
                    string Gen = gcb.SelectedItem.ToString();
                    string CType = cttbl.Text;
                    string Color = ctbl.Text;
                    string Query = "insert into CarsTbl values('{0}', '{1}', '{2}', '{3}', '{4}')";
                    Query = string.Format(Query, PNumber, Driver, Gen, CType, Color);
                    Con.SetData(Query);
                    MessageBox.Show("Car Added");
                    Reset();
                    ShowCars();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateCar()
        {
            if (pntabl.Text == "" || dtbl.Text == "" || ctbl.Text == "" || cttbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string PNumber = pntabl.Text;
                    string Driver = dtbl.Text;
                    string Gen = gcb.SelectedItem.ToString();
                    string CType = cttbl.Text;
                    string Color = ctbl.Text;
                    string Query = "update CarsTbl set PNumber = '{0}', Driver='{1}', Gender='{2}', CarType='{3}', CarColor='{4}' where CNum={5}";
                    Query = string.Format(Query, PNumber, Driver, Gen, CType, Color, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Car Updated");
                    Reset();
                    ShowCars();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteCar()
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Query = "delete from CarsTbl where CNum = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Car Deleted");
                    Reset();
                    ShowCars();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            SaveCar();
        }

        private void CarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pntabl.Text = CarDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtbl.Text = CarDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            gcb.SelectedItem = CarDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            cttbl.Text = CarDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            ctbl.Text = CarDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (pntabl.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CarDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM CarsTbl ";
            query += "WHERE CNum LIKE '%' + @param + '%' ";
            query += "OR PNumber LIKE '%' + @param + '%' ";
            query += "OR Driver LIKE '%' + @param + '%' ";
            query += "OR Gender LIKE '%' + @param + '%' ";
            query += "OR CarType LIKE '%' + @param + '%' ";
            query += "OR CarColor LIKE '%' + @param + '%'";
            string con = "Data Source=ACER;Initial Catalog=ParkingLotDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", searchtbl.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        CarDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void Reset()
        {
            pntabl.Text = "";
            dtbl.Text = "";
            gcb.Text = "Gender";
            cttbl.Text = "";
            ctbl.Text = "";
        }

        private void RestoreFilter()
        {
            searchtbl.Text = "";
            ShowCars();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdateCar();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeleteCar();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void searchtbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            RestoreFilter();
        }
    }
}

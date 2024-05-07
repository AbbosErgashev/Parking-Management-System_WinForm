using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace ParkingManagementSystem
{
    public partial class Places : Form
    {

        int Key = 0;
        Functions Con;

        public Places()
        {
            InitializeComponent();
            Con = new Functions();
            ShowPlaces();
        }

        private void ShowPlaces()
        {
            string Query = "select * from PlaceTbl";
            PlaceDGV.DataSource = Con.GetData(Query);
        }

        private void SavePlace()
        {
            if (ptbl.Text == "" || scb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Positoin = ptbl.Text;
                    string Status = scb.SelectedItem.ToString();
                    string Query = "insert into PlaceTbl values('{0}', '{1}')";
                    Query = string.Format(Query, Positoin, Status);
                    Con.SetData(Query);
                    MessageBox.Show("Place Added");
                    Reset();
                    ShowPlaces();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdatePlace()
        {
            if (ptbl.Text == "" || scb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Position = ptbl.Text;
                    string Status = scb.SelectedItem.ToString();
                    string Query = "update PlaceTbl set Pposition = '{0}', PStatus='{1}' where PlNum={2}";
                    Query = string.Format(Query, Position, Status, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Place Updated");
                    Reset();
                    ShowPlaces();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeletePlace()
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Query = "delete from PlaceTbl where PlNum = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Place Deleted");
                    Reset();
                    ShowPlaces();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private DataTable AllSearch()
        {
            string query = "SELECT * FROM PlaceTbl ";
            query += "WHERE PlNum LIKE '%' + @param + '%' ";
            query += "OR Pposition LIKE '%' + @param + '%' ";
            query += "OR PStatus LIKE '%' + @param + '%' ";
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
                        PlaceDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void Reset()
        {
            ptbl.Text = "";
            scb.Text = "Status";
        }

        private void RestoreFilter()
        {
            searchtbl.Text = "";
            ShowPlaces();
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

        private void PlaceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ptbl.Text = PlaceDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            scb.SelectedItem = PlaceDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (ptbl.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PlaceDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void sbtn_Click_1(object sender, EventArgs e)
        {
            SavePlace();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdatePlace();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeletePlace();
        }

        private void resetbtn_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void Restore_Click_1(object sender, EventArgs e)
        {
            RestoreFilter();
        }

        private void searchtbl_TextChanged_1(object sender, EventArgs e)
        {
            AllSearch();
        }
    }
}

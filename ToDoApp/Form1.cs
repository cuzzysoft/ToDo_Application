using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoApp
{
    public partial class ToDoApp : Form
    {
        DataAccessDb db = new DataAccessDb();

        //usp_todoapp
        public ToDoApp()
        {
            InitializeComponent();
        }
        private void setColumnSize()
        {
            dvg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[0].Width = 100; // Set a fixed width for column 0.

            dvg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[1].Width = 80; // Set a fixed width for column 0.

            dvg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[2].Width = 200; // Set a fixed width for column 0.

            dvg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[3].Width = 200; // Set a fixed width for column 0.

            dvg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[4].Width = 120; // Set a fixed width for column 0.

            dvg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[6].Width = 100; // Set a fixed width for column 0.

            comboBox.SelectedIndex = 0;

        }
        private void ToDoApp_Load(object sender, EventArgs e)
        {
            LoadData();
            setColumnSize();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
            LoadData();
        }
        private void LoadData()
        {
            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //chk.Name = "Chk";
            //chk.HeaderText = "Check";





            //DataGridViewButtonColumn col_update = new DataGridViewButtonColumn();
            //col_update.Name = "Edit";
            //col_update.Text = "Edit";
            //col_update.UseColumnTextForButtonValue = true;
            //DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();// Set the background color for the button cells
            //cellStyle.BackColor = Color.Blue;
            //col_update.DefaultCellStyle = cellStyle;


            //DataGridViewButtonColumn col_delete = new DataGridViewButtonColumn();
            //col_delete.Name = "Delete";
            //col_delete.Text = "Delete";
            //col_delete.UseColumnTextForButtonValue = true;

            string sql = "usp_todoapp '','','','','','VIEW'";
            DataSet ds = db.fillDataset(sql);
            dvg.Columns.Clear();
           // dvg.Columns.Add(chk);
            //dvg.Columns.Add(col_update);

            dvg.DataSource = ds.Tables[0];
           // dvg.Columns.Add(col_update);
        }
        private void UpdateData(string _id)
        {
            string sql = "usp_todoapp '','','','','','UPDATE'";
            DataSet ds = db.fillDataset(sql);
        }
        private void DeleteData(string _id)
        {
            string sql = "usp_todoapp '','','','','','DELETE'";
            DataSet ds = db.fillDataset(sql);
        }
        private void AddData()
        {
            if (txtTitle.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            string sql = "usp_todoapp '','" + txtTitle.Text + "','" + dateTimePicker.Value + "','N','" + txtDescription.Text + "','ADD'";
            DataSet ds = db.fillDataset(sql);
        }

        private void dvg_CellContentClick(object sender, DataGridViewCellCancelEventArgs e)
        {
            //MessageBox.Show("ok");
            dvg.EndEdit();
            try
            {
                if (bool.Parse(dvg["chk", e.RowIndex].Value.ToString()) == true)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void dvg_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dvg.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = dvg.SelectedRows[0];

        //        // Access cell values using cell indexes or column names
        //        string column2Value = selectedRow.Cells["Id"].Value.ToString(); // Using column name
        //        MessageBox.Show(column2Value);
        //    }
        //}






        private void button1_Click(object sender, EventArgs e)
        {
            if (dvg.SelectedCells.Count > 0)
            {
                int rowIndex = dvg.SelectedCells[0].RowIndex;

                // Access cell values using cell indexes or column names
                string column1Value = dvg.Rows[rowIndex].Cells[1].Value.ToString(); // Assuming column 0
                string column2Value = dvg.Rows[rowIndex].Cells["Id"].Value.ToString(); // Using column name
                MessageBox.Show(column2Value);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
   
    }
    public class DataAccessDb
    {
        public DataSet fillDataset(string sql)
        {
            DataSet dset = new DataSet();
            SqlConnection sqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=ToDoAppDB;Trusted_Connection=True");
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dset);
            return dset;
        }
    }

}
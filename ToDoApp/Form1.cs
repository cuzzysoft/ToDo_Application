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

        DataGridViewButtonColumn col_edit;
        DataGridViewCheckBoxColumn chk;

        //usp_todoapp
        public ToDoApp()
        {
            InitializeComponent();
        }
        private void setColumnSize()
        {
            dvg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[0].Width = 80; // Set a fixed width for column 0.

            dvg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[1].Width = 100; // Set a fixed width for column 0.

            dvg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[2].Width = 200; // Set a fixed width for column 0.

            dvg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[3].Width = 200; // Set a fixed width for column 0.

            dvg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[4].Width = 120; // Set a fixed width for column 0.

            dvg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[6].Width = 100; // Set a fixed width for column 0.

            comboBox.SelectedIndex = 0;
            completed.SelectedIndex = 0;
        }
        private void ToDoApp_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
            Reset();
        }
        private void LoadData()
        {
            chk = new DataGridViewCheckBoxColumn();
            chk.Name = "Chk";
            chk.HeaderText = "Check";

            col_edit = new DataGridViewButtonColumn();
            col_edit.Name = "Edit";
            col_edit.Text = "Edit";
            col_edit.UseColumnTextForButtonValue = true;

            string sql = "usp_todoapp '','','','','','VIEW'";
            DataSet ds = db.fillDataset(sql);
            dvg.Columns.Clear();
            dvg.Columns.Add(chk);
            dvg.DataSource = ds.Tables[0];

            dvg.Columns.Add(col_edit);
            setColumnSize();
        }


        private void AddData()
        {
            if (txtTitle.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }

            string sql = "usp_todoapp '','" + txtTitle.Text + "','" + dateTimePicker.Value + "','" + completed.SelectedItem.ToString() + "','" + txtDescription.Text + "','ADD'";
            DataSet ds = db.fillDataset(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "")
            {
                MessageBox.Show("Select record to update");
                return;
            }
            string sql = "usp_todoapp '" + txtid.Text + "','" + txtTitle.Text + "','" + dateTimePicker.Value + "','" + completed.SelectedItem.ToString() + "','" + txtDescription.Text + "','UPDATE'";
            DataSet ds = db.fillDataset(sql);
            Reset();
            MessageBox.Show("Information updated successfully");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        List<string> checkedIn = new List<string>();


        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvg.EndEdit();
            try
            {
                if (e.ColumnIndex == 0)
                {
                    string? comp = dvg["Chk", e.RowIndex].Value.ToString();
                    string? id = dvg["Id", e.RowIndex].Value.ToString();
                    if (comp == "True")
                    {
                        checkedIn.Add(id);
                    }
                    else
                    {
                        if (checkedIn.Contains(id))
                        {
                            checkedIn.Remove(id);
                        }
                    }
                }
                if (e.ColumnIndex == col_edit.Index)
                {
                    string? id = dvg["Id", e.RowIndex].Value.ToString();
                    string? title = dvg["Title", e.RowIndex].Value.ToString();
                    string? descr = dvg["Description", e.RowIndex].Value.ToString();
                    string? date = dvg["Date", e.RowIndex].Value.ToString();
                    string? comp = dvg["Completed", e.RowIndex].Value.ToString();
                    txtid.Text = id;
                    txtTitle.Text = title;
                    txtDescription.Text = descr;
                    dateTimePicker.Value = DateTime.Parse(date);
                    completed.SelectedItem = comp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtDescription.Text = "";
            txtid.Text = "";
            txtTitle.Text = "";
            dateTimePicker.Value = DateTime.Now;
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedIn.Count == 0)
            {
                MessageBox.Show("Select record(s) to delete");
                return;
            }
            foreach (string element in checkedIn)
            {
                string sql = "usp_todoapp '" + element + "','','','','','DELETE'";
                DataSet ds = db.fillDataset(sql);
            }

            Reset();
            MessageBox.Show("Information deleted successfully");
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
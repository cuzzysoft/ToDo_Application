using System.Data;
using ToDoApp.Services.Repository;
using ToDoApp.Model;
using ToDoApp.Services.Interface;

namespace ToDoApp
{
    public partial class ToDoApp : Form
    {

        DataGridViewButtonColumn? col_edit;
        DataGridViewCheckBoxColumn? chk;
        IServiceClass service_interface; //Instance of IService interface
        //usp_todoapp
        public ToDoApp(IServiceClass _service_interface)
        {
            InitializeComponent();
            service_interface = _service_interface;
        }
        private void setColumnSize()
        {
            // Set a fixed width for the desired column.
            dvg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[0].Width = 80;

            dvg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[1].Width = 100;

            dvg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[2].Width = 200;

            dvg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[3].Width = 200;

            dvg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[4].Width = 120;

            dvg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dvg.Columns[6].Width = 100;

            comboBox.SelectedIndex = 0;
            completed.SelectedIndex = 0;
        }
        private void ToDoApp_Load(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                MessageBox.Show("Unable to save. Update instead", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTitle.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Create new ToDoItemModel instance and add to database
            ToDoItemModel itemModel = new ToDoItemModel()
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                Completed = completed.SelectedItem.ToString(),
                Date = dateTimePicker.Value
            };
            service_interface.AddData(itemModel);
            Reset();
        }

        private void LoadData(bool firstload)
        {
            if (firstload)//if loading for the first time
            {
                //Creating new instance of check button to (DataGridViewCheckBoxColumn)
                chk = new DataGridViewCheckBoxColumn();
                chk.Name = "Chk";
                chk.HeaderText = "Check";

                //Creating new instance of edit button (DataGridViewButtonColumn)
                col_edit = new DataGridViewButtonColumn();
                col_edit.Name = "Edit";
                col_edit.Text = "Edit";
                col_edit.UseColumnTextForButtonValue = true;

            }
            DataSet ds = service_interface.GetAllRecords();
            dvg.Columns.Clear();
            dvg.Columns.Add(chk);
            dvg.DataSource = ds.Tables[0];
            dvg.Columns.Add(col_edit);
            setColumnSize();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "")
            {
                MessageBox.Show("Select record to update", "No record selected",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //Create new instance of ToDoItemModel and update with ID
            ToDoItemModel itemModel = new ToDoItemModel()
            {
                Id = int.Parse(txtid.Text),
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                Completed = completed.SelectedItem.ToString(),
                Date = dateTimePicker.Value
            };
            service_interface.UpdateData(itemModel);
            Reset();
            MessageBox.Show("Information updated successfully");
        }


        List<string> checkedIDs = new List<string>();


        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvg.EndEdit();
            try
            {
                if (e.ColumnIndex == 0)
                {
                    //If checkbox is clicked
                    string? comp = dvg["Chk", e.RowIndex].Value.ToString();
                    string? id = dvg["Id", e.RowIndex].Value.ToString();
                    if (comp == "True")
                    {
                        checkedIDs.Add(id);
                    }
                    else
                    {
                        if (checkedIDs.Contains(id))
                        {
                            checkedIDs.Remove(id);
                        }
                    }
                    ResetOnly();
                }
                if (e.ColumnIndex == col_edit.Index)
                {
                    //If update button is clicked
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
        void ResetOnly()
        {
            //Reset all fields to empty
            textBox1.Text = "";
            txtDescription.Text = "";
            txtid.Text = "";
            txtTitle.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }
        private void Reset()
        {
            ResetOnly();

            LoadData(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedIDs.Count == 0)
            {
                MessageBox.Show("Select record(s) to delete","No records selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Delete data
            DialogResult d = MessageBox.Show("Do you want to delete the selected records?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                service_interface.DeleteData(checkedIDs);
                Reset();
                MessageBox.Show("Information deleted successfully","Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            string search = textBox1.Text;
            if (search == "")
            {
                LoadData(false);
            }
            else
            {
                string? search_criteria = comboBox.SelectedIndex == 0 ? "TITLE" : "DATE";
                DataSet ds = service_interface.Search(search, search_criteria);
                dvg.DataSource = ds.Tables[0];
            }

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
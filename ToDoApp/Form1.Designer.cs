namespace ToDoApp
{
    partial class ToDoApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtid = new Label();
            completed = new ComboBox();
            label = new Label();
            panel4 = new Panel();
            btnreset = new Button();
            btndelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            panel2 = new Panel();
            dvg = new DataGridView();
            panel3 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            comboBox = new ComboBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvg).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(completed);
            panel1.Controls.Add(label);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(txtTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 193);
            panel1.TabIndex = 0;
            // 
            // txtid
            // 
            txtid.AutoSize = true;
            txtid.Location = new Point(880, 155);
            txtid.Name = "txtid";
            txtid.Size = new Size(59, 25);
            txtid.TabIndex = 9;
            txtid.Text = "label5";
            txtid.Visible = false;
            // 
            // completed
            // 
            completed.DropDownStyle = ComboBoxStyle.DropDownList;
            completed.FormattingEnabled = true;
            completed.Items.AddRange(new object[] { "NO", "YES" });
            completed.Location = new Point(865, 92);
            completed.Name = "completed";
            completed.Size = new Size(142, 33);
            completed.TabIndex = 3;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(865, 49);
            label.Name = "label";
            label.Size = new Size(100, 25);
            label.TabIndex = 8;
            label.Text = "Completed";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnreset);
            panel4.Controls.Add(btndelete);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnAdd);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1044, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(164, 193);
            panel4.TabIndex = 7;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(15, 142);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(137, 34);
            btnreset.TabIndex = 9;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(15, 96);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(140, 37);
            btndelete.TabIndex = 8;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += button2_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(15, 53);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 37);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 46);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 5;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 92);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 37);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 3;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(527, 43);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(300, 31);
            dateTimePicker.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(129, 92);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(698, 84);
            txtDescription.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(129, 34);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(279, 31);
            txtTitle.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(dvg);
            panel2.Location = new Point(0, 260);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(3);
            panel2.Size = new Size(1208, 394);
            panel2.TabIndex = 1;
            // 
            // dvg
            // 
            dvg.AllowUserToAddRows = false;
            dvg.AllowUserToDeleteRows = false;
            dvg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Location = new Point(3, 3);
            dvg.Name = "dvg";
            dvg.RowHeadersWidth = 62;
            dvg.RowTemplate.Height = 33;
            dvg.Size = new Size(1202, 388);
            dvg.TabIndex = 0;
            dvg.CellContentClick += dvg_CellContentClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(3, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(1205, 55);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(comboBox);
            panel5.Controls.Add(textBox1);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(706, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(497, 53);
            panel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 11);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 2;
            label4.Text = "Search:";
            // 
            // comboBox
            // 
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "By Title", "By Date" });
            comboBox.Location = new Point(114, 8);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(142, 33);
            comboBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 31);
            textBox1.TabIndex = 0;
            // 
            // ToDoApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 654);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ToDoApp";
            Text = "ToDoApp";
            Load += ToDoApp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvg).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dvg;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private Button btnAdd;
        private Panel panel4;
        private Button btndelete;
        private Button btnUpdate;
        private Panel panel3;
        private Panel panel5;
        private TextBox textBox1;
        private ComboBox comboBox;
        private Label label4;
        private ComboBox completed;
        private Label label;
        private Label txtid;
        private Button btnreset;
    }
}
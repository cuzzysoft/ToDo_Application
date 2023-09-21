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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoApp));
            panel1 = new Panel();
            panel6 = new Panel();
            label5 = new Label();
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
            panel6.SuspendLayout();
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
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel6);
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
            panel1.Size = new Size(1208, 252);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.Controls.Add(label5);
            panel6.Location = new Point(3, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(1205, 52);
            panel6.TabIndex = 10;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Goudy Stout", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.InactiveBorder;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(1205, 52);
            label5.TabIndex = 0;
            label5.Text = "TO DO LIST";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtid
            // 
            txtid.AutoSize = true;
            txtid.Location = new Point(879, 61);
            txtid.Name = "txtid";
            txtid.Size = new Size(0, 25);
            txtid.TabIndex = 9;
            txtid.Visible = false;
            // 
            // completed
            // 
            completed.DropDownStyle = ComboBoxStyle.DropDownList;
            completed.FormattingEnabled = true;
            completed.Items.AddRange(new object[] { "NO", "YES" });
            completed.Location = new Point(860, 195);
            completed.Name = "completed";
            completed.Size = new Size(142, 33);
            completed.TabIndex = 3;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = SystemColors.Window;
            label.Location = new Point(859, 167);
            label.Name = "label";
            label.Size = new Size(104, 25);
            label.TabIndex = 8;
            label.Text = "Completed";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Controls.Add(btnreset);
            panel4.Controls.Add(btndelete);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnAdd);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1044, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(164, 252);
            panel4.TabIndex = 7;
            // 
            // btnreset
            // 
            btnreset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnreset.Image = (Image)resources.GetObject("btnreset.Image");
            btnreset.ImageAlign = ContentAlignment.MiddleLeft;
            btnreset.Location = new Point(12, 207);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(137, 34);
            btnreset.TabIndex = 9;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Image = (Image)resources.GetObject("btndelete.Image");
            btndelete.ImageAlign = ContentAlignment.MiddleLeft;
            btndelete.Location = new Point(12, 161);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(140, 37);
            btndelete.TabIndex = 8;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += button2_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(12, 118);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 37);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(12, 77);
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
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(467, 89);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 5;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(16, 144);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(74, 89);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 3;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(522, 86);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(300, 31);
            dateTimePicker.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(124, 144);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(698, 84);
            txtDescription.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(124, 86);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(279, 31);
            txtTitle.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(dvg);
            panel2.Location = new Point(0, 319);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(3);
            panel2.Size = new Size(1208, 428);
            panel2.TabIndex = 1;
            // 
            // dvg
            // 
            dvg.AllowUserToAddRows = false;
            dvg.AllowUserToDeleteRows = false;
            dvg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg.Location = new Point(3, 6);
            dvg.Name = "dvg";
            dvg.RowHeadersWidth = 62;
            dvg.RowTemplate.Height = 33;
            dvg.Size = new Size(1202, 419);
            dvg.TabIndex = 0;
            dvg.CellContentClick += dvg_CellContentClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(0, 258);
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
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyUp += textBox1_KeyUp;
            textBox1.MouseEnter += textBox1_MouseEnter;
            // 
            // ToDoApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 747);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ToDoApp";
            Text = "ToDoApp";
            Load += ToDoApp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
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
        private Panel panel6;
        private Label label5;
    }
}
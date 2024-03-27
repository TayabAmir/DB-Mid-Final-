namespace MidProject
{
    partial class ManageStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudent));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dGV1 = new System.Windows.Forms.DataGridView();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lookupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.stuManageDataSet2 = new MidProject.StuManageDataSet2();
			this.stuManageDataSet = new MidProject.StuManageDataSet();
			this.lookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lookupTableAdapter = new MidProject.StuManageDataSetTableAdapters.LookupTableAdapter();
			this.lookupTableAdapter1 = new MidProject.StuManageDataSet2TableAdapters.LookupTableAdapter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stuManageDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stuManageDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(576, 80);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(576, 155);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(500, 226);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Registration Number";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(895, 79);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Contact";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(895, 160);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 21);
			this.label5.TabIndex = 4;
			this.label5.Text = "Email";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(895, 225);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 21);
			this.label6.TabIndex = 5;
			this.label6.Text = "Status";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(680, 80);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(101, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(680, 156);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(101, 20);
			this.textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(680, 226);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(101, 20);
			this.textBox3.TabIndex = 8;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(976, 78);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(96, 20);
			this.textBox4.TabIndex = 9;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(976, 158);
			this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(149, 20);
			this.textBox5.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(611, 284);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 35);
			this.button1.TabIndex = 12;
			this.button1.Text = "Add Student";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Yellow;
			this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(899, 284);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(151, 35);
			this.button2.TabIndex = 13;
			this.button2.Text = "Mark Attendance";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Red;
			this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(301, 583);
			this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 35);
			this.button3.TabIndex = 14;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Yellow;
			this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(742, 583);
			this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(74, 35);
			this.button4.TabIndex = 15;
			this.button4.Text = "Update";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// dGV1
			// 
			this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV1.Location = new System.Drawing.Point(244, 339);
			this.dGV1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dGV1.Name = "dGV1";
			this.dGV1.RowHeadersWidth = 51;
			this.dGV1.RowTemplate.Height = 24;
			this.dGV1.Size = new System.Drawing.Size(712, 240);
			this.dGV1.TabIndex = 17;
			this.dGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellContentClick);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.LinkColor = System.Drawing.Color.White;
			this.linkLabel2.Location = new System.Drawing.Point(542, 16);
			this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(35, 13);
			this.linkLabel2.TabIndex = 18;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Home";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(517, 423);
			this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(8, 20);
			this.textBox7.TabIndex = 19;
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lookupBindingSource1, "Name", true));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "InActive"});
			this.comboBox1.Location = new System.Drawing.Point(976, 223);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(92, 21);
			this.comboBox1.TabIndex = 20;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// lookupBindingSource1
			// 
			this.lookupBindingSource1.DataMember = "Lookup";
			this.lookupBindingSource1.DataSource = this.stuManageDataSet2;
			// 
			// stuManageDataSet2
			// 
			this.stuManageDataSet2.DataSetName = "StuManageDataSet2";
			this.stuManageDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// stuManageDataSet
			// 
			this.stuManageDataSet.DataSetName = "StuManageDataSet";
			this.stuManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lookupBindingSource
			// 
			this.lookupBindingSource.DataMember = "Lookup";
			this.lookupBindingSource.DataSource = this.stuManageDataSet;
			// 
			// lookupTableAdapter
			// 
			this.lookupTableAdapter.ClearBeforeFill = true;
			// 
			// lookupTableAdapter1
			// 
			this.lookupTableAdapter1.ClearBeforeFill = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGreen;
			this.panel1.Controls.Add(this.label7);
			this.panel1.Location = new System.Drawing.Point(-2, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1148, 61);
			this.panel1.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(560, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(184, 25);
			this.label7.TabIndex = 0;
			this.label7.Text = "Manage Student";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkGreen;
			this.panel2.Controls.Add(this.linkLabel2);
			this.panel2.Location = new System.Drawing.Point(90, 623);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1056, 46);
			this.panel2.TabIndex = 22;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(145, 80);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(350, 224);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// ManageStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGreen;
			this.ClientSize = new System.Drawing.Size(1144, 661);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dGV1);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ManageStudent";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.ManageStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stuManageDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stuManageDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private StuManageDataSet stuManageDataSet;
        private System.Windows.Forms.BindingSource lookupBindingSource;
        private StuManageDataSetTableAdapters.LookupTableAdapter lookupTableAdapter;
        private StuManageDataSet2 stuManageDataSet2;
        private System.Windows.Forms.BindingSource lookupBindingSource1;
        private StuManageDataSet2TableAdapters.LookupTableAdapter lookupTableAdapter1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
	}
}
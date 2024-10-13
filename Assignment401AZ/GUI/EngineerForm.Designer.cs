namespace Assignment401AZ.GUI
{
    partial class EngineerForm
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
            ADD = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            txtEngineerID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtTel = new TextBox();
            txtAddressID = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ADD
            // 
            ADD.Location = new Point(332, 289);
            ADD.Name = "ADD";
            ADD.Size = new Size(137, 43);
            ADD.TabIndex = 0;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(651, 289);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(137, 43);
            DELETE.TabIndex = 1;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(492, 289);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(137, 43);
            UPDATE.TabIndex = 2;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 81);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "EngineerID :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 122);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "FirstName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 166);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "LastName :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 210);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Dateofbirth :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 260);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 8;
            label5.Text = "Tel :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 303);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 9;
            label6.Text = "AddressID :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(294, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(547, 239);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtEngineerID
            // 
            txtEngineerID.Location = new Point(128, 73);
            txtEngineerID.Name = "txtEngineerID";
            txtEngineerID.Size = new Size(126, 23);
            txtEngineerID.TabIndex = 11;
            txtEngineerID.TextChanged += textBox1_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(128, 114);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(126, 23);
            txtFirstName.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(128, 158);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(126, 23);
            txtLastName.TabIndex = 13;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(128, 252);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(126, 23);
            txtTel.TabIndex = 14;
            // 
            // txtAddressID
            // 
            txtAddressID.Location = new Point(128, 295);
            txtAddressID.Name = "txtAddressID";
            txtAddressID.Size = new Size(126, 23);
            txtAddressID.TabIndex = 15;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(128, 204);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(126, 23);
            dateTimePickerDOB.TabIndex = 16;
            // 
            // EngineerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 389);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(txtAddressID);
            Controls.Add(txtTel);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEngineerID);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(ADD);
            Name = "EngineerForm";
            Text = "Engineer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ADD;
        private Button DELETE;
        private Button UPDATE;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private TextBox txtEngineerID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtTel;
        private TextBox txtAddressID;
        private DateTimePicker dateTimePickerDOB;
    }
}
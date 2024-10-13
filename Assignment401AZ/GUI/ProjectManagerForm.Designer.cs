namespace Assignment401AZ.GUI
{
    partial class ProjectManagerForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            EmailAddress = new Label();
            ADD = new Button();
            GO_TO_PROJECTFILES = new Button();
            DELETE = new Button();
            UPDATE = new Button();
            txtManagerID = new TextBox();
            txtTel = new TextBox();
            txtLastName = new TextBox();
            txtFirstname = new TextBox();
            txtEmailAddress = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(384, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(463, 282);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 105);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "ManagerID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 149);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "FirstName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 200);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 3;
            label3.Text = "LastName :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 253);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 4;
            label4.Text = "Dateofbirth :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 296);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 5;
            label5.Text = "Tel :";
            // 
            // EmailAddress
            // 
            EmailAddress.AutoSize = true;
            EmailAddress.Location = new Point(48, 341);
            EmailAddress.Name = "EmailAddress";
            EmailAddress.Size = new Size(84, 15);
            EmailAddress.TabIndex = 6;
            EmailAddress.Text = "EmailAddress :";
            // 
            // ADD
            // 
            ADD.Location = new Point(384, 334);
            ADD.Name = "ADD";
            ADD.Size = new Size(117, 38);
            ADD.TabIndex = 7;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += button1_Click;
            // 
            // GO_TO_PROJECTFILES
            // 
            GO_TO_PROJECTFILES.Location = new Point(542, 414);
            GO_TO_PROJECTFILES.Name = "GO_TO_PROJECTFILES";
            GO_TO_PROJECTFILES.Size = new Size(117, 38);
            GO_TO_PROJECTFILES.TabIndex = 9;
            GO_TO_PROJECTFILES.Text = "Go to ProjectFiles";
            GO_TO_PROJECTFILES.UseVisualStyleBackColor = true;
            GO_TO_PROJECTFILES.Click += button3_Click;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(694, 334);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(117, 38);
            DELETE.TabIndex = 10;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += button4_Click;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(542, 334);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(117, 38);
            UPDATE.TabIndex = 11;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            // 
            // txtManagerID
            // 
            txtManagerID.Location = new Point(151, 102);
            txtManagerID.Name = "txtManagerID";
            txtManagerID.Size = new Size(167, 23);
            txtManagerID.TabIndex = 12;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(151, 288);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(167, 23);
            txtTel.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(151, 192);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(167, 23);
            txtLastName.TabIndex = 14;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(151, 146);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(167, 23);
            txtFirstname.TabIndex = 15;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(151, 338);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(167, 23);
            txtEmailAddress.TabIndex = 16;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(151, 247);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(171, 23);
            dateTimePickerDOB.TabIndex = 17;
            // 
            // ProjectManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 492);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtFirstname);
            Controls.Add(txtLastName);
            Controls.Add(txtTel);
            Controls.Add(txtManagerID);
            Controls.Add(UPDATE);
            Controls.Add(DELETE);
            Controls.Add(GO_TO_PROJECTFILES);
            Controls.Add(ADD);
            Controls.Add(EmailAddress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ProjectManagerForm";
            Text = "ProjectManagerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label EmailAddress;
        private Button ADD;
        private Button GO_TO_PROJECTFILES;
        private Button DELETE;
        private Button UPDATE;
        private TextBox txtManagerID;
        private TextBox txtTel;
        private TextBox txtLastName;
        private TextBox txtFirstname;
        private TextBox txtEmailAddress;
        private DateTimePicker dateTimePickerDOB;
    }
}
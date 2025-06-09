namespace Assignment_10._1
{
    partial class Form1
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
            lblId = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblGPA = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtGPA = new TextBox();
            btnJSONdeser = new Button();
            btnJSONser = new Button();
            btnXMLser = new Button();
            btnXMLdeser = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(195, 41);
            lblId.Name = "lblId";
            lblId.Size = new Size(62, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Student ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(195, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Student Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(195, 107);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(93, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Student Address";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(195, 142);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(73, 15);
            lblGPA.TabIndex = 3;
            lblGPA.Text = "Student GPA";
            lblGPA.TextAlign = ContentAlignment.TopRight;
            lblGPA.UseMnemonic = false;
            lblGPA.Click += label2_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(337, 37);
            txtID.Name = "txtID";
            txtID.Size = new Size(145, 23);
            txtID.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(337, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(145, 23);
            txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(337, 104);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(145, 23);
            txtAddress.TabIndex = 6;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(337, 142);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(145, 23);
            txtGPA.TabIndex = 7;
            // 
            // btnJSONdeser
            // 
            btnJSONdeser.Location = new Point(428, 249);
            btnJSONdeser.Name = "btnJSONdeser";
            btnJSONdeser.Size = new Size(93, 40);
            btnJSONdeser.TabIndex = 8;
            btnJSONdeser.Text = "JSON DeSerialize";
            btnJSONdeser.UseVisualStyleBackColor = true;
            btnJSONdeser.Click += btnJSONdeser_Click;
            // 
            // btnJSONser
            // 
            btnJSONser.Location = new Point(233, 249);
            btnJSONser.Name = "btnJSONser";
            btnJSONser.Size = new Size(92, 40);
            btnJSONser.TabIndex = 9;
            btnJSONser.Text = "JSON Serialize";
            btnJSONser.UseVisualStyleBackColor = true;
            btnJSONser.Click += btnJSONser_Click;
            // 
            // btnXMLser
            // 
            btnXMLser.Location = new Point(233, 309);
            btnXMLser.Name = "btnXMLser";
            btnXMLser.Size = new Size(93, 40);
            btnXMLser.TabIndex = 10;
            btnXMLser.Text = "XML Serialize";
            btnXMLser.UseVisualStyleBackColor = true;
            btnXMLser.Click += btnXMLser_Click;
            // 
            // btnXMLdeser
            // 
            btnXMLdeser.Location = new Point(428, 309);
            btnXMLdeser.Name = "btnXMLdeser";
            btnXMLdeser.Size = new Size(93, 40);
            btnXMLdeser.TabIndex = 11;
            btnXMLdeser.Text = "XML DeSerialize";
            btnXMLdeser.UseVisualStyleBackColor = true;
            btnXMLdeser.Click += btnXMLdeser_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(337, 197);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(92, 40);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create Student";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(btnXMLdeser);
            Controls.Add(btnXMLser);
            Controls.Add(btnJSONser);
            Controls.Add(btnJSONdeser);
            Controls.Add(txtGPA);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblGPA);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblAddress;
        private Label lblGPA;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtGPA;
        private Button btnJSONdeser;
        private Button btnJSONser;
        private Button btnXMLser;
        private Button btnXMLdeser;
        private Button btnCreate;
    }
}

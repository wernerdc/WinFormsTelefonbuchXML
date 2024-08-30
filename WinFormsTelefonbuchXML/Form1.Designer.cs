namespace WinFormsTelefonbuchXML
{
    partial class WindowsFormsTelefonbuch
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
            btnLoad = new Button();
            btnSave = new Button();
            btnExit = new Button();
            btnDeletePerson = new Button();
            btnAddPerson = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxName = new TextBox();
            textBoxForename = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnDeletePerson);
            panel1.Controls.Add(btnAddPerson);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxPhone);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxForename);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 159);
            panel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Enabled = false;
            btnLoad.Location = new Point(291, 104);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(122, 23);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Laden";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(419, 103);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Speichern";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(547, 103);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(122, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Location = new Point(547, 74);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(122, 23);
            btnDeletePerson.TabIndex = 9;
            btnDeletePerson.Text = "Person löschen";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Click += btnDeletePerson_Click;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(547, 45);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(122, 23);
            btnAddPerson.TabIndex = 8;
            btnAddPerson.Text = "Person hinzufügen";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 27);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 27);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 27);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Vorname";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(419, 45);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(122, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(291, 45);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(122, 23);
            textBoxPhone.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(163, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(122, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxForename
            // 
            textBoxForename.Location = new Point(35, 45);
            textBoxForename.Name = "textBoxForename";
            textBoxForename.Size = new Size(122, 23);
            textBoxForename.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(718, 202);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // WindowsFormsTelefonbuch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 361);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "WindowsFormsTelefonbuch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinFormsTelefonbuchXML";
            FormClosing += WindowsFormsTelefonbuch_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox textBoxForename;
        private Button btnDeletePerson;
        private Button btnAddPerson;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private Button btnLoad;
        private Button btnSave;
        private Button btnExit;
    }
}

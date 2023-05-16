namespace FileHandler
{
    partial class MainForm
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
            txtSystemDetails = new TextBox();
            cboSytemDrives = new ComboBox();
            label1 = new Label();
            txtNewDirectory = new TextBox();
            btnCreateDirectory = new Button();
            btnSubDirectory = new Button();
            txtSubDirectory = new TextBox();
            label2 = new Label();
            btnListFiles = new Button();
            lblListFiles = new Label();
            cboListFiles = new ComboBox();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            txtDestination = new TextBox();
            lblSource = new Label();
            lblDestination = new Label();
            txtSource = new TextBox();
            btnCopy = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSystemDetails
            // 
            txtSystemDetails.Location = new Point(8, 42);
            txtSystemDetails.Margin = new Padding(2, 2, 2, 2);
            txtSystemDetails.Multiline = true;
            txtSystemDetails.Name = "txtSystemDetails";
            txtSystemDetails.Size = new Size(329, 222);
            txtSystemDetails.TabIndex = 0;
            // 
            // cboSytemDrives
            // 
            cboSytemDrives.FormattingEnabled = true;
            cboSytemDrives.Location = new Point(8, 7);
            cboSytemDrives.Margin = new Padding(2, 2, 2, 2);
            cboSytemDrives.Name = "cboSytemDrives";
            cboSytemDrives.Size = new Size(329, 23);
            cboSytemDrives.TabIndex = 1;
            cboSytemDrives.SelectedIndexChanged += cboSytemDrives_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(372, 13);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 2;
            label1.Text = "New Directory (Include Path)";
            // 
            // txtNewDirectory
            // 
            txtNewDirectory.Location = new Point(547, 10);
            txtNewDirectory.Name = "txtNewDirectory";
            txtNewDirectory.Size = new Size(265, 23);
            txtNewDirectory.TabIndex = 3;
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.Location = new Point(818, 9);
            btnCreateDirectory.Name = "btnCreateDirectory";
            btnCreateDirectory.Size = new Size(133, 23);
            btnCreateDirectory.TabIndex = 4;
            btnCreateDirectory.Text = "Create Directory";
            btnCreateDirectory.UseVisualStyleBackColor = true;
            btnCreateDirectory.Click += btnCreateDirectory_Click;
            // 
            // btnSubDirectory
            // 
            btnSubDirectory.Location = new Point(818, 41);
            btnSubDirectory.Name = "btnSubDirectory";
            btnSubDirectory.Size = new Size(133, 23);
            btnSubDirectory.TabIndex = 7;
            btnSubDirectory.Text = "Create Sub-Directory";
            btnSubDirectory.UseVisualStyleBackColor = true;
            btnSubDirectory.Click += btnSubDirectory_Click;
            // 
            // txtSubDirectory
            // 
            txtSubDirectory.Location = new Point(547, 42);
            txtSubDirectory.Name = "txtSubDirectory";
            txtSubDirectory.Size = new Size(265, 23);
            txtSubDirectory.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(402, 45);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 5;
            label2.Text = "New Sub-Directory";
            // 
            // btnListFiles
            // 
            btnListFiles.Location = new Point(818, 81);
            btnListFiles.Name = "btnListFiles";
            btnListFiles.Size = new Size(133, 23);
            btnListFiles.TabIndex = 10;
            btnListFiles.Text = "ver archivos";
            btnListFiles.UseVisualStyleBackColor = true;
            btnListFiles.Click += btnListFiles_Click;
            // 
            // lblListFiles
            // 
            lblListFiles.AutoSize = true;
            lblListFiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblListFiles.Location = new Point(388, 85);
            lblListFiles.Name = "lblListFiles";
            lblListFiles.Size = new Size(153, 15);
            lblListFiles.TabIndex = 8;
            lblListFiles.Text = "Listado archivos directorio";
            // 
            // cboListFiles
            // 
            cboListFiles.FormattingEnabled = true;
            cboListFiles.Location = new Point(547, 82);
            cboListFiles.Name = "cboListFiles";
            cboListFiles.Size = new Size(265, 23);
            cboListFiles.TabIndex = 11;
            cboListFiles.SelectedIndexChanged += cboListFiles_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDestination);
            panel1.Controls.Add(lblSource);
            panel1.Controls.Add(lblDestination);
            panel1.Controls.Add(txtSource);
            panel1.Controls.Add(btnCopy);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(344, 115);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 147);
            panel1.TabIndex = 12;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(202, 89);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(265, 23);
            txtDestination.TabIndex = 18;
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSource.Location = new Point(13, 58);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(46, 15);
            lblSource.TabIndex = 17;
            lblSource.Text = "Source";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestination.Location = new Point(13, 92);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(71, 15);
            lblDestination.TabIndex = 16;
            lblDestination.Text = "Destination";
            // 
            // txtSource
            // 
            txtSource.Location = new Point(202, 56);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(265, 23);
            txtSource.TabIndex = 15;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(475, 56);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(133, 52);
            btnCopy.TabIndex = 14;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(243, 7);
            label3.Name = "label3";
            label3.Size = new Size(170, 30);
            label3.TabIndex = 13;
            label3.Text = "Copy Directory";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 270);
            Controls.Add(panel1);
            Controls.Add(cboListFiles);
            Controls.Add(btnListFiles);
            Controls.Add(lblListFiles);
            Controls.Add(btnSubDirectory);
            Controls.Add(txtSubDirectory);
            Controls.Add(label2);
            Controls.Add(btnCreateDirectory);
            Controls.Add(txtNewDirectory);
            Controls.Add(label1);
            Controls.Add(cboSytemDrives);
            Controls.Add(txtSystemDetails);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "File Handler";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSystemDetails;
        private ComboBox cboSytemDrives;
        private Label label1;
        private TextBox txtNewDirectory;
        private Button btnCreateDirectory;
        private Button btnSubDirectory;
        private TextBox txtSubDirectory;
        private Label label2;
        private Button btnListFiles;
        private Label lblListFiles;
        private ComboBox cboListFiles;
        private ColorDialog colorDialog1;
        private Panel panel1;
        private Label label3;
        private TextBox txtDestination;
        private Label lblSource;
        private Label lblDestination;
        private TextBox txtSource;
        private Button btnCopy;
    }
}
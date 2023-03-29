namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeptid = new System.Windows.Forms.TextBox();
            this.txtDeptname = new System.Windows.Forms.TextBox();
            this.txtLoaction = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreatefolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deptid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deptname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // txtDeptid
            // 
            this.txtDeptid.Location = new System.Drawing.Point(268, 62);
            this.txtDeptid.Name = "txtDeptid";
            this.txtDeptid.Size = new System.Drawing.Size(100, 20);
            this.txtDeptid.TabIndex = 3;
            // 
            // txtDeptname
            // 
            this.txtDeptname.Location = new System.Drawing.Point(268, 102);
            this.txtDeptname.Name = "txtDeptname";
            this.txtDeptname.Size = new System.Drawing.Size(100, 20);
            this.txtDeptname.TabIndex = 4;
            // 
            // txtLoaction
            // 
            this.txtLoaction.Location = new System.Drawing.Point(268, 147);
            this.txtLoaction.Name = "txtLoaction";
            this.txtLoaction.Size = new System.Drawing.Size(100, 20);
            this.txtLoaction.TabIndex = 5;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(173, 212);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 23);
            this.btnwrite.TabIndex = 6;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(293, 212);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreatefolder
            // 
            this.btnCreatefolder.Location = new System.Drawing.Point(467, 74);
            this.btnCreatefolder.Name = "btnCreatefolder";
            this.btnCreatefolder.Size = new System.Drawing.Size(75, 23);
            this.btnCreatefolder.TabIndex = 8;
            this.btnCreatefolder.Text = "Create folder";
            this.btnCreatefolder.UseVisualStyleBackColor = true;
            this.btnCreatefolder.Click += new System.EventHandler(this.btnCreatefolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(467, 119);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreatefolder);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtLoaction);
            this.Controls.Add(this.txtDeptname);
            this.Controls.Add(this.txtDeptid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeptid;
        private System.Windows.Forms.TextBox txtDeptname;
        private System.Windows.Forms.TextBox txtLoaction;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreatefolder;
        private System.Windows.Forms.Button btnCreateFile;
    }
}
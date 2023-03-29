namespace WindowsFormsApp1
{
    partial class Form4
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
            this.txtLoaction = new System.Windows.Forms.TextBox();
            this.txtDeptname = new System.Windows.Forms.TextBox();
            this.txtDeptid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBinarywrite = new System.Windows.Forms.Button();
            this.btnBinaryread = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoaction
            // 
            this.txtLoaction.Location = new System.Drawing.Point(316, 178);
            this.txtLoaction.Name = "txtLoaction";
            this.txtLoaction.Size = new System.Drawing.Size(100, 20);
            this.txtLoaction.TabIndex = 15;
            // 
            // txtDeptname
            // 
            this.txtDeptname.Location = new System.Drawing.Point(316, 122);
            this.txtDeptname.Name = "txtDeptname";
            this.txtDeptname.Size = new System.Drawing.Size(100, 20);
            this.txtDeptname.TabIndex = 14;
            // 
            // txtDeptid
            // 
            this.txtDeptid.Location = new System.Drawing.Point(316, 76);
            this.txtDeptid.Name = "txtDeptid";
            this.txtDeptid.Size = new System.Drawing.Size(100, 20);
            this.txtDeptid.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Location";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Deptname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Deptid";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBinarywrite
            // 
            this.btnBinarywrite.Location = new System.Drawing.Point(199, 246);
            this.btnBinarywrite.Name = "btnBinarywrite";
            this.btnBinarywrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinarywrite.TabIndex = 20;
            this.btnBinarywrite.Text = "Binary Write";
            this.btnBinarywrite.UseVisualStyleBackColor = true;
            this.btnBinarywrite.Click += new System.EventHandler(this.btnBinarywrite_Click);
            // 
            // btnBinaryread
            // 
            this.btnBinaryread.Location = new System.Drawing.Point(316, 246);
            this.btnBinaryread.Name = "btnBinaryread";
            this.btnBinaryread.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryread.TabIndex = 21;
            this.btnBinaryread.Text = "BinaryRead";
            this.btnBinaryread.UseVisualStyleBackColor = true;
            this.btnBinaryread.Click += new System.EventHandler(this.btnBinaryread_Click);
            // 
            // btnxmlread
            // 
            this.btnxmlread.Location = new System.Drawing.Point(316, 301);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(75, 23);
            this.btnxmlread.TabIndex = 22;
            this.btnxmlread.Text = "XMLread";
            this.btnxmlread.UseVisualStyleBackColor = true;
            this.btnxmlread.Click += new System.EventHandler(this.btnxmlread_Click);
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Location = new System.Drawing.Point(199, 301);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(75, 23);
            this.btnxmlwrite.TabIndex = 23;
            this.btnxmlwrite.Text = "XMLwrite";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            this.btnxmlwrite.Click += new System.EventHandler(this.btnxmlwrite_Click);
            // 
            // btnsoapread
            // 
            this.btnsoapread.Location = new System.Drawing.Point(316, 357);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(75, 23);
            this.btnsoapread.TabIndex = 24;
            this.btnsoapread.Text = "SoapRead";
            this.btnsoapread.UseVisualStyleBackColor = true;
            this.btnsoapread.Click += new System.EventHandler(this.btnsoapread_Click);
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(199, 357);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(75, 23);
            this.btnsoapwrite.TabIndex = 25;
            this.btnsoapwrite.Text = "SoapWrite";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(199, 415);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(75, 23);
            this.btnjsonwrite.TabIndex = 26;
            this.btnjsonwrite.Text = "JSON Write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(316, 415);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(75, 23);
            this.btnjsonread.TabIndex = 27;
            this.btnjsonread.Text = "JSON Read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            this.btnjsonread.Click += new System.EventHandler(this.btnjsonread_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnBinaryread);
            this.Controls.Add(this.btnBinarywrite);
            this.Controls.Add(this.txtLoaction);
            this.Controls.Add(this.txtDeptname);
            this.Controls.Add(this.txtDeptid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLoaction;
        private System.Windows.Forms.TextBox txtDeptname;
        private System.Windows.Forms.TextBox txtDeptid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBinarywrite;
        private System.Windows.Forms.Button btnBinaryread;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsonread;
    }
}
namespace WindowsFormsApp1
{
    partial class Form7
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
            this.btnjsonread = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnBinaryread = new System.Windows.Forms.Button();
            this.btnBinarywrite = new System.Windows.Forms.Button();
            this.txtpercentage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(410, 383);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(75, 23);
            this.btnjsonread.TabIndex = 55;
            this.btnjsonread.Text = "JSON Read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            this.btnjsonread.Click += new System.EventHandler(this.btnjsonread_Click);
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(293, 383);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(75, 23);
            this.btnjsonwrite.TabIndex = 54;
            this.btnjsonwrite.Text = "JSON Write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(293, 325);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(75, 23);
            this.btnsoapwrite.TabIndex = 53;
            this.btnsoapwrite.Text = "SoapWrite";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // btnsoapread
            // 
            this.btnsoapread.Location = new System.Drawing.Point(410, 325);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(75, 23);
            this.btnsoapread.TabIndex = 52;
            this.btnsoapread.Text = "SoapRead";
            this.btnsoapread.UseVisualStyleBackColor = true;
            this.btnsoapread.Click += new System.EventHandler(this.btnsoapread_Click);
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Location = new System.Drawing.Point(293, 269);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(75, 23);
            this.btnxmlwrite.TabIndex = 51;
            this.btnxmlwrite.Text = "XMLwrite";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            this.btnxmlwrite.Click += new System.EventHandler(this.btnxmlwrite_Click);
            // 
            // btnxmlread
            // 
            this.btnxmlread.Location = new System.Drawing.Point(410, 269);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(75, 23);
            this.btnxmlread.TabIndex = 50;
            this.btnxmlread.Text = "XMLread";
            this.btnxmlread.UseVisualStyleBackColor = true;
            this.btnxmlread.Click += new System.EventHandler(this.btnxmlread_Click);
            // 
            // btnBinaryread
            // 
            this.btnBinaryread.Location = new System.Drawing.Point(410, 214);
            this.btnBinaryread.Name = "btnBinaryread";
            this.btnBinaryread.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryread.TabIndex = 49;
            this.btnBinaryread.Text = "BinaryRead";
            this.btnBinaryread.UseVisualStyleBackColor = true;
            this.btnBinaryread.Click += new System.EventHandler(this.btnBinaryread_Click);
            // 
            // btnBinarywrite
            // 
            this.btnBinarywrite.Location = new System.Drawing.Point(293, 214);
            this.btnBinarywrite.Name = "btnBinarywrite";
            this.btnBinarywrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinarywrite.TabIndex = 48;
            this.btnBinarywrite.Text = "Binary Write";
            this.btnBinarywrite.UseVisualStyleBackColor = true;
            this.btnBinarywrite.Click += new System.EventHandler(this.btnBinarywrite_Click);
            // 
            // txtpercentage
            // 
            this.txtpercentage.Location = new System.Drawing.Point(410, 146);
            this.txtpercentage.Name = "txtpercentage";
            this.txtpercentage.Size = new System.Drawing.Size(100, 20);
            this.txtpercentage.TabIndex = 47;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(410, 90);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 46;
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(410, 44);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(100, 20);
            this.txtrollno.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Roll No";
            // 
            // Form7
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
            this.Controls.Add(this.txtpercentage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnjsonread;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnBinaryread;
        private System.Windows.Forms.Button btnBinarywrite;
        private System.Windows.Forms.TextBox txtpercentage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
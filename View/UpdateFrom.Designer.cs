namespace View
{
    partial class UpdateFrom
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPersonUpdate = new System.Windows.Forms.Button();
            this.txtUpdateIdPerson = new System.Windows.Forms.TextBox();
            this.txtUpdateFname = new System.Windows.Forms.TextBox();
            this.txtUpdateLname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPersonUpdate
            // 
            this.btnPersonUpdate.Location = new System.Drawing.Point(217, 181);
            this.btnPersonUpdate.Name = "btnPersonUpdate";
            this.btnPersonUpdate.Size = new System.Drawing.Size(111, 23);
            this.btnPersonUpdate.TabIndex = 1;
            this.btnPersonUpdate.Text = "Person Update";
            this.btnPersonUpdate.UseVisualStyleBackColor = true;
            this.btnPersonUpdate.Click += new System.EventHandler(this.btnPersonUpdate_Click);
            // 
            // txtUpdateIdPerson
            // 
            this.txtUpdateIdPerson.Location = new System.Drawing.Point(172, 69);
            this.txtUpdateIdPerson.Name = "txtUpdateIdPerson";
            this.txtUpdateIdPerson.Size = new System.Drawing.Size(202, 23);
            this.txtUpdateIdPerson.TabIndex = 2;
            // 
            // txtUpdateFname
            // 
            this.txtUpdateFname.Location = new System.Drawing.Point(172, 98);
            this.txtUpdateFname.Name = "txtUpdateFname";
            this.txtUpdateFname.Size = new System.Drawing.Size(202, 23);
            this.txtUpdateFname.TabIndex = 3;
            // 
            // txtUpdateLname
            // 
            this.txtUpdateLname.Location = new System.Drawing.Point(172, 129);
            this.txtUpdateLname.Name = "txtUpdateLname";
            this.txtUpdateLname.Size = new System.Drawing.Size(202, 23);
            this.txtUpdateLname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "FirstName :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "LastName :";
            // 
            // UpdateFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(453, 248);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateLname);
            this.Controls.Add(this.txtUpdateFname);
            this.Controls.Add(this.txtUpdateIdPerson);
            this.Controls.Add(this.btnPersonUpdate);
            this.Controls.Add(this.btnClose);
            this.Name = "UpdateFrom";
            this.Text = "Update From";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button btnPersonUpdate;
        private TextBox txtUpdateIdPerson;
        private TextBox txtUpdateFname;
        private TextBox txtUpdateLname;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
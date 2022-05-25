namespace Keyper
{
    partial class ModifyWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyWindow));
            this.txtboxPersonId = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxPersonId
            // 
            this.txtboxPersonId.BackColor = System.Drawing.Color.Silver;
            this.txtboxPersonId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxPersonId.ForeColor = System.Drawing.Color.Black;
            this.txtboxPersonId.Location = new System.Drawing.Point(84, 5);
            this.txtboxPersonId.Name = "txtboxPersonId";
            this.txtboxPersonId.Size = new System.Drawing.Size(200, 20);
            this.txtboxPersonId.TabIndex = 4;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.BackColor = System.Drawing.Color.Silver;
            this.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxPassword.ForeColor = System.Drawing.Color.Black;
            this.txtboxPassword.Location = new System.Drawing.Point(84, 31);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(200, 20);
            this.txtboxPassword.TabIndex = 7;
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.BackColor = System.Drawing.Color.Silver;
            this.txtboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxDescription.ForeColor = System.Drawing.Color.Black;
            this.txtboxDescription.Location = new System.Drawing.Point(84, 57);
            this.txtboxDescription.Multiline = true;
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(200, 100);
            this.txtboxDescription.TabIndex = 8;
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Location = new System.Drawing.Point(12, 8);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(49, 13);
            this.lblPersonId.TabIndex = 9;
            this.lblPersonId.Text = "PersonId";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 34);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Silver;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.ForeColor = System.Drawing.Color.Black;
            this.btnModify.Location = new System.Drawing.Point(19, 103);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(46, 27);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // ModifyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(296, 169);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxPersonId);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModifyWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxPersonId;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnModify;
    }
}
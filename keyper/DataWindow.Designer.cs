namespace Keyper
{
    partial class DataWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataWindow));
            this.datagrid1 = new System.Windows.Forms.DataGridView();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnModifyAccount = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblRefreshed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid1
            // 
            this.datagrid1.BackgroundColor = System.Drawing.Color.Silver;
            this.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.GridColor = System.Drawing.Color.Silver;
            this.datagrid1.Location = new System.Drawing.Point(12, 12);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.Size = new System.Drawing.Size(776, 383);
            this.datagrid1.TabIndex = 0;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Silver;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.Location = new System.Drawing.Point(273, 401);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(78, 23);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAccount.Location = new System.Drawing.Point(357, 401);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Delete account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnModifyAccount
            // 
            this.btnModifyAccount.BackColor = System.Drawing.Color.Silver;
            this.btnModifyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyAccount.ForeColor = System.Drawing.Color.Black;
            this.btnModifyAccount.Location = new System.Drawing.Point(453, 401);
            this.btnModifyAccount.Name = "btnModifyAccount";
            this.btnModifyAccount.Size = new System.Drawing.Size(92, 23);
            this.btnModifyAccount.TabIndex = 3;
            this.btnModifyAccount.Text = "Modify account";
            this.btnModifyAccount.UseVisualStyleBackColor = false;
            this.btnModifyAccount.Click += new System.EventHandler(this.btnModifyAccount_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Silver;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(646, 401);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblRefreshed
            // 
            this.lblRefreshed.AutoSize = true;
            this.lblRefreshed.ForeColor = System.Drawing.Color.White;
            this.lblRefreshed.Location = new System.Drawing.Point(727, 406);
            this.lblRefreshed.Name = "lblRefreshed";
            this.lblRefreshed.Size = new System.Drawing.Size(0, 13);
            this.lblRefreshed.TabIndex = 5;
            // 
            // DataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.lblRefreshed);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModifyAccount);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.datagrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DataWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataWindow_FormClosing);
            this.Load += new System.EventHandler(this.Window2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid1;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnModifyAccount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRefreshed;
    }
}
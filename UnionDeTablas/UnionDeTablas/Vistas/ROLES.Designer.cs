namespace UnionDeTablas.Vistas
{
    partial class ROLES
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dtvRoles = new System.Windows.Forms.DataGridView();
            this.liklblMenu = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(577, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SALIR";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dtvRoles
            // 
            this.dtvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvRoles.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRoles.Location = new System.Drawing.Point(27, 86);
            this.dtvRoles.Name = "dtvRoles";
            this.dtvRoles.Size = new System.Drawing.Size(565, 235);
            this.dtvRoles.TabIndex = 15;
            // 
            // liklblMenu
            // 
            this.liklblMenu.ActiveLinkColor = System.Drawing.Color.Gray;
            this.liklblMenu.AutoSize = true;
            this.liklblMenu.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liklblMenu.LinkColor = System.Drawing.Color.Black;
            this.liklblMenu.Location = new System.Drawing.Point(533, 9);
            this.liklblMenu.Name = "liklblMenu";
            this.liklblMenu.Size = new System.Drawing.Size(38, 15);
            this.liklblMenu.TabIndex = 24;
            this.liklblMenu.TabStop = true;
            this.liklblMenu.Text = "MENU";
            this.liklblMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liklblMenu_LinkClicked);
            // 
            // ROLES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 339);
            this.Controls.Add(this.liklblMenu);
            this.Controls.Add(this.dtvRoles);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ROLES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROLES";
            this.Load += new System.EventHandler(this.ROLES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dtvRoles;
        private System.Windows.Forms.LinkLabel liklblMenu;
    }
}
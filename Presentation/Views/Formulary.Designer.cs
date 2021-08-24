
namespace Presentation.Views
{
    partial class Formulary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulary));
            this.SidenavContainer = new System.Windows.Forms.Panel();
            this.PasswordTxt = new System.Windows.Forms.Label();
            this.SignoutBtn = new System.Windows.Forms.PictureBox();
            this.UsernameTxt = new System.Windows.Forms.Label();
            this.SidenavPicture = new System.Windows.Forms.PictureBox();
            this.SeeCarnetsBtn = new System.Windows.Forms.Button();
            this.CreateCarnetBtn = new System.Windows.Forms.Button();
            this.FormularyContainer = new System.Windows.Forms.Panel();
            this.SidenavContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignoutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidenavPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SidenavContainer
            // 
            this.SidenavContainer.BackColor = System.Drawing.Color.White;
            this.SidenavContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidenavContainer.Controls.Add(this.PasswordTxt);
            this.SidenavContainer.Controls.Add(this.SignoutBtn);
            this.SidenavContainer.Controls.Add(this.UsernameTxt);
            this.SidenavContainer.Controls.Add(this.SidenavPicture);
            this.SidenavContainer.Controls.Add(this.SeeCarnetsBtn);
            this.SidenavContainer.Controls.Add(this.CreateCarnetBtn);
            this.SidenavContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidenavContainer.ForeColor = System.Drawing.Color.Black;
            this.SidenavContainer.Location = new System.Drawing.Point(0, 0);
            this.SidenavContainer.Name = "SidenavContainer";
            this.SidenavContainer.Size = new System.Drawing.Size(200, 729);
            this.SidenavContainer.TabIndex = 0;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.AutoSize = true;
            this.PasswordTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordTxt.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTxt.Location = new System.Drawing.Point(18, 623);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(76, 15);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.Text = "Contraseña:";
            this.PasswordTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignoutBtn
            // 
            this.SignoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("SignoutBtn.Image")));
            this.SignoutBtn.Location = new System.Drawing.Point(18, 667);
            this.SignoutBtn.Name = "SignoutBtn";
            this.SignoutBtn.Size = new System.Drawing.Size(56, 47);
            this.SignoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignoutBtn.TabIndex = 4;
            this.SignoutBtn.TabStop = false;
            this.SignoutBtn.Click += new System.EventHandler(this.SignoutBtn_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTxt.AutoSize = true;
            this.UsernameTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsernameTxt.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTxt.Location = new System.Drawing.Point(18, 584);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(56, 15);
            this.UsernameTxt.TabIndex = 0;
            this.UsernameTxt.Text = "Usuario:";
            this.UsernameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidenavPicture
            // 
            this.SidenavPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SidenavPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SidenavPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SidenavPicture.Image = ((System.Drawing.Image)(resources.GetObject("SidenavPicture.Image")));
            this.SidenavPicture.Location = new System.Drawing.Point(11, 3);
            this.SidenavPicture.Name = "SidenavPicture";
            this.SidenavPicture.Size = new System.Drawing.Size(179, 122);
            this.SidenavPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SidenavPicture.TabIndex = 3;
            this.SidenavPicture.TabStop = false;
            // 
            // SeeCarnetsBtn
            // 
            this.SeeCarnetsBtn.AutoEllipsis = true;
            this.SeeCarnetsBtn.BackColor = System.Drawing.Color.Navy;
            this.SeeCarnetsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeeCarnetsBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SeeCarnetsBtn.FlatAppearance.BorderSize = 0;
            this.SeeCarnetsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.SeeCarnetsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.SeeCarnetsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeeCarnetsBtn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SeeCarnetsBtn.ForeColor = System.Drawing.Color.White;
            this.SeeCarnetsBtn.Location = new System.Drawing.Point(-1, 177);
            this.SeeCarnetsBtn.Name = "SeeCarnetsBtn";
            this.SeeCarnetsBtn.Size = new System.Drawing.Size(200, 40);
            this.SeeCarnetsBtn.TabIndex = 2;
            this.SeeCarnetsBtn.Text = "Ver carnets";
            this.SeeCarnetsBtn.UseVisualStyleBackColor = false;
            this.SeeCarnetsBtn.Click += new System.EventHandler(this.SeeCarnetBtn_Click);
            // 
            // CreateCarnetBtn
            // 
            this.CreateCarnetBtn.AutoEllipsis = true;
            this.CreateCarnetBtn.BackColor = System.Drawing.Color.Navy;
            this.CreateCarnetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateCarnetBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateCarnetBtn.FlatAppearance.BorderSize = 0;
            this.CreateCarnetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.CreateCarnetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.CreateCarnetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCarnetBtn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateCarnetBtn.ForeColor = System.Drawing.Color.White;
            this.CreateCarnetBtn.Location = new System.Drawing.Point(-1, 131);
            this.CreateCarnetBtn.Name = "CreateCarnetBtn";
            this.CreateCarnetBtn.Size = new System.Drawing.Size(200, 40);
            this.CreateCarnetBtn.TabIndex = 1;
            this.CreateCarnetBtn.Text = "Crear carnet";
            this.CreateCarnetBtn.UseVisualStyleBackColor = false;
            this.CreateCarnetBtn.Click += new System.EventHandler(this.CreateCarnetBtn_Click);
            // 
            // FormularyContainer
            // 
            this.FormularyContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormularyContainer.Location = new System.Drawing.Point(197, 0);
            this.FormularyContainer.Name = "FormularyContainer";
            this.FormularyContainer.Size = new System.Drawing.Size(1156, 729);
            this.FormularyContainer.TabIndex = 0;
            // 
            // Formulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(39)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.FormularyContainer);
            this.Controls.Add(this.SidenavContainer);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Formulary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.SidenavContainer.ResumeLayout(false);
            this.SidenavContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignoutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidenavPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidenavContainer;
        private System.Windows.Forms.Button CreateCarnetBtn;
        private System.Windows.Forms.Button SeeCarnetsBtn;
        private System.Windows.Forms.Panel FormularyContainer;
        private System.Windows.Forms.PictureBox SidenavPicture;
        private System.Windows.Forms.Label UsernameTxt;
        private System.Windows.Forms.PictureBox SignoutBtn;
        private System.Windows.Forms.Label PasswordTxt;
    }
}
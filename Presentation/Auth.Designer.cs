
namespace Presentation
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.LoginContainer = new System.Windows.Forms.Panel();
            this.Container = new System.Windows.Forms.Panel();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.SigninTitle = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.MessageTxt = new System.Windows.Forms.Label();
            this.SigninBtn = new System.Windows.Forms.Button();
            this.LoginContainer.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginContainer
            // 
            this.LoginContainer.Controls.Add(this.SigninBtn);
            this.LoginContainer.Controls.Add(this.MessageTxt);
            this.LoginContainer.Controls.Add(this.PasswordTxt);
            this.LoginContainer.Controls.Add(this.UsernameTxt);
            this.LoginContainer.Controls.Add(this.SigninTitle);
            this.LoginContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginContainer.Location = new System.Drawing.Point(0, 0);
            this.LoginContainer.MaximumSize = new System.Drawing.Size(345, 381);
            this.LoginContainer.Name = "LoginContainer";
            this.LoginContainer.Size = new System.Drawing.Size(345, 381);
            this.LoginContainer.TabIndex = 0;
            // 
            // Container
            // 
            this.Container.Controls.Add(this.Picture);
            this.Container.Dock = System.Windows.Forms.DockStyle.Right;
            this.Container.Location = new System.Drawing.Point(342, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(422, 381);
            this.Container.TabIndex = 0;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.White;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(422, 381);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // SigninTitle
            // 
            this.SigninTitle.AutoSize = true;
            this.SigninTitle.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SigninTitle.Location = new System.Drawing.Point(116, 24);
            this.SigninTitle.Name = "SigninTitle";
            this.SigninTitle.Size = new System.Drawing.Size(107, 40);
            this.SigninTitle.TabIndex = 0;
            this.SigninTitle.Text = "Signin";
            this.SigninTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTxt.Location = new System.Drawing.Point(70, 111);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.PlaceholderText = "Usuario";
            this.UsernameTxt.Size = new System.Drawing.Size(200, 23);
            this.UsernameTxt.TabIndex = 1;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.Location = new System.Drawing.Point(70, 179);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PlaceholderText = "Contraseña";
            this.PasswordTxt.Size = new System.Drawing.Size(200, 23);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // MessageTxt
            // 
            this.MessageTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTxt.AutoSize = true;
            this.MessageTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MessageTxt.Location = new System.Drawing.Point(96, 226);
            this.MessageTxt.MaximumSize = new System.Drawing.Size(160, 0);
            this.MessageTxt.Name = "MessageTxt";
            this.MessageTxt.Size = new System.Drawing.Size(56, 15);
            this.MessageTxt.TabIndex = 0;
            this.MessageTxt.Text = "Message:";
            this.MessageTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MessageTxt.Visible = false;
            // 
            // SigninBtn
            // 
            this.SigninBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SigninBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SigninBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SigninBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SigninBtn.FlatAppearance.BorderSize = 2;
            this.SigninBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.SigninBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SigninBtn.Location = new System.Drawing.Point(118, 284);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.Size = new System.Drawing.Size(95, 31);
            this.SigninBtn.TabIndex = 3;
            this.SigninBtn.Text = "Signin";
            this.SigninBtn.UseVisualStyleBackColor = true;
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(764, 381);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.LoginContainer);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.LoginContainer.ResumeLayout(false);
            this.LoginContainer.PerformLayout();
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginContainer;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label MessageTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label SigninTitle;
        private System.Windows.Forms.Button SigninBtn;
    }
}


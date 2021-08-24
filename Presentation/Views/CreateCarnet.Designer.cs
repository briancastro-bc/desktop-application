
namespace Presentation.Views
{
    partial class CreateCarnet
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
            this.Title = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.LastnameTxt = new System.Windows.Forms.TextBox();
            this.PhoneTxt = new System.Windows.Forms.TextBox();
            this.GenderTxt = new System.Windows.Forms.TextBox();
            this.RoleTxt = new System.Windows.Forms.TextBox();
            this.IdTypeTxt = new System.Windows.Forms.ComboBox();
            this.IdNumberTxt = new System.Windows.Forms.TextBox();
            this.RhTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.FooterContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(463, 78);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(212, 45);
            this.Title.TabIndex = 0;
            this.Title.Text = "Crear carnet";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameTxt
            // 
            this.NameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxt.Location = new System.Drawing.Point(134, 167);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PlaceholderText = "Name";
            this.NameTxt.Size = new System.Drawing.Size(200, 23);
            this.NameTxt.TabIndex = 1;
            // 
            // LastnameTxt
            // 
            this.LastnameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastnameTxt.Location = new System.Drawing.Point(465, 167);
            this.LastnameTxt.Name = "LastnameTxt";
            this.LastnameTxt.PlaceholderText = "Lastname";
            this.LastnameTxt.Size = new System.Drawing.Size(200, 23);
            this.LastnameTxt.TabIndex = 2;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneTxt.Location = new System.Drawing.Point(771, 167);
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.PlaceholderText = "Phone";
            this.PhoneTxt.Size = new System.Drawing.Size(200, 23);
            this.PhoneTxt.TabIndex = 3;
            // 
            // GenderTxt
            // 
            this.GenderTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenderTxt.Location = new System.Drawing.Point(134, 258);
            this.GenderTxt.Name = "GenderTxt";
            this.GenderTxt.PlaceholderText = "Gender";
            this.GenderTxt.Size = new System.Drawing.Size(200, 23);
            this.GenderTxt.TabIndex = 4;
            // 
            // RoleTxt
            // 
            this.RoleTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoleTxt.Location = new System.Drawing.Point(465, 258);
            this.RoleTxt.Name = "RoleTxt";
            this.RoleTxt.PlaceholderText = "Role";
            this.RoleTxt.Size = new System.Drawing.Size(200, 23);
            this.RoleTxt.TabIndex = 5;
            // 
            // IdTypeTxt
            // 
            this.IdTypeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTypeTxt.DisplayMember = "Selecciona";
            this.IdTypeTxt.FormattingEnabled = true;
            this.IdTypeTxt.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.IdTypeTxt.Location = new System.Drawing.Point(771, 257);
            this.IdTypeTxt.Name = "IdTypeTxt";
            this.IdTypeTxt.Size = new System.Drawing.Size(200, 23);
            this.IdTypeTxt.TabIndex = 7;
            this.IdTypeTxt.ValueMember = "Selecciona";
            // 
            // IdNumberTxt
            // 
            this.IdNumberTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdNumberTxt.Location = new System.Drawing.Point(313, 351);
            this.IdNumberTxt.Name = "IdNumberTxt";
            this.IdNumberTxt.PlaceholderText = "ID Number";
            this.IdNumberTxt.Size = new System.Drawing.Size(200, 23);
            this.IdNumberTxt.TabIndex = 8;
            // 
            // RhTxt
            // 
            this.RhTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RhTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RhTxt.Location = new System.Drawing.Point(616, 351);
            this.RhTxt.Name = "RhTxt";
            this.RhTxt.PlaceholderText = "RH";
            this.RhTxt.Size = new System.Drawing.Size(200, 23);
            this.RhTxt.TabIndex = 9;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            this.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(384, 429);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(351, 50);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FooterContainer
            // 
            this.FooterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.FooterContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FooterContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterContainer.Location = new System.Drawing.Point(0, 488);
            this.FooterContainer.Name = "FooterContainer";
            this.FooterContainer.Size = new System.Drawing.Size(1151, 71);
            this.FooterContainer.TabIndex = 0;
            // 
            // CreateCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1151, 559);
            this.Controls.Add(this.FooterContainer);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.RhTxt);
            this.Controls.Add(this.IdNumberTxt);
            this.Controls.Add(this.IdTypeTxt);
            this.Controls.Add(this.RoleTxt);
            this.Controls.Add(this.GenderTxt);
            this.Controls.Add(this.PhoneTxt);
            this.Controls.Add(this.LastnameTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateCarnet";
            this.Text = "CreateCarnet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox LastnameTxt;
        private System.Windows.Forms.TextBox PhoneTxt;
        private System.Windows.Forms.TextBox GenderTxt;
        private System.Windows.Forms.TextBox RoleTxt;
        private System.Windows.Forms.ComboBox IdTypeTxt;
        private System.Windows.Forms.TextBox IdNumberTxt;
        private System.Windows.Forms.TextBox RhTxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel FooterContainer;
    }
}
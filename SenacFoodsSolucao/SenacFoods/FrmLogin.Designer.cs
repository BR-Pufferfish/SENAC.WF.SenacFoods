namespace SenacFoods
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            btn_close = new PictureBox();
            btn_login = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(txt_username);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(291, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 490);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel1.Location = new Point(722, 34);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(10, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.Text = ".";
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(712, 2);
            btn_close.Margin = new Padding(3, 2, 3, 2);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(28, 24);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 3;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaptionText;
            btn_login.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btn_login.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.Info;
            btn_login.Location = new Point(276, 248);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(141, 44);
            btn_login.TabIndex = 3;
            btn_login.Text = "Entrar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.WindowText;
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.ForeColor = SystemColors.Info;
            txt_password.Location = new Point(210, 202);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(272, 28);
            txt_password.TabIndex = 2;
            txt_password.Text = "Senha";
            txt_password.Enter += txt_password_Enter;
            txt_password.Leave += txt_password_Leave;
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.WindowText;
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.ForeColor = SystemColors.Info;
            txt_username.Location = new Point(210, 146);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(272, 28);
            txt_username.TabIndex = 1;
            txt_username.Text = "Usuário";
            txt_username.Enter += txt_username_Enter;
            txt_username.Leave += txt_username_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 490);
            panel2.TabIndex = 1;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1034, 490);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button btn_login;
        private PictureBox btn_close;
        private LinkLabel linkLabel1;
    }
}

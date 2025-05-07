namespace SenacFoods
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            btn_close = new PictureBox();
            groupBox1 = new GroupBox();
            lnk_tab0 = new LinkLabel();
            lbl_Usuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(756, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(32, 32);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 2;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 410);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lnk_tab0
            // 
            lnk_tab0.AutoSize = true;
            lnk_tab0.Location = new Point(702, 47);
            lnk_tab0.Name = "lnk_tab0";
            lnk_tab0.Size = new Size(86, 20);
            lnk_tab0.TabIndex = 5;
            lnk_tab0.TabStop = true;
            lnk_tab0.Text = "InvisibleTab";
            lnk_tab0.Visible = false;
            // 
            // lbl_Usuarios
            // 
            lbl_Usuarios.AutoSize = true;
            lbl_Usuarios.BackColor = Color.IndianRed;
            lbl_Usuarios.Font = new Font("Verdana", 16.2F);
            lbl_Usuarios.Location = new Point(327, 18);
            lbl_Usuarios.Name = "lbl_Usuarios";
            lbl_Usuarios.Size = new Size(139, 34);
            lbl_Usuarios.TabIndex = 8;
            lbl_Usuarios.Text = "Usuários";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 500);
            Controls.Add(lbl_Usuarios);
            Controls.Add(lnk_tab0);
            Controls.Add(groupBox1);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private GroupBox groupBox1;
        private LinkLabel lnk_tab0;
        private Label lbl_Usuarios;
    }
}
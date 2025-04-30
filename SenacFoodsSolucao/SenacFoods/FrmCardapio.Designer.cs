namespace SenacFoods
{
    partial class FrmCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardapio));
            btn_close = new PictureBox();
            txt_usuarios = new TextBox();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            groupBox1.SuspendLayout();
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
            // txt_usuarios
            // 
            txt_usuarios.BackColor = Color.Khaki;
            txt_usuarios.BorderStyle = BorderStyle.FixedSingle;
            txt_usuarios.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usuarios.Location = new Point(200, 12);
            txt_usuarios.Name = "txt_usuarios";
            txt_usuarios.Size = new Size(400, 40);
            txt_usuarios.TabIndex = 2;
            txt_usuarios.Text = "Cardápio";
            txt_usuarios.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 410);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(335, 201);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(267, 84);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 7;
            label1.Text = "CARDAPIO";
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 500);
            Controls.Add(groupBox1);
            Controls.Add(txt_usuarios);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapio";
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private TextBox txt_usuarios;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}
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
            groupBox1 = new GroupBox();
            lbl_Cardapio = new Label();
            lnk_tab0 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(765, 0);
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
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lbl_Cardapio
            // 
            lbl_Cardapio.AutoSize = true;
            lbl_Cardapio.BackColor = Color.FromArgb(255, 255, 128);
            lbl_Cardapio.Font = new Font("Verdana", 16.2F);
            lbl_Cardapio.Location = new Point(328, 15);
            lbl_Cardapio.Name = "lbl_Cardapio";
            lbl_Cardapio.Size = new Size(141, 34);
            lbl_Cardapio.TabIndex = 7;
            lbl_Cardapio.Text = "Cardápio";
            // 
            // lnk_tab0
            // 
            lnk_tab0.AutoSize = true;
            lnk_tab0.Location = new Point(705, 30);
            lnk_tab0.Name = "lnk_tab0";
            lnk_tab0.Size = new Size(86, 20);
            lnk_tab0.TabIndex = 0;
            lnk_tab0.TabStop = true;
            lnk_tab0.Text = "InvisibleTab";
            lnk_tab0.Visible = false;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 500);
            Controls.Add(lbl_Cardapio);
            Controls.Add(groupBox1);
            Controls.Add(lnk_tab0);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapio";
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private TextBox txt_usuarios;
        private GroupBox groupBox1;
        private LinkLabel lnk_tab0;
        private Label lbl_Cardapio;
    }
}
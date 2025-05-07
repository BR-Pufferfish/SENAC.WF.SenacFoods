namespace SenacFoods
{
    partial class FrmComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComanda));
            btn_close = new PictureBox();
            groupBox1 = new GroupBox();
            lnk_tab0 = new LinkLabel();
            lbl_comanda = new Label();
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
            groupBox1.Location = new Point(0, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 410);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lnk_tab0
            // 
            lnk_tab0.AutoSize = true;
            lnk_tab0.Location = new Point(702, 47);
            lnk_tab0.Name = "lnk_tab0";
            lnk_tab0.Size = new Size(86, 20);
            lnk_tab0.TabIndex = 7;
            lnk_tab0.TabStop = true;
            lnk_tab0.Text = "InvisibleTab";
            lnk_tab0.Visible = false;
            // 
            // lbl_comanda
            // 
            lbl_comanda.AutoSize = true;
            lbl_comanda.BackColor = Color.YellowGreen;
            lbl_comanda.Font = new Font("Verdana", 16.2F);
            lbl_comanda.Location = new Point(326, 30);
            lbl_comanda.Name = "lbl_comanda";
            lbl_comanda.Size = new Size(148, 34);
            lbl_comanda.TabIndex = 0;
            lbl_comanda.Text = "Comanda";
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 500);
            Controls.Add(lbl_comanda);
            Controls.Add(lnk_tab0);
            Controls.Add(groupBox1);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmComanda";
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private GroupBox groupBox1;
        private LinkLabel lnk_tab0;
        private Label lbl_comanda;
    }
}
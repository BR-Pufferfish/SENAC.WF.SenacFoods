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
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 500);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_close;
    }
}
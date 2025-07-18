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
            dataGridView1 = new DataGridView();
            lnk_tab0 = new LinkLabel();
            lbl_Usuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(865, 5);
            btn_close.Margin = new Padding(3, 2, 3, 2);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(28, 24);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 2;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(15, 120);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(865, 360);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 22);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(842, 328);
            dataGridView1.TabIndex = 0;
            // 
            // lnk_tab0
            // 
            lnk_tab0.AutoSize = true;
            lnk_tab0.LinkColor = SystemColors.ActiveCaptionText;
            lnk_tab0.Location = new Point(825, 35);
            lnk_tab0.Name = "lnk_tab0";
            lnk_tab0.Size = new Size(68, 15);
            lnk_tab0.TabIndex = 1;
            lnk_tab0.TabStop = true;
            lnk_tab0.Text = "InvisibleTab";
            // 
            // lbl_Usuarios
            // 
            lbl_Usuarios.AutoSize = true;
            lbl_Usuarios.BackColor = Color.IndianRed;
            lbl_Usuarios.Font = new Font("Verdana", 16.2F);
            lbl_Usuarios.Location = new Point(375, 15);
            lbl_Usuarios.Name = "lbl_Usuarios";
            lbl_Usuarios.Size = new Size(105, 26);
            lbl_Usuarios.TabIndex = 2;
            lbl_Usuarios.Text = "Usuários";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(900, 500);
            Controls.Add(lbl_Usuarios);
            Controls.Add(lnk_tab0);
            Controls.Add(groupBox1);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private GroupBox groupBox1;
        private LinkLabel lnk_tab0;
        private Label lbl_Usuarios;
        private DataGridView dataGridView1;
    }
}
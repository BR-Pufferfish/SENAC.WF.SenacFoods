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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            Pesquisar = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(1036, 15);
            btn_close.Margin = new Padding(4, 3, 4, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(36, 34);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 2;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(13, 108);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1059, 540);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lbl_Cardapio
            // 
            lbl_Cardapio.AutoSize = true;
            lbl_Cardapio.BackColor = Color.FromArgb(255, 255, 128);
            lbl_Cardapio.Font = new Font("Verdana", 16.2F);
            lbl_Cardapio.Location = new Point(471, 13);
            lbl_Cardapio.Margin = new Padding(4, 0, 4, 0);
            lbl_Cardapio.Name = "lbl_Cardapio";
            lbl_Cardapio.Size = new Size(109, 26);
            lbl_Cardapio.TabIndex = 7;
            lbl_Cardapio.Text = "Cardápio";
            // 
            // lnk_tab0
            // 
            lnk_tab0.AutoSize = true;
            lnk_tab0.Location = new Point(985, 52);
            lnk_tab0.Margin = new Padding(4, 0, 4, 0);
            lnk_tab0.Name = "lnk_tab0";
            lnk_tab0.Size = new Size(90, 21);
            lnk_tab0.TabIndex = 0;
            lnk_tab0.TabStop = true;
            lnk_tab0.Text = "InvisibleTab";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 29);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1012, 445);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(949, 483);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 1;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(845, 483);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(96, 32);
            button2.TabIndex = 2;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 70);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(471, 29);
            textBox1.TabIndex = 8;
            // 
            // Pesquisar
            // 
            Pesquisar.AutoSize = true;
            Pesquisar.BackColor = SystemColors.ActiveCaption;
            Pesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pesquisar.Location = new Point(13, 70);
            Pesquisar.Margin = new Padding(4, 0, 4, 0);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(92, 25);
            Pesquisar.TabIndex = 9;
            Pesquisar.Text = "Pesquisar";
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1088, 664);
            Controls.Add(Pesquisar);
            Controls.Add(textBox1);
            Controls.Add(lbl_Cardapio);
            Controls.Add(groupBox1);
            Controls.Add(lnk_tab0);
            Controls.Add(btn_close);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapio";
            Load += FrmCardapio_Load;
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private TextBox txt_usuarios;
        private GroupBox groupBox1;
        private LinkLabel lnk_tab0;
        private Label lbl_Cardapio;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label Pesquisar;
    }
}
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
            btn_Excluir = new Button();
            btn_Editar = new Button();
            dataGridView1 = new DataGridView();
            lbl_Usuarios = new Label();
            btn_incluir = new Button();
            lbl_Pesquisar = new Label();
            txt_Pesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(1045, 5);
            btn_close.Margin = new Padding(3, 2, 3, 2);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(36, 36);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 2;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Excluir);
            groupBox1.Controls.Add(btn_Editar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(10, 180);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1059, 472);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = Color.IndianRed;
            btn_Excluir.FlatStyle = FlatStyle.Flat;
            btn_Excluir.Font = new Font("Segoe UI", 12F);
            btn_Excluir.Location = new Point(839, 418);
            btn_Excluir.Margin = new Padding(4);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(96, 32);
            btn_Excluir.TabIndex = 4;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = false;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.BackColor = Color.Turquoise;
            btn_Editar.Enabled = false;
            btn_Editar.FlatStyle = FlatStyle.Flat;
            btn_Editar.Font = new Font("Segoe UI", 12F);
            btn_Editar.Location = new Point(943, 418);
            btn_Editar.Margin = new Padding(4);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(96, 32);
            btn_Editar.TabIndex = 3;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = false;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 30);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1012, 381);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lbl_Usuarios
            // 
            lbl_Usuarios.AutoSize = true;
            lbl_Usuarios.BackColor = Color.IndianRed;
            lbl_Usuarios.Font = new Font("Verdana", 27.75F);
            lbl_Usuarios.Location = new Point(440, 10);
            lbl_Usuarios.Name = "lbl_Usuarios";
            lbl_Usuarios.Size = new Size(178, 45);
            lbl_Usuarios.TabIndex = 2;
            lbl_Usuarios.Text = "Usuários";
            // 
            // btn_incluir
            // 
            btn_incluir.BackColor = Color.SpringGreen;
            btn_incluir.FlatAppearance.BorderSize = 0;
            btn_incluir.FlatStyle = FlatStyle.Flat;
            btn_incluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_incluir.Location = new Point(35, 135);
            btn_incluir.Margin = new Padding(4);
            btn_incluir.Name = "btn_incluir";
            btn_incluir.Size = new Size(120, 30);
            btn_incluir.TabIndex = 16;
            btn_incluir.Text = "Incluir";
            btn_incluir.UseVisualStyleBackColor = false;
            btn_incluir.Click += btn_incluir_Click;
            // 
            // lbl_Pesquisar
            // 
            lbl_Pesquisar.BackColor = SystemColors.ActiveCaption;
            lbl_Pesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Pesquisar.Location = new Point(35, 100);
            lbl_Pesquisar.Margin = new Padding(4, 0, 4, 0);
            lbl_Pesquisar.Name = "lbl_Pesquisar";
            lbl_Pesquisar.Size = new Size(120, 30);
            lbl_Pesquisar.TabIndex = 15;
            lbl_Pesquisar.Text = "Pesquisar";
            // 
            // txt_Pesquisa
            // 
            txt_Pesquisa.Location = new Point(160, 100);
            txt_Pesquisa.Margin = new Padding(4);
            txt_Pesquisa.Name = "txt_Pesquisa";
            txt_Pesquisa.Size = new Size(480, 23);
            txt_Pesquisa.TabIndex = 14;
            txt_Pesquisa.TextChanged += txt_Pesquisa_TextChanged;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1090, 665);
            Controls.Add(btn_incluir);
            Controls.Add(lbl_Pesquisar);
            Controls.Add(txt_Pesquisa);
            Controls.Add(lbl_Usuarios);
            Controls.Add(groupBox1);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private GroupBox groupBox1;
        private Label lbl_Usuarios;
        private DataGridView dataGridView1;
        private Button btn_Excluir;
        private Button btn_Editar;
        private Button btn_incluir;
        private Label lbl_Pesquisar;
        private TextBox txt_Pesquisa;
    }
}
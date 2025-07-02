namespace SenacFoods
{
    partial class FrmCardapioCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardapioCad));
            btn_close = new PictureBox();
            groupBox1 = new GroupBox();
            rtxt_descricao = new RichTextBox();
            txt_preco = new TextBox();
            txt_titulo = new TextBox();
            chk_preparo = new CheckBox();
            lbl_Preco = new Label();
            lbl_Descricao = new Label();
            lbl_Titulo = new Label();
            btn_Cancelar = new Button();
            btn_Salvar = new Button();
            lbl_Cardapio = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(1041, 12);
            btn_close.Margin = new Padding(4, 3, 4, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(36, 34);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 3;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtxt_descricao);
            groupBox1.Controls.Add(txt_preco);
            groupBox1.Controls.Add(txt_titulo);
            groupBox1.Controls.Add(chk_preparo);
            groupBox1.Controls.Add(lbl_Preco);
            groupBox1.Controls.Add(lbl_Descricao);
            groupBox1.Controls.Add(lbl_Titulo);
            groupBox1.Controls.Add(btn_Cancelar);
            groupBox1.Controls.Add(btn_Salvar);
            groupBox1.Location = new Point(13, 88);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1064, 472);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rtxt_descricao
            // 
            rtxt_descricao.Location = new Point(30, 188);
            rtxt_descricao.Name = "rtxt_descricao";
            rtxt_descricao.Size = new Size(407, 71);
            rtxt_descricao.TabIndex = 6;
            rtxt_descricao.Text = "";
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(30, 310);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(103, 23);
            txt_preco.TabIndex = 5;
            // 
            // txt_titulo
            // 
            txt_titulo.Location = new Point(30, 108);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(407, 23);
            txt_titulo.TabIndex = 5;
            // 
            // chk_preparo
            // 
            chk_preparo.AutoSize = true;
            chk_preparo.BackColor = SystemColors.ActiveCaption;
            chk_preparo.Font = new Font("Segoe UI", 15.75F);
            chk_preparo.Location = new Point(30, 360);
            chk_preparo.Name = "chk_preparo";
            chk_preparo.Size = new Size(177, 34);
            chk_preparo.TabIndex = 4;
            chk_preparo.Text = "Possui Preparo?";
            chk_preparo.UseVisualStyleBackColor = false;
            // 
            // lbl_Preco
            // 
            lbl_Preco.AutoSize = true;
            lbl_Preco.BackColor = SystemColors.ActiveCaption;
            lbl_Preco.Font = new Font("Segoe UI", 15.75F);
            lbl_Preco.Location = new Point(30, 277);
            lbl_Preco.Name = "lbl_Preco";
            lbl_Preco.Size = new Size(65, 30);
            lbl_Preco.TabIndex = 3;
            lbl_Preco.Text = "Preço";
            // 
            // lbl_Descricao
            // 
            lbl_Descricao.AutoSize = true;
            lbl_Descricao.BackColor = SystemColors.ActiveCaption;
            lbl_Descricao.Font = new Font("Segoe UI", 15.75F);
            lbl_Descricao.Location = new Point(30, 155);
            lbl_Descricao.Name = "lbl_Descricao";
            lbl_Descricao.Size = new Size(103, 30);
            lbl_Descricao.TabIndex = 3;
            lbl_Descricao.Text = "Descrição";
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.BackColor = SystemColors.ActiveCaption;
            lbl_Titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Titulo.Location = new Point(30, 75);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(65, 30);
            lbl_Titulo.TabIndex = 3;
            lbl_Titulo.Text = "Título";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.IndianRed;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.Location = new Point(839, 418);
            btn_Cancelar.Margin = new Padding(4);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(96, 32);
            btn_Cancelar.TabIndex = 2;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = Color.Turquoise;
            btn_Salvar.FlatStyle = FlatStyle.Flat;
            btn_Salvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Salvar.Location = new Point(943, 418);
            btn_Salvar.Margin = new Padding(4);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(96, 32);
            btn_Salvar.TabIndex = 1;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // lbl_Cardapio
            // 
            lbl_Cardapio.AutoSize = true;
            lbl_Cardapio.BackColor = Color.FromArgb(255, 255, 128);
            lbl_Cardapio.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Cardapio.Location = new Point(313, 12);
            lbl_Cardapio.Margin = new Padding(4, 0, 4, 0);
            lbl_Cardapio.Name = "lbl_Cardapio";
            lbl_Cardapio.Size = new Size(420, 45);
            lbl_Cardapio.TabIndex = 15;
            lbl_Cardapio.Text = "Cadastro de Cardápio";
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1090, 572);
            Controls.Add(lbl_Cardapio);
            Controls.Add(groupBox1);
            Controls.Add(btn_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "   ";
            Load += FrmCardapioCad_Load;
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_close;
        private GroupBox groupBox1;
        private Button btn_Cancelar;
        private Button btn_Salvar;
        private Label lbl_Preco;
        private Label lbl_Descricao;
        private Label lbl_Titulo;
        private Label lbl_Cardapio;
        private RichTextBox rtxt_descricao;
        private TextBox txt_preco;
        private TextBox txt_titulo;
        private CheckBox chk_preparo;
    }
}
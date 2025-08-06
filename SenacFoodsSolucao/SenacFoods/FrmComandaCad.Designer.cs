namespace SenacFoods
{
    partial class FrmComandaCad
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
            groupBox1 = new GroupBox();
            btn_adicionar = new Button();
            dataGridView1 = new DataGridView();
            cbx_mesa = new ComboBox();
            cbx_cardapio = new ComboBox();
            lbl_cardapio = new Label();
            lbl_mesa = new Label();
            txt_nomeCliente = new TextBox();
            lbl_nomeCliente = new Label();
            btn_Cancelar = new Button();
            btn_Salvar = new Button();
            lbl_comandaCad = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_adicionar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(cbx_mesa);
            groupBox1.Controls.Add(cbx_cardapio);
            groupBox1.Controls.Add(lbl_cardapio);
            groupBox1.Controls.Add(lbl_mesa);
            groupBox1.Controls.Add(txt_nomeCliente);
            groupBox1.Controls.Add(lbl_nomeCliente);
            groupBox1.Controls.Add(btn_Cancelar);
            groupBox1.Controls.Add(btn_Salvar);
            groupBox1.Location = new Point(10, 90);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1064, 472);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btn_adicionar
            // 
            btn_adicionar.BackColor = Color.Chartreuse;
            btn_adicionar.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_adicionar.Location = new Point(570, 195);
            btn_adicionar.Margin = new Padding(0);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(50, 50);
            btn_adicionar.TabIndex = 8;
            btn_adicionar.Text = "+";
            btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(405, 150);
            dataGridView1.TabIndex = 7;
            // 
            // cbx_mesa
            // 
            cbx_mesa.FormattingEnabled = true;
            cbx_mesa.Location = new Point(150, 145);
            cbx_mesa.Name = "cbx_mesa";
            cbx_mesa.Size = new Size(405, 23);
            cbx_mesa.TabIndex = 6;
            // 
            // cbx_cardapio
            // 
            cbx_cardapio.FormattingEnabled = true;
            cbx_cardapio.Location = new Point(150, 195);
            cbx_cardapio.Name = "cbx_cardapio";
            cbx_cardapio.Size = new Size(405, 23);
            cbx_cardapio.TabIndex = 6;
            // 
            // lbl_cardapio
            // 
            lbl_cardapio.AutoSize = true;
            lbl_cardapio.BackColor = SystemColors.ActiveCaption;
            lbl_cardapio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cardapio.Location = new Point(40, 190);
            lbl_cardapio.Name = "lbl_cardapio";
            lbl_cardapio.Size = new Size(96, 30);
            lbl_cardapio.TabIndex = 3;
            lbl_cardapio.Text = "Cardápio";
            // 
            // lbl_mesa
            // 
            lbl_mesa.AutoSize = true;
            lbl_mesa.BackColor = SystemColors.ActiveCaption;
            lbl_mesa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_mesa.Location = new Point(55, 140);
            lbl_mesa.Name = "lbl_mesa";
            lbl_mesa.Size = new Size(63, 30);
            lbl_mesa.TabIndex = 3;
            lbl_mesa.Text = "Mesa";
            // 
            // txt_nomeCliente
            // 
            txt_nomeCliente.Location = new Point(150, 90);
            txt_nomeCliente.Name = "txt_nomeCliente";
            txt_nomeCliente.Size = new Size(405, 23);
            txt_nomeCliente.TabIndex = 5;
            txt_nomeCliente.TextChanged += txt_nomeCliente_TextChanged;
            // 
            // lbl_nomeCliente
            // 
            lbl_nomeCliente.AutoSize = true;
            lbl_nomeCliente.BackColor = SystemColors.ActiveCaption;
            lbl_nomeCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nomeCliente.Location = new Point(50, 85);
            lbl_nomeCliente.Name = "lbl_nomeCliente";
            lbl_nomeCliente.Size = new Size(77, 30);
            lbl_nomeCliente.TabIndex = 3;
            lbl_nomeCliente.Text = "Cliente";
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
            // 
            // lbl_comandaCad
            // 
            lbl_comandaCad.AutoSize = true;
            lbl_comandaCad.BackColor = Color.FromArgb(255, 255, 128);
            lbl_comandaCad.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_comandaCad.Location = new Point(330, 15);
            lbl_comandaCad.Margin = new Padding(4, 0, 4, 0);
            lbl_comandaCad.Name = "lbl_comandaCad";
            lbl_comandaCad.Size = new Size(430, 45);
            lbl_comandaCad.TabIndex = 19;
            lbl_comandaCad.Text = "Cadastro de Comanda";
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1090, 572);
            Controls.Add(lbl_comandaCad);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComandaCad";
            Text = "FrmComandaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_nomeCliente;
        private Label lbl_nomeCliente;
        private Button btn_Cancelar;
        private Button btn_Salvar;
        private Label lbl_comandaCad;
        private Label lbl_cardapio;
        private Label lbl_mesa;
        private DataGridView dataGridView1;
        private ComboBox cbx_mesa;
        private ComboBox cbx_cardapio;
        private Button btn_adicionar;
    }
}
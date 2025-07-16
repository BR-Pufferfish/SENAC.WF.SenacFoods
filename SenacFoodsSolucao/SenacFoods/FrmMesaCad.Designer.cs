namespace SenacFoods
{
    partial class FrmMesaCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesaCad));
            groupBox1 = new GroupBox();
            txt_numeroMesa = new TextBox();
            lbl_NumeroMesa = new Label();
            btn_Cancelar = new Button();
            btn_Salvar = new Button();
            btn_close = new PictureBox();
            lbl_Cardapio = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_numeroMesa);
            groupBox1.Controls.Add(lbl_NumeroMesa);
            groupBox1.Controls.Add(btn_Cancelar);
            groupBox1.Controls.Add(btn_Salvar);
            groupBox1.Location = new Point(10, 90);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1064, 472);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt_numeroMesa
            // 
            txt_numeroMesa.Location = new Point(30, 108);
            txt_numeroMesa.Name = "txt_numeroMesa";
            txt_numeroMesa.Size = new Size(407, 23);
            txt_numeroMesa.TabIndex = 5;
            // 
            // lbl_NumeroMesa
            // 
            lbl_NumeroMesa.AutoSize = true;
            lbl_NumeroMesa.BackColor = SystemColors.ActiveCaption;
            lbl_NumeroMesa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NumeroMesa.Location = new Point(31, 75);
            lbl_NumeroMesa.Name = "lbl_NumeroMesa";
            lbl_NumeroMesa.Size = new Size(139, 30);
            lbl_NumeroMesa.TabIndex = 3;
            lbl_NumeroMesa.Text = "NumeroMesa";
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
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(1038, 14);
            btn_close.Margin = new Padding(4, 3, 4, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(36, 34);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 16;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // lbl_Cardapio
            // 
            lbl_Cardapio.AutoSize = true;
            lbl_Cardapio.BackColor = Color.FromArgb(255, 255, 128);
            lbl_Cardapio.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Cardapio.Location = new Point(370, 15);
            lbl_Cardapio.Margin = new Padding(4, 0, 4, 0);
            lbl_Cardapio.Name = "lbl_Cardapio";
            lbl_Cardapio.Size = new Size(350, 45);
            lbl_Cardapio.TabIndex = 18;
            lbl_Cardapio.Text = "Cadastro de Mesa";
            // 
            // FrmMesaCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1090, 572);
            Controls.Add(groupBox1);
            Controls.Add(btn_close);
            Controls.Add(lbl_Cardapio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesaCad";
            Text = "FrmMesaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_numeroMesa;
        private Label lbl_NumeroMesa;
        private Button btn_Cancelar;
        private Button btn_Salvar;
        private PictureBox btn_close;
        private Label lbl_Cardapio;
    }
}
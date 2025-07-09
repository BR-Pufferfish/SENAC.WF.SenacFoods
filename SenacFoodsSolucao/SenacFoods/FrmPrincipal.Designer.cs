namespace SenacFoods
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            groupBox1 = new GroupBox();
            btn_usuarios = new Button();
            btn_pedido_cozinha = new Button();
            btn_comanda = new Button();
            btn_cardapio = new Button();
            btn_close = new PictureBox();
            btn_minimize = new PictureBox();
            lnk_tab0 = new LinkLabel();
            lbl_bemvindo = new Label();
            btn_Mesas = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_usuarios);
            groupBox1.Controls.Add(btn_pedido_cozinha);
            groupBox1.Controls.Add(btn_Mesas);
            groupBox1.Controls.Add(btn_comanda);
            groupBox1.Controls.Add(btn_cardapio);
            groupBox1.ForeColor = SystemColors.Info;
            groupBox1.Location = new Point(0, 90);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(866, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btn_usuarios
            // 
            btn_usuarios.BackColor = Color.DarkRed;
            btn_usuarios.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btn_usuarios.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btn_usuarios.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_usuarios.ForeColor = SystemColors.ControlText;
            btn_usuarios.Location = new Point(530, 125);
            btn_usuarios.Margin = new Padding(3, 2, 3, 2);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(158, 112);
            btn_usuarios.TabIndex = 4;
            btn_usuarios.Text = "Usuários";
            btn_usuarios.UseVisualStyleBackColor = false;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // btn_pedido_cozinha
            // 
            btn_pedido_cozinha.BackColor = Color.Teal;
            btn_pedido_cozinha.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btn_pedido_cozinha.FlatAppearance.MouseOverBackColor = Color.Teal;
            btn_pedido_cozinha.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_pedido_cozinha.ForeColor = SystemColors.ControlText;
            btn_pedido_cozinha.Location = new Point(355, 125);
            btn_pedido_cozinha.Margin = new Padding(3, 2, 3, 2);
            btn_pedido_cozinha.Name = "btn_pedido_cozinha";
            btn_pedido_cozinha.Size = new Size(158, 112);
            btn_pedido_cozinha.TabIndex = 3;
            btn_pedido_cozinha.Text = "Pedido Cozinha";
            btn_pedido_cozinha.UseVisualStyleBackColor = false;
            btn_pedido_cozinha.Click += btn_pedido_cozinha_Click;
            // 
            // btn_comanda
            // 
            btn_comanda.BackColor = Color.ForestGreen;
            btn_comanda.FlatAppearance.MouseDownBackColor = Color.Green;
            btn_comanda.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_comanda.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_comanda.ForeColor = SystemColors.ControlText;
            btn_comanda.Location = new Point(185, 125);
            btn_comanda.Margin = new Padding(3, 2, 3, 2);
            btn_comanda.Name = "btn_comanda";
            btn_comanda.Size = new Size(158, 112);
            btn_comanda.TabIndex = 2;
            btn_comanda.Text = "Comanda";
            btn_comanda.UseVisualStyleBackColor = false;
            btn_comanda.Click += btn_comanda_Click;
            // 
            // btn_cardapio
            // 
            btn_cardapio.BackColor = Color.DarkGoldenrod;
            btn_cardapio.FlatAppearance.MouseDownBackColor = Color.Gold;
            btn_cardapio.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btn_cardapio.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cardapio.ForeColor = SystemColors.ControlText;
            btn_cardapio.Location = new Point(15, 125);
            btn_cardapio.Margin = new Padding(3, 2, 3, 2);
            btn_cardapio.Name = "btn_cardapio";
            btn_cardapio.Size = new Size(158, 112);
            btn_cardapio.TabIndex = 1;
            btn_cardapio.Text = "Cardápio";
            btn_cardapio.UseVisualStyleBackColor = false;
            btn_cardapio.Click += btn_cardapio_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.Image = (Image)resources.GetObject("btn_close.Image");
            btn_close.Location = new Point(840, 0);
            btn_close.Margin = new Padding(3, 2, 3, 2);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(28, 24);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 1;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.BackColor = Color.MediumBlue;
            btn_minimize.Image = (Image)resources.GetObject("btn_minimize.Image");
            btn_minimize.Location = new Point(809, 0);
            btn_minimize.Margin = new Padding(3, 2, 3, 2);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(28, 24);
            btn_minimize.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimize.TabIndex = 1;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // lnk_tab0
            // 
            lnk_tab0.AutoSize = true;
            lnk_tab0.LinkColor = SystemColors.ActiveCaptionText;
            lnk_tab0.Location = new Point(788, 34);
            lnk_tab0.Name = "lnk_tab0";
            lnk_tab0.Size = new Size(68, 15);
            lnk_tab0.TabIndex = 0;
            lnk_tab0.TabStop = true;
            lnk_tab0.Text = "InvisibleTab";
            // 
            // lbl_bemvindo
            // 
            lbl_bemvindo.AutoSize = true;
            lbl_bemvindo.BackColor = SystemColors.ActiveCaptionText;
            lbl_bemvindo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_bemvindo.ForeColor = SystemColors.Highlight;
            lbl_bemvindo.Location = new Point(328, 11);
            lbl_bemvindo.Name = "lbl_bemvindo";
            lbl_bemvindo.Size = new Size(158, 29);
            lbl_bemvindo.TabIndex = 3;
            lbl_bemvindo.Text = "lbl_bemvindo";
            // 
            // btn_Mesas
            // 
            btn_Mesas.BackColor = Color.OrangeRed;
            btn_Mesas.FlatAppearance.MouseDownBackColor = Color.Green;
            btn_Mesas.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_Mesas.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Mesas.ForeColor = SystemColors.ControlText;
            btn_Mesas.Location = new Point(705, 125);
            btn_Mesas.Margin = new Padding(3, 2, 3, 2);
            btn_Mesas.Name = "btn_Mesas";
            btn_Mesas.Size = new Size(150, 112);
            btn_Mesas.TabIndex = 2;
            btn_Mesas.Text = "Mesa";
            btn_Mesas.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(867, 450);
            Controls.Add(lbl_bemvindo);
            Controls.Add(lnk_tab0);
            Controls.Add(btn_minimize);
            Controls.Add(btn_close);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_cardapio;
        private Button btn_usuarios;
        private Button btn_pedido_cozinha;
        private Button btn_comanda;
        private PictureBox btn_close;
        private PictureBox btn_minimize;
        private LinkLabel lnk_tab0;
        private Label lbl_bemvindo;
        private Button btn_Mesas;
    }
}
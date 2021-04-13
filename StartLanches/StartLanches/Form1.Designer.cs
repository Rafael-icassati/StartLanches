namespace StartLanches
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbx_lanches = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_faz_pedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_valor_total = new System.Windows.Forms.TextBox();
            this.txb_nome_cliente = new System.Windows.Forms.TextBox();
            this.nud_alface = new System.Windows.Forms.NumericUpDown();
            this.nud_bacon = new System.Windows.Forms.NumericUpDown();
            this.nud_hamb_carne = new System.Windows.Forms.NumericUpDown();
            this.nud_ovo = new System.Windows.Forms.NumericUpDown();
            this.nud_queijo = new System.Windows.Forms.NumericUpDown();
            this.lbl_alface = new System.Windows.Forms.Label();
            this.lbl_bacon = new System.Windows.Forms.Label();
            this.lbl_hamb_carne = new System.Windows.Forms.Label();
            this.lbl_ovo = new System.Windows.Forms.Label();
            this.lbl_queijo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgw_Pedidos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbx_timer = new System.Windows.Forms.TextBox();
            this.lbl_promocoes = new System.Windows.Forms.Label();
            this.lbl_light = new System.Windows.Forms.Label();
            this.lbl_m_carne = new System.Windows.Forms.Label();
            this.lbl_m_queijo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_alface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bacon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hamb_carne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_queijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_lanches
            // 
            this.cbx_lanches.FormattingEnabled = true;
            this.cbx_lanches.Items.AddRange(new object[] {
            "X-Bacon",
            "X-Burger",
            "X-Egg",
            "X-Egg Bacon"});
            this.cbx_lanches.Location = new System.Drawing.Point(12, 238);
            this.cbx_lanches.Name = "cbx_lanches";
            this.cbx_lanches.Size = new System.Drawing.Size(121, 21);
            this.cbx_lanches.TabIndex = 0;
            this.cbx_lanches.Text = "X-Bacon";
            this.cbx_lanches.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Insira o nome do cliente:";
            // 
            // btn_faz_pedido
            // 
            this.btn_faz_pedido.Location = new System.Drawing.Point(13, 467);
            this.btn_faz_pedido.Name = "btn_faz_pedido";
            this.btn_faz_pedido.Size = new System.Drawing.Size(100, 23);
            this.btn_faz_pedido.TabIndex = 10;
            this.btn_faz_pedido.Text = "Fazer Pedido";
            this.btn_faz_pedido.UseVisualStyleBackColor = true;
            this.btn_faz_pedido.Click += new System.EventHandler(this.btn_faz_pedido_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor:";
            // 
            // tbx_valor_total
            // 
            this.tbx_valor_total.Location = new System.Drawing.Point(57, 441);
            this.tbx_valor_total.Name = "tbx_valor_total";
            this.tbx_valor_total.Size = new System.Drawing.Size(100, 20);
            this.tbx_valor_total.TabIndex = 12;
            // 
            // txb_nome_cliente
            // 
            this.txb_nome_cliente.Location = new System.Drawing.Point(12, 199);
            this.txb_nome_cliente.Name = "txb_nome_cliente";
            this.txb_nome_cliente.Size = new System.Drawing.Size(100, 20);
            this.txb_nome_cliente.TabIndex = 13;
            // 
            // nud_alface
            // 
            this.nud_alface.Location = new System.Drawing.Point(15, 270);
            this.nud_alface.Name = "nud_alface";
            this.nud_alface.Size = new System.Drawing.Size(32, 20);
            this.nud_alface.TabIndex = 14;
            this.nud_alface.ValueChanged += new System.EventHandler(this.nud_alface_ValueChanged);
            // 
            // nud_bacon
            // 
            this.nud_bacon.Location = new System.Drawing.Point(15, 296);
            this.nud_bacon.Name = "nud_bacon";
            this.nud_bacon.Size = new System.Drawing.Size(32, 20);
            this.nud_bacon.TabIndex = 15;
            this.nud_bacon.ValueChanged += new System.EventHandler(this.nud_bacon_ValueChanged);
            // 
            // nud_hamb_carne
            // 
            this.nud_hamb_carne.Location = new System.Drawing.Point(15, 322);
            this.nud_hamb_carne.Name = "nud_hamb_carne";
            this.nud_hamb_carne.Size = new System.Drawing.Size(32, 20);
            this.nud_hamb_carne.TabIndex = 16;
            this.nud_hamb_carne.ValueChanged += new System.EventHandler(this.nud_hamb_carne_ValueChanged);
            // 
            // nud_ovo
            // 
            this.nud_ovo.Location = new System.Drawing.Point(15, 348);
            this.nud_ovo.Name = "nud_ovo";
            this.nud_ovo.Size = new System.Drawing.Size(32, 20);
            this.nud_ovo.TabIndex = 17;
            this.nud_ovo.ValueChanged += new System.EventHandler(this.nud_ovo_ValueChanged);
            // 
            // nud_queijo
            // 
            this.nud_queijo.Location = new System.Drawing.Point(15, 374);
            this.nud_queijo.Name = "nud_queijo";
            this.nud_queijo.Size = new System.Drawing.Size(32, 20);
            this.nud_queijo.TabIndex = 18;
            this.nud_queijo.ValueChanged += new System.EventHandler(this.nud_queijo_ValueChanged);
            // 
            // lbl_alface
            // 
            this.lbl_alface.AutoSize = true;
            this.lbl_alface.Location = new System.Drawing.Point(54, 276);
            this.lbl_alface.Name = "lbl_alface";
            this.lbl_alface.Size = new System.Drawing.Size(37, 13);
            this.lbl_alface.TabIndex = 19;
            this.lbl_alface.Text = "Alface";
            // 
            // lbl_bacon
            // 
            this.lbl_bacon.AutoSize = true;
            this.lbl_bacon.Location = new System.Drawing.Point(54, 303);
            this.lbl_bacon.Name = "lbl_bacon";
            this.lbl_bacon.Size = new System.Drawing.Size(38, 13);
            this.lbl_bacon.TabIndex = 20;
            this.lbl_bacon.Text = "Bacon";
            // 
            // lbl_hamb_carne
            // 
            this.lbl_hamb_carne.AutoSize = true;
            this.lbl_hamb_carne.Location = new System.Drawing.Point(54, 329);
            this.lbl_hamb_carne.Name = "lbl_hamb_carne";
            this.lbl_hamb_carne.Size = new System.Drawing.Size(110, 13);
            this.lbl_hamb_carne.TabIndex = 21;
            this.lbl_hamb_carne.Text = "Hambúrguer de carne";
            // 
            // lbl_ovo
            // 
            this.lbl_ovo.AutoSize = true;
            this.lbl_ovo.Location = new System.Drawing.Point(53, 355);
            this.lbl_ovo.Name = "lbl_ovo";
            this.lbl_ovo.Size = new System.Drawing.Size(27, 13);
            this.lbl_ovo.TabIndex = 22;
            this.lbl_ovo.Text = "Ovo";
            // 
            // lbl_queijo
            // 
            this.lbl_queijo.AutoSize = true;
            this.lbl_queijo.Location = new System.Drawing.Point(54, 381);
            this.lbl_queijo.Name = "lbl_queijo";
            this.lbl_queijo.Size = new System.Drawing.Size(37, 13);
            this.lbl_queijo.TabIndex = 23;
            this.lbl_queijo.Text = "Queijo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Escolha o lanche abaixo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Aumente e diminua quantidade dos itens para\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "turbinar o lanche conforme vontade do cliente";
            // 
            // dgw_Pedidos
            // 
            this.dgw_Pedidos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgw_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Pedidos.Location = new System.Drawing.Point(242, 12);
            this.dgw_Pedidos.Name = "dgw_Pedidos";
            this.dgw_Pedidos.Size = new System.Drawing.Size(1163, 496);
            this.dgw_Pedidos.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 161);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbx_timer
            // 
            this.tbx_timer.Location = new System.Drawing.Point(1368, 514);
            this.tbx_timer.Name = "tbx_timer";
            this.tbx_timer.Size = new System.Drawing.Size(37, 20);
            this.tbx_timer.TabIndex = 30;
            // 
            // lbl_promocoes
            // 
            this.lbl_promocoes.AutoSize = true;
            this.lbl_promocoes.Location = new System.Drawing.Point(15, 510);
            this.lbl_promocoes.Name = "lbl_promocoes";
            this.lbl_promocoes.Size = new System.Drawing.Size(0, 13);
            this.lbl_promocoes.TabIndex = 31;
            // 
            // lbl_light
            // 
            this.lbl_light.AutoSize = true;
            this.lbl_light.Location = new System.Drawing.Point(9, 521);
            this.lbl_light.Name = "lbl_light";
            this.lbl_light.Size = new System.Drawing.Size(0, 13);
            this.lbl_light.TabIndex = 32;
            // 
            // lbl_m_carne
            // 
            this.lbl_m_carne.AutoSize = true;
            this.lbl_m_carne.Location = new System.Drawing.Point(9, 534);
            this.lbl_m_carne.Name = "lbl_m_carne";
            this.lbl_m_carne.Size = new System.Drawing.Size(0, 13);
            this.lbl_m_carne.TabIndex = 33;
            // 
            // lbl_m_queijo
            // 
            this.lbl_m_queijo.AutoSize = true;
            this.lbl_m_queijo.Location = new System.Drawing.Point(9, 547);
            this.lbl_m_queijo.Name = "lbl_m_queijo";
            this.lbl_m_queijo.Size = new System.Drawing.Size(0, 13);
            this.lbl_m_queijo.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1417, 561);
            this.Controls.Add(this.lbl_m_queijo);
            this.Controls.Add(this.lbl_m_carne);
            this.Controls.Add(this.lbl_light);
            this.Controls.Add(this.lbl_promocoes);
            this.Controls.Add(this.tbx_timer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgw_Pedidos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_queijo);
            this.Controls.Add(this.lbl_ovo);
            this.Controls.Add(this.lbl_hamb_carne);
            this.Controls.Add(this.lbl_bacon);
            this.Controls.Add(this.lbl_alface);
            this.Controls.Add(this.nud_queijo);
            this.Controls.Add(this.nud_ovo);
            this.Controls.Add(this.nud_hamb_carne);
            this.Controls.Add(this.nud_bacon);
            this.Controls.Add(this.nud_alface);
            this.Controls.Add(this.txb_nome_cliente);
            this.Controls.Add(this.tbx_valor_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_faz_pedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_lanches);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_alface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bacon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hamb_carne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_queijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_lanches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_faz_pedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_valor_total;
        private System.Windows.Forms.TextBox txb_nome_cliente;
        private System.Windows.Forms.NumericUpDown nud_alface;
        private System.Windows.Forms.NumericUpDown nud_bacon;
        private System.Windows.Forms.NumericUpDown nud_hamb_carne;
        private System.Windows.Forms.NumericUpDown nud_ovo;
        private System.Windows.Forms.NumericUpDown nud_queijo;
        private System.Windows.Forms.Label lbl_alface;
        private System.Windows.Forms.Label lbl_bacon;
        private System.Windows.Forms.Label lbl_hamb_carne;
        private System.Windows.Forms.Label lbl_ovo;
        private System.Windows.Forms.Label lbl_queijo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgw_Pedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbx_timer;
        private System.Windows.Forms.Label lbl_promocoes;
        private System.Windows.Forms.Label lbl_light;
        private System.Windows.Forms.Label lbl_m_carne;
        private System.Windows.Forms.Label lbl_m_queijo;
    }
}


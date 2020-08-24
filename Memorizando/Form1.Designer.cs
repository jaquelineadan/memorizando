namespace Memorizando
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
            this.btnResposta = new System.Windows.Forms.Button();
            this.alfabeto = new System.Windows.Forms.ComboBox();
            this.tentativa = new System.Windows.Forms.TextBox();
            this.letra = new System.Windows.Forms.Label();
            this.painelRelatorio = new System.Windows.Forms.Panel();
            this.memorizarMais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.relatorio = new System.Windows.Forms.ListBox();
            this.fimMemorizacao = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.ComboBox();
            this.painelRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResposta
            // 
            this.btnResposta.Enabled = false;
            this.btnResposta.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnResposta.Location = new System.Drawing.Point(117, 284);
            this.btnResposta.Name = "btnResposta";
            this.btnResposta.Size = new System.Drawing.Size(158, 49);
            this.btnResposta.TabIndex = 0;
            this.btnResposta.Text = "Responder";
            this.btnResposta.UseVisualStyleBackColor = true;
            this.btnResposta.Click += new System.EventHandler(this.btnResposta_Click);
            // 
            // alfabeto
            // 
            this.alfabeto.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.alfabeto.FormattingEnabled = true;
            this.alfabeto.Items.AddRange(new object[] {
            "Hiragana"});
            this.alfabeto.Location = new System.Drawing.Point(12, 12);
            this.alfabeto.Name = "alfabeto";
            this.alfabeto.Size = new System.Drawing.Size(174, 23);
            this.alfabeto.TabIndex = 1;
            this.alfabeto.Text = "Selecione um alfabeto";
            this.alfabeto.SelectedValueChanged += new System.EventHandler(this.alfabeto_SelectedValueChanged);
            // 
            // tentativa
            // 
            this.tentativa.Enabled = false;
            this.tentativa.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tentativa.Location = new System.Drawing.Point(146, 214);
            this.tentativa.Name = "tentativa";
            this.tentativa.Size = new System.Drawing.Size(100, 26);
            this.tentativa.TabIndex = 3;
            // 
            // letra
            // 
            this.letra.AutoSize = true;
            this.letra.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.letra.Location = new System.Drawing.Point(167, 96);
            this.letra.Name = "letra";
            this.letra.Size = new System.Drawing.Size(55, 55);
            this.letra.TabIndex = 4;
            this.letra.Text = "?";
            this.letra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // painelRelatorio
            // 
            this.painelRelatorio.Controls.Add(this.memorizarMais);
            this.painelRelatorio.Controls.Add(this.label1);
            this.painelRelatorio.Controls.Add(this.relatorio);
            this.painelRelatorio.Location = new System.Drawing.Point(12, 57);
            this.painelRelatorio.Name = "painelRelatorio";
            this.painelRelatorio.Size = new System.Drawing.Size(374, 381);
            this.painelRelatorio.TabIndex = 5;
            this.painelRelatorio.Visible = false;
            // 
            // memorizarMais
            // 
            this.memorizarMais.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.memorizarMais.Location = new System.Drawing.Point(254, 347);
            this.memorizarMais.Name = "memorizarMais";
            this.memorizarMais.Size = new System.Drawing.Size(120, 34);
            this.memorizarMais.TabIndex = 2;
            this.memorizarMais.Text = "Memorizar mais";
            this.memorizarMais.UseVisualStyleBackColor = true;
            this.memorizarMais.Click += new System.EventHandler(this.memorizarMais_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(90, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório de apredizado";
            // 
            // relatorio
            // 
            this.relatorio.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.relatorio.FormattingEnabled = true;
            this.relatorio.ItemHeight = 24;
            this.relatorio.Items.AddRange(new object[] {
            "あ 0 tentativas",
            "い 0 tentativas",
            "う 0 tentativas",
            "え 0 tentativas",
            "お 0 tentativas",
            "か 0 tentativas",
            "き 0 tentativas",
            "く 0 tentativas",
            "け 0 tentativas",
            "こ 0 tentativas",
            "さ 0 tentativas",
            "し 0 tentativas",
            "す 0 tentativas",
            "せ 0 tentativas",
            "そ 0 tentativas",
            "た 0 tentativas",
            "ち 0 tentativas",
            "つ 0 tentativas",
            "て 0 tentativas",
            "と 0 tentativas",
            "な 0 tentativas",
            "に 0 tentativas",
            "ぬ 0 tentativas",
            "ね 0 tentativas",
            "の 0 tentativas"});
            this.relatorio.Location = new System.Drawing.Point(54, 58);
            this.relatorio.Name = "relatorio";
            this.relatorio.Size = new System.Drawing.Size(266, 244);
            this.relatorio.TabIndex = 0;
            // 
            // fimMemorizacao
            // 
            this.fimMemorizacao.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fimMemorizacao.Location = new System.Drawing.Point(266, 404);
            this.fimMemorizacao.Name = "fimMemorizacao";
            this.fimMemorizacao.Size = new System.Drawing.Size(120, 34);
            this.fimMemorizacao.TabIndex = 3;
            this.fimMemorizacao.Text = "Fim";
            this.fimMemorizacao.UseVisualStyleBackColor = true;
            this.fimMemorizacao.Click += new System.EventHandler(this.fimMemorizacao_Click);
            // 
            // modulo
            // 
            this.modulo.Enabled = false;
            this.modulo.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.modulo.FormattingEnabled = true;
            this.modulo.Items.AddRange(new object[] {
            "A-O",
            "KA-KO",
            "SA-SO",
            "TA-TO",
            "NA-NO",
            "Todos os módulos"});
            this.modulo.Location = new System.Drawing.Point(212, 12);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(174, 23);
            this.modulo.TabIndex = 6;
            this.modulo.Text = "Selecione um módulo";
            this.modulo.SelectedValueChanged += new System.EventHandler(this.modulo_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.painelRelatorio);
            this.Controls.Add(this.letra);
            this.Controls.Add(this.tentativa);
            this.Controls.Add(this.alfabeto);
            this.Controls.Add(this.btnResposta);
            this.Controls.Add(this.fimMemorizacao);
            this.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memorizando os alfabetos japoneses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.painelRelatorio.ResumeLayout(false);
            this.painelRelatorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResposta;
        private System.Windows.Forms.ComboBox alfabeto;
        private System.Windows.Forms.TextBox tentativa;
        private System.Windows.Forms.Label letra;
        private System.Windows.Forms.Panel painelRelatorio;
        private System.Windows.Forms.Button memorizarMais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox relatorio;
        private System.Windows.Forms.Button fimMemorizacao;
        private System.Windows.Forms.ComboBox modulo;
    }
}


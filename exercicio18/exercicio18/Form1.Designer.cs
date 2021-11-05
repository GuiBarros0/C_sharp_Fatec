
namespace exercicio18
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CB_Genero = new System.Windows.Forms.ComboBox();
            this.TB_Idade = new System.Windows.Forms.TextBox();
            this.TB_Nome = new System.Windows.Forms.TextBox();
            this.B_Inclui = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.B_Procurar_A = new System.Windows.Forms.Button();
            this.TB_Procurado_A = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_GENERO_A = new System.Windows.Forms.ComboBox();
            this.TB_IDADE_A = new System.Windows.Forms.TextBox();
            this.TB_Nome_A = new System.Windows.Forms.TextBox();
            this.B_Altera = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.B_Procurar_E = new System.Windows.Forms.Button();
            this.TB_Procurado_E = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_GENERO_B = new System.Windows.Forms.ComboBox();
            this.TB_IDADE_B = new System.Windows.Forms.TextBox();
            this.TB_NOME_B = new System.Windows.Forms.TextBox();
            this.B_Exclui = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LB_Registros = new System.Windows.Forms.ListBox();
            this.B_Exibe = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 266);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tabPage2.Controls.Add(this.CB_Genero);
            this.tabPage2.Controls.Add(this.TB_Idade);
            this.tabPage2.Controls.Add(this.TB_Nome);
            this.tabPage2.Controls.Add(this.B_Inclui);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incluir";
            // 
            // CB_Genero
            // 
            this.CB_Genero.FormattingEnabled = true;
            this.CB_Genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CB_Genero.Location = new System.Drawing.Point(19, 124);
            this.CB_Genero.Name = "CB_Genero";
            this.CB_Genero.Size = new System.Drawing.Size(100, 21);
            this.CB_Genero.TabIndex = 6;
            // 
            // TB_Idade
            // 
            this.TB_Idade.Location = new System.Drawing.Point(19, 75);
            this.TB_Idade.Name = "TB_Idade";
            this.TB_Idade.Size = new System.Drawing.Size(100, 20);
            this.TB_Idade.TabIndex = 5;
            // 
            // TB_Nome
            // 
            this.TB_Nome.Location = new System.Drawing.Point(6, 36);
            this.TB_Nome.Name = "TB_Nome";
            this.TB_Nome.Size = new System.Drawing.Size(130, 20);
            this.TB_Nome.TabIndex = 4;
            // 
            // B_Inclui
            // 
            this.B_Inclui.Location = new System.Drawing.Point(29, 151);
            this.B_Inclui.Name = "B_Inclui";
            this.B_Inclui.Size = new System.Drawing.Size(75, 23);
            this.B_Inclui.TabIndex = 3;
            this.B_Inclui.Text = "Inclui";
            this.B_Inclui.UseVisualStyleBackColor = true;
            this.B_Inclui.Click += new System.EventHandler(this.B_Inclui_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gênero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tabPage3.Controls.Add(this.B_Procurar_A);
            this.tabPage3.Controls.Add(this.TB_Procurado_A);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.CB_GENERO_A);
            this.tabPage3.Controls.Add(this.TB_IDADE_A);
            this.tabPage3.Controls.Add(this.TB_Nome_A);
            this.tabPage3.Controls.Add(this.B_Altera);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(242, 291);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alterar";
            // 
            // B_Procurar_A
            // 
            this.B_Procurar_A.Location = new System.Drawing.Point(142, 33);
            this.B_Procurar_A.Name = "B_Procurar_A";
            this.B_Procurar_A.Size = new System.Drawing.Size(75, 23);
            this.B_Procurar_A.TabIndex = 16;
            this.B_Procurar_A.Text = "Procurar";
            this.B_Procurar_A.UseVisualStyleBackColor = true;
            this.B_Procurar_A.Click += new System.EventHandler(this.B_Procurar_A_Click);
            // 
            // TB_Procurado_A
            // 
            this.TB_Procurado_A.Location = new System.Drawing.Point(6, 36);
            this.TB_Procurado_A.Name = "TB_Procurado_A";
            this.TB_Procurado_A.Size = new System.Drawing.Size(130, 20);
            this.TB_Procurado_A.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nome procurado";
            // 
            // CB_GENERO_A
            // 
            this.CB_GENERO_A.FormattingEnabled = true;
            this.CB_GENERO_A.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CB_GENERO_A.Location = new System.Drawing.Point(23, 153);
            this.CB_GENERO_A.Name = "CB_GENERO_A";
            this.CB_GENERO_A.Size = new System.Drawing.Size(100, 21);
            this.CB_GENERO_A.TabIndex = 13;
            // 
            // TB_IDADE_A
            // 
            this.TB_IDADE_A.Location = new System.Drawing.Point(23, 114);
            this.TB_IDADE_A.Name = "TB_IDADE_A";
            this.TB_IDADE_A.Size = new System.Drawing.Size(100, 20);
            this.TB_IDADE_A.TabIndex = 12;
            // 
            // TB_Nome_A
            // 
            this.TB_Nome_A.Location = new System.Drawing.Point(6, 75);
            this.TB_Nome_A.Name = "TB_Nome_A";
            this.TB_Nome_A.Size = new System.Drawing.Size(130, 20);
            this.TB_Nome_A.TabIndex = 11;
            // 
            // B_Altera
            // 
            this.B_Altera.Location = new System.Drawing.Point(31, 180);
            this.B_Altera.Name = "B_Altera";
            this.B_Altera.Size = new System.Drawing.Size(75, 23);
            this.B_Altera.TabIndex = 10;
            this.B_Altera.Text = "Altera";
            this.B_Altera.UseVisualStyleBackColor = true;
            this.B_Altera.Click += new System.EventHandler(this.B_Altera_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gênero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Idade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tabPage1.Controls.Add(this.B_Procurar_E);
            this.tabPage1.Controls.Add(this.TB_Procurado_E);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.CB_GENERO_B);
            this.tabPage1.Controls.Add(this.TB_IDADE_B);
            this.tabPage1.Controls.Add(this.TB_NOME_B);
            this.tabPage1.Controls.Add(this.B_Exclui);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 291);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Excluir";
            // 
            // B_Procurar_E
            // 
            this.B_Procurar_E.Location = new System.Drawing.Point(142, 29);
            this.B_Procurar_E.Name = "B_Procurar_E";
            this.B_Procurar_E.Size = new System.Drawing.Size(75, 23);
            this.B_Procurar_E.TabIndex = 26;
            this.B_Procurar_E.Text = "Procurar";
            this.B_Procurar_E.UseVisualStyleBackColor = true;
            this.B_Procurar_E.Click += new System.EventHandler(this.B_Procurar_E_Click);
            // 
            // TB_Procurado_E
            // 
            this.TB_Procurado_E.Location = new System.Drawing.Point(6, 29);
            this.TB_Procurado_E.Name = "TB_Procurado_E";
            this.TB_Procurado_E.Size = new System.Drawing.Size(130, 20);
            this.TB_Procurado_E.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nome procurado";
            // 
            // CB_GENERO_B
            // 
            this.CB_GENERO_B.FormattingEnabled = true;
            this.CB_GENERO_B.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CB_GENERO_B.Location = new System.Drawing.Point(27, 146);
            this.CB_GENERO_B.Name = "CB_GENERO_B";
            this.CB_GENERO_B.Size = new System.Drawing.Size(100, 21);
            this.CB_GENERO_B.TabIndex = 23;
            // 
            // TB_IDADE_B
            // 
            this.TB_IDADE_B.Location = new System.Drawing.Point(27, 107);
            this.TB_IDADE_B.Name = "TB_IDADE_B";
            this.TB_IDADE_B.Size = new System.Drawing.Size(100, 20);
            this.TB_IDADE_B.TabIndex = 22;
            // 
            // TB_NOME_B
            // 
            this.TB_NOME_B.Location = new System.Drawing.Point(6, 68);
            this.TB_NOME_B.Name = "TB_NOME_B";
            this.TB_NOME_B.Size = new System.Drawing.Size(130, 20);
            this.TB_NOME_B.TabIndex = 21;
            // 
            // B_Exclui
            // 
            this.B_Exclui.Location = new System.Drawing.Point(35, 173);
            this.B_Exclui.Name = "B_Exclui";
            this.B_Exclui.Size = new System.Drawing.Size(75, 23);
            this.B_Exclui.TabIndex = 20;
            this.B_Exclui.Text = "Exclui";
            this.B_Exclui.UseVisualStyleBackColor = true;
            this.B_Exclui.Click += new System.EventHandler(this.B_Exclui_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gênero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Idade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nome";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tabPage4.Controls.Add(this.LB_Registros);
            this.tabPage4.Controls.Add(this.B_Exibe);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(242, 240);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Exibir";
            // 
            // LB_Registros
            // 
            this.LB_Registros.FormattingEnabled = true;
            this.LB_Registros.Location = new System.Drawing.Point(55, 47);
            this.LB_Registros.Name = "LB_Registros";
            this.LB_Registros.Size = new System.Drawing.Size(121, 160);
            this.LB_Registros.TabIndex = 1;
            // 
            // B_Exibe
            // 
            this.B_Exibe.Location = new System.Drawing.Point(55, 18);
            this.B_Exibe.Name = "B_Exibe";
            this.B_Exibe.Size = new System.Drawing.Size(121, 23);
            this.B_Exibe.TabIndex = 0;
            this.B_Exibe.Text = "Exibe os registros";
            this.B_Exibe.UseVisualStyleBackColor = true;
            this.B_Exibe.Click += new System.EventHandler(this.B_Exibe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(281, 307);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Gerenciar Pessoas - Lista linear encadeada";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CB_Genero;
        private System.Windows.Forms.TextBox TB_Idade;
        private System.Windows.Forms.TextBox TB_Nome;
        private System.Windows.Forms.Button B_Inclui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox LB_Registros;
        private System.Windows.Forms.Button B_Exibe;
        private System.Windows.Forms.Button B_Procurar_A;
        private System.Windows.Forms.TextBox TB_Procurado_A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_GENERO_A;
        private System.Windows.Forms.TextBox TB_IDADE_A;
        private System.Windows.Forms.TextBox TB_Nome_A;
        private System.Windows.Forms.Button B_Altera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B_Procurar_E;
        private System.Windows.Forms.TextBox TB_Procurado_E;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_GENERO_B;
        private System.Windows.Forms.TextBox TB_IDADE_B;
        private System.Windows.Forms.TextBox TB_NOME_B;
        private System.Windows.Forms.Button B_Exclui;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}


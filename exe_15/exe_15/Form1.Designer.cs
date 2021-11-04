
namespace exe_15
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
            this.tb_num_aviao = new System.Windows.Forms.TextBox();
            this.tb_num_quantidade = new System.Windows.Forms.TextBox();
            this.tb_num_autoriza = new System.Windows.Forms.TextBox();
            this.tb_num_primeiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_adiciona = new System.Windows.Forms.Button();
            this.b_quantidade = new System.Windows.Forms.Button();
            this.b_decolagem = new System.Windows.Forms.Button();
            this.b_primeiro = new System.Windows.Forms.Button();
            this.b_aviao_fila = new System.Windows.Forms.Button();
            this.lb_resultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_num_aviao
            // 
            this.tb_num_aviao.Location = new System.Drawing.Point(188, 46);
            this.tb_num_aviao.Name = "tb_num_aviao";
            this.tb_num_aviao.Size = new System.Drawing.Size(100, 20);
            this.tb_num_aviao.TabIndex = 0;
            // 
            // tb_num_quantidade
            // 
            this.tb_num_quantidade.Location = new System.Drawing.Point(188, 110);
            this.tb_num_quantidade.Name = "tb_num_quantidade";
            this.tb_num_quantidade.Size = new System.Drawing.Size(100, 20);
            this.tb_num_quantidade.TabIndex = 1;
            // 
            // tb_num_autoriza
            // 
            this.tb_num_autoriza.Location = new System.Drawing.Point(188, 139);
            this.tb_num_autoriza.Name = "tb_num_autoriza";
            this.tb_num_autoriza.Size = new System.Drawing.Size(100, 20);
            this.tb_num_autoriza.TabIndex = 3;
            // 
            // tb_num_primeiro
            // 
            this.tb_num_primeiro.Location = new System.Drawing.Point(188, 168);
            this.tb_num_primeiro.Name = "tb_num_primeiro";
            this.tb_num_primeiro.Size = new System.Drawing.Size(100, 20);
            this.tb_num_primeiro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Avião";
            // 
            // b_adiciona
            // 
            this.b_adiciona.Location = new System.Drawing.Point(15, 44);
            this.b_adiciona.Name = "b_adiciona";
            this.b_adiciona.Size = new System.Drawing.Size(109, 23);
            this.b_adiciona.TabIndex = 6;
            this.b_adiciona.Text = "Adiciona na fila";
            this.b_adiciona.UseVisualStyleBackColor = true;
            this.b_adiciona.Click += new System.EventHandler(this.b_adiciona_Click);
            // 
            // b_quantidade
            // 
            this.b_quantidade.Location = new System.Drawing.Point(15, 107);
            this.b_quantidade.Name = "b_quantidade";
            this.b_quantidade.Size = new System.Drawing.Size(109, 23);
            this.b_quantidade.TabIndex = 7;
            this.b_quantidade.Text = "Quantidade na fila";
            this.b_quantidade.UseVisualStyleBackColor = true;
            this.b_quantidade.Click += new System.EventHandler(this.b_quantidade_Click);
            // 
            // b_decolagem
            // 
            this.b_decolagem.Location = new System.Drawing.Point(15, 136);
            this.b_decolagem.Name = "b_decolagem";
            this.b_decolagem.Size = new System.Drawing.Size(109, 23);
            this.b_decolagem.TabIndex = 8;
            this.b_decolagem.Text = "Autoriza decolagem";
            this.b_decolagem.UseVisualStyleBackColor = true;
            this.b_decolagem.Click += new System.EventHandler(this.b_decolagem_Click);
            // 
            // b_primeiro
            // 
            this.b_primeiro.Location = new System.Drawing.Point(15, 165);
            this.b_primeiro.Name = "b_primeiro";
            this.b_primeiro.Size = new System.Drawing.Size(109, 23);
            this.b_primeiro.TabIndex = 9;
            this.b_primeiro.Text = "Primeiro na fila";
            this.b_primeiro.UseVisualStyleBackColor = true;
            this.b_primeiro.Click += new System.EventHandler(this.b_primeiro_Click);
            // 
            // b_aviao_fila
            // 
            this.b_aviao_fila.Location = new System.Drawing.Point(326, 47);
            this.b_aviao_fila.Name = "b_aviao_fila";
            this.b_aviao_fila.Size = new System.Drawing.Size(75, 23);
            this.b_aviao_fila.TabIndex = 10;
            this.b_aviao_fila.Text = "Avião na fila";
            this.b_aviao_fila.UseVisualStyleBackColor = true;
            this.b_aviao_fila.Click += new System.EventHandler(this.b_aviao_fila_Click);
            // 
            // lb_resultados
            // 
            this.lb_resultados.FormattingEnabled = true;
            this.lb_resultados.Location = new System.Drawing.Point(304, 76);
            this.lb_resultados.Name = "lb_resultados";
            this.lb_resultados.Size = new System.Drawing.Size(120, 108);
            this.lb_resultados.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(455, 227);
            this.Controls.Add(this.lb_resultados);
            this.Controls.Add(this.b_aviao_fila);
            this.Controls.Add(this.b_primeiro);
            this.Controls.Add(this.b_decolagem);
            this.Controls.Add(this.b_quantidade);
            this.Controls.Add(this.b_adiciona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_num_primeiro);
            this.Controls.Add(this.tb_num_autoriza);
            this.Controls.Add(this.tb_num_quantidade);
            this.Controls.Add(this.tb_num_aviao);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Avião_fila";
            this.TransparencyKey = System.Drawing.Color.LightSeaGreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_num_aviao;
        private System.Windows.Forms.TextBox tb_num_quantidade;
        private System.Windows.Forms.TextBox tb_num_autoriza;
        private System.Windows.Forms.TextBox tb_num_primeiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_adiciona;
        private System.Windows.Forms.Button b_quantidade;
        private System.Windows.Forms.Button b_decolagem;
        private System.Windows.Forms.Button b_primeiro;
        private System.Windows.Forms.Button b_aviao_fila;
        private System.Windows.Forms.ListBox lb_resultados;
    }
}


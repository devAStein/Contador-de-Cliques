namespace atividade3
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
            this.numeroClick = new System.Windows.Forms.Label();
            this.somar = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.contadorClick = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeroClick
            // 
            this.numeroClick.AutoSize = true;
            this.numeroClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroClick.Location = new System.Drawing.Point(23, 53);
            this.numeroClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeroClick.Name = "numeroClick";
            this.numeroClick.Size = new System.Drawing.Size(310, 39);
            this.numeroClick.TabIndex = 0;
            this.numeroClick.Text = "Número de cliques:";
            this.numeroClick.Click += new System.EventHandler(this.numeroClick_Click);
            // 
            // somar
            // 
            this.somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somar.Location = new System.Drawing.Point(252, 191);
            this.somar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(43, 46);
            this.somar.TabIndex = 1;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // subtrair
            // 
            this.subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtrair.Location = new System.Drawing.Point(309, 191);
            this.subtrair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(43, 46);
            this.subtrair.TabIndex = 2;
            this.subtrair.Text = "-";
            this.subtrair.UseVisualStyleBackColor = true;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(380, 191);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(199, 46);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // contadorClick
            // 
            this.contadorClick.AutoSize = true;
            this.contadorClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorClick.Location = new System.Drawing.Point(360, 53);
            this.contadorClick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contadorClick.Name = "contadorClick";
            this.contadorClick.Size = new System.Drawing.Size(36, 39);
            this.contadorClick.TabIndex = 4;
            this.contadorClick.Text = "0";
            // 
            // iniciar
            // 
            this.iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.Location = new System.Drawing.Point(16, 189);
            this.iniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(216, 48);
            this.iniciar.TabIndex = 5;
            this.iniciar.Text = "Clique Aqui";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(607, 389);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.contadorClick);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.numeroClick);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Cliques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroClick;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label contadorClick;
        private System.Windows.Forms.Button iniciar;
    }
}


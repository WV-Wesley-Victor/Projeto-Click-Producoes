namespace ProjetoG3_Fotografo
{
    partial class UserControlDias
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbDias = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbEvento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDias.Location = new System.Drawing.Point(12, 9);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(25, 20);
            this.lbDias.TabIndex = 0;
            this.lbDias.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbEvento
            // 
            this.LbEvento.Location = new System.Drawing.Point(3, 39);
            this.LbEvento.Name = "LbEvento";
            this.LbEvento.Size = new System.Drawing.Size(95, 23);
            this.LbEvento.TabIndex = 2;
            this.LbEvento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LbEvento);
            this.Controls.Add(this.lbDias);
            this.Name = "UserControlDias";
            this.Size = new System.Drawing.Size(101, 62);
            this.Load += new System.EventHandler(this.UserControlDias_Load);
            this.Click += new System.EventHandler(this.UserControlDias_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbDias;
        private System.Windows.Forms.Timer timer1;
        private Label LbEvento;
    }
}

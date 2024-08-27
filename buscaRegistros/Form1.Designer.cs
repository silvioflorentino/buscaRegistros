namespace buscaRegistros
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
            this.comboBoxTemporadas = new System.Windows.Forms.ComboBox();
            this.comboBoxEpisodios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxTemporadas
            // 
            this.comboBoxTemporadas.FormattingEnabled = true;
            this.comboBoxTemporadas.Location = new System.Drawing.Point(166, 138);
            this.comboBoxTemporadas.Name = "comboBoxTemporadas";
            this.comboBoxTemporadas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTemporadas.TabIndex = 0;
            // 
            // comboBoxEpisodios
            // 
            this.comboBoxEpisodios.FormattingEnabled = true;
            this.comboBoxEpisodios.Location = new System.Drawing.Point(402, 138);
            this.comboBoxEpisodios.Name = "comboBoxEpisodios";
            this.comboBoxEpisodios.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEpisodios.TabIndex = 1;
            this.comboBoxTemporadas.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemporadas_SelectedIndexChanged);


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxEpisodios);
            this.Controls.Add(this.comboBoxTemporadas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTemporadas;
        private System.Windows.Forms.ComboBox comboBoxEpisodios;
    }
}


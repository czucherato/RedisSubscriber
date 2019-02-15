namespace RedisSubscriber
{
    partial class Resposta
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
            this.LblPergunta = new System.Windows.Forms.Label();
            this.TxtPergunta = new System.Windows.Forms.TextBox();
            this.CkInscrever = new System.Windows.Forms.CheckBox();
            this.LblResposta = new System.Windows.Forms.Label();
            this.TxtResposta = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPergunta
            // 
            this.LblPergunta.AutoSize = true;
            this.LblPergunta.Location = new System.Drawing.Point(12, 22);
            this.LblPergunta.Name = "LblPergunta";
            this.LblPergunta.Size = new System.Drawing.Size(55, 13);
            this.LblPergunta.TabIndex = 4;
            this.LblPergunta.Text = "Perguntas";
            // 
            // TxtPergunta
            // 
            this.TxtPergunta.Enabled = false;
            this.TxtPergunta.Location = new System.Drawing.Point(15, 38);
            this.TxtPergunta.Multiline = true;
            this.TxtPergunta.Name = "TxtPergunta";
            this.TxtPergunta.Size = new System.Drawing.Size(347, 185);
            this.TxtPergunta.TabIndex = 6;
            // 
            // CkInscrever
            // 
            this.CkInscrever.AutoSize = true;
            this.CkInscrever.Location = new System.Drawing.Point(15, 229);
            this.CkInscrever.Name = "CkInscrever";
            this.CkInscrever.Size = new System.Drawing.Size(84, 17);
            this.CkInscrever.TabIndex = 7;
            this.CkInscrever.Text = "Inscrever-se";
            this.CkInscrever.UseVisualStyleBackColor = true;
            this.CkInscrever.CheckedChanged += new System.EventHandler(this.CkInscrever_CheckedChanged);
            // 
            // LblResposta
            // 
            this.LblResposta.AutoSize = true;
            this.LblResposta.Location = new System.Drawing.Point(12, 259);
            this.LblResposta.Name = "LblResposta";
            this.LblResposta.Size = new System.Drawing.Size(52, 13);
            this.LblResposta.TabIndex = 8;
            this.LblResposta.Text = "Resposta";
            // 
            // TxtResposta
            // 
            this.TxtResposta.Location = new System.Drawing.Point(15, 273);
            this.TxtResposta.Name = "TxtResposta";
            this.TxtResposta.Size = new System.Drawing.Size(265, 20);
            this.TxtResposta.TabIndex = 9;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(287, 270);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 10;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // Resposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 305);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtResposta);
            this.Controls.Add(this.LblResposta);
            this.Controls.Add(this.CkInscrever);
            this.Controls.Add(this.TxtPergunta);
            this.Controls.Add(this.LblPergunta);
            this.Name = "Resposta";
            this.Text = "Resposta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPergunta;
        private System.Windows.Forms.TextBox TxtPergunta;
        private System.Windows.Forms.CheckBox CkInscrever;
        private System.Windows.Forms.Label LblResposta;
        private System.Windows.Forms.TextBox TxtResposta;
        private System.Windows.Forms.Button BtnEnviar;
    }
}
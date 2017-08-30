namespace FormatarValoresParaQuery
{
    partial class Form1
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
            this.txtIn = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnGerarCopiar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(12, 12);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(331, 143);
            this.txtIn.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(350, 12);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(121, 49);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(350, 67);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(121, 49);
            this.btnCopiar.TabIndex = 2;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtOut
            // 
            this.txtOut.Enabled = false;
            this.txtOut.Location = new System.Drawing.Point(12, 161);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(330, 116);
            this.txtOut.TabIndex = 3;
            // 
            // btnGerarCopiar
            // 
            this.btnGerarCopiar.Location = new System.Drawing.Point(350, 122);
            this.btnGerarCopiar.Name = "btnGerarCopiar";
            this.btnGerarCopiar.Size = new System.Drawing.Size(121, 49);
            this.btnGerarCopiar.TabIndex = 4;
            this.btnGerarCopiar.Text = "Gerar e Copiar";
            this.btnGerarCopiar.UseVisualStyleBackColor = true;
            this.btnGerarCopiar.Click += new System.EventHandler(this.btnGerarCopiar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(350, 177);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 49);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 287);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerarCopiar);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnGerarCopiar;
        private System.Windows.Forms.Button btnLimpar;
    }
}


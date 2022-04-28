
namespace MenuX
{
    partial class Menusx
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
            this.register = new System.Windows.Forms.Button();
            this.consult = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(90, 30);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(123, 43);
            this.register.TabIndex = 0;
            this.register.Text = "Cadastrar";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // consult
            // 
            this.consult.Location = new System.Drawing.Point(90, 91);
            this.consult.Name = "consult";
            this.consult.Size = new System.Drawing.Size(123, 43);
            this.consult.TabIndex = 1;
            this.consult.Text = "Consultar";
            this.consult.UseVisualStyleBackColor = true;
            this.consult.Click += new System.EventHandler(this.consult_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(90, 151);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(123, 43);
            this.update.TabIndex = 2;
            this.update.Text = "Atualizar";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(90, 210);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(123, 43);
            this.delete.TabIndex = 3;
            this.delete.Text = "Excluir";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Menusx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 316);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.consult);
            this.Controls.Add(this.register);
            this.Name = "Menusx";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menusx_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button consult;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
    }
}


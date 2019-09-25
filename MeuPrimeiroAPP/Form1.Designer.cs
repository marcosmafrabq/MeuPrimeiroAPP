namespace MeuPrimeiroAPP
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
            this.Ligar = new System.Windows.Forms.Button();
            this.Desligar = new System.Windows.Forms.Button();
            this.Detalhes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ligar
            // 
            this.Ligar.Location = new System.Drawing.Point(109, 92);
            this.Ligar.Name = "Ligar";
            this.Ligar.Size = new System.Drawing.Size(124, 44);
            this.Ligar.TabIndex = 0;
            this.Ligar.Text = "Ligar";
            this.Ligar.UseVisualStyleBackColor = true;
            this.Ligar.Click += new System.EventHandler(this.Ligar_Click);
            // 
            // Desligar
            // 
            this.Desligar.Location = new System.Drawing.Point(387, 92);
            this.Desligar.Name = "Desligar";
            this.Desligar.Size = new System.Drawing.Size(99, 44);
            this.Desligar.TabIndex = 1;
            this.Desligar.Text = "Desligar";
            this.Desligar.UseVisualStyleBackColor = true;
            this.Desligar.Click += new System.EventHandler(this.Desligar_Click);
            // 
            // Detalhes
            // 
            this.Detalhes.Location = new System.Drawing.Point(636, 92);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(91, 44);
            this.Detalhes.TabIndex = 2;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(858, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Detalhes);
            this.Controls.Add(this.Desligar);
            this.Controls.Add(this.Ligar);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MeuPrimeiroBotao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MeuSegundoBotao;
        private System.Windows.Forms.Button Ligar;
        private System.Windows.Forms.Button Desligar;
        private System.Windows.Forms.Button Detalhes;
        private System.Windows.Forms.Button button1;
    }
}


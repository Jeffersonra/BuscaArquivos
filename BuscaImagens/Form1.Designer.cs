namespace BuscaImagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcessando = new System.Windows.Forms.Label();
            this.selectPath = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(597, 99);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(90, 30);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Processar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtdestino
            // 
            this.txtdestino.Location = new System.Drawing.Point(81, 69);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(559, 20);
            this.txtdestino.TabIndex = 4;
            this.txtdestino.TextChanged += new System.EventHandler(this.txtdestino_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arquivo txt: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arquivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProcessando
            // 
            this.txtProcessando.AutoSize = true;
            this.txtProcessando.Location = new System.Drawing.Point(33, 23);
            this.txtProcessando.Name = "txtProcessando";
            this.txtProcessando.Size = new System.Drawing.Size(72, 13);
            this.txtProcessando.TabIndex = 7;
            this.txtProcessando.Text = "Processando:";
            this.txtProcessando.Click += new System.EventHandler(this.label3_Click);
            // 
            // selectPath
            // 
            this.selectPath.Image = global::BuscaImagens.Properties.Resources._1493190937_BT_folder_blanc;
            this.selectPath.Location = new System.Drawing.Point(644, 68);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(43, 23);
            this.selectPath.TabIndex = 8;
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 141);
            this.Controls.Add(this.selectPath);
            this.Controls.Add(this.txtProcessando);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdestino);
            this.Controls.Add(this.btnProcurar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robô Copia Arquivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtProcessando;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}


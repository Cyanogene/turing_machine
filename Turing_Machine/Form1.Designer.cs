
namespace Turing_Machine
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_input = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_AddizioneBinaria = new System.Windows.Forms.Button();
            this.lbl_puntatore = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_CompilaAlgoritmo = new System.Windows.Forms.Button();
            this.btn_EseguiCustom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(373, 127);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(0, 30);
            this.lbl_input.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // btn_AddizioneBinaria
            // 
            this.btn_AddizioneBinaria.Location = new System.Drawing.Point(202, 219);
            this.btn_AddizioneBinaria.Name = "btn_AddizioneBinaria";
            this.btn_AddizioneBinaria.Size = new System.Drawing.Size(113, 49);
            this.btn_AddizioneBinaria.TabIndex = 2;
            this.btn_AddizioneBinaria.Text = "Addizione Binaria";
            this.btn_AddizioneBinaria.UseVisualStyleBackColor = true;
            this.btn_AddizioneBinaria.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_puntatore
            // 
            this.lbl_puntatore.AutoSize = true;
            this.lbl_puntatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_puntatore.Location = new System.Drawing.Point(370, 88);
            this.lbl_puntatore.Name = "lbl_puntatore";
            this.lbl_puntatore.Size = new System.Drawing.Size(34, 39);
            this.lbl_puntatore.TabIndex = 3;
            this.lbl_puntatore.Text = "↓";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 359);
            this.textBox2.TabIndex = 4;
            // 
            // btn_CompilaAlgoritmo
            // 
            this.btn_CompilaAlgoritmo.Location = new System.Drawing.Point(330, 340);
            this.btn_CompilaAlgoritmo.Name = "btn_CompilaAlgoritmo";
            this.btn_CompilaAlgoritmo.Size = new System.Drawing.Size(75, 23);
            this.btn_CompilaAlgoritmo.TabIndex = 5;
            this.btn_CompilaAlgoritmo.Text = "Compila";
            this.btn_CompilaAlgoritmo.UseVisualStyleBackColor = true;
            this.btn_CompilaAlgoritmo.Click += new System.EventHandler(this.btn_CompilaAlgoritmo_Click);
            // 
            // btn_EseguiCustom
            // 
            this.btn_EseguiCustom.Location = new System.Drawing.Point(423, 339);
            this.btn_EseguiCustom.Name = "btn_EseguiCustom";
            this.btn_EseguiCustom.Size = new System.Drawing.Size(75, 23);
            this.btn_EseguiCustom.TabIndex = 6;
            this.btn_EseguiCustom.Text = "Esegui";
            this.btn_EseguiCustom.UseVisualStyleBackColor = true;
            this.btn_EseguiCustom.Click += new System.EventHandler(this.btn_EseguiCustom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_EseguiCustom);
            this.Controls.Add(this.btn_CompilaAlgoritmo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_puntatore);
            this.Controls.Add(this.btn_AddizioneBinaria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_AddizioneBinaria;
        private System.Windows.Forms.Label lbl_puntatore;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_CompilaAlgoritmo;
        private System.Windows.Forms.Button btn_EseguiCustom;
    }
}


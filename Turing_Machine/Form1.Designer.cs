
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_AddizioneBinaria = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_CompilaAlgoritmo = new System.Windows.Forms.Button();
            this.btn_EseguiCustom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 426);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(338, 168);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(36, 46);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DataGridView1_ColumnAdded);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_EseguiCustom);
            this.Controls.Add(this.btn_CompilaAlgoritmo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_AddizioneBinaria);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_AddizioneBinaria;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_CompilaAlgoritmo;
        private System.Windows.Forms.Button btn_EseguiCustom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


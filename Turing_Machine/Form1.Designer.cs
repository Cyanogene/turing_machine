
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_AddizioneBinaria = new System.Windows.Forms.Button();
            this.txt_ScriviAlgoritmo = new System.Windows.Forms.TextBox();
            this.btn_CompilaAlgoritmo = new System.Windows.Forms.Button();
            this.btn_EseguiCustom = new System.Windows.Forms.Button();
            this.dgv_nastro = new System.Windows.Forms.DataGridView();
            this.btn_AggiungiCellaInizio = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_divisibile3 = new System.Windows.Forms.Button();
            this.btn_numPari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nastro)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddizioneBinaria
            // 
            this.btn_AddizioneBinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddizioneBinaria.Location = new System.Drawing.Point(864, 150);
            this.btn_AddizioneBinaria.Name = "btn_AddizioneBinaria";
            this.btn_AddizioneBinaria.Size = new System.Drawing.Size(330, 51);
            this.btn_AddizioneBinaria.TabIndex = 2;
            this.btn_AddizioneBinaria.Text = "Esegui addizione binaria";
            this.btn_AddizioneBinaria.UseVisualStyleBackColor = true;
            this.btn_AddizioneBinaria.Click += new System.EventHandler(this.btn_AddizioneBinaria_Click);
            // 
            // txt_ScriviAlgoritmo
            // 
            this.txt_ScriviAlgoritmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ScriviAlgoritmo.Location = new System.Drawing.Point(12, 12);
            this.txt_ScriviAlgoritmo.Multiline = true;
            this.txt_ScriviAlgoritmo.Name = "txt_ScriviAlgoritmo";
            this.txt_ScriviAlgoritmo.Size = new System.Drawing.Size(234, 616);
            this.txt_ScriviAlgoritmo.TabIndex = 4;
            // 
            // btn_CompilaAlgoritmo
            // 
            this.btn_CompilaAlgoritmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompilaAlgoritmo.Location = new System.Drawing.Point(252, 87);
            this.btn_CompilaAlgoritmo.Name = "btn_CompilaAlgoritmo";
            this.btn_CompilaAlgoritmo.Size = new System.Drawing.Size(162, 40);
            this.btn_CompilaAlgoritmo.TabIndex = 5;
            this.btn_CompilaAlgoritmo.Text = "Compila";
            this.btn_CompilaAlgoritmo.UseVisualStyleBackColor = true;
            this.btn_CompilaAlgoritmo.Click += new System.EventHandler(this.btn_CompilaAlgoritmo_Click);
            // 
            // btn_EseguiCustom
            // 
            this.btn_EseguiCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EseguiCustom.Location = new System.Drawing.Point(252, 133);
            this.btn_EseguiCustom.Name = "btn_EseguiCustom";
            this.btn_EseguiCustom.Size = new System.Drawing.Size(162, 40);
            this.btn_EseguiCustom.TabIndex = 6;
            this.btn_EseguiCustom.Text = "Esegui";
            this.btn_EseguiCustom.UseVisualStyleBackColor = true;
            this.btn_EseguiCustom.Click += new System.EventHandler(this.btn_EseguiCustom_Click);
            // 
            // dgv_nastro
            // 
            this.dgv_nastro.AllowUserToAddRows = false;
            this.dgv_nastro.AllowUserToDeleteRows = false;
            this.dgv_nastro.AllowUserToResizeColumns = false;
            this.dgv_nastro.AllowUserToResizeRows = false;
            this.dgv_nastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgv_nastro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_nastro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_nastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nastro.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nastro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_nastro.Location = new System.Drawing.Point(252, 12);
            this.dgv_nastro.MultiSelect = false;
            this.dgv_nastro.Name = "dgv_nastro";
            this.dgv_nastro.RowHeadersVisible = false;
            this.dgv_nastro.Size = new System.Drawing.Size(942, 69);
            this.dgv_nastro.TabIndex = 7;
            this.dgv_nastro.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // btn_AggiungiCellaInizio
            // 
            this.btn_AggiungiCellaInizio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AggiungiCellaInizio.Location = new System.Drawing.Point(864, 87);
            this.btn_AggiungiCellaInizio.Name = "btn_AggiungiCellaInizio";
            this.btn_AggiungiCellaInizio.Size = new System.Drawing.Size(330, 45);
            this.btn_AggiungiCellaInizio.TabIndex = 8;
            this.btn_AggiungiCellaInizio.Text = "Sposta nastro a destra";
            this.btn_AggiungiCellaInizio.UseVisualStyleBackColor = true;
            this.btn_AggiungiCellaInizio.Click += new System.EventHandler(this.btn_AggiungiCellaInizio_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Location = new System.Drawing.Point(252, 179);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(162, 51);
            this.btn_Help.TabIndex = 9;
            this.btn_Help.Text = "Apri manuale";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.Btn_Help_Click);
            // 
            // btn_divisibile3
            // 
            this.btn_divisibile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divisibile3.Location = new System.Drawing.Point(864, 207);
            this.btn_divisibile3.Name = "btn_divisibile3";
            this.btn_divisibile3.Size = new System.Drawing.Size(330, 65);
            this.btn_divisibile3.TabIndex = 10;
            this.btn_divisibile3.Text = "Controlla se il numero binario è divisibile per 3";
            this.btn_divisibile3.UseVisualStyleBackColor = true;
            this.btn_divisibile3.Click += new System.EventHandler(this.btn_divisibile3_Click);
            // 
            // btn_numPari
            // 
            this.btn_numPari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_numPari.Location = new System.Drawing.Point(864, 278);
            this.btn_numPari.Name = "btn_numPari";
            this.btn_numPari.Size = new System.Drawing.Size(330, 67);
            this.btn_numPari.TabIndex = 11;
            this.btn_numPari.Text = "Controlla se il numero binario ha un numero pari di \"0\"";
            this.btn_numPari.UseVisualStyleBackColor = true;
            this.btn_numPari.Click += new System.EventHandler(this.btn_numPari_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.btn_numPari);
            this.Controls.Add(this.btn_divisibile3);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_AggiungiCellaInizio);
            this.Controls.Add(this.dgv_nastro);
            this.Controls.Add(this.btn_EseguiCustom);
            this.Controls.Add(this.btn_CompilaAlgoritmo);
            this.Controls.Add(this.txt_ScriviAlgoritmo);
            this.Controls.Add(this.btn_AddizioneBinaria);
            this.MaximumSize = new System.Drawing.Size(1270, 688);
            this.MinimumSize = new System.Drawing.Size(1270, 688);
            this.Name = "Form1";
            this.Text = "Macchina di Turing";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddizioneBinaria;
        private System.Windows.Forms.TextBox txt_ScriviAlgoritmo;
        private System.Windows.Forms.Button btn_CompilaAlgoritmo;
        private System.Windows.Forms.Button btn_EseguiCustom;
        private System.Windows.Forms.DataGridView dgv_nastro;
        private System.Windows.Forms.Button btn_AggiungiCellaInizio;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_divisibile3;
        private System.Windows.Forms.Button btn_numPari;
    }
}


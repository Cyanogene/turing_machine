
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_AddizioneBinaria = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_CompilaAlgoritmo = new System.Windows.Forms.Button();
            this.btn_EseguiCustom = new System.Windows.Forms.Button();
            this.dgv_nastro = new System.Windows.Forms.DataGridView();
            this.btn_AggiungiCellaInizio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nastro)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddizioneBinaria
            // 
            this.btn_AddizioneBinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddizioneBinaria.Location = new System.Drawing.Point(864, 138);
            this.btn_AddizioneBinaria.Name = "btn_AddizioneBinaria";
            this.btn_AddizioneBinaria.Size = new System.Drawing.Size(330, 51);
            this.btn_AddizioneBinaria.TabIndex = 2;
            this.btn_AddizioneBinaria.Text = "Addizione binaria";
            this.btn_AddizioneBinaria.UseVisualStyleBackColor = true;
            this.btn_AddizioneBinaria.Click += new System.EventHandler(this.btn_AddizioneBinaria_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 616);
            this.textBox2.TabIndex = 4;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nastro.DefaultCellStyle = dataGridViewCellStyle1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 649);
            this.Controls.Add(this.btn_AggiungiCellaInizio);
            this.Controls.Add(this.dgv_nastro);
            this.Controls.Add(this.btn_EseguiCustom);
            this.Controls.Add(this.btn_CompilaAlgoritmo);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_CompilaAlgoritmo;
        private System.Windows.Forms.Button btn_EseguiCustom;
        private System.Windows.Forms.DataGridView dgv_nastro;
        private System.Windows.Forms.Button btn_AggiungiCellaInizio;
    }
}


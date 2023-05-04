namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.meseriDataSet = new WindowsFormsApplication1.meseriDataSet();
            this.tabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelTableAdapter = new WindowsFormsApplication1.meseriDataSetTableAdapters.tabelTableAdapter();
            this.numeleMeserieiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oreLucratePeSaptamanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuBrutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticheteDeMasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studiiNecesareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meseriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeleMeserieiDataGridViewTextBoxColumn,
            this.oreLucratePeSaptamanaDataGridViewTextBoxColumn,
            this.salariuBrutDataGridViewTextBoxColumn,
            this.salariuNetDataGridViewTextBoxColumn,
            this.ticheteDeMasaDataGridViewTextBoxColumn,
            this.studiiNecesareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // meseriDataSet
            // 
            this.meseriDataSet.DataSetName = "meseriDataSet";
            this.meseriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelBindingSource
            // 
            this.tabelBindingSource.DataMember = "tabel";
            this.tabelBindingSource.DataSource = this.meseriDataSet;
            // 
            // tabelTableAdapter
            // 
            this.tabelTableAdapter.ClearBeforeFill = true;
            // 
            // numeleMeserieiDataGridViewTextBoxColumn
            // 
            this.numeleMeserieiDataGridViewTextBoxColumn.DataPropertyName = "Numele meseriei";
            this.numeleMeserieiDataGridViewTextBoxColumn.HeaderText = "Numele meseriei";
            this.numeleMeserieiDataGridViewTextBoxColumn.Name = "numeleMeserieiDataGridViewTextBoxColumn";
            // 
            // oreLucratePeSaptamanaDataGridViewTextBoxColumn
            // 
            this.oreLucratePeSaptamanaDataGridViewTextBoxColumn.DataPropertyName = "Ore lucrate pe saptamana";
            this.oreLucratePeSaptamanaDataGridViewTextBoxColumn.HeaderText = "Ore lucrate pe saptamana";
            this.oreLucratePeSaptamanaDataGridViewTextBoxColumn.Name = "oreLucratePeSaptamanaDataGridViewTextBoxColumn";
            // 
            // salariuBrutDataGridViewTextBoxColumn
            // 
            this.salariuBrutDataGridViewTextBoxColumn.DataPropertyName = "Salariu brut";
            this.salariuBrutDataGridViewTextBoxColumn.HeaderText = "Salariu brut";
            this.salariuBrutDataGridViewTextBoxColumn.Name = "salariuBrutDataGridViewTextBoxColumn";
            // 
            // salariuNetDataGridViewTextBoxColumn
            // 
            this.salariuNetDataGridViewTextBoxColumn.DataPropertyName = "Salariu net";
            this.salariuNetDataGridViewTextBoxColumn.HeaderText = "Salariu net";
            this.salariuNetDataGridViewTextBoxColumn.Name = "salariuNetDataGridViewTextBoxColumn";
            // 
            // ticheteDeMasaDataGridViewTextBoxColumn
            // 
            this.ticheteDeMasaDataGridViewTextBoxColumn.DataPropertyName = "Tichete de masa";
            this.ticheteDeMasaDataGridViewTextBoxColumn.HeaderText = "Tichete de masa";
            this.ticheteDeMasaDataGridViewTextBoxColumn.Name = "ticheteDeMasaDataGridViewTextBoxColumn";
            // 
            // studiiNecesareDataGridViewTextBoxColumn
            // 
            this.studiiNecesareDataGridViewTextBoxColumn.DataPropertyName = "Studii necesare";
            this.studiiNecesareDataGridViewTextBoxColumn.HeaderText = "Studii necesare";
            this.studiiNecesareDataGridViewTextBoxColumn.Name = "studiiNecesareDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Afisare meserii";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(544, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Revenire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.steel_brushed_wallpaper_simson_images_135096;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meseriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private meseriDataSet meseriDataSet;
        private System.Windows.Forms.BindingSource tabelBindingSource;
        private meseriDataSetTableAdapters.tabelTableAdapter tabelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeleMeserieiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oreLucratePeSaptamanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuBrutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticheteDeMasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studiiNecesareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
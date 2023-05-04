namespace WindowsFormsApplication1
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordonareToolStrip = new System.Windows.Forms.ToolStrip();
            this.ordonareToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.numeleMeserieiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oreLucratePeSaptamanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuBrutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticheteDeMasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studiiNecesareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meseriDataSet3 = new WindowsFormsApplication1.meseriDataSet3();
            this.tabelTableAdapter = new WindowsFormsApplication1.meseriDataSet3TableAdapters.tabelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ordonareToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meseriDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sortare dupa ore lucrate";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(589, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Revenire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(50, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sortare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 175);
            this.dataGridView1.TabIndex = 3;
            // 
            // ordonareToolStrip
            // 
            this.ordonareToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordonareToolStripButton});
            this.ordonareToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ordonareToolStrip.Name = "ordonareToolStrip";
            this.ordonareToolStrip.Size = new System.Drawing.Size(720, 25);
            this.ordonareToolStrip.TabIndex = 4;
            this.ordonareToolStrip.Text = "ordonareToolStrip";
            // 
            // ordonareToolStripButton
            // 
            this.ordonareToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ordonareToolStripButton.Name = "ordonareToolStripButton";
            this.ordonareToolStripButton.Size = new System.Drawing.Size(59, 22);
            this.ordonareToolStripButton.Text = "ordonare";
            this.ordonareToolStripButton.Click += new System.EventHandler(this.ordonareToolStripButton_Click);
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
            // tabelBindingSource
            // 
            this.tabelBindingSource.DataMember = "tabel";
            this.tabelBindingSource.DataSource = this.meseriDataSet3;
            // 
            // meseriDataSet3
            // 
            this.meseriDataSet3.DataSetName = "meseriDataSet3";
            this.meseriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelTableAdapter
            // 
            this.tabelTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.steel_brushed_wallpaper_simson_images_1350963;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 333);
            this.Controls.Add(this.ordonareToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ordonareToolStrip.ResumeLayout(false);
            this.ordonareToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meseriDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private meseriDataSet3 meseriDataSet3;
        private System.Windows.Forms.BindingSource tabelBindingSource;
        private meseriDataSet3TableAdapters.tabelTableAdapter tabelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeleMeserieiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oreLucratePeSaptamanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuBrutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticheteDeMasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studiiNecesareDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip ordonareToolStrip;
        private System.Windows.Forms.ToolStripButton ordonareToolStripButton;
    }
}
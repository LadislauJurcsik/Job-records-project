namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeleMeserieiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oreLucratePeSaptamanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuBrutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticheteDeMasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studiiNecesareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meseriDataSet1 = new WindowsFormsApplication1.meseriDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cautareToolStrip = new System.Windows.Forms.ToolStrip();
            this.wToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.wToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.cautareToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabelTableAdapter = new WindowsFormsApplication1.meseriDataSet1TableAdapters.tabelTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meseriDataSet1)).BeginInit();
            this.cautareToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(536, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Revenire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(33, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 198);
            this.dataGridView1.TabIndex = 1;
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
            this.tabelBindingSource.DataSource = this.meseriDataSet1;
            // 
            // meseriDataSet1
            // 
            this.meseriDataSet1.DataSetName = "meseriDataSet1";
            this.meseriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduceti meseria cautata";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(162, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cautare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cautareToolStrip
            // 
            this.cautareToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wToolStripLabel,
            this.wToolStripTextBox,
            this.cautareToolStripButton});
            this.cautareToolStrip.Location = new System.Drawing.Point(0, 0);
            this.cautareToolStrip.Name = "cautareToolStrip";
            this.cautareToolStrip.Size = new System.Drawing.Size(719, 25);
            this.cautareToolStrip.TabIndex = 5;
            this.cautareToolStrip.Text = "cautareToolStrip";
            // 
            // wToolStripLabel
            // 
            this.wToolStripLabel.Name = "wToolStripLabel";
            this.wToolStripLabel.Size = new System.Drawing.Size(21, 22);
            this.wToolStripLabel.Text = "W:";
            // 
            // wToolStripTextBox
            // 
            this.wToolStripTextBox.Name = "wToolStripTextBox";
            this.wToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // cautareToolStripButton
            // 
            this.cautareToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cautareToolStripButton.Name = "cautareToolStripButton";
            this.cautareToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.cautareToolStripButton.Text = "Cautare";
            this.cautareToolStripButton.Click += new System.EventHandler(this.cautareToolStripButton_Click);
            // 
            // tabelTableAdapter
            // 
            this.tabelTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cautare meserii";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.steel_brushed_wallpaper_simson_images_1350961;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cautareToolStrip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meseriDataSet1)).EndInit();
            this.cautareToolStrip.ResumeLayout(false);
            this.cautareToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private meseriDataSet1 meseriDataSet1;
        private System.Windows.Forms.BindingSource tabelBindingSource;
        private meseriDataSet1TableAdapters.tabelTableAdapter tabelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeleMeserieiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oreLucratePeSaptamanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuBrutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuNetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticheteDeMasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studiiNecesareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip cautareToolStrip;
        private System.Windows.Forms.ToolStripLabel wToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox wToolStripTextBox;
        private System.Windows.Forms.ToolStripButton cautareToolStripButton;
        private System.Windows.Forms.Label label2;
    }
}
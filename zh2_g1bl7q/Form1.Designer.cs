namespace zh2_g1bl7q
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            jaratIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            legitarsasagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            indulasiHelyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            celHelyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            utasokSzamaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idotartamOraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            repuloBindingSource = new BindingSource(components);
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonAddNew = new Button();
            buttonFact = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repuloBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { jaratIDDataGridViewTextBoxColumn, legitarsasagDataGridViewTextBoxColumn, indulasiHelyDataGridViewTextBoxColumn, celHelyDataGridViewTextBoxColumn, utasokSzamaDataGridViewTextBoxColumn, idotartamOraDataGridViewTextBoxColumn });
            dataGridView1.DataSource = repuloBindingSource;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 356);
            dataGridView1.TabIndex = 0;
            // 
            // jaratIDDataGridViewTextBoxColumn
            // 
            jaratIDDataGridViewTextBoxColumn.DataPropertyName = "JaratID";
            jaratIDDataGridViewTextBoxColumn.HeaderText = "JaratID";
            jaratIDDataGridViewTextBoxColumn.Name = "jaratIDDataGridViewTextBoxColumn";
            // 
            // legitarsasagDataGridViewTextBoxColumn
            // 
            legitarsasagDataGridViewTextBoxColumn.DataPropertyName = "Legitarsasag";
            legitarsasagDataGridViewTextBoxColumn.HeaderText = "Legitarsasag";
            legitarsasagDataGridViewTextBoxColumn.Name = "legitarsasagDataGridViewTextBoxColumn";
            // 
            // indulasiHelyDataGridViewTextBoxColumn
            // 
            indulasiHelyDataGridViewTextBoxColumn.DataPropertyName = "IndulasiHely";
            indulasiHelyDataGridViewTextBoxColumn.HeaderText = "IndulasiHely";
            indulasiHelyDataGridViewTextBoxColumn.Name = "indulasiHelyDataGridViewTextBoxColumn";
            // 
            // celHelyDataGridViewTextBoxColumn
            // 
            celHelyDataGridViewTextBoxColumn.DataPropertyName = "CelHely";
            celHelyDataGridViewTextBoxColumn.HeaderText = "CelHely";
            celHelyDataGridViewTextBoxColumn.Name = "celHelyDataGridViewTextBoxColumn";
            // 
            // utasokSzamaDataGridViewTextBoxColumn
            // 
            utasokSzamaDataGridViewTextBoxColumn.DataPropertyName = "UtasokSzama";
            utasokSzamaDataGridViewTextBoxColumn.HeaderText = "UtasokSzama";
            utasokSzamaDataGridViewTextBoxColumn.Name = "utasokSzamaDataGridViewTextBoxColumn";
            // 
            // idotartamOraDataGridViewTextBoxColumn
            // 
            idotartamOraDataGridViewTextBoxColumn.DataPropertyName = "IdotartamOra";
            idotartamOraDataGridViewTextBoxColumn.HeaderText = "IdotartamOra";
            idotartamOraDataGridViewTextBoxColumn.Name = "idotartamOraDataGridViewTextBoxColumn";
            // 
            // repuloBindingSource
            // 
            repuloBindingSource.DataSource = typeof(repulo);
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(713, 12);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Betöltés";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(632, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(632, 417);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new Point(713, 417);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(75, 23);
            buttonAddNew.TabIndex = 4;
            buttonAddNew.Text = "Új sor";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += buttonAddNew_Click;
            // 
            // buttonFact
            // 
            buttonFact.Location = new Point(12, 12);
            buttonFact.Name = "buttonFact";
            buttonFact.Size = new Size(115, 23);
            buttonFact.TabIndex = 5;
            buttonFact.Text = "Érdekességek";
            buttonFact.UseVisualStyleBackColor = true;
            buttonFact.Click += buttonFact_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFact);
            Controls.Add(buttonAddNew);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repuloBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn jaratIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legitarsasagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn indulasiHelyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn celHelyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn utasokSzamaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idotartamOraDataGridViewTextBoxColumn;
        private BindingSource repuloBindingSource;
        private Button buttonAddNew;
        private Button buttonFact;
    }
}
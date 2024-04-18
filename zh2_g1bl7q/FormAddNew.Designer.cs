namespace zh2_g1bl7q
{
    partial class FormAddNew
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            repuloBindingSource = new BindingSource(components);
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)repuloBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Járat azonosítója";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", repuloBindingSource, "JaratID", true));
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 23);
            textBox1.TabIndex = 1;
            // 
            // repuloBindingSource
            // 
            repuloBindingSource.DataSource = typeof(repulo);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Légitárs neve";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", repuloBindingSource, "Legitarsasag", true));
            textBox2.Location = new Point(12, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 4;
            label3.Text = "Járat indulási helye";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", repuloBindingSource, "IndulasiHely", true));
            textBox3.Location = new Point(12, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 6;
            label4.Text = "Járat végállomása";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", repuloBindingSource, "CelHely", true));
            textBox4.Location = new Point(12, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(281, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 240);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 8;
            label5.Text = "Utasok száma";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", repuloBindingSource, "UtasokSzama", true));
            textBox5.Location = new Point(12, 258);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(281, 23);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 302);
            label6.Name = "label6";
            label6.Size = new Size(198, 15);
            label6.TabIndex = 10;
            label6.Text = "Időtartam ami alatt megtette a távot";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", repuloBindingSource, "IdotartamOra", true));
            textBox6.Location = new Point(12, 320);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(281, 23);
            textBox6.TabIndex = 11;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(116, 358);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 12;
            buttonOk.Text = "&OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 393);
            Controls.Add(buttonOk);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormAddNew";
            Text = "FormAddNew";
            ((System.ComponentModel.ISupportInitialize)repuloBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private BindingSource repuloBindingSource;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Button buttonOk;
    }
}
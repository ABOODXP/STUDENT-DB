namespace STUDENT_DB_SYSTEM
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.student_systemDataSet = new STUDENT_DB_SYSTEM.student_systemDataSet();
            this.tablestudentdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_studentdbTableAdapter = new STUDENT_DB_SYSTEM.student_systemDataSetTableAdapters.Table_studentdbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablestudentdbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablestudentdbBindingSource, "id", true));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox1.Location = new System.Drawing.Point(214, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 34);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablestudentdbBindingSource, "first name", true));
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox2.Location = new System.Drawing.Point(971, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 34);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablestudentdbBindingSource, "last name", true));
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox3.Location = new System.Drawing.Point(214, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(308, 34);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablestudentdbBindingSource, "date of birth", true));
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox4.Location = new System.Drawing.Point(214, 340);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(308, 34);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID STUDENT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(763, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "FIRST NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "LAST NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "DATE OF BIRTH:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 538);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(997, 347);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(176, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(621, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "DISPLAY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1045, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 52);
            this.button4.TabIndex = 12;
            this.button4.Text = "CLOSE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(763, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "EMAIL:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablestudentdbBindingSource, "email", true));
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox5.Location = new System.Drawing.Point(971, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(308, 34);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablestudentdbBindingSource, "enrolled date", true));
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox6.Location = new System.Drawing.Point(971, 343);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(308, 34);
            this.textBox6.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(763, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 27);
            this.label6.TabIndex = 16;
            this.label6.Text = "ENROLLED DATE:";
            // 
            // student_systemDataSet
            // 
            this.student_systemDataSet.DataSetName = "student_systemDataSet";
            this.student_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablestudentdbBindingSource
            // 
            this.tablestudentdbBindingSource.DataMember = "Table_studentdb";
            this.tablestudentdbBindingSource.DataSource = this.student_systemDataSet;
            // 
            // table_studentdbTableAdapter
            // 
            this.table_studentdbTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1356, 916);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablestudentdbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private student_systemDataSet student_systemDataSet;
        private System.Windows.Forms.BindingSource tablestudentdbBindingSource;
        private student_systemDataSetTableAdapters.Table_studentdbTableAdapter table_studentdbTableAdapter;
    }
}


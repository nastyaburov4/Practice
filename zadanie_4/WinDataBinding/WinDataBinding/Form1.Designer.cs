namespace WinDataBinding
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbProductDataSet1 = new WinDataBinding.RBProductDataSet();
            this.поставщикиTableAdapter1 = new WinDataBinding.RBProductDataSetTableAdapters.ПоставщикиTableAdapter();
            this.CodetextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rbProductDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbProductDataSet1
            // 
            this.rbProductDataSet1.DataSetName = "RBProductDataSet";
            this.rbProductDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиTableAdapter1
            // 
            this.поставщикиTableAdapter1.ClearBeforeFill = true;
            // 
            // CodetextBox
            // 
            this.CodetextBox.Location = new System.Drawing.Point(120, 89);
            this.CodetextBox.Name = "CodetextBox";
            this.CodetextBox.Size = new System.Drawing.Size(34, 20);
            this.CodetextBox.TabIndex = 0;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(256, 89);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(157, 20);
            this.NametextBox.TabIndex = 1;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(559, 89);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(202, 20);
            this.AddresstextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Код поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адрес поставщика";
            // 
            // Previousbutton
            // 
            this.Previousbutton.Location = new System.Drawing.Point(256, 158);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(75, 23);
            this.Previousbutton.TabIndex = 6;
            this.Previousbutton.Text = "Previous";
            this.Previousbutton.UseVisualStyleBackColor = true;
            this.Previousbutton.Click += new System.EventHandler(this.Previousbutton_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(453, 158);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 23);
            this.Nextbutton.TabIndex = 7;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 227);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.CodetextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbProductDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RBProductDataSet rbProductDataSet1;
        private RBProductDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter1;
        private System.Windows.Forms.TextBox CodetextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.Button Nextbutton;
    }
}


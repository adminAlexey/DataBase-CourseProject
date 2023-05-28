namespace AutoPartsStore
{
    partial class CarBrandForm
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
            this.table = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(406, 318);
            this.table.TabIndex = 3;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(424, 12);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(200, 75);
            this.insert.TabIndex = 4;
            this.insert.Text = "Добавить";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(424, 93);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(200, 75);
            this.delete.TabIndex = 5;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(424, 255);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(200, 75);
            this.back.TabIndex = 6;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(424, 174);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(200, 75);
            this.update.TabIndex = 7;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            // 
            // CarBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 343);
            this.Controls.Add(this.update);
            this.Controls.Add(this.back);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.table);
            this.Name = "CarBrandForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button update;
    }
}


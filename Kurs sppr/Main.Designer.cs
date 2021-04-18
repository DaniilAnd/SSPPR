namespace Kurs_sppr
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.новыйНаборКритериевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.критерииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пустая1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пустая2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пустая3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средниеНормализованнойМатрицыКритериевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весовыеКоэффициентыКритериевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаСогласованностиМатрицToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рекомендацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(660, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйНаборКритериевToolStripMenuItem,
            this.критерииToolStripMenuItem,
            this.альтернативыToolStripMenuItem,
            this.расчётыToolStripMenuItem,
            this.рекомендацииToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripDropDownButton1.Text = "Меню";
            // 
            // новыйНаборКритериевToolStripMenuItem
            // 
            this.новыйНаборКритериевToolStripMenuItem.Name = "новыйНаборКритериевToolStripMenuItem";
            this.новыйНаборКритериевToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.новыйНаборКритериевToolStripMenuItem.Text = "Новый набор критериев";
            this.новыйНаборКритериевToolStripMenuItem.Click += new System.EventHandler(this.новыйНаборКритериевToolStripMenuItem_Click);
            // 
            // критерииToolStripMenuItem
            // 
            this.критерииToolStripMenuItem.Name = "критерииToolStripMenuItem";
            this.критерииToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.критерииToolStripMenuItem.Text = "Критерии";
            this.критерииToolStripMenuItem.Click += new System.EventHandler(this.критерииToolStripMenuItem_Click);
            // 
            // альтернативыToolStripMenuItem
            // 
            this.альтернативыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пустая1ToolStripMenuItem,
            this.пустая2ToolStripMenuItem,
            this.пустая3ToolStripMenuItem});
            this.альтернативыToolStripMenuItem.Name = "альтернативыToolStripMenuItem";
            this.альтернативыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.альтернативыToolStripMenuItem.Text = "Альтернативы";
            // 
            // пустая1ToolStripMenuItem
            // 
            this.пустая1ToolStripMenuItem.Name = "пустая1ToolStripMenuItem";
            this.пустая1ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.пустая1ToolStripMenuItem.Text = "Альтернатива 1";
            this.пустая1ToolStripMenuItem.Click += new System.EventHandler(this.пустая1ToolStripMenuItem_Click);
            // 
            // пустая2ToolStripMenuItem
            // 
            this.пустая2ToolStripMenuItem.Name = "пустая2ToolStripMenuItem";
            this.пустая2ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.пустая2ToolStripMenuItem.Text = "Альтернатива 2";
            this.пустая2ToolStripMenuItem.Click += new System.EventHandler(this.пустая2ToolStripMenuItem_Click);
            // 
            // пустая3ToolStripMenuItem
            // 
            this.пустая3ToolStripMenuItem.Name = "пустая3ToolStripMenuItem";
            this.пустая3ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.пустая3ToolStripMenuItem.Text = "Альтернатива 3";
            this.пустая3ToolStripMenuItem.Click += new System.EventHandler(this.пустая3ToolStripMenuItem_Click);
            // 
            // расчётыToolStripMenuItem
            // 
            this.расчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.средниеНормализованнойМатрицыКритериевToolStripMenuItem,
            this.весовыеКоэффициентыКритериевToolStripMenuItem,
            this.проверкаСогласованностиМатрицToolStripMenuItem});
            this.расчётыToolStripMenuItem.Name = "расчётыToolStripMenuItem";
            this.расчётыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.расчётыToolStripMenuItem.Text = "Расчёты";
            // 
            // средниеНормализованнойМатрицыКритериевToolStripMenuItem
            // 
            this.средниеНормализованнойМатрицыКритериевToolStripMenuItem.Name = "средниеНормализованнойМатрицыКритериевToolStripMenuItem";
            this.средниеНормализованнойМатрицыКритериевToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.средниеНормализованнойМатрицыКритериевToolStripMenuItem.Text = "Средние значения нормализованной матрицы";
            this.средниеНормализованнойМатрицыКритериевToolStripMenuItem.Click += new System.EventHandler(this.средниеНормализованнойМатрицыКритериевToolStripMenuItem_Click);
            // 
            // весовыеКоэффициентыКритериевToolStripMenuItem
            // 
            this.весовыеКоэффициентыКритериевToolStripMenuItem.Name = "весовыеКоэффициентыКритериевToolStripMenuItem";
            this.весовыеКоэффициентыКритериевToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.весовыеКоэффициентыКритериевToolStripMenuItem.Text = "Весовые коэффициенты";
            this.весовыеКоэффициентыКритериевToolStripMenuItem.Click += new System.EventHandler(this.весовыеКоэффициентыКритериевToolStripMenuItem_Click);
            // 
            // проверкаСогласованностиМатрицToolStripMenuItem
            // 
            this.проверкаСогласованностиМатрицToolStripMenuItem.Name = "проверкаСогласованностиМатрицToolStripMenuItem";
            this.проверкаСогласованностиМатрицToolStripMenuItem.Size = new System.Drawing.Size(333, 22);
            this.проверкаСогласованностиМатрицToolStripMenuItem.Text = "Вывод согласованности матрицы";
            this.проверкаСогласованностиМатрицToolStripMenuItem.Click += new System.EventHandler(this.проверкаСогласованностиМатрицToolStripMenuItem_Click);
            // 
            // рекомендацииToolStripMenuItem
            // 
            this.рекомендацииToolStripMenuItem.Name = "рекомендацииToolStripMenuItem";
            this.рекомендацииToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.рекомендацииToolStripMenuItem.Text = "Рекомендации";
            this.рекомендацииToolStripMenuItem.Click += new System.EventHandler(this.рекомендацииToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 25);
            this.toolStripTextBox1.Leave += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 235);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(700, 320);
            this.Name = "Main";
            this.Text = "СППР при выборе телевизора";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem новыйНаборКритериевToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пустая1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пустая2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пустая3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средниеНормализованнойМатрицыКритериевToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаСогласованностиМатрицToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весовыеКоэффициентыКритериевToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рекомендацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem критерииToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
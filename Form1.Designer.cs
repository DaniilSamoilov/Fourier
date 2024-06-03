namespace Fourier
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FurierBtn = new System.Windows.Forms.Button();
            this.SelectedFunction = new System.Windows.Forms.ComboBox();
            this.NCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.periodCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(776, 371);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // FurierBtn
            // 
            this.FurierBtn.Location = new System.Drawing.Point(699, 405);
            this.FurierBtn.Name = "FurierBtn";
            this.FurierBtn.Size = new System.Drawing.Size(75, 23);
            this.FurierBtn.TabIndex = 1;
            this.FurierBtn.Text = "Разложить";
            this.FurierBtn.UseVisualStyleBackColor = true;
            this.FurierBtn.Click += new System.EventHandler(this.FurierBtn_Click);
            // 
            // SelectedFunction
            // 
            this.SelectedFunction.FormattingEnabled = true;
            this.SelectedFunction.Location = new System.Drawing.Point(146, 405);
            this.SelectedFunction.Name = "SelectedFunction";
            this.SelectedFunction.Size = new System.Drawing.Size(187, 21);
            this.SelectedFunction.TabIndex = 2;
            // 
            // NCount
            // 
            this.NCount.Location = new System.Drawing.Point(584, 392);
            this.NCount.Name = "NCount";
            this.NCount.Size = new System.Drawing.Size(100, 20);
            this.NCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "F(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество разбиений";
            // 
            // periodCount
            // 
            this.periodCount.Location = new System.Drawing.Point(584, 418);
            this.periodCount.Name = "periodCount";
            this.periodCount.Size = new System.Drawing.Size(100, 20);
            this.periodCount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество отображаемых периодов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.periodCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NCount);
            this.Controls.Add(this.SelectedFunction);
            this.Controls.Add(this.FurierBtn);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button FurierBtn;
        private System.Windows.Forms.ComboBox SelectedFunction;
        private System.Windows.Forms.TextBox NCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox periodCount;
        private System.Windows.Forms.Label label3;
    }
}


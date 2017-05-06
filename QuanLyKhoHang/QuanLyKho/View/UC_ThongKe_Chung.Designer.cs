namespace QuanLyKho.View
{
    partial class UC_ThongKe_Chung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartDoanhThu_Nam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu_Nam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.chartDoanhThu_Nam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 534);
            this.panel1.TabIndex = 1;
            // 
            // chartDoanhThu_Nam
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu_Nam.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu_Nam.Legends.Add(legend1);
            this.chartDoanhThu_Nam.Location = new System.Drawing.Point(101, 43);
            this.chartDoanhThu_Nam.Name = "chartDoanhThu_Nam";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Nhập";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Xuất";
            this.chartDoanhThu_Nam.Series.Add(series1);
            this.chartDoanhThu_Nam.Series.Add(series2);
            this.chartDoanhThu_Nam.Size = new System.Drawing.Size(734, 445);
            this.chartDoanhThu_Nam.TabIndex = 0;
            this.chartDoanhThu_Nam.Text = "Thống kê doanh thu theo năm";
            title1.Name = "Title1";
            title1.Text = "Thống kê doanh thu theo năm";
            this.chartDoanhThu_Nam.Titles.Add(title1);
            // 
            // UC_ThongKe_Chung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(931, 534);
            this.MinimumSize = new System.Drawing.Size(931, 534);
            this.Name = "UC_ThongKe_Chung";
            this.Size = new System.Drawing.Size(931, 534);
            this.Load += new System.EventHandler(this.UC_ThongKe_Nam_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu_Nam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu_Nam;
    }
}

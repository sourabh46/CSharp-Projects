namespace GraphPlotApplication
{
    partial class SimpleGraphApplication
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartXValueVsYValue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartXValueVsYValue)).BeginInit();
            this.SuspendLayout();
            // 
            // chartXValueVsYValue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartXValueVsYValue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartXValueVsYValue.Legends.Add(legend1);
            this.chartXValueVsYValue.Location = new System.Drawing.Point(29, 26);
            this.chartXValueVsYValue.Name = "chartXValueVsYValue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartXValueVsYValue.Series.Add(series1);
            this.chartXValueVsYValue.Size = new System.Drawing.Size(839, 656);
            this.chartXValueVsYValue.TabIndex = 0;
            this.chartXValueVsYValue.Text = "chart1";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(904, 26);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // SimpleGraphApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chartXValueVsYValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SimpleGraphApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Graph Plot Application (v1.0)";
            ((System.ComponentModel.ISupportInitialize)(this.chartXValueVsYValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartXValueVsYValue;
        private System.Windows.Forms.Button btnShow;
    }
}


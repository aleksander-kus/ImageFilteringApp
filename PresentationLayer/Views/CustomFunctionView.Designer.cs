
namespace PresentationLayer.Views
{
    partial class CustomFunctionView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.functionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bezierCurveButton = new System.Windows.Forms.RadioButton();
            this.normalCurveButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removePointsButton = new System.Windows.Forms.RadioButton();
            this.addPointsButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // functionChart
            // 
            chartArea3.Name = "ChartArea1";
            this.functionChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.functionChart.Legends.Add(legend3);
            this.functionChart.Location = new System.Drawing.Point(12, 12);
            this.functionChart.Name = "functionChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.functionChart.Series.Add(series3);
            this.functionChart.Size = new System.Drawing.Size(565, 320);
            this.functionChart.TabIndex = 0;
            this.functionChart.Text = "chart1";
            this.functionChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.functionChart_MouseDown);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(162, 358);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(306, 357);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(450, 357);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bezierCurveButton);
            this.groupBox1.Controls.Add(this.normalCurveButton);
            this.groupBox1.Location = new System.Drawing.Point(592, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curve mode";
            // 
            // bezierCurveButton
            // 
            this.bezierCurveButton.AutoSize = true;
            this.bezierCurveButton.Location = new System.Drawing.Point(7, 44);
            this.bezierCurveButton.Name = "bezierCurveButton";
            this.bezierCurveButton.Size = new System.Drawing.Size(54, 17);
            this.bezierCurveButton.TabIndex = 1;
            this.bezierCurveButton.Text = "Bezier";
            this.bezierCurveButton.UseVisualStyleBackColor = true;
            // 
            // normalCurveButton
            // 
            this.normalCurveButton.AutoSize = true;
            this.normalCurveButton.Checked = true;
            this.normalCurveButton.Location = new System.Drawing.Point(7, 20);
            this.normalCurveButton.Name = "normalCurveButton";
            this.normalCurveButton.Size = new System.Drawing.Size(58, 17);
            this.normalCurveButton.TabIndex = 0;
            this.normalCurveButton.TabStop = true;
            this.normalCurveButton.Text = "Normal";
            this.normalCurveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removePointsButton);
            this.groupBox2.Controls.Add(this.addPointsButton);
            this.groupBox2.Location = new System.Drawing.Point(592, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Points";
            // 
            // removePointsButton
            // 
            this.removePointsButton.AutoSize = true;
            this.removePointsButton.Location = new System.Drawing.Point(7, 46);
            this.removePointsButton.Name = "removePointsButton";
            this.removePointsButton.Size = new System.Drawing.Size(65, 17);
            this.removePointsButton.TabIndex = 1;
            this.removePointsButton.Text = "Remove";
            this.removePointsButton.UseVisualStyleBackColor = true;
            this.removePointsButton.Click += new System.EventHandler(this.removePointsButton_Click);
            // 
            // addPointsButton
            // 
            this.addPointsButton.AutoSize = true;
            this.addPointsButton.Checked = true;
            this.addPointsButton.Location = new System.Drawing.Point(7, 20);
            this.addPointsButton.Name = "addPointsButton";
            this.addPointsButton.Size = new System.Drawing.Size(44, 17);
            this.addPointsButton.TabIndex = 0;
            this.addPointsButton.TabStop = true;
            this.addPointsButton.Text = "Add";
            this.addPointsButton.UseVisualStyleBackColor = true;
            this.addPointsButton.Click += new System.EventHandler(this.addPointsButton_Click);
            // 
            // CustomFunctionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.functionChart);
            this.Name = "CustomFunctionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Define custom function";
            this.Load += new System.EventHandler(this.CustomFunctionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart functionChart;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bezierCurveButton;
        private System.Windows.Forms.RadioButton normalCurveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton removePointsButton;
        private System.Windows.Forms.RadioButton addPointsButton;
    }
}
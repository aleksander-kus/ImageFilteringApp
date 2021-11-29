
namespace PresentationLayer.Views
{
    partial class MainView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wholeButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noFilterButton = new System.Windows.Forms.RadioButton();
            this.brightnessButton = new System.Windows.Forms.RadioButton();
            this.contrastButton = new System.Windows.Forms.RadioButton();
            this.negationButton = new System.Windows.Forms.RadioButton();
            this.gammaButton = new System.Windows.Forms.RadioButton();
            this.customButton = new System.Windows.Forms.RadioButton();
            this.brushButton = new System.Windows.Forms.RadioButton();
            this.polygonButton = new System.Windows.Forms.RadioButton();
            this.mainTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.filterTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 3;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTable.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.mainTable.Controls.Add(this.pictureBox1, 0, 0);
            this.mainTable.Controls.Add(this.menuTable, 1, 0);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(1098, 761);
            this.mainTable.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bChart, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(826, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 755);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // rChart
            // 
            chartArea1.Name = "ChartArea1";
            this.rChart.ChartAreas.Add(chartArea1);
            this.rChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.rChart.Legends.Add(legend1);
            this.rChart.Location = new System.Drawing.Point(3, 3);
            this.rChart.Name = "rChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.rChart.Series.Add(series1);
            this.rChart.Size = new System.Drawing.Size(263, 245);
            this.rChart.TabIndex = 0;
            this.rChart.Text = "chart1";
            // 
            // gChart
            // 
            chartArea2.Name = "ChartArea1";
            this.gChart.ChartAreas.Add(chartArea2);
            this.gChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.gChart.Legends.Add(legend2);
            this.gChart.Location = new System.Drawing.Point(3, 254);
            this.gChart.Name = "gChart";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.gChart.Series.Add(series2);
            this.gChart.Size = new System.Drawing.Size(263, 245);
            this.gChart.TabIndex = 1;
            this.gChart.Text = "chart2";
            // 
            // bChart
            // 
            chartArea3.Name = "ChartArea1";
            this.bChart.ChartAreas.Add(chartArea3);
            this.bChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.bChart.Legends.Add(legend3);
            this.bChart.Location = new System.Drawing.Point(3, 505);
            this.bChart.Name = "bChart";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.bChart.Series.Add(series3);
            this.bChart.Size = new System.Drawing.Size(263, 247);
            this.bChart.TabIndex = 2;
            this.bChart.Text = "chart3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 755);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuTable
            // 
            this.menuTable.ColumnCount = 1;
            this.menuTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuTable.Controls.Add(this.groupBox1, 0, 0);
            this.menuTable.Controls.Add(this.groupBox2, 0, 1);
            this.menuTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTable.Location = new System.Drawing.Point(552, 3);
            this.menuTable.Name = "menuTable";
            this.menuTable.RowCount = 2;
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.menuTable.Size = new System.Drawing.Size(268, 755);
            this.menuTable.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection mode";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.polygonButton);
            this.panel1.Controls.Add(this.brushButton);
            this.panel1.Controls.Add(this.wholeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 201);
            this.panel1.TabIndex = 0;
            // 
            // wholeButton
            // 
            this.wholeButton.AutoSize = true;
            this.wholeButton.Checked = true;
            this.wholeButton.Location = new System.Drawing.Point(3, 14);
            this.wholeButton.Name = "wholeButton";
            this.wholeButton.Size = new System.Drawing.Size(87, 17);
            this.wholeButton.TabIndex = 0;
            this.wholeButton.TabStop = true;
            this.wholeButton.Text = "Whole image";
            this.wholeButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 523);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // filterTable
            // 
            this.filterTable.ColumnCount = 1;
            this.filterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterTable.Controls.Add(this.panel2, 0, 0);
            this.filterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterTable.Location = new System.Drawing.Point(3, 16);
            this.filterTable.Name = "filterTable";
            this.filterTable.RowCount = 2;
            this.filterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterTable.Size = new System.Drawing.Size(256, 504);
            this.filterTable.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customButton);
            this.panel2.Controls.Add(this.gammaButton);
            this.panel2.Controls.Add(this.negationButton);
            this.panel2.Controls.Add(this.contrastButton);
            this.panel2.Controls.Add(this.brightnessButton);
            this.panel2.Controls.Add(this.noFilterButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 246);
            this.panel2.TabIndex = 0;
            // 
            // noFilterButton
            // 
            this.noFilterButton.AutoSize = true;
            this.noFilterButton.Location = new System.Drawing.Point(4, 3);
            this.noFilterButton.Name = "noFilterButton";
            this.noFilterButton.Size = new System.Drawing.Size(61, 17);
            this.noFilterButton.TabIndex = 1;
            this.noFilterButton.TabStop = true;
            this.noFilterButton.Text = "No filter";
            this.noFilterButton.UseVisualStyleBackColor = true;
            // 
            // brightnessButton
            // 
            this.brightnessButton.AutoSize = true;
            this.brightnessButton.Location = new System.Drawing.Point(4, 49);
            this.brightnessButton.Name = "brightnessButton";
            this.brightnessButton.Size = new System.Drawing.Size(74, 17);
            this.brightnessButton.TabIndex = 2;
            this.brightnessButton.TabStop = true;
            this.brightnessButton.Text = "Brightness";
            this.brightnessButton.UseVisualStyleBackColor = true;
            // 
            // contrastButton
            // 
            this.contrastButton.AutoSize = true;
            this.contrastButton.Location = new System.Drawing.Point(4, 95);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(64, 17);
            this.contrastButton.TabIndex = 3;
            this.contrastButton.TabStop = true;
            this.contrastButton.Text = "Contrast";
            this.contrastButton.UseVisualStyleBackColor = true;
            // 
            // negationButton
            // 
            this.negationButton.AutoSize = true;
            this.negationButton.Location = new System.Drawing.Point(4, 26);
            this.negationButton.Name = "negationButton";
            this.negationButton.Size = new System.Drawing.Size(68, 17);
            this.negationButton.TabIndex = 4;
            this.negationButton.TabStop = true;
            this.negationButton.Text = "Negation";
            this.negationButton.UseVisualStyleBackColor = true;
            // 
            // gammaButton
            // 
            this.gammaButton.AutoSize = true;
            this.gammaButton.Location = new System.Drawing.Point(4, 72);
            this.gammaButton.Name = "gammaButton";
            this.gammaButton.Size = new System.Drawing.Size(111, 17);
            this.gammaButton.TabIndex = 5;
            this.gammaButton.TabStop = true;
            this.gammaButton.Text = "Gamma correction";
            this.gammaButton.UseVisualStyleBackColor = true;
            // 
            // customButton
            // 
            this.customButton.AutoSize = true;
            this.customButton.Location = new System.Drawing.Point(4, 119);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(101, 17);
            this.customButton.TabIndex = 6;
            this.customButton.TabStop = true;
            this.customButton.Text = "Custom function";
            this.customButton.UseVisualStyleBackColor = true;
            // 
            // brushButton
            // 
            this.brushButton.AutoSize = true;
            this.brushButton.Location = new System.Drawing.Point(3, 38);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(86, 17);
            this.brushButton.TabIndex = 1;
            this.brushButton.TabStop = true;
            this.brushButton.Text = "Round brush";
            this.brushButton.UseVisualStyleBackColor = true;
            // 
            // polygonButton
            // 
            this.polygonButton.AutoSize = true;
            this.polygonButton.Location = new System.Drawing.Point(3, 61);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(63, 17);
            this.polygonButton.TabIndex = 2;
            this.polygonButton.TabStop = true;
            this.polygonButton.Text = "Polygon";
            this.polygonButton.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 761);
            this.Controls.Add(this.mainTable);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image function filtering program";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.mainTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.filterTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart rChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart gChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart bChart;
        private System.Windows.Forms.TableLayoutPanel menuTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton wholeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel filterTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton gammaButton;
        private System.Windows.Forms.RadioButton negationButton;
        private System.Windows.Forms.RadioButton contrastButton;
        private System.Windows.Forms.RadioButton brightnessButton;
        private System.Windows.Forms.RadioButton noFilterButton;
        private System.Windows.Forms.RadioButton polygonButton;
        private System.Windows.Forms.RadioButton brushButton;
        private System.Windows.Forms.RadioButton customButton;
    }
}
﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.functionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).BeginInit();
            this.menuTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.filterTable.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).BeginInit();
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
            chartArea6.Name = "ChartArea1";
            this.rChart.ChartAreas.Add(chartArea6);
            this.rChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.rChart.Legends.Add(legend6);
            this.rChart.Location = new System.Drawing.Point(3, 3);
            this.rChart.Name = "rChart";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.rChart.Series.Add(series6);
            this.rChart.Size = new System.Drawing.Size(263, 245);
            this.rChart.TabIndex = 0;
            this.rChart.Text = "chart1";
            // 
            // gChart
            // 
            chartArea7.Name = "ChartArea1";
            this.gChart.ChartAreas.Add(chartArea7);
            this.gChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.gChart.Legends.Add(legend7);
            this.gChart.Location = new System.Drawing.Point(3, 254);
            this.gChart.Name = "gChart";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.Green;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.gChart.Series.Add(series7);
            this.gChart.Size = new System.Drawing.Size(263, 245);
            this.gChart.TabIndex = 1;
            this.gChart.Text = "chart2";
            // 
            // bChart
            // 
            chartArea8.Name = "ChartArea1";
            this.bChart.ChartAreas.Add(chartArea8);
            this.bChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Legend1";
            this.bChart.Legends.Add(legend8);
            this.bChart.Location = new System.Drawing.Point(3, 505);
            this.bChart.Name = "bChart";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.Blue;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.bChart.Series.Add(series8);
            this.bChart.Size = new System.Drawing.Size(263, 247);
            this.bChart.TabIndex = 2;
            this.bChart.Text = "chart3";
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
            this.filterTable.Controls.Add(this.functionChart, 0, 1);
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
            this.noFilterButton.Checked = true;
            this.noFilterButton.Location = new System.Drawing.Point(4, 3);
            this.noFilterButton.Name = "noFilterButton";
            this.noFilterButton.Size = new System.Drawing.Size(61, 17);
            this.noFilterButton.TabIndex = 1;
            this.noFilterButton.TabStop = true;
            this.noFilterButton.Text = "No filter";
            this.noFilterButton.UseVisualStyleBackColor = true;
            this.noFilterButton.Click += new System.EventHandler(this.noFilterButton_Click);
            // 
            // brightnessButton
            // 
            this.brightnessButton.AutoSize = true;
            this.brightnessButton.Location = new System.Drawing.Point(4, 49);
            this.brightnessButton.Name = "brightnessButton";
            this.brightnessButton.Size = new System.Drawing.Size(74, 17);
            this.brightnessButton.TabIndex = 2;
            this.brightnessButton.Text = "Brightness";
            this.brightnessButton.UseVisualStyleBackColor = true;
            this.brightnessButton.Click += new System.EventHandler(this.brightnessButton_Click);
            // 
            // contrastButton
            // 
            this.contrastButton.AutoSize = true;
            this.contrastButton.Location = new System.Drawing.Point(4, 95);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(64, 17);
            this.contrastButton.TabIndex = 3;
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
            this.negationButton.Text = "Negation";
            this.negationButton.UseVisualStyleBackColor = true;
            this.negationButton.Click += new System.EventHandler(this.negationButton_Click);
            // 
            // gammaButton
            // 
            this.gammaButton.AutoSize = true;
            this.gammaButton.Location = new System.Drawing.Point(4, 72);
            this.gammaButton.Name = "gammaButton";
            this.gammaButton.Size = new System.Drawing.Size(111, 17);
            this.gammaButton.TabIndex = 5;
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 755);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // functionChart
            // 
            chartArea5.Name = "ChartArea1";
            this.functionChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.functionChart.Legends.Add(legend5);
            this.functionChart.Location = new System.Drawing.Point(3, 255);
            this.functionChart.Name = "functionChart";
            series5.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Black;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.functionChart.Series.Add(series5);
            this.functionChart.Size = new System.Drawing.Size(250, 246);
            this.functionChart.TabIndex = 1;
            this.functionChart.Text = "chart1";
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
            this.menuTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.filterTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart functionChart;
    }
}
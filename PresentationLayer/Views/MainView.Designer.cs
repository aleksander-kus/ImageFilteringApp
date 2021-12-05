
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
            this.removePolygonButton = new System.Windows.Forms.Button();
            this.addPolygonButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.RadioButton();
            this.brushButton = new System.Windows.Forms.RadioButton();
            this.wholeButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterTable = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.Panel();
            this.customFunctionButton = new System.Windows.Forms.Button();
            this.contrastBox = new System.Windows.Forms.NumericUpDown();
            this.brightnessBox = new System.Windows.Forms.NumericUpDown();
            this.gammaBox = new System.Windows.Forms.NumericUpDown();
            this.customButton = new System.Windows.Forms.RadioButton();
            this.gammaButton = new System.Windows.Forms.RadioButton();
            this.negationButton = new System.Windows.Forms.RadioButton();
            this.contrastButton = new System.Windows.Forms.RadioButton();
            this.brightnessButton = new System.Windows.Forms.RadioButton();
            this.noFilterButton = new System.Windows.Forms.RadioButton();
            this.functionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bufferedPanel1 = new PresentationLayer.Controls.BufferedPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.earthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tajMahalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.normalCurveButton = new System.Windows.Forms.RadioButton();
            this.bezierCurveButton = new System.Windows.Forms.RadioButton();
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
            this.pictureBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 3;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTable.Controls.Add(this.tableLayoutPanel1, 2, 1);
            this.mainTable.Controls.Add(this.menuTable, 1, 1);
            this.mainTable.Controls.Add(this.bufferedPanel1, 0, 1);
            this.mainTable.Controls.Add(this.menuStrip1, 0, 0);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 2;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(1124, 801);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(846, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 771);
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
            this.rChart.Size = new System.Drawing.Size(269, 250);
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
            this.gChart.Location = new System.Drawing.Point(3, 259);
            this.gChart.Name = "gChart";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.Green;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.gChart.Series.Add(series7);
            this.gChart.Size = new System.Drawing.Size(269, 251);
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
            this.bChart.Location = new System.Drawing.Point(3, 516);
            this.bChart.Name = "bChart";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.Blue;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.bChart.Series.Add(series8);
            this.bChart.Size = new System.Drawing.Size(269, 252);
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
            this.menuTable.Location = new System.Drawing.Point(565, 27);
            this.menuTable.Name = "menuTable";
            this.menuTable.RowCount = 2;
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.menuTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.menuTable.Size = new System.Drawing.Size(275, 771);
            this.menuTable.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection mode";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removePolygonButton);
            this.panel1.Controls.Add(this.addPolygonButton);
            this.panel1.Controls.Add(this.polygonButton);
            this.panel1.Controls.Add(this.brushButton);
            this.panel1.Controls.Add(this.wholeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 206);
            this.panel1.TabIndex = 0;
            // 
            // removePolygonButton
            // 
            this.removePolygonButton.Location = new System.Drawing.Point(137, 85);
            this.removePolygonButton.Name = "removePolygonButton";
            this.removePolygonButton.Size = new System.Drawing.Size(95, 23);
            this.removePolygonButton.TabIndex = 4;
            this.removePolygonButton.Text = "Remove polygon";
            this.removePolygonButton.UseVisualStyleBackColor = true;
            this.removePolygonButton.Click += new System.EventHandler(this.removePolygonButton_Click);
            // 
            // addPolygonButton
            // 
            this.addPolygonButton.Location = new System.Drawing.Point(23, 85);
            this.addPolygonButton.Name = "addPolygonButton";
            this.addPolygonButton.Size = new System.Drawing.Size(75, 23);
            this.addPolygonButton.TabIndex = 3;
            this.addPolygonButton.Text = "Add polygon";
            this.addPolygonButton.UseVisualStyleBackColor = true;
            this.addPolygonButton.Click += new System.EventHandler(this.addPolygonButton_Click);
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
            this.polygonButton.Click += new System.EventHandler(this.polygonButton_Click);
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
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
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
            this.wholeButton.Click += new System.EventHandler(this.wholeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 534);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // filterTable
            // 
            this.filterTable.ColumnCount = 1;
            this.filterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filterTable.Controls.Add(this.pictureBox1, 0, 0);
            this.filterTable.Controls.Add(this.functionChart, 0, 1);
            this.filterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterTable.Location = new System.Drawing.Point(3, 16);
            this.filterTable.Name = "filterTable";
            this.filterTable.RowCount = 2;
            this.filterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filterTable.Size = new System.Drawing.Size(263, 515);
            this.filterTable.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Controls.Add(this.groupBox3);
            this.pictureBox1.Controls.Add(this.customFunctionButton);
            this.pictureBox1.Controls.Add(this.contrastBox);
            this.pictureBox1.Controls.Add(this.brightnessBox);
            this.pictureBox1.Controls.Add(this.gammaBox);
            this.pictureBox1.Controls.Add(this.customButton);
            this.pictureBox1.Controls.Add(this.gammaButton);
            this.pictureBox1.Controls.Add(this.negationButton);
            this.pictureBox1.Controls.Add(this.contrastButton);
            this.pictureBox1.Controls.Add(this.brightnessButton);
            this.pictureBox1.Controls.Add(this.noFilterButton);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 251);
            this.pictureBox1.TabIndex = 0;
            // 
            // customFunctionButton
            // 
            this.customFunctionButton.Location = new System.Drawing.Point(20, 220);
            this.customFunctionButton.Name = "customFunctionButton";
            this.customFunctionButton.Size = new System.Drawing.Size(144, 23);
            this.customFunctionButton.TabIndex = 10;
            this.customFunctionButton.Text = "Define custom function";
            this.customFunctionButton.UseVisualStyleBackColor = true;
            this.customFunctionButton.Click += new System.EventHandler(this.customFunctionButton_Click);
            // 
            // contrastBox
            // 
            this.contrastBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.contrastBox.Location = new System.Drawing.Point(20, 172);
            this.contrastBox.Maximum = new decimal(new int[] {
            122,
            0,
            0,
            0});
            this.contrastBox.Name = "contrastBox";
            this.contrastBox.Size = new System.Drawing.Size(120, 20);
            this.contrastBox.TabIndex = 9;
            this.contrastBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.contrastBox.ValueChanged += new System.EventHandler(this.contrastBox_ValueChanged);
            // 
            // brightnessBox
            // 
            this.brightnessBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.brightnessBox.Location = new System.Drawing.Point(20, 72);
            this.brightnessBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.brightnessBox.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.brightnessBox.Name = "brightnessBox";
            this.brightnessBox.Size = new System.Drawing.Size(120, 20);
            this.brightnessBox.TabIndex = 8;
            this.brightnessBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.brightnessBox.ValueChanged += new System.EventHandler(this.brightnessBox_ValueChanged);
            // 
            // gammaBox
            // 
            this.gammaBox.DecimalPlaces = 2;
            this.gammaBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gammaBox.Location = new System.Drawing.Point(20, 123);
            this.gammaBox.Name = "gammaBox";
            this.gammaBox.Size = new System.Drawing.Size(120, 20);
            this.gammaBox.TabIndex = 7;
            this.gammaBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gammaBox.ValueChanged += new System.EventHandler(this.gammaBox_ValueChanged);
            // 
            // customButton
            // 
            this.customButton.AutoSize = true;
            this.customButton.Location = new System.Drawing.Point(3, 198);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(101, 17);
            this.customButton.TabIndex = 6;
            this.customButton.Text = "Custom function";
            this.customButton.UseVisualStyleBackColor = true;
            // 
            // gammaButton
            // 
            this.gammaButton.AutoSize = true;
            this.gammaButton.Location = new System.Drawing.Point(4, 98);
            this.gammaButton.Name = "gammaButton";
            this.gammaButton.Size = new System.Drawing.Size(111, 17);
            this.gammaButton.TabIndex = 5;
            this.gammaButton.Text = "Gamma correction";
            this.gammaButton.UseVisualStyleBackColor = true;
            this.gammaButton.Click += new System.EventHandler(this.gammaButton_Click);
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
            // contrastButton
            // 
            this.contrastButton.AutoSize = true;
            this.contrastButton.Location = new System.Drawing.Point(4, 149);
            this.contrastButton.Name = "contrastButton";
            this.contrastButton.Size = new System.Drawing.Size(64, 17);
            this.contrastButton.TabIndex = 3;
            this.contrastButton.Text = "Contrast";
            this.contrastButton.UseVisualStyleBackColor = true;
            this.contrastButton.Click += new System.EventHandler(this.contrastButton_Click);
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
            // functionChart
            // 
            chartArea5.Name = "ChartArea1";
            this.functionChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.functionChart.Legends.Add(legend5);
            this.functionChart.Location = new System.Drawing.Point(3, 260);
            this.functionChart.Name = "functionChart";
            series5.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Black;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.functionChart.Series.Add(series5);
            this.functionChart.Size = new System.Drawing.Size(250, 238);
            this.functionChart.TabIndex = 1;
            this.functionChart.Text = "chart1";
            // 
            // bufferedPanel1
            // 
            this.bufferedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bufferedPanel1.Location = new System.Drawing.Point(3, 27);
            this.bufferedPanel1.Name = "bufferedPanel1";
            this.bufferedPanel1.Size = new System.Drawing.Size(556, 771);
            this.bufferedPanel1.TabIndex = 5;
            this.bufferedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bufferedPanel1_Paint);
            this.bufferedPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bufferedPanel1_MouseDown);
            this.bufferedPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bufferedPanel1_MouseMove);
            this.bufferedPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bufferedPanel1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.earthToolStripMenuItem1,
            this.tajMahalToolStripMenuItem1,
            this.loadFromFileToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // earthToolStripMenuItem1
            // 
            this.earthToolStripMenuItem1.Checked = true;
            this.earthToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.earthToolStripMenuItem1.Name = "earthToolStripMenuItem1";
            this.earthToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.earthToolStripMenuItem1.Text = "Earth";
            this.earthToolStripMenuItem1.Click += new System.EventHandler(this.earthToolStripMenuItem1_Click);
            // 
            // tajMahalToolStripMenuItem1
            // 
            this.tajMahalToolStripMenuItem1.Name = "tajMahalToolStripMenuItem1";
            this.tajMahalToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.tajMahalToolStripMenuItem1.Text = "Taj Mahal";
            this.tajMahalToolStripMenuItem1.Click += new System.EventHandler(this.tajMahalToolStripMenuItem1_Click);
            // 
            // loadFromFileToolStripMenuItem1
            // 
            this.loadFromFileToolStripMenuItem1.Name = "loadFromFileToolStripMenuItem1";
            this.loadFromFileToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.loadFromFileToolStripMenuItem1.Text = "Load from file...";
            this.loadFromFileToolStripMenuItem1.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bezierCurveButton);
            this.groupBox3.Controls.Add(this.normalCurveButton);
            this.groupBox3.Location = new System.Drawing.Point(158, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(86, 70);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Curve mode";
            // 
            // normalCurveButton
            // 
            this.normalCurveButton.AutoSize = true;
            this.normalCurveButton.Checked = true;
            this.normalCurveButton.Location = new System.Drawing.Point(6, 19);
            this.normalCurveButton.Name = "normalCurveButton";
            this.normalCurveButton.Size = new System.Drawing.Size(58, 17);
            this.normalCurveButton.TabIndex = 0;
            this.normalCurveButton.TabStop = true;
            this.normalCurveButton.Text = "Normal";
            this.normalCurveButton.UseVisualStyleBackColor = true;
            this.normalCurveButton.Click += new System.EventHandler(this.normalCurveButton_Click);
            // 
            // bezierCurveButton
            // 
            this.bezierCurveButton.AutoSize = true;
            this.bezierCurveButton.Location = new System.Drawing.Point(6, 42);
            this.bezierCurveButton.Name = "bezierCurveButton";
            this.bezierCurveButton.Size = new System.Drawing.Size(54, 17);
            this.bezierCurveButton.TabIndex = 1;
            this.bezierCurveButton.Text = "Bezier";
            this.bezierCurveButton.UseVisualStyleBackColor = true;
            this.bezierCurveButton.Click += new System.EventHandler(this.bezierCurveButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 801);
            this.Controls.Add(this.mainTable);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image function filtering program";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
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
            this.pictureBox1.ResumeLayout(false);
            this.pictureBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTable;
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
        private System.Windows.Forms.Panel pictureBox1;
        private System.Windows.Forms.RadioButton gammaButton;
        private System.Windows.Forms.RadioButton negationButton;
        private System.Windows.Forms.RadioButton contrastButton;
        private System.Windows.Forms.RadioButton brightnessButton;
        private System.Windows.Forms.RadioButton noFilterButton;
        private System.Windows.Forms.RadioButton polygonButton;
        private System.Windows.Forms.RadioButton brushButton;
        private System.Windows.Forms.RadioButton customButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart functionChart;
        private Controls.BufferedPanel bufferedPanel1;
        private System.Windows.Forms.NumericUpDown contrastBox;
        private System.Windows.Forms.NumericUpDown brightnessBox;
        private System.Windows.Forms.NumericUpDown gammaBox;
        private System.Windows.Forms.Button removePolygonButton;
        private System.Windows.Forms.Button addPolygonButton;
        private System.Windows.Forms.Button customFunctionButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem earthToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tajMahalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton bezierCurveButton;
        private System.Windows.Forms.RadioButton normalCurveButton;
    }
}
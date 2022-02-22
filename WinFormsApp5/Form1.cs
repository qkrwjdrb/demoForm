using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfluxDB.Client;
using InfluxDB.Client.Core.Flux.Domain;
using System.Windows.Forms.DataVisualization.Charting;

using System.Threading;
using Grpc.Core;
using Grpc.Net.Client;
using NetExchange;
using Google.Protobuf;


namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task.Run(() => RtuMessageService());
            Task.Run(() => ExtMessageService());
            Task.Run(() => CmdMessageService());
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.nh3Label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.co2Label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.humLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.temLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 43);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 666);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 375);
            this.panel8.MinimumSize = new System.Drawing.Size(0, 290);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(565, 290);
            this.panel8.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(565, 244);
            this.dataGridView1.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(4, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Title";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Title";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chart4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(565, 375);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(429, 291);
            this.panel7.TabIndex = 2;
            // 
            // chart4
            // 
            chartArea1.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea1);
            this.chart4.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart4.Legends.Add(legend1);
            this.chart4.Location = new System.Drawing.Point(10, 0);
            this.chart4.Margin = new System.Windows.Forms.Padding(0);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(419, 291);
            this.chart4.TabIndex = 2;
            this.chart4.Text = "chart4";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chart3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 115);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(994, 260);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.chart1);
            this.flowLayoutPanel1.Controls.Add(this.chart2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 260);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 250);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(310, 0);
            this.chart2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(324, 250);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(644, 0);
            this.chart3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(350, 250);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 115);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.nh3Label);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(744, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 105);
            this.panel6.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Completed";
            // 
            // nh3Label
            // 
            this.nh3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nh3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nh3Label.ForeColor = System.Drawing.Color.White;
            this.nh3Label.Location = new System.Drawing.Point(-19, 38);
            this.nh3Label.Name = "label15";
            this.nh3Label.Size = new System.Drawing.Size(266, 25);
            this.nh3Label.TabIndex = 1;
            this.nh3Label.Text = "95856565";
            this.nh3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "암모니아";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(68, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 25);
            this.label17.TabIndex = 3;
            this.label17.Text = "894456";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.co2Label);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(496, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 105);
            this.panel5.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Completed";
            // 
            // co2Label
            // 
            this.co2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.co2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.co2Label.ForeColor = System.Drawing.Color.White;
            this.co2Label.Location = new System.Drawing.Point(-31, 38);
            this.co2Label.Name = "label11";
            this.co2Label.Size = new System.Drawing.Size(266, 25);
            this.co2Label.TabIndex = 1;
            this.co2Label.Text = "95856565";
            this.co2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "이산화탄소";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(56, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "894456";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.humLabel);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(248, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 105);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Completed";
            // 
            // humLabel
            // 
            this.humLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.humLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humLabel.ForeColor = System.Drawing.Color.White;
            this.humLabel.Location = new System.Drawing.Point(-31, 38);
            this.humLabel.Name = "humLabel";
            this.humLabel.Size = new System.Drawing.Size(266, 25);
            this.humLabel.TabIndex = 1;
            this.humLabel.Text = "95856565";
            this.humLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "습도";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(56, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "894456";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.temLabel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 105);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Completed";
            // 
            // temLabel
            // 
            this.temLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.temLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.temLabel.ForeColor = System.Drawing.Color.White;
            this.temLabel.Location = new System.Drawing.Point(-31, 38);
            this.temLabel.Name = "temLabel";
            this.temLabel.Size = new System.Drawing.Size(266, 25);
            this.temLabel.TabIndex = 1;
            this.temLabel.Text = "95856565";
            this.temLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "온도";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "894456";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(450, 650);

            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(994, 709);
            //this.Controls.Add(this.panel2);
            //this.Controls.Add(this.panel1);
            //this.MinimumSize = new System.Drawing.Size(450, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }



        readonly List<string> allSensorList = new List<string> {
  "tem_1",
  "tem_2",
  "tem_3",
  "hum_1",
  "hum_2",
  "hum_3",
  "co2_1",
  "co2_2",
  "co2_3",
  "lux_1",
  "lux_2",
  "lux_3",
  "uv_1",
  "uv_2",
  "uv_3",
  "nh3_1",
  "nh3_2",
  "nh3_3",
  "nh3L_1",
  "nh3L_2",
  "nh3L_3",
  "nh3M_1",
  "nh3M_2",
  "nh3M_3",
  "nh3H_1",
  "nh3H_2",
  "nh3H_3",
  "no2_1",
  "no2_2",
  "no2_3",
  "no2L_1",
  "no2L_2",
  "no2L_3",
  "no2M_1",
  "no2M_2",
  "no2M_3",
  "no2H_1",
  "no2H_2",
  "no2H_3",
  "co_1",
  "co_2",
  "co_3",
  "coL_1",
  "coL_2",
  "coL_3",
  "coM_1",
  "coM_2",
  "coM_3",
  "coH_1",
  "coH_2",
  "coH_3",
};

        #region chartdata

        static List<ChartData> tem1ChartData = new List<ChartData> { };
        static List<ChartData> tem2ChartData = new List<ChartData> { };
        static List<ChartData> tem3ChartData = new List<ChartData> { };
        static List<ChartData> hum1ChartData = new List<ChartData> { };
        static List<ChartData> hum2ChartData = new List<ChartData> { };
        static List<ChartData> hum3ChartData = new List<ChartData> { };
        static List<ChartData> co21ChartData = new List<ChartData> { };
        static List<ChartData> co22ChartData = new List<ChartData> { };
        static List<ChartData> co23ChartData = new List<ChartData> { };
        static List<ChartData> lux1ChartData = new List<ChartData> { };
        static List<ChartData> lux2ChartData = new List<ChartData> { };
        static List<ChartData> lux3ChartData = new List<ChartData> { };
        static List<ChartData> uv1ChartData = new List<ChartData> { };
        static List<ChartData> uv2ChartData = new List<ChartData> { };
        static List<ChartData> uv3ChartData = new List<ChartData> { };
        static List<ChartData> nh31ChartData = new List<ChartData> { };
        static List<ChartData> nh32ChartData = new List<ChartData> { };
        static List<ChartData> nh33ChartData = new List<ChartData> { };
        static List<ChartData> nh3L1ChartData = new List<ChartData> { };
        static List<ChartData> nh3L2ChartData = new List<ChartData> { };
        static List<ChartData> nh3L3ChartData = new List<ChartData> { };
        static List<ChartData> nh3M1ChartData = new List<ChartData> { };
        static List<ChartData> nh3M2ChartData = new List<ChartData> { };
        static List<ChartData> nh3M3ChartData = new List<ChartData> { };
        static List<ChartData> nh3H1ChartData = new List<ChartData> { };
        static List<ChartData> nh3H2ChartData = new List<ChartData> { };
        static List<ChartData> nh3H3ChartData = new List<ChartData> { };
        static List<ChartData> no21ChartData = new List<ChartData> { };
        static List<ChartData> no22ChartData = new List<ChartData> { };
        static List<ChartData> no23ChartData = new List<ChartData> { };
        static List<ChartData> no2L1ChartData = new List<ChartData> { };
        static List<ChartData> no2L2ChartData = new List<ChartData> { };
        static List<ChartData> no2L3ChartData = new List<ChartData> { };
        static List<ChartData> no2M1ChartData = new List<ChartData> { };
        static List<ChartData> no2M2ChartData = new List<ChartData> { };
        static List<ChartData> no2M3ChartData = new List<ChartData> { };
        static List<ChartData> no2H1ChartData = new List<ChartData> { };
        static List<ChartData> no2H2ChartData = new List<ChartData> { };
        static List<ChartData> no2H3ChartData = new List<ChartData> { };
        static List<ChartData> co1ChartData = new List<ChartData> { };
        static List<ChartData> co2ChartData = new List<ChartData> { };
        static List<ChartData> co3ChartData = new List<ChartData> { };
        static List<ChartData> coL1ChartData = new List<ChartData> { };
        static List<ChartData> coL2ChartData = new List<ChartData> { };
        static List<ChartData> coL3ChartData = new List<ChartData> { };
        static List<ChartData> coM1ChartData = new List<ChartData> { };
        static List<ChartData> coM2ChartData = new List<ChartData> { };
        static List<ChartData> coM3ChartData = new List<ChartData> { };
        static List<ChartData> coH1ChartData = new List<ChartData> { };
        static List<ChartData> coH2ChartData = new List<ChartData> { };
        static List<ChartData> coH3ChartData = new List<ChartData> { };
        #endregion

        List<List<ChartData>> sensorChartData = new List<List<ChartData>> {
          tem1ChartData,
          tem2ChartData,
          tem3ChartData,
          hum1ChartData,
          hum2ChartData,
          hum3ChartData,
          co21ChartData,
          co22ChartData,
          co23ChartData,
          lux1ChartData,
          lux2ChartData,
          lux3ChartData,
          uv1ChartData,
          uv2ChartData,
          uv3ChartData,
          nh31ChartData,
          nh32ChartData,
          nh33ChartData,
          //18
          nh3L1ChartData,
          nh3L2ChartData,
          nh3L3ChartData,
          nh3M1ChartData,
          nh3M2ChartData,
          nh3M3ChartData,
          nh3H1ChartData,
          nh3H2ChartData,
          nh3H3ChartData,
          //27
          no21ChartData,
          no22ChartData,
          no23ChartData,
          //30
          no2L1ChartData,
          no2L2ChartData,
          no2L3ChartData,
          no2M1ChartData,
          no2M2ChartData,
          no2M3ChartData,
          no2H1ChartData,
          no2H2ChartData,
          no2H3ChartData,
          //39
          co1ChartData,
          co2ChartData,
          co3ChartData,
          //42
          coL1ChartData,
          coL2ChartData,
          coL3ChartData,
          coM1ChartData,
          coM2ChartData,
          coM3ChartData,
          coH1ChartData,
          coH2ChartData,
          coH3ChartData
    };

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            endResponsive();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            endResponsive();
        }

        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_RESTORE = 0xF120;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_SYSCOMMAND)
            {
                if (m.WParam == (IntPtr)SC_MAXIMIZE || m.WParam == (IntPtr)SC_RESTORE)
                    this.OnResizeEnd(EventArgs.Empty);
            }
        }

        private void endResponsive()
        {
            if (this.Width < 450)
            {
                tableLayoutPanel2.ColumnStyles[1].Width = 350;
            }
            else if (this.Width < 1010)
            {
                tableLayoutPanel2.ColumnStyles[1].Width = tableLayoutPanel2.Width - (chart1.Width + chart1.Margin.Right);
            }
            else
            {
                tableLayoutPanel2.ColumnStyles[1].Width = tableLayoutPanel2.Width -
                    (chart1.Width + chart2.Width + chart1.Margin.Right + chart2.Margin.Right);
            }

            if (this.Height <= 775)
            {
                panel8.Height = 290;
            }
            else
            {
                panel8.Height = panel7.Height;
            }
        }
        public async void influxDB()
        {
            InfluxDBClient client = InfluxDBClientFactory.Create("http://localhost:8086",
                                    "t7HUaHSBPVheH6QK351z1qpwuCX_rhq2vsX_-V7kqagcu7cNfRgR-wL0gzM6csRXIE0W8_r3I4AWETwmfSNRVQ==");

            //var query = $"from(bucket:\"database/autogen\") " +
            //      $" |> range(start: -15h)" +
            //      $" |> filter(fn: (r)=> r._measurement == \"table\")" +
            //      $" |> filter(fn: (r)=> r.column == \"data\" and r.colmun2 ==\"data2\")" +
            //      $" |> limit(n:1)";
            for (int i = 0; i < allSensorList.Count; i++)
            {

                var query = $"from(bucket:\"farmcare\") " +
                      $" |> range(start: -24h)" +
                      $" |> filter(fn: (r)=> r._measurement == \"{allSensorList[i]}\")" +
                      $" |> yield(name: \"mean\")";

                List<FluxTable> fluxTables = await client.GetQueryApi().QueryAsync(query, "saltanb");
                fluxTables.ForEach(table =>
                {
                    table.Records.ForEach(record =>
                    {
                        // label1.Text = $"1:{record.GetTime()} 2:{record.GetMeasurement()} 3:{ record.GetField()} 4:{ record.GetValue()}";


                        DateTime date = DateTime.Parse($"{record.GetTime()}");
                        double value = double.Parse($"{record.GetValue()}");
                        if (!sensorChartData[i].Contains(new ChartData(date, value)))
                        {
                            sensorChartData[i].Add(new ChartData(date, value));
                            if (i == 1)
                            {
                                temDate.Add(date);
                                temDouble.Add(value);
                            }
                        }

                    });
                });
            }
            client.Dispose();
            makeChart();
        }
        static List<DateTime> temDate = new List<DateTime> { };
        static List<double> temDouble = new List<double> { };
        private void Form1_Load(object sender, EventArgs e)
        {
            //test
            influxDB();
        }

        //테스트 버튼
        private void label1_Click(object sender, EventArgs e)
        {
            influxDB();
        }

        //테스트 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            Grpc_Test();
            influxDB();
        }


        private static GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:5044");
   


        internal static ExProto.ExProtoClient exchange = new ExProto.ExProtoClient(channel);

        internal static AsyncDuplexStreamingCall<RtuMessage, RtuMessage> rtuLink = exchange.MessageRtu();
        internal static AsyncDuplexStreamingCall<ExtMessage, ExtMessage> extLink = exchange.MessageExt();
        internal static AsyncDuplexStreamingCall<CmdMessage, CmdMessage> cmdLink = exchange.MessageCmd();

        internal UInt16 TxCnt;



        private async void RtuMessageService()
        {
            try
            {
                while (await rtuLink.ResponseStream.MoveNext(cancellationToken: CancellationToken.None))
                {
                    var response = rtuLink.ResponseStream.Current;

                    byte protocol = (byte)response.Channel;
                    UInt16 clientId = (UInt16)(response.Channel >> 8);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        //richTextBox2.Text = "RxRtu(" + GetProtocolChannelName(protocol) + ")";
                        //richTextBox2.AppendText(Environment.NewLine + $"Client ID={clientId}");
                    });

                    switch (protocol)
                    {
                        case 0:
                          // Modbus protocol 
                            byte[] payload = new byte[response.DataUnit.Length];
                            response.DataUnit.CopyTo(payload, 0);
                            RxRtu((UInt16)response.SequenceNumber, response.GwId, response.DeviceId, payload);
                            break;
                        default:
                            // Unknown protocol 
                            break;
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Application.Exit();
            }
        }

        private async void ExtMessageService()
        {
            try
            {
                while (await extLink.ResponseStream.MoveNext(cancellationToken: CancellationToken.None))
                {
                    var response = extLink.ResponseStream.Current;
                    byte[] payload = new byte[response.DataUnit.Length];
                    response.DataUnit.CopyTo(payload, 0);
                    RxExt(response.Context, response.GwId, response.DeviceId, payload);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Application.Exit();
            }
        }

        private async void CmdMessageService()
        {
            try
            {
                while (await cmdLink.ResponseStream.MoveNext(cancellationToken: CancellationToken.None))
                {
                    var response = cmdLink.ResponseStream.Current;
                    byte[] payload = new byte[response.Payload.Length];
                    response.Payload.CopyTo(payload, 0);
                    RxCmd((UInt16)response.OpCode, response.Route, response.Argument, response.GwId, response.DeviceId, payload);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Application.Exit();
            }
        }

        private String GetProtocolChannelName(UInt16 channel)
        {
            switch (channel)
            {
                case 0:
                    return "Modbus";
            }

            return "Unknown probotol";
        }
  static private readonly ushort[] wCRCTable =
{
            0x0000, 0xC0C1, 0xC181, 0x0140, 0xC301, 0x03C0, 0x0280, 0xC241, 0xC601, 0x06C0,
            0x0780, 0xC741, 0x0500, 0xC5C1, 0xC481, 0x0440, 0xCC01, 0x0CC0, 0x0D80, 0xCD41,
            0x0F00, 0xCFC1, 0xCE81, 0x0E40, 0x0A00, 0xCAC1, 0xCB81, 0x0B40, 0xC901, 0x09C0,
            0x0880, 0xC841, 0xD801, 0x18C0, 0x1980, 0xD941, 0x1B00, 0xDBC1, 0xDA81, 0x1A40,
            0x1E00, 0xDEC1, 0xDF81, 0x1F40, 0xDD01, 0x1DC0, 0x1C80, 0xDC41, 0x1400, 0xD4C1,
            0xD581, 0x1540, 0xD701, 0x17C0, 0x1680, 0xD641, 0xD201, 0x12C0, 0x1380, 0xD341,
            0x1100, 0xD1C1, 0xD081, 0x1040, 0xF001, 0x30C0, 0x3180, 0xF141, 0x3300, 0xF3C1,
            0xF281, 0x3240, 0x3600, 0xF6C1, 0xF781, 0x3740, 0xF501, 0x35C0, 0x3480, 0xF441,
            0x3C00, 0xFCC1, 0xFD81, 0x3D40, 0xFF01, 0x3FC0, 0x3E80, 0xFE41, 0xFA01, 0x3AC0,
            0x3B80, 0xFB41, 0x3900, 0xF9C1, 0xF881, 0x3840, 0x2800, 0xE8C1, 0xE981, 0x2940,
            0xEB01, 0x2BC0, 0x2A80, 0xEA41, 0xEE01, 0x2EC0, 0x2F80, 0xEF41, 0x2D00, 0xEDC1,
            0xEC81, 0x2C40, 0xE401, 0x24C0, 0x2580, 0xE541, 0x2700, 0xE7C1, 0xE681, 0x2640,
            0x2200, 0xE2C1, 0xE381, 0x2340, 0xE101, 0x21C0, 0x2080, 0xE041, 0xA001, 0x60C0,
            0x6180, 0xA141, 0x6300, 0xA3C1, 0xA281, 0x6240, 0x6600, 0xA6C1, 0xA781, 0x6740,
            0xA501, 0x65C0, 0x6480, 0xA441, 0x6C00, 0xACC1, 0xAD81, 0x6D40, 0xAF01, 0x6FC0,
            0x6E80, 0xAE41, 0xAA01, 0x6AC0, 0x6B80, 0xAB41, 0x6900, 0xA9C1, 0xA881, 0x6840,
            0x7800, 0xB8C1, 0xB981, 0x7940, 0xBB01, 0x7BC0, 0x7A80, 0xBA41, 0xBE01, 0x7EC0,
            0x7F80, 0xBF41, 0x7D00, 0xBDC1, 0xBC81, 0x7C40, 0xB401, 0x74C0, 0x7580, 0xB541,
            0x7700, 0xB7C1, 0xB681, 0x7640, 0x7200, 0xB2C1, 0xB381, 0x7340, 0xB101, 0x71C0,
            0x7080, 0xB041, 0x5000, 0x90C1, 0x9181, 0x5140, 0x9301, 0x53C0, 0x5280, 0x9241,
            0x9601, 0x56C0, 0x5780, 0x9741, 0x5500, 0x95C1, 0x9481, 0x5440, 0x9C01, 0x5CC0,
            0x5D80, 0x9D41, 0x5F00, 0x9FC1, 0x9E81, 0x5E40, 0x5A00, 0x9AC1, 0x9B81, 0x5B40,
            0x9901, 0x59C0, 0x5880, 0x9841, 0x8801, 0x48C0, 0x4980, 0x8941, 0x4B00, 0x8BC1,
            0x8A81, 0x4A40, 0x4E00, 0x8EC1, 0x8F81, 0x4F40, 0x8D01, 0x4DC0, 0x4C80, 0x8C41,
            0x4400, 0x84C1, 0x8581, 0x4540, 0x8701, 0x47C0, 0x4680, 0x8641, 0x8201, 0x42C0,
            0x4380, 0x8341, 0x4100, 0x81C1, 0x8081, 0x4040
        };
        public byte[] fn_makeCRC16_byte(byte[] bytes)
        {
            int ilen = bytes.Length;
            int icrc = 0xFFFF;
            for (int i = 0; i < ilen; i++)
            {
                icrc = (icrc >> 8) ^ wCRCTable[(icrc ^ bytes[i]) & 0xff];
            }
            byte[] ret = BitConverter.GetBytes((ushort)icrc);

            return ret;
        }
        public void TxRtu(UInt16 sequenceNumber, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            UInt16 channel = 0;
            var list = new List<byte>();
            list.AddRange(payload);
            list.AddRange(fn_makeCRC16_byte(payload));
            payload = list.ToArray();


            this.Invoke((MethodInvoker)delegate ()
            {
                //richTextBox1.Text = "TxRtu(" + GetProtocolChannelName(protocol) + ")";
                //richTextBox1.AppendText(Environment.NewLine + $"Client ID={clientID}");
                //richTextBox1.AppendText(Environment.NewLine + $"RequestStream.SequenceNumber={sequenceNumber}");
                //richTextBox1.AppendText(Environment.NewLine + $"RequestStream.GatewayId=" + gatewayId.ToString("X6"));
                //richTextBox1.AppendText(Environment.NewLine + $"RequestStream.DeviceId=" + deviceId.ToString("X12"));
                //richTextBox1.AppendText(Environment.NewLine + $"RequestStream.Tdu.Length={payload.Length}");
                //richTextBox1.AppendText(Environment.NewLine + $"RequestStream.Tdu={BitConverter.ToString(payload).Replace("-", string.Empty)}");
                //richTextBox1.AppendText(Environment.NewLine);
                //richTextBox2.Text = "Awaiting response...";
            });

            rtuLink.RequestStream.WriteAsync(new RtuMessage
            {

                Channel = channel,
                SequenceNumber = sequenceNumber,
                GwId = gatewayId,
                DeviceId = deviceId,
                DataUnit = ByteString.CopyFrom(payload[0..payload.Length])
            });
        }

        public void RxRtu(UInt16 acknowledgeNumber, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                //richTextBox2.AppendText(Environment.NewLine + $"response.AcknowledgeNumber={acknowledgeNumber}");
                //richTextBox2.AppendText(Environment.NewLine + $"response.GatewayId=" + gatewayId.ToString("X6"));
                //richTextBox2.AppendText(Environment.NewLine + $"response.DeviceId=" + deviceId.ToString("X12"));
                //richTextBox2.AppendText(Environment.NewLine + $"response.Tdu.Length={payload.Length}");
                //richTextBox2.AppendText(Environment.NewLine + BitConverter.ToString(payload));
                //richTextBox2.AppendText(Environment.NewLine);
                //richTextBox1.Text += "Responsed... ";
            });
        }

        public void TxExt(UInt64 context, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            UInt16 channel = (UInt16)context;

            this.Invoke((MethodInvoker)delegate ()
            {
                //richTextBox2.Text = "TxExt(" + GetProtocolChannelName(channel) + ")";
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.Context=" + context.ToString("X16"));
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.GatewayId=" + gatewayId.ToString("X6"));
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.DeviceId=" + deviceId.ToString("X12"));
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.Tdu.Length={payload.Length}");
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.Tdu={BitConverter.ToString(payload).Replace("-", string.Empty)}");
                //richTextBox2.AppendText(Environment.NewLine);
                //richTextBox3.Text = "Replied...";
            });

            extLink.RequestStream.WriteAsync(new ExtMessage
            {
                Context = context,
                GwId = gatewayId,
                DeviceId = deviceId,
                DataUnit = ByteString.CopyFrom(payload)
            });
        }

        public void RxExt(UInt64 context, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            UInt16 channel = (UInt16)context;

            this.Invoke((MethodInvoker)delegate ()
            {
                //richTextBox3.Text = "RxExt(" + GetProtocolChannelName(channel) + ")";
                //richTextBox3.AppendText(Environment.NewLine + $"RequestStream.Context=" + context.ToString("X16"));
                //richTextBox3.AppendText(Environment.NewLine + $"response.GatewayId=" + gatewayId.ToString("X6"));
                //richTextBox3.AppendText(Environment.NewLine + $"response.DeviceId=" + deviceId.ToString("X12"));
                //richTextBox3.AppendText(Environment.NewLine + $"response.Tdu.Length={payload.Length}");
                //richTextBox3.AppendText(Environment.NewLine + BitConverter.ToString(payload));
                //richTextBox3.AppendText(Environment.NewLine);
                //richTextBox3.Text += "Awaiting processing...";
            });

            switch (channel)
            {
                case 0: // Modbus Salve Processing 

                    TxExt(context, gatewayId, deviceId, new byte[] { });
                    break;
            }
        }

        public void TxCmd(UInt16 opCode, UInt32 route, UInt32 argument, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                //richTextBox2.Text = "TxExt()";
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.OpCode=" + opCode.ToString("X4"));
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.Route=" + route.ToString("X8"));
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.Argument=" + argument.ToString("X8"));
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.GatewayId=" + gatewayId.ToString("X6"));
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.DeviceId=" + deviceId.ToString("X12"));
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.Tdu.Length={payload.Length}");
                //richTextBox2.AppendText(Environment.NewLine + $"RequestStream.Tdu={BitConverter.ToString(payload).Replace("-", string.Empty)}");
                //richTextBox2.AppendText(Environment.NewLine);
                //richTextBox3.Text = "Replied...";
            });

            cmdLink.RequestStream.WriteAsync(new CmdMessage
            {
                OpCode = opCode,
                Route = route,
                Argument = argument,
                GwId = gatewayId,
                DeviceId = deviceId,
                Payload = ByteString.CopyFrom(payload)
            });
        }

        public void RxCmd(UInt16 opCode, UInt32 route, UInt32 argument, UInt32 gatewayId, UInt64 deviceId, byte[] payload)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                //richTextBox3.Text = "RxCmd()";
                //richTextBox3.AppendText(Environment.NewLine + $"RequestStream.OpCode=" + opCode.ToString("X4"));
                //richTextBox3.AppendText(Environment.NewLine + $"RequestStream.Route=" + route.ToString("X8"));
                //richTextBox3.AppendText(Environment.NewLine + $"RequestStream.Argument=" + argument.ToString("X8"));
                //richTextBox3.AppendText(Environment.NewLine + $"response.GatewayId=" + gatewayId.ToString("X6"));
                //richTextBox3.AppendText(Environment.NewLine + $"response.DeviceId=" + deviceId.ToString("X12"));
                //richTextBox3.AppendText(Environment.NewLine + $"response.Tdu.Length={payload.Length}");
                //richTextBox3.AppendText(Environment.NewLine + BitConverter.ToString(payload));
                //richTextBox3.AppendText(Environment.NewLine);
            });

            switch (opCode)
            {
                case 0:
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        //richTextBox2.Text += "Gateway... ";
                    });
                    break;
            }
        }
        public void Grpc_Test()
        {
            //TxRtu(++TxCnt, 0, 0x308398D9E8F5, new byte[] { 0x01, 0x03, 0x00, 0x01, 0x00, 0x08, 0x15, 0xCC });
            TxRtu(++TxCnt, 0, 0x4C7525c1cf89, new byte[] {  0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x01, 0x2e,
                   //opid
                0,9,
                0x00,0x00,0x00,0x00 });
        }

        private void makeChart()
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            chart4.Series.Clear();

            chart1.Series.Add("온도_1");
            chart1.Series.Add("온도_2");
            chart1.Series.Add("온도_3");

            chart2.Series.Add("습도_1");
            chart2.Series.Add("습도_2");
            chart2.Series.Add("습도_3");

            chart3.Series.Add("CO2_1");
            chart3.Series.Add("CO2_2");
            chart3.Series.Add("CO2_3");

            chart4.Series.Add("암모니아_1");
            chart4.Series.Add("암모니아_2");
            chart4.Series.Add("암모니아_3");

            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:dd";
            chart2.Series[0].XValueType = ChartValueType.DateTime;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:dd";
            chart3.Series[0].XValueType = ChartValueType.DateTime;
            chart3.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:dd";
            chart4.Series[0].XValueType = ChartValueType.DateTime;
            chart4.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:dd";




            chart1.Series[0].Points.DataBind(sensorChartData[0], "Time", "Sensordata", null);
            chart1.Series[1].Points.DataBind(sensorChartData[1], "Time", "Sensordata", null);
            chart1.Series[2].Points.DataBind(sensorChartData[2], "Time", "Sensordata", null);

            chart2.Series[0].Points.DataBind(sensorChartData[3], "Time", "Sensordata", null);
            chart2.Series[1].Points.DataBind(sensorChartData[4], "Time", "Sensordata", null);
            chart2.Series[2].Points.DataBind(sensorChartData[5], "Time", "Sensordata", null);

            chart3.Series[0].Points.DataBind(sensorChartData[6], "Time", "Sensordata", null);
            chart3.Series[1].Points.DataBind(sensorChartData[7], "Time", "Sensordata", null);
            chart3.Series[2].Points.DataBind(sensorChartData[8], "Time", "Sensordata", null);

            chart4.Series[0].Points.DataBind(sensorChartData[14], "Time", "Sensordata", null);
            chart4.Series[1].Points.DataBind(sensorChartData[15], "Time", "Sensordata", null);
            chart4.Series[2].Points.DataBind(sensorChartData[16], "Time", "Sensordata", null);



            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;

            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[1].ChartType = SeriesChartType.Line;
            chart2.Series[2].ChartType = SeriesChartType.Line;

            chart3.Series[0].ChartType = SeriesChartType.Line;
            chart3.Series[1].ChartType = SeriesChartType.Line;
            chart3.Series[2].ChartType = SeriesChartType.Line;

            chart4.Series[0].ChartType = SeriesChartType.Line;
            chart4.Series[1].ChartType = SeriesChartType.Line;
            chart4.Series[2].ChartType = SeriesChartType.Line;




            //chart2.Series[0].LegendText = "습도";
            //for (int i = 0; i < tem1ChartData.Count; i++)
            //{
            //}

            ChartData.chart_ = chart1;
        }
    }
}
public class ChartData
{
    public static Chart chart_ { get; set; }
    double sensordata;
    DateTime time;

    public ChartData(DateTime a, double b)
    {
        this.sensordata = b;
        this.time = a;
    }
    public DateTime Time
    {
        set { time = value; }
        get { return time; }
    }
    public double Sensordata
    {
        set { sensordata = value; }
        get { return sensordata; }
    }
}

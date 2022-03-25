
namespace WinFormsApp5.Forms
{
    partial class ControlForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.전압 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.남은시간 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OPID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.상태코드 = new System.Windows.Forms.Label();
            this.상태 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OnButton1 = new System.Windows.Forms.Button();
            this.OffButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.OnButton3 = new System.Windows.Forms.Button();
            this.OffButton3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.OnButton4 = new System.Windows.Forms.Button();
            this.OffButton4 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.OnButton5 = new System.Windows.Forms.Button();
            this.OffButton5 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.OnButton6 = new System.Windows.Forms.Button();
            this.OffButton6 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.OnButton7 = new System.Windows.Forms.Button();
            this.OffButton7 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.OnButton8 = new System.Windows.Forms.Button();
            this.OffButton8 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.OnButton2 = new System.Windows.Forms.Button();
            this.OffButton2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(20, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 169);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "구동기 제어";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(130, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "타이머 우회전";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "리셋";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "좌회전";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "우회전";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "타이머 좌회전";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 23);
            this.textBox1.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 60);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "정지";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "(초)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "(초)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.전압);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.남은시간);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.OPID);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.상태코드);
            this.groupBox4.Controls.Add(this.상태);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(274, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 169);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "구동기 상태";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "갱신시간";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 23);
            this.textBox4.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "(초)";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 19);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "실시간 갱신";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // 전압
            // 
            this.전압.AutoSize = true;
            this.전압.Location = new System.Drawing.Point(81, 122);
            this.전압.Name = "전압";
            this.전압.Size = new System.Drawing.Size(11, 15);
            this.전압.TabIndex = 41;
            this.전압.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "전압";
            // 
            // 남은시간
            // 
            this.남은시간.AutoSize = true;
            this.남은시간.Location = new System.Drawing.Point(81, 104);
            this.남은시간.Name = "남은시간";
            this.남은시간.Size = new System.Drawing.Size(11, 15);
            this.남은시간.TabIndex = 41;
            this.남은시간.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "남은시간";
            // 
            // OPID
            // 
            this.OPID.AutoSize = true;
            this.OPID.Location = new System.Drawing.Point(81, 85);
            this.OPID.Name = "OPID";
            this.OPID.Size = new System.Drawing.Size(11, 15);
            this.OPID.TabIndex = 41;
            this.OPID.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "OPID";
            // 
            // 상태코드
            // 
            this.상태코드.AutoSize = true;
            this.상태코드.Location = new System.Drawing.Point(81, 66);
            this.상태코드.Name = "상태코드";
            this.상태코드.Size = new System.Drawing.Size(11, 15);
            this.상태코드.TabIndex = 41;
            this.상태코드.Text = " ";
            // 
            // 상태
            // 
            this.상태.AutoSize = true;
            this.상태.Location = new System.Drawing.Point(81, 46);
            this.상태.Name = "상태";
            this.상태.Size = new System.Drawing.Size(11, 15);
            this.상태.TabIndex = 41;
            this.상태.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "상태코드";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "상태";
            // 
            // OnButton1
            // 
            this.OnButton1.Location = new System.Drawing.Point(15, 35);
            this.OnButton1.Name = "OnButton1";
            this.OnButton1.Size = new System.Drawing.Size(86, 24);
            this.OnButton1.TabIndex = 45;
            this.OnButton1.Text = "ON";
            this.OnButton1.UseVisualStyleBackColor = true;
            this.OnButton1.Click += new System.EventHandler(this.OnButton1_Click);
            // 
            // OffButton1
            // 
            this.OffButton1.Location = new System.Drawing.Point(15, 69);
            this.OffButton1.Name = "OffButton1";
            this.OffButton1.Size = new System.Drawing.Size(86, 24);
            this.OffButton1.TabIndex = 49;
            this.OffButton1.Text = "OFF";
            this.OffButton1.UseVisualStyleBackColor = true;
            this.OffButton1.Click += new System.EventHandler(this.OffButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(110, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "OPID (DEC)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(197, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 23);
            this.textBox3.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "OPID수동설정";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 63);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OnButton1);
            this.groupBox2.Controls.Add(this.OffButton1);
            this.groupBox2.Location = new System.Drawing.Point(20, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 125);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.OnButton3);
            this.groupBox5.Controls.Add(this.OffButton3);
            this.groupBox5.Location = new System.Drawing.Point(274, 479);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 125);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            // 
            // OnButton3
            // 
            this.OnButton3.Location = new System.Drawing.Point(15, 35);
            this.OnButton3.Name = "OnButton3";
            this.OnButton3.Size = new System.Drawing.Size(86, 24);
            this.OnButton3.TabIndex = 45;
            this.OnButton3.Text = "ON";
            this.OnButton3.UseVisualStyleBackColor = true;
            this.OnButton3.Click += new System.EventHandler(this.OnButton3_Click);
            // 
            // OffButton3
            // 
            this.OffButton3.Location = new System.Drawing.Point(15, 69);
            this.OffButton3.Name = "OffButton3";
            this.OffButton3.Size = new System.Drawing.Size(86, 24);
            this.OffButton3.TabIndex = 49;
            this.OffButton3.Text = "OFF";
            this.OffButton3.UseVisualStyleBackColor = true;
            this.OffButton3.Click += new System.EventHandler(this.OffButton3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.OnButton4);
            this.groupBox6.Controls.Add(this.OffButton4);
            this.groupBox6.Location = new System.Drawing.Point(401, 479);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(117, 125);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            // 
            // OnButton4
            // 
            this.OnButton4.Location = new System.Drawing.Point(15, 35);
            this.OnButton4.Name = "OnButton4";
            this.OnButton4.Size = new System.Drawing.Size(86, 24);
            this.OnButton4.TabIndex = 45;
            this.OnButton4.Text = "ON";
            this.OnButton4.UseVisualStyleBackColor = true;
            this.OnButton4.Click += new System.EventHandler(this.OnButton4_Click);
            // 
            // OffButton4
            // 
            this.OffButton4.Location = new System.Drawing.Point(15, 69);
            this.OffButton4.Name = "OffButton4";
            this.OffButton4.Size = new System.Drawing.Size(86, 24);
            this.OffButton4.TabIndex = 49;
            this.OffButton4.Text = "OFF";
            this.OffButton4.UseVisualStyleBackColor = true;
            this.OffButton4.Click += new System.EventHandler(this.OffButton4_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.OnButton5);
            this.groupBox7.Controls.Add(this.OffButton5);
            this.groupBox7.Location = new System.Drawing.Point(529, 479);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(117, 125);
            this.groupBox7.TabIndex = 50;
            this.groupBox7.TabStop = false;
            // 
            // OnButton5
            // 
            this.OnButton5.Location = new System.Drawing.Point(15, 35);
            this.OnButton5.Name = "OnButton5";
            this.OnButton5.Size = new System.Drawing.Size(86, 24);
            this.OnButton5.TabIndex = 45;
            this.OnButton5.Text = "ON";
            this.OnButton5.UseVisualStyleBackColor = true;
            this.OnButton5.Click += new System.EventHandler(this.OnButton5_Click);
            // 
            // OffButton5
            // 
            this.OffButton5.Location = new System.Drawing.Point(15, 69);
            this.OffButton5.Name = "OffButton5";
            this.OffButton5.Size = new System.Drawing.Size(86, 24);
            this.OffButton5.TabIndex = 49;
            this.OffButton5.Text = "OFF";
            this.OffButton5.UseVisualStyleBackColor = true;
            this.OffButton5.Click += new System.EventHandler(this.OffButton5_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.OnButton6);
            this.groupBox8.Controls.Add(this.OffButton6);
            this.groupBox8.Location = new System.Drawing.Point(656, 479);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(117, 125);
            this.groupBox8.TabIndex = 50;
            this.groupBox8.TabStop = false;
            // 
            // OnButton6
            // 
            this.OnButton6.Location = new System.Drawing.Point(15, 35);
            this.OnButton6.Name = "OnButton6";
            this.OnButton6.Size = new System.Drawing.Size(86, 24);
            this.OnButton6.TabIndex = 45;
            this.OnButton6.Text = "ON";
            this.OnButton6.UseVisualStyleBackColor = true;
            this.OnButton6.Click += new System.EventHandler(this.OnButton6_Click);
            // 
            // OffButton6
            // 
            this.OffButton6.Location = new System.Drawing.Point(15, 69);
            this.OffButton6.Name = "OffButton6";
            this.OffButton6.Size = new System.Drawing.Size(86, 24);
            this.OffButton6.TabIndex = 49;
            this.OffButton6.Text = "OFF";
            this.OffButton6.UseVisualStyleBackColor = true;
            this.OffButton6.Click += new System.EventHandler(this.OffButton6_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.OnButton7);
            this.groupBox9.Controls.Add(this.OffButton7);
            this.groupBox9.Location = new System.Drawing.Point(783, 479);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(117, 125);
            this.groupBox9.TabIndex = 50;
            this.groupBox9.TabStop = false;
            // 
            // OnButton7
            // 
            this.OnButton7.Location = new System.Drawing.Point(15, 35);
            this.OnButton7.Name = "OnButton7";
            this.OnButton7.Size = new System.Drawing.Size(86, 24);
            this.OnButton7.TabIndex = 45;
            this.OnButton7.Text = "ON";
            this.OnButton7.UseVisualStyleBackColor = true;
            this.OnButton7.Click += new System.EventHandler(this.OnButton7_Click);
            // 
            // OffButton7
            // 
            this.OffButton7.Location = new System.Drawing.Point(15, 69);
            this.OffButton7.Name = "OffButton7";
            this.OffButton7.Size = new System.Drawing.Size(86, 24);
            this.OffButton7.TabIndex = 49;
            this.OffButton7.Text = "OFF";
            this.OffButton7.UseVisualStyleBackColor = true;
            this.OffButton7.Click += new System.EventHandler(this.OffButton7_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.OnButton8);
            this.groupBox10.Controls.Add(this.OffButton8);
            this.groupBox10.Location = new System.Drawing.Point(910, 479);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(117, 125);
            this.groupBox10.TabIndex = 51;
            this.groupBox10.TabStop = false;
            // 
            // OnButton8
            // 
            this.OnButton8.Location = new System.Drawing.Point(15, 35);
            this.OnButton8.Name = "OnButton8";
            this.OnButton8.Size = new System.Drawing.Size(86, 24);
            this.OnButton8.TabIndex = 45;
            this.OnButton8.Text = "ON";
            this.OnButton8.UseVisualStyleBackColor = true;
            this.OnButton8.Click += new System.EventHandler(this.OnButton8_Click);
            // 
            // OffButton8
            // 
            this.OffButton8.Location = new System.Drawing.Point(15, 69);
            this.OffButton8.Name = "OffButton8";
            this.OffButton8.Size = new System.Drawing.Size(86, 24);
            this.OffButton8.TabIndex = 49;
            this.OffButton8.Text = "OFF";
            this.OffButton8.UseVisualStyleBackColor = true;
            this.OffButton8.Click += new System.EventHandler(this.OffButton8_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.OnButton2);
            this.groupBox11.Controls.Add(this.OffButton2);
            this.groupBox11.Location = new System.Drawing.Point(147, 479);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(117, 125);
            this.groupBox11.TabIndex = 50;
            this.groupBox11.TabStop = false;
            // 
            // OnButton2
            // 
            this.OnButton2.Location = new System.Drawing.Point(15, 35);
            this.OnButton2.Name = "OnButton2";
            this.OnButton2.Size = new System.Drawing.Size(86, 24);
            this.OnButton2.TabIndex = 45;
            this.OnButton2.Text = "ON";
            this.OnButton2.UseVisualStyleBackColor = true;
            this.OnButton2.Click += new System.EventHandler(this.OnButton2_Click);
            // 
            // OffButton2
            // 
            this.OffButton2.Location = new System.Drawing.Point(15, 69);
            this.OffButton2.Name = "OffButton2";
            this.OffButton2.Size = new System.Drawing.Size(86, 24);
            this.OffButton2.TabIndex = 49;
            this.OffButton2.Text = "OFF";
            this.OffButton2.UseVisualStyleBackColor = true;
            this.OffButton2.Click += new System.EventHandler(this.OffButton2_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 748);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "ControlForm";
            this.Text = "FormChart";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.Label 전압;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label 남은시간;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label OPID;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label 상태코드;
        public System.Windows.Forms.Label 상태;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OnButton1;
        private System.Windows.Forms.Button OffButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button OnButton3;
        private System.Windows.Forms.Button OffButton3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button OnButton4;
        private System.Windows.Forms.Button OffButton4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button OnButton5;
        private System.Windows.Forms.Button OffButton5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button OnButton6;
        private System.Windows.Forms.Button OffButton6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button OnButton7;
        private System.Windows.Forms.Button OffButton7;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button OnButton8;
        private System.Windows.Forms.Button OffButton8;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button OnButton2;
        private System.Windows.Forms.Button OffButton2;
    }
}
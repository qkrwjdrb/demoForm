
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
            this.gatewayBox = new System.Windows.Forms.ComboBox();
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
            this.button8 = new System.Windows.Forms.Button();
            this.deviceBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gatewayBox
            // 
            this.gatewayBox.FormattingEnabled = true;
            this.gatewayBox.Items.AddRange(new object[] {
            "308398D9E8F5",
            "4C7525891309",
            "4C7525891709",
            "4C752589171D",
            "4C7525891719",
            "4C75258916ED",
            "4C752589170D",
            "500291AEBD15",
            "4C75258914DD",
            "4C752589150D",
            "4C7525C1CF89"});
            this.gatewayBox.Location = new System.Drawing.Point(20, 72);
            this.gatewayBox.Name = "gatewayBox";
            this.gatewayBox.Size = new System.Drawing.Size(100, 23);
            this.gatewayBox.TabIndex = 0;
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
            this.groupBox3.Location = new System.Drawing.Point(12, 127);
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
            this.button4.Click += new System.EventHandler(this.button5_Click);
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
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(261, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 23);
            this.button8.TabIndex = 42;
            this.button8.Text = "리셋";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // deviceBox
            // 
            this.deviceBox.FormattingEnabled = true;
            this.deviceBox.Items.AddRange(new object[] {
            "308398D9E8F5",
            "4C7525891309",
            "4C7525891709",
            "4C752589171D",
            "4C7525891719",
            "4C75258916ED",
            "4C752589170D",
            "500291AEBD15",
            "4C75258914DD",
            "4C752589150D",
            "4C7525C1CF89"});
            this.deviceBox.Location = new System.Drawing.Point(142, 72);
            this.deviceBox.Name = "deviceBox";
            this.deviceBox.Size = new System.Drawing.Size(100, 23);
            this.deviceBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(277, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 63);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "OPID수동설정";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(197, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 23);
            this.textBox3.TabIndex = 12;
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
            this.groupBox4.Location = new System.Drawing.Point(856, 127);
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
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(283, 222);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "좌회전";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button2_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(389, 222);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "좌회전";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(495, 222);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 23);
            this.button11.TabIndex = 1;
            this.button11.Text = "좌회전";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button2_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(601, 222);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "좌회전";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button2_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(283, 267);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 23);
            this.button13.TabIndex = 1;
            this.button13.Text = "좌회전";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button2_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(389, 267);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 23);
            this.button14.TabIndex = 1;
            this.button14.Text = "좌회전";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button2_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(495, 267);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 23);
            this.button15.TabIndex = 1;
            this.button15.Text = "좌회전";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button2_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(601, 267);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "좌회전";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button2_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 748);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.deviceBox);
            this.Controls.Add(this.gatewayBox);
            this.Name = "ControlForm";
            this.Text = "FormChart";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox gatewayBox;
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox deviceBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}
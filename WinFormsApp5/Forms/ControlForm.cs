using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Core;
using Grpc.Net.Client;
using NetExchange;
using Google.Protobuf;
using System.Threading;
using WinFormsApp5;

namespace WinFormsApp5.Forms
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        ushort opid = 0;
        uint gatewayAddress = 0x0;
        ulong deviceAddress = 0x4C7525C1CF89;
        private void button1_Click(object sender, EventArgs e)
        {
            //리셋

            ResetDevice();

        }

        private void ResetDevice()
        {
            if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                {
                    0x01, 0x10, 0x01, 0xF5, 0x00, 0x02, 0x04,
                    0x00, 0x01, (byte)Convert.ToInt32(textBox3.Text), (byte)(Convert.ToInt32(textBox1.Text)>>8),
                });
            }
            else if (checkBox1.Checked && string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("OPID를 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                {
                    0x01, 0x10, 0x01, 0xF5, 0x00, 0x02, 0x04,
                    0x00, 0x01, (byte)(opid>>8),(byte)opid
                });
                opid++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //좌회전

            LeftTurn();

        }

        private void LeftTurn()
        {
            if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                   {
                    0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x01,0x2d,  (byte)Convert.ToInt32(textBox3.Text), (byte)(Convert.ToInt32(textBox1.Text)>>8), 0x00, 0x00, 0x00, 0x00

                   });
            }
            else if (checkBox1.Checked && string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("OPID를 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                {
                    0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x01,0x2d, (byte)(opid>>8),(byte)opid, 0x00, 0x00, 0x00, 0x00
                });
                opid++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //우회전

            RightTurn();
        }

        private void RightTurn()
        {
            if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                {
                    0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x01, 0x2e,  (byte)Convert.ToInt32(textBox3.Text), (byte)(Convert.ToInt32(textBox1.Text)>>8),0x00, 0x00, 0x00, 0x00
                });
            }
            else if (checkBox1.Checked && string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("OPID를 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                {

                    0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x01, 0x2e, (byte)(opid>>8),(byte)opid, 0x00, 0x00, 0x00, 0x00
                });
                opid++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //타이머 좌회전


            TimerLeftTurn();

        }

        private void TimerLeftTurn()
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                    {
                        0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                        0x01, 0x2F, 0x00, (byte)Convert.ToInt32(textBox3.Text), (byte)(Convert.ToInt32(textBox1.Text)>>8),(byte)Convert.ToInt32(textBox1.Text), 0x00, 0x00
                    });
                }
                else if (checkBox1.Checked && string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("OPID를 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                    {
                        0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                        0x01, 0x2F,(byte)(opid>>8),(byte)opid, (byte)(Convert.ToInt32(textBox1.Text)>>8),(byte)Convert.ToInt32(textBox1.Text), 0x00, 0x00
                    });
                    opid++;
                }

            }
            else
            {
                MessageBox.Show("시간을 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //타이머 우회전

            TimerRightTurn();

        }

        private void TimerRightTurn()
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                    {
                        0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                        0x01, 0x30, 0x00, (byte)Convert.ToInt32(textBox3.Text),(byte)(Convert.ToInt32(textBox2.Text)>>8), (byte)Convert.ToInt32(textBox2.Text), 0x00, 0x00
                    });
                }
                else if (checkBox1.Checked && string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("OPID를 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                    {
                        0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                        0x01, 0x30, (byte)(opid>>8),(byte)opid,  (byte)(Convert.ToInt32(textBox2.Text)>>8), (byte)Convert.ToInt32(textBox2.Text), 0x00, 0x00
                    });
                    opid++;
                }
            }
            else
            {
                MessageBox.Show("시간을 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //정지


            StopDevice();

        }

        private void StopDevice()
        {
            if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                {
                    0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x00, 0x00,  (byte)Convert.ToInt32(textBox3.Text), (byte)(Convert.ToInt32(textBox1.Text)>>8),0x00,0x00,0x00,0x00

                });
            }
            else if (checkBox1.Checked && string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("OPID를 입력해주세요.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2.f2.TxRtu(++Form2.f2.TxCnt, gatewayAddress, deviceAddress, new byte[]
                {
                    0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x00, 0x00, (byte)(opid>>8),(byte)opid,0x00,0x00,0x00,0x00
                });
                opid++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void ControlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
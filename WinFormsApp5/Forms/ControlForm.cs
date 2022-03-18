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


        private void button1_Click(object sender, EventArgs e)
        {
            //리셋
            if (int.TryParse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
                    && ulong.TryParse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
                )
            {
                if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
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
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
                    {
                    0x01, 0x10, 0x01, 0xF5, 0x00, 0x02, 0x04,
                    0x00, 0x01, (byte)(opid>>8),(byte)opid
                    });
                    opid++;
                }
            }
            else
            {
                MessageBox.Show("입력값을 확인하세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //좌회전
            if (int.TryParse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
               && ulong.TryParse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
            )
            {
                if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
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
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
                    {
                    0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x01,0x2d, (byte)(opid>>8),(byte)opid, 0x00, 0x00, 0x00, 0x00
                    });
                    opid++;
                }
            }
            else
            {
                MessageBox.Show("입력값을 확인하세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //우회전
            if (int.TryParse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
              && ulong.TryParse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
            )
            {

                if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
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
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
                    {

                    0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x01, 0x2e, (byte)(opid>>8),(byte)opid, 0x00, 0x00, 0x00, 0x00
                    });
                    opid++;
                }
            }
            else
            {
                MessageBox.Show("입력값을 확인하세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //타이머 좌회전
            if (int.TryParse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
              && ulong.TryParse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
            )
            {

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
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
                        Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
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
            else
            {
                MessageBox.Show("입력값을 확인하세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //타이머 우회전
            if (int.TryParse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
            && ulong.TryParse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
            )
            {

                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
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
                        Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
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
            else
            {
                MessageBox.Show("입력값을 확인하세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //정지
            if (int.TryParse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
                && ulong.TryParse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out _)
            )
            {

                if (checkBox1.Checked && !string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
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
                    Form2.f2.TxRtu(++Form2.f2.TxCnt, (uint)int.Parse(gatewayBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), ulong.Parse(deviceBox.Text.ToString(), System.Globalization.NumberStyles.HexNumber), new byte[]
                    {
                    0x01, 0x10, 0x01, 0xF7, 0x00, 0x04, 0x08,
                    0x00, 0x00, (byte)(opid>>8),(byte)opid,0x00,0x00,0x00,0x00
                    });
                    opid++;
                }
            }
            else
            {
                MessageBox.Show("입력값을 확인하세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
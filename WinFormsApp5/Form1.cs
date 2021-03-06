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
        }
        /*



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
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
   
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
 */ 
    }
}

using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfluxDB.Client;
using InfluxDB.Client.Core.Flux.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Net.Client;
using NetExchange;
using System.Threading;
using System.Net.Http;


namespace WinFormsApp5.Forms
{
    public partial class Formc : Form
    {
        public Formc()
        {
            InitializeComponent();
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

        private void makeChart()
        {

            var allTempList = new List<ChartData>();
            allTempList.AddRange(sensorChartData[0]);
            allTempList.AddRange(sensorChartData[1]);
            allTempList.AddRange(sensorChartData[2]);
            allTempList = allTempList.Distinct().ToList();
            var allTempValue = from TempList in allTempList
                               select TempList.Sensordata;
            chart1.ChartAreas[0].AxisY.Maximum = (int)allTempValue.Max();
            chart1.ChartAreas[0].AxisY.Minimum = (int)allTempValue.Min();
            chart1.Series.Clear();
            chart1.Series.Add("온도_1");
            chart1.Series.Add("온도_2");
            chart1.Series.Add("온도_3");
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:dd";
            chart1.Series[0].Points.DataBind(sensorChartData[0], "Time", "Sensordata", null);
            chart1.Series[1].Points.DataBind(sensorChartData[1], "Time", "Sensordata", null);
            chart1.Series[2].Points.DataBind(sensorChartData[2], "Time", "Sensordata", null);
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;


            var allHumList = new List<ChartData>();
            allHumList.AddRange(hum1ChartData);
            allHumList.AddRange(hum2ChartData);
            allHumList.AddRange(hum3ChartData);
            allHumList = allHumList.Distinct().ToList();
            var allHumValue = from HumList in allHumList
                              select HumList.Sensordata;
            chart2.ChartAreas[0].AxisY.Maximum = (int)allHumValue.Max();
            chart2.ChartAreas[0].AxisY.Minimum = (int)allHumValue.Min();

            chart2.Series.Clear();
            chart2.Series.Add("습도_1");
            chart2.Series.Add("습도_2");
            chart2.Series.Add("습도_3");
            chart2.Series[0].XValueType = ChartValueType.DateTime;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:dd";
            chart2.Series[0].Points.DataBind(sensorChartData[3], "Time", "Sensordata", null);
            chart2.Series[1].Points.DataBind(sensorChartData[4], "Time", "Sensordata", null);
            chart2.Series[2].Points.DataBind(sensorChartData[5], "Time", "Sensordata", null);
            chart2.Series[0].ChartType = SeriesChartType.Line;
            chart2.Series[1].ChartType = SeriesChartType.Line;
            chart2.Series[2].ChartType = SeriesChartType.Line;

            var allCo2List = new List<ChartData>();
            allCo2List.AddRange(co21ChartData);
            allCo2List.AddRange(co22ChartData);
            allCo2List.AddRange(co23ChartData);
            allCo2List = allCo2List.Distinct().ToList();
            var allCo2Value = from Co2List in allCo2List
                              select Co2List.Sensordata;
            chart3.ChartAreas[0].AxisY.Maximum = (int)allCo2Value.Max();
            chart3.ChartAreas[0].AxisY.Minimum = (int)allCo2Value.Min();

            chart3.Series.Clear();
            chart3.Series.Add("CO2_1");
            chart3.Series.Add("CO2_2");
            chart3.Series.Add("CO2_3");
            chart3.Series[0].XValueType = ChartValueType.DateTime;
            chart3.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:dd";
            chart3.Series[0].Points.DataBind(sensorChartData[6], "Time", "Sensordata", null);
            chart3.Series[1].Points.DataBind(sensorChartData[7], "Time", "Sensordata", null);
            chart3.Series[2].Points.DataBind(sensorChartData[8], "Time", "Sensordata", null);
            chart3.Series[0].ChartType = SeriesChartType.Line;
            chart3.Series[1].ChartType = SeriesChartType.Line;
            chart3.Series[2].ChartType = SeriesChartType.Line;

            var allLuxList = new List<ChartData>();
            allLuxList.AddRange(lux1ChartData);
            allLuxList.AddRange(lux2ChartData);
            allLuxList.AddRange(lux3ChartData);
            allLuxList = allLuxList.Distinct().ToList();
            var allLuxValue = from LuxList in allLuxList
                              select LuxList.Sensordata;
            chart4.ChartAreas[0].AxisY.Maximum = (int)allLuxValue.Max();
            chart4.ChartAreas[0].AxisY.Minimum = (int)allLuxValue.Min();

            chart4.Series.Clear();
            chart4.Series.Add("조도_1");
            chart4.Series.Add("조도_2");
            chart4.Series.Add("조도_3");
            chart4.Series[0].XValueType = ChartValueType.DateTime;
            chart4.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:dd";
            chart4.Series[0].Points.DataBind(sensorChartData[9], "Time", "Sensordata", null);
            chart4.Series[1].Points.DataBind(sensorChartData[10], "Time", "Sensordata", null);
            chart4.Series[2].Points.DataBind(sensorChartData[11], "Time", "Sensordata", null);
            chart4.Series[0].ChartType = SeriesChartType.Line;
            chart4.Series[1].ChartType = SeriesChartType.Line;
            chart4.Series[2].ChartType = SeriesChartType.Line;


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
        sensordata = b;
        time = a;
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

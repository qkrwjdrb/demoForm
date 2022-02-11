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
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            else if(this.Width<1010) 
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
            var query = $"from(bucket:\"farmcare\") " +
                  $" |> range(start: -24h)" +
                  $" |> filter(fn: (r)=> r._measurement == \"tem_1\")" +
                  $" |> yield(name: \"mean\")";

            List<FluxTable> fluxTables = await client.GetQueryApi().QueryAsync(query, "saltanb");

            fluxTables.ForEach(table =>
            {
                table.Records.ForEach(record =>
                {
                   label1.Text = ($"{record.GetTime()} {record.GetMeasurement()}:  { record.GetField()} { record.GetValue()}    ");
        
        });
            });
            client.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

            //테스트 버튼
        private void label1_Click(object sender, EventArgs e)
        {
            influxDB();
        }
    }
}

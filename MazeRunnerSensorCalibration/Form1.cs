using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeRunnerSensorCalibration
{
    public partial class Form1 : Form
    {
        DataTable dt;
        TcpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void nudStart_ValueChanged(object sender, EventArgs e)
        {
            nudDistance.Value = nudStart.Value;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nudDistance.Value = nudDistance.Value + nudInterval.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["Distance"]) == Convert.ToInt32(nudDistance.Value))
                {
                    if (checkBox1.Checked)
                        row["Sensor 1"] = Convert.ToInt32(nud1.Value);
                    if (checkBox2.Checked)
                        row["Sensor 2"] = Convert.ToInt32(nud2.Value);
                    if (checkBox3.Checked)
                        row["Sensor 3"] = Convert.ToInt32(nud3.Value);
                    if (checkBox4.Checked)
                        row["Sensor 4"] = Convert.ToInt32(nud4.Value);
                    if (checkBox5.Checked)
                        row["Sensor 5"] = Convert.ToInt32(nud5.Value);
                    if (checkBox6.Checked)
                        row["Sensor 6"] = Convert.ToInt32(nud6.Value);
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Distance");
            if (checkBox1.Checked)
                dt.Columns.Add("Sensor 1");
            if (checkBox2.Checked)
                dt.Columns.Add("Sensor 2");
            if (checkBox3.Checked)
                dt.Columns.Add("Sensor 3");
            if (checkBox4.Checked)
                dt.Columns.Add("Sensor 4");
            if (checkBox5.Checked)
                dt.Columns.Add("Sensor 5");
            if (checkBox6.Checked)
                dt.Columns.Add("Sensor 6");

            var current = nudStart.Value;
            while (current <= nudEnd.Value)
            {
                dt.Rows.Add(new object[] { Convert.ToInt32(current) });
                current += nudInterval.Value;
            }

            dataGridView1.DataSource = dt;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(client.GetStream(), Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine("Received: {0}", line);
                        backgroundWorker1.ReportProgress(1, line);
                    }
                }
                client.Close();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("ArgumentNullException: {0}", ex);
            }
            catch (SocketException ex)
            {
                Console.WriteLine("SocketException: {0}", ex);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var data = e.UserState as String;
            var datas = data.Split(' ');
            nud1.Value = Convert.ToInt32(data[0]);
            nud2.Value = Convert.ToInt32(data[1]);
            nud3.Value = Convert.ToInt32(data[2]);
            nud4.Value = Convert.ToInt32(data[3]);
            nud5.Value = Convert.ToInt32(data[4]);
            nud6.Value = Convert.ToInt32(data[5]);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtServer.Enabled = false;
            txtPort.Enabled = false;
            btnConnect.Enabled = false;
            try
            {
                client = new TcpClient(txtServer.Text, Convert.ToInt32(txtPort.Text));

                Byte[] data = Encoding.ASCII.GetBytes("D\n");
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                backgroundWorker1.RunWorkerAsync();

                MessageBox.Show("Connection successful.");
            }
            catch (Exception ex)
            {
                txtServer.Enabled = true;
                txtPort.Enabled = true;
                btnConnect.Enabled = true;
            }
        }

        private void btnGetReadings_Click(object sender, EventArgs e)
        {
            Byte[] data = Encoding.ASCII.GetBytes("N\n");

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            Console.WriteLine("Sent");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string sensor1 = "[" + dt.Rows.Count + "]PROGMEM = {";
            string sensor2 = "[" + dt.Rows.Count + "]PROGMEM = {";
            string sensor3 = "[" + dt.Rows.Count + "]PROGMEM = {";
            string sensor4 = "[" + dt.Rows.Count + "]PROGMEM = {";
            string sensor5 = "[" + dt.Rows.Count + "]PROGMEM = {";
            string sensor6 = "[" + dt.Rows.Count + "]PROGMEM = {";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (checkBox1.Checked)
                {
                    sensor1 += Convert.ToInt32(dt.Rows[i]["Sensor 1"]);
                    if (i != dt.Rows.Count - 1)
                        sensor1 += ",";
                }
                if (checkBox2.Checked)
                {
                    sensor2 += Convert.ToInt32(dt.Rows[i]["Sensor 2"]);
                    if (i != dt.Rows.Count - 1)
                        sensor2 += ",";
                }
                if (checkBox3.Checked)
                {
                    sensor3 += Convert.ToInt32(dt.Rows[i]["Sensor 3"]);
                    if (i != dt.Rows.Count - 1)
                        sensor3 += ",";
                }
                if (checkBox4.Checked)
                {
                    sensor4 += Convert.ToInt32(dt.Rows[i]["Sensor 4"]);
                    if (i != dt.Rows.Count - 1)
                        sensor4 += ",";
                }
                if (checkBox5.Checked)
                {
                    sensor5 += Convert.ToInt32(dt.Rows[i]["Sensor 5"]);
                    if (i != dt.Rows.Count - 1)
                        sensor5 += ",";
                }
                if (checkBox6.Checked)
                {
                    sensor6 += Convert.ToInt32(dt.Rows[i]["Sensor 6"]);
                    if (i != dt.Rows.Count - 1)
                        sensor6 += ",";
                }
            }

            sensor1 += "};\r\n";
            sensor2 += "};\r\n";
            sensor3 += "};\r\n";
            sensor4 += "};\r\n";
            sensor5 += "};\r\n";
            sensor6 += "};\r\n";

            string output = "// Start: " + nudStart.Value + " \r\n";
            output += "// End: " + nudEnd.Value + " \r\n";
            output += "// Interval: " + nudInterval.Value + " \r\n";

            output += "1: " + sensor1 + "2: " + sensor2 + "3: " + sensor3 + "4: " + sensor4 + "5: " + sensor5 + "6: " + sensor6;

            File.WriteAllText(DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", output);

            MessageBox.Show("Code exported.");
        }
    }
}

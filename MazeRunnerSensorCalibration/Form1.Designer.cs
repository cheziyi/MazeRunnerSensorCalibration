namespace MazeRunnerSensorCalibration
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.nudEnd = new System.Windows.Forms.NumericUpDown();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.nud4 = new System.Windows.Forms.NumericUpDown();
            this.nud5 = new System.Windows.Forms.NumericUpDown();
            this.nud6 = new System.Windows.Forms.NumericUpDown();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnGetReadings = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Distance";
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(26, 131);
            this.nudStart.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudStart.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(80, 20);
            this.nudStart.TabIndex = 5;
            this.nudStart.Value = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.nudStart.ValueChanged += new System.EventHandler(this.nudStart_ValueChanged);
            // 
            // nudEnd
            // 
            this.nudEnd.Location = new System.Drawing.Point(112, 131);
            this.nudEnd.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudEnd.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudEnd.Name = "nudEnd";
            this.nudEnd.Size = new System.Drawing.Size(80, 20);
            this.nudEnd.TabIndex = 6;
            this.nudEnd.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(198, 131);
            this.nudInterval.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(80, 20);
            this.nudInterval.TabIndex = 7;
            this.nudInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudDistance
            // 
            this.nudDistance.Location = new System.Drawing.Point(26, 226);
            this.nudDistance.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudDistance.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(80, 20);
            this.nudDistance.TabIndex = 8;
            this.nudDistance.Value = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Sensor 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(112, 281);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Sensor 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(198, 281);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Sensor 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(26, 337);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(68, 17);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Sensor 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(112, 337);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(68, 17);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "Sensor 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(198, 337);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(68, 17);
            this.checkBox6.TabIndex = 19;
            this.checkBox6.Text = "Sensor 6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(26, 304);
            this.nud1.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(80, 20);
            this.nud1.TabIndex = 20;
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(112, 304);
            this.nud2.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(80, 20);
            this.nud2.TabIndex = 21;
            // 
            // nud3
            // 
            this.nud3.Location = new System.Drawing.Point(198, 304);
            this.nud3.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(80, 20);
            this.nud3.TabIndex = 22;
            // 
            // nud4
            // 
            this.nud4.Location = new System.Drawing.Point(26, 360);
            this.nud4.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud4.Name = "nud4";
            this.nud4.Size = new System.Drawing.Size(80, 20);
            this.nud4.TabIndex = 23;
            // 
            // nud5
            // 
            this.nud5.Location = new System.Drawing.Point(112, 360);
            this.nud5.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud5.Name = "nud5";
            this.nud5.Size = new System.Drawing.Size(80, 20);
            this.nud5.TabIndex = 24;
            // 
            // nud6
            // 
            this.nud6.Location = new System.Drawing.Point(198, 360);
            this.nud6.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud6.Name = "nud6";
            this.nud6.Size = new System.Drawing.Size(80, 20);
            this.nud6.TabIndex = 25;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(112, 223);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(166, 23);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "Next Distance";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(26, 415);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(252, 23);
            this.btnOk.TabIndex = 27;
            this.btnOk.Text = "Save Current Values";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(26, 157);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(252, 23);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(458, 390);
            this.dataGridView1.TabIndex = 29;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Port";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(26, 35);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(166, 20);
            this.txtServer.TabIndex = 32;
            this.txtServer.Text = "192.168.7.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(198, 35);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(80, 20);
            this.txtPort.TabIndex = 33;
            this.txtPort.Text = "77";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(26, 61);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(145, 23);
            this.btnConnect.TabIndex = 34;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnGetReadings
            // 
            this.btnGetReadings.Location = new System.Drawing.Point(26, 386);
            this.btnGetReadings.Name = "btnGetReadings";
            this.btnGetReadings.Size = new System.Drawing.Size(252, 23);
            this.btnGetReadings.TabIndex = 35;
            this.btnGetReadings.Text = "Get Readings";
            this.btnGetReadings.UseVisualStyleBackColor = true;
            this.btnGetReadings.Click += new System.EventHandler(this.btnGetReadings_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(306, 415);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(458, 23);
            this.btnExport.TabIndex = 36;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(177, 61);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(101, 23);
            this.btnDebug.TabIndex = 37;
            this.btnDebug.Text = "Toggle Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 455);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnGetReadings);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.nud6);
            this.Controls.Add(this.nud5);
            this.Controls.Add(this.nud4);
            this.Controls.Add(this.nud3);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.nudDistance);
            this.Controls.Add(this.nudInterval);
            this.Controls.Add(this.nudEnd);
            this.Controls.Add(this.nudStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MazeRunner Sensor Calibration";
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.NumericUpDown nudEnd;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.NumericUpDown nud4;
        private System.Windows.Forms.NumericUpDown nud5;
        private System.Windows.Forms.NumericUpDown nud6;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnGetReadings;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDebug;
    }
}


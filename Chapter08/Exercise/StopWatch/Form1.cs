using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {

        Stopwatch sw = new Stopwatch();
        Timer tm = new Timer();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");

            tm.Tick += Tm_Tick;
            tm.Interval = 1; // 1ms
            tm.Start();
            
        }

        private void Tm_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void btStart_Click(object sender, EventArgs e) {
            sw.Start();
        }

        private void btReset_Click(object sender, EventArgs e) {
            lbTimerDisp.Text = "00:00:00.00";
            lbLapDisp.Items.Clear();
            sw.Reset();
        }

        private void btStop_Click(object sender, EventArgs e) {
            sw.Stop();
        }

        private void btLap_Click(object sender, EventArgs e) {
            lbLapDisp.Items.Add(sw.Elapsed.ToString(@"hh\:mm\:ss\.ff"));
        }
    }
}

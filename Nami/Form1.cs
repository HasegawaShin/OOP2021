using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nami_YarukiSwitch {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        int flag = 0;

        private void btSwitch_Click(object sender, EventArgs e) {
            lbGage.Text += "■";

            flag++;
            if (flag >= 0) {
                lbResult.Text = "イマイチ...";

                if (flag >= 10) {
                    lbGage.ForeColor = Color.Orange;
                    lbResult.Text = "もうちょっと...！";

                    if (flag >= 20) {
                        lbGage.ForeColor = Color.Red;
                        lbResult.Text = "やる気MAX！！！\n日誌かけえええええええ";
                    }
                }
            }
        }
    }
}

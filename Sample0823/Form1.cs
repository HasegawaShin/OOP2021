﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Exec_Click(object sender, EventArgs e) {
            
            // 整数に変換
            int value = int.Parse(Value.Text);
            int jyou = int.Parse(Jyou.Text);

            double result = Math.Pow(value, jyou);

            Result.Text = result.ToString();
        }
    }
}

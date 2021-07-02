using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {

        // コンストラクタ(先に呼ばれる)
        public Form1() {
            InitializeComponent();
        }

        // フォームがロードされるタイミングで一回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
        }
     

        private void Button5_3_1_Click(object sender, EventArgs e) {
            TextBoxSpaceCount.Text = inputStrText.Text.Count(s => s == ' ').ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            TextBoxWordChange.Text = inputStrText.Text.Replace("big", "small");
        }

        private void Button5_3_3_Click(object sender, EventArgs e) {
            var words = inputStrText.Text.Split(' ');

            TextBoxWordCount.Text = words.Length.ToString();
        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            var words = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);

            foreach (var word in words) {
                TextBoxWord_4.Text += word  + " ";
            }     

        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            var words = inputStrText.Text.Split(' ').ToArray();
            var sb = new StringBuilder();

            if (words.Length > 0) {
                foreach (var word in words) {
                    sb.Append(word + " ");
                }
                TextBoxAgain.Text = sb.ToString();
            }
            
        }

       
    }
}

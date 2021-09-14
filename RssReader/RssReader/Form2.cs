using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        // linkを受け取ってForm2に表示する
        public void openBrowser(string link) {
            wbBrowser.Url = new Uri(link);
        }

        private void btForward_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }

        private void btBack_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }
    }
}

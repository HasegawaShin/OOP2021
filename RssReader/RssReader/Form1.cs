using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            setRssTitle(tbUrl.Text);
        }

        List<string> listLinks = new List<string>(); // リンクを保存

        // 指定したURL先からXMLデータを取得し、title要素を取得し、リストボックスへセットする
        private void setRssTitle(string uri) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF8");

                var stream = wc.OpenRead(uri);

                XDocument xdoc = XDocument.Load(stream);
                var listTitles = xdoc.Root.Descendants("title").ToList();

                for (int i = 1; i < listTitles.Count; i++) {
                    lbTitle.Items.Add(listTitles[i].Value);
                    listLinks.Add(listTitles[i].Elements("link").Descendants().ToString());
                }

            }
        }

        private void lbTitle_SelectedIndexChanged(object sender, EventArgs e) {
            //wbBrowser.Url = new Uri(listLinks[lbTitle.SelectedIndex]);
        }
    }
}

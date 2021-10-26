using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendMail {
    public partial class ConfigForm : Form {
        public ConfigForm() {
            InitializeComponent();
        }

        private Settings settings = Settings.getInstance();

        // デフォルトボタン
        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost(); // ホスト名
            tbPort.Text = settings.sPort(); // ポート番号
            tbUserName.Text = settings.sMailAdder();　// ユーザー名
            tbPass.Text = settings.sPass(); // パスワード
            cbSsl.Checked = settings.bSsl(); // SSL
            tbSender.Text = settings.sMailAdder(); // 送信元
        }

        // 適用ボタン
        private void btApply_Click(object sender, EventArgs e) {
            // Settingオブジェクトに入力データを渡して登録を行う
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);
        }

        // OKボタン
        private void btOk_Click(object sender, EventArgs e) {
            this.settingRegist();
            this.Close();
        }

        // キャンセルボタン
        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        // 送信データ登録
        private void settingRegist() {
        }

        // 設定画面をロードすると一度だけ実行されるイベントハンドラ
        private void ConfigForm_Load(object sender, EventArgs e) {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAdder;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAdder;
        }
    }
}

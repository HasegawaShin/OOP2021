using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public class Settings {

        private static Settings instance = null;

        public static bool Set { get; private set; } = true;

        public string Host { get; set; } // ホスト名
        public int Port { get; set; } // ポート番号
        public string  MailAdder{ get; set; } // メールアドレス
        public string Pass { get; set; } // パスワード
        public bool Ssl { get; set; } // SSL

        // コンストラクタ
        private Settings() {
        }

        // インスタンスの取得
        public static Settings getInstance() {
            if (instance == null) {
                instance = new Settings();

                // XMLファイルを読み込み(逆シリアル化)【P303参照】
                try {
                    using (var reader = XmlReader.Create("mailsetting.xml")) {
                        var serializer = new DataContractSerializer(typeof(Settings));
                        var readSettings = serializer.ReadObject(reader) as Settings;

                        instance.Host = readSettings.Host;
                        instance.Port = readSettings.Port;
                        instance.MailAdder = readSettings.MailAdder;
                        instance.Pass = readSettings.Pass;
                        instance.Ssl = readSettings.Ssl;
                    }
                }
                // ファイルがない場合の処理
                catch (FileNotFoundException fe) {
                    Set = false; // データ未設定
                    // MessageBox.Show(fe.Message);
                }
                // その他の例外の処理
                catch (Exception ex) {
                    Set = false;
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return instance;
        }

        // 送信データ登録
        public bool setSendConfig(string host, int port,
                                  string mailAdder, string pass, bool ssl) {

            Host = host;
            Port = port;
            MailAdder = mailAdder;
            Pass = pass;
            Ssl = ssl;

            // XMLファイルへ書き出し(シリアル化)
            var xws = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "   ",
            };

            using (var writer = XmlWriter.Create("mailsetting.xml", xws)) {
                var serializer = new DataContractSerializer(this.GetType());
                serializer.WriteObject(writer, this);
            }

            Set = true;

            return true; // 登録完了
        }

        // 初期値
        public string sHost() {
            return "smtp.gmail.com";
        }

        public string sPort() {
            return 587.ToString();
        }

        public string sMailAdder() {
            return "ojsinfosys01@gmail.com";
        }

        public string sPass() {
            return "Infosys2021";
        }

        public bool bSsl() {
            return true;
        }

    }
}

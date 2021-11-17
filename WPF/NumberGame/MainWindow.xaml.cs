using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();

        Random random = new Random();
        private static int ANS = 0; // 答え

        public MainWindow() {
            ANS = random.Next(1, 26); // ランダムな値を生成
            InitializeComponent();

            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dt.Start();
            sw.Start();
            dt.Tick += Dt_Tick;
            this.Title = "NumberGame [00:00:000]";
        }

        private void Dt_Tick(object sender, EventArgs e) {            
            this.Title = "NumberGame [" + sw.Elapsed.ToString(@"mm\:ss\:fff") + "]";
        }

        // ボタンがクリックされた時に呼ばれるイベントハンドラ
        private void Button_Click(object sender, RoutedEventArgs e) {
            ChangeBackground((Button)e.Source);
            ResultText((Button)e.Source);
        }

        // ボタンの背景色を変えるメソッド
        private void ChangeBackground(Button button) {
            button.Background = Brushes.Gray;
        }

        // リザルトを表示
        private void ResultText(Button button) {
            int bt_num = int.Parse(button.Content.ToString());

            if (ANS > bt_num) {
                Tb_result.Text = "もっと大きい数です";
            } else if (ANS < bt_num) {
                Tb_result.Text = "もっと小さい数です";
            } else {
                sw.Stop();
                dt.Stop();
                button.Background = Brushes.OrangeRed;
                Tb_result.Text = "正解です";
            }
        }
    }
}

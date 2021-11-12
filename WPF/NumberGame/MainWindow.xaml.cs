using System;
using System.Collections.Generic;
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

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        Random random = new Random();
        private static int ANS = 0; // 答え

        public MainWindow() {
            ANS = random.Next(1, 25); // ランダムな値を生成
            InitializeComponent();
        }

        // ボタンがクリックされた時に呼ばれるイベントハンドラ
        private void Button_Click(object sender, RoutedEventArgs e) {
            ChaageBackground((Button)e.Source);
            ResultText((Button)e.Source);
        }

        // ボタンの背景色を変えるメソッド
        private void ChaageBackground(Button button) {
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
                Tb_result.Text = "正解です";
            }
        }
    }
}

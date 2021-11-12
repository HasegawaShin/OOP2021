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
        private int red = 0;

        public MainWindow() {
            IntRandom();
            InitializeComponent();
        }

        private void Bt_1_Click_1(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_1);
            red = 1;
            ResultText(red);
        }

        private void Bt_2_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_2);
            red = 2;
            ResultText(red);
        }

        private void Bt_3_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_3);
            red = 3;
            ResultText(red);
        }

        private void Bt_4_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_4);
            red = 4;
            ResultText(red);
        }

        private void Bt_5_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_5);
            red = 5;
            ResultText(red);
        }

        private void Bt_6_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_6);
            red = 6;
            ResultText(red);
        }

        private void Bt_7_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_7);
            red = 7;
            ResultText(red);
        }

        private void Bt_8_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_8);
            red = 8;
            ResultText(red);
        }

        private void Bt_9_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_9);
            red = 9;
            ResultText(red);
        }

        private void Bt_10_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_10);
            red = 10;
            ResultText(red);
        }

        private void Bt_11_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_11);
            red = 11;
            ResultText(red);
        }

        private void Bt_12_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_12);
            red = 12;
            ResultText(red);
        }

        private void Bt_13_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_13);
            red = 13;
            ResultText(red);
        }

        private void Bt_14_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_14);
            red = 14;
            ResultText(red);
        }

        private void Bt_15_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_15);
            red = 15;
            ResultText(red);
        }

        private void Bt_16_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_16);
            red = 16;
            ResultText(red);
        }

        private void Bt_17_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_17);
            red = 17;
            ResultText(red);
        }

        private void Bt_18_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_18);
            red = 18;
            ResultText(red);
        }

        private void Bt_19_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_19);
            red = 19;
            ResultText(red);
        }

        private void Bt_20_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_20);
            red = 20;
            ResultText(red);
        }

        private void Bt_21_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_21);
            red = 21;
            ResultText(red);
        }

        private void Bt_22_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_22);
            red = 22;
            ResultText(red);
        }

        private void Bt_23_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_23);
            red = 23;
            ResultText(red);
        }

        private void Bt_24_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_24);
            red =24;
            ResultText(red);
        }

        private void Bt_25_Click(object sender, RoutedEventArgs e) {
            ChabheBackground(Bt_25);
            red = 25;
            ResultText(red);
        }

        // ランダムな値を生成
        private void IntRandom() {
            ANS = random.Next(1, 25);
        }

        // ボタンの背景色を変えるメソッド
        private void ChabheBackground(Button button) {
            button.Background = Brushes.Gray;
        }

        // リザルトを表示
        private void ResultText(int red) {
            if (ANS > red) {
                Tb_result.Text = "もっと大きい数字です";
            } else if (ANS < red) {
                Tb_result.Text = "もっと小さい数字です";
            } else {
                Tb_result.Text = "正解です";
            }
        }
    }
}

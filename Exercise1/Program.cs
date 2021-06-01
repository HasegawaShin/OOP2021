using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
                new Song("マリーゴールド", "あいみょん", 240),
                new Song("ハルノヒ", "あいみょん", 230),
            };

            PrintSongs(songs);

        }

        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine(@"曲名：{0} アーティスト：{1} 演奏時間：{2:m\:ss}:{3:00}", song.Title1, song.ArtistName1, TimeSpan.FromSeconds(song.Length1));
            }
        }
    }
}

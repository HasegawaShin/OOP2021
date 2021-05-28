using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            List<Song> songs = new List<Song>();

            songs.Add(new Song("Lemon", "米津玄師", 240));
            songs.Add(new Song("Loser", "米津玄師", 230));

        }

        private static void PrintSongs(Song[] songs) {
            foreach (var i in songs) {
                Console.WriteLine("曲名：{0} アーティスト：{1} 演奏時間：{2}:{3:00}", i.Title1, i.ArtistName1, (i.Length1 / 60), (i.Length1 % 60));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song {
        private string Title; // 歌のタイトル
        private string ArtistName; // アーティスト
        private int Length; // 演奏時間 (s)

        public string Title1 { get => Title; set => Title = value; }
        public string ArtistName1 { get => ArtistName; set => ArtistName = value; }
        public int Length1 { get => Length; set => Length = value; }

        public Song(string Title, string ArtistName, int Length) {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;
        }

    }
}

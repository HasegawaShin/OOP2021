using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }

    class Program {
        static void Main(string[] args) {

            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise6_1(numbers);
            Console.WriteLine("-----");

            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise6_2(books);
            Console.WriteLine("-----");
        }

        private static void Exercise6_1(int[] numbers) {
            // 1.最大値
            Console.WriteLine(numbers.Max());
            // 2.最後から二つ
            for (int i = 1; i < 3; i++) {
                Console.WriteLine(numbers[numbers.Length - i]);
            }
            // 3.数値を文字列に変換し出力
            foreach (var numStr in numbers.Select(x => x.ToString())) {
                Console.Write(numStr + " ");
            }
            Console.WriteLine();
            // 4.小さい順に3つ
            foreach (var num in numbers.OrderBy(x => x).Take(3)){
                Console.Write(num + " ");
            }
            Console.WriteLine();
            // 5
            Console.WriteLine(numbers.Distinct().Count(x => x > 10)); 

        }

        private static void Exercise6_2(List<Book> books) {
            // 1
            var whereBook = books.Where(x => x.Title.Contains("ワンダフル・C#ライフ"));
            foreach (var book in whereBook) {
                Console.WriteLine("価格：" + book.Price + "　ページ数：" + book.Pages);
            }
            // 2
            var countBook = books.Count(x => x.Title.Contains("C#"));
            Console.WriteLine(countBook);
            // 3
            var avePages = books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages);
            Console.WriteLine(avePages + "ページ");
            // 4
            var selectbook = books.FirstOrDefault(x => x.Price >= 4000);
            if (selectbook != null) {
                Console.WriteLine(selectbook.Title);
            }
            // 5
            var boook = books.Where(x => x.Price < 4000).Max(x => x.Pages);
            Console.WriteLine(boook);
            // 6
            var booook = books.Where(x => x.Pages >= 400).OrderBy(x => x.Price);
            foreach (var book in booook) {
                Console.WriteLine("タイトル：" + book.Title + "　価格：" + book.Price);
            }
            // 7
            var boooook = books.Where(x => x.Title.Contains("C#") && x.Pages <= 500);
            foreach (var book in boooook) {
                Console.WriteLine(book.Title);
            }
        }

      
    }
}

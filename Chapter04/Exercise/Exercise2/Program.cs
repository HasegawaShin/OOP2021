using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            // 4.2.1
            var YearMonths = new YearMonth[] {
                new YearMonth(2101, 2),
                new YearMonth(2111, 8),
                new YearMonth(2112, 10),
                new YearMonth(2021, 5),
                new YearMonth(2323, 6),
            };

            // 4.2.2
            foreach (var ym in YearMonths) {
                Console.WriteLine(ym);
            }

            // 4.2.4
            if (First21Century(YearMonths) == null) {
                Console.WriteLine("21世紀のデータはありません。");
            } else {
                Console.WriteLine(First21Century(YearMonths).Year);
            }



        }

        // 4.2.3
        public static YearMonth First21Century(YearMonth[] YearMonths) {
            foreach (var ym in YearMonths) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }


    }
}

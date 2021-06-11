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
            var ymCollection = new YearMonth[] {
                new YearMonth(2101, 2),
                new YearMonth(2111, 8),
                new YearMonth(2112, 10),
                new YearMonth(2021, 12),
                new YearMonth(2323, 6),
            };

            // 4.2.2
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }

            // 4.2.4
            var yearmonth = First21Century(ymCollection);
            var s = yearmonth != null ? yearmonth.Year.ToString() : "21世紀のデータはありません";

            // 4.2.5

            // ToArray():配列に格納して　　ToList():リストに格納して
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine(ym);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            #region 問題5.1
            // 5.1
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();

            if (String.Compare(str1, str2, ignoreCase : true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
            Console.WriteLine("-------------------");
            #endregion

            // 5.2 未完成
            var str = int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine(number);

        }
    }
}

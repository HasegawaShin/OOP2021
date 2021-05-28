using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            PrintIncToMeterList(1, 10);
        }

        // インチからメートルへの対応表を出力
        private static void PrintIncToMeterList(int start, int stop) {
            for (int inc = start; inc <= stop; inc++) {
                double meter = IncConverter.FromInc(inc);
                Console.WriteLine("{0} inc = {1:0.0000} m", inc, meter);
            }
        }
    }
}

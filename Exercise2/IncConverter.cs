using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class IncConverter {

        private const double ratio = 0.0254;

        // インチからメートルを求める
        public static double FromInc(int inc) {
            return inc * ratio;
        }

        // メートルからインチを求める
        public static double ToMeter(int meter) {
            return  meter* ratio;
        }
    }
}

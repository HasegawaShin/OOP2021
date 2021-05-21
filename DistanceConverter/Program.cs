﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeetToMeterList(1, 10);
            } else {
                PrintMeterToFeetList(1, 10);
            }

        }

        // フィートからメートルへの対応表を出力
        private static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0} ft = {1:0.0000} ft", meter, feet);
            }
        }

        // メートルからフィートへの対応表を出力
        private static void PrintFeetToMeterList(int start, int stop) {
            for (int feet = start; feet <= stop; feet++) {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        // フィートからメートルを求める
        private static double FeetToMeter(int feet) {
            return feet * 0.3048;
        }

        // メートルからフィートを求める
        private static double MeterToFeet(int meter) {
            return meter / 0.3048;
        }

    }
}

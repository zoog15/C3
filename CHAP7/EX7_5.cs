using System;

namespace EX7_5 {
    struct ACSetting {
        public double currentInCelsius; // 현재 온도(섭씨)
        public double target; // 희망 온도

        public readonly double GetFahrenheit() {
            //target = currentInCelsius * 1.8 + 32; // 화씨 계산 결과 target에 저장
            double fahrenheit = currentInCelsius * 1.8 + 32;
            return fahrenheit; // target 반환
        }
    }

    class MainApp {
        static void Main(string[] args) {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}

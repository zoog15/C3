using System;


namespace C3_Practice
{
    class WaterHeater {
        protected int temperature;

        public void SetTemperature(int temperature) {
            // -5~42 도를 벗어난 값이 들어오면 예외를 발생
            if (temperature < -5 || temperature > 42) {
                throw new Exception("Out of temperature range");
            }

            // temperature는 protected로 수식되어 외부에서 직접 접근 불가능. public 메소드 통해 접근해야함
            this.temperature = temperature;
        }

        internal void TurnOnWater() {
            Console.WriteLine($"Turn on water : {temperature}");
        }

        class AccessModifier {
            static void Main(string[] args)
            {
                try
                {
                    WaterHeater heater = new WaterHeater();
                    heater.SetTemperature(20);
                    heater.TurnOnWater();

                    heater.SetTemperature(-2);
                    heater.TurnOnWater();

                    // 에러메시지가 발생하여 TurnOnWater로 가지않고 catch 블록으로 이동
                    heater.SetTemperature(50);
                    heater.TurnOnWater();
                }
                catch (Exception e) 
                { 
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

using System;


namespace C3_Practice
{
    class Configuration {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2) {
            min = v1;
            max = v2;
        }

        public void ChangeMax(int newMax) {
            // readonly 필드를 생성자가 아닌 다른곳에서 수정하려 했기에 컴파일 에러 발생
            max = newMax;
        }
    }

    class ReadOnlyFields {
        static void Main(string[] args) {
            Configuration c = new Configuration(100, 10);
        }
    }
}

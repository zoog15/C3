using System;


namespace Ex9_1
{
    class NameCard {
        private int age;
        private string name;

        public int Age
        {
            get {
                return age;
            }
            set {
                age = value;
            }
        }

        public string Name
        {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
    }

    class MainApp {
        public static void Main() {
            NameCard MyCard = new NameCard();

            MyCard.Age = 24;
            MyCard.Name = "상현";

            Console.WriteLine("나이 : {0}", MyCard.Age);
            Console.WriteLine("이름 : {0}", MyCard.Name);
        }
    }
}

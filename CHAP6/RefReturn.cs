using System;


namespace C3_Practice
{
    class Product {
        private int price = 100;

        public ref int GetPrice() {
            return ref price;
        }

        public void PrintPrice() {
            Console.WriteLine($"Price: {price}");
        }
    }
    class RefReturn
    {
        static void Main(string[] args) {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            // ref_local_price를 수정하면 carrot.price의 내용도 같이 바뀜
            ref_local_price = 200;
            carrot.PrintPrice();
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");
        }
    }
}

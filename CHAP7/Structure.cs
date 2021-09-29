using System;

namespace Structure {
    struct Point3D {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int X, int Y, int Z) {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return String.Format($"{X},{Y},{Z}");
        }
    }

    class MainApp {
        static void Main(string[] args) {
            // 선언 만으로 인스턴스 생성
            Point3D p3d1;
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString());

            // 생성자를 이용해서도 생성 가능
            Point3D p3d2 = new Point3D(100, 200, 300);
            // 깊은 복사 이루어짐
            Point3D p3d3 = p3d2;
            p3d3.Z = 400;

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
        }
    }
}

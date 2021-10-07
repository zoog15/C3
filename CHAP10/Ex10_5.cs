using System;
using System.Collections;
using static System.Console;


namespace Ex10_2
{
    class MainApp {
        static void Main(string[] args) {
            Hashtable ht = new Hashtable();

            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            WriteLine("회사 : {0}", ht["회사"]);
            WriteLine("URL : {0}", ht["URL"]);
        }
    }
}

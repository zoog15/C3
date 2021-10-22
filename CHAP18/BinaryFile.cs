using System;
using static System.Console;
using System.IO;
using FS = System.IO.FileStream;




namespace UsingDeclaration
{
    class MainApp
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw =
                new BinaryWriter(
                        new FileStream("a.dat", FileMode.Create)))
            {
                bw.Write(int.MaxValue);
                bw.Write("Good morning");
                bw.Write(uint.MaxValue);
                bw.Write("안녕하세요!");
                bw.Write(double.MaxValue);
            }

            using BinaryReader br =
                new BinaryReader(
                    new FileStream("a.dat", FileMode.Open));

            WriteLine($"File size : {br.BaseStream.Length} bytes");
            WriteLine($"{br.ReadInt32()}");
            WriteLine($"{br.ReadString()}");
            WriteLine($"{br.ReadUInt32()}");
            WriteLine($"{br.ReadString()}");
            WriteLine($"{br.ReadDouble()}");
        }
    }
}
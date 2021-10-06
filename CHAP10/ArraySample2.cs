using System;


namespace ArraySample2
{
    class MainApp {
        static void Main(string[] args) {
            int[] score = new int[5];
            score[0] = 80;
            score[1] = 74;
            score[2] = 81;
            score[^2] = 90; // 배열의 마지막-1
            score[^1] = 34; // 배열의 마지막

            foreach (int scores in score)
                Console.WriteLine(scores);

            int sum = 0;
            foreach (int scores in score)
                sum += scores;

            int average = sum / score.Length; ;

            Console.WriteLine($"Average Score : {average}");
        }
    }
}

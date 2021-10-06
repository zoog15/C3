using System;


namespace ArraySample
{
    class MainApp {
        static void Main(string[] args) {
            int[] score = new int[5];
            score[0] = 80;
            score[1] = 74;
            score[2] = 81;
            score[3] = 90;
            score[4] = 34;

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

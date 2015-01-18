using System;

class NakovsMatching
{
    static void Main()
    {
        string wordA = Console.ReadLine();
        string wordB = Console.ReadLine();
        int limit = int.Parse(Console.ReadLine());

        bool validSolution = false;

        for (int a = 1; a < wordA.Length; a++)
        {
            string aLeft = wordA.Substring(0, a);
            string aRight = wordA.Substring(a, wordA.Length - a);
            for (int b = 1; b < wordB.Length; b++)
            {
                string bLeft = wordB.Substring(0, b);
                string bRight = wordB.Substring(b, wordB.Length - b);
                int nakovsDistance = CalcNakovsDistance(aLeft, aRight, bLeft, bRight);
                if (nakovsDistance <= limit)
                {
                    validSolution = true;
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", 
                        aLeft, aRight, bLeft, bRight, nakovsDistance);
                }
            }
        }
        if (!validSolution)
        {
            Console.WriteLine("No");
        }
    }
    public static int CalcWordWeight(string word)
    {
        int weight = 0;
        for (int i = 0; i < word.Length; i++)
        {
            weight += word[i];
        }
        return weight;
    }
    public static int CalcNakovsDistance(string aLeft, string aRight, string bLeft, string bRight)
    {
        int nakovsDistance = Math.Abs(CalcWordWeight(aLeft) * CalcWordWeight(bRight) - CalcWordWeight(aRight) * CalcWordWeight(bLeft));
        return nakovsDistance;

    }
}
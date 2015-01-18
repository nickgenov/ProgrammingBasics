using System;

class BitBall
{
    //Telerik Academy Exam 1 @ 28 Dec 2012
    //Problem 5 – Bit Ball
    static void Main()
    {
        //parse the first 8 numbers - the first team
        int[] team1 = new int[8];
        for (int i = 0; i < team1.Length; i++)
        {
            team1[i] = int.Parse(Console.ReadLine());
        }
        //parse the second 8 numbers - the second team
        int[] team2 = new int[8];
        for (int i = 0; i < team2.Length; i++)
        {
            team2[i] = int.Parse(Console.ReadLine());
        }
        //remove the players that committed a foul
        for (int i = 0; i < team1.Length; i++)
        {
            int valueTeam1 = team1[i] & (team1[i] ^ team2[i]);
            int valueTeam2 = team2[i] & (team2[i] ^ team1[i]);
            team1[i] = valueTeam1;
            team2[i] = valueTeam2;
        }

        int goalsTeam1 = 0;
        int goalsTeam2 = 0;

        //goals for team1
        for (int row = 0; row < 7; row++)
        {
            int result = 0;
            for (int playerRow = row; playerRow < 7; playerRow++)
            {
                result = team1[playerRow] & (team1[playerRow] ^ team1[playerRow + 1]);
            }
        }
     

     
    }
    public static int CountOneBits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            int bit = number % 2;
            if (bit == 1)
            {
                count++;
            }
            number /= 2;
        }
        return count;
    }
}

//AUTHOR SOLUTION!!!
//using system;
//using system.linq;

//public class bitball
//{
//    static void main(string[] args)
//    {
//        short bytelength = 8;
//        int topteamscore = 0;
//        int bottomteamscore = 0;

//        #region read top team players
//        byte top0 = byte.parse(console.readline());
//        byte top1 = byte.parse(console.readline());
//        byte top2 = byte.parse(console.readline());
//        byte top3 = byte.parse(console.readline());
//        byte top4 = byte.parse(console.readline());
//        byte top5 = byte.parse(console.readline());
//        byte top6 = byte.parse(console.readline());
//        byte top7 = byte.parse(console.readline());
//        #endregion

//        #region read bottom team players
//        byte bottom0 = byte.parse(console.readline());
//        byte bottom1 = byte.parse(console.readline());
//        byte bottom2 = byte.parse(console.readline());
//        byte bottom3 = byte.parse(console.readline());
//        byte bottom4 = byte.parse(console.readline());
//        byte bottom5 = byte.parse(console.readline());
//        byte bottom6 = byte.parse(console.readline());
//        byte bottom7 = byte.parse(console.readline());
//        #endregion

//        #region check for red cards
//        for (int i = 0; i < bytelength; i++)
//        {
//            if (((top0 >> i) & 1) == 1 &&
//                ((bottom0 >> i) & 1) == 1)
//            {
//                top0 = (byte)(top0 & (~(1 << i)));
//                bottom0 = (byte)(bottom0 & (~(1 << i)));
//            }

//            if (((top1 >> i) & 1) == 1 &&
//                ((bottom1 >> i) & 1) == 1)
//            {
//                top1 = (byte)(top1 & (~(1 << i)));
//                bottom1 = (byte)(bottom1 & (~(1 << i)));
//            }

//            if (((top2 >> i) & 1) == 1 &&
//                ((bottom2 >> i) & 1) == 1)
//            {
//                top2 = (byte)(top2 & (~(1 << i)));
//                bottom2 = (byte)(bottom2 & (~(1 << i)));
//            }

//            if (((top3 >> i) & 1) == 1 &&
//                ((bottom3 >> i) & 1) == 1)
//            {
//                top3 = (byte)(top3 & (~(1 << i)));
//                bottom3 = (byte)(bottom3 & (~(1 << i)));
//            }

//            if (((top4 >> i) & 1) == 1 &&
//                ((bottom4 >> i) & 1) == 1)
//            {
//                top4 = (byte)(top4 & (~(1 << i)));
//                bottom4 = (byte)(bottom4 & (~(1 << i)));
//            }

//            if (((top5 >> i) & 1) == 1 &&
//                ((bottom5 >> i) & 1) == 1)
//            {
//                top5 = (byte)(top5 & (~(1 << i)));
//                bottom5 = (byte)(bottom5 & (~(1 << i)));
//            }

//            if (((top6 >> i) & 1) == 1 &&
//                ((bottom6 >> i) & 1) == 1)
//            {
//                top6 = (byte)(top6 & (~(1 << i)));
//                bottom6 = (byte)(bottom6 & (~(1 << i)));
//            }

//            if (((top7 >> i) & 1) == 1 &&
//                ((bottom7 >> i) & 1) == 1)
//            {
//                top7 = (byte)(top7 & (~(1 << i)));
//                bottom7 = (byte)(bottom7 & (~(1 << i)));
//            }
//        }
//        #endregion

//        #region perform top team attacks
//        for (int row = 0; row < bytelength; row++)
//        {
//            for (int col = 0; col < bytelength; col++)
//            {
//                switch (row)
//                {
//                    case (0):
//                        if (((top0 >> col) & 1) == 1)
//                        {
//                            if ((((top1 | top2 | top3 | top4 | top5 | top6 | top7 | bottom1 | bottom2 | bottom3 | bottom4 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
//                            {
//                                topteamscore++;
//                            }
//                        }
//                        break;
//                    case (1):
//                        if (((top1 >> col) & 1) == 1)
//                        {
//                            if ((((top2 | top3 | top4 | top5 | top6 | top7 | bottom2 | bottom3 | bottom4 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
//                            {
//                                topteamscore++;
//                            }
//                        }
//                        break;
//                    case (2):
//                        if (((top2 >> col) & 1) == 1)
//                        {
//                            if ((((top3 | top4 | top5 | top6 | top7 | bottom3 | bottom4 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
//                            {
//                                topteamscore++;
//                            }
//                        }
//                        break;
//                    case (3):
//                        if (((top3 >> col) & 1) == 1)
//                        {
//                            if ((((top4 | top5 | top6 | top7 | bottom4 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
//                            {
//                                topteamscore++;
//                            }
//                        }
//                        break;
//                    case (4):
//                        if (((top4 >> col) & 1) == 1)
//                        {
//                            if ((((top5 | top6 | top7 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
//                            {
//                                topteamscore++;
//                            }
//                        }
//                        break;
//                    case (5):
//                        if (((top5 >> col) & 1) == 1)
//                        {
//                            if ((((top6 | top7 | bottom6 | bottom7) >> col) & 1) == 0)
//                            {
//                                topteamscore++;
//                            }
//                        }
//                        break;
//                    case (6):
//                        if (((top6 >> col) & 1) == 1)
//                        {
//                            if ((((top7 | bottom7) >> col) & 1) == 0)
//                            {
//                                topteamscore++;
//                            }
//                        }
//                        break;
//                    case (7):
//                        if (((top7 >> col) & 1) == 1)
//                        {
//                            topteamscore++;
//                        }
//                        break;
//                    default:
//                        break;
//                }
//            }
//        }
//        #endregion

//        #region perform bottom team attacks
//        for (int row = bytelength - 1; row >= 0; row--)
//        {
//            for (int col = 0; col < bytelength; col++)
//            {
//                switch (row)
//                {
//                    case (7):
//                        if (((bottom7 >> col) & 1) == 1)
//                        {
//                            if ((((top6 | top5 | top4 | top3 | top2 | top1 | top0 | bottom6 | bottom5 | bottom4 | bottom3 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
//                            {
//                                bottomteamscore++;
//                            }
//                        }
//                        break;
//                    case (6):
//                        if (((bottom6 >> col) & 1) == 1)
//                        {
//                            if ((((top5 | top4 | top3 | top2 | top1 | top0 | bottom5 | bottom4 | bottom3 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
//                            {
//                                bottomteamscore++;
//                            }
//                        }
//                        break;
//                    case (5):
//                        if (((bottom5 >> col) & 1) == 1)
//                        {
//                            if ((((top4 | top3 | top2 | top1 | top0 | bottom4 | bottom3 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
//                            {
//                                bottomteamscore++;
//                            }
//                        }
//                        break;
//                    case (4):
//                        if (((bottom4 >> col) & 1) == 1)
//                        {
//                            if ((((top3 | top2 | top1 | top0 | bottom3 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
//                            {
//                                bottomteamscore++;
//                            }
//                        }
//                        break;
//                    case (3):
//                        if (((bottom3 >> col) & 1) == 1)
//                        {
//                            if ((((top2 | top1 | top0 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
//                            {
//                                bottomteamscore++;
//                            }
//                        }
//                        break;
//                    case (2):
//                        if (((bottom2 >> col) & 1) == 1)
//                        {
//                            if ((((top1 | top0 | bottom1 | bottom0) >> col) & 1) == 0)
//                            {
//                                bottomteamscore++;
//                            }
//                        }
//                        break;
//                    case (1):
//                        if (((bottom1 >> col) & 1) == 1)
//                        {
//                            if ((((top0 | bottom0) >> col) & 1) == 0)
//                            {
//                                bottomteamscore++;
//                            }
//                        }
//                        break;
//                    case (0):
//                        if (((bottom0 >> col) & 1) == 1)
//                        {
//                            bottomteamscore++;
//                        }
//                        break;
//                    default:
//                        break;
//                }
//            }
//        }
//        #endregion

//        #region print final score
//        console.writeline("{0}:{1}", topteamscore, bottomteamscore);
//        #endregion
//    }
//}
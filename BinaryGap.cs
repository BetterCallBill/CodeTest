using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeTest
{
    // BinaryGap
    public class BinaryGap
    {
        static void BinaryGapMain()
        {
            int[] x =  {
                1041,
                32,
                66561,
                6291457,
                74901729,
                805306373,
                1376796946,
                1073741825,
                1610612737
            };

            for (int i = 0; i < x.Length; i++)
            {
                int result = solution1(x[i]);

                Console.WriteLine(x[i] + " result: " + result);
            }
        }

        public static int solution1(int N)
        {
            // 1. convert integer to binary 
            string binary = Convert.ToString(N, 2);

            var zeroList = new List<string>();

            int startIndex = binary.IndexOf('1', 0);

            while (startIndex != -1)
            {
                int substringStart = startIndex + 1;

                // find next 1 after substringStart
                int substringEnd = binary.IndexOf('1', substringStart);

                if (substringEnd < 0)
                {
                    break;
                }

                zeroList.Add(binary.Substring(substringStart, substringEnd - substringStart));

                startIndex = binary.IndexOf('1', substringEnd);
            }

            if (zeroList.Count > 0)
            {
                return zeroList.Max(x => x.Length);
            }
            else
            {
                return 0;
            }
        }

        // from Github
        public static int solution2(int N)
        {
            string binaryRepresentation = Convert.ToString(N, 2);

            // search max binary gap
            int longestBinaryGap = 0;
            int binaryGapLenght = 0;

            // possibilities:
            // 1 0 initial 1
            // 0 0 length + 1
            // 0 1 end, compare
            // 1 1 do nothing
            for (int i = 1; i < binaryRepresentation.Length; i++)
            {
                if (binaryRepresentation[i - 1] == '1' && binaryRepresentation[i] == '0')
                {
                    binaryGapLenght = 1;
                }
                else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '0')
                {
                    binaryGapLenght++;
                }
                else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '1')
                {
                    longestBinaryGap = Math.Max(longestBinaryGap, binaryGapLenght);
                }
            }

            return longestBinaryGap;
        }
    }
}

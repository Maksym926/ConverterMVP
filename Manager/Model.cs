namespace Manager
{
    public class Model
    {
        public string OctalToBinary(string number)
        {
            int[] halfBite = new int[3] { 4, 2, 1 };
            string newNum = "";
            for (int i = 0; i < number.Length; i++)
            {
                numberIntConvert(number[i].ToString(), halfBite, ref newNum);
            }
            return newNum;
        }

        public string HexadecimalToBinary(string number)
        {
            int[] halfBite = new int[4] { 8, 4, 2, 1 };
            string newNum = "";
            var numbers = new Dictionary<double, string>() {
                { 10 , "A" },
                { 11,  "B" },
                { 12, "C" },
                { 13, "D" },
                { 14, "E" },
                { 15, "F" }
            };


            for (int i = 0; i < number.Length; i++)
            {

                bool IsPass = false;
                /*double auxiliary = 0;*/
                foreach (var num in numbers)
                {
                    if (num.Value == number[i].ToString())
                    {
                        auxiliaryConvert(num.Key, ref newNum, halfBite);
                        IsPass = true;
                        break;

                    }

                }
                if (IsPass) continue;
                numberIntConvert(number[i].ToString(), halfBite, ref newNum);
            }
            return newNum;
        }

        public void numberIntConvert(string number, int[] halfBite, ref string newNum)
        {
            int numberInt = Int32.Parse(number);
            for (int y = 0; y < halfBite.Length; y++)
            {
                if (numberInt >= halfBite[y])
                {
                    newNum += 1;
                    numberInt = numberInt - halfBite[y];
                }
                else newNum += 0;
            }
        }
        public void auxiliaryConvert(double key, ref string newNum, int[] halfBite)
        {
            for (int y = 0; y < halfBite.Length; y++)
            {
                if (key != 0)
                {
                    if (key >= halfBite[y])
                    {
                        newNum += 1;
                        key = key - halfBite[y];
                    }

                    else newNum += 0;


                }
            }
        }
        public string BinaryToHexaOctal(string number, string TextBox)
        {
            int n = 0;
            if (TextBox == "Hexadecimal") n = 3;
            else n = 2;
            var numbers = new Dictionary<double, string>() {
                { 10 , "A" },
                { 11,  "B" },
                { 12, "C" },
                { 13, "D" },
                { 14, "E" },
                { 15, "F" }
            };
            string newnum = "";
            int y = 0;
            double sum = 0;


            for (int i = number.Length - 1; i >= 0; i--)
            {

                if (number[i].ToString() == "1")
                {
                    sum += Math.Pow(2, y);
                }
                if (y == n)
                {
                    if (sum >= 10)
                    {
                        newnum += numbers[sum];
                    }
                    else
                    {
                        newnum += sum;
                    }


                    sum = 0;
                    y = -1;
                }
                if (i == 0 && sum != 0)
                {
                    newnum += sum;
                }
                y++;
            }

            return reversStr(newnum);
        }

        public string DecimalToBinary(string number, string Textbox)
        {




            string newnum = "";
            int num = Convert.ToInt32(number);
            while (num != 0)
            {

                newnum += num % 2;
                num = num / 2;
            }



            return reversStr(newnum);
        }

        public string reversStr(string newnum)
        {
            string reversedNum = "";
            for (int i = newnum.Length - 1; i >= 0; i--)
            {
                reversedNum += newnum[i];
            }
            return reversedNum;
        }

        public string BinaryToDecimal(string number)
        {

            double newnum = 0;
            double y = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {

                if (number[i].ToString() == "1")
                {
                    newnum += Math.Pow(2, y);
                }
                y++;
            }

            return newnum.ToString();
        }
    }
}

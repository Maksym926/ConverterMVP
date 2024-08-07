﻿using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Manager
{
    public class Model
    {
        private string _number = "0";
        public string TextBox = "";
        public string BinaryToHexaOctal1 {
            get { return _number; }
            set { _number = value;
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


                for (int i = _number.Length - 1; i >= 0; i--)
                {

                    if (_number[i].ToString() == "1")
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

                 _number = reversStr(newnum);
            }
        }
        public string OctalToBinary1
        {
            get { return _number; }
            set { _number = value;
                int[] halfBite = new int[3] { 4, 2, 1 };
                string newNum = "";
                for (int i = 0; i < _number.Length; i++)
                {
                    numberIntConvert(_number[i].ToString(), halfBite, ref newNum);
                }
                _number = newNum;
            }
        }        
        public string HexadecimalToBinary1
        {
            get { return _number; }
            set { _number = value;
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


                for (int i = 0; i < _number.Length; i++)
                {

                    bool IsPass = false;
                    /*double auxiliary = 0;*/
                    foreach (var num in numbers)
                    {
                        if (num.Value == _number[i].ToString())
                        {
                            auxiliaryConvert(num.Key, ref newNum, halfBite);
                            IsPass = true;
                            break;

                        }

                    }
                    if (IsPass) continue;
                    numberIntConvert(_number[i].ToString(), halfBite, ref newNum);
                }
                _number = newNum;
            }
        }
        public string DecimalToBinary1
        {
            get { return _number; }
            set { _number = value;
                string newnum = "";
                int num = Convert.ToInt32(_number);
                while (num != 0)
                {

                    newnum += num % 2;
                    num = num / 2;
                }



                _number = reversStr(newnum);
            }
        }
        public string BinaryToDecimal1
        {
            get { return _number; }
            set { _number = value;

                double newnum = 0;
                double y = 0;
                for (int i = _number.Length - 1; i >= 0; i--)
                {

                    if (_number[i].ToString() == "1")
                    {
                        newnum += Math.Pow(2, y);
                    }
                    y++;
                }

                _number = newnum.ToString();

            }
        }

        

        public string BinaryTo2sComplement_U
        {
            get { return _number; }
            set { _number = value;
                bool IsMinus = false;
                if (_number[0].ToString() == "1") { 
                    IsMinus = true;
                }
                string newNum = "";
                bool IsFound = false;
                for (int i = _number.Length - 1; i > 0; i--) {
                    if (IsFound)
                    {
                        if (_number[i].ToString() == "1")
                        {
                            newNum = "0" + newNum;
                        }
                        else newNum = "1" + newNum;
                    }
                    if (_number[i].ToString() == "0" && IsFound == false) {
                        newNum = _number[i].ToString() + newNum;
                    }
                    if (_number[i].ToString() == "1" && IsFound == false)
                    {
                        newNum = _number[i].ToString() + newNum;
                        IsFound = true;
                    }
                    
                }
                while (newNum.Length < 8) {
                    if (IsMinus)
                    {
                        newNum = "1" + newNum;
                    }
                    else {
                        newNum = "0" + newNum;
                    }
                }


                _number = reversStr(newNum);


            }
        }

        public string TwosComplementToBinary
        {
            get { return _number; }
            set
            {
                _number = value;
                
                
                string newNum = "";
                bool IsFound = false;
                for (int i = _number.Length - 1; i >= 0; i--)
                {
                    if (IsFound)
                    {
                        if (_number[i].ToString() == "1")
                        {
                            newNum = "0" + newNum;
                        }
                        else newNum = "1" + newNum;
                    }
                    if (_number[i].ToString() == "0" && IsFound == false)
                    {
                        newNum = _number[i].ToString() + newNum;
                    }
                    if (_number[i].ToString() == "1" && IsFound == false)
                    {
                        newNum = _number[i].ToString() + newNum;
                        IsFound = true;
                    }

                }
                


                _number = newNum;


            }
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
        public string reversStr(string newnum)
        {
            string reversedNum = "";
            for (int i = newnum.Length - 1; i >= 0; i--)
            {
                reversedNum += newnum[i];
            }
            return reversedNum;
        }
    }
}

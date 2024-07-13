using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Manager
{
    public class Presenter
    {
        private Model model;
        private IView view;
        public Presenter(Model model , IView view) { 
            this.model = model;
            this.view = view;
            view.SetPresenter(this);
        }

        public void Calculate(string arg1, string arg2, string number) {
            if (arg1 == "Hexadecimal" && arg2 == "Decimal")
            {
                model.HexadecimalToBinary1 = number;
                string binary = model.HexadecimalToBinary1;
                model.BinaryToDecimal1 = binary;

                
                UpdateForm(model.BinaryToDecimal1);
                
            }
            if (arg1 == "Decimal" && arg2 == "Hexadecimal")
            {
                /*string res = model.DecimalToBinary(number, arg2);*/
                /*UpdateForm(model.BinaryToHexaOctal(res, arg2));*/

            }
            if (arg1 == "Octal" && arg2 == "Decimal")
            {
                /*string res = model.OctalToBinary(number);*/ 
                /*UpdateForm(model.BinaryToDecimal(res));*/
            }
            if (arg1 == "Decimal" && arg2 == "Octal")
            {
                /*string res = model.DecimalToBinary(number, arg2);*/
                /*UpdateForm(model.BinaryToHexaOctal(res, arg2));*/
            }
            if (arg1 == "Octal" && arg2 == "Hexadecimal")
            {
                /*string res = model.OctalToBinary(number);*/
                //Add Binary to Hexa
            }
            if (arg1 == "Hexadecimal" && arg2 == "Octal")
            {
                /*string res = model.HexadecimalToBinary(number);*/
                /*UpdateForm(model.BinaryToHexaOctal(res, arg2))*/;
            }
            if (arg1 == "Decimal" && arg2 == "Binary")
            {
                model.DecimalToBinary1 = number;
                UpdateForm(model.DecimalToBinary1);
            }
            if (arg1 == "Octal" && arg2 == "Binary")
            {

                /*return DecimalOctalToBinary(number, TextBox1);*/
                model.OctalToBinary1 = number;
                UpdateForm(model.OctalToBinary1);
            }
            if (arg1 == "Hexadecimal" && arg2 == "Binary")
            {

                /*return DecimalToBinaryOctalHexadecimal(number, TextBox1);*/
                model.HexadecimalToBinary1 = number;
                UpdateForm(model.HexadecimalToBinary1);
            }
            if (arg1 == "Binary" && arg2 == "Decimal")
            {
                model.BinaryToDecimal1 = number;
                UpdateForm(model.BinaryToDecimal1);
            }
            if (arg1 == "Binary" && arg2 == "Hexadecimal")
            {

                /*UpdateForm(model.BinaryToHexaOctal(number, arg2));*/
            }
            if (arg1== "Binary" && arg2 == "Octal")
            {
                model.TextBox = arg2;
                model.BinaryToHexaOctal1 = number;
                UpdateForm(model.BinaryToHexaOctal1);
            }

        }

        public void UpdateForm(string result) { 
            view.GetResult(result);
        }
    }
}

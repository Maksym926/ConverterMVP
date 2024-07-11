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
                string res = model.HexadecimalToBinary(number);
                UpdateForm(model.BinaryToDecimal(res));
                
            }
            if (arg1 == "Decimal" && arg2 == "Hexadecimal")
            {
                string res = model.DecimalToBinary(number, arg2);
                UpdateForm(model.BinaryToHexaOctal(res, arg2));

            }
            if (arg1 == "Octal" && arg2 == "Decimal")
            {
                string res = model.OctalToBinary(number); 
                UpdateForm(model.BinaryToDecimal(res));
            }
            if (arg1 == "Decimal" && arg2 == "Octal")
            {
                string res = model.DecimalToBinary(number, arg2);
                UpdateForm(model.BinaryToHexaOctal(res, arg2));
            }
            if (arg1 == "Octal" && arg2 == "Hexadecimal")
            {
                string res = model.OctalToBinary(number);
               
            }
            if (arg1 == "Hexadecimal" && arg2 == "Octal")
            {
                string res = model.HexadecimalToBinary(number);
                UpdateForm(model.BinaryToHexaOctal(res, arg2));
            }
            if (arg1 == "Decimal" && arg2 == "Binary")
            {

                UpdateForm(model.DecimalToBinary(number, arg2));
            }
            if (arg1 == "Octal" && arg2 == "Binary")
            {

                /*return DecimalOctalToBinary(number, TextBox1);*/
                UpdateForm(model.OctalToBinary(number));
            }
            if (arg1 == "Hexadecimal" && arg2 == "Binary")
            {

                /*return DecimalToBinaryOctalHexadecimal(number, TextBox1);*/
                UpdateForm(model.HexadecimalToBinary(number));
            }
            if (arg1 == "Binary" && arg2 == "Decimal")
            {

                UpdateForm(model.BinaryToDecimal(number));
            }
            if (arg1 == "Binary" && arg2 == "Hexadecimal")
            {

                UpdateForm(model.BinaryToHexaOctal(number, arg2));
            }
            if (arg1== "Binary" && arg2 == "Octal")
            {

                UpdateForm(model.BinaryToHexaOctal(number, arg2));
            }

        }

        public void UpdateForm(string result) { 
            view.GetResult(result);
        }
    }
}

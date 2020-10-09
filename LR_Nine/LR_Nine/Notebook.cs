using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Nine
{
    public class Notebook : ICalculate, IVisual
    {
        private string Models;
        private int Prices;
        private string Names;
        public Notebook(string pModel, string pName)
        {
            Models = pModel;
            Names = pName;
        }
        public void Price(int pPrice)
        {
            Prices = pPrice;
        }
        public void DrawObject()
        {
            Console.WriteLine("   -----------------\n" +
                              "   |               |\n" +
                              "   |               |\n" +
                              "   |               |\n" +
                              "   |               |\n" +
                              "   -----------------\n" +
                              "  /                /\n" +
                              " /                /\n" +
                              "/                /\n" +
                              "-----------------");
            Console.WriteLine(Name);
            Console.WriteLine(Model);
        }

        public string Name
        {
            get
            {
                return "Ноутбук " + Names;
            }
            set
            {
                Names = value;
            }
        }
        public string Model
        {
            get
            {
                if (Prices % 10 == 1)
                {
                    return "Модель " + Models + ": " + Prices.ToString() + " Рубль";
                }
                else if (Prices % 10 == 2 || Prices % 10 == 4 || Prices % 10 == 3)
                {
                    return "Модель " + Models + ": " + Prices.ToString() + " Рубля";
                }
                else return "Модель " + Models + ": " + Prices.ToString() + " Рублей";
            }
            set
            {
                Models = value;
            }
        }

    }
}
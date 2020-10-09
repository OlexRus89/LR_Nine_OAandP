using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Nine
{
    public class PersonalComputer: IVisual, ICalculate
    {
        public PersonalComputer(string pModel, string pName, string sMotherBoard, int iMotherBoard, string sMemory, int iMemory, string sVideoGame, int iVideoGame, string sProcessor, int iProcessor, string sRAM, int iRAM)
        {
            Models = pModel;
            Names = pName;
            StringMotherBoard = sMotherBoard;
            IntMotherBoard = iMotherBoard;
            StringMemory = sMemory;
            IntMemory = iMemory;
            StringVideoGame = sVideoGame;
            IntVideoGame = iVideoGame;
            StringProcessor = sProcessor;
            IntProcessor = iProcessor;
            StringRAM = sRAM;
            IntRAM = iRAM;

        }

        private string Models;
        private int Prices;
        private string Names;
        private string StringMotherBoard;
        private int IntMotherBoard;
        private string StringMemory;
        private int IntMemory;
        private string StringVideoGame;
        private int IntVideoGame;
        private string StringProcessor;
        private int IntProcessor;
        private string StringRAM;
        private int IntRAM;
        public void Price(int pPrice)
        {
            Prices = pPrice;
        }
        public void DrawObject()
        {
            Console.WriteLine("   -----------------\n" +
                              "   | ____      PC  |\n" +
                              "   | _______       |\n" +
                              "   | ____          |\n" +
                              "   | _________     |\n" +
                              "   -----------------\n");
            Console.WriteLine(Name);
            Console.WriteLine(Model);

        }
        public string Name
        {
            get
            {
                return "Персональный Компьютер " + Names;
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
                    return "Модель " + Models + ": " + Prices.ToString() + " Рубль \n" + "Материнская плата: " + StringMotherBoard + " " + IntMotherBoard.ToString() + "\nПамять: " + StringMemory + " " + IntMemory.ToString() + "\nВидеокарта: " + StringVideoGame + " " + IntVideoGame.ToString() + "\nПроцессор: " + StringProcessor + " " + IntProcessor.ToString() + "\nОперативная память: " + StringRAM + " " + IntRAM.ToString();
                }
                else if (Prices % 10 <= 2 && Prices % 10 >= 4)
                {
                    return "Модель " + Models + ": " + Prices.ToString() + " Рубля \n" + "Материнская плата:" + StringMotherBoard + " " + IntMotherBoard.ToString() + "\nПамять: " + StringMemory + " " + IntMemory.ToString() + "\nВидеокарта: " + StringVideoGame + " " + IntVideoGame.ToString() + "\nПроцессор: " + StringProcessor + " " + IntProcessor.ToString() + "\nОперативная память: " + StringRAM + " " + IntRAM.ToString();
                }
                else return "Модель " + Models + ": " + Prices.ToString() + " Рублей \n" + "Материнская плата: " + StringMotherBoard + " " + IntMotherBoard.ToString() + "\nПамять: " + StringMemory + " " + IntMemory.ToString() + "\nВидеокарта: " + StringVideoGame + " " + IntVideoGame.ToString() + "\nПроцессор: " + StringProcessor + " " + IntProcessor.ToString() + "\nОперативная память: " + StringRAM + " " + IntRAM.ToString();
            }
            set
            {
                Models = value;
            }
        }
    }
}
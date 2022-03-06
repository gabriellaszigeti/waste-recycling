using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace Codecool.WasteRecycling

{
    public class Dustbin
    {



        public const string Red = "\u001b[31m";
        public const string Blue = "\u001b[34m";
        public const string Green = "\u001b[32m";
        public const string EndTag = "\u001b[0m";

        private string Color { get; set; }

        PaperGarbage[] PaperWasteContent;
        PlasticGarbage[] PlasticWasteContent;
        Garbage[] HouseWasteContent;


        public Dustbin(string color)
        {
            PaperWasteContent = new PaperGarbage[0];
            PlasticWasteContent = new PlasticGarbage[0];
            HouseWasteContent = new Garbage[0];
            Color = color;
        }


        public int GetHouseWasteCount()
        {
            return HouseWasteContent.Length;
        }

        public int GetPaperCount()
        {
            return PaperWasteContent.Length;
        }

        public int GetPlasticCount()
        {
            return PlasticWasteContent.Length;
        }

        public void EmptyContents()
        {
            PlasticWasteContent = new PlasticGarbage[0];
            PaperWasteContent = new PaperGarbage[0];
            HouseWasteContent = new Garbage[0];
        }



        public void ThrowOutGarbage(Garbage garbage)
        {
            // to-do refactor
            if (garbage.GetType() == typeof(PlasticGarbage))
            {
                if (((PlasticGarbage)garbage).Cleaned == true)
                {
                    int arraySize = PlasticWasteContent.Length;
                    int newSize = arraySize + 1;
                    PlasticGarbage[] temp = new PlasticGarbage[newSize];
                    for (int i = 0; i < arraySize; i++)
                    {
                        temp[i] = PlasticWasteContent[i];
                    }
                    temp[newSize - 1] = (PlasticGarbage)garbage;
                    PlasticWasteContent = temp;
                }
                else
                {
                    throw new DustbinContentException("The plastic is not clean!");

                }
            }

            else if (garbage.GetType() == typeof(PaperGarbage))
            {

                if (((PaperGarbage)garbage).Squeezed == true)
                {
                    int arraySize = PaperWasteContent.Length;
                    int newSize = arraySize + 1;
                    PaperGarbage[] temp = new PaperGarbage[newSize];
                    for (int i = 0; i < arraySize; i++)
                    {
                        temp[i] = PaperWasteContent[i];
                    }
                    temp[newSize - 1] = (PaperGarbage)garbage;
                    PaperWasteContent = temp;
                }
                else
                {
                    throw new DustbinContentException("The paper is not squeezed!");

                }


            }
            else
            {
                int arraySize = HouseWasteContent.Length;
                int newSize = arraySize + 1;
                Garbage[] temp = new Garbage[newSize];
                for (int i = 0; i < arraySize; i++)
                {
                    temp[i] = HouseWasteContent[i];
                }
                temp[newSize - 1] = garbage;
                HouseWasteContent = temp;
            }
        }




        public void DisplayContents()
        {
            Console.WriteLine(this);
        }



        public override string ToString()
        {

            var builder = new StringBuilder();
            builder.Append(Color + " Dustbin!" + "\n");
            builder.Append(Green + "House waste content : " + GetHouseWasteCount() + (GetHouseWasteCount() <= 1 ? " item" : " items") + "\n" + EndTag);

            for (int i = 0; i < GetHouseWasteCount(); i++)
            {
                builder.Append("nr." + (i + 1) + " " + HouseWasteContent[i].Name + "\n");
            }
            builder.Append(Blue + "Paper content : " + GetPaperCount() + (GetPaperCount() <= 1 ? " item" : " items") + "\n" + EndTag);

            for (int i = 0; i < GetPaperCount(); i++)
            {
                builder.Append("nr." + (i + 1) + " " + PaperWasteContent[i].Name + "\n");
            }
            builder.Append(Red + "Plastic content : " + GetPlasticCount() + (GetPlasticCount() <= 1 ? " item" : " items") + "\n" + EndTag);

            for (int i = 0; i < GetPlasticCount(); i++)
            {
                builder.Append("nr." + (i + 1) + " " + PlasticWasteContent[i].Name + "\n");
            }
            return builder.ToString();
        }


    }
}

using System;
using System.Text;
namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {   

            Dustbin bin = new Dustbin("Blue");
            Garbage bottle = new PlasticGarbage("plastic bottle", true);
            PaperGarbage pizzaBox = new PaperGarbage("empty pizza box", false);
            bin.ThrowOutGarbage(pizzaBox);
            bin.DisplayContents();

            if (!pizzaBox.Squeezed)
            {
                pizzaBox.Squeeze();
            }

            Garbage bananaPeel = new Garbage("banana");
            Garbage folpack = new PlasticGarbage("folpack", true);
            Garbage uveg = new PlasticGarbage("uveg", true);
            bin.ThrowOutGarbage(bottle);
            bin.ThrowOutGarbage(pizzaBox);
            bin.ThrowOutGarbage(bananaPeel);
            bin.ThrowOutGarbage(folpack);
            bin.ThrowOutGarbage(uveg);
            bin.DisplayContents();
            bin.EmptyContents();
            bin.DisplayContents();
        }
    }
}

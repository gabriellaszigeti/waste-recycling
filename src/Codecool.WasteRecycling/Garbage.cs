namespace Codecool.WasteRecycling
{
    public class Garbage
    {

        public string Name { get; }

        public Garbage(string name)
        {
            Name = name;
        }



        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}}}";
        }

  
    }
    }

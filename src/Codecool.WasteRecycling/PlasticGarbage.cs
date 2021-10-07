namespace Codecool.WasteRecycling
{
    public class PlasticGarbage : Garbage
    {

        public bool Cleaned { get; private set; }

        public PlasticGarbage(string name, bool cleaned) : base(name)
        {
            Cleaned = cleaned;
        }


        public  void Clean()
        {
            this.Cleaned = true;
        }

        public override string ToString()
        {
            return $"{{{nameof(Cleaned)}={Cleaned.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}

namespace Codecool.WasteRecycling
{
    public class PaperGarbage : Garbage
    {

        public bool Squeezed { get; private set; }

        public PaperGarbage(string name,bool squeezed) : base(name)
        {
            Squeezed = squeezed;
        }

        public void Squeeze()
        {
            this.Squeezed = true;
        }

        public override string ToString()
        {
            return $"{{{nameof(Squeezed)}={Squeezed.ToString()}, {nameof(Name)}={Name}}}";
        }
    }

}

using Builder._2.Builder;

namespace Builder._3.Concrete_Builder_Class
{
    /// <summary>
    /// ConcreteBuilder1 class
    /// </summary>
    public class MiniBuilder : CarBuilder
    {
        public MiniBuilder()
            : base("Mini")
        {

        }
        public override void BuildEngine()
        {
            Car.AddPart(" 'not a V8' ");
        }

        public override void BuildFrame()
        {
            Car.AddPart(" '3-door with stripes' ");

        }
    }
}

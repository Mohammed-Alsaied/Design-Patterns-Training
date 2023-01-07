using Builder._2.Builder;
using BuilderPattern;

namespace Builder._3.Concrete_Builder_Class
{
    /// <summary>
    /// ConcreteBuilder2 class
    /// </summary>
    public class BMWBuilder : CarBuilder
    {
        public BMWBuilder()
            : base("BMW")
        {

        }
        public override void BuildEngine()
        {
            Car.AddPart(" 'a vancy V8 engine' ");
        }

        public override void BuildFrame()
        {
            Car.AddPart(" '5-door with Metallic finish' ");

        }
    }
}

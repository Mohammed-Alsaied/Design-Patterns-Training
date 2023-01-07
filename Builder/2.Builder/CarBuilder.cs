using BuilderPattern;

namespace Builder._2.Builder
{
    /// <summary>
    /// Builder abstract class
    /// </summary>
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }

        public CarBuilder(string carType)
        {
            Car = new Car(carType);
        }

        public abstract void BuildEngine();
        public abstract void BuildFrame();

    }
}

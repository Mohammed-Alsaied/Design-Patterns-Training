using Newtonsoft.Json;

namespace Prototype._2.Concrete_Prototype
{
    public class Employee : Person
    {
        public Manager manager { get; set; }
        public override string Name { get; set; }

        public Employee(string name, Manager manager)
        {
            Name = name;
            this.manager = manager;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Employee>(objectAsJson);
            }
            return (Person)MemberwiseClone();//Shallow Copy
        }
    }
}

﻿using Newtonsoft.Json;

namespace Prototype._2.Concrete_Prototype
{
    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Manager>(objectAsJson);
            }
            return (Person)MemberwiseClone();//Shallow Copy
        }
    }
}

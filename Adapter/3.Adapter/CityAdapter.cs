using Adapter._1.Adaptee;
using Adapter._2.Target;

namespace Adapter._3.Adapter
{
    /// <summary>
    /// Adapter
    /// </summary>

    #region By Composition
    //public class CityAdapter : ICityAdapter
    //{
    //    public ExternalSystem ExternalSystem { get; private set; } = new();
    //    public City GetCity()
    //    {
    //        // call into the external system 
    //        var cityFromExternalSystem = ExternalSystem.GetCity();

    //        // adapt the CityFromExternalCity to a City 
    //        return new City(
    //            $"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}"
    //            , cityFromExternalSystem.Inhabitants);
    //    }
    //}
    #endregion By Composition

    #region By Multiple Inheritance using Interfaces
    public class CityAdapter : ExternalSystem, ICityAdapter
    {
        public City GetCity()
        {
            // call into the external system 
            var cityFromExternalSystem = base.GetCity();

            // adapt the CityFromExternalCity to a City 
            return new City(
                $"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}"
                , cityFromExternalSystem.Inhabitants);
        }
    }
    #endregion By Multiple Inheritance using Interfaces
}

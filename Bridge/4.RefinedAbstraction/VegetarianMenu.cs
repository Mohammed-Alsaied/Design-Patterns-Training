using Bridge._2.Implementor;

namespace Bridge._4.RefinedAbstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class VegetarianMenu : Menu
    {
        public VegetarianMenu(ICoupon coupon) : base(coupon)
        {
        }
        public override int CalculatePrice()
        {
            return 20 - _coupon.CouponValue;
        }
    }
}

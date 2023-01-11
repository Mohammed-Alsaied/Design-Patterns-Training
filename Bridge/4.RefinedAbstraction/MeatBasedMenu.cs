using Bridge._2.Implementor;

namespace Bridge._4.RefinedAbstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class MeatBasedMenu : Menu
    {
        public MeatBasedMenu(ICoupon coupon) : base(coupon)
        {
        }
        public override int CalculatePrice()
        {
            return 30 - _coupon.CouponValue;
        }
    }
}

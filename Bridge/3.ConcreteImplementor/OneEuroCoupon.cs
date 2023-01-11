using Bridge._2.Implementor;

namespace Bridge._3.ConcreteImplementor
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class OneEuroCoupon : ICoupon
    {
        public int CouponValue { get => 1; }
    }
}

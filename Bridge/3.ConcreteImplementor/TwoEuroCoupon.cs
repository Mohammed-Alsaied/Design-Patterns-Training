using Bridge._2.Implementor;

namespace Bridge._3.ConcreteImplementor
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class TwoEuroCoupon : ICoupon
    {
        public int CouponValue { get => 2; }
    }
}

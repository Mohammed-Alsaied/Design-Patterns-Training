using Bridge._2.Implementor;

namespace Bridge._3.ConcreteImplementor
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class NoCoupon : ICoupon
    {
        public int CouponValue { get => 0; }
    }
}

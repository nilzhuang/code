using System.ComponentModel;

namespace CommonLib.CEnum
{
    /// <summary>
    ///     税费类别
    /// </summary>
    public enum TaxType : long
    {
        [Description("营业税及附加税")] Businesstaxes = 17095,
        [Description("个人所得税")] Incometax = 17096,
        [Description("印花税")] Stampduty = 17097,
        [Description("契税")] Deedtax = 17473,
        [Description("交易费用")] DealCosts = 17474
    }
}
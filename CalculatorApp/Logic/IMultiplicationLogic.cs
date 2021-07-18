namespace CalculatorApp.Logic
{
    /// <summary>
    /// 掛け算ロジック　インターフェース
    /// </summary>
    /// <remarks>
    /// 掛け算ロジック　インターフェース
    /// </remarks>
    public interface IMultiplicationLogic
    {
        /// <summary>
        /// 掛け算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の積を求める。
        /// </remarks>
        /// <returns>数値の積</returns>
        string Multiply();
    }
}

namespace CalculatorApp.Logic
{
    /// <summary>
    /// 引き算ロジック　インターフェース
    /// </summary>
    /// <remarks>
    /// 引き算ロジック　インターフェース
    /// </remarks>
    public interface ISubtractionLogic
    {
        /// <summary>
        /// 引き算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の差を求める。
        /// </remarks>
        /// <returns>数値の差</returns>
        string Subtract();
    }
}

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
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        /// <returns>数値の差</returns>
        string Subtract(string validNumber1, string validNumber2);
    }
}

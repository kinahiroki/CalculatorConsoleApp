namespace CalculatorApp.Logic
{
    /// <summary>
    /// 割り算ロジック　インターフェース
    /// </summary>
    /// <remarks>
    /// 割り算ロジック　インターフェース
    /// </remarks>
    public interface IDivisionLogic
    {
        /// <summary>
        /// 割り算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の商を求める。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        /// <returns>数値の商</returns>
        string Divide(string validNumber1, string validNumber2);
    }
}

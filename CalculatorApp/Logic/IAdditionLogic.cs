namespace CalculatorApp.Logic
{
    /// <summary>
    /// 足し算ロジック　インターフェース
    /// </summary>
    /// <remarks>
    /// 足し算ロジック　インターフェース
    /// </remarks>
    public interface IAdditionLogic
    {
        /// <summary>
        /// 足し算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の和を求める。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        /// <returns>数値の和</returns>
        string Add(string validNumber1, string validNumber2);
    }
}

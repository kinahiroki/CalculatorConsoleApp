namespace CalculatorApp.Logic
{
    /// <summary>
    /// 演算ロジック　インターフェース
    /// </summary>
    /// <remarks>
    /// 演算ロジック　インターフェース
    /// </remarks>
    public interface ICalcuratorLogic
    {
        /// <summary>
        /// 計算の実施
        /// </summary>
        /// <remarks>
        /// 引数の数値と演算子から計算を行い、結果を返す。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        /// <param name="validOperator">有効な演算子</param>
        /// <returns>計算結果</returns>
        string Calculate(string validNumber1, string validNumber2, string validOperator);
    }
}

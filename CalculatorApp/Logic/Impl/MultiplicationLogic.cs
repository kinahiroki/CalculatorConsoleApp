namespace CalculatorApp.Logic
{
    /// <summary>
    /// 掛け算ロジック　実装クラス
    /// </summary>
    /// <remarks>
    /// 掛け算ロジック　実装クラス
    /// </remarks>
    public class MultiplicationLogic : IMultiplicationLogic
    {
        /// <summary>
        /// 掛け算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の積を求める。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        /// <returns>数値の積</returns>
        public string Multiply(string validNumber1, string validNumber2)
        {
            var multiplicand = decimal.Parse(validNumber1);
            var multiplier = decimal.Parse(validNumber2);

            return decimal.Multiply(multiplicand, multiplier).ToString();
        }
    }
}

namespace CalculatorApp.Logic
{
    /// <summary>
    /// 引き算ロジック　実装クラス
    /// </summary>
    /// <remarks>
    /// 引き算ロジック　実装クラス
    /// </remarks>
    public class SubtractionLogic : ISubtractionLogic
    {
        /// <summary>
        /// 引き算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の差を求める。
        /// </remarks>
        /// <returns>数値の差</returns>
        public string Subtract(string validNumber1, string validNumber2)
        {
            var minuend = decimal.Parse(validNumber1);
            var subtrahend = decimal.Parse(validNumber2);

            return decimal.Subtract(minuend, subtrahend).ToString();
        }
    }
}

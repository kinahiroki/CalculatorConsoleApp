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
        /// <summary>被減数</summary>
        /// <remarks>被減数</remarks>
        private decimal Minuend { get; set; }

        /// <summary>減数</summary>
        /// <remarks>減数</remarks>
        private decimal Subtrahend { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 計算で使う有効な数値をプロパティに設定する。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        public SubtractionLogic(string validNumber1, string validNumber2)
        {
            Minuend = decimal.Parse(validNumber1);
            Subtrahend = decimal.Parse(validNumber2);
        }

        /// <summary>
        /// 引き算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の差を求める。
        /// </remarks>
        /// <returns>数値の差</returns>
        public string Subtract()
        {
            return decimal.Subtract(Minuend, Subtrahend).ToString();
        }
    }
}

namespace CalculatorApp.Logic
{
    /// <summary>
    /// 割り算ロジック　実装クラス
    /// </summary>
    /// <remarks>
    /// 割り算ロジック　実装クラス
    /// </remarks>
    public class DivisionLogic : IDivisionLogic
    {
        /// <summary>被除数</summary>
        /// <remarks>被除数</remarks>
        private decimal Dividend { get; set; }

        /// <summary>除数</summary>
        /// <remarks>除数</remarks>
        private decimal Divisor { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 計算で使う有効な数値をプロパティに設定する。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        public DivisionLogic(string validNumber1, string validNumber2)
        {
            Dividend = decimal.Parse(validNumber1);
            Divisor = decimal.Parse(validNumber2);
        }

        /// <summary>
        /// 割り算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の商を求める。
        /// </remarks>
        /// <returns>数値の商</returns>
        public string Divide()
        {
            return decimal.Divide(Dividend, Divisor).ToString();
        }
    }
}

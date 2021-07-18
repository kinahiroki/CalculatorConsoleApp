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
        /// <summary>被乗数</summary>
        /// <remarks>被乗数</remarks>
        private decimal Multiplicand { get; set; }

        /// <summary>乗数</summary>
        /// <remarks>乗数</remarks>
        private decimal Multiplier { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 計算で使う有効な数値をプロパティに設定する。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        public MultiplicationLogic(string validNumber1, string validNumber2)
        {
            Multiplicand = decimal.Parse(validNumber1);
            Multiplier = decimal.Parse(validNumber2);
        }

        /// <summary>
        /// 掛け算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の積を求める。
        /// </remarks>
        /// <returns>数値の積</returns>
        public string Multiply()
        {
            return decimal.Multiply(Multiplicand, Multiplier).ToString();
        }
    }
}

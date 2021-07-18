namespace CalculatorApp.Logic
{
    /// <summary>
    /// 足し算ロジック　実装クラス
    /// </summary>
    /// <remarks>
    /// 足し算ロジック　実装クラス
    /// </remarks>
    public class AdditionLogic : IAdditionLogic
    {
        /// <summary>被加数</summary>
        /// <remarks>被加数</remarks>
        private decimal Augend { get; set; }

        /// <summary>加数</summary>
        /// <remarks>加数</remarks>
        private decimal Addend { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 計算で使う有効な数値をプロパティに設定する。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        public AdditionLogic(string validNumber1, string validNumber2)
        {
            Augend = decimal.Parse(validNumber1);
            Addend = decimal.Parse(validNumber2);
        }

        /// <summary>
        /// 足し算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の和を求める。
        /// </remarks>
        /// <returns>数値の和</returns>
        public string Add()
        {
            return decimal.Add(Augend, Addend).ToString();
        }
    }
}

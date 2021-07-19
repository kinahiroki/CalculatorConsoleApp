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
        /// <summary>
        /// 足し算の実施
        /// </summary>
        /// <remarks>
        /// 2つの数値の和を求める。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        /// <returns>数値の和</returns>
        public string Add(string validNumber1, string validNumber2)
        {
            var augend = decimal.Parse(validNumber1);
            var addend = decimal.Parse(validNumber2);

            return decimal.Add(augend, addend).ToString();
        }
    }
}

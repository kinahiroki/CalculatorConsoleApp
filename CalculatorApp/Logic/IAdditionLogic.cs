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
        /// <returns>数値の和</returns>
        string Add();
    }
}

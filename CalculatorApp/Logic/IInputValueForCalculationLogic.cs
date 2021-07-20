namespace CalculatorApp.Logic
{
    /// <summary>
    /// 入力値チェック(計算用)ロジック　インターフェース
    /// </summary>
    /// <remarks>
    /// 入力値チェック(計算用)ロジック　インターフェース
    /// </remarks>
    public interface IInputValueForCalculationLogic
    {
        /// <summary>
        /// 入力した値が計算する際に有効な数値かどうか検証
        /// </summary>
        /// <remarks>
        /// 入力した値が計算する際に有効な数値かどうか検証
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        /// <returns>有効な値の場合はtrue、無効な値の場合はfalse</returns>
        bool IsValidInputValueNumberForCalculation(string checkTargetValue);

        /// <summary>
        /// 入力した値が有効な演算子がどうか検証
        /// </summary>
        /// <remarks>
        /// 入力した値が有効な演算子がどうか検証
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        /// <returns>有効な値の場合はtrue、無効な値の場合はfalse</returns>
        bool IsValidInputValueOperator(string checkTargetValue);

        /// <summary>
        /// 入力した値が有効な式かどうか検証
        /// </summary>
        /// <remarks>
        /// 入力した値が有効な式かどうか検証
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        /// <param name="validOperator">有効な演算子</param>
        /// <returns>有効な値の場合はtrue、無効な値の場合はfalse</returns>
        bool IsValidFormula(string validNumber1, string validNumber2, string validOperator);
    }
}

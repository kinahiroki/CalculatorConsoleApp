using CalculatorApp.Common.Constants;

namespace CalculatorApp.Common.Validation
{
    /// <summary>
    /// 共通チェッククラス
    /// </summary>
    /// <remarks>
    /// 共通で使うチェックメソッドを定義する。
    /// </remarks>
    public class CheckUtility
    {
        /// <summary>
        /// 必須チェック
        /// </summary>
        /// <remarks>
        /// チェック対象の値がNullまたは空文字でないか検証する。
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        /// <returns>値がある場合はtrue、ない場合はfalse</returns>
        public static bool IsNecessarilyInput(string checkTargetValue)
        {
            if (string.IsNullOrEmpty(checkTargetValue))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 数値チェック
        /// </summary>
        /// <remarks>
        /// チェック対象の値が有効な数値かどうかを検証する。
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        /// <returns>有効な値の場合はtrue、無効な値の場合はfalse</returns>
        public static bool IsValidNumber(string checkTargetValue)
        {
            return decimal.TryParse(checkTargetValue, out _);
        }

        /// <summary>
        /// 桁数チェック
        /// </summary>
        /// <remarks>
        /// チェック対象の値が指定した桁数以下かどうかを検証する。
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        /// <param name="specifiedDigits">指定の桁数</param>
        /// <returns>桁数以下の場合はtrue、桁数より大きい場合はfalse</returns>
        public static bool IsValidSpecifeidDigitsOrLess(string checkTargetValue, int specifiedDigits)
        {
            return checkTargetValue.Length <= specifiedDigits;
        }
    }
}

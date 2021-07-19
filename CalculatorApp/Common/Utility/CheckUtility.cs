using CalculatorApp.Common.Constants;
using System.Linq;

namespace CalculatorApp.Common.Utility
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

        /// <summary>
        /// 演算子チェック
        /// </summary>
        /// <remarks>
        /// チェック対象の値が有効な演算子かどうかを検証する。
        /// 検証は定数.演算子リストに含まれているかどうかで行う。
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        /// <returns>桁数以下の場合はtrue、桁数より大きい場合はfalse</returns>
        public static bool IsValidOperator(string checkTargetValue)
        {
            return Operator.OPERATOR_LIST.Where(item => item == checkTargetValue).Any();
        }

        /// <summary>
        /// 処理継続チェック
        /// </summary>
        /// <remarks>
        /// チェック対象の値に処理終了の文字列かどうかを検証する。
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        /// <returns>処理終了の文字列以外の場合はtrue、処理終了の文字列の場合はfalse</returns>
        public static bool IsContinue(string checkTargetValue)
        {
            // 処理終了キーワード
            const string PROCESS_END_KEYWORD = "end";

            if (PROCESS_END_KEYWORD == checkTargetValue)
            {
                // 処理終了の文字列の場合
                return false;
            }

            return true;
        }
    }
}

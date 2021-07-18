using CalculatorApp.Common.Utility;
using System;

namespace CalculatorApp.Logic
{
    /// <summary>
    /// 入力値チェック(計算用)ロジック　実装クラス
    /// </summary>
    /// <remarks>
    /// 入力値チェック(計算用)ロジック　実装クラス
    /// </remarks>
    public class InputValueForCalculationLogic : IInputValueForCalculationLogic
    {
        /// <summary>
        /// 入力した値が計算する際に有効な数値かどうか検証
        /// </summary>
        /// <remarks>
        /// 入力した値が計算する際に有効な数値かどうか検証
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        /// <returns>有効な値の場合はtrue、無効な値の場合はfalse</returns>
        public bool IsValidInputValueNumberForCalculation(string checkTargetValue)
        {
            if (!CheckUtility.IsNecessarilyInput(checkTargetValue))
            {
                // 未入力の場合
                Console.WriteLine("数値は必須です。入力してください。");
                return false;
            }

            if (!CheckUtility.IsValidNumber(checkTargetValue))
            {
                // 数値以外の場合
                Console.WriteLine("数値のみ入力してください。");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 入力した値が有効な演算子がどうか検証
        /// </summary>
        /// <remarks>
        /// 入力した値が有効な演算子がどうか検証
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        /// <returns>有効な値の場合はtrue、無効な値の場合はfalse</returns>
        public bool IsValidInputValueOperator(string checkTargetValue)
        {
            if (!CheckUtility.IsNecessarilyInput(checkTargetValue))
            {
                // 未入力の場合
                Console.WriteLine("演算子は必須です。入力してください。");
                return false;
            }

            if (!CheckUtility.IsValidOperator(checkTargetValue))
            {
                // 未入力の場合
                Console.WriteLine("無効な演算子です。指定した値のみ入力してください。");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 入力した値が有効な式かどうか検証
        /// </summary>
        /// <remarks>
        /// 入力した値が有効な式かどうか検証
        /// </remarks>
        /// <param name="chackTargetValue">チェック対象の値</param>
        /// <returns>有効な値の場合はtrue、無効な値の場合はfalse</returns>
        public bool IsValidFormula(string chackTargetValue)
        {
            // TODO 必要かどうか検討
            return false;
        }
    }
}

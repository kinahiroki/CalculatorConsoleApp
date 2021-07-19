using CalculatorApp.Common.Constants;

namespace CalculatorApp.Logic
{
    /// <summary>
    /// 演算ロジック　実装クラス
    /// </summary>
    /// <remarks>
    /// 演算ロジック　実装クラス
    /// </remarks>
    public class CalcuratorLogic : ICalcuratorLogic
    {
        /// <summary>足し算ロジック</summary>
        /// <remarks>足し算ロジック</remarks>
        private readonly IAdditionLogic _additionLogic = null;

        /// <summary>引き算ロジック</summary>
        /// <remarks>引き算ロジック</remarks>
        private readonly ISubtractionLogic _subtractionLogic = null;

        /// <summary>掛け算ロジック</summary>
        /// <remarks>掛け算ロジック</remarks>
        private readonly IMultiplicationLogic _multiplicationLogic = null;

        /// <summary>割り算ロジック</summary>
        /// <remarks>割り算ロジック</remarks>
        private readonly IDivisionLogic _divisionLogic = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// 演算ロジックで使うオブジェクトをDIする。
        /// </remarks>
        /// <param name="additionLogic">足し算ロジック</param>
        /// <param name="subtractionLogic">引き算ロジック</param>
        /// <param name="multiplicationLogic">掛け算ロジック</param>
        /// <param name="divisionLogic">割り算ロジック</param>
        public CalcuratorLogic(
            IAdditionLogic additionLogic,
            ISubtractionLogic subtractionLogic,
            IMultiplicationLogic multiplicationLogic,
            IDivisionLogic divisionLogic)
        {
            _additionLogic = additionLogic;
            _subtractionLogic = subtractionLogic;
            _multiplicationLogic = multiplicationLogic;
            _divisionLogic = divisionLogic;
        }

        /// <summary>
        /// 計算の実施
        /// </summary>
        /// <remarks>
        /// 引数の数値と演算子から計算を行い、結果を返す。
        /// </remarks>
        /// <param name="validNumber1">有効な数値1</param>
        /// <param name="validNumber2">有効な数値2</param>
        /// <param name="validOperator">有効な演算子</param>
        /// <returns>計算結果</returns>
        public string Calculate(string validNumber1, string validNumber2, string validOperator)
        {
            var calculationResult = string.Empty;
            if (Operator.OPERATOR_ADDITION == validOperator)
            {
                // 足し算の実施
                calculationResult = _additionLogic.Add(validNumber1, validNumber2);
            }
            else if (Operator.OPERATOR_SUBTRACTION == validOperator)
            {
                // 引き算の実施
                calculationResult = _subtractionLogic.Subtract(validNumber1, validNumber2);
            }
            else if (Operator.OPERATOR_MULTIPLICATION == validOperator)
            {
                // 掛け算の実施
                calculationResult = _multiplicationLogic.Multiply(validNumber1, validNumber2);
            }
            else if (Operator.OPERATOR_DIVISION == validOperator)
            {
                // 割り算の実施
                calculationResult = _divisionLogic.Divide(validNumber1, validNumber2);
            }

            return calculationResult;
        }
    }
}

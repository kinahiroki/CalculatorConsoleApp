using CalculatorApp.Logic;
using System;

namespace CalculatorApp.UseCase
{
    /// <summary>
    /// 電卓ユースケース　実装クラス
    /// </summary>
    /// <remarks>
    /// 電卓ユースケース　実装クラス
    /// </remarks>
    public class CalculatorUseCase : ICalculatorUseCase
    {
        /// <summary>入力値チェックロジック</summary>
        /// <remarks>入力値チェックロジック</remarks>
        private readonly IInputValueForCalculationLogic _inputValueCheckForCalculationLogic = null;

        /// <summary>演算ロジック</summary>
        /// <remarks>演算ロジック</remarks>
        private readonly ICalcuratorLogic _calcuratorLogic = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// DIの実施
        /// </remarks>
        /// <param name="inputValueCheckForCalculationLogic">入力値チェックロジック</param>
        /// <param name="calcuratorLogic">演算ロジック</param>
        public CalculatorUseCase(
            IInputValueForCalculationLogic inputValueCheckForCalculationLogic,
            ICalcuratorLogic calcuratorLogic)
        {
            _inputValueCheckForCalculationLogic = inputValueCheckForCalculationLogic;
            _calcuratorLogic = calcuratorLogic;
        }

        /// <summary>
        /// 計算実行
        /// </summary>
        /// <remarks>
        /// 計算実行で使う業務ロジックの呼び出しと処理流れの制御を行う。
        /// </remarks>
        public void PerformCalculation()
        {
            Console.WriteLine("1つ目の数を入力してください。");
            string validInputNumber1 = RecieveValidNumberForCalculation();

            Console.WriteLine("2つ目の数を入力してください。");
            string validInputNumber2 = RecieveValidNumberForCalculation();

            Console.WriteLine("演算子(+, -, *, /)を入力してください。");
            string validInputOperator = RecieveValidOperator();

            // 入力値から計算式を生成
            if (!_inputValueCheckForCalculationLogic.IsValidFormula(validInputNumber1, validInputNumber2, validInputOperator))
            {
                // 不正な式の場合、アプリ終了
                return;
            }

            // 計算実施
            var calculationResult = _calcuratorLogic.Calculate(validInputNumber1, validInputNumber2, validInputOperator);

            // 計算結果の出力
            Console.WriteLine(calculationResult);
            _ = Console.Read();
        }

        /// <summary>
        /// 計算用の有効な数値受け取り
        /// </summary>
        /// <remarks>
        /// コンソールに入力された値を受け取り、その値が計算で有効な値かどうか検証する。
        /// 有効な数値の場合は値を呼びもとに返す。有効でない数値の場合、ユーザに再度入力依頼を行う。
        /// ただし、アプリ終了を支持する文字列が入力された場合は、ただちに処理を終了する。
        /// </remarks>
        /// <returns>有効な計算用の数値とアプリ終了フラグ</returns>
        private string RecieveValidNumberForCalculation()
        {
            string validInputValue;
            do
            {
                // 入力値の受け取り
                validInputValue = Console.ReadLine();

            } while (!_inputValueCheckForCalculationLogic.IsValidInputValueNumberForCalculation(validInputValue));

            return validInputValue;
        }

        /// <summary>
        /// 有効な演算子の受け取り
        /// </summary>
        /// <remarks>
        /// コンソールに入力された値を受け取り、その値が有効な演算子かどうか検証する。
        /// 有効な演算子の場合は値を呼びもとに返す。
        /// ただし、有効でない演算子の場合、ユーザに再度入力依頼を行う。
        /// </remarks>
        /// <returns>有効な演算子</returns>
        private string RecieveValidOperator()
        {
            string validInputValue;
            do
            {
                // 入力値の受け取り
                validInputValue = Console.ReadLine();

            } while (!_inputValueCheckForCalculationLogic.IsValidInputValueOperator(validInputValue));

            return validInputValue;
        }
    }
}

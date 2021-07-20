using CalculatorApp.Logic;
using System;
using System.Collections.Generic;
using System.Text;

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
            string validInputNumber1;
            do
            {
                validInputNumber1 = Console.ReadLine();

            } while (!_inputValueCheckForCalculationLogic.IsValidInputValueNumberForCalculation(validInputNumber1));

            Console.WriteLine("2つ目の数を入力してください。");
            string validInputNumber2;
            do
            {
                validInputNumber2 = Console.ReadLine();

            } while (!_inputValueCheckForCalculationLogic.IsValidInputValueNumberForCalculation(validInputNumber2));

            Console.WriteLine("演算子(+, -, *, /)を入力してください。");
            string validInputOperator;
            do
            {
                validInputOperator = Console.ReadLine();

            } while (!_inputValueCheckForCalculationLogic.IsValidInputValueOperator(validInputOperator));

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
            Console.Read();
        }
    }
}

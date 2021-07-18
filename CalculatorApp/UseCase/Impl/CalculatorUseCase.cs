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
        private readonly IInputValueForCalculationLogic _inputValueCheckForCalculationLogic;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// DIの実施
        /// </remarks>
        /// <param name="inputValueCheckForCalculationLogic">入力値チェックロジック</param>
        public CalculatorUseCase(IInputValueForCalculationLogic inputValueCheckForCalculationLogic)
        {
            _inputValueCheckForCalculationLogic = inputValueCheckForCalculationLogic;
        }

        /// <summary>
        /// 計算実行
        /// </summary>
        /// <remarks>
        /// 計算実行で使う業務ロジックの呼び出しと処理流れの制御を行う。
        /// </remarks>
        public void PerformCalculation()
        {
            // 数値の入力受付
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
        }
    }
}

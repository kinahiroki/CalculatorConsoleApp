using CalculatorApp.Common.Constants;
using CalculatorApp.Logic;
using CalculatorApp.UseCase;

namespace CalculatorApp
{
    /// <summary>
    /// 電卓アプリ起動クラス
    /// </summary>
    /// <remarks>
    /// 電卓アプリ起動クラス
    /// </remarks>
    public class Program
    {
        /// <summary>
        /// 電卓アプリ起動メソッド
        /// </summary>
        /// <remarks>
        /// 電卓アプリ起動メソッド
        /// </remarks>
        public static void Main()
        {
            // 計算実行処理の呼び出し
            var inputValueForCalculationLogic = new InputValueForCalculationLogic();

            var calculation = new CalculatorUseCase(inputValueForCalculationLogic);
            calculation.PerformCalculation();
        }
    }
}

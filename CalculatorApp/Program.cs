using CalculatorApp.Common.Constants;
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
            Operator.IsExistsOperators();

            // 計算実行処理の呼び出し
            var calculation = new CalculatorUseCase();
            calculation.PerformCalculation();
        }
    }
}

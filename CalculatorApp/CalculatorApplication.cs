using CalculatorApp.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp
{
    /// <summary>
    /// 電卓アプリ起動クラス
    /// </summary>
    /// <remarks>
    /// 電卓アプリ起動クラス
    /// </remarks>
    public class CalculatorApplication
    {
        /// <summary>電卓ユースケース</summary>
        /// <remarks>電卓ユースケース</remarks>
        private readonly ICalculatorUseCase _useCase;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// DIの実施
        /// </remarks>
        /// <param name="useCase">電卓ユースケース</param>
        public CalculatorApplication(ICalculatorUseCase useCase)
        {
            _useCase = useCase;
        }

        /// <summary>
        /// 電卓起動
        /// </summary>
        /// <remarks>
        /// 電卓起動
        /// </remarks>
        public void Run()
        {
            Console.WriteLine("電卓アプリ 起動");

            _useCase.PerformCalculation();

            Console.WriteLine("計算アプリ 終了");
        }
    }
}

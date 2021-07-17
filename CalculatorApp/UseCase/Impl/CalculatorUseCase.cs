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
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CalculatorUseCase()
        {
        }

        /// <summary>
        /// 計算実行
        /// </summary>
        /// <remarks>
        /// 計算実行で使う業務ロジックの呼び出しと処理流れの制御を行う。
        /// </remarks>
        public void PerformCalculation()
        {
            Console.WriteLine("計算アプリ 起動");

            // 入力値チェック

            Console.WriteLine("計算アプリ 終了");
        }
    }
}

using CalculatorApp.Logic;
using CalculatorApp.UseCase;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CalculatorApp
{
    /// <summary>
    /// 電卓アプリ設定クラス
    /// </summary>
    /// <remarks>
    /// 電卓アプリ設定クラス
    /// </remarks>
    public class Program
    {
        /// <summary>
        /// 電卓アプリ設定メソッド
        /// </summary>
        /// <remarks>
        /// 電卓アプリ起動に必要な設定処理を実施
        /// </remarks>
        public static void Main()
        {
            // DIの設定
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);

            // 電卓アプリ起動
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            var app = serviceProvider.GetService<CalculatorApplication>();
            app.Run();
        }

        /// <summary>
        /// サービスの構成
        /// </summary>
        /// <remarks>
        /// アプリで使うサービスを構成する。
        /// </remarks>
        /// <param name="services">services</param>
        private static void ConfigureServices(IServiceCollection services)
        {
            // DIコンテナにオブジェクトを登録
            // Application
            services.AddTransient<CalculatorApplication>();

            // UseCase
            services.AddTransient<ICalculatorUseCase, CalculatorUseCase>();

            // Logic
            services.AddTransient<IInputValueForCalculationLogic, InputValueForCalculationLogic>();
            services.AddTransient<IAdditionLogic, AdditionLogic>();
        }
    }
}

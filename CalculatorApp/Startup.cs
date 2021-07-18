using CalculatorApp.Logic;
using CalculatorApp.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorApp
{
    /// <summary>
    /// プログラム起動セットアップクラス
    /// </summary>
    /// <remarks>
    /// プログラム起動セットアップクラス
    /// </remarks>
    public class Startup
    {
        /// <summary>
        /// DIの設定
        /// </summary>
        /// <remarks>
        /// DIの設定
        /// </remarks>
        /// <param name="services">services</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICalculatorUseCase, CalculatorUseCase>();
            services.AddTransient<IInputValueForCalculationLogic, InputValueForCalculationLogic>();
        }
    }
}

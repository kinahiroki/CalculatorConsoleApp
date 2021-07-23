using CalculatorApp.Logic;
using NUnit.Framework;

namespace CalculatorAppTests.Logic
{
    /// <summary>
    /// 足し算ロジック　テストクラス
    /// </summary>
    /// <remarks>
    /// 足し算ロジック　テストクラス
    /// </remarks>
    [TestFixture]
    public class AdditionLogicTest
    {
        /// <summary>
        /// 足し算処理　テストケース
        /// </summary>
        /// <remarks>
        /// 以下のテストケース実施
        /// ①整数同士の足し算
        /// ②小数同士の足し算
        /// ③0同子の足し算
        /// </remarks>
        /// <param name="num1">数値1</param>
        /// <param name="num2">数値2</param>
        /// <param name="expetedResult">期待結果</param>
        [TestCase("100", "100", "200")]
        [TestCase("100.1", "100.1", "200.2")]
        [TestCase("0", "0", "0")]
        public void AddTest(string num1, string num2, string expetedResult)
        {
            // Act テスト対象呼び出し
            var testTarget = new AdditionLogic();
            var actualResult = testTarget.Add(num1, num2);

            // Assert 実施結果が期待結果通りになっているか？
            Assert.AreEqual(expetedResult, actualResult);
        }
    }
}

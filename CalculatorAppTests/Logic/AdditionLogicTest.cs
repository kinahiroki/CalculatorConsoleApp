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
        /// 以下のテストケースを実施すること。
        /// ①整数同士の足し算
        /// </remarks>
        [Test]
        public void AddTest()
        {
            // Arrange テスト前の準備
            var number1 = "1000";
            var number2 = "2000";

            // Act テスト対象の呼び出し
            var testTarget = new AdditionLogic();
            var actualResult = testTarget.Add(number1, number2);

            // Assert 実施結果が期待結果通りになっているか？
            Assert.AreEqual("3000", actualResult);
        }

        /// <summary>
        /// 足し算処理　テストケース
        /// </summary>
        /// <remarks>
        /// 以下のテストケース実施
        /// ①整数同士の足し算
        /// ②小数同士の足し算
        /// </remarks>
        /// <param name="num1">数値1</param>
        /// <param name="num2">数値2</param>
        /// <param name="expetedResult">期待結果</param>
        [TestCase("100", "100", "200")]
        [TestCase("100.1", "100.1", "200.2")]
        public void AddTest002(string num1, string num2, string expetedResult)
        {
            // Act テスト対象呼び出し
            var testTarget = new AdditionLogic();
            var actualResult = testTarget.Add(num1, num2);

            // Assert 実施結果が期待結果通りになっているか？
            Assert.AreEqual(expetedResult, actualResult);
        }
    }
}

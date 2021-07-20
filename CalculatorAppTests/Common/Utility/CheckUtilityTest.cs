using CalculatorApp.Common.Utility;
using NUnit.Framework;

namespace CalculatorAppTests.Common.Utility
{
    /// <summary>
    /// 共通チェック テストクラス
    /// </summary>
    /// <remarks>
    /// 共通チェック テストクラス
    /// </remarks>
    [TestFixture]
    public class CheckUtilityTest
    {
        /// <summary>
        /// 必須チェック正常時テスト
        /// </summary>
        /// <remarks>
        /// 必須チェックが正常時の場合のテストを検証する。
        /// </remarks>
        [Test]
        public void IsNecessarilyInputNormalTest()
        {
            var checkTargetValue = "TEST_VALUE";

            // 検証実施
            var actualResult = CheckUtility.IsNecessarilyInput(checkTargetValue);

            // 検証結果
            Assert.IsTrue(actualResult);
        }

        /// <summary>
        /// 必須チェック異常時テスト
        /// </summary>
        /// <remarks>
        /// 必須チェックが異常時の場合のテストを検証する。
        /// テストケースは以下のケースを検証する。
        /// ①値がNULLの場合
        /// ②値が空文字の場合
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        [TestCase(null)]
        [TestCase("")]
        public void IsNecessarilyInputAbnormalTest(string checkTargetValue)
        {
            // 検証実施
            var actualResult = CheckUtility.IsNecessarilyInput(checkTargetValue);

            // 検証結果
            Assert.IsFalse(actualResult);
        }

        /// <summary>
        /// 数値チェック正常時テスト
        /// </summary>
        /// <remarks>
        /// 数値チェックが正常時の場合のテストを検証する。
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        [TestCase("0")]
        [TestCase("0.123456789")]
        [TestCase("123456789")]
        public void IsValidNumberNormalTest(string checkTargetValue)
        {
            // 検証実施
            var actualResult = CheckUtility.IsValidNumber(checkTargetValue);

            // 検証結果
            Assert.IsTrue(actualResult);
        }

        /// <summary>
        /// 数値チェック異常時テスト
        /// </summary>
        /// <remarks>
        /// 数値チェックが異常時の場合のテストを検証する。
        /// テストケースは以下のケースを実施する。
        /// ①値がNULLの場合
        /// ②値が空文字の場合
        /// ③値が文字の場合
        /// ④値が空白の場合
        /// </remarks>
        /// <param name="checkTargetValue">チェック対象の値</param>
        [TestCase(null)]
        [TestCase("")]
        [TestCase("abc")]
        [TestCase(" ")]
        public void IsValidNumberAbnormalTest(string checkTargetValue)
        {
            // 検証実施
            var actualResult = CheckUtility.IsValidNumber(checkTargetValue);

            // 検証結果
            Assert.IsFalse(actualResult);
        }
    }
}

namespace CalculatorApp.Common.Constants
{
    /// <summary>
    /// 演算子クラス
    /// </summary>
    /// <remarks>
    /// 演算子クラス
    /// </remarks>
    public class Operator
    {
        /// <summary>定数_演算子_足し算</summary>
        /// <remarks>定数_演算子_足し算</remarks>
        public static readonly string OPERATOR_ADDTION = "+";

        /// <summary>定数_演算子_引き算</summary>
        /// <remarks>定数_演算子_引き算</remarks>
        public static readonly string OPERATOR_SUBTRACTION = "-";

        /// <summary>定数_演算子_掛け算</summary>
        /// <remarks>定数_演算子_掛け算</remarks>
        public static readonly string OPERATOR_MULTIPLICATION = "*";

        /// <summary>定数_演算子_割り算</summary>
        /// <remarks>定数_演算子_割り算</remarks>
        public static readonly string OPERATOR_DIVISION = "/";

        /// <summary>
        /// 演算子の列挙子
        /// </summary>
        /// <remarks>
        /// 演算子の列挙子
        /// </remarks>
        public enum OperatorEnum
        {
            /// <summary>列挙子_演算子_足し算</summary>
            /// <remarks>列挙子_演算子_足し算</remarks>
            ADDTION = 1,

            /// <summary>列挙子_演算子_引き算</summary>
            /// <remarks>列挙子_演算子_引き算</remarks>
            SUBTRACTION = 2,

            /// <summary>列挙子_演算子_掛け算</summary>
            /// <remarks>列挙子_演算子_掛け算</remarks>
            MULTIPLICATION = 3,

            /// <summary>列挙子_演算子_割り算</summary>
            /// <remarks>列挙子_演算子_割り算</remarks>
            DIVISION = 4
        }
    }
}

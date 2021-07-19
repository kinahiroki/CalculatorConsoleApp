using System.Collections.Generic;

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
        public static readonly string OPERATOR_ADDITION = "+";

        /// <summary>定数_演算子_引き算</summary>
        /// <remarks>定数_演算子_引き算</remarks>
        public static readonly string OPERATOR_SUBTRACTION = "-";

        /// <summary>定数_演算子_掛け算</summary>
        /// <remarks>定数_演算子_掛け算</remarks>
        public static readonly string OPERATOR_MULTIPLICATION = "*";

        /// <summary>定数_演算子_割り算</summary>
        /// <remarks>定数_演算子_割り算</remarks>
        public static readonly string OPERATOR_DIVISION = "/";

        /// <summary>定数_演算子_剰余算</summary>
        /// <remarks>定数_演算子_剰余算</remarks>
        public static readonly string OPERATOR_REMAINDER = "%";

        /// <summary>定数_演算子リスト</summary>
        /// <remarks>定数_演算子リスト</remarks>
        public static readonly IEnumerable<string> OPERATOR_LIST = new List<string>()
        {
            OPERATOR_ADDITION,
            OPERATOR_SUBTRACTION,
            OPERATOR_MULTIPLICATION,
            OPERATOR_DIVISION,
            OPERATOR_REMAINDER,
        };
    }
}

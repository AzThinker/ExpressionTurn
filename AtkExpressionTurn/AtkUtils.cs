using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atk.AtkExpression
{
    /// <summary>
    /// 表达式工具
    /// </summary>
    public static class AtkUtils
    {
        /// <summary>
        /// 增加 In 条件语句（注意加入的条件不益太多，否则会超过SQL语句的限制
        /// </summary>
        /// <param name="inConditon">条件组</param>
        /// <returns>In 条件语句</returns>
        public static string MutiInWhere(int[] inConditon)
        {

            string bizincdt = string.Empty;
            foreach (var item in inConditon)
            {
                if (string.IsNullOrWhiteSpace(bizincdt))
                {
                    bizincdt = item.ToString();
                }
                else
                {
                    bizincdt = bizincdt + "," + item.ToString();
                }
            }

            return bizincdt;
        }

        /// <summary>
        /// 增加 In 条件语句（注意加入的条件不益太多，否则会超过SQL语句的限制
        /// </summary>
        /// <param name="inConditon">条件组</param>
        /// <returns>In 条件语句</returns>
        public static string MutiInWhere(IList<int> inConditon)
        {
            string bizincdt = string.Empty;
            foreach (var item in inConditon)
            {
                if (string.IsNullOrWhiteSpace(bizincdt))
                {
                    bizincdt = item.ToString();
                }
                else
                {
                    bizincdt = bizincdt + "," + item.ToString();
                }
            }
            return bizincdt;
        }
    }
}

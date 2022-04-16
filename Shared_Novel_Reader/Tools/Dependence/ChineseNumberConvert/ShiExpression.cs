using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.Tools.Dependence.ChineseNumberConvert
{
    /// <summary>
    /// 十
    /// </summary>
    public class ShiExpression : ChineseNumberConvertExpression
    {
        public override string GetPostfix()
        {
            return ChineseNumberChar.Ten;
        }

        public override long Multiplier()
        {
            return 10;
        }
    }
}

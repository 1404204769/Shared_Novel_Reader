using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.Tools.Dependence.ChineseNumberConvert
{
    /// <summary>
    /// 千
    /// </summary>
    public class QianExpression : ChineseNumberConvertExpression
    {
        public override string GetPostfix()
        {
            return ChineseNumberChar.Thousand;
        }

        public override long Multiplier()
        {
            return 1000;
        }
    }
}

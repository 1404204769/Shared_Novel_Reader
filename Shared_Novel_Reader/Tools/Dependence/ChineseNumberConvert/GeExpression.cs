using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.Tools.Dependence.ChineseNumberConvert
{
    /// <summary>
    /// 个
    /// </summary>
    public class GeExpression : ChineseNumberConvertExpression
    {
        public override string GetPostfix()
        {
            return "";
        }

        public override long Multiplier()
        {
            return 1;
        }

        public override int GetLength()
        {
            return 1;
        }
    }
}

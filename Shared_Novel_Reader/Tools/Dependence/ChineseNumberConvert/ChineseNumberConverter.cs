using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.Tools.Dependence.ChineseNumberConvert
{
    /// <summary>
    /// 中文数字转阿拉伯数字
    /// </summary>
    public class ChineseNumberConverter
    {
        public long Convert(string str)
        {
            str = PrePrecess(str);

            ChineseNumberConvertContext context = new ChineseNumberConvertContext(str);

            ArrayList tree = new ArrayList();
            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());
            tree.Add(new WanExpression());
            tree.Add(new YiExpression());

            foreach (ChineseNumberConvertExpression exp in tree)
            {
                exp.Interpret(context);
            }

            return context.Data;
        }

        /// <summary>
        /// 预处理
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string PrePrecess(string str)
        {
            str = str.Trim();// 去除开头结尾的空格
            // System.StringComparison.Ordinal 进行byte级别的比较
            if (str.StartsWith(ChineseNumberChar.Ten, System.StringComparison.Ordinal) ||
                str.StartsWith(ChineseNumberChar.Hundred, System.StringComparison.Ordinal) ||
                str.StartsWith(ChineseNumberChar.Thousand, System.StringComparison.Ordinal) ||
                str.StartsWith(ChineseNumberChar.Wan, System.StringComparison.Ordinal) ||
                str.StartsWith(ChineseNumberChar.Yi, System.StringComparison.Ordinal))
            {
                // 在单位前面补充 “一”
                str = ChineseNumberChar.One + str;
            }
            return str;
        }

    }
}

using Microsoft.VisualBasic.CompilerServices;   // LikeOperator

namespace LikeOperatorSample.Forms.Model
{

    /// <summary>
    /// LikeOperatorサンプル.Model
    /// </summary>
    public class Sample
    {

        public bool Contains(string source, string pattern)
        {

            // 大文字／小文字、全角／半角、ひらがな／カタカナ を区別する場合はCompareMethod.Binaryを使用
            return LikeOperator.LikeString(source, pattern, Microsoft.VisualBasic.CompareMethod.Text);

        }

    }

}

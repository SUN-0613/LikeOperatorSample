using AYam.Common.MVVM;

namespace LikeOperatorSample.Forms.ViewModel
{

    /// <summary>
    /// LikeOperatorサンプル.ViewModel
    /// </summary>
    public class Sample : ViewModelBase
    {

        #region Model

        /// <summary>
        /// LikeOperatorサンプル.Model
        /// </summary>
        private Model.Sample _Model = new Model.Sample();

        #endregion

        #region Property

        /// <summary>
        /// 検索元の文章
        /// </summary>
        public string Source { get; set; } = "Hello World!";

        /// <summary>
        /// 検索する文字列
        /// </summary>
        public string Pattern { get; set; } = "*W*";

        /// <summary>
        /// 検索結果
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// 検索コマンド
        /// </summary>
        public DelegateCommand SearchCommand { get; private set; }

        #endregion

        /// <summary>
        /// LikeOperatorサンプル.ViewModel
        /// </summary>
        public Sample()
        {

            SearchCommand = new DelegateCommand(
                () =>
                {

                    if (_Model.Contains(Source, Pattern))
                    {
                        Answer = "見つかりました";
                    }
                    else
                    {
                        Answer = "見つかりません";
                    }

                    CallPropertyChanged(nameof(Answer));

                },
                () => true);

        }

    }

}

using LikeOperatorSample.Forms.View;
using System.Windows;

namespace LikeOperatorSample
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {

        /// <summary>処理開始</summary>
        /// <param name="e">スタートアップイベントデータ</param>
        protected override void OnStartup(StartupEventArgs e)
        {

            base.OnStartup(e);

            new Sample().ShowDialog();

        }

    }

}

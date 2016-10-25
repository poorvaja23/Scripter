using System;

namespace Scripter.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IViewWithDataContextAndVisibility view;

        public IViewWithDataContextAndVisibility View
        {
            get { return view; }
            set
            {
                if (view == value) return;

                view = value;
                view.DataContext = this;
            }
        }

        private string authorName;

        public string AuthorName
        {
            get { return authorName; }
            set { SetProperty(ref authorName, value, "AuthorName"); }
        }

        public MainViewModel()
        {

        }

        public override void Initialize()
        {
            AuthorName = Environment.UserName.Split('_')[0]+ " "+ Environment.UserName.Split('_')[1];
            //string MyKeyWord = "XMP";

            //var allDirectories = new DirectoryInfo(SearchDirectoryName).GetDirectories("*", SearchOption.AllDirectories);

            //var ItemsSource =
            //    (from di in allDirectories from fi in di.GetFiles() where HasKeyWordMatch(fi, MyKeyWord) select fi);
        }
    }
}

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

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value, "FirstName"); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { SetProperty(ref lastName, value, "LastName"); }
        }

        public MainViewModel()
        {

        }

        public override void Initialize()
        {
        }

        public override void Load()
        {
            FirstName = Environment.UserName.ToString();
            //string MyKeyWord = "XMP";

            //var allDirectories = new DirectoryInfo(SearchDirectoryName).GetDirectories("*", SearchOption.AllDirectories);

            //var ItemsSource =
            //    (from di in allDirectories from fi in di.GetFiles() where HasKeyWordMatch(fi, MyKeyWord) select fi);
        }
    }
}

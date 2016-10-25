using System.ComponentModel;

namespace Scripter
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase HostViewModel { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetProperty<T>(ref T targetField, T value, string propertyName)
        {
            targetField = value;
            onPropertyChanged(propertyName);
        }

        public virtual void Initialize()
        {
        }

        public virtual void Load()
        {
        }

        public virtual void Unload()
        {
        }

        private void onPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

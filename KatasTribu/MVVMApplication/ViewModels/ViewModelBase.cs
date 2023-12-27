using System.ComponentModel;

namespace MVVMApplication.ViewModels
{
    public class ViewModelBase: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // on fait hériter d'abord l'interface à la classe, ça surligne en rouge et ensuite cette ligne est mis automatiquement avec afficher les corrections éventuelles

        public void OnPropertyChanged(string propertyName) => PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

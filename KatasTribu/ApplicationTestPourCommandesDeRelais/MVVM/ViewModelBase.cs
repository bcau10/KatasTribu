using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTestPourCommandesDeRelais.MVVM
{
    internal class ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged; //on note l'interface en dur et on implémente l'interface avec afficher les corrections

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

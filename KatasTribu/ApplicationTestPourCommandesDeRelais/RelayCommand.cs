using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ApplicationTestPourCommandesDeRelais
{
    class RelayCommand :ICommand
    {
        private Action<object> _execute; //_execute is a function call cf ci-dessous
        private Func<object, bool> _canExecute;// Func fonction qui retourne un bool

        public event EventHandler CanExecuteChanged //on rentre à l'intérieur de cet event, la propriété Event doit tjs avoir des accesseurs add et remove
        {
            add { CommandManager.RequerySuggested += value; }  //gestion meilleure de la mémoire sur les event
            remove { CommandManager.RequerySuggested -= value; }
        }

        //we need a constructor
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) //on rend le 2ème argument optionnel
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return (_canExecute == null || _canExecute(parameter)); //affiche si une fonction ne peut pas être affiché, sinon il l'execute
        }

        public void Execute(object parameter)
        {
            Execute(parameter); //run our Execute function
        }
    }
}

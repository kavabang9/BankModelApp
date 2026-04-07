using BankingActivitiesApp.ViewModels;
using BankModelApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace BankModelApp.ViewModels
{
    class RegisterViewModel : INotifyPropertyChanged
    {
        public ICommand OpenLoginWindowCommand { get; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public RegisterViewModel()
        {

        }
        private void OpenLoginWindow()
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }
    }
}

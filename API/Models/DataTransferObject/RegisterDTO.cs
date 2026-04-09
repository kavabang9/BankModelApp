using BankModelApp.ViewModels;

namespace BankModelApp.API.Models.DataTransferObject
{
    internal class RegisterDTO : RegisterViewModel
    {
        private string phone;
        private string password;
        private string Name;    // надо реализовать
        private string Surname;    // надо реализовать
        private string Email;    // надо реализовать

        public string TempPhone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string TempPassword
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public RegisterDTO(string phone, string password)
        {
            phone = TempPhone;
            password = TempPassword;
        }

        public bool Validation(string phone, string password)
        {
            return (!string.IsNullOrEmpty(phone) && password.Length > 8);
        }
    }
}

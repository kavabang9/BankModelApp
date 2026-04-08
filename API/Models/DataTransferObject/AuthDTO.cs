using BankModelApp.View;

namespace BankModelApp.API.Models.DataTransferObject
{
    internal class AuthDTO : LoginWindow
    {
        private string phone;

        private string password;

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
        public AuthDTO(string phone, string password)
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

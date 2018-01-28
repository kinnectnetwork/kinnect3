using System;
namespace kinnect.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username  { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Industry { get; set; }
        public string FocusArea { get; set; }
        public string Organisation { get; set; }
        public string CurrentlyWorksIn { get; set; }
        public string HaveWorkedIn { get; set; }
        public string ProfessionalInterests { get; set; }


        public User(){}
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public bool CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
                    else
                return false;
            
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Honours.Models
{
    // connector table used to keep hashed passwords separate from main user table for additional security
    public class Password 
    {
        public Guid UserID { get; init; }
        [ForeignKey("_password")]
        private string _password { get; set; } // set to private as to keep secure

        public Password(Guid userID, string password)
        {
            UserID = userID;
            _password = password;
        }
    }
}

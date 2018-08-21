using BusinessLayer.io.employeeManagement;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer.io.users.loginInformation
{
    [Table("LoginInformation")]
    public class LoginInformation
    {
        public LoginInformation(string userName, string password, AuthenticationLevel authenticationLevel)
        {
            this.UserName = userName;
            this.Password = password;
            this.AuthenticationLevel = authenticationLevel;
        }
        public LoginInformation()
        {

        }
        public AuthenticationLevel AuthenticationLevel { get; set; }
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        //EF
        [Key]
        [ForeignKey("Employee")]
        public string ID { get; set; }
        public virtual Employee Employee { get; set; }

    }
}

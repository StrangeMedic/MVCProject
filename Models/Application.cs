using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string phoneNumber { get; set; }
        public string major {  get; set; }

        public bool likesXP { get; set; }

        public int GetApplicationID()//Getter
        {
            return ApplicationId;
        }

        public void SetApplicationID(int num) //Setter
        {
            ApplicationId = num;
        }

    }
}


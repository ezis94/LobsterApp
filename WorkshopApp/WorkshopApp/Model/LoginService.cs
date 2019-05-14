using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkshopApp.Model;
using Xamarin.Forms;

[assembly:Dependency(typeof(LoginService))]
namespace WorkshopApp.Model
{
    public class LoginService : ILoginService
    {

        public async Task<bool> SubmitAsync(string username, string password)
        {
     
            await Task.Delay(2000);

            if ((username == "1") && (password == "1"))
                return true;
            else
                throw new UnauthorizedAccessException();
     
        }
    }
}

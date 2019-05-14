using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopApp.Model
{
    public interface ILoginService
    {
        Task<bool> SubmitAsync(string username, string password);
    }
}

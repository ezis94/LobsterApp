using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkshopApp.Model.Contract;

namespace WorkshopApp.Model
{
    public interface IChuckService
    {
        Task<Joke> GetRandomJokeAsync();
    }
}

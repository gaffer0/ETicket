using ECommerce_YT.Models;

namespace ECommerce_YT.Data.Services
{
    public interface IActorService
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor actor);
        void Delete(int id);
    }
}

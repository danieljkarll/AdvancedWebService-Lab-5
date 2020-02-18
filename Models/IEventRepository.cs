using System.Linq;
using Microsoft.AspNetCore.JsonPatch;

namespace Modas.Models
{
    public interface IEventRepository
    {
        IQueryable<Event> Events { get; }
        IQueryable<Location> Locations { get; }
        Event AddEvent(Event evt);
        void DeleteEvent(int eventId);

        Event UpdateEvent(Event evt);
        void PatchEvent(int id, JsonPatchDocument<Event> patch);


    }
}

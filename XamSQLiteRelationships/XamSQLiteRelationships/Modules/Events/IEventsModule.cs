using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Events;

namespace XamSQLiteRelationships.Modules.Events
{
    public interface IEventsModule
    {
        Task AddOrUpdateEvent(Event eventObject);
        Task<List<Event>> GetEventsByUserId(int userId);
        Task SubscribeUserToEvent(int eventId, int userId);
        Task RemoveEvent(int eventId);
    }
}

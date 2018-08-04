using System.Collections.Generic;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Events;

namespace XamSQLiteRelationships.Modules.Events
{
    public class EventsModule : IEventsModule
    {
        public async Task AddOrUpdateEvent(Event eventObject)
        {
            await App.Database.Events.AddOrUpdateEvent(eventObject);
        }

        public async Task<List<Event>> GetEventsByUserId(int userId)
        {
            var eventsUserId = await App.Database.Events.GetEventsByUserId(userId);
            return eventsUserId;
        }

        public async Task SubscribeUserToEvent(int eventId, int userId)
        {
            await App.Database.Events.SubscribeUserToEvent(eventId, userId);
        }

        public async Task RemoveEvent(int eventId)
        {
            await App.Database.Events.RemoveEvent(eventId);
        }
    }
}
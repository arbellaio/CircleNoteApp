using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamSQLiteRelationships.Database.DatabaseHandler;
using XamSQLiteRelationships.Models.Events;
using XamSQLiteRelationships.Models.Users;
using XamSQLiteRelationships.Models.UsersEvents;

namespace XamSQLiteRelationships.Database.Events
{
    public class EventsTable : IEventsTable
    {
        public LocalDatabase Handler { get; set; }

        public EventsTable(LocalDatabase _database)
        {
            if (_database == null)
            {
                throw new ArgumentNullException("Database");
            }
            else
            {
                Handler = _database;
            }
        }


        public async Task AddOrUpdateEvent(Event eventObject)
        {
            await Handler.Database.InsertAsync(eventObject);
        }

        public async Task<List<Event>> GetEventsByUserId(int userId)
        {
            List<Event> userEvents = null;
            var usereventlist = await Handler.Database.Table<UserEvent>().Where(x => x.UserId == userId).ToListAsync();
            foreach (var userevent in usereventlist)
            {
                userEvents = await Handler.Database.Table<Event>().Where(x => x.Id == userevent.EventId).ToListAsync();
            }

            return userEvents;
        }

        public async Task SubscribeUserToEvent(int eventId, int userId)
        {
            //TODO Confusing Still Need Work Todo
            // var eventObject = await Handler.Database.Table<Event>().Where(x => x.Id == eventId).FirstOrDefaultAsync();
            // var user = await Handler.Database.Table<User>().Where(x => x.Id == userId).FirstOrDefaultAsync();

            var userEvent= new UserEvent
            {
                EventId = eventId,
                UserId = userId
            };
            await Handler.Database.InsertAsync(userEvent);
          
        }

        public async Task RemoveEvent(int eventId)
        {
           var eventObject =  await Handler.Database.Table<Event>().Where(x => x.Id == eventId).FirstOrDefaultAsync();
            await Handler.Database.DeleteAsync(eventObject);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using SQLiteNetExtensions.Attributes;
using XamSQLiteRelationships.Models.Events;
using XamSQLiteRelationships.Models.Users;

namespace XamSQLiteRelationships.Models.UsersEvents
{
    public class UserEvent
    {
        // Foreign Key Of User's Id in User_Event Table
        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

        // Foreign Key Of Event's Id in User_Event Table
        [ForeignKey(typeof(Event))]
        public int EventId { get; set; }
    }
}

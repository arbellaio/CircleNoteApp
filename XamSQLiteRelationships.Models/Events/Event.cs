using System;
using System.Collections.Generic;
using System.Text;
using SQLiteNetExtensions.Attributes;
using XamSQLiteRelationships.Models.Users;
using XamSQLiteRelationships.Models.UsersEvents;

namespace XamSQLiteRelationships.Models.Events
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        //UserEvent Foreign Key Many To Many With Event
        [ManyToMany(typeof(UserEvent))]
        public virtual List<User> Users{ get; set; }
    }
}

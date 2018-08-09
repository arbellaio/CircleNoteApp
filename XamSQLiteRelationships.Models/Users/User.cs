using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using XamSQLiteRelationships.Models.Events;
using XamSQLiteRelationships.Models.Insurances;
using XamSQLiteRelationships.Models.Notes;
using XamSQLiteRelationships.Models.UsersEvents;

namespace XamSQLiteRelationships.Models.Users
{
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        
        // Insurance One To One Relationship with User
        [ForeignKey(typeof(Insurance))]
        public int InsuranceId { get; set; }
        [OneToOne]
        public Insurance Insurance { get; set; }


        
        // Notes One To Many Relationship With User
        [OneToMany]
        public virtual List<Note> Notes { get; set; }

        // UserEvent Many To Many Relationship With User
        [ManyToMany(typeof(UserEvent))]
        public virtual List<Event> Events { get; set; }


    }
}

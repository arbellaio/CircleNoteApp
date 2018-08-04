using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using XamSQLiteRelationships.Models.Users;

namespace XamSQLiteRelationships.Models.Insurances
{
    public class Insurance
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string InsuranceType { get; set; }
        public DateTime AppliedDate { get; set; }


        // User One To One Relationship With Insurance 
        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

        [OneToOne]
        public User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using XamSQLiteRelationships.Models.Users;

namespace XamSQLiteRelationships.Models.Notes
{
    public class Note
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string NoteContent { get; set; }
        
        // DateTime Nullable = true
        public DateTime? CreatedDate { get; set; }

        
        // User Many To One Relationship with User
        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

        [ManyToOne]
        public User User { get; set; }

    }
}

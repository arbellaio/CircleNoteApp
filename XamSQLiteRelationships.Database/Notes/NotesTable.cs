using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamSQLiteRelationships.Database.DatabaseHandler;
using XamSQLiteRelationships.Models.Notes;
using XamSQLiteRelationships.Models.Users;

namespace XamSQLiteRelationships.Database.Notes
{
    public class NotesTable : INotesTable
    {
        public LocalDatabase Handler { get; set; }

        public NotesTable(LocalDatabase _database)
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

        public async Task AddOrUpdateNoteByUserId(Note note, int userId)
        {
            var user = await Handler.Database.Table<User>().Where(x => x.Id == userId).FirstOrDefaultAsync();
            var noteInDb = new Note
            {
                NoteContent = note.NoteContent,
                CreatedDate = DateTime.Today.Date,
                UserId = userId,
                User = user
            };
            await Handler.Database.InsertAsync(noteInDb);

        }

        public async Task<List<Note>> GetAllNotes()
        {
            var noteslist = await Handler.Database.Table<Note>().ToListAsync();
            return noteslist;
        }

        public async Task<List<Note>> GetNotesByUserId(int userId)
        {
            var notesByUserId = await Handler.Database.Table<Note>().Where(x => x.UserId == userId).ToListAsync();
            return notesByUserId;
        }

        public async Task DeleteNote(int noteId)
        {
            var note = Handler.Database.Table<Note>().Where(x => x.Id == noteId).FirstOrDefaultAsync();
            await Handler.Database.DeleteAsync(note);
        }
    }
}
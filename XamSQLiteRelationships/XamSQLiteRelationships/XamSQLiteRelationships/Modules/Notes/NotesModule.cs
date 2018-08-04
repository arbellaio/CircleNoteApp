using System.Collections.Generic;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Notes;

namespace XamSQLiteRelationships.Modules.Notes
{
    public class NotesModule : INotesModule
    {
        public async Task AddOrUpdateNoteByUserId(Note note, int userId)
        {
           await App.Database.Notes.AddOrUpdateNoteByUserId(note, userId);
        }

        public async Task<List<Note>> GetAllNotes()
        {
            var noteslist = await App.Database.Notes.GetAllNotes();
            return noteslist;
        }

        public async Task<List<Note>> GetNotesByUserId(int userId)
        {
           var userNoteList = await App.Database.Notes.GetNotesByUserId(userId);
           return userNoteList;
        }

        public async Task DeleteNote(int noteId)
        {
            await App.Database.Notes.DeleteNote(noteId);
        }
    }
}
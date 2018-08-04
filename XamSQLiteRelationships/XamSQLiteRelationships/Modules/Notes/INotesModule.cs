using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Notes;

namespace XamSQLiteRelationships.Modules.Notes
{
    public interface INotesModule
    {
        Task AddOrUpdateNoteByUserId(Note note, int userId);
        Task<List<Note>> GetAllNotes();
        Task<List<Note>> GetNotesByUserId(int userId);
        Task DeleteNote(int noteId);
    }
}

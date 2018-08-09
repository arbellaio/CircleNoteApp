using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamSQLiteRelationships.Models.Notes;

namespace XamSQLiteRelationships.Database.Notes
{
    public interface INotesTable
    {
        Task AddOrUpdateNoteByUserId(Note note, int userId);
        Task<List<Note>> GetAllNotes();
        Task<List<Note>> GetNotesByUserId(int userId);
        Task DeleteNote(int noteId);

    }
}

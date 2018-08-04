using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using XamSQLiteRelationships.Models.Notes;
using XamSQLiteRelationships.Models.Users;

namespace XamSQLiteRelationships.ViewModels.Notes
{
    public class NotesViewModel : BaseViewModel
    {              
        public Note Note { get; set; }
        public List<Note> notesList { get; set; }

        public NotesViewModel()
        {
            Note = new Note(); 
            GetAllNotesByUser();
          
        }


       


        public async Task AddOrUpdateNote()
        {
            var userId = App.Users.LoggedInUserId;                  
            await App.Notes.AddOrUpdateNoteByUserId(Note, userId);
            if (NotesList != null)
            {
                NotesList.Clear();
                notesList = await App.Notes.GetNotesByUserId(userId);
                notesList.Reverse();
            }
            NotesList = new ObservableCollection<Note>(notesList);
            await Application.Current.MainPage.Navigation.PopPopupAsync();

        }

      
        public async Task GetAllNotesByUser()
        {
            var userId =  App.Users.LoggedInUserId;
            notesList = new List<Note>();            
            notesList =  await App.Notes.GetNotesByUserId(userId);
            if (notesList != null)
            {
                notesList.Reverse();
                NotesList = new ObservableCollection<Note>(notesList);                
            } 
        }

        


        public ICommand AddNoteCommand
        {
            get
            {
              return new Command(async () =>
              {
                IsRefreshing = true;
                await GetAllNotesByUser();
                await AddOrUpdateNote();
                IsRefreshing = false;

              });               
            }
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsRefreshing = true;
                    await GetAllNotesByUser();
                    IsRefreshing = false;
                });
            }
        }


        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                NotifyPropertyChanged(nameof(IsRefreshing));
            }
        }

        public DateTime? CreatedDate
        {
            get => Note.CreatedDate;
            set
            {
                Note.CreatedDate = DateTime.Today.Date;
                NotifyPropertyChanged(nameof(CreatedDate));
            }
        }


        public string NoteContent
        {
            get => Note.NoteContent;
            set
            {
                Note.NoteContent = value;
                NotifyPropertyChanged("NoteContent");
            }
        }


        public ObservableCollection<Note> _notes;
        public ObservableCollection<Note> NotesList
        {
            get => _notes;
            set
            {
                if (value == null) return;
                _notes = value;
                NotifyPropertyChanged(nameof(NotesList));
            }
        }
    }
}

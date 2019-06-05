using System;
using System.Collections.ObjectModel;
using JaverianaCali.Models;
using JaverianaCali.Services;

namespace JaverianaCali.ViewModels
{
    public class BookViewModel : BookModel
    {
        private readonly BookService service = new BookService();
        private ObservableCollection<BookModel> books;

        public BookViewModel(UserModel user)
        {
            // Todo: Make this async call the same way we did on post Login
            books = service.findBooksByUser(user);
        }

        public ObservableCollection<BookModel> Books { get => books; set => books = value; }
    }
}

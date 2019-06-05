using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using JaverianaCali.Models;

namespace JaverianaCali.Services
{
    public class BookService : BookServiceInterface
    {
        public BookService()
        {
        }

        public ObservableCollection<BookModel> findBooksByUser(UserModel user)
        {
            ObservableCollection<BookModel> books = new ObservableCollection<BookModel>();
            books.Add(new BookModel("Calculo Multivariable", "Prestado", "8 Junio - 2019"));
            books.Add(new BookModel("Matematicas Discretas", "Prestado", "7 Junio - 2019"));
            books.Add(new BookModel("Desarrollo Movil", "Prestado", "5 Junio - 2019"));
            return books;
        }
    }
}

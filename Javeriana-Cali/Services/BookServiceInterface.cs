using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using JaverianaCali.Models;

namespace JaverianaCali.Services
{
    public interface BookServiceInterface
    {
        ObservableCollection<BookModel> findBooksByUser(UserModel user);
    }
}

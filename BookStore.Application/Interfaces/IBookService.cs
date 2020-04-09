using BookStore.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Application.Interfaces
{
    public interface IBookService
    {
        BookViewModel Books();
    }
}

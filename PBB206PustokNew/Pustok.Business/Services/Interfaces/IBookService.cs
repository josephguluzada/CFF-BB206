﻿using Pustok.Models;
using System.Linq.Expressions;

namespace Pustok.Business.Services.Interfaces
{
    public interface IBookService
    {
        Task CreateAsync(Book entity);
        Task SoftDelete(int id);
        Task Delete(int id);
        Task<Book> GetByIdAsync(int id);
        IQueryable<Book> GetAll(Expression<Func<Book, bool>>? expression = null,params string[]? includes);
        Task<List<Book>> GetAllAsync(Expression<Func<Book, bool>>? expression = null, params string[]? includes);
        Task<List<Book>> GetAllFilteredAsync(Expression<Func<Book, bool>>? expression = null, params string[]? includes);

        Task<List<Book>> GetAllRelatedBooksAsync(Book book);
        Task UpdateAsync(Book entity);
    }
}

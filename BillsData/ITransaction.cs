using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BillsData
{
    public interface ITransaction
    {
        IEnumerable<Transaction> GetAll();
        Transaction GetById(int id);
        void Add(Transaction newAsset);
        //Task<List<Transaction>> GetList(int page = 1, int? pageLocalSize = null);
        //int TotalItems { get; set; }
    }
}

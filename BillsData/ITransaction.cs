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
        string GetCategory(int id);
        string GetPaymentType(int id);
        string GetTransactionTag(int id);
        string GetProduct(int id);
        int GetAmout(int id);
        string GetUnit(int id);
       // string GetAttachment(int id);
                
        void Add(Transaction newAsset);
        //Task<List<Transaction>> GetList(int page = 1, int? pageLocalSize = null);
        //int TotalItems { get; set; }
    }
}

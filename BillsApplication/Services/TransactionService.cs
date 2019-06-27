﻿
using BillsApplication.Data;
using BillsData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillsApplication
{
    public class TransactionService : ITransaction
    {
        private readonly ApplicationDbContext context;

        public TransactionService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(Transaction newAsset)
        {
            context.Add(newAsset);
            context.SaveChanges();
        }

        public IEnumerable<Transaction> GetAll()
        {
            return context.Transactions
                .Include(asset => asset.TransactionCategory)
                .Include(asset => asset.PaymentType);
        }

        public Transaction GetById(int id)
        {
            return
                GetAll()
                .FirstOrDefault(asset => asset.ID== id);
        }
        public string GetCategory(int id)
        {
            if (context.TransactionCategories.Any(a => a.ID == id))
            {
                return context.TransactionCategories
                    .FirstOrDefault(a => a.ID == id).Name;
            }
            else return "";
        }
        public string GetPaymentType(int id)
        {
            if (context.PaymentTypes.Any(a => a.ID == id))
            {
                return context.PaymentTypes
                    .FirstOrDefault(a => a.ID == id).PaymentName.ToString();
            }
            else return "";
        }
    }
}
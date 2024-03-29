﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BillsApplication.Data;
using BillsData;
using BillsApplication.Models.TransactionForm;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace BillsApplication.Controllers
{
    public class TransactionController : Controller
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ITransaction assets;

        public TransactionController(ITransaction assets)
        {
            this.assets = assets;
        }

        // GET: Transaction
        public IActionResult Index()
        {
            var assetModels = assets.GetAll();
            var listingResult = assetModels
                .Select(result => new TransactionListingModel
                {
                    ID = result.ID,
                    TransactionCategory = assets.GetCategory(result.ID),
                    Name = result.Name,
                    Description = result.Description,
                    TransactionDate = result.TransactionDate,
                    Price = result.Price,
                    PaymentType = assets.GetPaymentType(result.ID)

                });
            var model = new TransactionIndexModel()
            {
                TransactionsListingModels = listingResult
            };
            return View(model);
        }


        // GET: Transaction/Details/5
        public IActionResult Details(int id)
        {
            var asset = assets.GetById(id);
            var model = new DetailsModel
            {
                ID = id,
                TransactionCategory = assets.GetCategory(id),
                Name = asset.Name,
                Description = asset.Description,
                TransactionDate = asset.TransactionDate,
                Price = asset.Price,
                PaymentType = assets.GetPaymentType(id),
                CreationDate = DateTime.Now,
                ModyficationDate = asset.ModyficationDate,
                TransactionTags = assets.GetTransactionTag(id),
                Product = assets.GetProduct(id),
                Amount = assets.GetAmout(id),
          
            };
            return View(model);
        }

        // GET: Transaction/Create
        public IActionResult Create()
        {
            ViewData["PaymentTypeID"] = assets.GetPaymentTypes();
            ViewData["TransactionCategoryID"] = assets.GetTransactionCategories();
            return View();
        }

        // POST: Transaction/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Name,Description,TransactionCategoryID,TransactionDate,CreateDate,ModyficationDate,Price,PaymentTypeID")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
               // transaction.UserID = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

                assets.Add(transaction);
                return RedirectToAction(nameof(Index));
            }
            ViewData["PaymentTypeID"] = assets.GetPaymentTypes();
            ViewData["TransactionCategoryID"] = assets.GetTransactionCategories();
            return View(transaction);
        }
    }

    //    // GET: Transaction/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var transaction = await _context.Transactions.FindAsync(id);
    //        if (transaction == null)
    //        {
    //            return NotFound();
    //        }
    //        ViewData["TransactionCategoryID"] = new SelectList(_context.TransactionCategories, "ID", "Name", transaction.TransactionCategoryID);
    //        ViewData["PaymentTypeID"] = new SelectList(_context.PaymentTypes, "ID", "ID", transaction.PaymentTypeID);
    //        return View(transaction);
    //    }

    //    // POST: Transaction/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Category,TransactionCategoryID,TransactionDate,CreateDate,ModyficationDate,Price,PaymentTypeID")] Transaction transaction)
    //    {
    //        if (id != transaction.ID)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(transaction);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!TransactionExists(transaction.ID))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        ViewData["TransactionCategoryID"] = new SelectList(_context.TransactionCategories, "ID", "Name", transaction.TransactionCategoryID);
    //        ViewData["PaymentTypeID"] = new SelectList(_context.PaymentTypes, "ID", "ID", transaction.PaymentTypeID);
    //        return View(transaction);
    //    }

    //    // GET: Transaction/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var transaction = await _context.Transactions
    //            .Include(t => t.Category)
    //            .Include(t => t.PaymentType)
    //            .FirstOrDefaultAsync(m => m.ID == id);
    //        if (transaction == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(transaction);
    //    }

    //    // POST: Transaction/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var transaction = await _context.Transactions.FindAsync(id);
    //        _context.Transactions.Remove(transaction);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool TransactionExists(int id)
    //    {
    //        return _context.Transactions.Any(e => e.ID == id);
    //    }
    //}
}

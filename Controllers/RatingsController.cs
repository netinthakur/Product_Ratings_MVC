using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Product_Ratings_MVC.Models;

namespace Product_Ratings_MVC.Controllers
{
    [Authorize]
    //Ratings controller using permission.
    public class RatingsController : Controller
    {
        private readonly Product_Ratings_MVCDataContext _context;

        public RatingsController(Product_Ratings_MVCDataContext context)
        {
            _context = context;
        }

        // GET: Ratings
        //Gets all ratings using a  lamda query
        public IActionResult Index()
        {
            var product_Ratings_MVCDataContext = _context.Rating.Include(r => r.Customer).Include(r => r.Product);
            return View( product_Ratings_MVCDataContext.ToList());
        }

        // GET: Ratings/Details/5
        //Gets the details of  the rating using a lamda query.
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating =_context.Rating
                .Include(r => r.Customer)
                .Include(r => r.Product)
                .FirstOrDefault(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // GET: Ratings/Create
        //Gets the create ratings form.
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Name");
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name");
            return View();
        }

        // POST: Ratings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Creates the rating
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,CustomerId,ProductId,RatingValue,Comment")] Rating rating)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rating);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Name", rating.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name", rating.ProductId);
            return View(rating);
        }

        // GET: Ratings/Edit/5
        //Gets the rating for edit using  a linq query.
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating = (from ratings in _context.Rating
                          where ratings.Id == id
                          select ratings).FirstOrDefault();
            if (rating == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Name", rating.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name", rating.ProductId);
            return View(rating);
        }

        // POST: Ratings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Updates the rating
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,CustomerId,ProductId,RatingValue,Comment")] Rating rating)
        {
            if (id != rating.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rating);
                     _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RatingExists(rating.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "Id", "Id", rating.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", rating.ProductId);
            return View(rating);
        }

        // GET: Ratings/Delete/5
        //Gets the rating a for delete using a lamda 
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rating =  _context.Rating
                .Include(r => r.Customer)
                .Include(r => r.Product)
                .FirstOrDefault(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }

            return View(rating);
        }

        // POST: Ratings/Delete/5
        //Deletes the ratings uses a linq query to select 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var rating = (from ratings in _context.Rating
                          where ratings.Id == id
                          select ratings).FirstOrDefault();
            _context.Rating.Remove(rating);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //Checks the rating using a lamda query.
        private bool RatingExists(int id)
        {
            return _context.Rating.Any(e => e.Id == id);
        }
    }
}

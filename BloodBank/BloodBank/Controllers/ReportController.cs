using BloodBank.EF;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.Controllers
{
    public class ReportController : Controller
    {
        BloodBankDbContext db;

        public ReportController(BloodBankDbContext db)
        {
            this.db = db;
        }


        
        public IActionResult FilterByBloodGroup(string bloodGroup)
        {
            var donors = string.IsNullOrEmpty(bloodGroup)
                ? db.Donors.ToList()
                : db.Donors.Where(d => d.BloodGroup == bloodGroup).ToList();

            ViewBag.SelectedBloodGroup = bloodGroup;
            return View(donors);
        }


       
        public IActionResult SortedByDate()
        {
            var donors = db.Donors.OrderBy(d => d.LastDonationDate).ToList();
            return View(donors);
        }



        public IActionResult DonationCount()
        {
            var rs = db.Donors.Select(d => new
            {
                d.FullName,
                d.BloodGroup,
                TotalDonations = db.Donations.Count()
            })
                .ToList();

            ViewBag.Title = rs;
            return View();
        }


        public IActionResult TotalVolume()
        {
            var total = db.Donations.Sum(d => Convert.ToInt32(d.VolumeMl));
            ViewBag.TotalVolume = total;
            return View();
        }

    }
}
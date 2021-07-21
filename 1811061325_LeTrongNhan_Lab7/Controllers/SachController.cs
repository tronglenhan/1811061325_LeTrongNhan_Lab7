using _1811061325_LeTrongNhan_Lab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1811061325_LeTrongNhan_Lab7.Controllers
{
    public class SachController : ApiController
    {

        [HttpGet]
        public List<sach> GetSachLists()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.saches.ToList();
        }
        [HttpGet]
        public sach GetSach(int id)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            return db.saches.FirstOrDefault(x => x.Id == id);
        }
        //aa
    }
}

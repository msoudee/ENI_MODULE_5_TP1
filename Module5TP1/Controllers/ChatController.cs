using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace Module5TP1.Controllers
{
    public class ChatController : Controller
    { 

        // GET: Chat
        public ActionResult Index()
        {
            var listeDeChats = ChatVM.GetMeuteDeChats();

            return View(listeDeChats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            var chat = ChatVM.GetMeuteDeChats().Where(c => c.Id == id).FirstOrDefault();

            return View(chat);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            var chat = ChatVM.GetMeuteDeChats().Where(c => c.Id == id).FirstOrDefault();

            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ChatVM.GetMeuteDeChats().Remove(ChatVM.GetMeuteDeChats().Where(c => c.Id == id).First());

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

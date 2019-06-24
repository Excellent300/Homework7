using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework7._1.ViewModels;
using System.Data.SqlClient;

namespace Homework7._1.Controllers
{
    public class ShopController : Controller
    {
        private SqlConnection myConnect = new SqlConnection(Global.connectionString);
        public static List<ShopItemModel> Items = new List<ShopItemModel>();


        ShopItemModel list = new ShopItemModel();
    
       
      
    public ActionResult Index()
        {
            
          

            Items.OrderBy(zz => zz.getName).ToList();

       

            ViewBag.counts = Items.Count();
            ViewBag.Model = "Model";

            return View(Items.ToList());
        }

   


        public ActionResult AddItem()
        {
            return View();
        }

        public ActionResult Part_2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Part_2(string Name, string Descr, double Prices, int Quantity)
        {
            try
            {
                SqlCommand myComm = new SqlCommand("Insert into ShopItem Values('"+Name+ "', '" + Descr + "', '" + Prices + "' , '"+ Quantity + "')", myConnect);
                myConnect.Open();
                myComm.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                ViewBag.message = err.Message;
            }
            finally
            {
                myConnect.Close();
            }
            return View();
        }
            

        [HttpPost]
        public ActionResult AddItem(string Name,string Descr,double Prices,int Quantity)
        {
           

            ShopItemModel newItem = new ShopItemModel(Name, Descr, Prices, Quantity);
            Items.Add(newItem);
            return View("Index",Items);
        }

      
        public void orderName()
        {
            List<ShopItemModel> sorted=Items.OrderBy(zz => zz.Name).ToList();
        }
    }
}
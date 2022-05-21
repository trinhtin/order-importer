using System;
using System.Collections.Generic;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v3;
using WooCommerceNET.WooCommerce.v3.Extension;

namespace OrderImporter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            run();
        }

        static void run()
        {
            //Keys of Store
            List<WooCommerceKey> listKeys = new List<WooCommerceKey>();

            //Shipbh.xyz
            listKeys.Add(new WooCommerceKey("shipbh.xyz", "ck_782ebd66de091b3b8cd70c753a0106c789102c9d", "cs_c97daf05befbd6bc07d707f75f8cdda5e0898202"));

            //Group 6: Hà Quí Thành
            listKeys.Add(new WooCommerceKey("minsizeshop.xyz", "ck_9864e8d917c94a4db471aabcb74e898eb636c134", "cs_4215883059ed4927664a086b922b5b86f37c5d74"));

            //Group 8: Kiên
            listKeys.Add(new WooCommerceKey("learning.tino.page", "ck_d5ded62184add40393c512de96bbc9b6d6b7bd26", "cs_29010a1536b28b6fcd47738e0091b978c328ba65"));

            //Group 3: Đa
            listKeys.Add(new WooCommerceKey("xusobanhkeo.com", "ck_467fe4008a12a00864a14b0144c96a775340a7d9", "cs_fea6357adb02c7636e1d0225d90623ff2ae31971"));

            //Loop through each store to get orders
            List<Order> listAllOrders = new List<Order>();
            foreach (var key in listKeys)
            {
                //Set up API
                RestAPI rest = new RestAPI("https://" + key.DomainName + "/wp-json/wc/v3/", key.ConsumerKey, key.ConsumerSecret);
                WCObject wc = new WCObject(rest);

                //Get orders
                var orders = wc.Order.GetAll().Result;
                listAllOrders.AddRange(orders);
            }
        }
    }
}

////Get all products
//Dictionary<string, string> parameters = new Dictionary<string, string>();
//parameters.Add("per_page", "20");
//parameters.Add("page", "2");
//parameters.Add("order", "asc");
//var products = wc.Product.GetAll(parameters).Result;

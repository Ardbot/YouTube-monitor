/*
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net;
public class Item
{
    public string classid { get; set; }
    public string instanceid { get; set; }
    public string hash_name { get; set; }
    public string price { get; set; }
    public string time { get; set; }
    public string id { get; set; }
}
public class Program
{
    public static void Main()
    {
        var jsonString = new WebClient().DownloadString(@"https://market.csgo.com/history/json/");
        var itemsFromApi = JsonConvert.DeserializeObject<Item[]>(jsonString);

        // strings for search
        var keyWords = new string[] { "StatTrakT P250", "Sticker" };

        foreach (var keyWord in keyWords)
        {
            // filtering items
            var filteredItems = FilterItems(itemsFromApi, keyWord);
   /*         Console.WriteLine("-----------------------------------");
            Console.WriteLine("Keyword: {0}", keyWord);
            Console.WriteLine("Found: {0} items", filteredItems.Count);
            foreach (var filteredItem in filteredItems)
            {
                Console.WriteLine("classid : {0}", filteredItem.classid);
                Console.WriteLine("instanceid: {0}", filteredItem.instanceid);
                Console.WriteLine("hash_name : {0}", filteredItem.hash_name);
                Console.WriteLine("price : {0}", filteredItem.price);
                Console.WriteLine("time : {0}", filteredItem.time);
                Console.WriteLine("id : {0}", filteredItem.id);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }

    //    Console.ReadKey();
    }

    private static List<Item> FilterItems(Item[] items, string searchedItem)
    {
        var filteredItems = items.Where(item => item.hash_name.Contains(searchedItem)).ToList();
        return filteredItems;
    }
}
*/

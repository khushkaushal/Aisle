using System;
using System.Collections.Generic;
using System.Text;

namespace Aisle
{
    public class Item
    {
        public string Name { get; set; }
        public string Aisle { get; set; }
        

        public List<Item> makeList()
        {
                
                    List<Item> itemList = new List<Item>();

                    itemList.Add(new Item { Name = "Shampoo", Aisle = "Aisle 11" });
                    itemList.Add(new Item { Name = "Chicken", Aisle = "Aisle 10" });
                    itemList.Add(new Item { Name = "Fish", Aisle = "Aisle 9" });
                    itemList.Add(new Item { Name = "Cereal", Aisle = "Aisle 10" });
                    itemList.Add(new Item { Name = "Tomato", Aisle = "Aisle 1" });
                    itemList.Add(new Item { Name = "Juice", Aisle = "Aisle 8" });
                    itemList.Add(new Item { Name = "Honey", Aisle = "Aisle 7" });
                    itemList.Add(new Item { Name = "Soap", Aisle = "Aisle 10" });
                    itemList.Add(new Item { Name = "Chips", Aisle = "Aisle 5" });
                    itemList.Add(new Item { Name = "Umberella", Aisle = "Aisle 25" });
                    itemList.Add(new Item { Name = "bread", Aisle = "Aisle 20" });

                    return itemList;
                
        }

        

        public List<Item> searchItem(String Naam)
        {
            List<Item> itemList = new List<Item>();

            itemList.Add(new Item { Name = "Shampoo", Aisle = "Aisle 11" });
            itemList.Add(new Item { Name = "Chicken", Aisle = "Aisle 10" });
            itemList.Add(new Item { Name = "Fish", Aisle = "Aisle 9" });
            itemList.Add(new Item { Name = "Cereal", Aisle = "Aisle 10" });
            itemList.Add(new Item { Name = "Tomato", Aisle = "Aisle 1" });
            itemList.Add(new Item { Name = "Juice", Aisle = "Aisle 8" });
            itemList.Add(new Item { Name = "Honey", Aisle = "Aisle 7" });
            itemList.Add(new Item { Name = "Soap", Aisle = "Aisle 10" });
            itemList.Add(new Item { Name = "Chips", Aisle = "Aisle 5" });
            itemList.Add(new Item { Name = "Umberella", Aisle = "Aisle 25" });
            itemList.Add(new Item { Name = "bread", Aisle = "Aisle 20" });

            return itemList.FindAll(x => x.Name.Contains(Naam));
        }


        
    }
}
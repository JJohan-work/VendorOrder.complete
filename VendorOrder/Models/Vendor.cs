using System;
using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Desc { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string desc)
    {
      Name = name;
      Desc = desc;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

//Functions to add
  //Find Category
  //Get all Categories
  //Get all orders
  //Get specific order
  //Add order
  //Remove all orders
  //Remove specific order
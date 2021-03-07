using System;
using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};

    public int Id { get; private set; }
    public int VendorId {get; private set;}
    public string Type { get; private set; }
    public int Amount { get; private set; }
    public DateTime OrderPlaced { get; private set; }
    public DateTime OrderRequested { get; private set; }
    public int Cost = 0;
    public bool Payed { get; private set; } = false;
    public bool Fulfilled { get; private set; } = false;

    public Order(string type, int amount, int vendorId)
    {
      Type = type;
      Amount = amount;
      _instances.Add(this);
      Id = _instances.Count;
      VendorId = vendorId;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}
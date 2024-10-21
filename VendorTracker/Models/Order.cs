using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description)
    {
      Title = title;
      Description = description;
      _instances.Add(this);
    }
  }
}
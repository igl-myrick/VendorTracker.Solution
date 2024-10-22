using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name)
    {
      Name = name;
      _instances.Add(this)
    }
  }
}
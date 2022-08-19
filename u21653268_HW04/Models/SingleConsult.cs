using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21653268_HW04.Models
{
    public class SingleConsult : Session
    {
        private string mLocation;

        public SingleConsult(string name, string desc, int time, double price, bool refund, string imageUrl, string location) : base(name, desc, time, price, refund, imageUrl)
        {
            mLocation = location;
        }
        public override string Duration()
        {
            return "Once off Drop-in";
        }
        public string Location
        {
            get { return mLocation; }
            set { mLocation = value; }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " (" + Duration() + ") at this location: " + this.Location;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21653268_HW04.Models
{
    public class VirtualConsult : Session
    {
        private string mOnlinePlatform;

        public VirtualConsult(string name, string desc, int time, double price, bool refund, string imageUrl, string onlinePlatform) : base(name, desc, time, price, refund, imageUrl)
        {
            mOnlinePlatform = onlinePlatform;
        }
        public override string Duration()
        {
            return "Weekly";
        }
        public string OnlinePlatform
        {
            get { return mOnlinePlatform; }
            set { mOnlinePlatform = value; }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " (" + Duration() + ") on " + this.OnlinePlatform;
        }
    }
}
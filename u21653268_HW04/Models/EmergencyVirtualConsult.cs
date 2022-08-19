using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21653268_HW04.Models
{
    public class EmergencyVirtualConsult : Session
    {
        private string mPriority;
        private string mOnlinePlatform;

        public EmergencyVirtualConsult(string name, string desc, int time, double price, bool refund, string imageUrl, string onlinePlatform, string priority) : base(name, desc, time, price, refund, imageUrl)
        {
            mPriority = priority;
            mOnlinePlatform = onlinePlatform;

        }
        public string OnlinePlatform
        {
            get { return mOnlinePlatform; }
            set { mOnlinePlatform = value; }
        }

        public string Priority
        {
            get { return mPriority; }
            set { mPriority = value; }
        }
        public override string Duration()
        {
            return "Once off Drop-in";
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " (" + Duration() + ") on " + this.OnlinePlatform;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21653268_HW04.Models
{
    public abstract class Session
    {
        private int mTime;
        private string mName;
        private string mDescription;
        private double mPrice;
        private bool mRefund;
        private string mImageURL;

        public Session()
        {

        }

        public Session(string name, string desc, int time, double price, bool refund, string imageUrl)
        {
            mName = name;
            mDescription = desc;
            mTime = time;
            mPrice = price;
            mRefund = refund;
            mImageURL = imageUrl;
        }

        public abstract string Duration();

        public virtual string GetInfo()
        {
            return Time.ToString() + " minutes @ R" + Price.ToString();
        }

        public string ImageURL
        {
            get { return mImageURL; }
            set { mImageURL = value; }
        }
        public string Name 
        {
            get {return mName; }
            set { mName = value; } 
        }
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }
        public int Time
        {
            get { return mTime; }
            set { mTime = value; }
        }
        public double Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }
        public bool Refund
        {
            get { return mRefund; }
            set { mRefund = value; }
        }
    }
}
using System;
using MonoFramework;

namespace MonoTrader.Event
{
    public enum MatchDirection
    {
        LONG = 1,
        SHORT = 2
    }

    public class MatchedEvent: IEvent
    {
        public string OrderID { get; private set; }
        public MatchDirection Direction {get; private set;}
        public DateTime MatchedTime { get; private set; }
        public double MatchedPrice { get; private set; }
        public int MatchedVolume { get; private set; }
        public bool IsWithdrawal { get; private set; }

        public MatchedEvent(string orderID, MatchDirection direction,
                            DateTime matchedTime, double matchedPrice, int matchedVolume, bool isWithdrawal = false)
        {
            OrderID = orderID;
            Direction = direction;
            MatchedTime = matchedTime;
            MatchedPrice = matchedPrice;
            MatchedVolume = matchedVolume;
            IsWithdrawal = isWithdrawal;
        }
    }
}

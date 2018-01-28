using MonoFramework;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEEQMM.Event
{
    public class AssetCollectionChangedEvent : IEvent
    {
        //public NotifyCollectionChangedAction Action { get; set; }

        //public string Code { get; private set; }
        //public string Name { get; private set; }

        public NotifyCollectionChangedEventArgs Changes { get; private set; }
        public AssetCollectionChangedEvent()
        {
            Changes = new NotifyCollectionChangedEventArgs(null);
            Changes.NewItems
        }

        public IList<string> NewItems
        {
            get
            {
                return Changes.NewItems;
            }
        }
    }
}

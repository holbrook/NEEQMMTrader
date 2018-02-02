using Caliburn.Micro;
using MonoFramework.Workbench;
using NEEQMM.Event;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMDashboard
{
    public class DashbaordViewModel : IViewPart, IHandle<AssetCollectionChangedEvent>, IHandle<MMStatusChangedEvent>
    {
        public string DisplayName { get { return "做市状态监控";  } }

        public IObservableCollection<CardView> Items { get; set; }

        
        public DashbaordViewModel()
        {
            Items = new BindableCollection<CardView>();
            IoC.Get<IEventAggregator>().Subscribe(this);
        }



        public void Handle(AssetCollectionChangedEvent message)
        {
            throw new NotImplementedException();
        }

        public void Handle(MMStatusChangedEvent message)
        {
            throw new NotImplementedException();
        }
    }
}

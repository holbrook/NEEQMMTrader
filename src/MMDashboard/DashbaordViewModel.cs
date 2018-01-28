using Caliburn.Micro;
using MonoFramework.Workbench;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMDashboard
{
    public class DashbaordViewModel : IViewPart, IHandle<>
    {
        public string DisplayName { get { return "做市状态监控";  } }

        public IObservableCollection<CardView> Items { get; set; }

        
        public IEventAggregator EventStream { get; set; }
        public DashbaordViewModel()
        {
            Items = new BindableCollection<CardView>();
        }
    }
}

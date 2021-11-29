using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalAppliancesIHierarchy.Models
{
    public interface IPlugableIn
    {
        bool PluggedIn { get; set; }
    }
}

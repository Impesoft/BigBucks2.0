using System.Collections.Generic;
using System.Windows.Controls;

namespace BigBucks2._0
{
    interface IBeverage
    {
        string DefaultImage { get; set; }
        string Description { get; set; }
        string Image { get; set; }
        int InstanceID { get; set; }
        string Name { get; set; }
        double Price { get; set; }

        List<Control> CreateControls();
        string ToString();
    }
}
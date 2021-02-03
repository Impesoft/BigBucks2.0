using System.Collections.Generic;
using System.Windows.Controls;

namespace BigBucks2._0
{
    internal interface IBeverage
    {
        string Description { get; set; }
        string Image { get; set; }
        int Instanceid { get; set; }
        string Name { get; set; }
        double Price { get; set; }

        List<Control> CreateControls();

        string ToString();
    }
}
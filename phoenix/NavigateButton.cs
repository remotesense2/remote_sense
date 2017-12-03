using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix
{
    public partial class NavigateButton : System.Windows.Forms.Button
    {
        public ContainerControl ContainerPanel;

        public NavigateButton(ContainerControl container)
        {
            ContainerPanel = container;
        }
    }
}

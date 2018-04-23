using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.LayoutControl;

namespace LayoutCntMoveInGroup
{
    class MyLayoutControl : LayoutControl
    {
        protected override DevExpress.Xpf.Core.PanelControllerBase CreateController()
        {
            return new MyLayoutControlController(this);
        }

    }
}

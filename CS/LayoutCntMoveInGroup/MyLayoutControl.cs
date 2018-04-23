// Developer Express Code Central Example:
// How to prevent dragging elements from LayoutGroup
// 
// This example demonstrates how to allow customizing items only inside
// LayoutGroup. All custom logic is implemented in the
// LayoutItemDragAndDropController and LayoutControlController descendants. To
// allow adding new "isolated groups" to LayoutControl, a
// LayoutControlCustomizationController descendant was created.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4195

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

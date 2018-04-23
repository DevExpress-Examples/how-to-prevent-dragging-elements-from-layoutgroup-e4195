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
using DevExpress.Xpf.Core;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Core.Native;

namespace LayoutCntMoveInGroup
{
    class MyLayoutItemDragAndDropController : LayoutItemDragAndDropController
    {
        public MyLayoutItemDragAndDropController(Controller controller, Point startDragPoint, FrameworkElement dragControl)
			: base(controller, startDragPoint, dragControl) {
		}
        DependencyObject OriginalParent;
        LayoutItemInsertionInfo OriginalInsertationInfo;
        public override void StartDragAndDrop(Point p)
        {
            OriginalParent = DragControl.Parent;
            OriginalInsertationInfo = InsertionInfo;
            base.StartDragAndDrop(p);
        }
        protected override void OnInsertionInfoChanged()
        {
            MyLayoutGroup elemPar = OriginalParent as MyLayoutGroup;
            bool IsSourceIsolated = false;
            if (elemPar != null)
                IsSourceIsolated = elemPar.IsIsolatedGroup;
            bool IsTargetIsolated = false;
            MyLayoutGroup targParent;
            if (InsertionInfo.DestinationItem != null)
            {
                targParent = InsertionInfo.DestinationItem.Parent as MyLayoutGroup;
                if (targParent != null)
                    IsTargetIsolated = targParent.IsIsolatedGroup;
            }

            if (OriginalParent != null && InsertionInfo.DestinationItem != null)
                if (OriginalParent != InsertionInfo.DestinationItem.Parent && (IsSourceIsolated || IsTargetIsolated))
                {
                    NoIndicator();
                    return;
                }
            if (OriginalParent == null && IsTargetIsolated)
            {
                NoIndicator();
                return;
            }

            base.OnInsertionInfoChanged();
        }
        void NoIndicator()
        {
            Indicator.InsertionInfo = OriginalInsertationInfo;
            Indicator.SetVisible(OriginalInsertationInfo.DestinationItem != null);
            DestinationGroup = InsertionInfo.DestinationItem.IsLayoutGroup() ? (ILayoutGroup)InsertionInfo.DestinationItem : null;
        }
    }

}

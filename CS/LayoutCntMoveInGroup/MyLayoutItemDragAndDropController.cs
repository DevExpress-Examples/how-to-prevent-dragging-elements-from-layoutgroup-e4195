using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.LayoutControl;
using DevExpress.Xpf.Core;
using System.Windows;

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

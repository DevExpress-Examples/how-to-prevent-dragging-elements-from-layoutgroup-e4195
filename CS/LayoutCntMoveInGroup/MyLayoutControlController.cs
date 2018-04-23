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

namespace LayoutCntMoveInGroup
{
    class MyLayoutControlController : LayoutControlController
    {
        public MyLayoutControlController(ILayoutControl control) : base(control) { }
        protected override DragAndDropController CreateItemDragAndDropControler(Point startDragPoint, FrameworkElement dragControl)
        {
            return new MyLayoutItemDragAndDropController(this, startDragPoint, dragControl);
        }
        protected override LayoutControlCustomizationController CreateCustomizationController()
        {
            return new MyLayoutControlCustomizationController(this);
        }
        public override void DropElement(System.Windows.FrameworkElement element, LayoutItemInsertionPoint insertionPoint, LayoutItemInsertionKind insertionKind)
        {
            MyLayoutGroup elemPar = element.Parent as MyLayoutGroup;
            bool IsSourceIsolated = false;
            if (elemPar != null)
                IsSourceIsolated = elemPar.IsIsolatedGroup;
            bool IsTargetIsolated = false;
            MyLayoutGroup targParent = insertionPoint.Element.Parent as MyLayoutGroup;
            if (targParent != null)
                IsTargetIsolated = targParent.IsIsolatedGroup;

            if (element.Parent != null)
                if (element.Parent != insertionPoint.Element.Parent && (IsSourceIsolated || IsTargetIsolated))
                    return;
            if (element.Parent == null && IsTargetIsolated)
                return;
            base.DropElement(element, insertionPoint, insertionKind);
        }
    }
}

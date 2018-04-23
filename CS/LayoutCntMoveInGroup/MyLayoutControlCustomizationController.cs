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
using System.Windows;

namespace LayoutCntMoveInGroup
{
    public enum MyNewItem
    {
        NewCustomGroup
    }

    public class MyLayoutControlCustomizationController : LayoutControlCustomizationController
    {
        public MyLayoutControlCustomizationController(LayoutControlController controller)
            : base(controller)
        {

        }
        protected override LayoutControlNewItemsInfo GetNewItemsInfo()
        {
            LayoutControlNewItemsInfo itemInfo = base.GetNewItemsInfo();
            itemInfo.Add(new LayoutControlNewItemInfo("Isolated Group Box", MyNewItem.NewCustomGroup));
            return itemInfo;
        }

        protected override FrameworkElement CreateNewItem(LayoutControlNewItemInfo itemInfo)
        {
            if (itemInfo.Data is MyNewItem)
            {
                MyLayoutGroup item = new MyLayoutGroup();
                item.IsIsolatedGroup = true;
                item.Header = itemInfo.Label;
                item.View = LayoutGroupView.GroupBox;
                InitNewItem(item);
                return item;
            }
            return base.CreateNewItem(itemInfo);
        }
    }
}

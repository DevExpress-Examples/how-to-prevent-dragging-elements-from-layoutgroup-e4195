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

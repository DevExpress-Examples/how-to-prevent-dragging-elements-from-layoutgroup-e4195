<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/LayoutCntMoveInGroup/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/LayoutCntMoveInGroup/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/LayoutCntMoveInGroup/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/LayoutCntMoveInGroup/MainWindow.xaml.vb))
* [MyLayoutControl.cs](./CS/LayoutCntMoveInGroup/MyLayoutControl.cs) (VB: [MyLayoutControlCustomizationController.vb](./VB/LayoutCntMoveInGroup/MyLayoutControlCustomizationController.vb))
* [MyLayoutControlController.cs](./CS/LayoutCntMoveInGroup/MyLayoutControlController.cs) (VB: [MyLayoutControlController.vb](./VB/LayoutCntMoveInGroup/MyLayoutControlController.vb))
* [MyLayoutControlCustomizationController.cs](./CS/LayoutCntMoveInGroup/MyLayoutControlCustomizationController.cs) (VB: [MyLayoutControlCustomizationController.vb](./VB/LayoutCntMoveInGroup/MyLayoutControlCustomizationController.vb))
* [MyLayoutGroup.cs](./CS/LayoutCntMoveInGroup/MyLayoutGroup.cs) (VB: [MyLayoutGroup.vb](./VB/LayoutCntMoveInGroup/MyLayoutGroup.vb))
* [MyLayoutItemDragAndDropController.cs](./CS/LayoutCntMoveInGroup/MyLayoutItemDragAndDropController.cs) (VB: [MyLayoutItemDragAndDropController.vb](./VB/LayoutCntMoveInGroup/MyLayoutItemDragAndDropController.vb))
<!-- default file list end -->
# How to prevent dragging elements from LayoutGroup


<p>This example demonstrates how to allow customizing items only inside LayoutGroup. All custom logic is implemented in the LayoutItemDragAndDropController and  LayoutControlController descendants. To allow adding new "isolated groups" to LayoutControl, a LayoutControlCustomizationController descendant was created.</p>

<br/>



' Developer Express Code Central Example:
' How to prevent dragging elements from LayoutGroup
' 
' This example demonstrates how to allow customizing items only inside
' LayoutGroup. All custom logic is implemented in the
' LayoutItemDragAndDropController and LayoutControlController descendants. To
' allow adding new "isolated groups" to LayoutControl, a
' LayoutControlCustomizationController descendant was created.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4195


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.LayoutControl
Imports System.Windows

Namespace LayoutCntMoveInGroup
	Public Enum MyNewItem
		NewCustomGroup
	End Enum

	Public Class MyLayoutControlCustomizationController
		Inherits LayoutControlCustomizationController
		Public Sub New(ByVal controller As LayoutControlController)
			MyBase.New(controller)

		End Sub
		Protected Overrides Function GetNewItemsInfo() As LayoutControlNewItemsInfo
			Dim itemInfo As LayoutControlNewItemsInfo = MyBase.GetNewItemsInfo()
			itemInfo.Add(New LayoutControlNewItemInfo("Isolated Group Box", MyNewItem.NewCustomGroup))
			Return itemInfo
		End Function

		Protected Overrides Function CreateNewItem(ByVal itemInfo As LayoutControlNewItemInfo) As FrameworkElement
			If TypeOf itemInfo.Data Is MyNewItem Then
				Dim item As New MyLayoutGroup()
				item.IsIsolatedGroup = True
				item.Header = itemInfo.Label
				item.View = LayoutGroupView.GroupBox
				InitNewItem(item)
				Return item
			End If
			Return MyBase.CreateNewItem(itemInfo)
		End Function
	End Class
End Namespace

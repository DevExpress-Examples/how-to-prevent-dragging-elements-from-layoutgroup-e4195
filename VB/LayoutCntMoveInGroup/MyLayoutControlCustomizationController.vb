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

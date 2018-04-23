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
Imports DevExpress.Xpf.Core
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core.Native

Namespace LayoutCntMoveInGroup
	Friend Class MyLayoutItemDragAndDropController
		Inherits LayoutItemDragAndDropController
		Public Sub New(ByVal controller As Controller, ByVal startDragPoint As Point, ByVal dragControl As FrameworkElement)
			MyBase.New(controller, startDragPoint, dragControl)
		End Sub
		Private OriginalParent As DependencyObject
		Private OriginalInsertationInfo As LayoutItemInsertionInfo
		Public Overrides Sub StartDragAndDrop(ByVal p As Point)
			OriginalParent = DragControl.Parent
			OriginalInsertationInfo = InsertionInfo
			MyBase.StartDragAndDrop(p)
		End Sub
		Protected Overrides Sub OnInsertionInfoChanged()
			Dim elemPar As MyLayoutGroup = TryCast(OriginalParent, MyLayoutGroup)
			Dim IsSourceIsolated As Boolean = False
			If elemPar IsNot Nothing Then
				IsSourceIsolated = elemPar.IsIsolatedGroup
			End If
			Dim IsTargetIsolated As Boolean = False
			Dim targParent As MyLayoutGroup
			If InsertionInfo.DestinationItem IsNot Nothing Then
				targParent = TryCast(InsertionInfo.DestinationItem.Parent, MyLayoutGroup)
				If targParent IsNot Nothing Then
					IsTargetIsolated = targParent.IsIsolatedGroup
				End If
			End If

			If OriginalParent IsNot Nothing AndAlso InsertionInfo.DestinationItem IsNot Nothing Then
				If OriginalParent IsNot InsertionInfo.DestinationItem.Parent AndAlso (IsSourceIsolated OrElse IsTargetIsolated) Then
					NoIndicator()
					Return
				End If
			End If
			If OriginalParent Is Nothing AndAlso IsTargetIsolated Then
				NoIndicator()
				Return
			End If

			MyBase.OnInsertionInfoChanged()
		End Sub
		Private Sub NoIndicator()
			Indicator.InsertionInfo = OriginalInsertationInfo
			Indicator.SetVisible(OriginalInsertationInfo.DestinationItem IsNot Nothing)
			DestinationGroup = If(InsertionInfo.DestinationItem.IsLayoutGroup(), CType(InsertionInfo.DestinationItem, ILayoutGroup), Nothing)
		End Sub
	End Class

End Namespace

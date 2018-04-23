Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.LayoutControl
Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace LayoutCntMoveInGroup
	Friend Class MyLayoutControlController
		Inherits LayoutControlController
		Public Sub New(ByVal control As ILayoutControl)
			MyBase.New(control)
		End Sub
		Protected Overrides Function CreateItemDragAndDropControler(ByVal startDragPoint As Point, ByVal dragControl As FrameworkElement) As DragAndDropController
			Return New MyLayoutItemDragAndDropController(Me, startDragPoint, dragControl)
		End Function
		Protected Overrides Function CreateCustomizationController() As LayoutControlCustomizationController
			Return New MyLayoutControlCustomizationController(Me)
		End Function
		Public Overrides Sub DropElement(ByVal element As System.Windows.FrameworkElement, ByVal insertionPoint As LayoutItemInsertionPoint, ByVal insertionKind As LayoutItemInsertionKind)
			Dim elemPar As MyLayoutGroup = TryCast(element.Parent, MyLayoutGroup)
			Dim IsSourceIsolated As Boolean = False
			If elemPar IsNot Nothing Then
				IsSourceIsolated = elemPar.IsIsolatedGroup
			End If
			Dim IsTargetIsolated As Boolean = False
			Dim targParent As MyLayoutGroup = TryCast(insertionPoint.Element.Parent, MyLayoutGroup)
			If targParent IsNot Nothing Then
				IsTargetIsolated = targParent.IsIsolatedGroup
			End If

			If element.Parent IsNot Nothing Then
				If element.Parent IsNot insertionPoint.Element.Parent AndAlso (IsSourceIsolated OrElse IsTargetIsolated) Then
					Return
				End If
			End If
			If element.Parent Is Nothing AndAlso IsTargetIsolated Then
				Return
			End If
			MyBase.DropElement(element, insertionPoint, insertionKind)
		End Sub
	End Class
End Namespace

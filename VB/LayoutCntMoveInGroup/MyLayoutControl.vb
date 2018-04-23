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

Namespace LayoutCntMoveInGroup
	Friend Class MyLayoutControl
		Inherits LayoutControl
		Protected Overrides Function CreateController() As DevExpress.Xpf.Core.PanelControllerBase
			Return New MyLayoutControlController(Me)
		End Function

	End Class
End Namespace

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
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows

Namespace LayoutCntMoveInGroup
	''' <summary>
	''' Логика взаимодействия для App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application
	End Class
End Namespace

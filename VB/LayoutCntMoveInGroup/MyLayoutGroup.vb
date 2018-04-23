Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.LayoutControl

Namespace LayoutCntMoveInGroup
	Friend Class MyLayoutGroup
		Inherits LayoutGroup
		Private privateIsIsolatedGroup As Boolean
		Public Property IsIsolatedGroup() As Boolean
			Get
				Return privateIsIsolatedGroup
			End Get
			Set(ByVal value As Boolean)
				privateIsIsolatedGroup = value
			End Set
		End Property
	End Class
End Namespace

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

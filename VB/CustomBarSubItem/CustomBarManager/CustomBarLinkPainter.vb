Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars.Painters
Imports DevExpress.XtraBars.Styles

Namespace CustomBar.CustomBarManager
	Friend Class CustomBarLinkPainter
		Inherits BarCustomContainerLinkPainter
		Public Sub New(ByVal paintStyle As BarManagerPaintStyle)
			MyBase.New(paintStyle)

		End Sub

		Protected Overrides Sub DrawLinkHorizontal(ByVal e As BarLinkPaintArgs)
			Dim item As CustomBarSubItem = TryCast(e.LinkInfo.Link.Item, CustomBarSubItem)
			If item.IsChildItemChecked Then
				MyBase.DrawLinkPressed(e)
			Else
				MyBase.DrawLinkHorizontal(e)
			End If
		End Sub
	End Class
End Namespace

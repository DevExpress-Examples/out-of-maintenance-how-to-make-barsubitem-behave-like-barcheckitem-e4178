Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars
Imports System.ComponentModel
Imports DevExpress.XtraBars.Styles

Namespace CustomBar.CustomBarManager
	Friend Class CustomBarManager
		Inherits BarManager
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)

		End Sub

		Protected Overridable Sub UpdateBarItemInfo()
			For Each ps As BarManagerPaintStyle In GetController().PaintStyles
				If TypeOf ps Is SkinBarManagerPaintStyle Then
					For Each info As BarItemInfo In ps.ItemInfoCollection
						If info.Name = "BarSubItem" Then
							ps.ItemInfoCollection.Add(New BarItemInfo(CustomBarSubItem.BarItemName, CustomBarSubItem.SubBarItemCaption, -1, GetType(CustomBarSubItem), info.LinkType, info.ViewInfoType, New CustomBarLinkPainter(ps), True, False))
							Return
						End If
					Next info
				End If
			Next ps
		End Sub
		Protected Overrides Sub OnLoaded()
			MyBase.OnLoaded()
			UpdateBarItemInfo()
		End Sub

		Private Sub ChildItemChecking(ByVal subItem As CustomBarSubItem)
			subItem.IsChildItemChecked = False
			For i As Integer = 0 To subItem.ItemLinks.Count - 1
				If subItem.ItemLinks(i).GetType() Is GetType(BarCheckItemLink) AndAlso (CType(subItem.ItemLinks(i).Item, BarCheckItem)).Checked Then
					subItem.IsChildItemChecked = True
					Exit For
				End If
			Next i
		End Sub

		Protected Overrides Sub RaiseItemClick(ByVal e As ItemClickEventArgs)
			MyBase.RaiseItemClick(e)
			If e.Link IsNot Nothing AndAlso e.Link.Item.GetType() Is GetType(BarCheckItem) Then
				If e.Link.OwnerItem IsNot Nothing AndAlso e.Link.OwnerItem.GetType() Is GetType(CustomBarSubItem) Then
					ChildItemChecking(CType(e.Link.OwnerItem, CustomBarSubItem))
				End If
			End If
		End Sub
	End Class
End Namespace

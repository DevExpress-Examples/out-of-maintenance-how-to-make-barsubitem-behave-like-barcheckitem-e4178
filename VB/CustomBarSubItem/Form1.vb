Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports CustomBar.CustomBarManager
Imports DevExpress.XtraBars

Namespace CustomBar
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			CustomBarBuilding()
		End Sub

		Public Sub CustomBarBuilding()

			Dim menuCheckItem As New BarCheckItem(customBarManager1, False) With {.Caption = "customCheckItem"}

			Dim subItem As New CustomBarSubItem(customBarManager1, "Menu")

			Dim subMenuCheckItem As New BarCheckItem(customBarManager1, False) With {.Caption = "checkItem1"}
			Dim subMenuCheckItem1 As New BarCheckItem(customBarManager1, False) With {.Caption = "checkItem2"}
			Dim subMenuCheckItem2 As New BarCheckItem(customBarManager1, False) With {.Caption = "checkItem3"}

			subItem.AddItems(New BarItem() { subMenuCheckItem, subMenuCheckItem1, subMenuCheckItem2 })
			bar2.AddItems(New BarItem() { subItem, menuCheckItem })
		End Sub

	End Class
End Namespace

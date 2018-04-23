Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars

Namespace CustomBar.CustomBarManager
	Friend Class CustomBarSubItem
		Inherits BarSubItem

		Public Const BaseBarItemName As String = "BarSubItem"
		Public Const BarItemName As String = "CustomBarCheckSubItem"
		Public Const SubBarItemCaption As String = "CustomBarCheckSubItem"

		Private isChecked As Boolean

		Public Property IsChildItemChecked() As Boolean
			Get
				Return isChecked
			End Get
			Set(ByVal value As Boolean)
				If value <> isChecked Then
					isChecked = value
				End If
			End Set
		End Property

		Public Sub New(ByVal manager As BarManager, ByVal caption As String)
			MyBase.New(manager, caption)
				IsChildItemChecked = False

		End Sub

		Public Sub New(ByVal manager As BarManager, ByVal caption As String, ByVal items() As BarItem)
			MyBase.New(manager, caption, items)

		End Sub

		Public Sub New(ByVal manager As BarManager, ByVal caption As String, ByVal imageIndex As Integer)
			MyBase.New(manager, caption, imageIndex)

		End Sub

		Public Sub New(ByVal manager As BarManager, ByVal caption As String, ByVal imageIndex As Integer, ByVal items() As BarItem)
			MyBase.New(manager, caption, imageIndex, items)

		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomFilterOperationExample
	Friend Class TaskNums
		Private _List As ObservableCollection(Of Task)

		Public ReadOnly Property List() As ObservableCollection(Of Task)
			Get
				If _List Is Nothing Then
					_List = New ObservableCollection(Of Task)()
					For i As Integer = 1 To 19
						If i = 5 Then
							_List.Add(New Task() With {.FirstNum = 10, .SecondNum = 5, .TherdNum = 2})
						Else
							_List.Add(New Task() With {.FirstNum = i * 1, .SecondNum = i * 2, .TherdNum = i * 3})
						End If
					Next i
				End If
				Return _List
			End Get
		End Property

		Public Class Task
			Private privateFirstNum As Integer
			Public Property FirstNum() As Integer
				Get
					Return privateFirstNum
				End Get
				Set(ByVal value As Integer)
					privateFirstNum = value
				End Set
			End Property
			Private privateSecondNum As Integer
			Public Property SecondNum() As Integer
				Get
					Return privateSecondNum
				End Get
				Set(ByVal value As Integer)
					privateSecondNum = value
				End Set
			End Property
			Private privateTherdNum As Integer
			Public Property TherdNum() As Integer
				Get
					Return privateTherdNum
				End Get
				Set(ByVal value As Integer)
					privateTherdNum = value
				End Set
			End Property
		End Class
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Gauges


Namespace SilverlightApplication1
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'			#Region "#SetSymbolSize"
			' Specify fixed values for symbol height and width.
			Dim newWidth As New SymbolLength(SymbolLengthType.Fixed, 44)
			matrixView.Width = newWidth
			Dim newHeight As New SymbolLength(SymbolLengthType.Fixed, 50)
			matrixView.Height = newHeight
'			#End Region ' #SetSymbolSize
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'			#Region "#SetSymbolSize"
			' Specify proportional values for symbol height and width.
			Dim newWidth As New SymbolLength(SymbolLengthType.Proportional, 2)
			matrixView.Width = newWidth
			Dim newHeight As New SymbolLength(SymbolLengthType.Proportional, 5)
			matrixView.Height = newHeight
'			#End Region ' #SetSymbolSize
		End Sub

	End Class
End Namespace

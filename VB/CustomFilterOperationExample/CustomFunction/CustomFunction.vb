Imports Microsoft.VisualBasic
Imports DevExpress.Data.Filtering
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomFilterOperationExample
    Public Class CustomFunction
        Implements ICustomFunctionOperator
        Public Function Evaluate(ParamArray operands As Object()) As Object Implements ICustomFunctionOperator.Evaluate
            Dim result = Convert.ToInt32(operands(0)) / Convert.ToInt32(operands(1))

            If result = Convert.ToInt32(operands(2)) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public ReadOnly Property Name() As String Implements ICustomFunctionOperator.Name
            Get
                Return "Function"
            End Get
        End Property

        Public Function ResultType(ParamArray operands As Type()) As Type Implements ICustomFunctionOperator.ResultType
            Return GetType(Boolean)
        End Function
    End Class
End Namespace

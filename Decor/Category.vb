'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Category
    Public Property categoryId As Integer
    Public Property categoryName As String

    Public Overridable Property ProductTypes As ICollection(Of ProductType) = New HashSet(Of ProductType)

End Class

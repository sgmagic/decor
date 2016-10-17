Imports System.Linq
Public Class ManageUsers
    
    Dim users As User
    Dim roles As Role
    Dim userContext As New DecorDBEntities()

    Function addUser(user As User) As Boolean
        
        Try
            userContext.Users.Add(user)
            userContext.SaveChanges()
    
            Catch ex As Exception   
                return False
         End Try

      Return true

    End Function

    Function editUser(user As User) As Boolean
        Dim users = 
        return true
    End Function

    Function getAllUser() As IList(Of User)

    End Function

End Class

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Module DataTableSerializer
    Public  Function SaveToFile( dataTables() As DataTable,  path As String) As Boolean

        Try
            Using stream = New MemoryStream()
                Dim formatter As Runtime.Serialization.IFormatter = New BinaryFormatter()
                formatter.Serialize(stream, dataTables)
                stream.Close()
                File.WriteAllBytes(path, stream.ToArray())
            End Using

            Return True

        Catch ex As Exception

            Return False

        End Try
    End Function

    Public  Function LoadFromFile( path As String) As DataTable()
        Try
            Dim buffer() As Byte = File.ReadAllBytes(path)
            Dim stream = New MemoryStream(buffer)
            Dim formatter As Runtime.Serialization.IFormatter = New BinaryFormatter()

            Return CType(formatter.Deserialize(stream), DataTable())

        Catch ex As Exception

            Return Nothing

        End Try
    End Function

End Module
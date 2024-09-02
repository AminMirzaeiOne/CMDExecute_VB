Public Class Executor
    Public Async Function ExecuteAsync(userCommand As String) As System.Threading.Tasks.Task
        Try
            Await System.Threading.Tasks.Task.Run(Sub()
                                                      Using cmd As New Process()
                                                          cmd.StartInfo.FileName = "cmd.exe"
                                                          cmd.StartInfo.RedirectStandardInput = True
                                                          cmd.StartInfo.RedirectStandardOutput = True
                                                          cmd.StartInfo.CreateNoWindow = True
                                                          cmd.StartInfo.UseShellExecute = False
                                                          cmd.Start()

                                                          cmd.StandardInput.WriteLine(userCommand)
                                                          cmd.StandardInput.Flush()
                                                          cmd.StandardInput.Close()
                                                          cmd.WaitForExit()
                                                      End Using
                                                  End Sub)
        Catch
            Throw New Exception("Error - The command entered is invalid")
        End Try
    End Function
End Class

# CMDExecute

<h2> 👨‍💻 About Project</h2>
Among the first projects of Amin Mirzaei after learning the basic concepts of Visual Basic <br />
A library for executing command line commands in the Visual Basic programming language <br />

<h2> 🏗 Build Information</h2>
- Made in year = February 2016 <br />
----------------------------------------------- <br />
- .NET Framework =  4.5.1 <br />
- Visual Basic = VB.NET 14.0 <br />
- Micrsoft Visual Studio = VS 2012 <br />


<h2> 📜 Program Rules</h2>
1 - Commands should be just like command line commands<br />

<h2> 💡 Program Help</h2>
1 - Add the library to the project by reference (WinForms - WPF - Console Application)<br />
2 - Import CMDExecute namespace<br />
3 - Create an instance of the Executor class<br />
4 - Call the ExecuteAsync function on the created instance<br />
5 - Give the function a string parameter as a command line command (For example = "start notepad")

<h2>🤔 How to use the library</h2>
1 - Import Namespace<br />

```
+Imports CMDExecute
```

2 - Class Instantiation<br />

```
+Dim ex As Executor = New Executor()
```

3 - Function Call<br />

```
+ex.ExecuteAsync("start notepad")
```

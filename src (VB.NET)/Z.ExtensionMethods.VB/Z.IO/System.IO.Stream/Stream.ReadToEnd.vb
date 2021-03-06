
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Text

Public Module Extensions_797

	''' <summary>
	'''     A Stream extension method that reads a stream to the end.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>
	'''     The rest of the stream as a string, from the current position to the end. If the current position is at the
	'''     end of the stream, returns an empty string ("").
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReadToEnd(this As Stream) As String
		Using sr = New StreamReader(this, Encoding.[Default])
			Return sr.ReadToEnd()
		End Using
	End Function

	''' <summary>
	'''     A Stream extension method that reads a stream to the end.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="encoding">The encoding.</param>
	''' <returns>
	'''     The rest of the stream as a string, from the current position to the end. If the current position is at the
	'''     end of the stream, returns an empty string ("").
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReadToEnd(this As Stream, encoding As Encoding) As String
		Using sr = New StreamReader(this, encoding)
			Return sr.ReadToEnd()
		End Using
	End Function

	''' <summary>
	'''     A Stream extension method that reads a stream to the end.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="position">The position.</param>
	''' <returns>
	'''     The rest of the stream as a string, from the current position to the end. If the current position is at the
	'''     end of the stream, returns an empty string ("").
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReadToEnd(this As Stream, position As Long) As String
		this.Position = position

		Using sr = New StreamReader(this, Encoding.[Default])
			Return sr.ReadToEnd()
		End Using
	End Function

	''' <summary>
	'''     A Stream extension method that reads a stream to the end.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="encoding">The encoding.</param>
	''' <param name="position">The position.</param>
	''' <returns>
	'''     The rest of the stream as a string, from the current position to the end. If the current position is at the
	'''     end of the stream, returns an empty string ("").
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReadToEnd(this As Stream, encoding As Encoding, position As Long) As String
		this.Position = position

		Using sr = New StreamReader(this, encoding)
			Return sr.ReadToEnd()
		End Using
	End Function
End Module



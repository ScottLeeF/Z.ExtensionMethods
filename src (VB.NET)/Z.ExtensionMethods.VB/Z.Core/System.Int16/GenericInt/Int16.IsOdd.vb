
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_252

	''' <summary>
	'''     An Int16 extension method that query if '@this' is odd.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if odd, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsOdd(this As Int16) As Boolean
		Return this Mod 2 <> 0
	End Function
End Module



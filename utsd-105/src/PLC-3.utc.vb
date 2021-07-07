M556 = 0
If P10 = 20 Then
	If M504 = 1 And Q504 = 0 And M180 = 0 Then
		Q504 = 1
		If M131 <> 0 Then
			P0 = 105
			Return
		End If
		If M140 <> 2 Then
			CMD "#1J/"
			M72 = 150
			While M72 > 0
			End While
		End If
		CMD "#1J+"
	End If
	If M504 = 0 And Q504 = 1 Then
		Q504 = 0
		CMD "#1J/"
		While M140 <> 2
		End While
		CMD "K"
	End If
	If M515 = 1 And Q515 = 0 Then
		Q515 = 1
		If M131 <> 0 Then
			P0 = 105
			Return
		End If
		If M140 < 3 Then
			If M140 <> 2 Then
				CMD "#1J/"
				M72 = 150
				While M72 > 0
				End While
			End If
			M163 = P140 * P141
			CMD "#1J:"
			While M140 <> 2
			End While
		End If
	End If
	If M515 = 0 And Q515 = 1 Then
		Q515 = 0
	End If
	If M506 = 1 And Q506 = 0 Then
		Q506 = 1
		If M18 = 0 Then
			P0 = 106
			Return
		End If
		M1 = M1^1
		If M1 = 0 Then
			P122 = 1
		Else
			P122 = 0
		End If
	End If
	If M506 = 0 And Q506 = 1 Then
		Q506 = 0
	End If
	If M1 = 0 And Q1 = 0 Then
		Q1 = 1
	End If
	If M1 = 1 And Q1 = 1 Then
		Q1 = 0
		P122 = 0
	End If
	If M507 = 1 Then
		If M16 = 0 Then
			P0 = 101
			M507 = 0
			Return
		End If
		If M1 <> 0 Then
			If M18 = 0 Then
				P0 = 106
				Return
			End If
			M1 = 0
			P122 = 1
			M76 = 5000
		Else
			If M508 = 0 And M76 < 0 Then
				M508 = 1
			End If
		End If
		M507 = 0
	End If
	If M508 = 1 Then
		M2 = 0
		M75 = 25000
		M508 = 2
	End If
	If M508 = 2 Then
		If M13 = 0 Then
			M2 = 1
			M75 = 5000
			M508 = 3
		End If
		If M75 < 0 Then
			P0 = 108
			M508 = 0
			Return
		End If
	End If
	If M508 = 3 Then
		If M14 = 1 Then
			P122 = 1
			M508 = 0
		End If
		If M75 < 0 Then
			P0 = 109
			M508 = 0
			Return
		End If
	End If
	If M512 = 1 And Q512 = 0 Then
		Q512 = 1
		If M16 = 0 Then
			P0 = 101
			Return
		End If
		M5 = M5^1
	End If
	If M512 = 0 And Q512 = 1 Then
		Q512 = 0
	End If
	If M513 = 1 And Q513 = 0 Then
		Q513 = 1
		M8 = M8^1
	End If
	If M513 = 0 And Q513 = 1 Then
		Q513 = 0
	End If
	If M514 = 1 And Q514 = 0 Then
		Q514 = 1
		M6 = M6^1
	End If
	If M514 = 0 And Q514 = 1 Then
		Q514 = 0
	End If
	If M518 = 1 And Q518 = 0 Then
		Q518 = 1
		If M16 = 0 Then
			P0 = 101
			Return
		End If
		M7 = M7^1
	End If
	If M518 = 0 And Q518 = 1 Then
		Q518 = 0
	End If
Else
	Q504 = 0
	Q505 = 0
	Q506 = 0
	Q512 = 0
	Q513 = 0
	Q514 = 0
	M507 = 0
End If
Return

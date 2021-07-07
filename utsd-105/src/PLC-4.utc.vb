If P135 = 0 Then
	If P1000 > 0 Then
		If Q671 = 0 Then
			M5 = 1
			If M691 <> -1 Then
				If M691 > I117 Then
					CMD "M691 = M691 - I117"
					Q671 = 0.1
				Else
					Q671 = 1
				End If
			End If
		End If
		If Q671 = 0.1 And P1000 <> 5.1 Then
			If M162 < M691 Then
				Q671 = 1
			End If
		End If
		If Q671 = 1 Then
			If M162 > M691 And P1000 <> 5.1 Then
				M691 = -1
				M5 = 0
				Q671 = 2
			End If
		End If
		If Q671 = 2 Then
			If M692 <> -1 Then
				Q671 = 3
			End If
		End If
		If Q671 = 3 Then
			If M162 > M692 Then
				If M691 = -1 Then
					M692 = -1
					Q671 = 0
				Else
					If M691 - M692 > 100 * M191 Then
						M5 = 1
					End If
					M692 = -1
					Q671 = 1
				End If
			End If
		End If
	End If
Else
	If P135 = 1 Then
		M5 = 0
	Else
		M5 = 1
	End If
End If
If P160 <> 0 Then
	If P160 < 3 Then
		If Q8 = 0 Then
			M8 = 0
			P160 = 2.1
			M77 = P117 * 1000
			Q8 = 1
		Else
			If M77 <= 0 Then
				Q8 = 0
				M8 = 1
				P160 = 0
			Else
				If P160 <> 2.1 Then
					Return
				End If
			End If
		End If
	Else
		If Q6 = 0 Then
			M531 = M162
			Q6 = 1
		End If
		If Q6 = 1 Then
			If M162 > M531 + 50 * M191 Then
				M6 = 0
				M8 = 0
				M77 = P117 * 1000
				Q6 = 2
			End If
		End If
		If Q6 = 2 Then
			If M77 <= 0 Then
				M6 = 1
				M8 = 1
				Q6 = 0
				Q8 = 0
				P160 = 0
			End If
		End If
	End If
Else
	Q6 = 0
	Q8 = 0
	M6 = 1
	M8 = 1
End If
If P128 <> 0 Then
	M519 = 1
	If P128 = 1 Then
		If M57 = 1 Then
			If Q57 = 0 Then
				Q57 = 1
				P0 = 104
			End If
		Else
			If Q57 <> 0 Then
				Q57 = 0
			End If
		End If
		If M122 = 1 And M15 = 1 Then
			M47 = 0
			M82 = 2047
		Else
			If M140 > 2 Then
				M47 = 0
				If M168 <= 133 Then
					M82 = (M168 / 133) * 2047
				Else
					M82 = 2047
				End If
			Else
				M47 = 1
			End If
		End If
	Else
		M47 = 1
		Q57 = 0
	End If
	If P128 = 2 Then
		If M53 = 0 Then
			If Q53 = 0 Then
				Q53 = 1
				P0 = 107
			End If
		Else
			If Q53 <> 0 Then
				Q53 = 0
			End If
		End If
		If M54 = 0 Then
			If Q54 = 0 Then
				Q54 = 1
				P0 = 122
			End If
		Else
			If Q54 <> 0 Then
				Q54 = 0
			End If
		End If
		If P100 = 0 Then
			CMD "M40..44 = 1"
		Else
			If M51 = 0 Then
				If Q41 = 0 Then
					Q41 = 1
					If M41 = 1 Then
						Q42 = 1
					Else
						Q53 = 0
						Q54 = 0
						Q42 = 0
						CMD "M40..44 = 1"
					End If
				End If
			Else
				If Q41 <> 0 Then
					Q41 = 0
				End If
			End If
		End If
		If Q42 = 1 Then
			M40 = 1
			M41 = 0
			M42 = 1
			M43 = 1
			M44 = 1
			If M122 = 1 And M15 = 1 And M50 = 0 Then
				M74 = P181
				Q42 = 2
			End If
		End If
		If Q42 = 2 Then
			If M50 = 1 Then
				Q42 = 1
			End If
			If M74 < 0 Then
				M41 = 1
				Q42 = 3
			End If
		End If
		If Q42 = 3 Then
			M40 = 0
			M43 = 0
			M74 = 700
			Q42 = 4
		End If
		If Q42 = 4 Then
			If M74 <= 0 Then
				M44 = 0
				M74 = P146
				Q42 = 5
			End If
		End If
		If Q42 = 5 Then
			If M74 <= 0 Then
				M44 = 1
				M42 = 0
				Q42 = 6
			End If
		End If
		If Q42 = 6 Then
			If M15 = 0 Then
				M40 = 1
				M42 = 1
				Q42 = 7
			End If
		End If
		If Q42 = 7 Then
			If M50 = 1 Then
				M41 = 0
				M43 = 1
			End If
			If M15 = 1 Then
				Q42 = 1
			End If
		End If
	End If
Else
End If
If M519 = 1 Then
	If P1000 > 0 Then
		If M15 = 0 Then
			M7 = 0
		Else
			M7 = 1
		End If
	Else
		M7 = 1
	End If
Else
	M7 = 0
End If
Return

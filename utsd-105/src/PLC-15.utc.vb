While M140 <> 2
End While
If P1000 = 5.1 Then
	Q162 = M162
	CMD "X = (M163 - M611 - Q104) / M191"
	M462 = M162
	Q162 = M162 - Q162
	M611 = M611 + Q162
	M562 = M611
	M530 = 0
	M691 = M611 + Q104 + 100 * M191
	If M612 <> -1 Then
		M612 = M612 + Q162
		If M612 < M611 Then
			M612 = M612 + I117
		End If
		M692 = M612 + Q104 + 200 * M191
	Else
		If M692 <> -1 Then
			M692 = M692 + Q162
		End If
	End If
	If M613 <> -1 Then
		Q602 = 0
		While M(613 + Q602) <> -1 And Q602 <= 26
			CMD "M(613 + Q602) = M(613 + Q602) + Q162"
			If M(613 + Q602) < M611 Then
				CMD "M(613 + Q602) = M(613 + Q602) + I117"
			End If
			Q602 = Q602 + 1
		End While
	End If
	If M641 <> -1 Then
		M641 = M641 + Q162
		If M641 < M611 Then
			M641 = M641 + I117
		End If
	End If
	If M642 <> -1 Then
		M642 = M642 + Q162
		If M642 < M611 Then
			M642 = M642 + I117
		End If
	End If
	If M643 <> -1 Then
		Q602 = 0
		While M(643 + Q602) <> -1 And Q602 <= 26
			CMD "M(643 + Q602) = M(643 + Q602) + Q162"
			If M(643 + Q602) < M611 Then
				CMD "M(643 + Q602) = M(643 + Q602) + I117"
			End If
			Q602 = Q602 + 1
		End While
	End If
	Q122 = 1
	P1000 = 5
End If
If P1000 = 5 Then
	M75 = 20000
	While M13 = 1
		M2 = 0
		If M75 <= 0 Then
			P0 = 108
			P100 = 0
			DISPLC 15
			Return
		End If
	End While
	If M14 = 0 Then
		P0 = 109
		P100 = 0
		DISPLC 15
		Return
	End If
	M2 = 1
	If M162 < Q118 Then
		P160 = 1
	Else
		If M162 - M562 < Q118 Then
			P160 = 2
		Else
			If M612 <> -1 And Q118 > M612 + Q104 - M162 Then
				P160 = 3
			End If
		End If
	End If
	If Q122 = 1 Then
		M530 = 0
		Q122 = 2
	End If
	M76 = 5000
	While M14 = 1
		If M76 <= 0 Then
			P0 = 109
			P100 = 0
			DISPLC 15
			Return
		End If
	End While
	If P100 = 1 Or P100 = 2 Or P100 = 4 Then
		If Q621 = 1 Then
			If P109 = 0 Then
				P151 = P151 + (M162 - M530 - Q108) / M191 * 0.001
			Else
				P151 = P151 + (M162 - M530 - Q108) / M191 * 0.003
			End If
		End If
	End If
	If P100 = 3 Then
		If M535 = 0 Then
			If Q150 < M162 - M530 Then
				If P109 = 0 Then
					P151 = P151 + (M162 - M530 - Q108) / M191 * 0.001
				Else
					P151 = P151 + (M162 - M530 - Q108) / M191 * 0.003
				End If
			End If
		End If
	End If
	If Q621 = 1 Then
		If P100 = 1 Then
			If P147 = 0 Then
				P114 = P114 + 1
			Else
				CMD "P(351 + P115 - 1) = P(351 + P115 - 1) + 1"
				If P(351 + P115 - 1) >= P(3011 + P115 - 1) Then
					P115 = P115 + 1
				End If
			End If
		End If
		If P100 = 2 Then
			CMD "P(351 + P115 - 1) = P(351 + P115 - 1) + 1"
			If P(341 + P115 - 1) > 0 And P(351 + P115 - 1) >= P(341 + P115 - 1) Then
				P0 = 110
				M1 = 1
				M2 = 1
				P100 = 0
				DISPLC 15
				Return
			End If
			P282 = P282 + 1
			If P282 >= P(3011 + P115 - 1) Then
				P115 = P115 + 1
				P282 = 0
			End If
		End If
		If P100 = 4 Then
			P114 = P114 + 1
		End If
		Q621 = 0
	End If
	M530 = M162
	If M501 = 1 Then
		While M11 = 1
		End While
	End If
	If P113 > 0 And P114 >= P113 Then
		While P10 <> 110
			P0 = 110
		End While
		M1 = 1
		M2 = 1
		P100 = 0
		DISPLC 15
		Return
	End If
	P127 = 0
	If P100 = 3 And Q535 = 1 Then
		M535 = 1
		Q535 = 0
	End If
	P1000 = 3
End If
DISPLC 15
Return

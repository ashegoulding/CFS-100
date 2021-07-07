If P1000 = 3 Then
	M562 = M162
	If P147 = 0 Then
		M163 = M162 + Q280 + Q108
		CMD "#1J="
		While M140 <> 2
			If M612 <> -1 Then
				If Q129 < Q138 Or M163 > M612 + Q104 + Q108 Then
					P1000 = 4
					Return
				Else
					If M163 < M562 + Q138 And M163 > M612 + Q104 + Q108 - Q138 Then
						P1000 = 4
						Return
					End If
				End If
			End If
		End While
		If M161 > M163 Then
			P0 = 102
			P190 = 101
			P1000 = 10
			Return
		End If
		Q621 = 1
		P1000 = 5
		ENAPLC 15
	Else
		P1000 = 3.1
	End If
End If
If P1000 = 3.1 Then
	If P(351 + P115 - 1) >= P(3011 + P115 - 1) Then
		P115 = P115 + 1
		If P115 > 10 Then
			P115 = 10
			P0 = 110
			M1 = 1
			M2 = 1
			P100 = 0
			Return
		End If
		If P(3001 + P115 - 1) = 0 Or P(3011 + P115 - 1) = 0 Then
			P0 = 110
			M1 = 1
			M2 = 1
			P100 = 0
			Return
		End If
	End If
	Q107 = Q(301 + P115 - 1)
	If P115 > 5 And P10 = 45 Then
		P0 = 46
	End If
	M163 = M162 + Q107 + Q108
	CMD "#1J="
	While M140 <> 2
		If M612 <> -1 Then
			If Q129 < Q138 Or M163 > M612 + Q104 + Q108 Then
				P1000 = 4
				Return
			Else
				If M163 < M562 + Q138 And M163 > M612 + Q104 + Q108 - Q138 Then
					P1000 = 4
					Return
				End If
			End If
		End If
	End While
	If M161 > M163 Then
		P0 = 102
		P190 = 102
		P1000 = 10
		Return
	End If
	Q621 = 1
	P1000 = 5
	ENAPLC 15
End If
If P1000 = 4 Then
	CMD "#1J+"
	If M612 = -1 Then
		While M612 = -1
		End While
	End If
	If Q122 > 0 Then
		If P109 = 0 Then
			P153 = P153 + P129 * 0.001
		Else
			P153 = P153 + P129 * 0.083
		End If
		If Q129 - M530 > Q150 Then
			If P109 = 0 Then
				P151 = P151 + (Q129 - M530) / M191 * 0.001
			Else
				P151 = P151 + (Q129 - M530) / M191 * 0.003
			End If
		End If
		If P153 >= P151 Then
			P152 = P153 - P151
			P155 = 100 * (P151 / P153)
		End If
	End If
	CMD "M610..639 = M640"
	CMD "M641..669 = -1"
	M691 = M693
	M693 = -1
	M640 = 0
	M163 = 0
	ENAPLC 10
	P1000 = 1
End If
Return

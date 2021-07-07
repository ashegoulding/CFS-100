If P1000 = 3 Then
	M562 = M162
	If Q(301 + P115 - 1) = 0 Or P(3011 + P115 - 1) = 0 Then
		If M505 = 0 Then
			P1000 = 4
			Return
		Else
			P115 = 1
			P282 = 0
		End If
	End If
	If P115 < 6 Then
		P0 = 41
	Else
		P0 = 42
	End If
	M163 = M162 + Q(301 + P115 - 1) + Q108
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
		P190 = 201
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

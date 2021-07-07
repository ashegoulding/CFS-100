If P1000 = 1 Then
	CMD "#1J+"
	While M611 = -1
	End While
	While M162 < M611 + 20 * M191
	End While
	If M612 <> -1 Or M122 = 1 Then
		CMD "M610..639 = M640"
		CMD "M641..669 = -1"
		M691 = M693
		M693 = -1
		M640 = 0
		M163 = 0
		Return
	End If
	P24 = P23
	M690 = M611 + Q104
	M691 = M611 + Q104 + 100 * M191
	M535 = 0
	Q535 = 0
	M562 = M690
	Q600 = 0
	Q621 = 0
	If P100 = 1 Then
		If P147 = 0 Then
			P115 = 1
		End If
	Else
		P115 = 1
	End If
	P282 = 0
	P127 = 0
	Q122 = 0
	If P102 = 0 Then
		M163 = M690 + Q103
		CMD "#1J="
		If P100 = 1 Or P100 = 2 Then
			While M140 <> 2
				If M122 = 1 Or M612 <> -1 Then
					P1000 = 1.1
					Return
				End If
			End While
			If M161 > M163 Then
				P0 = 102
				P190 = 11
				P1000 = 10
				Return
			End If
			P1000 = 5.1
			ENAPLC 15
			DISPLC 10
			Return
		End If
		If P100 = 3 Or P100 = 4 Then
			While M140 <> 2 And M(613 + Q600) = -1
				If M122 = 1 Or M612 <> -1 Then
					P1000 = 1.1
					Return
				End If
			End While
			If M(613 + Q600) <> -1 Then
				If M(613 + Q600) < M611 Then
					CMD "M(613 + Q600) = M(613 + Q600) + I117"
				End If
				Q163 = M(613 + Q600) + Q105
				If P100 = 3 Then
					Q107 = Q150
				Else
					If Q281 < Q150 Then
						Q107 = Q281
					Else
						Q107 = Q150
					End If
				End If
				If M163 > Q163 - Q107 Then
					M163 = M(613 + Q600) + Q105
					Q600 = Q600 + 1
					CMD "#1J="
					While M140 <> 2
					End While
					If M161 > M163 Then
						P0 = 102
						P190 = 12
						P1000 = 10
						Return
					End If
				End If
			End If
			If P100 = 3 And P137 = 2 And P292 > 0 And P139 > 0 Then
				If M(613 + Q600) <> -1 And M(613 + Q600) + Q105 - M163 <= Q139 Then
					Q600 = Q600 + 1
					M535 = 1
				End If
			End If
			P1000 = 5.1
			ENAPLC 15
			DISPLC 10
			Return
		End If
	Else
		If P100 = 1 Or P100 = 2 Then
			If P100 = 1 Then
				If P147 = 0 Then
					Q107 = Q280
				Else
					Q107 = Q(301 + P115 - 1)
				End If
			Else
				Q107 = Q(301 + P115 - 1)
			End If
			M163 = M690 + Q107 + Q108
			CMD "#1J="
			Q621 = 1
			While M140 <> 2
				If M612 <> -1 Then
					If Q129 < Q138 Or M163 > M612 + Q104 + Q108 Then
						P1000 = 1.2
						Return
					Else
						If M163 < M562 + Q138 And M163 > M612 + Q104 + Q108 - Q138 Then
							P1000 = 1.2
							Return
						End If
					End If
				End If
			End While
			If M161 > M163 Then
				P0 = 102
				P190 = 13
				P1000 = 10
				Return
			End If
			P1000 = 5.1
			ENAPLC 15
			DISPLC 10
			Return
		Else
			If P100 = 3 Then
				While M(613 + Q600) = -1
					If M140 = 2 Then
						CMD "#1J+"
					End If
					If M612 <> -1 Then
						P1000 = 1.2
						Return
					End If
				End While
				If M(613 + Q600) < M611 Then
					CMD "M(613 + Q600) = M(613 + Q600) + I117"
				End If
				M163 = M(613 + Q600) + Q105
				Q600 = Q600 + 1
				CMD "#1J="
				While M140 <> 2
				End While
				If M161 > M163 Then
					P0 = 102
					P190 = 14
					P1000 = 10
					Return
				End If
				If P137 = 2 And P292 > 0 And P139 > 0 Then
					If M(613 + Q600) <> -1 And M(613 + Q600) + Q105 - M163 <= Q139 Then
						Q600 = Q600 + 1
						Q535 = 1
					End If
				End If
				P1000 = 5.1
				ENAPLC 15
				DISPLC 10
				Return
			Else
				M163 = M690 + Q281 + Q108
				CMD "#1J="
				Q621 = 1
				While M140 <> 2 And M(613 + Q600) = -1
					If M612 <> -1 Then
						If Q129 < Q138 Or M163 > M612 + Q104 + Q108 Then
							P1000 = 1.2
							Return
						Else
							If M163 < M562 + Q138 And M163 > M612 + Q104 + Q108 - Q138 Then
								P1000 = 1.2
								Return
							End If
						End If
					End If
				End While
				If M140 = 2 Then
					If M161 > M163 Then
						P0 = 102
						P190 = 15
						P1000 = 10
						Return
					End If
					P1000 = 5.1
					ENAPLC 15
					DISPLC 10
					Return
				End If
				If M(613 + Q600) <> -1 Then
					If M(613 + Q600) < M611 Then
						CMD "M(613 + Q600) = M(613 + Q600) + I117"
					End If
					If Q123 = 0 Then
						Q163 = M(613 + Q600) + Q105
					Else
						Q163 = M(613 + Q600) + Q105 - Q123
					End If
					If M163 > Q163 Then
						M163 = M(613 + Q600) + Q105
						Q600 = Q600 + 1
						Q621 = 0
						CMD "#1J="
						Q621 = 0
						While M140 <> 2
						End While
						If M161 > M163 Then
							P0 = 102
							P190 = 16
							P1000 = 10
							Return
						End If
					End If
				End If
				P1000 = 5.1
				ENAPLC 15
				DISPLC 10
				Return
			End If
		End If
	End If
End If
If P1000 = 1.1 Then
	While M140 <> 2
		If M612 <> -1 Or M122 = 1 Then
			If M612 <> -1 Then
				I181 = 2
				M5 = 1
				CMD "M610..639 = M640"
				CMD "M641..669 = -1"
				M691 = M693
				M693 = -1
				M640 = 0
				CMD "#1J+"
				P1000 = 1
				Return
			Else
				If M162 - M611 < 150 * M191 Then
					I181 = 2
					M5 = 1
					CMD "M610..639 = M640"
					CMD "M641..669 = -1"
					M691 = M693
					M693 = -1
					M640 = 0
					CMD "#1J+"
					P1000 = 1
					Return
				End If
			End If
		End If
	End While
	P1000 = 5.1
	ENAPLC 15
	DISPLC 10
End If
If P1000 = 1.2 Then
	CMD "#1J+"
	If P109 = 0 Then
		P153 = P153 + P129 * 0.001
	Else
		P153 = P153 + P129 * 0.083
	End If
	If P129 > P150 Then
		If P109 = 0 Then
			P151 = P151 + P129 * 0.001
		Else
			P151 = P151 + P129 * 0.003
		End If
	End If
	If P153 >= P151 Then
		P152 = P153 - P151
		P155 = 100 * (P151 / P153)
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

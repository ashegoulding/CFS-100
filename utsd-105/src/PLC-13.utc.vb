If P1000 = 3 Then
	M562 = M162
	If P137 = 2 And P139 <> 0 And P292 <> 0 Then
		If M535 = 1 Then
			M163 = M162 + Q292 + Q108
			CMD "#1J="
		Else
			CMD "#1J+"
		End If
		While M140 <> 2 And M(613 + Q600) = -1 And M612 = -1
		End While
		If M140 = 2 Then
			If M161 > M163 Then
				P0 = 102
				P190 = 301
				P1000 = 10
				Return
			End If
			P1000 = 5
			ENAPLC 15
			Return
		End If
		If M(613 + Q600) <> -1 Then
			If M(613 + Q600) < M611 Then
				CMD "M(613 + Q600) = M(613 + Q600) + I117"
			End If
			If M535 = 1 Then
				If M163 > M(613 + Q600) + Q105 Then
					M163 = M(613 + Q600) + Q105
					Q600 = Q600 + 1
					M535 = 0
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
						P190 = 302
						P1000 = 10
						Return
					End If
					If M535 = 0 And M(613 + Q600) <> -1 And M162 > M(613 + Q600) + Q105 - Q139 Then
						Q600 = Q600 + 1
						M535 = 1
					End If
					P1000 = 5
					ENAPLC 15
					Return
				Else
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
					P1000 = 5
					ENAPLC 15
					Return
				End If
			Else
				M163 = M(613 + Q600) + Q105
				Q600 = Q600 + 1
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
					P190 = 303
					P1000 = 10
					Return
				End If
				If M(613 + Q600) <> -1 And M162 > M(613 + Q600) + Q105 - Q139 Then
					Q600 = Q600 + 1
					Q535 = 1
				End If
				P1000 = 5
				ENAPLC 15
				Return
			End If
		Else
			If M535 = 1 Then
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
				P1000 = 5
				ENAPLC 15
				Return
			Else
				P1000 = 4
				Return
			End If
		End If
	Else
		CMD "#1J+"
		While M(613 + Q600) = -1
			If M612 <> -1 Then
				P1000 = 4
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
			P190 = 304
			P1000 = 10
			Return
		End If
		P1000 = 5
		ENAPLC 15
	End If
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
		If M535 = 0 Then
			If Q129 - M530 > Q150 Then
				If P109 = 0 Then
					P151 = P151 + (Q129 - M530) / M191 * 0.001
				Else
					P151 = P151 + (Q129 - M530) / M191 * 0.003
				End If
			End If
		End If
		If P153 >= P151 Then
			P152 = P153 - P151
			P155 = 100 * (P151 / P153)
		Else
			If M122 = 1 And P1000 = 1 Then
				P151 = P153
			End If
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

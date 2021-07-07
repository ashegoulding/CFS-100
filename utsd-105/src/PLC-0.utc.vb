M462 = M162
If M128 = 1 And Q128 = 0 Then
	Q128 = 1
End If
If Q128 = 1 Then
	If M128 = 0 Then
		Q128 = 0
		If I181 = 2 Then
			If M122 = 0 Then
				If M611 = -1 Then
					M611 = M160
					M610 = 0
				Else
					M641 = M160
					M640 = 0
				End If
				I181 = 10
			End If
		Else
			If M122 = 1 Then
				If M612 = -1 Then
					M612 = M160 + Q119
					M692 = M612 + Q104 + 200 * M191
					If M611 > M612 Then
						Q129 = M612 + I117 - M611
					Else
						Q129 = M612 - M611
					End If
					If P109 = 0 Then
						P129 = Q129 / M191
					Else
						P129 = Q129 / M191 * 0.039
					End If
					If Q129 < 100 And P1000 < 10 Then
						CMD "M611..639 = -1"
						M610 = 0
						I181 = 2
						Return
					End If
					If P130 > 0 And P100 > 2 Then
						If M610 = 0 Then
							CMD "M(613 + M610) = M612 - Q130 - (Q105 - Q104)"
							M610 = M610 + 1
						Else
							If M610 > 0 And M612 - M(613 + M610 - 1) > 175 * M191 Then
								CMD "M(613 + M610) = M612 - Q130 - (Q105 - Q104)"
								M610 = M610 + 1
							End If
						End If
					End If
				Else
					If M642 < M641 Then
						M642 = M642 + I117
					End If
					M642 = M160 + Q119
					M694 = M642 + Q104 + 200 * M191
					Q129 = (M642 - M641) * Q191
					If P109 = 0 Then
						P129 = Q129 / M191
					Else
						P129 = Q129 / M191 * 0.039
					End If
					If Q129 < 100 Then
						CMD "M641..669 = -1"
						M640 = 0
						I181 = 2
						Return
					End If
					If P130 > 0 And P100 > 2 Then
						If M610 = 0 Then
							CMD "M(613 + M610) = M612 - Q130 - (Q105 - Q104) + Q108"
							M610 = M610 + 1
						Else
							If M610 > 0 And M612 - M(613 + M610 - 1) > 175 * M191 Then
								CMD "M(613 + M610) = M612 - Q130 - (Q105 - Q104) + Q108"
								M610 = M610 + 1
							End If
						End If
					End If
				End If
				I181 = 2
			End If
		End If
	Else
		Q106 = M106
	End If
End If
If M428 = 1 Then
	While M428 = 1
		Q406 = M406
	End While
	If P100 = 3 Or P100 = 4 Then
		If I181 = 10 Then
			If M612 = -1 Then
				If P137 = 1 And P100 = 3 And P126 <> 0 Then
					If M(613 + M610 - 1) >= M460 Then
						CMD "M(613 + M610 - 1) = M460"
						CMD "M(613 + M610) = M460 + Q126 + Q108"
						M610 = M610 + 1
					Else
						CMD "M(613 + M610) = M460"
						M610 = M610 + 1
						CMD "M(613 + M610) = M460 + Q126 + Q108"
						M610 = M610 + 1
					End If
				Else
					CMD "M(613 + M610) = M460"
					M610 = M610 + 1
				End If
			Else
				If P137 = 1 And P100 = 3 And P126 <> 0 Then
					If M(643 + M640 - 1) >= M460 Then
						CMD "M(643 + M640 - 1) = M460"
						CMD "M(643 + M640) = M460 + Q126 + Q108"
						M640 = M640 + 1
					Else
						CMD "M(643 + M640) = M460"
						M640 = M640 + 1
						CMD "M(643 + M640) = M460 + Q126 + Q108"
						M640 = M640 + 1
					End If
				Else
					CMD "M(643 + M640) = M460"
					M640 = M640 + 1
				End If
			End If
		End If
	End If
End If
If P100 <> 0 And P1000 <> 0 Then
	If M146 = 1 Then
		If Q146 = 0 Then
			M550 = M162
			Q146 = 1
		End If
		If Q146 = 1 Then
			If M162 - M550 > 20 * M191 Then
				P0 = 102
				CMD "K"
				Return
			End If
		End If
	Else
		Q146 = 0
	End If
End If
Return

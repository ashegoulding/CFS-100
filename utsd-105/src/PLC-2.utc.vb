If M11 = 0 And M12 = 0 Then
	If Q11 = 0 Then
		Q11 = 1
		If P100 = 0 Then
			ENAPLC 9
		End If
	End If
Else
	If Q11 <> 0 Then
		Q11 = 0
	End If
End If
If M12 = 1 Or M554 = 1 Then
	If Q12 = 0 Then
		Q12 = 1
		Q552 = 0
		M528 = 0
		M547 = 0
		DISPLC 0, 4, 5, 6, 9, 10, 11, 12, 13, 14, 15
		P100 = 0
		P116 = 0
		P1000 = 0
		M2 = 1
		If M14 = 1 Then
			M72 = 2000
			While M14 = 1 And M72 > 0
			End While
			If M72 <= 0 Then
				P0 = 109
			End If
		End If
		M1 = 1
		M5 = 1
		M6 = 1
		M7 = 1
		M8 = 1
		CMD "M40..47 = 1"
		M528 = 0
		If M140 > 0 Then
			CMD "#1J/"
			M72 = 150
			While M72 > 0
			End While
			CMD "#1K"
		End If
	End If
Else
	If Q12 <> 0 Then
		Q12 = 0
	End If
End If
If M520 = 1 Then
	If Q520 = 0 Then
		Q520 = 1
		If P110 < 100 Then
			P110 = P110 + 10
		Else
			If P110 > 100 Then
				P110 = 100
			End If
		End If
	End If
Else
	If Q520 <> 0 Then
		Q520 = 0
	End If
End If
If M521 = 1 Then
	If Q521 = 0 Then
		Q521 = 1
		If P110 > 0 Then
			P110 = P110 - 10
		Else
			If P110 < 0 Then
				P110 = 0
			End If
		End If
	End If
Else
	If Q521 <> 0 Then
		Q521 = 0
	End If
End If
If M556 = 0 Then
	M197 = P110 * 0.01
Else
	M197 = 0
	If M556 = 1 Then
		M556 = 2
	End If
End If
If P99 <> 0 Then
	If P99 = 1 Then
		If P147 = 0 Then
			P0 = 40
		Else
			P0 = 45
		End If
	End If
	If P99 = 2 Then
		If P100 <> 0 Then
			If P100 = 2 Then
				If P115 < 6 Then
					P0 = 41
				Else
					P0 = 42
				End If
			Else
				If P115 < 6 Then
					P0 = 45
				Else
					P0 = 46
				End If
			End If
		End If
		P0 = 41
	End If
	If P99 = 3 Then
		P0 = 43
	End If
	If P99 = 4 Then
		P0 = 44
	End If
	If P99 > 20 Then
		If P99 = 5687 Then
			P0 = 3
		Else
			If P99 = 25226150 Then
				P0 = 12
			Else
				P0 = 38
			End If
		End If
	End If
	P99 = 0
End If
If P100 <> 0 Then
	M4 = 1
	If M0&512 = 0 Then
		M3 = 0
	Else
		M3 = 1
	End If
	DISPLC 3
	Q100 = 1
Else
	If Q100 = 1 Then
		Q100 = 0
		P1000 = 0
		CMD "M932..947 = 1"
		M2 = 1
		If M14 = 1 Then
			M72 = 2000
			While M14 = 1 And M72 > 0
			End While
			If M72 <= 0 Then
				P0 = 109
			End If
		End If
		M1 = 1
		M5 = 1
		M6 = 1
		M7 = 1
		M8 = 1
		DISPLC 0, 4, 5, 6, 10, 11, 12, 13, 14, 15
		If M140 > 0 Then
			CMD "#1J/"
			M72 = 150
			While M72 > 0
			End While
			CMD "#1K"
		End If
	End If
	If P10 <> 20 Then
		M1 = 1
		M2 = 1
	End If
	If P10 > 100 And P10 < 200 Then
		M554 = 1
		M3 = 1
		If M0&512 = 0 Then
			M4 = 0
		Else
			M4 = 1
		End If
	Else
		M554 = 0
		M3 = 1
		M4 = 0
	End If
	If P10 = 20 Then
		ENAPLC 3
	Else
		DISPLC 3
	End If
	If M551 = 1 Then
		CMD "P351..360 = 0"
		P115 = 0
		M551 = 0
	End If
	If M553 = 1 Then
		CMD "P341..360 = 0"
		CMD "P3001..3020 = 0"
		P115 = 0
		M553 = 0
	End If
	If M557 = 1 Then
		P280 = 0
		P281 = 0
		P113 = 0
		P114 = 0
		P123 = 0
		CMD "P341..360 = 0"
		CMD "P3001..3020 = 0"
		CMD "P3501..3700 = 0"
		CMD "P3701..3900 = 0"
		P115 = 0
		P0 = 602
		M557 = 0
	End If
	If M522 = 1 Then
		M71 = 3000
		While M71 > 0
			If M522 = 0 Then
				Return
			End If
		End While
		M522 = 0
		CMD "$$$"
	End If
	P116 = 0
	Q621 = 0
	Q100 = 0
End If
If M516 = 1 Then
	P151 = 0
	P152 = 0
	P153 = 0
	P154 = 0
	P155 = 0
	M516 = 0
	P0 = 21
End If
If P137 <> 0 Then
	If P137 = 1 Then
		M532 = 0
		M524 = 1
	Else
		M524 = 0
		M532 = 1
	End If
Else
	M524 = 0
	M532 = 0
	P126 = 0
End If
If M16 = 0 Then
	If Q16 = 0 Then
		Q16 = 1
		P0 = 101
	End If
Else
	If Q16 <> 0 Then
		Q16 = 0
	End If
End If
If M18 = 0 Then
	If Q18 = 0 Then
		Q18 = 1
		P0 = 106
	End If
Else
	If Q18 <> 0 Then
		Q18 = 0
	End If
End If
If M131 <> 0 And Q131 = 0 Then
	Q131 = 1
	M129 = 1
	P0 = 105
	Q124 = M150 * 1 + M151 * 2 + M152 * 3 + M153 * 4 + M154 * 5
	Q125 = M155 * 6 + M156 * 7 + M157 * 8 + M158 * 9
	P124 = Q124 + Q125
End If
If M131 = 0 And Q131 = 1 Then
	Q131 = 0
	M129 = 0
End If
If P165 <> 0 Then
	If P100 = 0 Then
		If P165 = 5687 Then
			P0 = 20
		Else
			P0 = 112
		End If
	Else
		P0 = 113
	End If
	P165 = 0
End If
If M524 = 0 Then
	M525 = 0
	M526 = 0
Else
	If P109 = 0 Then
		M525 = 1
		M526 = 0
	Else
		M525 = 0
		M526 = 1
	End If
End If
If M532 = 0 Then
	M533 = 0
	M534 = 0
Else
	If P109 = 0 Then
		M533 = 1
		M534 = 0
	Else
		M533 = 0
		M534 = 1
	End If
End If
If P146 = 1 Then
	If M23 = 1 Then
		If Q23 = 0 Then
			Q23 = 1
			P0 = 107
		End If
	Else
		If Q23 <> 0 Then
			Q23 = 0
		End If
	End If
End If
If M548 = 1 Then
	If Q548 = 0 Then
		P0 = 30
		Q548 = 1
	End If
Else
	If Q548 <> 0 Then
		Q548 = 0
	End If
	M549 = 0
	Q549 = 0
End If
If M549 = 1 Then
	If Q549 = 0 Then
		P114 = 0
		P151 = 0
		P152 = 0
		P153 = 0
		P156 = 0
		P157 = 0
		P158 = 0
		CMD "P351..360 = 0"
		CMD "P401..430 = 0"
		CMD "P451..480 = 0"
		CMD "P501..530 = 0"
		CMD "P551..580 = 0"
		Q549 = 1
	End If
	If M1 = 0 And P100 > 0 Then
		If Q549 = 1 Then
			Q549 = 2
		End If
	Else
		If Q549 > 1 Then
			Q549 = 1
		End If
	End If
	If Q549 = 2 Then
		M78 = 1000
		Q549 = 3
	End If
	If Q549 = 3 Then
		If M78 <= 0 Then
			P158 = P158 + 1
			If P158 >= 60 Then
				P157 = P157 + 1
				P158 = 0
			End If
			If P157 >= 60 Then
				P156 = P156 + 1
				P157 = 0
			End If
			Q549 = 2
		End If
		If M1 <> 0 Or P100 = 0 Then
			If Q549 > 1 Then
				Q549 = 1
			End If
		End If
	End If
	If P10 = 31 Then
		P450 = 1
	Else
		If P10 = 32 Then
			P450 = 2
		Else
			If P10 = 33 Then
				P450 = 3
			Else
				If P10 = 34 Then
					P450 = 4
				Else
					If P10 = 35 Then
						P450 = 5
					Else
						If P10 = 36 Then
							P450 = 6
						End If
					End If
				End If
			End If
		End If
	End If
	If Q552 = 1 Then
		If M552 = 0 Then
			Q552 = 0
			If P10 = 31 Then
				P450 = 1
				P3501 = P280
				P3701 = P114
				CMD "P3502..3700 = 0"
				CMD "P3702..3900 = 0"
			End If
			If P10 = 32 Then
				P450 = 2
				CMD "P3501..3510 = P3001"
				CMD "P3701..3710 = P351"
				CMD "P3511..3700 = 0"
				CMD "P3711..3900 = 0"
			End If
			If P10 = 33 Then
				P450 = 3
				CMD "P3501..3510 = P3001"
				CMD "P3701..3710 = P351"
				CMD "P3511..3700 = 0"
				CMD "P3711..3900 = 0"
			End If
			If P10 = 34 Then
				P450 = 4
				CMD "P3501..3700 = 0"
				CMD "P3701..3900 = 0"
			End If
			If P10 = 35 Then
				P450 = 5
				P3501 = P281
				P3701 = P114
				CMD "P3502..3700 = 0"
				CMD "P3702..3900 = 0"
			End If
			If P10 = 36 Then
				P450 = 6
				CMD "P3501..3700 = P3101"
				CMD "P3701..3900 = P3301"
			End If
			M552 = 1
		End If
	End If
Else
	If Q549 <> 0 Then
		Q549 = 0
	End If
End If
If P128 <> 0 Then
	Q519 = 1
Else
	Q519 = 0
End If
Return

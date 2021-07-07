M530 = 0
Q191 = 1 / M191
Q6 = 0
Q8 = 0
Q600 = 0
Q671 = 0
Q42 = 0
I281 = 2
P115 = 0
P127 = 0
P129 = 0
P136 = 0
P160 = 0
M160 = 0
M260 = 0
M460 = 0
M535 = 0
M556 = 0
CMD "M40..47 = 1"
CMD "P142..145 = 0"
CMD "M542..545 = -1"
CMD "M610..699 = -1"
M610 = 0
M640 = 0
CMD "M691..904 = -1"
If M131 <> 0 Then
	P0 = 105
	DISPLC 9
	Return
End If
If M13 <> 1 Then
	P0 = 108
	DISPLC 9
	Return
End If
If M14 <> 0 Then
	P0 = 109
	DISPLC 9
	Return
End If
If M16 = 0 Then
	P0 = 101
	DISPLC 9
	Return
End If
If M18 = 0 Then
	P0 = 106
	DISPLC 9
	Return
End If
If M21 = 0 Then
	P0 = 121
	DISPLC 9
	Return
End If
If P128 <> 0 Then
	If P128 = 1 Then
		If M57 = 1 Then
			P0 = 104
			DISPLC 9
			Return
		End If
	End If
	If P128 = 2 Then
		If M53 = 0 Then
			P0 = 107
			DISPLC 9
			Return
		End If
		If M54 = 0 Then
			P0 = 122
			DISPLC 9
			Return
		End If
	End If
End If
If P147 = 0 Then
	If P10 = 40 Then
		If P280 = 0 Then
			P0 = 103
			DISPLC 9
			Return
		End If
		If P113 > 0 And P114 >= P113 Then
			P0 = 110
			DISPLC 9
			Return
		End If
		P100 = 1
		ENAPLC 11
	End If
Else
	If P10 = 45 Or P10 = 46 Then
		If P(3001) = 0 Or P(3011) = 0 Then
			P0 = 103
			DISPLC 9
			Return
		End If
		P115 = 1
		While P(3011 + P115 - 1) <= P(351 + P115 - 1)
			If P(3001 + P115 - 1) = 0 Or P(3011 + P115 - 1) = 0 Then
				P0 = 110
				DISPLC 9
				Return
			End If
			P115 = P115 + 1
			If P115 > 10 Then
				P0 = 110
				DISPLC 9
				Return
			End If
		End While
		If P115 > 5 Then
			P0 = 46
		Else
			P0 = 45
		End If
		P100 = 1
		ENAPLC 11
	End If
End If
If P10 = 41 Or P10 = 42 Then
	If P(3001) = 0 Or P(3011) = 0 Then
		P0 = 103
		DISPLC 9
		Return
	Else
		P0 = 41
		P100 = 2
		ENAPLC 12
	End If
End If
If P10 = 43 Then
	P100 = 3
	ENAPLC 13
End If
If P10 = 44 Then
	If P281 = 0 Then
		P0 = 103
		DISPLC 9
		Return
	End If
	If P113 <> 0 And P113 <= P114 Then
		P0 = 110
		DISPLC 9
		Return
	End If
	P100 = 4
	ENAPLC 14
End If
If P100 = 0 Then
	P0 = 111
	DISPLC 9
	Return
End If
M1 = 0
CMD "K"
CMD "A"
ENAPLC 4
M71 = 5000
While M71 > 0
	If M12 = 1 Then
		M1 = 1
		DISPLC 9
		Return
	End If
End While
CMD "#1HMZ#4HMZ"
M462 = M162
I101 = P161
CMD "#1J+"
If M122 = 0 Then
	I181 = 10
	While M122 = 0
	End While
	While M128 <> 0
		Q106 = M106
	End While
	M612 = M160 + Q119
	M5 = 0
	M692 = M612 + Q104 + 200 * M191
	While M162 < M692
	End While
	M5 = 1
End If
If M128 <> 0 Or M428 <> 0 Then
	While M128 <> 0 Or M428 <> 0
		Q106 = M106
		Q406 = M406
	End While
End If
I181 = 2
P1000 = 1
ENAPLC 0, 10
DISPLC 9
Return

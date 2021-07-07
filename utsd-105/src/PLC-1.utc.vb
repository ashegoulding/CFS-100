DISPLC 0, 2, 3, 4, 5, 6, 9, 10, 11, 12, 13, 14, 15
I10 = 1
M1 = 1
M2 = 1
M5 = 1
M6 = 1
M7 = 1
M8 = 1
CMD "M40..47 = 1"
Q11 = 0
Q12 = 0
Q16 = 0
Q18 = 0
Q131 = 0
Q123 = 0
Q552 = 0
Q903 = 0
Q904 = 0
Q907 = 0
M516 = 0
M522 = 0
P0 = 1
P100 = 0
P127 = 0
P129 = 0
P136 = 0
P1000 = 0
Q148 = P148
If M170 >= 3.1 Then
	I480 = 4
Else
	I480 = 0
End If
CMD "K"
M71 = 5000
While M71 > 0
End While
P0 = 2
ENAPLC 2
DISPLC 1
Return

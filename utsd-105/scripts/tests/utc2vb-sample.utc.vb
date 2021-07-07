' Ordinary comment line

' Don't pad operators that are already padded
P1 = P1 + 1
P1= P1 +1 ' Even if it's weird

' Normal arithmetics
P123 = Q500 + I70 + 1 / 2
P123 = Q500 * I70 + 420.0 + 99.9
P123 = Q500 / I70 + 12 + 0.0

' Format CMD calls as well
CMD "P0..P42 = 9 * M1 + 2"

' Calculated indices
' For-loop using while
Q0 = 0
Q1 = 0
While Q0 < 10
	' Run this block 10 times
	M(100 + Q0) = Q1
	Q1 = Q1 + Q0
	Q0 = Q0 + 1
End While

If M1 = 0 Or M2 = 1 Then
End If

If P0 = 1 AND P1 = 100 Then
	CMD "#1J+"
Else
	CMD "K"
End If

While M1 = 1
	M2 = 1000
	While M2 > 0
		If P3 = 3 Then		' Comment after statement
			DISPLC 1			' Disable PLC program #1
		End If
	End While
End While

		' Leading/trailing whitespaces preserved for comment lines
		'                            |
		'                           / \
		'                          /   \
		'                         /     \
		'                        /       \
		'                       /         \
		'                       ----|@|----
		'                           |@|

Return ' End of program

# UTSD-105 Notes
## Carriage Return Translation
**icrnl** works but **onlret** doesn't. How strange. Just use `unix2mac` to save
troubles.

```sh
# Set up for COM2
stty -F /dev/ttyUSB0 19200 cs8 -parenb -cstopb raw

# This is how you command the PLC
echo 'SOME COMMAND' | unix2dos > /dev/ttyUSB0
# This is how you receive from the PLC
mac2unix /dev/ttyUSB0
# Or just dump it into a file for later review
# Text editor will take care of the line endings
cat /dev/ttyUSB0 | tee some_file | mac2unix
```

## Useful Online Commands
**NOTE**: this is CFS-100 specific. Other users applications might use all the
features of UTSD-105.

```
echo 'VER' | unix2dos > /dev/ttyUSB0
echo -e "\\x07"  | unix2dos > /dev/ttyUSB0
echo `SIZE`  | unix2dos > /dev/ttyUSB0

echo 'I0..499' | unix2dos > /dev/ttyUSB0
echo 'P0..1023' | unix2dos > /dev/ttyUSB0
echo 'Q0..1023' | unix2dos > /dev/ttyUSB0
echo 'M0..M1023->' | unix2dos > /dev/ttyUSB0

echo 'LIST PROG' | unix2dos > /dev/ttyUSB0
echo 'LIST PLC' | unix2dos > /dev/ttyUSB0
echo 'LIST CAM' | unix2dos > /dev/ttyUSB0
```

* `??` command
  * Returns: `80C001000002`
  * This is a 48 bit unsigned integer. Refer to the reference manual for bit
    fields
* `???` command
  * Returns: `$8000010F`
  * This is a 32 bit unsigned integer. Refer to the reference manual for bit
    fields

## OEM Software Analysis
```sh
strings UTCPanel+.exe | grep -i saving
```

Yields ...

```
Saving I-Variables (
Saving P-Variables (
Saving Q-Variables (
Saving M-Definitions (
Saving Motion Programs (
Saving PLC Programs (
Saving Gathered Data (
Saving CAM Table
Saving Specified Memory Data (
```

## Syntax Highlighting of PLC Code
Visual Basic seems to be the closest relative to the "UTC Programming Language".
So ".utc.vb" has been chosen for the extension of the PLC source code files. And
the abbreviated keywords used in the code can be replaced with the VB equivalent
for better readability. See **[utrend-utc2vb](scripts/utrend-utc2vb)** for more.

![Comparison of raw PLC code and PLC code converted to VB using
utrend-utc2vb](img/utc2vb-syntax-highlight.png)

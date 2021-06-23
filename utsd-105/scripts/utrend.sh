IO_TIMEOUT=0.5
declare SERIAL

utr_rdl () {
	local timeo

	if [ -z "$2" ]; then
		IOeo="$RDL_TIMEOUT"
	else
		timeo="$2"
	fi
	read -t "$timeo" -r < "$SERIAL" $1
}

utr_wrl () {
	# TODO: use $IO_TIMEOUT ??
	echo -ne "$1\\r" > "$SERIAL"
}

utr_sync () {
	echo -ne \\x18 > "$SERIAL"
	sleep 0.5
	while true; do
		unset line
		utr_rdl line 0
		if [ -z "$line" ]; then
			break
		fi
	done
}

utr_ayt () {
	utr_sync

	echo -ne \\x07 > "$SERIAL"
	unset line
	utr_rdl line

	[ 11 -lt ${#line} ] && [ ${#line} -lt 15 ] && return true
	return false
}

utr_perr () {
	echo "$1" >&2
}

utr_report () {
	echo "$1" >&2
}

utr_die () {
	local ec="$2"

	[ -z "$ec" ] && ec="1"

	perr "$1"
	exit "$ec"
}

utr_chk_serial () {
	if [ ! -c "$SERIAL"]; then
		utr_die "$SERIAL: not a character device"
	fi
}

utr_parse_hex () {
	echo -n "0x"
	echo "$1" | sed -E -n -e 's/\$?([0-9a-f])/\1/ip'
}

utr_parse_system_status () {
	v=$(utr_parse_hex "$1")
	utr_ss_=$(( (v & 0x00000000) >> 0 ))
}

utr_parse_coor_status () {

}

utr_parse_motor_status () {

}

#!/usr/bin/expect -f

# This script is used 

set timeout -1
spawn ssh-add /Users/jeanpaul/.ssh/id_rsa
expect "Enter passphrase for /Users/jeanpaul/.ssh/id_rsa: "
send "Pa55w0rd!\r"
expect eof
check if the content of the configuration file is valid
 sudo nfsd checkexports

make the NFS daemon start at boot
 sudo nfsd enable
 sudo nfsd start

check the service status
 nfsd status

restart the server
 sudo kill -1 `cat /var/run/mountd.pid`

list NFS mount points
 /usr/bin/showmount -e

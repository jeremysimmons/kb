#!/bin/bash
FILE=$(date '+%Y%m%d%H%M%S')_bitnami_conf
sudo find /opt/bitnami -type f -name "*.conf" | tar -cf $FILE -T -



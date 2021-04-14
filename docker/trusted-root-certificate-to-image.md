https://stackoverflow.com/a/44160125/26877
Trusted Root Certificates in DotNet Core on Linux (RHEL 7.1)

.NET Core uses OpenSSL on linux, you need to set up your linux environment in the container so that OpenSSL will pick up the certificate.

This is done by (+ Dockerfile examples):

1. Copying the the certificate `.crt` file to a location that `update-ca-certificates` will scan for trusted certificates - e.g. `/usr/local/share/ca-certificates/` or on RHEL `/etc/pki/ca-trust/source/anchors/`:
    
```
 COPY myca.crt /usr/local/share/ca-certificates/
```
    
2. Invoking `update-ca-certificates`:
    
```
 RUN update-ca-certificates
```
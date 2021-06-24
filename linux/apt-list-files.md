List of files installed from apt package

To find which files were installed by a package, use `dpkg -L`:

```
$ dpkg -L $package
```

`apt-file` can tell you which files will be installed by a package before installing it:

```
root# apt-get install apt-file
root# apt-file update
$ apt-file list $package
```

Or if you have the package as a `.deb` file locally already, you can run `dpkg` on it:

```
$ dpkg --contents $package.deb
```

To find which package provides a file that is already on your system, use:

```
$ dpkg -S /path/to/file
```

To find which package provides a file that is not currently on your system, use `apt-file` again:

```
$ apt-file search /path/to/file
```

https://serverfault.com/a/96965/22484
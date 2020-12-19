TL;DR;

Copy-out Mode: Copy files named in name-list to the archive
`cpio -o < name-list > archive`   

Copy-In Mode: Extract files from the archive
`cpio -i < archive`
    
Copy-pass Mode: Copy files named in name-list to destination-directory
`cpio -p destination-directory < name-list`

Synopsis:
cpio [-i|-o|-p] [options]

Several kinds of options exist:
– UNIX options, which may be grouped and must be preceded by a dash.
– BSD options, which may be grouped and must not be used with a dash.
– GNU long options, which are preceded by two dashes.

1. Archive creation:

When creating archives during the copy-out operation, initiated with the -o command line flag, cpio reads file and directory path names from its standard input channel and writes the resulting archive byte stream to its standard output. Cpio is therefore typically used with other utilities that generate the list of files to be archived, such as the find program or the ls command.

(i) `$ ls | cpio -ov > di.cpio`

The `-o` option creates the archive, and the `-v` option prints the names of the files archived as they are added.The `>` redirects the cpio output to the file `di.cpio`

(ii) `$ find . -depth -print | cpio -o >/path/archive.cpio`

This example uses the find utility to generate a list of path names starting in the current directory to create an archive of the directory tree.

(iii) cpio works like tar but it can read input from the “find” command. This is nifty feature. For example you can find out all *.c files and backup with cpio command.

`$ find / -name "*.c" | cpio -o --format=tar > c-file.backup.tar`

OR – Specifying format with -H option

`$ find / -name "*.c" | cpio -o -H tar > c-file.backup.tar`

OR – Specifying Filename with -F option

`$ find / -name "*.c" | cpio -o -H tar -F c-file.backup.tar`

2. Extraction:

During the copy-in operation, initiated by the -i command line flag, cpio reads an archive from its standard input and recreates the archived files in the operating system`s file system.

Extracting an archive is tedious because cpio does not create directories by default and it does not overwrite existing files unless you tell it to.
(i)

`$ cpio -ivd < archive.cpio`

This will retrieve the files archived in the file archive.cpio and place them in the present directory.
If you are dealing with an archived directory tree, you need to use the `-d` option to create directories as necessary. The `-v` flag lists file names as they are extracted as explained before.

(ii) If only files in the archive with matching names are to be copied from the archive, the following example shows that as it extracts etc/fstab from the archive.

`$ cpio -id etc/fstab <archive.cpio`

3. Listing files within archive

You can list file inside archive i.e. list contents of the cpio file with following command:

`$ cpio -it < archive.cpio`

List may be useful since a cpio archive may contain absolute rather than relative paths.

4. Copy

Cpio supports a third type of operation which copies files. It is initiated with the pass option (-p). cpio copies files from one directory tree to another, as specified by the path given as a command line argument, combining the copy-out and copy-in steps without actually using an archive.

`$ find . -depth -print | cpio -pdumv new-path`

This example copies the directory tree starting at the current directory to another path new-path in the file system, preserving file modes (-m), creating directories as needed (-d), replacing any existing files unconditionally (-u), while producing a progress listing on standard output (-v):

Original Credit: https://www.sanfoundry.com/5-practical-cpio-command-usage-examples-linux/
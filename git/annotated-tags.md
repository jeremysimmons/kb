https://stackoverflow.com/a/25996877/26877

**Usage differences**

`man git-tag` says:

> Annotated tags are meant for release while lightweight tags are meant for private or temporary object labels.

And certain behaviors do differentiate between them in ways that this recommendation is useful e.g.:

- annotated tags can contain a message, creator, and date different than the commit they point to. So you could use them to describe a release without making a release commit.

    Lightweight tags don't have that extra information, and don't need it, since you are only going to use it yourself to develop.
- [git push --follow-tags](https://stackoverflow.com/a/26438076/895245) will only push annotated tags
- `git describe` without command line options only sees annotated tags

**Internals differences**

-   both lightweight and annotated tags are a file under `.git/refs/tags` that contains a SHA-1

-   for lightweight tags, the SHA-1 points directly to a commit:

        git tag light
        cat .git/refs/tags/light

    prints the same as the HEAD's SHA-1.

    So no wonder they cannot contain any other metadata.

-   annotated tags point to a tag object in the object database.

        $ git tag -as -m msg annot
        $ git cat-file -t "$(cat .git/refs/tags/annot)"
        tag
        $ # Get a textual representation of the tag object.
        $ git cat-file -p "$(cat .git/refs/tags/annot)"
        object 4284c41353e51a07e4ed4192ad2e9eaada9c059f
        type commit
        tag annot
        tagger Ciro Santilli <your@mail.com> 1411478848 +0200

        msg
        -----BEGIN PGP SIGNATURE-----
        Version: GnuPG v1.4.11 (GNU/Linux)

        <YOUR PGP SIGNATURE>
        -----END PGP SIGNAT

    And this is how it contains extra metadata. As we can see from the output, the metadata fields are:

    - the object it points to
    - the type of object it points to. Yes, [tag objects can point to any other type of object like blobs, not just commits](https://github.com/gitlabhq/gitlabhq/issues/8266).
    - the name of the tag
    - tagger identity and timestamp
    - message. Note how the PGP signature is just appended to the message

**Bonuses**

-   Determine if a tag is annotated:

        git cat-file -t tag

    Outputs `commit` for lightweight, `tag` for annotated.

-   List only lightweight tags: https://stackoverflow.com/questions/21031201/how-can-i-list-all-lightweight-tags 
If, like me, you want Home to send you to the start of the line and not to the top of the document then create a file called `~/Library/KeyBindings/DefaultKeyBinding.dict` in your ~/Library/KeyBindings folder (might need to create that folder too) with the following contents:
```
{
  "\UF729"  = moveToBeginningOfParagraph:; // home
  "\UF72B"  = moveToEndOfParagraph:; // end
  "$\UF729" = moveToBeginningOfParagraphAndModifySelection:; // shift-home
  "$\UF72B" = moveToEndOfParagraphAndModifySelection:; // shift-end
  "^\UF729" = moveToBeginningOfDocument:; // ctrl-home
  "^\UF72B" = moveToEndOfDocument:; // ctrl-end
  "^$\UF729" = moveToBeginningOfDocumentAndModifySelection:; // ctrl-shift-home
  "^$\UF72B" = moveToEndOfDocumentAndModifySelection:; // ctrl-shift-end
}
```
This remapping does the following in most Mac apps including Chrome (some apps do their own key handling):

Home and End will go to start and end of line
Shift+Home and Shift+End will select to start and end of line
Ctrl+Home and Ctrl+End will go to start and end of document
Shift+Ctrl+Home and Shift+Ctrl+End will select to start and end of document
Note that you will need to reboot after creating this file for it to take effect.

Source: https://damieng.com/blog/2015/04/24/make-home-end-keys-behave-like-windows-on-mac-os-x
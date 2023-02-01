# Introduction
This version of CrackMe uses a simple license key validation. This program doesn't internet connection since the license key is stored locally in the program. You can use dnSpy or Ghidra to crack this program.

# Walkthrough
Since this program is locally validated, it must store the key somewhere. Why not we first try run the program and see if the any files created to store the key. This is simple, the key is stored in `license.key`. So we can copy and paste into the lincese validation box.

To have more ecperience and studies, we can open this program using dnSpy and we can see all the methods and variables that has been set to store and validate the license key. So far, the license key is compared to file `validate.key` and the `license.key` file is only created once when start the program.

From here we understand that, we actualy don't need to put the correct license key, instead we can just adjust the value in these `license.key` and `validate.key` file with the same value and it should work as well.


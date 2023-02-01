# Introduction
This version of CrackMe uses a simple license key validation. This program doesn't need internet connection since the license key is stored locally in the program. You can use dnSpy or Ghidra to crack this program.

# Walkthrough
Since this program is locally validated, it must store the key somewhere. Why not we first try run the program and see if the any files created to store the key. There is no file created to store the license key. So it must have stored it in the program.

To have more ecperience and studies, we can open this program using dnSpy and we can see all the methods and variables that has been set to store and validate the license key. In the variable section, we can see that the license key is written in the program. So we can copy and paste the license key in the license validation box.

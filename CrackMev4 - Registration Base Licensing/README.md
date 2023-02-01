# Introduction
This version of CrackMe uses internet to get the key from the server. But this time, the key must be authorized user to get it.

# Walkthrough
Since there is no key stored in local, so we have to crack this manually. Using dnSpy or Ghidra, we learn that the url is defined in the variable section. But the request must be includes the username and password. As stated in the code (from dnSpy or Ghidra), the username and password is written in `json` format and sent as request body too the url.

This time, we can use PostMan (download from chrome) to perform this request. Set the method to POST, insert the url, then in the body section, select raw > JSON and start write the `json` formatted string as seen in dnSpy or Ghidra.

```
{
	"username": "from dnSpy",
	"password": "from dnSpy"
}
```

Click on send button, the key will appear there.

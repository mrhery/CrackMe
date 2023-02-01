# Introduction
This program is already expired. The expiry check is base on the url.

# Walkthrough
This version is quite hard and tricky. This is the most uses type of software licensing crack done (in adobe, filmora, autocad etc.). First you need to reverse engineer the program using dnSpy or Ghidra, get the url that supplies information about the time.

Now, we can hack the website (but not in this module) or we can spoof the url. You can install any webserver application in your machine. I uses xampp (can download) then create a vhost with the hostname in the url. Then we can create the path `v5/get-time.php` and write `<?php echo strtotime("+1 day"); ?>`. This line of codes will shows the timestamp that always one day ahead which mean will never expired.

Then you can alter the windows `hosts` file in `C:/Windows/Systems32/Drivers/etc/hosts` and add this line: `127.0.0.1 <put the hostname here>` and the saved. This line means, whenever the program wants to download from the url, the windows will redirect the request to our xampp webserver.

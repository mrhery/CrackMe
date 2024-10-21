# CrackMe
A simple RE challenge for starter in RE Attack to understand the basic concept of Reverse engineering. I have developed these challenges to demonstrate how a software can be cracked from licensed software. Most of the programs will be developed in C# language and a few in Java. Since theres a lot of languages in the market, I chooses these two languages which is simpler to crack with opensource toolkit.

# Introduction
CrackMe software has different levels with different types of licensing, from local licensing to remote licensing. With these programs and walthrough, I hope students and starter in RE can understand how the cracking software concept are done in market. Maybe few step is missing in real life hacking, but the basic is here to help you to start :).

# Installation
Since these programs developed in C# and Java, you might need to install Visual C++ 2019 (if reuquired) and Java in your machine. These programs o tested and worked in windows machine. But if you are an expert, you can crack this in any OS also.

You can also download https://github.com/dnSpy/dnSpy which is a tool to reverse engineer C# code and Ghidra (https://github.com/NationalSecurityAgency/ghidra) + Dex2Jar https://github.com/pxb1988/dex2jar to reverse engineer Java Program. (Basically Ghidra can reverse most of the thing).

# Build the web server
1. Navigate to the web server directory
```bash
   cd ./crackme-web
```
2. Run Docker Compose to build and start the containers in detached mode
```bash
docker compose up -d
```
3. Test the Webserver by opening your browser and navigating to
```bash
http://localhost:80
```

# Walkthroughs
I have put the walkthrough details in every version folder in README.md. 

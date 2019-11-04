# Content Related to .NET Framework (Desktop + Web Apps)

Here is the list of Contents for Course EAD 2019

- [Event Drive Programming](./EAD2019/EDP.md)
- [N-Tier Architecture](./EAD2019/N-Tier-Architecture.md)
- [Windows Forms Applications](./EAD2019/WinForms.md)
- [Intro to CSharp](./EAD2019/CSharp.md)
- [Intro to File Handling](./EAD2019/FileHandling.md)
- [Intro CRUD operations](./EAD2019/CRUD.md)
- [Intro Databse](./EAD2019/Database.md)
- [Intro to Web Development](./EAD2019/Intro-to-Web-Development.md)

##  Generating Thumbnail

**Note**: Please add following **_Nuget Pakage_** for ShellFile class.

[Click here to download required nuget package](https://www.nuget.org/packages/WindowsAPICodePack-Shell)

**Getting Thumbnail on Client Side using JavaScript**

```
<img src='http://localhost:14125/api/action/GetThumbnail?uniqueName="+FileUniqueName+"' style='width:10%; height:3%'>
```

## Cryptography

It has two basic functions called `Encryption` &amp; `Decryption`. This cryptography is according to the Electronic Codebook(ECB) mode.

## Email Sending using C# in .NET Framework

**.config file settings**

Put these key pair in the config file under AppSettings <AppSettings>
<add key="mailSender" value="someone.person@gmail.com" />
<add key="mailPassword" value="abc123"/>
<add key="smtpClient" value="smtp.gmail.com"/>
<add key="mailSubject" value="Password Recovery"/>
<add key="secrectRecoveryCode" value="4531254"/>
<add key="port" value="587"/>

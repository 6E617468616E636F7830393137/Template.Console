Log4Net

• log4net.config file has to have property Copy File set to Copy if only newer

Setting Versioning up for Project

• Make sure Visual Studio is CLOSED.
• Open up the csproj file for your project using a text editor like Notepad ++.
• Change the following value from true to false: <Deterministic>false</Deterministic>
• Save the csproj file and open up Visual Studio.
• Open your solution and the wildcard build will work.
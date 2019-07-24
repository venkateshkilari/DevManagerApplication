# DevManagerApplication

Problem Statement: 
Dev team uses one admin credential to login to the server, so two people can’t login once to a server. But one logs in, there is no way to know if someone using it or no. 

About Application:
This application is a simple solution to the above problem. It can integrate with MS Teams app or can be hosted separately. Dev team can check the status of the server and who is using it before logging into server.

How it works? 
As a Teams App:
Install above application as a MS team’s app, it auto populates user email into User field when user click on block server it gets blocked and same is shown to all other users. No one can block the server unless they release it.

As a Web Application:
Works same way as a MS Teams app except populating Name field automatically.

For installing application in teams follow the instructions.
https://docs.microsoft.com/en-us/microsoftteams/platform/get-started/get-started-dotnet-app-studio
For running as a web application , download and code and run in visual studio

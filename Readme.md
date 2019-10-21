# Migrate Playlist Api

###### This API are made just to practice some skills in C#, the scenario isn't usual but this code probably could help you to migrate a playlist from Spotify to Deezer or the opposite when it's done.

To set an environment workspace, you'll need an IDE or code editor (I'm using [VSCode by Microsoft](https://code.visualstudio.com/download)), [dotnet core 3.0 sdk](https://dotnet.microsoft.com/download) and I think that's enougth to start.

> The application already count with integrated interface to test the api endpoints ([Swagger](https://swagger.io/)) without need an external program to do it like postman, but feel free to use the method that makes you more comfortable.

###### To run the project, follow the steps below: 

1. Clone the repo into your PC.
2. Open it in your code editor or IDE
3. If you're using a code editor, in your terminal run the command `dotnet restore` and assert that everything works well.
4. Finally run the project.
5. If the project come up into your browser in the `https://localhost:5001`, add `/swagger/` at the end and you'll see the interface to test the api.

>TIPS
To make the requests to [Spotify](https://developer.spotify.com/documentation/web-api/) and [Deezer](https://developers.deezer.com/api) Apis I'm using [RestSharp](https://github.com/restsharp/RestSharp), you could take a look there before start to code here ;D
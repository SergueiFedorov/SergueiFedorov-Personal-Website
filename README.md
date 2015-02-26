# SergueiFedorov-Personal-Website
Personal website source code. The only thing that is not supplied is the release .config file which is used by the version currently running on the server. However, I have supplied a .mdf database in order to test the codebase of the website.

Some things to know:
- This website runs as a web service. The front end requests data from the web service and then constructs the page dynamically using Javascript
- The webservice is facilitated by the ASP.NET MVC framework.
- This webservice is accessible from any platform that can make rest calls and has the ability to parse JSON data. Most frameworks support this.

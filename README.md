# AutoUpdateChecker
 
1. This executable checks if the Agent executable [https://github.com/krishnaprasadvijayarajan/Agent] is running every 5 seconds
2. If the agent is not running, it triggers the agent
3. Connects to a URL containing version number text file zip and Agent executable zip
4. Downloads the version number zip file, unzips it and obtains the server version number
5. Checks the version number of the running Agent executable - reads the txt file containing the version number
6. Compares if the version numbers - if server version > local version, Agent exe zip from server is downloaded
7. Agent exe zip file is unzipped
8. Existing Agent job is killed
9. Updated Agent job is triggered

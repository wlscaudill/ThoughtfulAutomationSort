# ThoughtfulAutomationSort

## Build
The solution can be built using a standard Visual Studio installation to open ***ThoughtfulAutomationSort.sln*** or via the command line `dotnet build ./ThoughtfulAutomationSort.sln`.

## Testing
The tests can be run by running the unit tests from ***ThoughtfulAutomationSort.Domain.Test*** project in Visual Studio or via command line: `dotnet test ./ThoughtfulAutomationSort.Domain.Test`

## Console Harness
The logic can also be run via a command line using the console harness project ***ThoughtfulAutomationSort.Console***.  Once built you can execute the logic running the executable: `./ThoughtfulAutomationSort.Console/bin/Debug/netcoreapp3.1/ThroughtfulAutomationSort.Console.exe 1 1 1 1` where the parameters are in the order width, height, length, mass.  Running the executable without arguments will describe usage.

## Robot Logic Entrypoint
The logic is not structured the same as the required interface for the robot.  There is an entrypoint for the robot's contract at ***./ThoughtfulAutomationSort.Domain/Logic/RobotAdapter.cs***

# Component-Based Applications
Application is split into several segments by utilizing principles of component-based development. The used architecture is MVC where each one of these segments is modular and based in different projects. We have two main applications ASP.NET Web application and Windows Forms Standalone application.

## The ASP .NET Web Application - USERS
This application is for users (visitors) that only have limited functionality and can only view the the data (added components).

## The Windows Forms Application - ADMIN
This application is developed for the admin of the system and provides complete CRUD functionality.

## Building / runing project and developpment
In order to be able to connect MySQl and .NET you need:
- Running MySQL server
- Created database from the script file (located in the Database/MysqlScript directory)
- Plugins:
	- MySql Connector for .NET (https://dev.mysql.com/downloads/connector/net/)
		- This is mandatory
	 - MySQL for Visual Studio (https://dev.mysql.com/downloads/windows/visualstudio/)
		 - This is not mandatory but highly suggested (if you need Entity Framework,..)
	 * ALL IN ONE SERVER AND PLUGINS (https://dev.mysql.com/downloads/mysql/)
	 - Ikvm-8.0.5449.1 or later
- Add references for installed/downloaded plugins (Mysql.Data and Ikvm Core)
- If exceptions are thrown and everything is connected and should be working try adding references for all ikvm dll files instead of just Core file

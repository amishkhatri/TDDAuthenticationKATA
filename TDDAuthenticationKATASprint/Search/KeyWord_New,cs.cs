using System;
using System.Collections.Generic;
using System.Text;

namespace TDDAuthenticationSprint.Search
{
    class KeyWord_New_cs
    {
        /*
         
        Which of the following about resolving and loading assemblies are true 
a)	Assembly resolution happens at compile time
b)	Assembly resolution happens at run time
c)	The compiler writes the strong names of referenced assemblies to the manifest  , but not any ore as to where to find them 
ANS
1 ) A & B
2 ) A & B
3 ) A & C
4 ) All above given are true (mostly)

What is the following statement about URL authorization is\are true ?
1)	URL authorization is based on the section in web.config
2)	URL authorization doesn’t  have any effect on static files if they are served up directly by the kernel
3)	URL authorization doesn’t require the client to have a Windows account
4)	URL authorization allows both role based checks and direct test  for usernames.
5)	All of the given above (90% correct)
	
As per ASP.NET concepts which of the given statements about the following code is true ? 
Interface IPerson
{
String Firstname {  Get; Set; }	 
String Lastname {  Get; Set; }	 
Void Print();
Void Stack();
Int Fun();
}
a)	Properties cannot be declared inside an interface
b)	This is a perfectly executable interface
c)	The properties in the interface must have a body
d)	Subroutine in the interface must have a body 

What is the default time of a session ?
1)	20 mins
2)	10 mins
3)	30 mins
4)	Noe of the above
Identify the ASP.NET control , the provides an alternative way of showing text on web page
1)	<asp:label>
2)	<asp:listitem>
3)	<asp:button>
4)	All of above
What is the name of the Microsoft IIS server running and handling ASP.NET requests among other things 
1)	Asp.net _isapi.dll
2)	Asp.net _isapi.exe
3)	Inetinfo.exe
4)	None of above
Which of the following statements about an ANTS profiler us\are true ? 
a)	ANTS profiler provides a summary of which methods took the longest to execute during the profiling process.
b)	ANTS profiler provides a summary of which lines of code took the longest time to execute during the profiling process.
c)	ANTS profiler provides a summary of slowest lines of code in the application 
ANS
1.	Only A
2.	Only B
3.	Only C
4.	All of the given above  (it can run on method and line level both)

Which of the following response headers is\are available by default? 
1.	Pragma
2.	Last Modified
3.	Content Type
4.	All of the given above



You are using the ASP.NET membership APIs to manage user accounts for a website . The web.config file contains the definition for the membership provider. After modifying the web.config file to enable password recovery, you create a PassowordReset.aspx file. You need to enable users to reset their password online. The new passwords must be sent to them by e-mail after they have logged on through the Login.aspx page. In addition, users must be required to answer their secret questions before resetting their passwords. Which code logic should use to achieve the given task ?
a.	Add a PasswordRecovery element to the PasswordReset.aspx and configure it.
b.	Modify the Page_Load to set the Membership.EnablePasswordReset to True in the PasswordReset.aspx.
c.	Add a ChangePassword element to the  PasswordReset.aspx file and configure it. 
d.	Modify the Login.aspx form to include a  Required Field Validator on the secret question answer text to redirect users to the PasswordReset.aspx file. 

Which of the following is not a good way to boost ASP.NET application performance? 
a.	Trap exceptions instead of using them to direct program flow.
b.	Disable session state, unless you actively plan to use it. 
c.	Use stored procedures instead of ad hoc queries when accessing back-end SQL data
d.	Never leave caching turned on.

What is the key name for XSRF request verification session token?
a.	__RequestVerification Token
b.	__XSRFVerification Token
c.	__ResponseVerification Token
d.	__KeyVerification Token
Which of the following options are not followed\controlled by client side ?
a.	Cookie
b.	ViewState
c.	Session Object 
d.	HTML controls
In ASP.NET 2.0 website has information collected from logged-in users spreading over multiple ASP.NET web pages. When a user reach the last page, all data has to be gathered, validated and saved to the SQL database. Which of the following controls will you use to collect this data on  a single web page easily ? 
a.	Textbox control
b.	Wizard Control (90% sure)
c.	View control
d.	DataCollection control

Web.config cant override which of the following options ?
a.	Web.config files in the current application’s parent directory
b.	Web.config files in the current application’s sub folder
c.	Web.config file located in the IIS root directory
d.	Machine.config file located on the IIS server (not sure) 

Which of the following is an extension of an ASP.NET web service file ? 
a.	.ASCX
b.	.ASMX
c.	.ASPX
d.	All of above

Where can you store information about User Locale ? 
a.	System.Web.UI.Page.Culture
b.	System.Web.Page
c.	System.Web.Security
d.	None of the above options
What is the syntax of inheriting the ViewModel class from multiple interfaces?
a.	Public class MyClass : <interface1> , <interface2>
b.	Public class MyClass : $<interface1> , $<interface2>
c.	Public class MyClass extends  <interface1> , <interface2>
d.	Public class MyClass inheritss  <interface1> , <interface2>

Which of the following options is a collection interface that will provide the class implementation for various collections ?
a.	ICollectionView
b.	PagedCollectionView
c.	ListCollectionView
d.	CollectionViewSource 
Which of the following statements about singleton pattern is true? 
a.	Singleton pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes. 
b.	Singleton pattern helps two incompatible interfaces to work together.
c.	Singleton pattern restricts the instantiation of a class to one object.
d.	Singleton pattern describes that a group of objects is to be treated in the same way as a single instance of an object.  

Which of the following statements about configuring ASP.NET process identify for impersonation are true? 
a.	ASP.NET pages are executed within a process , or windows program.
b.	ASP.NET process run within identity that should have only the minimal permissions required to run your program.
c.	The application-pool identity must also be added to the IIS_WPG group on the server group. 
d.	The application-pool identity must also be added to the IIS_APP_POOL_WPG group on the server group. 

ANS
1.	A,B and C (90%)
2.	A,B and D
3.	A,C and D
4.	B, C and D

Which of the following exception policies log(s) the exception, replaces the original exception with a custom exception, and throws the new exception ?
a.	Base Policy
b.	Security Policy 
c.	Expressive Policy
ANS
1.	Only A (not sure)
2.	Only B
3.	Only C
4.	Both A and C
Which of the following statements apply to a stack collection? 
A.	It can be used for evaluation of expressions.
B.	All elements in the Stack collection can be addressed using enumerator 
C.	It is used to maintain a FIFO list
D.	All elements stored in a stack collection must be of similar type.
E.	Top-most element of the stack collection can be accessed using Peek() method.
ANS 
1.	A,B and E
2.	A,C and E
3.	A,D and E
4.	All of the given above 


Which of the following statements about Serialization  is\are correct ?
a.	Serialization is converting an object into a stream of bytes 
b.	Serialization is converting stream of bytes into an object

ANS
1.	Only A
2.	Only B
3.	Both A and B
4.	Neither A nor B

 Error information from a database can be retrieved using which of the following events?
a.	GetTrace
b.	MessageReceived
c.	InfoMessage
d.	StateChanged
e.	ErrorMessage
Which event allows you to intervene and manually load an assembly that the CLR cannot find?
a.	AssemblyResolve
b.	AssemblyLoading
c.	AssemblyResolved
d.	AssemblyResolving

As per ASP.NET concepts, while signing an assembly, where is the public key embedded?
a.	Header
b.	IL
c.	Metadata
d.	Manifest
Which of the following components in .NET framework provides an extensible set of classes that can be used by any .NET compliant programming language ?
a.	.NET Class Library
b.	Common Language Runtime
c.	Common  Language Infrastructure
d.	Component Object Model
e.	Common Type System


You create a large n-tier web application that has a custom event tracking system. You need to create a custom event that enables you event tracking system to record all relevant event details for all types of events. The event must be stored in MS SQL Server . You will inherit custom event type from which of the following types. 
a.	IWebEventCustomEvaluator
b.	WebEventProvider
c.	WebBaseEvent
d.	WebAuditEvent
How do you ensure that a paging file doesn’t get fragmented?
1.	By making the paging file dynamic
2.	By making the paging file static
3.	By making the paging file large and keep it on a single drive
4.	By installing MPDFRG.EXE and setting it to run automatically.

Which method do you invoke on the Data Adapter control to load your generated dataset
1.	Fill
2.	ExecuteQuery
3.	Read
4.	None of above
Ans
a.	1
b.	2
c.	3
d.	4
How do you get Type objects from assemblies that have not been loaded
a.	Using Assembly.GetType or Assembly.GetTypes
b.	Using Assembly.GetType only
c.	Using Assembly.GetTypes only
d.	Using Assembly.Typeobjects 

Which property is used to determine whether the type is generic?
1.	Use the IsGenericType Property
2.	Use the IsGeneric Property
3.	Use the GenericType Property
4.	None of these


Which property of Page class helps in setting master page in asp.net?
a.	MasterPage
b.	MasterPageFile
c.	Master
d.	None of above

Which of the following attribute of the <CustomErrors>  section is used to show custom error page in asp.net
1.	defaultToPage
2.	defaultRedirect
3.	redirectToPage
4.	DefaultRedirectPage

Which of the following transfer execution directly to another page
1.	Response.Redirect
2.	Server.Transfer
3.	
4.	None of above

Which of these data source control do not implement caching ?
a.	ObjectDataSource
b.	LinqDataSource
c.	SqlDataSource
d.	XmlDataSource

Which of the following method is used to obtain details about information types of assembly? 
a.	GetTypes
b.	GetType
c.	Both a and b
d.	None of these  

ASP.NET web services is useful  for publishing which of the following options via internet
a.	Middle tier component
b.	Lower tier component
c.	High tier component
d.	Micro tier component

What is the advantage of using ASP.NET CORE
1.	ASP.NET CORE is cross platform, so you can run it on Windows, Linus and Mac.
2.	No need to install the .NET framework to run it. Instead, ship al the required dll with your application.
3.	ASP.NET can handle many requests.
4.	Both 1 & 2
5.	All
ANS 
a.	1
b.	2
c.	3
d.	4
e.	5

The static file middleware understands almost 400 known file content types. If the user requests a file of an unknown file type , the static file middleware returns a 
a.	500 error code
b.	502 error code
c.	400 error code
d.	404 error code
ANS
1.	a
2.	b
3.	c
4.	d
To make a routing constraint optional with @page directive in asp.net core which of the following character is used?
1.	#
2.	?
3.	!
4.	!!
ANS
a.	1
b.	2
c.	3
d.	4
Which directive help a chtml file handle requests directly,  without going through a controller ?
1.	“@page”
2.	“@using”
3.	“@model”
4.	“@DateTime”
ANS 
a.	1
b.	2
c.	3
d.	4
The URLs for content exposed with UseDirectoryBrowser and UseStaticFiles are
1.	Case sensitive
2.	Case insensitive and don’t follow character restrictions of the underlying file system.
3.	Follow character restrictions of the underlying system.
4.	1 & 3 are correct
ANS 
a.	1
b.	2
c.	3
d.	4
Which of the following keys is\are not part of the response header
a.	Re
b.	Set Cookies
c.	If-Modified-Since
ANS 
1.	a & b
2.	b & c
3.	a,b & c (not sure)
4.	a & cs

Which of the following options has a two-way communication between view and ViewModel?
1.	Commands
2.	Bindings
3.	Expression interactivity
4.	Events occurred in C#

Which of the following statements about Location-Specific Authorization Policies are true in ASP.NET?
A.	We can override the baseline policy by creating location specific policies.
B.	Location specific policies apply to just one part of the application.
C.	Location specific policies can be defined in the web.config using the “location” element. 
D.	The baseline policy is applied if none of the location-specific add or deny elements matches the request
ANS 
1.	A,B and D
2.	B,C and D
3.	A and D
4.	All of above.

As per ASP.NET concepts, which of the following statements are true?
A.	An argument passed to a ref parameter need not be initialized first.
B.	Variable passed as out arguments need to be initialized prior to be passed.
C.	Argument that uses parameters keyword must be the last argument of variable argument list of a method.
D.	To use a ref parameter, only the calling method must explicitly use the ref keyword.
ANS
1.	A, B ,D
2.	B, C
3.	A, C
4.	C, D
You can turn off view state for all the web pages in a site by  which of the following options
a.	Add the following line within web.config <%@Page Language=”VB” Enableviewstate=”false”/>
b.	Add the following line in all pages <%@Page Language=”VB” Enableviewstate=”false”/>
c.	Set EnableViewState=”false” for all controls in all web pages.
d.	None of the above given option
By default .net web site is configured with which of the following authentication types ?
A.	Anonymous
B.	Basic
C.	Integrated Windows Authentication
Ans
1.	Only A
2.	Only B
3.	Only C
4.	Both A and C
Which of the following are performance monitoring classes that are provided by the .NET framework? 
A.	System.Diagnostics.PerformanceCounter
B.	System.Diagnostics.PerformanceCounterInstaller
C.	System.Diagnostics.PerformanceCounterType
D.	System.Diagnostics.FrameworkElement
ANS
1.	A,B,D
2.	A,B,C
3.	A,D
4.	B,C,D

Pre-flight requests use which HTTP status code ?
a.	405 status code
b.	401 status code
c.	403 status code
d.	404 status code

What will you do to find out whether a user is  a member of  a particular role in a web site that uses ASP.NET membership control for creation of user account ?
a.	Pass the user names and passwords to membership ValidateUser
b.	Pass the role names to User.IsInRole
c.	Pass the role names to Roles.RoleExists
d.	Pass the user names to Membership.GetUsesr

Which of the following elements registers the custom handler? 
1.	ISAPI.DLL
2.	ILDSAM
3.	GLOBAL.ASAX
4.	HttpHandler
5.	Web.Config

As per ASP.NET concepts, which stage event is raised after the page is fully rendered , sent to client and is ready to be discarded ?
A.	Rendering
B.	Page Request
C.	Initialization
D.	Unload

Which of the following control is designed to show single record at a time in a web page?
1.	Gridview
2.	Formview
3.	DataList
4.	Listviews

As per ASP.NET concepts, which of the following page events reads or sets the profile property value ?
a.	Pre-init
b.	Init
c.	PreLoad
d.	Load
Which of the following options enables you to show multiple records , supports data grouping, but disable insertion of records in the underlying data directly and does not support paging natively.
1.	DataList
2.	GridView
3.	Repeater
4.	ListView

What should you do before using ASP.NET Webservices? 
1.	Build a proxy library by using the Disc.exe utility
2.	Build a proxy library by using the Tblimp.exe utility
3.	Build a proxy library by using the csc.exe utility
4.	Build a proxy library by using the wsdl.exe utility

Which of the following statements about how the garbage collector works are correct 
A.	The CLR uses a generational mark and compact GC that performs automatic memory management for objects stored on the managed heap.
B.	During a garbage collection only the main threads will be frozen.
C.	Unused objects without finalizer are immediately discarded. 
D.	If there is an insufficient space to allocate memory for a new object after garbage collection , and the operating system is unable to grant further memory, as insufficientMemoryException is thrown.
ANS
1.	A , B
2.	B , C
3.	A, B, D
4.	All above

Which of the following methods accepts no parameters ? 
a.	CallMethodAction
b.	InvokeCommandAction
c.	CanExecute
d.	Command

Which of the following design patterns is an example of structural pattern ? 
1.	Command Pattern
2.	Observer Pattern
3.	Strategy Pattern
4.	Proxy Pattern
Façade design pattern is an example of which of the following pattern?
a.	Creational Pattern
b.	Structural Pattern
c.	Behavioral Pattern
d.	Enterprise Pattern 
Which of the following statements about assembly is true ?
1.	An assembly is a collection of files that appear to the programmer to be single dll or exe
2.	An assembly is a collection of properties of C#
3.	An assembly is a collection of events of C#
4.	An assembly is a collection of declarative syntax of C#
Which of the following options will catch the exception if it is not caught at runtime
a.	Compiler
b.	CLR
c.	Linker
d.	Loader
As per .NET string belongs to which of the following types? 
1.	Reference Type
2.	Value Type
Which of the possible languages are available in .NET 4.0 ? 
A.	C# 4
B.	VB.NET 10
C.	F#
ANS 
1.	Only A
2.	Only B and C
3.	Only C
4.	All of above given options
When you create a web site .The web site needs to be deployed to a staging server for performance testing. You plan to make a number of performance enhancements and then restest.You need to compile and copy web site to the staging server. What will you do to accomplish the given task?
1.	Write a batch file that uses aspnet_compiler.exe
2.	Write a batch file that uses InstallUtil.exe
3.	Write a batch file that uses CSC.exe
4.	Write a batch file that uses aspnet_wp.exe

Which of the following options has common type system built into it ?
a.	CLR
b.	RCT
c.	RCW
d.	GAC
As per ASP.NET concepts, which of the following can privately deployed? 
A.	Weakly named assemblies. 
B.	Strong named assemblies. 
ANS
1.	A
2.	B
3.	A,B
4.	Any assemblies


Which property of the session object is used to set the local identifier 
1.	LCID
2.	SessionId
3.	Key
4.	Item
Can theme attribute be applied to @Master directive in asp.net ? 
1.	True
2.	False
Which property of Page class helps in setting master page in asp.net
1.	MasterPage
2.	MasterPageFile
3.	Master
4.	None of these

Which of the following is used to cache multiple responses for a single web form based on HTTP POST parameter or query string ? 
1.	VaryyHeaders
2.	SetCacheability
3.	VaryByParams
4.	SetVaryByCustom

What can manage states in asp.net application using
a.	Session Objects
b.	Application Objects
c.	ViewState 
d.	All of above
ANS
1.	a
2.	b
3.	c
4.	d
Which  directive is used to mark a page as a master page in asp.net?
1.	“@Page”
2.	“@MasterPage”
3.	“@Master”
4.	“@M”
ANS
a.	1
b.	2
c.	3
d.	4
In asp.net , application DLL stored in 
1.	App_Data
2.	App_Code
3.	Bin
4.	App_localResources

Which attributes do you use to hide a public .NET class from COM?
1.	DLLImport Attributes
2.	ComInvisible attributes
3.	COM Interop
4.	ComVisible attributes
What is the extension of a resource file in asp.net ? 
1.	.aspx
2.	.resx
3.	.config
4.	.resource
Which technology discontinued in ASP.NET Core?
1.	Reflection
2.	AppDomain
3.	Remoting
4.	Binary Serialization
5.	All
ANS 
a.	1
b.	2
c.	3
d.	4
e.	5



Sticky sessions ensure that subsequent requests from client all go to
1.	Different Server
2.	The same server
3.	Any of the server
4.	None of these

The static file middleware provides authorization check by default. Any files served  by it, including those under wwwroot are not publicly accessible
1.	TRUE
2.	FALSE

MemoryCache requires which NuGet package for asp.net core?
1.	Microsoft.Extensions.Caching.MemoryCache
2.	Microsoft.Extensions.Caching.Memory
3.	Microsoft.Extensions.Caching.CacheMemory
4.	Microsoft.Extensions.Caching.InMemory

ANS
a.	1
b.	2
c.	3
d.	4

1)   What is the name of the Page object’s property that determines if a Web page is being requested without data being submitted to server?

a. IsCallback
b. IsReusable
c. IsValid
d. IsPostBack

ANSWER: IsPostBack

2)   ______________ is the DataType return in IsPostback property.

a. bit
b. boolean
c. int
d. object
e. string

ANSWER: boolean

3)   When does Garbage collector run?
a. When application is running low of memory
b. It runs random
c. When application is running for more than 15 minutes
d. None of the above
ANSWER: When application is running low of memory

4)   Which is the first event of ASP.NET page, when user requests a web page? 
a. PreLoad
b. Load 
c. Preinit
d. Init
ANSWER: Preinit
 
1)	PreInit: This event is also useful when you are dynamically (from code) set values such as master page, theme or dynamically created controls for a page.
2)	Init: This event fires after each control has been initialized.
3)	InitComplete: This event fires all initializations of the page and its controls have been completed.
4)	PreLoad: Executes before view state has been loaded for the page and its controls and before PostBack processing.
5)	Load: This event checks for PostBack and then sets control properties.
6)	Control (PostBack) event(s): This event fires when any events on the page or its controls that caused the PostBack to occur. For example button’s click event.
7)	LoadComplete: At this point all controls are loaded.
8)	PreRender: This event fires after all regular PostBack event have taken place. It is executed before saving ViewState.
9)	SaveStateComplete: If anyone makes changes to the page’s controls at this point or beyond, they are ignored.
10)	Render: This event generates the client-side HTML, DHTML, and script that are necessary to display a control at the browser.
11)	UnLoad: This event is used for cleanup code.

5)   What happens in the Init event of a page?
a. ViewState is loaded on the page.
b. Each child control of the page is initialized to its design time values.
c. HTML is rendered.
d. None of the above.




ANSWER: Each child control of the page is initialized to its design time values.


6)   Which one of the following has a parameter called as “preserveForm”?

a. Server.transfer 
b. Response.redirect
ANSWER: Server.transfer

7)   Which validation control in ASP.NET can be used to determine if data that is entered into a TextBox control is of type Currency?

a. ValidationSummary
b. CompareValidator
c. RequiredFieldValidator
d. None of the above.

ANSWER: CompareValidator

 
You can use the CompareValidator control to do a data type check. Set its operator property to DataTypeCheck and its Type property to Currency.

8)   If we want to add graphics using asp.net which of the following web control will you use?

a. Link Button
b. AdRotator
c. Grid View
d. Layout

ANSWER: AdRotator

 
The AdRotator web server control cycles through a series of clickable ad banner and allows some ads to be weighted more heavily.

9)   What is/are true about master page? Choose the correct option.

a. You can add more than one master page in a website.
b. Master page can be nested.
c. ContentPlaceHolder control is required on a content page.
d. Both A and B option are correct.

ANSWER: Both A and B option are correct.


10)   Which of the following statements about referencing master page methods and properties is true? 

a. Content pages can reference controls in the master page.
b. Content pages can reference public properties in the master page.
c. Content pages can reference public methods in the master page.
d. All of the above.

11)   How many types of authentication ASP.NET supports?

a. Windows Authentication.
b. .NET Passport Authentication.
c. Forms Authentication.
d. All of the above.

ANSWER: All of the above.

 
Windows authentication

It is enabled by default. When Windows authentication is enabled, users are identified by their Microsoft Windows account names.

.NET Passport authentication

It is a centralized service provided by Microsoft. .NET Passport allows users to create a single sign-in name and password to access any site that is uses .NET 

Passport authentication

.NET Passport does only authentication not authorization. Passport simply tells a participating site who the user is. MSN and Hotmail uses .NET Passport authentication.. 

Forms authentication

In this authentication users are typically identified by a cookie. When a user is authenticated, an encrypted cookie is added to the user’s browser. As the user moves from page to page, the user is identified by the cookie.

12)   Which of the following is the default authentication mode for IIS?

a. Anonymous
b. Windows
c. Basic Authentication
d. None

13)   You use the ASP.NET Web Site Administration Tool to configure ASP.NET membership with forms authentication. What should you name your login form so that you do not have to modify the Web.config file?

a. Login.aspx
b. LoginPage.aspx
c. Default.aspx
d. Auth.aspx

ANSWER: Login.aspx

 
If no filename is specified in the Web.config file, ASP.NET redirects unauthenticated users to the Login.aspx page, regardless of whether the page exists.

14)   What are the types of cookies?

a. Session cookies
b. Persistent cookies.
c. Dummy cookies.
d. Option A and B are correct.

ANSWER: Option A and B are correct.

 
There are two types of cookies: session cookies and persistent cookies. A session cookie exists only in memory. If a user closes the web browser, the session cookie will be lost. 

A persistent cookie, on the other hand, can remain for months or even years. When you create a persistent cookie, the cookie is stored permanently by the user’s browser on the user’s computer.

15)   Default Session data is stored in ASP.Net.

a. StateServer
b. Session Object
c. InProcess
d. all of the above

ANSWER: InProcess

 


16)   Which session modes stores session Information in Current Application Domain?

a. InProc
b. StateServer 
c. SQLServer 
d. Off

ANSWER: InProc

 
InProc session mode stores its session data in a memory object on that application domain. This is handled by worker process in application pool. So if you restart the server you will lose the session data. In web.config file you can mention Session mode and also you have to set the Timeout. 
< system.web>
< sessionState mode=”InProc” timeout=”30”>
< /system.web>

17)   Choose the correct option about the Integrated Security property of connection object. 

a. If Integrated Security=false then User ID, and Password must be specified in the connection string.
b. If Integrated Security=true then current Windows account credentials are used for authentication.
c. Both A and B option are correct.
d. None of the above.	

ANSWER: Both A and B option are correct.

 
You can provide yes, no, true, SSPI and false value to Integrated Security property according to the requirement and security of application. If Integrated Security=false then User ID, and Password must be specified in the connection string and if true then current Windows account credentials are used for authentication. 

SSPI is equivalent to specifying True.

18)   In which file you should write the connection string, so you can access it in all the web page for same application?

a. In App_Data folder.
b. In Web.config file.
c. In MasterPage file.
d. None of the above.

ANSWER: In Web.config file.

 
Following are the steps to create the connection string in Web.config file and access it in code behind file. In connection string data source and database name you have to provide according to your sqlserver instance and their database name.

Step 1: Create the connection string in Web.config file as follows. 
< connectionStrings>
< add name="con" connectionString="Data Source =ServerName; initial catalog= DataBaseName; Integrated Security=true"/> 



Step 2: In code behind file write the following code.
ConfigurationManager class is available in System.Configuration namespace;

string conStr= ConfigurationManager.ConnectionStrings["con"].ConnectionString;
SqlConnection conObj = new SqlConnection(conStr); 
conObj.Open();

// Write code according to the requirement.

conObj.Close();

19)   How will you specifying the Cache Location?

a. You can use browser settings to specify where a page is cached.
b. You can use the Location attribute of the < %@ OutputCache %> directive to specify where a page is cached.
c. You can use the Location attribute in QueryString to specify where a page is cached.
d. None of the above.

ANSWER: You can use the Location attribute of the < %@ OutputCache %> directive to specify where a page is cached.

 
By default, when you use Page Output Caching, a page is cached in three locations: web server, any proxy servers, and browser. You can write following code to cache the page on server for 50 seconds.

< %@ OutputCache Duration="50" VaryByParam="none" Location=”Server” %>

20)   Which of these data source controls do not implement Caching?

a. LinqDataSource
b. ObjectDataSource
c. SqlDataSource
d. XmlDataSource

ANSWER: LinqDataSource

 
1)   You want to make a configuration setting change that will affect only the current Web application. Which file will you change?

a. Global.asax
b. Web.config in the root of the Web application
c. Machine.config
d. All of the above
Answer  Explanation 
ANSWER: Web.config in the root of the Web application

Explanation: 
No explanation is available for this question!

2)   ______________is the first method that is fired during the page load.

a. PreRender()
b. Load()
c. Unload()
d. Init()
Answer  Explanation 
ANSWER: Init()

Explanation: 
No explanation is available for this question!

3)   What is a web application running on multiple servers called?

a. HTTP
b. Web Servers
c. Web Page
d. Web farm
Answer  Explanation 
ANSWER: Web farm

Explanation: 
When we host a web application over multiple web servers to distribute the load among them it is known as a web farm

4)   What property do you modify on a server control to minimize the size of the ViewState data?

a. ViewState=”true”
b. Set EnableViewState to false.
c. Set EnableViewState to true.
d. None of the above
Answer  Explanation 
ANSWER: Set EnableViewState to false.

Explanation: 
In ASP.NET when a form is postback to server it reappears in the browser with all form values. ASP.NET page and controls maintain their state by in hidden form field named _ViewState. By default it is enable for all server controls and sometimes create problem because unnecessary data are stored in this field. To minimize the size of the ViewState data, set EnableViewState to false. 

5)   A web page has lots of input data, and you want the data input to be spread across multiple screens. What is the best control to use to implement this solution on a single Web page?

a. ImageMap
b. Panel
c. Wizard 
d. None of the above
Answer  Explanation 
ANSWER: Wizard

Explanation: 
The Wizard control is used to divide a large form, which has the lots of data, into multiple sub-forms. The Wizard control contains one or more WizardStep child controls. Only one WizardStep is displayed at a time.

6)   ASP.NET validation controls works (handle validation) at 

a. Client side only.
b. Server side only.
c. Both client side and server side.
d. None of the above.
Answer  Explanation 
ANSWER: Both client side and server side.

Explanation: 
ASP.NET validation controls can be attached to user input controls to handle validation on both the server and the client. Client-side validation improves performance by checking the input data at the browser before sending to the server. Clint side validation is not so much secure. It can be easily hacked by hackers. Server-side validation is more secure way of validating the data that is posted back to the server.

7)   There is a button on page name cancel and it should bypass validation when cancel button is clicked. What will you do?

a. set CausesValidation = false.
b. set RemoveValidation=true
c. set cancel=true
d. None of the above.
Answer  Explanation 
ANSWER: set CausesValidation = false.

Explanation: 
No explanation is available for this question!

8)   Which of the following is a valid skin code inside a skin file?

a. < asp:TextBox BackColor=”Yellow” BorderStyle=”Dotted” ID=”colorTxt” Runat=”Server”/>
b. < asp:TextBox BackColor=”Yellow” BorderStyle=”Dotted” Runat=”Server” />
c. < asp:TextBox BackColor=”Yellow” BorderStyle=”Dotted” ID=”colorTxt” />
d. None of the above.
Answer  Explanation 
ANSWER: < asp:TextBox BackColor=”Yellow” BorderStyle=”Dotted” Runat=”Server” />

Explanation: 
You must always include a Runat=”server” attribute, but you can never include the ID attribute when declaring a control in a Skin.

9)   What is/are the advantages of master page?

a. It helps to display common content in multiple pages.
b. They allow you to centralize the common functionality of your pages so that you can make updates in just one place.
c. It helps to create a common page layout.
d. All of the above.
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

10)   How to implement authentication via web.config?

a. Include the authentication element.
b. Include the authorization element.
c. Include the identity element.
d. Include the deny element.
Answer  Explanation 
ANSWER: Include the authorization element.

Explanation: 
No explanation is available for this question!

11)   Windows-Based Authentication is well suited for.

a. Intranet environment.
b. Public web site.
c. Desktop application.
d. None of the above.
Answer  Explanation 
ANSWER: Intranet environment.

Explanation: 
In a Windows-based authentication, the requests go directly to IIS to provide the authentication process. This type of authentication is quite useful in an intranet 
environment, where the server handles authentication process. 

12)   If any user has disabled cookies in their browsers, what can you do to enable them to use forms authentication?

a. Set BoweserCookieEnabled=true;
b. Set cookieless=true;
c. Use the AutoDetect setting of the cookieless attribute.
d. None of the above.
Answer  Explanation 
ANSWER: Use the AutoDetect setting of the cookieless attribute.

Explanation: 
No explanation is available for this question!

13)   What ASP.NET object encapsulates the state of the client and the browser?

a. Application Object
b. Session Object
c. Response Object
d. Request Object
Answer  Explanation 
ANSWER: Session Object

Explanation: 
No explanation is available for this question!

14)    In ASP.NET what are the different types of session mode available?

a. InProc 
b. StateServer 
c. SQLServer 
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
InPorc Session Mode: 

This is the default session mode in Asp.Net. Its stores session Information in Current Application Domain. There are no requirements of serialization to store data in InProc Session Mode.

StateServer Session Mode: 

This is also called Out-Proc session mode. It is managed by aspnet_state.exe. In this mode server may runs on the same system, but it's outside of that main 
application domain where your web site is running. It is useful in web farm and web garden scenarios. 

SQL Server Session Mode:

In this session mode, the Session data is serialized and stored in the SQL Server database. We should use SQL server session mode when we need to implement Session with some more security. 

15)   To kill a users session explicitly which of the following will you use?

a. Session.Close()
b. Session.End()
c. Session.Abondon()
d. Session.Discard()
Answer  Explanation 
ANSWER: Session.Abondon()

Explanation: 
The Abandon method destroys all the objects stored in a session object and releases their resources. If we don't call this explicitly the server destroys this object when the session times out.

16)   Which control is required of every AJAX page to manage the JavaScript files sent to the client and the communication between client and server?

a. UpdatePanel
b. ScriptManager
c. AsyncPostBackTrigger
d. None of the above.
Answer  Explanation 
ANSWER: ScriptManager

Explanation: 
ScriptManager control is mandatory control if you want to work with ASP.NET AJAX server control. Only one instance of a ScriptManager can be added to the web page. It manages the JavaScript files sent to the client and the communication between the server and the client. It also manages partial-page updates. The HTML for a ScriptManager control in Source view looks as follows:

< asp:UpdatePanel ID="UpdatePanel1" runat="server">


17)   What property and method of the Page object do you use to register client script dynamically from code?

a. ScriptManager control is used to dynamically register client script from code.
b. The Page.ClientScript.RegisterClientScriptBlock is used to dynamically register client script from code.
c. ScriptManagerProxy control is used to dynamically register client script from code. 
d. None of the above.
Answer  Explanation 
ANSWER: ScriptManagerProxy control is used to dynamically register client script from code.

Explanation: 
No explanation is available for this question!

18)   Which ado.net class provide disconnected environment?

a. DataReader
b. DataSet
c. Command
d. None of the above.	
Answer  Explanation 
ANSWER: DataSet

Explanation: 
No explanation is available for this question!

19)   What data type is returned when calling the ExecuteScalar method of a command object?

a. System.Int32
b. Object
c. No of effected records.
d. None of the above.
Answer  Explanation 
ANSWER: Object

Explanation: 
No explanation is available for this question!

20)   How many types of Cache Dependencies are available in ASP.NET? 

a. File based dependencies
b. Key-based dependencies
c. Time-based dependencies
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!


1)   In order to prevent a browser from caching a page which of these xstatements should be written?

a. Response.Cache.SetNoStore();
b. Response.Cache.SetNoServerCaching();
c. Response.Cache.SetNoCaching();
d. None of these
Answer  Explanation 
ANSWER: Response.Cache.SetNoStore();

Explanation: 
No explanation is available for this question!

2)   You need to programmatically configure page output caching. Which object would you use?

a. Request
b. Response
c. Application
d. Server
Answer  Explanation 
ANSWER: Response

Explanation: 
The Response object have methods such as Response.Cache.SetExpires and Response.AddCacheDependency that enables you to configure page output caching programmatically.

3)   What are the Command Object Methods?

a. ExecuteNonQuery
b. ExecuteReader
c. ExecuteScalar
d. All of the above.
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
The common methods of command abject are as follows.

- ExecuteReader: This method works on select SQL query. It returns the DataReader object. Use DataReader read () method to retrieve the rows.

- ExecuteScalar: This method returns single value. Its return type is Object. If you call ExecuteScalar method with a SQL statement that returns rows of data, the query executes but returns only the first column of the first row returned by the query. 

- ExecuteNonQuery: If you are using Insert, Update or Delete SQL statement then use this method. Its return type is Integer (The number of affected records).

4)   To perform asynchronous data access, what must be added to the connection string?

a. BeginExecute=true
b. MultiThreaded=true
c. MultipleActiveResultSets=true
d. Asynchronous=true
Answer  Explanation 
ANSWER: Asynchronous=true

Explanation: 
No explanation is available for this question!

5)   A Master Page contains a ScriptManager control and a user wants the AJAX functionality on content page then which control is necessary on content page. 

a. AsyncPostBackTrigger
b. ScriptManager
c. ScriptManagerProxy
d. None of the above.
Answer  Explanation 
ANSWER: ScriptManagerProxy

Explanation: 
No explanation is available for this question!

6)   Which of the following is not a member of ADODBCommand object?

a. ExecuteScalar
b. ExecuteStream
c. Open
d. ExecuteReader
Answer  Explanation 
ANSWER: Open

Explanation: 
No explanation is available for this question!

7)   From the following which is not a valid state management object?

a. Querystate
b. Cookies
c. Application state
d. Hidden form fields
Answer  Explanation 
ANSWER: Querystate

Explanation: 
We generally do not run queries in asp as they are slow. It is not a valid management tool to be used.

8)   Where do we include the user lists for Form authentication?

a. < credential>
b. < authorization>
c. < Identity>
d. < authentication>
Answer  Explanation 
ANSWER: < credential>

Explanation: 
No explanation is available for this question!

9)   By default, a .Net web site is configured with which of the following authentication types?

a. Anonymous
b. Basic
c. Digest
d. Integrated Windows authentication
e. a and d
Answer  Explanation 
ANSWER: a and d

Explanation: 
No explanation is available for this question!

10)   Validation events of server controls occur before the page is post back to the server.

a. True 
b. False


Answer  Explanation 
11)   _____________is a property common in every validation control.

a. ValidationExpression
b. InitialValue
c. ValueToCompare
d. ControlToCompare
e. ControlToValidate
Answer  Explanation 
12)   Using which type of stylesheet we can change the style of an element in the entire website?

a. Internal Stylesheet 
b. External Stylesheet
c. Inline stylesheet
d. None of above
Answer  Explanation 
ANSWER: External Stylesheet

Explanation: 
No explanation is available for this question!

13)   Which of the following is the way to monitor the web application?

a. MMC Event viewers
b. Performance logs
c. Alerts Snap-ins
d. ALL
Answer  Explanation 
ANSWER: ALL

Explanation: 
No explanation is available for this question!

14)   __________________ file apply settings to all ASP.NET applications

a. web.config
b. machine.config
c. global.asax file
d. application object
Answer  Explanation 
ANSWER: machine.config

Explanation: 
No explanation is available for this question!

15)  Which type of processing model does asp.net stimulate?

a. Static
b. Linear
c. Bottom­ up
d. Event­-driven
Answer  Explanation 
ANSWER: Event­-driven

Explanation: 
Event-­driven programs respond to events. An event happens(or is raised) when something happens like when a button is pressed or something. Often, events are generated by user actions but there are some events which are system generated also.


1)   Which protocol is used for requesting a web page in ASP.NET from the Web Server?

a. HTTP
b. TCP
c. SMTP
d. None of the above.
Answer  Explanation 
ANSWER: HTTP

Explanation: 
No explanation is available for this question!

2)   What are the types of cookies?

a. Session cookies
b. Persistent cookies
c. Dummy cookies
d. Option A and B are correct
Answer  Explanation 
ANSWER: Option A and B are correct

Explanation: 
No explanation is available for this question!

3)   What is the fully qualified name of the base class of all server controls?

a. System.Web.UI.Control 
b. System.Web.UI
c. System.Control
d. All of the above
Answer  Explanation 
ANSWER: System.Web.UI.Control

Explanation: 
No explanation is available for this question!

4)   Which file you should write for the connection string, so that you can access it in all the web pages for the same application?

a. In App_Data folder
b. In Web.config file
c. In MasterPage file
d. None of the above
Answer  Explanation 
ANSWER: In Web.config file

Explanation: 
No explanation is available for this question!

5)   Which of the following control provides a link for unauthenticated users to log on?

a. Login
b. LoginView
c. LoginStatus 
d. LoginName
Answer  Explanation 
ANSWER: LoginStatus

Explanation: 
No explanation is available for this question!

6)   What are the advantages of AJAX?

a. AJAX is a platform-independent technology
b. It provides partial-page updates
c. Improved performance
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!

7)   If you want to cache the page according to the browser, then what will you do?

a. 
Write the given below code in aspx page. 
<%@ OutputCache Duration=”500” VaryByParam=”none” VaryByCustom=”browser” %>
b. 
Write the given below code in aspx page. 
<%@ OutputCache Duration=”500” VaryByParam=”none” VaryByHeader=”browser” %>
c. 
Write the given below code in aspx page. 
<%@ OutputCache Duration=”500” VaryByParam=” browser” VaryByCustom=”none” %>
d. None of the above.
Answer  Explanation 
ANSWER: 
Write the given below code in aspx page. 
<%@ OutputCache Duration=”500” VaryByParam=”none” VaryByCustom=”browser” %>

Explanation: 
No explanation is available for this question!

8)   You need to allow users to choose their own themes. In which page event will you write the user-selected theme?

a. Page_Load
b. Page_Render
c. Page_PreInit 
d. Page_PreRender
Answer  Explanation 
ANSWER: Page_PreInit

Explanation: 
No explanation is available for this question!

9)   Client-side validation is turned on by default. If you want that particular validation control should not validate at client side, what will you do?

a. Set the EnableClientScript property to false
b. Set the validate property to false
c. Set the EnableClientScript property to true
d. Set the Page.Isvalid property to false
Answer  Explanation 
ANSWER: Set the EnableClientScript property to false

Explanation: 
No explanation is available for this question!

10)   A button control is located outside the UpdatePanel control. You need that a given button control outside of the UpdatePanel should cause the UpdatePanel to execute an update with partial update. What will you do to achieve this task?

a. 
- Add a PostBackTrigger control to the Triggers section of the UpdatePanel. 
- Set the ControlID attribute of the AsyncPostBackTrigger control to the ID of the Button control.
b. 
- Add a Trigger control to the Triggers section of the UpdatePanel. 
- Set the ControlID attribute of the AsyncPostBackTrigger control to the ID of the Button control.
c. 
- Add an AsyncPostBackTrigger control to the Triggers section of the UpdatePanel. 
- Set the ControlID attribute of the AsyncPostBackTrigger control to the ID of the Button control.
d. None of the above.
Answer  Explanation 
ANSWER: 
- Add an AsyncPostBackTrigger control to the Triggers section of the UpdatePanel. 
- Set the ControlID attribute of the AsyncPostBackTrigger control to the ID of the Button control.

Explanation: 
No explanation is available for this question!

11)   Choose the correct option about the Integrated Security property of connection object. 

a. If Integrated Security=false then User ID, and Password must be specified in the connection string.
b. If Integrated Security=true then current Windows account credentials are used for authentication.
c. Both A and B option are correct. 
d. None of the above. 
Answer  Explanation 
ANSWER: Both A and B option are correct.

Explanation: 
No explanation is available for this question!

12)   You are creating an ASP.NET application for CareerRide. The company uses Microsoft Windows authentication. All users are in the CareerRide domain.

You want to configure the application to use the following authorization rules:

1. Anonymous users must not be allowed to access the application.
2. All employees except Raj and Shiva must be allowed to access the application.

Which code you will apply to configure the application ?

a. 
<authorization>
<deny users=” CareerRide \Raj, CareerRide \Shiva”> 
<allow users=”*”>
<deny users=”?”> 
</authorization>

b. 
<authorization>
<allow users=”*”> 
<deny users=” CareerRide \Raj, CareerRide \Shiva”>
<deny users=”?”> 
</authorization>

c. 
<authorization>
<deny users=” CareerRide \Raj, CareerRide \Shiva”> 
<deny users=”?”>
<allow users=”*”> 
</authorization> 

d. 
<authorization>
<allow users=” CareerRide \Raj, CareerRide \Shiva”> 
<allow users=”*”> 
</authorization> 
Answer  Explanation 
13)   Which is the first event of ASP.NET page, when user requests a web page ? 

a. PreLoad
b. Load 
c. Preinit 
d. Init
Answer  Explanation 
ANSWER: Preinit

Explanation: 
No explanation is available for this question!

14)   There is a button on page name cancel and it should bypass validation when cancel button is clicked. What will you do?

a. set CausesValidation = false 
b. set RemoveValidation=true
c. set cancel=true
d. None of the above
Answer  Explanation 
ANSWER: set CausesValidation = false

Explanation: 
No explanation is available for this question!

15)   What is the name of the Page object’s property that determines if a Web page is being requested without data being submitted to server?

a. IsCallback
b. IsReusable
c. IsValid
d. IsPostBack 
Answer  Explanation 
ANSWER: IsPostBack

Explanation: 
No explanation is available for this question!

16)   Which one of the following HTTP verbs indicates that you are creating and writing a file on the Web server?

a. POST
b. SET
c. GET
d. PUT 
Answer  Explanation 
ANSWER: PUT

Explanation: 
No explanation is available for this question!

17)   What is/are the advantages of master page?

a. It helps to display common content in multiple pages.
b. They allow you to centralize the common functionality of your pages so that you can make updates in just one place.
c. It helps to create a common page layout.
d. All of the above. 
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

18)   How will you specifying the Cache Location?

a. You can use browser settings to specify where a page is cached.
b. You can use the Location attribute of the <%@ OutputCache %> directive to specify where a page is cached. 
c. You can use the Location attribute in QueryString to specify where a page is cached.
d. None of the above.
Answer  Explanation 
ANSWER: You can use the Location attribute of the <%@ OutputCache %> directive to specify where a page is cached.

Explanation: 
No explanation is available for this question!

19)   How many types of authentication ASP.NET supports?

a. Windows Authentication.
b. .NET Passport Authentication.
c. Forms Authentication.
d. All of the above. 
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

20)   Which attribute is necessary for HTML control to work as a HTML server control? 

a. runat=”server”
b. runat=”web-server”
c. ID=”server”
d. ID=”web-server”
Answer  Explanation 
ANSWER: runat=”server”

Explanation: 
No explanation is available for this question!

21)   MARS feature is disabled by default. What action you will perform in connection string to enable this feature? 

a. Set MultipleActiveResultSets=True"
b. Set MultipleResultSets=true"
c. Set ResultSets=True"
d. None of the above.
Answer  Explanation 
ANSWER: Set MultipleActiveResultSets=True"

Explanation: 
No explanation is available for this question!

22)   Which control can be used to update only the portion of the page?

a. UpdatePanel 
b. ScriptManager
c. AsyncPostBackTrigger
d. None of the above.
Answer  Explanation 
ANSWER: UpdatePanel

Explanation: 
No explanation is available for this question!

23)   Which is the mandatory property for all validation controls?

a. ControlToValidate 
b. Message
c. EnableClientScript
d. EnableServerScript
Answer  Explanation 
24)   Which object works on client side in state management system?

a. ViewState
b. cookies
c. Query strings
d. All of the above 
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!

25)   How many types of caching ASP.NET supports?

a. Page Output Caching
b. Partial Page Caching
c. Data Caching
d. DataSource Caching
e. All of the above.
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!



1)   If a user wants to create controls at runtime which event should be used to write code?

a. PreLoad
b. Load
c. Init
d. PreInit 
Answer  Explanation 
ANSWER: PreInit

Explanation: 
No explanation is available for this question!

2)   How will you add a TextBox control at runtime on the form? Choose the correct one.

a. TextBox obj = new TextBox(); 
    obj.ID = "txtUserName"; 
    form1.Controls.Add(obj);
b. form1.Controls.Add(TextBox);
c. this.FindControl.add(TextBox);
d. None of the above.
Answer  Explanation 
ANSWER: TextBox obj = new TextBox(); 
    obj.ID = "txtUserName"; 
    form1.Controls.Add(obj);

Explanation: 
No explanation is available for this question!

3)   You are creating an ASP.NET application for company CareerRide. You use form based authentication to validate users. You need to prevent unauthenticated users from accessing the application. What should you do?

a. In the authorization section of the Web.config file, set the users attribute of the deny element to “?” 
b. Set In the authorization section of the Web.config file, set the users attribute of the deny element to “*”
c. In the authorization section of the Machine.config file, set the users attribute to the allow element to s“?”.
d. None of the above.
Answer  Explanation 
ANSWER: In the authorization section of the Web.config file, set the users attribute of the deny element to “?”

Explanation: 
No explanation is available for this question!

4)   If any user has disabled cookies in their browsers, what can you do to enable them to use forms authentication?

a. Set BoweserCookieEnabled=true;
b. Set cookieless=true;
c. Use the AutoDetect setting of the cookieless attribute. 
d. None of the above.
Answer  Explanation
ANSWER: Use the AutoDetect setting of the cookieless attribute.

Explanation: 
No explanation is available for this question!

5)   What is the use of VaryByParam attribute in OutputCache directive?

a. You can neglect VaryByParam attribute while using Page output caching.
b. The VaryByParam attribute determines which versions of the page output are actually cached. 
c. The VaryByParam attribute determines which web page is cached in database.
d. None of the above.
Answer  Explanation 
ANSWER: The VaryByParam attribute determines which versions of the page output are actually cached.

Explanation: 
No explanation is available for this question!

6)   You need to programmatically configure page output caching. Which object would you use?

a. Request
b. Response 
c. Application
d. Server
Answer  Explanation 
ANSWER: Response

Explanation: 
No explanation is available for this question!

7)   Which control is required inside a content page to reference ContentPlaceHolder control inside the master page?

a. Content control on a content page. 
b. ContentPlaceHolder on a content page.
c. PlaceHolder control is required on content page.
d. None of the above.
Answer  Explanation 
ANSWER: Content control on a content page.

Explanation: 
No explanation is available for this question!

8)   At which level Theme can be applied?

a. Page level
b. Site level (through the Web.config file)
c. Individual control level
d. All of the above. 	
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

9)   When user request a web page by entering Uniform Resource Locator (URL) then which method /verb/command is used in ASP.NET?

a. POST
b. SET
c. GET 
d. All of the above.
Answer  Explanation 
ANSWER: GET

Explanation: 
No explanation is available for this question!

10)   HTTP messages are typically sent between the Web server and Web browser using which Port number?

a. 70
b. 80 
c. 400
d. 410
Answer  Explanation 
ANSWER: 80

Explanation: 
No explanation is available for this question!

11)   What type of data can Cookies store?

a. String 
b. DateTime
c. System.Int32
d. None of the above.
Answer  Explanation 
ANSWER: String

Explanation: 
No explanation is available for this question!

12)   What are the different types of Session Mode in ASP.NET?

a. InProc 
b. StateServer 
c. SQLServer 
d. All of the above 
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!

13)   Which validation control in ASP.NET can be used to determine if the data is entered into a TextBox control is of type Currency?

a. ValidationSummary
b. CompareValidator 
c. RequiredFieldValidator
d. None of the above.
Answer  Explanation 
ANSWER: CompareValidator

Explanation: 
No explanation is available for this question!

14)   CompareValidator control can be used for performing which task?

a. To perform a data type check.
b. To compare the value entered into a form field against a fixed value.
c. To compare the value of one form field against another.
d. All of the above. 
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

15)   Match the following List 1 to List 2

a. Client-side navigation ---------------------- i. Server.Transfer 
b. Cross-page posting ------------------------- ii. Response.Redirect
c. Client-side browser redirects ------------- iii. PostBackUrl
d. Server-side transfer ------------------------- iv. HyperLink

a. a-iv, b-iii, c-ii, d-i 
b. a-ii, b-iv, c-i, d-iii
c. a-ii, b-i, c-iii, d-iv
d. a-ii, b-iv, c-iii, d-i
Answer  Explanation 
ANSWER: a-iv, b-iii, c-ii, d-i

Explanation: 
No explanation is available for this question!

16)   You want to enable Page Output Caching in ASP.NET. What code you will write in ASPX page.


a. <%@ OutputCache Duration="30" VaryByParam="none" %> 
b. <%@ OutputCache VaryByParam="none" %>
c. <%@ OutputCache Duration="30" %>
d. None of the above.
Answer  Explanation 
ANSWER: <%@ OutputCache Duration="30" VaryByParam="none" %>

Explanation: 
No explanation is available for this question!

17)   How many types of Cache Dependencies are available in ASP.NET? 

a. File based dependencies
b. Key-based dependencies
c. Time-based dependencies
d. All of the above 
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!

18)   Choose the correct option according to given statements.

Statement 1: Authentication is the process that determines the identity of a user.
Statement 2: Authorization is the process of determining whether a user is permitted to access to any part of an application, or any particular resource.
Statement 3: Authorization is the process that determines the identity of a user.
Statement 4: Authentication is the process of determining whether a user is permitted access to any part of an application, or any particular resource.

a. Statement 1 and Statement 2 are correct. 
b. Statement 3 and Statement 4 are correct.
c. Statement 1 and Statement 3 are correct.
d. Statement 2 and Statement 4 are correct.
Answer  Explanation 
ANSWER: Statement 1 and Statement 2 are correct.

Explanation: 
No explanation is available for this question!

19)   You use the ASP.NET Web Site Administration Tool to configure ASP.NET membership with forms authentication. What should you name your login form so that you do not have to modify the Web.config file?

a. Login.aspx 
b. LoginPage.aspx
c. Default.aspx
d. Auth.aspx
Answer  Explanation 
ANSWER: Login.aspx

Explanation: 
No explanation is available for this question!

20)   What are the three main objects of DataSet?

a. DataTable, DataColumn, and type.
b. DataTable, DataRelation, and DataAdapter.
c. DataTable, DataColumn, and DataRelation. 
d. DataReader,DataAdapter, and Command.
Answer  Explanation 
ANSWER: DataTable, DataColumn, and DataRelation.

Explanation: 
No explanation is available for this question!

21)   On what object would you set the properties to create a primary key for a DataTable?

a. DataRelation
b. DataColumn
c. DataSet 
d. DataTable
Answer  Explanation 
ANSWER: DataSet

Explanation: 
No explanation is available for this question!

22)   How many 'ScriptManager' control can be added on a ASP.NET web page?

a. Only One 
b. More than One
c. Only Two
d. None of the above.
Answer  Explanation 
ANSWER: Only One

Explanation: 
No explanation is available for this question!

23)   Which property and method of the Page object do you use to register client script dynamically from code?

a. ScriptManager control is used to dynamically register client script from code.
b. The Page.ClientScript.RegisterClientScriptBlock is used to dynamically register client script from code. 
c. ScriptManagerProxy control is used to dynamically register client script from code.
d. None of the above.
Answer  Explanation 
ANSWER: The Page.ClientScript.RegisterClientScriptBlock is used to dynamically register client script from code.

Explanation: 
No explanation is available for this question!

24)   Match the following List 1 to List 2 

a. Web Form -------------------------- i. .ascx
b. Web User Control ---------------- ii. .asmx
c. Web Service ---------------------- iii. .aspx

a. a-iii, b-i, c-ii 
b. a-ii , b-i, c-iii 
c. a-i, b-ii, c-iii 

Answer  Explanation 
ANSWER: a-iii, b-i, c-ii

Explanation: 
No explanation is available for this question!

25)   To create your application on a remote server which option you will choose in ASP.NET?

a. File System
b. FTP 
c. HTTPS
d. None of the above.
Answer  Explanation 
ANSWER: FTP

Explanation: 
No explanation is available for this question!


1)   What is Multiple Active Result Sets (MARS)?


a. It allows execution of multiple batches against Database on a single connection.
b. New feature of SQL SERVER 2005. Previous version of SQL Server does not support this feature.
c. Option A and B are correct. 
d. None of the above.
Answer  Explanation 
ANSWER: Option A and B are correct.

Explanation: 
No explanation is available for this question!

2)   Which Data Provider gives the maximum performance when connect to SQL Server?

a. The SqlClient data provider. 
b. The OLE DB data provider.
c. The Oracle data provider
d. All of the above.
Answer  Explanation 
ANSWER: The SqlClient data provider.

Explanation: 
No explanation is available for this question!

3)   What property do you modify on a server control to minimize the size of the ViewState data?

a. ViewState=”true”
b. Set EnableViewState to false 
c. Set EnableViewState to true
d. None of the above
Answer  Explanation 
ANSWER: Set EnableViewState to false

Explanation: 
No explanation is available for this question!

4)   What are the client-side state management options that ASP.NET supports?

a. Application
b. Session
c. Querystring
d. Option a and b are correct 
Answer  Explanation 
ANSWER: Querystring

Explanation: 
No explanation is available for this question!

5)   Which Session Mode stores session Information in Current Application Domain?


a. InProc
b. StateServer 
c. SQLServer 
d. Off
Answer  Explanation 
ANSWER: InProc

Explanation: 
No explanation is available for this question!

6)   By default, when you use Page Output Caching, at what location page is cached?

a. Only on web server
b. Only on Client
c. Web server, any proxy servers, and browser 
d. All of the above.
Answer  Explanation 
ANSWER: Web server, any proxy servers, and browser

Explanation: 
No explanation is available for this question!

7)   What code you will write for using the cache object?

a. 
// Storing the value. 
Cache["name"]="CareerRide"; 
// Retrieving the value on any webpage within the application. 
if (Cache["name"] != null) 
Label1.Text= Cache["name"].ToString(); 

b. 
// Storing the value. 
Cache="CareerRide"; 
// Retrieving the value on any webpage within the application. 
if (Cache != null) 
Label1.Text= Cache.getStringValue;

c. 
// Storing the value. 
Cache["name"]="CareerRide"; 
// Retrieving the value on any webpage within the application. 
if (Cache["name"] != null) 
Label1.Text= Cache["name"].Text;

d. None of the above.
Answer  Explanation 
ANSWER: 
// Storing the value. 
Cache["name"]="CareerRide"; 
// Retrieving the value on any webpage within the application. 
if (Cache["name"] != null) 
Label1.Text= Cache["name"].ToString(); 

Explanation: 
No explanation is available for this question!

8)   Debug class is available in which namespace?

a. System.Debug
b. System.Data
c. System.Diagnostics 
d. None of the above
Answer  Explanation 
9)   Match the following List 1 to List 2

a. Literal Control ----------------- i. SingleLine, MultiLine, Password 
b. Label Control ------------------ ii. CommandName
c. TextBox Control -------------- iii. Convert to span tag in HTML
d. Button Control ---------------- iv. PassThrough, Encode, Transform mode


a. a-iv, b-iii, c-ii, d-i
b. a-ii, b-iv, c-i, d-iii
c. a-ii, b-i, c-iii, d-iv
d. a-iv, b-iii, c-i, d-ii
Answer  Explanation 
ANSWER: a-iv, b-iii, c-i, d-ii

Explanation: 
No explanation is available for this question!

10)   You are developing a Web page that contains many validated controls. You want to provide a detailed message for each validation error, but the page doesn’t have sufficient space to provide the detailed message next to each control. What can you do to indicate an error at the control and list the detailed error messages at the top of the Web page?

a. 
- Set the Text property of the validator control to the detailed message. 
- Set the ErrorMessage property to an asterisk (*). 
- Place a ValidationSummary control at the top of the Web page.

b. 
- Set the ErrorMessage property of the validator control to the detailed message. 
- Set the Text property to an asterisk (*). 
- Place a ValidationSummary control at the top of the Web page.

c. 
- Set the ToolTip property of the validator control to the detailed message. 
- Set the ErrorMessage property to an asterisk (*). 
- Place a ValidationSummary control at the top of the Web page.

d. None of the above
Answer  Explanation 
ANSWER: 
- Set the ErrorMessage property of the validator control to the detailed message. 
- Set the Text property to an asterisk (*). 
- Place a ValidationSummary control at the top of the Web page.

Explanation: 
No explanation is available for this question!

11)   A Master Page contains a ScriptManager control and a user wants the AJAX functionality on content page then which control is necessary on content page?

a. AsyncPostBackTrigger
b. ScriptManager
c. ScriptManagerProxy 
d. None of the above.
Answer  Explanation 
ANSWER: ScriptManagerProxy

Explanation: 
No explanation is available for this question!

12)   You are writing a page that contains an UpdatePanel for partial-page updates. You want that user should get the message “Processing is going on, please wait.” that the update is processing only if the update takes longer than 5 seconds. Which actions should you take?

a. Add a ProgressBar control to the page. Set the Interval property to 5000. Set the text property as “Processing is going on, please wait.” 
b. Add a Timer control to the page. Set the Interval property to 5000. Set its text property to Processing is going on, please wait.”
c. Add an UpdateProgress control to the UpdatePanel. Set its DisplayAfter property to 5000. Set its ProgressTemplate contents to read “Processing is going on, please wait.” 
d. None of the above.
Answer  Explanation 
ANSWER: Add an UpdateProgress control to the UpdatePanel. Set its DisplayAfter property to 5000. Set its ProgressTemplate contents to read “Processing is going on, please wait.”

Explanation: 
No explanation is available for this question!

13)   Which of the following is a valid skin code inside a skin file?

a. <asp:TextBox BackColor=”Yellow” BorderStyle=”Dotted” ID=”colorTxt” Runat=”Server”/>
b. <asp:TextBox BackColor=”Yellow” BorderStyle=”Dotted” Runat=”Server” />
c. <asp:TextBox BackColor=”Yellow” BorderStyle=”Dotted” ID=”colorTxt” />
d. None of the above.
Answer  Explanation 
ANSWER: <asp:TextBox BackColor=”Yellow” BorderStyle=”Dotted” Runat=”Server” />

14)   What are the basic steps to reference master page properties from a content page?
a. 
- Create a property in the master page code-behind file.
- Reference the master page property from the content page using the syntax Master.<Property_Name>
b. 
- Create a property in the master page code-behind file.
- Add the @ MasterType declaration to the .aspx content page. 
- Reference the master page property from the content page using the syntax Master.<Property_Name>

c. 
- Create a property in the master page code-behind file.
- Reference the master page property from the content page using the syntax Master.<Property_Name>
d. None of the above
Answer  Explanation 
ANSWER: 
- Create a property in the master page code-behind file.
- Add the @ MasterType declaration to the .aspx content page. 
- Reference the master page property from the content page using the syntax Master.<Property_Name>

Explanation: 
No explanation is available for this question!

15)   Which ADO.NET class provide Disconnected Environment?

a. DataReader
b. DataSet
c. Command
d. None of the above. 
Answer  Explanation 
ANSWER: DataSet

Explanation: 
No explanation is available for this question!

16)   Which ADO.NET class provide Connected Environment?

a. DataReader
b. DataSet
c. Command
d. None of the above
Answer  Explanation 
ANSWER: DataReader

Explanation: 
No explanation is available for this question!

17)   Match the following List 1 to List 2

a. App_Code ------------------------ i.  Assembly Resource Files (.resx) 
b. App_Data ------------------------ ii. .skin file, CSS files
c. App_Themes -------------------- iii. .mdf file, .mdb file
d. App_GlobalResources --------- iv. .wsdl files, typed datasets


a. a-iv, b-iii, c-ii, d-i
b. a-ii, b-iv, c-i, d-iii
c. a-ii, b-i, c-iii, d-iv
d. a-ii, b-iv, c-iii, d-i
Answer  Explanation 
ANSWER: a-iv, b-iii, c-ii, d-i

Explanation: 
No explanation is available for this question!

18)   In ASP.NET application DLL files are stored in which folder?

a. App_Code 
b. App_Data
c. Bin 
d. App_LocalResources 
Answer  Explanation 
ANSWER: Bin

Explanation: 
No explanation is available for this question!

19)   What types of data can you store in the Cache collection?

a. Only String Type of Data
b. You can store any type of data in the Cache collection.
c. Only DataSet Object
d. All of the above.
Answer  Explanation 
ANSWER: You can store any type of data in the Cache collection.

Explanation: 
No explanation is available for this question!

20)   How many types of parameter supported by OutputCache?

a. VaryByParam
b. VaryByControl
c. VaryByHeader
d. VaryByCustom
e. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!

21)   You want to secure the connection strings contained within your Web.config file to ensure that no one can open the file easily and see the connection information. Which tool must you use to encrypt the connection strings? 

a. ASPNET_WP.EXE
b. ASPNET_REGSQL.EXE
c. ASPNET_REGIIS.EXE 
d. None of the above.
Answer  Explanation 
ANSWER: ASPNET_REGIIS.EXE

Explanation: 
No explanation is available for this question!

22)   What are the three primary kinds of parameters are used while working with the Stored Procedure in ASP.NET?

a. Input, Integer, String
b. int, varchar, nvarchar
c. Input, Output, InputOutput 
d. All of the above.
Answer  Explanation 
ANSWER: Input, Output, InputOutput

Explanation: 
No explanation is available for this question!

23)   How do you execute multiple SQL statements using a DataReader?

a. Call the ExecuteReader method of a single Command object twice.
b. Set the Command.CommandText property to multiple SQL statements delimited by a semicolon. 
c. Set the Command.CommandType property to multiple result sets.
d. None of the above.
Answer  Explanation 
24)   When a User’s Session times out which event should you respond to?

a. Application_Start
b. Session_End 
c. Session_Start
d. Application_End
Answer  Explanation 
ANSWER: Session_End

Explanation: 
No explanation is available for this question! 

25)   Which of the following Web.config files correctly enables the Web application to track the LastVisit of anonymous users in a variable of type DateTime?
a. 
<anonymousIdentification enabled="true"/>
<profile> 
<properties> 
<add name="LastVisit" type="System.DateTime" allowAnonymous="true" /> 
</properties>
</profile>
b. 
<anonymousIdentification enabled="true"/>
<profile> 
<properties>
<add name=" LastVisit " allowAnonymous="true" /> 
</properties>
</profile>
c. 
<anonymousIdentification enabled="true" />
<profile> 
< properties>
< add name=" LastVisit " type="System. DateTime " /> 
</properties>
</profile>
d. 
<profile>
<properties> 
<add name="LastVisit" type="System. DateTime "/>
</properties> 
</profile>

Answer  Explanation 
ANSWER: 
<anonymousIdentification enabled="true"/>
<profile> 
<properties> 
<add name="LastVisit" type="System.DateTime" allowAnonymous="true" /> 
</properties>
</profile>

Explanation: 
No explanation is available for this question!

1)   A web page has lots of input data, and you want the data input to be spread across multiple screens. What is the best control to implement this solution on a single Web page?

a. ImageMap
b. Panel
c. Wizard 
d. None of the above.
Answer  Explanation 
ANSWER: Wizard

Explanation: 
No explanation is available for this question!

2)   Match the following List 1 (Controls) to List 2.

a. Image ------------------------- i. Navigate, PostBack, Inactive HotSpotMode 
b. ImageButton ---------------- ii. Container control
c. ImageMap ------------------- iii. Has command event
d. MultiView ------------------- iv. Does not have click event

a. a-iv, b-iii, c-i, d-ii 
b. a-ii, b-iv, c-i, d-iii
c. a-ii, b-i, c-iii, d-iv
d. a-iv, b-iii, c-i, d-ii
Answer  Explanation 
ANSWER: a-iv, b-iii, c-i, d-ii

Explanation: 
No explanation is available for this question!

3)   What are the steps to create a DataTable programmatically?

a. Instantiate a new DataTable and add DataColumn objects to the DataTable. Columns Collection. 
b. Run the Data Source Configuration Wizard.
c. Instantiate a new DataSet object.
d. None of the above.
Answer  Explanation 
4)   The three statements are given below about DataSet and DataReader, choose the correct option according to the statement.

Statement 1: DataSet Provides Disconnected environment but DataReader provides Connected environment. 
Statement 2: DataSet Provides Connected environment but DataReader provides Disconnected environment. 
Statement 3: DataSet Can store multiple table simultaneously but DataReader Supports a single table based on a single SQL query.

a. Only Statement 1 is correct.
b. Statement 1 and 2 is correct.
c. Statement 2 and 3 is correct.
d. Statement 1 and 3 is correct. 
Answer  Explanation 
ANSWER: Statement 1 and 3 is correct.

Explanation: 
No explanation is available for this question!

5)   The following group profile properties defined under a group name in Web.config file. How will you access Street and City property?

<properties>
<group name="Address">
<add name="Street" />
<add name="City" />
</group>
</properties> 


a. - Profile.name.Street
 - Profile.name.City
b. - Profile.Address.Street 
 - Profile.Address.City 
c. - Address.Street 
 - Address.City
d. None of the above.
Answer  Explanation 
ANSWER: - Profile.Address.Street 
 - Profile.Address.City

Explanation: 
No explanation is available for this question!

6)   Which control is required of every AJAX page to manage the JavaScript files sent to the client and the communication between client and server?

a. UpdatePanel
b. ScriptManager 
c. AsyncPostBackTrigger
d. None of the above.
Answer  Explanation 
ANSWER: ScriptManager

Explanation: 
No explanation is available for this question!

7)   The UpdatePanel supports two types of triggers: AsyncPostBackTrigger and PostBackTrigger. Choose the correct option regarding working of these triggers.

a. AsyncPostBackTrigger causes an asynchronous (Ajax) postback.
b. PostBackTrigger causes a normal entire-page postback.
c. AsyncPostBackTrigger causes a normal entire-page postback.
d. Option A and B are Correct. 
Answer  Explanation 
ANSWER: Option A and B are Correct.

Explanation: 
No explanation is available for this question!

8)   What is/are true about master page? Choose the correct option.

a. You can add more than one master page in a website.
b. Master page can be nested.
c. ContentPlaceHolder control is required on a content page.
d. Both A and B options are correct. 
Answer  Explanation 
ANSWER: Both A and B options are correct.

Explanation: 
No explanation is available for this question!

9)   What is/are true about master page?

a. Master page contains a <%@ Master %> directive instead of the normal <%@ Page %> directive.
b. ContentPlaceHolder control can be added only on master page.
c. You can add as many ContentPlaceHolders to a Master Page as you need.
d. All of the above. 
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

10)   To implement a specified .NET Framework interface which directive is used?

a. @Register
b. @Control
c. @Reference
d. @Implements 
Answer  Explanation 
ANSWER: @Implements

Explanation: 
No explanation is available for this question!

11)   Which of the following is not an ASP.NET page event? 

a. Init
b. Load
c. Import 
d. None of the above. 
Answer  Explanation 
ANSWER: Import

Explanation: 
No explanation is available for this question!

12)   How will you store and retrieve value in viewstate?

a. // Storing the data in viewstate
 ViewState[“SiteName”]=”CareerRide”; 
 // Retrieving Value from a View State
 Label1.Text = ViewState["SiteName "].ToString(); 
b. // Storing the data in viewstate
 ViewState obj=new ViewState
 ViewState [obj]=”CareerRide”;
 // Retrieving Value from a View State
 Label1.Text = ViewState[obj].ToString();
c. // Storing the data in viewstate
 ViewState=”CareerRide”;
 // Retrieving Value from a View State
 Label1.Text = ViewState.ToString();
d. None of the above.
Answer  Explanation 
13)   Which file is used to write the code to respond to the Application_Start event?

a. Any ASP.NET web page with an .aspx extension
b. Web.config
c. Global.asax 
d. None of the above.
Answer  Explanation 
ANSWER: Global.asax

Explanation: 
No explanation is available for this question!

14)    What is the difference between a Local Transaction and a Distributed Transaction?

a. Local transactions are performed on a single database table, but distributed transactions are performed on more than one database tables.
b. Local transactions are performed on a single database server, but distributed transactions can be performed across multiple database servers. 
c. Local transactions are performed on a database on the local machine, but distributed transactions are performed on a database on a remote machine.
d. None of the above.
Answer  Explanation 
ANSWER: Local transactions are performed on a single database server, but distributed transactions can be performed across multiple database servers.

Explanation: 
No explanation is available for this question!

15)   Choose the correct option about DataReader object.

a. DataReader object is a forward-only object.
b. It provides connection oriented environment.
c. DataReader is read only object.
d. All of the above 
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!

16)   Using which type of stylesheet we can change the style of an element in the entire website?

a. Internal Stylesheet 
b. External Stylesheet
c. Inline stylesheet
d. None of these above 
Answer  Explanation 
17)   How do you create a TextBox for retrieving a password from a user?

a. Set TextMode property of the TextBox control to Secret.
b. Set Mode property of the TextBox control to Password.
c. Set Text property of the TextBox control to Password. 
d. Set TextMode property of the TextBox control to Password. 
Answer  Explanation 
ANSWER: Set TextMode property of the TextBox control to Password.

Explanation: 
No explanation is available for this question!

18)   What is/are the advantages of StateServer session mode?

a. Its keeps the data separate from IIS so; if any Issue comes with IIS it will not hamper Session data. 
b. It is useful in web farm and web garden scenarios. 
c. Process is fast due to serialization and de-serialization.
d. A and B are the correct option. 
Answer  Explanation 
ANSWER: A and B are the correct option.

Explanation: 
No explanation is available for this question!

19)   What is/are the advantages of Session State?

a. It helps to maintain user data to all over the application and can store any kind of object.
b. Stores every client data separately. 
c. Session is secure and transparent from user. 
d. All of the above 
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!

20)   Choose the correct option about DataSet object.

a. Provides Disconnected mode
b. Can store multiple table simultaneously
c. Consumer Object
d. All of the above.
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

21)   You are a Web developer for CareerRide. The data is stored in a Microsoft SQL Server 2005 database on a server named CareerPC and the Database name is TestDB. You connect to TestDB by using Windows Integrated authentication. You use a SqlConnection object to connect to the database. You need to create a connection string to TestDB in the instance of SQL Server named CareerPC. Which string should you use?


a. “Data Source= CareerPC; Database=TestDB; Integrated Security=SSP1”.
b. “Data Source= CareerPC; Initial Catalog=TestDB; Integrated Security=SSP1”.
c. “Server= CareerPC; Database=TestDB; Integrated Security=SSP1”.
d. All of the above.
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

22)   Match the following List 1 with List 2:

a. Control ------------------ i. Controls the output caching policies of a page or user control. 
b. MasterType ------------ ii. Page directive uses with user controls.
c. PreviousPageType ---- iii. Enables an ASP.NET page to work with a postback from another page in the application. 
d. OutputCache ----------- iv. Associates a class name to a page to get references or members contained within the specified master page. 


a. a-ii, b-i, c-iv, d-iii
b. a-ii, b-iv, c-i, d-iii
c. a-ii, b-i, c-iii, d-iv
d. a-ii, b-iv, c-iii, d-i 
Answer  Explanation 
ANSWER: a-ii, b-iv, c-iii, d-i

Explanation: 
No explanation is available for this question!

23)   ASP.NET Validation Control works at ________ . 

a. Client side only.
b. Server side only.
c. Both Client Side and Server Side 
d. None of the above.
Answer  Explanation 
ANSWER: Both Client Side and Server Side

Explanation: 
No explanation is available for this question!

24)   Some control, by default, does not cause an automatic PostBack, i.e TextChanged event of TextBox. Which property will you set for automatic postback of these types of controls?

a. isPostBack=”false”
b. isPostBack=”true”
c. PostBack=”true”
d. AutoPostBack=”true” 
Answer  Explanation 
ANSWER: AutoPostBack=”true”

Explanation: 
No explanation is available for this question!

25)   What is the easiest way in Design view to create an event handler for the default event of a server control?


a. Open the code-behind page and write the code.
b. Right-click the control and select Create Handler.
c. Drag an event handler from the Toolbox to the desired control.
d. Double-click the control. 
Answer  Explanation 
ANSWER: Double-click the control.

Explanation: 
No explanation is available for this question!

26)   What are the types of Web Server Button Controls that can be created?

a. Only Submit buttons
b. Only Command buttons
c. Submit and command buttons 
d. None of the above.
Answer  Explanation 
ANSWER: Submit and command buttons

Explanation: 
No explanation is available for this question!

1)   Clicking a CheckBox does not cause an automatic PostBack. How do you make the CheckBox cause an automatic PostBack?

a. Set the AutoPostBack property to true. 
b. Add JavaScript code to call the ForcePostBack method.
c. Set the PostBackAll property of the Web Page to true.
d. None of the above
Answer  Explanation 
ANSWER: Set the AutoPostBack property to true.

Explanation: 
No explanation is available for this question!

2)   What happen in the Web Page when Init event occur?

a. ViewState is loaded on the page.
b. Each child control of the page is initialized to its design time values.
c. HTML is rendered.
d. None of the above
Answer  Explanation 
ANSWER: Each child control of the page is initialized to its design time values.

Explanation: 
No explanation is available for this question!

3)   What are the Command Object Methods?

a. ExecuteNonQuery
b. ExecuteReader
c. ExecuteScalar
d. All of the above 
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!

4)   If you want that command object should returns XML data then which method of Command Object will be used?

a. getXMLData
b. getXML
c. ExecuteXMLReader
d. None of the above.
Answer  Explanation 
ANSWER: ExecuteXMLReader

Explanation: 
No explanation is available for this question!

5)    Match the following List 1 to List 2:
       
a. UpdatePanel ------------------ i. If Master Page contains a ScriptManager then content page will use this control. 
b. UpdateProgress -------------- ii. ContentTemplate
c. Timer -------------------------- iii. ProgressTemplate 
d. ScriptManagerProxy -------- iv. Tick Event


a. a - iii b - ii c - iv d - i
b. a - ii b - iii c - iv d - i
c. a - i b - ii c - iv d - iii
d. a - i b - ii c - iii d – iv
Answer  Explanation 
ANSWER: a - ii b - iii c - iv d - i

Explanation: 
No explanation is available for this question!

6)   Windows-Based Authentication is well suited for ___________ .

a. Intranet environment 
b. Public web site
c. Desktop application
d. None of the above
Answer  Explanation 
ANSWER: Intranet environment

Explanation: 
No explanation is available for this question!

7)   What are the minimum attribute is required to create a connection string using SqlConnection object?

a. - Data Source
 - Initial Catalog
 - Integrated security=true
b. - Server
 - Database
 - Integrated security=true
c. Option A and B both are correct 
d. None of the above
Answer  Explanation 
ANSWER: Option A and B both are correct

Explanation: 
No explanation is available for this question!

8)   What datatype is returned when calling the ExecuteScalar method of a command object?

a. System.Int32
b. Object 
c. No. of effected records
d. None of the above
Answer  Explanation 
ANSWER: Object

Explanation: 
No explanation is available for this question!

9)   You want to make a configuration setting change that will affect only the current Web application. Which file will you change?

a. Global.asax
b. Web.config in the root of the Web application
c. Machine.config
d. All of the above
Answer  Explanation 
ANSWER: Web.config in the root of the Web application

Explanation: 
No explanation is available for this question!

10)   Which programming model should you implement if you want to separate your server-side code from your client-side layout code in a Web page?

a. Single-file model
b. Code-behind model 
c. Inline model
d. Client-server model
Answer  Explanation 
ANSWER: Code-behind model

Explanation: 
No explanation is available for this question!

11)   Which object in ASP.NET provides a global storage mechanism for state data that needs to be accessible to all pages in a given Web application?

a. Session
b. Application
c. ViewState
d. None of the above
Answer  Explanation 
12)   Which Session Mode Serialization is not required to store the data?

a. Off
b. InProc 
c. StateServer 
d. SQLServer 
Answer  Explanation 
ANSWER: InProc

Explanation: 
No explanation is available for this question!

13)   You are a Web developer for CareerRide. The data is stored in a Microsoft SQL Server 2005 database on a server named CareerPC and the Database name is TestDB. There is one GridView control on the page that you want to fill with table name Employee. Suppose that SqlConnection object is conObj and SqlCommand Object object is cmdObj. Which important properties of command object you will initialize to achieve this task?

a. cmdObj.CommandType = Text;
 cmdObj.Connection = conObj;
 cmdObj.CommandText = "select * from Employee";
b. cmdObj.CommandConnection = conObj; 
 cmdObj.CommandText = "select * from Employee";
c. cmdObj.CommandType = CommandType.Text;
 cmdObj.Connection = conObj;
 cmdObj.CommandText = "select * from Employee"; 
d. None of the above.
Answer  Explanation 
ANSWER: cmdObj.CommandType = CommandType.Text;
 cmdObj.Connection = conObj;
 cmdObj.CommandText = "select * from Employee";

Explanation: 
No explanation is available for this question!

14)   How will you create the SQL Server Connection Objects in Code? Choose the correct option.

a. SqlConnection con = new SqlConnection ("Data Source=ServerName; Initial Catalog=DatabaseName;Integrated Security=True");
b. SqlConnection con = new SqlConnection();
 con.ConnectionString = ("Data Source=ServerName; Initial Catalog=DatabaseName;Integrated Security=True");
c. using (SqlConnection con = new SqlConnection("Data Source=ServerName; Initial Catalog=DatabaseName;Integrated Security=True"))
 {
 con.Open();
 - - - - - - 
 - - - - - -
 }
d. All of the above codes are correct. 
Answer  Explanation 
ANSWER: All of the above codes are correct.

Explanation: 
No explanation is available for this question!

15)   Which of the following statements about referencing master page methods and properties is true? 

a. Content pages can reference controls in the master page.
b. Content pages can reference public properties in the master page.
c. Content pages can reference public methods in the master page.
d. All of the above. 
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

16)   Choose the correct option about Master Page and Theme.

a. A Master Page enables you to share content across multiple pages in a website and A Theme enables you to control the appearance of the content.
b. Theme enables you to share content across multiple pages in a website and A Master Page enables you to control the appearance of the content.
c. App_Themes folder contains skin files.
d. Option A and C are correct. 
Answer  Explanation 
ANSWER: Option A and C are correct.

Explanation: 
No explanation is available for this question!

17)   When should you use HTML Server control rather than Web Server controls?

a. You are migrating existing, classic ASP pages over to ASP.NET pages.
b. The control needs to have custom client-side JavaScript attached to the control’s events.
c. The Web page has lots of client-side JavaScript that is referencing the control.
d. All of the above.
Answer  Explanation 
ANSWER: All of the above.

Explanation: 
No explanation is available for this question!

18)   Which property will you set for each RadioButton Control in the group?

a. Specify the same GroupName for each RadioButton.
b. Specify the different GroupName for each RadioButton.
c. Specify the same GroupID for each RadioButton. 
d. Specify the same ID for each RadioButton.
Answer  Explanation 
ANSWER: Specify the same GroupName for each RadioButton.

Explanation: 
No explanation is available for this question!

19)   Which file contains settings for all .NET application types, such as Windows, Console, ClassLibrary, and Web applications?

a. Web.config
b. Machine.config 
c. Global.asax
d. All of the above
Answer  Explanation 
ANSWER: Machine.config

Explanation: 
No explanation is available for this question!

20)   Which object data is included in bookmarks and e-mailed URLs?

a. ViewState
b. cookies
c. Query strings
d. All of the above
Answer  Explanation 
ANSWER: Query strings

Explanation: 
No explanation is available for this question!

21)   If you want to validate the email addresses, Social Security numbers, phone numbers, and dates types of data, which validation control will be used?

a. RegularExpressionValidator
b. CompareValidator
c. RequiredFieldValidator
d. None of the above
Answer  Explanation 
ANSWER: RegularExpressionValidator

Explanation: 
No explanation is available for this question!

22)   When should you use the OleDbConnection object?

a. When connecting to an Oracle database.
b. When connecting to an Office Access database
c. When connecting to SQL Server 2000
d. None of the above
Answer  Explanation 
ANSWER: When connecting to an Office Access database

Explanation: 
No explanation is available for this question!

23)   In a SQL Statement while working with SqlCommand it returns a single value, at that time which method of Command Object will be used? 

a. ExecuteNonQuery
b. ExecuteReader
c. ExecuteScalar 
d. All of the above
Answer  Explanation 
ANSWER: ExecuteScalar

Explanation: 
No explanation is available for this question!

24)   According to the given below statements, choose the correct option.

Statement 1: Application caching is the process of storing data (and not pages) in a cache object.
Statement 2: Page output caching stores a rendered page, portion of a page, or version of a page in memory.
Statement 3: Caching reduces the time required to render cached page in future requests.


a. Only statement 1 is correct.
b. Statement 2 and 3 are correct.
c. Only statement 3 is correct.
d. All statements are correct. 
Answer  Explanation 
ANSWER: All statements are correct.

Explanation: 
No explanation is available for this question!

1)   Choose the correct one.  

int[] numbers = { 9, 10, 0, 11 }; 
  
        var nums = 
        from n in numbers 
        select n + 1; 
  
    foreach (var i in nums) 
    { 
        Console. Write (i+”,”); 
    } 


a. 10, 11, 1, 12
b. 10, 11, 12, 13
c. 9, 10, 0, 11 
d. None of these
Answer  Explanation 
ANSWER: 10, 11, 1, 12

Explanation: 
The LINQ Select statement has been used to add all the elements in an integer array by one and return the projected collection.
In the above code snippet, an integer type array, named numbers has been instantiated with {9, 10, 0, 11}. The Select operator operates on this numbers array and returns a collection in which every item is added by one.

2)   Choose the correct one. 

int[] numbers = { 9, 4, 1, 3, 8, 6, 7, 2,1 }; 
  
    var nums = numbers.Take(3);  
  
    foreach (var n in nums)   
    { 
  
        Console.WriteLine(n); 
  
    } 


a. 
7 
2 
1
b. 
9 
4 
1
c. 
3 
8 
6
d. 
1
4 
9
Answer  Explanation 
ANSWER: 
9 
4 
1

Explanation: 
Take function takes a number of elements from one collection, and places them in a new collection.
This method is available in the System.Linq namespace that allows you to get the specified number of contiguous elements from the start of a sequence.
In the above code snippet, take function will takes the first three elements from array. 
int[] numbers = { 9, 4, 1, 3, 8, 6, 7, 2,1 }; 

3)   Choose the correct one.  

int[] numbers = { 5, 4, 11, 3, 9, 8, 6, 7, 2, 0 };  
  
    var nums = numbers.Skip(4);    
  
    foreach (var n in nums)   
    {   
        Console.Write(n+”  “);   
    } 


a. 9867 2 0 
b. 5411398
c. 54113
d. None of the above
Answer  Explanation 
ANSWER: 9867 2 0

Explanation: 
Skip method ignored a specified number of elements in a sequence and then returns the remaining elements.
In the above code snippet, Skip(4) function will ignore the first four elements from array
int[] numbers = { 5, 4, 11, 3, 9, 8, 6, 7, 2, 0 }; 

4)   Choose the correct one.  

int[] A = { 0, 2, 4, 5, 6, 8 }; 
        int[] B = { 1, 3, 5, 7, 8 }; 
  
        var nums = A.Union(B);   
   
    foreach (var n in nums) 
    { 
        Console.Write(n+”  “); 
    } 


a. 0 24568 13578 
b. 0 2 4 5 6 8 1 3 7 
c. 0 1 2 3 4 5 6 7 8
d. None of the above
Answer  Explanation 
ANSWER: 0 2 4 5 6 8 1 3 7

Explanation: 
Union operator returns the union of two sequences. In the above code Union operator returns the sequence of number those are either in array A and B. It removes the duplicate entries.
The Union method will work with two collections of the same type of elements.

5)   Choose the correct one.  

int[] A = { 0, 2, 4, 5, 6, 8, 9 }; 
    int[] B = { 1, 3, 5, 7, 8 }; 
  
    IEnumerable nums = A.Except(B); 
  
    foreach (var n in nums) 
    { 
        Console.Write(n +”  “); 
    } 


a. 0, 2, 4, 5, 6, 8, 9 
b. 1, 3, 5, 7, 8 
c. 0 2 4 6 9
d. All of the above
Answer  Explanation 
ANSWER: 0 2 4 6 9

Explanation: 
In the above example the answer will be C because Except extension method produces the set difference of two sequences. The result is a collection where the second array's elements are subtracted from the first array.

6)   Which LINQ statement defines the range variable in a LINQ query?

a. from
b. select
c. join
d. where
Answer  Explanation 
ANSWER: from

Explanation: 
A Linq query must begin with a from clause. The from clause specifies the following:

•	The data source on which the query or sub - query will be executed.
•	A local range variable that represents each element in the source.
Example:
class Demo
{
static void Main()
{ 
Int [ ] numbers = {15, 4, 1, 3, 9, 8, 6, 7, 2, 0, 20};

var no = from num in numbers
wherenum< 4
selectnum;

foreach (intI in no)
{
Console.Write(I + “ “);
}
} 
}
// Output: 1 3 2 0

7)   Which query expression is used to limit the number of results?

a. Skip
b. Take
c. Where
d. Select
Answer  Explanation 
ANSWER: Take

Explanation: 
Take function takes a number of elements from one collection, and places them in a new collection.
This method is available in the System.Linq namespace that allows you to get the specified number of contiguous elements from the start of a sequence.

8)   Which interface defines the basic extension methods for LINQ?

a. IComparable<T>
b. IList
c. IEnumerable
d. IQueryable<T>
Answer  Explanation 
ANSWER: IEnumerable

Explanation: 
IEnumerable is a generic interface that defines the basic extension methods for LINQ. IEnumerable can move forward only over a collection. It is suitable for LINQ to Object and LINQ to XML queries.

9)   What LINQ expressions are used to shape results in a query?

1.	where
2.	select
3.	join
4.	group


a. 2, 4
b. 1, 2
c. 3, 4
d. None
Answer  Explanation 
10)   What types of shapes can LINQ query results be shaped into?

1.	Collections of primitive types
2.	Collections of complex types
3.	Single types
4.	Collections of anonymous types


a. 1, 2, 4
b. 1,2,3
c. 1,3,4 
d. None of the above
Answer  Explanation 
ANSWER: 1, 2, 4

Explanation: 
Primitive, complex, anonymous types shapes can LINQ query results be shaped.

11)   Which LINQ statement is used to merge two data sources to perform queries?

a. where
b. select
c. join
d. group
Answer  Explanation 
ANSWER: join

Explanation: 
The join clause is used to combine the elements of two different sources. The following are three most common join types:

•	Inner join
•	Group join
•	Left outer join

12)   Which LINQ keyword is used to categorize results in a query?

a. where
b. select
c. join
d. group
Answer  Explanation 
ANSWER: group

Explanation: 
By using group clause you can group your results based on a key that you specify. It can be inserted between a from clause and a select clause.

13)   Which of the following statements is true?

a. LINQ to SQL works with any database.
b. LINQ to SQL works with SQL Server.
c. LINQ to SQL is a CLR feature.
d. LINQ to SQL is a SQL Server feature.
Answer  Explanation 
ANSWER: LINQ to SQL works with SQL Server.

Explanation: 
LINQ to SQL works with SQL Server and it is optimal with sql server.

14)   LINQ query can work with?

a. DataSet
b. List<T>
c. Array
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
There are three types of LINQ.
1. Linq to Objects
2. Linq to SQL
3.Linq to XML
So in the above question all options are correct.

15)   How you can merge the results from two separate LINQ queries into a single result set.

a. Use the ToList method.
b. Use the DataContractJsonSerializer class.
c. Use the XElement class.
d. Use the Concat method.
Answer  Explanation 
16)   Which of the following objects represents a LINQ to SQL O / R map?

a. DataSet
b. XElement
c. ObjectContext
d. DataContext
Answer  Explanation 
ANSWER: DataContext

Explanation: 
A DataContext object represents a LINQ to SQL O / R map. ORM stands for Object-Relational Mapping. It is also called as O / R mapping.
DataContext class is used to connect with database, retrieve objects from it, and submit changes back to it.

17)   What is lamda expression?

1.	Anonymous function
2.	Can  be used to create delegates
3.	Named function
4.	None


a. 1, 2	
b. 1, 2, 3 
c. 1, 3 
d. 4
Answer  Explanation 
ANSWER: 1, 2

Explanation: 
A lambda expression is an anonymous function that can be used to create delegates. There are two types of lambda expression, Expression Lambda and Statement Lambdas. 

Example:
delegateint del(int i);
static void Main(string[ ] args)
{
delmyDelegate = x => x * x * x;
int j = myDelegate(4); 
}
In the above given example x is the parameter that is acted on by the expression x * x * x. So the value of x will be cube of x.

18)    Choose the correct one

a. The lambda must contain the same number of parameters as the delegate type.
b. The lambda should not contain the same number of parameters as the delegate type.
c. The return value of the lambda (if any) must be explicitly convertible to the delegate's return type
d. None of the above
Answer  Explanation 
ANSWER: The lambda must contain the same number of parameters as the delegate type.

Explanation: 
The lambda must contain the same number of parameters as the delegate type.
A delegate can refer only those methods that have same signature as delegate and lambda is nothing but anonymous function that can be used to create delegates.

19)   Choose the correct one.

a. The return value of the lambda (if any) must be explicitly convertible to the delegate's return type
b. Each input parameter in the lambda must be implicitly convertible to its corresponding delegate parameter.
c. Lamda expression does not work with LINQ.
d. None of the above
Answer  Explanation 
ANSWER: Each input parameter in the lambda must be implicitly convertible to its corresponding delegate parameter.

Explanation: 
Each input parameter in the lambda must be implicitly convertible to its corresponding delegate parameter because A delegate can refer only those methods that have same signature as delegate.

20)   Choose the correct one

a. Variables introduced within a lambda expression are not visible in the outer method.
b. Variables introduced within a lambda expression are visible in the outer method.
c. The lambda should not contain the same number of parameters as the delegate type.
d. None of the above
Answer  Explanation 
ANSWER: Variables introduced within a lambda expression are not visible in the outer method.

Explanation: 
A lambda expression is an anonymous function that you can use to create delegates
A variable, declared inside the anonymous method can’t be accessed outside the anonymous method but a variable, declared outside the anonymous method can be accessed inside the anonymous method.

21)   Choose the correct option.

a. Dynamic type is non - static type.
b. Dynamic type is static type.
c. Implicit conversion does not work with type dynamic.
d. None of the above
Answer  Explanation 
ANSWER: Dynamic type is static type.

Explanation: 
If you declare anything as dynamic then its type is checked at runtime. Dynamic type is static type.

22)   Which of the following statement is correct?

a. Anonymous types are class types that derive directly from object.
b. Anonymous types are not class types that derive directly from object.
c. Anonymous types are class types that derive directly from System.Class.
d. None of the above
Answer  Explanation 
ANSWER: Anonymous types are class types that derive directly from object.

Explanation: 
Anonymous types are class types that derive directly from object. You cannot cast to other type except object.Anonymous types are created by using new operator along with an object initializer.

Example:
var v = new {Website = “ CareerRide ”, Message = " Welcome " };
Console.WriteLine(v. Website + v.Message);

23)   What types of Objects can you query using LINQ?

a. DataTables and DataSets
b. Any .NET Framework collection that implements IEnumerable(T)
c. Collections that implement interfaces that inherit from IEnumerable(T)
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
In the above question all the options are correct. Any .NET Framework collection that implements IEnumerable(T) or that inherit from IEnumerable(T) can be queried using LINQ.

24)    When do LINQ queries actually run?

a. When they are iterated over in a foreachloop
b. When calling the ToArray() method on the range variable
c. When calling the ToList() method on the range variable
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
In the above question all options are correct. By default LINQ uses deferred query execution. It means that LINQ queries are always executed when you iterated the query variable, not when the query variable is created. LINQ queries actually run when they are iterated over in a foreach loop.

25)   Which of the following statement / s is / are true?

a. CommitChanges is a method of SqlDataContext.
b. CommitChanges is a method of DataContext.
c. CommitChanges is a method of DbDataContext.
d. CommitChanges is a method of OleDbData Context
Answer  Explanation 
ANSWER: CommitChanges is a method of DataContext.

Explanation: 
In LINQ, CommitChanges is a method of DataContext class. DataContext class is used to connect with database, retrieve objects from it, and submit changes back to it.
Example:
DataContext context = new DataContext( “ Provide your connection string ” );
You can also create and delete database as given below.
Create database 
context.CreateDatabase();

Delete database 
context.DeleteDatabase();

26)   Trace the output
namespace A
{
    class MyClass
    {
        public void fun()
        {
            Console.WriteLine( " C # is fun " );
        }
    }
    namespace B
    {
        class MyClass
        {
            public void fun()
            {
                Console.WriteLine( " C # is interesting " );
            }
        }
    }
}
Consider the above code what will be the output of following program
class Program
    {
        static void Main(string[] args)
        {
            A.B.MyClass obj = new A.B.MyClass();

            obj.fun();

        }

    }


a. C # is interesting
b. C # is fun
c. compile time error
d. None of the above
Answer  Explanation 
ANSWER: C # is interesting

Explanation: 
In the given problem there is nested namespace. The code A.B.MyClass obj = new A.B.MyClass(); will create the object that will refer to namespace B, so the inner class method will be called and answer will be 
“C # is interesting”

27)   Trace the output
namespace A
{
    class MyClass
    {
        public void fun()
        {
            Console.WriteLine("C # is fun");
        }
    }
    namespace B
    {
        class MyClass
        {
            public void fun()
            {
                Console.WriteLine("C # is interesting");
            }
        }
    }
}
Consider the above code what will be the output of following program
class Program
    {
        static void Main(string[] args)
        {

            A.MyClass obj = new A.MyClass(); 
            obj.fun();
        }

    }


a. C # is interesting
b. C # is fun
c. cmpile time error
d. None of the above
Answer  Explanation 
ANSWER: C # is fun

Explanation: 
No explanation is available for this question!

28)   Trace the output
class Myclass
{
   public  int count = 0;
   public  Myclass()
    {
        count++;
    }
}


    class Program
    {
        static void Main(string[] args)
        {
            Myclass obj1 = new Myclass(); 
            Console.WriteLine(obj1.count);

            Myclass obj2 = new Myclass();
            Console.WriteLine(obj2.count);

            Myclass obj3 = new Myclass();
            Console.WriteLine(obj3.count);
        }

    }


a. 1, 1, 1
b. 1, 2, 3
c. 0, 1, 2
d. All of the above
Answer  Explanation 
ANSWER: 1, 1, 1

Explanation: 
In the above example three different objects are created of class Myclass. So every time count is reinitialized with zero and constructor will be called. Here count variable is non - static therefore separate copy of count will be created for each object. So the answer will be 1 1 1.

29)   An interface can contain declaration of?

a. Methods, properties, events, indexers
b. Methods
c. Static members
d. All of the above
Answer  Explanation 
ANSWER: Methods, properties, events, indexers

Explanation: 
An interface can contain declaration of methods, properties, events, indexers but you cannot provide the definition.

30)   Which of the following are correct?

1.	An interface can be instantiated directly.
2.	Interfaces can contain constructor.
3.	Interfaces contain no implementation of methods.
4.	Classes and structs can implement more than one interface.
5.	An interface itself can inherit from multiple interfaces.


a. 3,4,5 
b. 1,2,3 
c. 2,3,4 
d. All of the above
Answer  Explanation 
ANSWER: 3,4,5

Explanation: 
Interfaces are like classes but we cannot provide definition of methods in interface. We can only declare the methods not implementation in interface. A class must implement all its members that is inheriting the interface.
An interface has the following properties:

•	An interface cannot be instantiated directly.
•	Interfaces can contain events, indexers, methods and properties.
•	Interfaces contain no implementation of methods.
•	Classes and structs can inherit from more than one interface.
•	An interface can itself inherit from multiple interfaces.

31)   Which of the following are correct?

1.	Delegates are like C++ function pointers.
2.	Delegates allow methods to be passed as parameters.
3.	Delegates can be used to define callback methods.
4.	Delegates are not type safe.


a. 1,3,4 
b. 1,2,3 
c. 2,3,4
d. All of the above
Answer  Explanation 
ANSWER: 1,2,3

Explanation: 
A delegate is an object that can refer to a method. It means that it can hold a reference to a method. The method can be called through this reference or we can say that a delegate can invoke the method to which it refers. The main advantage of a delegate is that it invokes the method at run time rather than compile time. Delegate in C# is similar to a function pointer in C / C++.
A delegate can call only those methods that have same signature and return type as delegate. So the option 1, 2, 3 are correct.

32)   Properties in .NET can be declare as

1.	Static, Protected internal, Virtual
2.	Public, internal, Protected internal
3.	Only public 
4.	None


a. 1, 2	
b. 3
c. 1, 2, 3
d. 4
Answer  Explanation 
ANSWER: 1, 2

Explanation: 
Properties are not variables. Properties are an extension of fields and are accessed using the same syntax. Properties cannot be passed as a ref or out parameter.A property is one or two code blocks, representing a get accessor or a set accessor or both. A property without a set accessor is considered read-only. A property without a get accessor is considered write - only. 
Properties can be marked as public, private, protected, internal, protected internal, static, virtual.

33)   Which of the following statements are correct?

1.	Indexers enable objects to be indexed in a similar manner to arrays.
2.	The this keyword is used to define the indexers.
3.	Indexers can be overloaded.
4.	Indexer cannot be used in interface


a. 1, 2
b. 3 
c. 1,2,3	
d. None of the above
Answer  Explanation 
ANSWER: 1,2,3

Explanation: 
The indexer has following properties.
•	Indexers enable objects to be indexed in a similar manner to arrays.
•	A get accessor returns a value. A set accessor assigns a value.
•	The this keyword is used to define the indexers.
•	The value keyword is used to define the value being assigned by the set indexer.
•	Indexers can be overloaded.
Example:
classIndDemo
{
privateint [ ] arr = new int[3];
publicint this[int i]
{
get
{
returnarr[i];
}
set
{
arr[i] = value;
}
}
}

class Program
{
static void Main(string[] args)
{
IndDemoobj = new IndDemo();
obj[0] = 10;
Console.WriteLine(obj[0]);
}
}

34)   The best way for handling exception when dealing with a database connection?

a. Implement a try / catch block that catches System.Exceptions.
b. Implementing custom error page.
c. Implement a try / catch block that catches individual exception types, such as SQLException.
d. Display an error message.
Answer  Explanation 
ANSWER: Implement a try / catch block that catches System.Exceptions.

Explanation: 
System.Exception is base class for all type of exceptions. This class can handle any type of exception. So for handling exception while working with database connectivity use try/catch block that catches System.Exceptions.

35)   For building new types at runtime which class can be used?

a. System
b. System.Object
c. System.NewClass
d. System.Reflection.Emit.
Answer  Explanation 
ANSWER: System.Reflection.Emit.

Explanation: 
For building new types at runtime System.Reflection.Emit namespace will be used. This namespace provides you a number of classes which you can use to build your type. Some of the important classes in this namespace are 

•	AssemblyBuilder
•	ModuleBuilder
•	ConstructorBuilder
•	MethodBuilder
•	EventBuilder
•	PropertyBuilder

36)   Reflection can be used when?

a. To access attributes in your program's metadata
b. To create type at compile time
c. To access attributes at compile time.
d. None of the above
Answer  Explanation 
ANSWER: To access attributes in your program's metadata

Explanation: 
Reflection is used toaccess attributes in your program's metadata. In .NET the metadata contains the type information of method, property, event, delegate, and enumeration. CLR use this metadata to load and execute code.

37)   Choose the correct one

1)	XML serialization serializes the public fields and properties of an object.
2)	XML serialization serializes the private fields and properties of an object.
3)	XML serialization serializes only the public methods.


a. Only 1
b. Only 2
c. Only 1 & 2
d. All of the above
Answer  Explanation 
ANSWER: Only 1

Explanation: 
XML serialization can serialize only public data. You cannot serialize private data.

Example:
FileStreamfs = new FileStream(" MyFile.XML ", FileMode.Create);
XmlSerializerobj = new XmlSerializer(typeof(DateTime));
obj.Serialize(fs, System.DateTime.Now);
fs.Close();

38)   Choose the correct one

1)	Sealed class can be declared as abstract
2)	Abstract class cannot be declared as abstract
3)	Abstract class can  be declared as abstract


a. Only 1
b. Only 2
c. Only 1 & 2
d. All of the above
Answer  Explanation 
ANSWER: Only 1

Explanation: 
If you declare any class as a sealed class then this class cannot be inherited. A sealed class cannot be used as a base class. So, it cannot also be an abstract class.

39)   A write - only property can be specified if the following is present.

a. The set modifier only
b. The get modifier only
c. Both the modifiers
d. None of the modifiers
Answer  Explanation 
ANSWER: The set modifier only

Explanation: 
A property is called as write-only property if it has set modifier only. Properties can be think as an extension of fields. A property is one or two code blocks, representing a get accessor or a set accessor or both.

40)   An indexer is 

a. A class
b. A structure
c. An enumeration
d. A special type of property
Answer  Explanation 
ANSWER: A special type of property

Explanation: 
An indexer is a special type of property. this keyword is used to define the indexers. A get accessor returns a value. A set accessor assigns a value.


1)   You need to select a class that is optimized for key - based item retrieval from both small and large collections. Which class should you choose?

a. OrderedDictionary class
b. HybridDictionary class
c. ListDictionary class
d. Hashtable class
Answer  Explanation 
ANSWER: HybridDictionary class

Explanation: 
HybridDictionary classes optimized for key-based item retrieval from both small and large collections. If the numbers of items are less then it works as ListDictionary and only when the list becomes too large it converts automatically into a Hashtable internally.
If you do not know how large your collection is, then HybridDictionary class should be used.

2)   You need to identify a type that meets the following criteria:

•	Is always a number.
•	Is not greater than 65,535.

Which type should you choose?


a. System.UInt16
b. int
c. System.String
d. System.IntPtr
Answer  Explanation 
ANSWER: System.UInt16

Explanation: 
The maximum value of System.UInt16 is 65535 so you can store more than this value.

3)   Which of the following is dictionary object?


a. HashTable
b. SortedList
c. NameValueCollection
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
HashTable, SortedList, NameValueCollection are dictionary objects because it store data in key-value form.

Example:
Hashtableht = new Hashtable();
ht["CompId"] = "1";
ht["CompName"] = "CareerRide";
foreach (DictionaryEntryob in ht)
{
Console.WriteLine(ob.Key+" : "+ob.Value);
}

4)   You want to configure the application to use the following authorization rules in web.config file.

• Anonymous users must not be allowed to access the application.
• All employees except ABC must be allowed to access the application.


a. 
<authorization> 
<deny users=”ABC”> 
<allow users=”*”> 
<deny users=”?”> 
</authorization>
b. 
<authorization> 
<allow users=”*”> 
<deny users=”ABC”> 
<deny users=”?”> 
</authorization>
c. 
<authorization> 
<allow users=”ABC”> 
<allow users=”*”> 
</authorization>
d. 
<authorization> 
<deny users=”ABC”> 
<deny users=”?”> 
<allow users=”*”> 
</authorization>
Answer  Explanation 
ANSWER: 
<authorization> 
<deny users=”ABC”> 
<deny users=”?”> 
<allow users=”*”> 
</authorization>

Explanation: 
First you deny user ABC. Then you deny anonymous users access by writing <deny users=”?”>. And last we allow to all other users access. This is proper order of the elements for the requirements of this scenario.

5)   An assembly must have an permission to connect with web server is?

a. socketPermission
b. DnsPermission
c. WebPermission
d. TCPPermission
Answer  Explanation 
ANSWER: WebPermission

Explanation: 
No explanation is available for this question!

6)   Thread class has the following property.

A.	ManagedThreadID
B.	IsBackground
C.	IsBackgroundColor
D.	Abort


a. 1, 2 
b. 1, 4 
c. 4
d. 1 ,2, 4
Answer  Explanation 
7)   Which delegate is required to start a thread with one parameter?

a. ThreadStart
b. ParameterizedThreadStart
c. ThreadStartWithOneParameter
d. None of the above
Answer  Explanation 
ANSWER: ParameterizedThreadStart

Explanation: 
ParameterizedThreadStart is a delegate that refers to a method that have single parameter.

Example:
class Program
{
static void Main(string[] args)
{
ParameterizedThreadStartts = new ParameterizedThreadStart(Counting);
Thread obj = new Thread(ts);

obj.Start("careerride");

}
static void Counting(Object obj)
{
stringstr=(string)obj;
Console.WriteLine("Welcome at "+str);
for (int i = 1; i <= 10; i++)
{
Console.WriteLine("Count: {0}", i);
Thread.Sleep(10);
}
}
}

8)   For locking the data with synchronization which class will be used?

a. Lock
b. Moniter
c. SyncLock
d. Deadlock
Answer  Explanation 
ANSWER: Moniter

Explanation: 
By using Moniter class a block of code can be access by one thread at a time. Moniter.Enter() method allows only one thread to access the resource.

Example:
public void ShowNumbers()
{
Monitor.Enter(this);
try
{
for (int i = 0; i < 5; i++)
{
Thread.Sleep(100);
Console.Write(i + ",");
}
Console.WriteLine();
}
finally
{
Monitor.Exit(this);
}
}

9)   How many readers can simultaneously read data with ReaderWriterLock if there is no writer locks apply?

a. 9
b. 11
c. 13
d. No Limit
Answer  Explanation 
ANSWER: No Limit

Explanation: 
There is no limit for number of users to access the data if ReaderWriterLock is applied. By using ReaderWriterLock you can synchronize access to a resource. It allows concurrent read access to multiple users. ReaderWriterLock class is available in System.Threading namespace.

10)   Which of the following are value types?

a. String
b. System .Value
c. System.Drawing
d. System.Drawing.Point
Answer  Explanation 
ANSWER: System.Drawing.Point

Explanation: 
There are two types are available in C#. Value Type and Reference Type. Value type are allocated on stack and reference types are allocated on managed heap. Predefined datatypes, structures, enums are value types. Class, Sting, Object etc are reference types. In the above example Point is struct so it is value type.

11)   Which of the following are reference types?

a. String
b. Exception
c. Class
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
No explanation is available for this question!

12)   Why should you write the cleanup code in Finally block?

a. Compiler throws an error if you close the connection in try block.
b. Resource cannot be destroyed in catch block.
c. Finally blocks run whether or not exception occurs.
d. All of the above
Answer  Explanation 
ANSWER: Finally blocks run whether or not exception occurs.

Explanation: 
The finally block always executes whether exception occurs or not. Finally block run when control leaves a try statement. You can write all cleanup code in finally block.

Example:
class Program
{
staticint a = 10, b = 0, c;
static void Main(string[] args)
{

try
{
c = a / b;
}
finally
{
Console.WriteLine(c);
}

}
}

13)   When the garbage collector runs.

a. It runs automatically
b. EveryDay
c. Every alternate day
d. When IIS restart.
Answer  Explanation 
ANSWER: It runs automatically

Explanation: 
We create the object, use it and generally forget to delete. Garbage collector is automatic memory management process that releases the memory used by the objects. Garbage collector runs automatically and it checks for objects in the managed heap that are no longer being used by the application and performs the necessary action to regain memory.
It allows us to develop an application without having worry to free memory.

14)   Which of the following is true ?

1.	AJAX is a platform-independent technology
2.	AJAX can work with web application
3.	AJAX can only work with ASP.NET
4.	AJAX is a platform-dependent technology


a. 1, 2
b. 1,2,3 
c. 1,3,4
d. None of the above
Answer  Explanation 
ANSWER: 1, 2

Explanation: 
AJAX is a platform-independent technology that works with Web applications. Ajax (Asynchronous JavaScript And XML) enables your client - side web pages to exchange data with the server through asynchronous calls. By using AJAX you can create flicker - free pages that enable you to refresh partial page without a full reload and without affecting other parts of the page.

15)   Which control is required for every page that have AJAX Extensions for ASP.NET?

a. UpdatePanel
b. ScriptManager
c. ContentPanel
d. None of the above
Answer  Explanation 
ANSWER: ScriptManager

Explanation: 
ScriptManager control is required for every page that have AJAX Extensions for ASP.NET The ScriptManager control manages the communication between the client page and the server.You can directly drag and drop this control on content page. It does not have a visual representation. It only used to manage AJAX processing. You cannot use more than one ScriptManager control on single web page. 

<asp: ScriptManager ID=" ScriptManager1 " runat=" server ">
</asp: ScriptManager>

16)   AnUpdatePanel control defined on a page. Button control is placed outside of the UpdatePanel. How to cause the UpdatePanel to execute an update. 

a. Set the Trigger attribute of the UpdatePanel to the ID of the Button control.
b. Set the AsyncPostBackTrigger attribute of the Button control to the ID of theUpdatePanel.
c. Place the button control on the update panel without script manager.
d. Add an AsyncPostBackTrigger control to the Triggers section of the UpdatePanel. Set the ControlID attribute of the AsyncPostBackTrigger control to the ID of the Button control.
Answer  Explanation 
ANSWER: Add an AsyncPostBackTrigger control to the Triggers section of the UpdatePanel. Set the ControlID attribute of the AsyncPostBackTrigger control to the ID of the Button control.

Explanation: 
To connect a control that is outside an UpdatePanel and you want that this outside control should trigger the update then you should register it as an asyncPostBackTrigger in the Triggers section of the UpdatePanel markup.

<asp:UpdatePanel ID="UpdatePanelVendors" runat="server">
<Triggers>
<asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
</Triggers>
</asp:UpdatePanel>

17)   Which method is used to dynamically register client script from code?

a. Page.ClientScript.RegisterClientScriptBlock
b. RegisterScript
c. Page.ClientScript
d. None of the above
Answer  Explanation 
ANSWER: Page.ClientScript.RegisterClientScriptBlock

Explanation: 
Page.ClientScript.RegisterClientScriptBlock method is used to dynamically register client script from code.

18)   Which interface you will use wrap an AJAX client control into a custom server control?

a. IScriptManager
b. IScriptControl
c. IScriptAJAX
d. None of the above
Answer  Explanation 
ANSWER: IScriptManager

Explanation: 
No explanation is available for this question!

19)   What is jQuery?

1.	jQuery is an open source library
2.	It works client side.
3.	jQuery is java technology.


a. 1, 2
b. 1, 2, 3 
c. 1, 3
d. None of the above
Answer  Explanation 
ANSWER: 1, 2

Explanation: 
jQuery is java script library that works on client side. By using jQuery it is much easier to use JavaScript on your website.
The main feature of jQuery is as follows

•	HTML / DOM manipulation
•	CSS manipulation
•	HTML event methods
•	Animations
•	AJAX

20)   If you must use a user name and password to connect to a database, where should you store the sensitive information?

a. Compiled in the application
b. In an encrypted application configuration file
c. In a resource file deployed with the application
d. In the registry
Answer  Explanation 
ANSWER: In an encrypted application configuration file

Explanation: 
If your connection string contains sensitive information then encrypted application configuration file by using RsaProtectedConfigurationProvider:

21)   What is the recommended method for securing sensitive connection string information?

a. Encrypting the data in the application configuration file
b. Using a code obfuscator
c. Using Integrated Security (Windows Authentication)
d. Querying the user for his or her credentials at run time
Answer  Explanation 
ANSWER: Using Integrated Security (Windows Authentication)

Explanation: 
No explanation is available for this question!

22)   What are the element of code access security?

a. Evidence,Permission
b. SQLSecurity
c. UserInterface
d. SQL Injection
Answer  Explanation 
23)   What is Caspol?

a. Command line tool
b. Code access security policy tool
c. Case Tool
d. Command line tool & Code access security policy tool
Answer  Explanation 
ANSWER: Command line tool & Code access security policy tool

Explanation: 
Caspol is command line code access security policy tool. By using this tool administrator can modify security policy for the following level.

Machine policy level.
User policy level.
Enterprise policy level.

24)   Which data provider gives the maximum performance from a connection to SQL Server?

a. The OLE DB data provider.
b. The JDBC data provider.
c. The SqlClient data provider.
d. The Oracle data provider
Answer  Explanation 
ANSWER: The SqlClient data provider.

Explanation: 
The SqlClient data provider gives the maximum performance from a connection to SQL Server.
Data provider works as a bridge between an application and a data source.SQL Server.NET Data Provider available in the System.Data.SqlClient namespace.

25)   Which CommandType value is incorrect?

a. StoredProcedure
b. TableDirect
c. TableSchema
d. Text
Answer  Explanation 
ANSWER: TableSchema

Explanation: 
The TableSchema value is wrong because it is not a CommandType enumeration value.

26)   Which SqlCommand execution returns the value of the first column of the first row from a table?

a. ExecuteNonQuery
b. ExecuteReader
c. ExecuteXmlReader
d. ExecuteScalar
Answer  Explanation 
ANSWER: ExecuteScalar

Explanation: 
EecuteScalar method of SqlCommand object returns the value of the first column of the first row from a table.
The common methods of command abject are as follows.

•	ExecuteReader: This method works on select SQL query. It returns the DataReader object. Use DataReader read () method to retrieve the rows.
•	ExecuteScalar: This method returns single value. Its return type is Object.If you call ExecuteScalar method with a SQL statement that returns rows of data, the query returns only the first column of the first row. 
•	ExecuteNonQuery: If you are using Insert, Update or Delete SQL statement then use this method. Its return type is Integer (The number of affected records).

27)   Which SqlCommand execution returns the number of effected records in the table?

a. ExecuteNonQuery
b. ExecuteReader
c. ExecuteXmlReader
d. ExecuteScalar
Answer  Explanation 
28)   OleDbConnectionobject works with?

1.	When connecting to an Oracle database
2.	When connecting to an Office Access database
3.	When connecting to SQL Server 6.x or later
4.	When connecting to SQL Server 2000


a. 1, 2
b. 2, 3
c. 1, 3
d. 4
Answer  Explanation 
ANSWER: 2, 3

Explanation: 
OleDbConnection object is used to connect to SQL Server 6.x or later. It is also used to connect with access database.
Example of connection string.
Provider = Microsoft.ACE.OLEDB.12.0;
Data Source = C:\myFolder\myAccessFile.accdb;
Persist Security Info = False;

29)   What is the minimal information needed by a connection string to open a connection to a SQL Server 2000 or SQL Server 2005 database? 

1. A valid data source
2. A valid provider name
3. A valid file path
4. Appropriate credentials or Integrated Security settings


a. 1, 2
b. 1, 2, 3
c. 1, 3
d. 1, 4
Answer  Explanation 
ANSWER: 1, 4

Explanation: 
A valid data source, appropriate credentials or Integrated Security settings needed by a connection string to open a connection to a SQL Server 2000 or SQL Server 2005 database.
Example:
String conString = "Data Source = PC name; Initial Catalog = your DataBasename;
Integrated Security = SSPI;"

30)   What happens when you call the Close method of a connection object? 

1. The connection is destroyed.
2. The connection is returned to the connection pool.
3. The StateChangeevent is fired.
4. All non - committed pending transactions are rolled back.


a. 1, 2
b. 1,3
c. 2, 3, 4
d. All of the above
Answer  Explanation 
ANSWER: 2, 3, 4

1)   What determines the connection pool that a connection should use? 

1. A connection string
2. The identity or credentials of the user opening the connection
3. The database being connected to
4. The connection object used to connect to the database


a. 1, 2
b. 1, 2, 3
c. 1, 3
d. 1, 4
Answer  Explanation 
ANSWER: 1, 2

Explanation: 
Connecting with the database is time consuming and resource intensive task. Connection pool is cache that stores connection string. These connection strings can be reused for future requirements.Only connections with the same configuration can be stored in a pool. Connections are divided into pools by connection string and by identity when integrated security is used.
Connection pooling removes the overhead of making a new connection.

2)    What are the recommended techniques for enabling connection pooling on for a SQL Server 2000 or SQL Server 2005 database? 

1. Setting the OLE DB Services connection string keyword to -4
2. Opening a connection and not explicitly disabling pooling
3. Setting the connection string keyword Pooling = True in the connection string
4. Using the Connection Pooling tab of the ODBC Data Source Administrator dialog
Box


a. 1, 2
b. 1, 2, 3
c. 2, 3
d. 1, 4
Answer  Explanation 
ANSWER: 2, 3

Explanation: 
For enabling connection pooling on for a SQL Server 2000 or SQL Server 2005 database set pooling = true and should not explicitly disable it.

3)   How do I explicitly turn on connection pooling for an OLE DB data source?

a. By setting the OLE DB Services connection string keyword to 0
b. By setting the OLE DB Services connection string keyword to -4
c. By setting the OLE DB Services connection string keyword to -1
d. By setting the OLE DB Services connection string keyword to -7
Answer  Explanation 
ANSWER: By setting the OLE DB Services connection string keyword to -1

Explanation: 
No explanation is available for this question!

4)   What property contains the actual error message returned by SQL Server? 

1. SqlException.Source
2. SqlException.Message
3. SqlError.Class
4. SqlError.Message


a. 1, 2
b. 1, 2, 3
c. 1, 3
d. 2, 4
Answer  Explanation 
ANSWER: 2, 4

Explanation: 
SqlException.Message and SqlError.Messageproperty contains the actual error message returned by SQL Server.

5)   What is the connection string’s key / value pair for using WindowsAuthentication in SQLServer 2000 and SQL Server 2005? 

a. 1, 2
b. 1, 2, 3
c. 2, 3
d. 1, 4
Answer  Explanation 
ANSWER: 2, 3

Explanation: 
You can provide yes, no, true, SSPI and false value to Integrated Security property of connection string according to the requirement. If Integrated Security= truethen current Windows account credentials are used for authentication. SSPI is equivalent to specifying True.

6)   What are the Command object property settings to execute a stored procedure?

1. CommandType = Text, CommandText = stored procedure name
2. CommandType= Text, CommandText = SQL syntax to execute the stored
procedure
3. CommandType = StoredProcedure, CommandText = SQL syntax to execute the
stored procedure
4. CommandType = StoredProcedure, CommandText = stored procedure name


a. 1, 2
b. 1, 2, 3
c. 2, 4
d. 1, 4
Answer  Explanation 
ANSWER: 2, 4

Explanation: 
You can execute stored procedure by using Command object.
SqlCommandcmd = new SqlCommand();
cmd.Connection = ConnectionString;
cmd.CommandType = CommandType.StoredProcedure;
cmd.CommandText = "stored procedure name ";

7)   What should you do to access the returned tabular data after starting execution of a command that runs asynchronously? (Choose all that apply.)

1. Call the EndExecuteNonQuerymethod.
2. Call the EndExecuteReadermethod.
3. Wait for the StatementCompletedevent to fire and iterate through the DataReader.
4. Wait for the StatementCompletedevent to fire, call the EndExecuteReadermethod, and then iterate through the DataReader.


a. 1, 2
b. 1, 2, 3
c. 2, 3
d. 2, 4
Answer  Explanation 
ANSWER: 2, 4

Explanation: 
No explanation is available for this question!

8)   How do you execute multiple SQL statements using a DataReader?

a. Call the ExecuteReadermethod of two Command objects and assign the results tothe same instance of a DataReader.
b. Call the ExecuteReadermethod of a single Command object twice.
c. Set the Command.CommandTextproperty to multiple SQL statements delimited by a semicolon.
d. Set the Command.CommandTypeproperty to multiple result sets.
Answer  Explanation 
9)   When would you typically use an Input parameter? 

1. When the parameter value is created based on user input
2. When the parameter is used to send data from the application to the database
3. When the command is set to execute a statement with a WHERE clause
4. When the parameter value is passed to an INSERT statement


a. 1, 2
b. 1, 2, 3
c. 2, 3
d. 1, 4
Answer  Explanation 
ANSWER: 2, 3

Explanation: 
Input parameter is used to send data from the application to the database. You can also use input parameter in where clause. By default the parameter direction is input type. Parameters are created by using Parameter class.

10)   What are the three primary kinds of parameters?

a. Input, Integer, String
b. Integer, String, DateTime
c. int, varchar, nvarchar
d. Input, Output, InputOutput
Answer  Explanation 
ANSWER: Input, Output, InputOutput

Explanation: 
There are three types of parameters that you can use in a .NET Framework and those are Input, Output, InputOutput .
Parameters are like variables that you can use to pass and return values between your application and a database. The types of parameters are defined by SqlDbTypeenumeration. It contains a list of the types available in SQL Server. These parameter values are pass to SQL statements and stored procedures. SQL Server uses the @ symbol as a prefix to denote parameters.
Parameters are Input parameters by default. You can change its direction by using ParameterDirection property.

Example:
SqlParameterparaObj = new SqlParameter();
paraObj.ParameterName = "@TotalCost";
paraObj.SqlDbType = SqlDbType.Money;

11)   How do you determine the actual SQL data type of a SqlParameter (the type expected by the SQL Server)?

a. It is the .NET Framework data type in your application that the parameter represents.
b. It is the type of column or data in SQL Server that the command expects.
c. It is the type of column in a DataTablethat it represents.
d. It is any type defined in the SqlDbDataTypeenumeration.
Answer  Explanation 
ANSWER: It is the type of column or data in SQL Server that the command expects.

Explanation: 
No explanation is available for this question!

12)   Which of the following is true?

a. DataTable object contain DataRow and DataColoumn objects
b. DataSet and DataTable can be binary serialized
c. DataSet and DataTable can be XML serialized
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
A DataTable is an in-memory representation of a single database table that contains DataRow and DataColoumn objects.
Serialization is the process of converting an object into a stream of bytes so you can store or transmit the object. Only those objects can be serialized those have SerializableAttribute.
There are two types of serialization binary and XML serialization.

13)   If you are using the DataSet and you have to display the data in sorted order what will you do?

a. Use Sort method of DataTable
b. Use Sort method of DataSet
c. Use DataViev object with each sort
d. Use datapaging and sort the data.
Answer  Explanation 
ANSWER: Use DataViev object with each sort

Explanation: 
DataView.Sortproperty allow you to sort data. Using a DataView, you can show the data in a table with different sort orders.

Example.
In this example our table name is StudentMaster.
public partial class Default5 : System.Web.UI.Page
{
SqlConnection con = new SqlConnection("provide connection string");
SqlDataAdapter da;
protected void Page_Load(object sender, EventArgs e)
{
string query = "select * from StudentMaster";
da = new SqlDataAdapter(query, con);
DataSet ds = new DataSet();
da.Fill(ds);
DataView dv = new DataView();
dv = ds.Tables[0].DefaultView;
dv.Sort = "studName";
DataTabledt = dv.Table; 
GridView1.DataSource = dt;
GridView1.DataBind();
}
}

14)   In which Event you can set the value of a Theme?

a. Page_Load
b. Page_Render
c. Page_PreRender
d. Page_PreInit
Answer  Explanation 
ANSWER: Page_PreInit

Explanation: 
To apply a theme programmatically, you can use to set the page’s Theme property in the Page_PreInitmethod. Page_PreInitis the proper method in which you can specify the theme.

15)   You need to initialize some variable only when the first user accesses the application. What should you do?

a. Add code to the Application_OnStart event handler in the Global.asax file.
b. Add code to the Application_BeginRequest event handler in the Global.asax
c. Add code to the Session_OnStart event handler in the Global.asax file 
d. None of the above
Answer  Explanation 
ANSWER: Add code to the Application_OnStart event handler in the Global.asax file.

Explanation: 
Application_Start event runs only ones when the application started. It is used to serve application - level and session - level events.

16)   Which of the following template supports by Repeater control?

a. <ItemTemplate>
b. <AlternatingItemTemplate>
c. <SeperatorTemplate>
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
Repeater is a web server control. It is used to create custom lists out of data that is available on the page. Repeater control supports different type of template because it has not any built in layout.

Following are the template that a repeater control supports.
•	ItemTemplate
•	AlternatingItemTemplate
•	SeparatorTemplate
•	HeaderTemplate and FooterTemplate

17)   Which of the following works on client side?

a. ViewState
b. HiddenField
c. ControlState
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
The following objects works on the client side in ASP.NET.

1.	view state. It works within the page only. You cannot use view state value in next page. 
2.	control state: You can persist information about a control that is not part of the view state. If view state is disabled for a control or the page, the control state will still work.
3.	hidden fields: It store data without displaying that control and data to the user’s browser. Hidden fields data is available within the page only (page - scoped data).
4.	Cookies: Cookies are small piece of information that server creates on the browser. Cookies store a value in the user’s browser that the browser sends with every page request to the web server.
5.	Query strings: In query strings values are stored at the end of the URL. These values are visible to the user through his or her browser’s address bar. Query strings are not secure. 

18)   Which of the following works on server side?

a. ViewState
b. HiddenField
c. Application and session
d. All of the above
Answer  Explanation 
ANSWER: Application and session

Explanation: 
Application and session objects works on the server side and more secure than client side objects.

• Application State:
This object stores the data that is accessible to all pages in a given Web application. 
• Session State:
Session object store user - specific data between individual requests. This object is same as application object but it stores the data about particular user.

19)   Application_Start event is available in which file?

a. Global.asax
b. Local.asax
c. Web.config
d. None of the above
Answer  Explanation 
ANSWER: Global.asax

Explanation: 
Application_Start event is available in Global.asax file. Application_Start event runs only ones when the application started. It is used to serve application-level and session-level events.
The following are some of the important events in the Global.asax file.
•	Application_Start
•	Session_Start
•	Application_BeginRequest
•	Application_EndRequest 
•	Application_Error
•	Session_End
•	Application_End

20)   You have to log the data into database if your session times out. Which event you will use?

a. Session_End
b. Application_End
c. Application_Start
d. Application_SessionTimeout
Answer  Explanation 
ANSWER: Session_End

Explanation: 
The Session_End Event is fired whenever a single user Session ends or times out. By using timeout property of session state you can control the session expire time. A session expires when the time specified by the Timeout property passes without a request came from the user.

21)   Which of the following is true when referencing master page from content page?

a. Content pages can reference private indexer in the master page.
b. Content pages can reference private Properties in the master page.
c. Contentpages can reference public Properties in the master page.
d. Content pages can reference private Methods in the master page.
Answer  Explanation 
ANSWER: Contentpages can reference public Properties in the master page.

Explanation: 
You can access the Properties and Controls of Master Pages from content pages. You can set value inside the master page and then make it available to content pages as a property of the master page.

22)   If you are using Webparts in your web page then which control is necessary? 

a. WebpartController
b. WebPartmanager
c. WebpartZone
d. None of the above
Answer  Explanation 
ANSWER: WebPartmanager

Explanation: 
WebPartmanager control is necessary for using webparts in ASP.NET. This control will manage different webpart in web page. When you run the application you will not see any WebPartmanager control because it is a non - visual control. It is most important control while using weparts. It provides the functionality for adding, deleting, and closing WebPart controls on a page.

23)   What component do you need to enable for a user to add new web parts?

a. WebpartZone
b. CatalogZone
c. WebPartManager
d. WebManager
Answer  Explanation 
ANSWER: CatalogZone

Explanation: 
CatalogZone control is required to add new web parts. This control is works like a container for other controls. CatalogPart control can be added on CatalogZone only.

24)   Which of the following are required to enable users to change the title of web part?

a. CatalogZone
b. TitleZone
c. EditorZone, AppearanceEditorPart
d. WebPart
Answer  Explanation 
ANSWER: EditorZone, AppearanceEditorPart

Explanation: 
EditorZone enables the user to edit appearance, layout, behavior, and other properties of the visible WebPart controls. So you can change the title of web part by using these controls.

25)   What is the file extension of web service in ASP.NET?

a. .ascx
b. .asmx
c. .aspx
d. .docx
Answer  Explanation 
ANSWER: .asmx

Explanation: 
.asmx is the file extension of web service in ASP.NET

26)   If you want to access a web service method, which attribute it must have?

a. [WebMethod]
b. [PageMetod]
c. [Web.Service]
d. [WebSupport]
Answer  Explanation 
ANSWER: [WebMethod]

Explanation: 
A web service is a web-based functionality that is used by other web application.
WebMethod attribute is used with methods within an XML Web service. This attribute makes the method callable from remote Web clients.

Example:
[WebMethod()] 

public int Add(int a, int b) 
{ 
return (a + b); 
} 

27)   Range Validator control in ASP.NET supports which type?

a. Integer
b. String
c. Currency
d. All of the above
Answer  Explanation 
ANSWER: All of the above

Explanation: 
The RangeValidator control checks whether a user's input data is between a specified upper and lower value. This controls supports the following type.
•	String 
•	Integer
•	Double
•	Date
•	Currency 

28)   If you are using user control in ASP.NET page which directory will be used?

a. Register
b. Assembly
c. Implements
d. Aspx
Answer  Explanation 
ANSWER: Register

Explanation: 
@register directive will be used, when you drag a user control onto your page. This directive registers your user control on the page so that the control can be accessed by the page. @Register directive informs the compiler that a user control added to the page. In ASP.NET the extension of user control is .ascx.

29)   A web application can contain _______ .

a. Only One Web.Config File
b. Only Two Web.Config File
c. more than one Web.config file
d. No file.
Answer  Explanation 
ANSWER: more than one Web.config file

Explanation: 
A web application can contain more than one Web.config file. When you create a web application, visual studio provide a default Web.config file in the root for you. For using more than one Web.config file, first you have to add a folder than you can add new Web.config file in this sub folder. There can be one web.config file in every sub folder of the application.

30)   What is the last event of web page life cycle?

a. Page_Load
b. Page_LoadComplete
c. Page_Finish
d. Page_Unload
Answer  Explanation 
ANSWER: Page_Unload

Explanation: 
When an ASP.NET page runs, the page goes through a series of events. These step by step events are called as page life cycle. The first event is Page_PreInit and last event is Page_Unload. 
The following are the list of page life cycle event.

•	PreInit
•	Init
•	InitComplete
•	PreLoad
•	Load
•	LoadComplete
•	PreRender
•	PreRenderComplete
•	SaveStateComplete
•	Render
•	Unload

31)   ByDefault ASP.Net SessionID is stored in _________.

a. Application
b. Session
c. Cookies
d. ViewState
Answer  Explanation 
ANSWER: Cookies




         */


    }
}

**C#.NET, ASP.NET, MVC, .NET Core**
1. What is the difference between .NET Framework and .NET Core?
.NET Framework is used to build Windows applications, while .NET Core is cross-platform and used to build
modern cloud-based applications.
2. Explain the lifecycle of an ASP.NET MVC request.
The lifecycle includes receiving the request, routing, creating a controller instance, invoking an action
method, and returning the response to the client.
3. What is Dependency Injection in .NET Core?
Dependency Injection (DI) is a design pattern that allows classes to declare their dependencies, which are
then provided by a service container.
4. What is LINQ and why is it useful?
LINQ (Language Integrated Query) is a set of methods that provide a query capability over collections,
reducing boilerplate code and increasing readability.
5. Explain Model Binding in ASP.NET MVC.
Model Binding in MVC automatically maps form fields from an HTTP request to corresponding model
properties.
6. What are Action Filters in ASP.NET MVC?
Action Filters allow code to run before or after an action method executes, commonly used for logging,
authentication, or handling exceptions.
7. Explain the Repository pattern and why it's used.
The Repository pattern provides an abstraction for data access, separating business logic from data access
logic.
8. How would you implement Dependency Injection in ASP.NET Core?
Register services in Startup.cs under the ConfigureServices method and inject them into the required
classes via constructor injection.
9. What are the main differences between synchronous and asynchronous programming in C#?
Synchronous code blocks the thread until the operation is complete, while asynchronous code allows other
operations to run while waiting for the task to complete.
10. How can you handle exceptions globally in ASP.NET Core?
Use middleware or custom exception filters to handle exceptions across the entire application.

**MS SQL**
12. What are the different types of joins in SQL?
Inner Join, Left Join, Right Join, Full Outer Join, and Cross Join.
13. Explain the difference between a clustered and non-clustered index.
A clustered index sorts the data rows in the table based on the key values, while a non-clustered index
creates a separate structure that references the table's data.
14. What is a stored procedure, and why would you use one?
A stored procedure is a precompiled collection of SQL statements that can be executed as a single unit,
improving performance and reusability.
15. How do you optimize a slow-running SQL query?
Use indexes, avoid SELECT *, ensure proper joins, and check query execution plans for inefficiencies.
16. What is a primary key and how does it differ from a unique key?
A primary key uniquely identifies each record in a table and cannot contain null values, while a unique key
also enforces uniqueness but can contain a single null value.
17. How would you implement database normalization?
Break tables into smaller, more manageable pieces, ensuring that each table contains only related data, to
reduce redundancy.
18. What is a trigger in SQL, and how does it work?
A trigger is a set of instructions that automatically executes in response to certain events on a table or view.
19. Explain the ACID properties in a database context.
ACID stands for Atomicity, Consistency, Isolation, and Durability, which are guarantees that database
transactions will be processed reliably.
20. What is a foreign key constraint in SQL?
A foreign key is a field in a table that uniquely identifies a row in another table, enforcing referential
integrity between the two tables.
21. What is the use of the ROW_NUMBER() function in SQL?
The ROW_NUMBER() function assigns a unique sequential number to rows within a result set, often used for
pagination.

**HTML, CSS, JavaScript, Bootstrap, jQuery**
22. What is the difference between block-level and inline-level elements in HTML?
Block-level elements take up the entire width of the container, while inline elements take only as much
width as necessary.
23. Explain CSS specificity and how it works.
CSS specificity determines which CSS rule will be applied by assigning weights to different types of selectors
(IDs, classes, elements).
24. What are media queries in CSS?
Media queries allow you to apply styles based on the device’s properties like width, height, orientation, etc.
25. What is jQuery, and why is it used?
jQuery is a lightweight JavaScript library that simplifies HTML DOM manipulation, event handling, and AJAX
interactions.
26. How can you use JavaScript to prevent the default action of an element?
You can use event.preventDefault() to stop the default action of an element.
27. What is Bootstrap and what are its key components?
Bootstrap is a front-end framework for responsive web design. Key components include the grid system,
forms, buttons, and navigation bars.
28. How do you perform AJAX requests using jQuery? $.ajax({ url: 'example.com', method: 'GET', success:
function(data) { console.log(data); } });
29. What is the box model in CSS?
The box model consists of content, padding, border, and margin, controlling the size and spacing of
elements.
30. How do you create a modal in Bootstrap? <button type="button" class="btn btn-primary" data-toggle="modal"
data-target="#myModal">Open Modal</button>
31. What is event delegation in JavaScript?
Event delegation allows you to attach a single event listener to a parent element that will handle events for
all of its child elements.

**Problem Solving and Analytical Skills**
32. Explain a time when you faced a complex problem and how you solved it.
Demonstrate a situation from a previous project where you used analytical skills to identify the root cause
and implement an effective solution.
33. How do you debug an issue in an application?
Use tools like logs, debuggers, and exception handling to identify the cause and fix it.
34. What approach do you take to database design?
Identify entities, relationships, and constraints, then normalize the data to reduce redundancy.
35. How do you handle performance issues in application development?
Use profiling tools to identify bottlenecks, optimize code, implement caching, and consider database
indexing.
36. Explain a situation where you had to optimize an existing solution.
Provide a real-world example where you improved the performance, scalability, or reliability of an
application.
37. What is the difference between var , let , and const in JavaScript?
var has function scope, while let and const have block scope. const is read-only and cannot be
reassigned.
38. How would you troubleshoot a cross-browser compatibility issue?
Use browser-specific developer tools, validate CSS/HTML, and test across multiple browsers using tools like
BrowserStack.
39. What is the purpose of design patterns in software development?
Design patterns provide reusable solutions to common problems, improving code maintainability and
flexibility.
40. Explain how you would optimize database queries for large datasets.
Index tables, use partitioning, optimize SQL queries, and avoid unnecessary joins or subqueries.
41. How do you manage security vulnerabilities in an application?
Implement input validation, use encryption for sensitive data, and follow secure coding practices.

**SSIS, Agile, Azure DevOps, Git**
42. What is SSIS and how is it used in ETL processes?
SSIS (SQL Server Integration Services) is used to extract, transform, and load data from multiple sources to
destinations.
43. How do you handle version control in Git?
Use branching, commits, merges, and pull requests to manage different versions of the code.
44. What are the key ceremonies in Agile methodology?
Sprint Planning, Daily Standups, Sprint Reviews, and Retrospectives are core ceremonies in Agile.
45. What is the purpose of Continuous Integration (CI) in Azure DevOps?
CI ensures that code changes are automatically tested and integrated, reducing integration issues.
46. What is the role of a Product Owner in Agile?
The Product Owner manages the product backlog and ensures the team delivers value according to
business priorities.
47. How do you create a pull request in Git? git checkout -b new-branch; git push origin new-branch; open a pull
request on GitHub.
48. How would you create a pipeline in Azure DevOps?
Use the Pipelines service in Azure DevOps, define build and release pipelines using YAML or the graphical
interface.
49. What is Continuous Delivery (CD) in DevOps?
CD automates the release process so that code changes are automatically deployed to production
environments.
50. What is the difference between Git and GitHub?
Git is a version control system, while GitHub is a cloud-based platform that hosts Git repositories.
51. What are the benefits of using Agile over traditional waterfall methods?
Agile allows for faster iterations, continuous feedback, and adaptability to changing requirements.

**Communication Skills**
52. How do you explain technical concepts to non-technical stakeholders?
Use simple language, avoid jargon, and focus on how the technical solution meets business needs.
53. How would you handle a situation where a client doesn't understand the requirements clearly?
Ask clarifying questions, restate their requirements in simple terms, and confirm their understanding before
proceeding.
54. Describe a situation where you had to collaborate with a difficult team member.
Discuss how you maintained professionalism, addressed the issue, and found common ground to work
together.
55. How do you handle feedback from clients?
Listen actively, acknowledge their concerns, and work towards implementing their feedback in a constructive
manner.
56. How do you keep stakeholders informed about project progress?
Use regular status updates, meetings, and reports to ensure transparency and manage expectations.

**Object-Oriented Programming (OOP) and 2/3-Tier Architecture**
57. What are the four pillars of OOP?
Encapsulation, Abstraction, Inheritance, and Polymorphism.
58. Explain the concept of Polymorphism with an example. public class Animal { public virtual void Speak() {
Console.WriteLine("Animal sound"); } } public class Dog : Animal { public override void Speak() {
Console.WriteLine("Bark"); } }
59. What is Encapsulation and why is it important?
Encapsulation hides the internal implementation of an object, exposing only what is necessary and
protecting the object’s integrity.
60. How does Inheritance work in C#?
Inheritance allows one class to inherit fields and methods from another class, enabling code reuse.
61. What is Abstraction in OOP?
Abstraction simplifies complex reality by modeling classes based on essential properties and behaviors,
hiding the complexity from the user.
62. What is the difference between an interface and an abstract class?
An interface only defines signatures of methods, while an abstract class can provide default behavior along
with method signatures.
63. How do you implement 2-tier and 3-tier architecture?
2-tier architecture has a client and a server, while 3-tier architecture divides the application into
Presentation, Business Logic, and Data Access layers.
64. What are design patterns? Name a few commonly used ones.
Design patterns are reusable solutions to common problems in software design. Common patterns include
Singleton, Factory, and Repository.
65. What is SOLID principle in OOP?
SOLID is an acronym for five design principles that help make software designs more understandable,
flexible, and maintainable.
66. How do you implement Dependency Injection in 3-tier architecture?
Use constructor injection to inject dependencies like repositories or services into the business logic and
presentation layers.

**Insurance Domain Knowledge**
67. What is underwriting in the Insurance domain?
Underwriting is the process by which an insurer evaluates the risk of insuring a client and decides the
premium to charge.
68. What are the main types of insurance policies?
Life insurance, health insurance, property insurance, and liability insurance are the main types.
69. What is a premium in insurance terms?
A premium is the amount of money that an individual or business must pay for an insurance policy.
70. Explain the concept of risk pooling in insurance.
Risk pooling involves spreading risks among a large group of policyholders, allowing the insurer to absorb
the cost of claims.
71. What is a claim in insurance?
A claim is a formal request made by the insured to the insurer for compensation of a covered loss or policy
event.
72. What is reinsurance and why is it important?
Reinsurance is insurance for insurance companies, allowing them to mitigate risk by passing on some of the
risk to other insurers.
73. What are the key components of an insurance policy?
The key components are the policyholder, the insurer, the premium, the coverage, and the term of the
policy.
74. What are deductibles in insurance?
A deductible is the amount the insured must pay out-of-pocket before the insurer pays for the remaining
covered loss.
75. How does the concept of moral hazard apply to insurance?
Moral hazard refers to the increased likelihood of risk-taking by the insured because they are protected by
the insurance policy.
76. What is an actuary and what role do they play in the insurance domain?
An actuary is a professional who uses mathematical models to assess and manage financial risks, particularly
in the context of insurance and pensions.

**Advanced Topics**
77. How do you manage state in an ASP.NET Core application?
Use session, cookies, or TempData to store state across multiple requests in an ASP.NET Core application.
78. What is middleware in ASP.NET Core?
Middleware is software that processes requests and responses in the HTTP pipeline.
79. Explain what a DbContext is in Entity Framework Core.
DbContext is the primary class for interacting with the database using Entity Framework Core, responsible
for querying and saving data.
80. How do you create an API in ASP.NET Core?
Use the Controller class, define routes using attributes, and return JSON or XML data in response to HTTP
requests.
81. What is AutoMapper and why would you use it in an ASP.NET Core application?
AutoMapper is a library that automatically maps objects of one type to another, simplifying object
transformation in the business layer.

**Code-based Questions**
82. How do you handle null values in LINQ? var result = myList?.Where(x => x != null);
83. Write a LINQ query to select all customers with orders over $100. var customers =
dbContext.Customers.Where(c => c.Orders.Any(o => o.Amount > 100));
84. How do you create a foreign key relationship in Entity Framework Core? modelBuilder.Entity<Order>
().HasOne(o => o.Customer).WithMany(c => c.Orders).HasForeignKey(o => o.CustomerId);
85. Write a C# program to find the sum of all even numbers in a list. var evenSum = numbers.Where(n => n % 2
== 0).Sum();
86. Write an asynchronous method to read from a file in C#. public async Task<string> ReadFileAsync(string path) {
using (var reader = new StreamReader(path)) { return await reader.ReadToEndAsync(); } }

**Miscellaneous**
87. What is version control, and why is it important in software development?
Version control is the practice of managing changes to source code over time, allowing teams to collaborate
and revert changes if necessary.
88. What is the difference between GET and POST in HTTP?
GET requests data from a server, while POST submits data to be processed to a server.
89. Explain the differences between IEnumerable and IQueryable .
IEnumerable is used for in-memory collection iteration, while IQueryable is used for querying databases
with deferred execution.
90. What is the purpose of caching in web applications?
Caching improves performance by storing frequently accessed data, reducing the load on the server.
91. Explain the difference between optimistic and pessimistic concurrency control in SQL.
Optimistic concurrency control assumes no conflict will occur, whereas pessimistic control locks records to
prevent conflicts.

**SSIS and Azure DevOps**
92. What is the purpose of control flow in SSIS?
Control flow defines the order in which tasks are executed in an SSIS package.
93. How do you deploy an SSIS package?
Use the SQL Server Data Tools (SSDT) to deploy SSIS packages to the Integration Services server or file
system.
94. What is the difference between Continuous Integration and Continuous Delivery?
Continuous Integration ensures that code changes are automatically tested and integrated, while
Continuous Delivery ensures that code can be deployed to production at any time.
95. Explain the concept of a “sprint” in Agile methodology.
A sprint is a time-boxed period, typically 2-4 weeks, during which the Agile team completes a set of tasks or
stories from the product backlog.
96. What are the benefits of using containers in application deployment?
Containers provide consistent environments across development, testing, and production, reducing
dependency conflicts.
Git and Agile
97. How do you resolve merge conflicts in Git? git merge feature-branch; git status; open the conflicted files, resolve
conflicts, then commit.
98. Explain the difference between a git fetch and git pull .
git fetch retrieves the latest changes from the remote without merging, while git pull fetches and
merges the changes.
99. What are user stories in Agile?
User stories are short descriptions of functionality from the perspective of the user, helping the team
understand and implement requirements.
100. How do you revert a commit in Git? git revert <commit-hash> undoes the changes of a specific commit by
creating a new commit with the inverse changes.
101. What is a burn-down chart in Agile? - A burn-down chart tracks the amount of work remaining in a sprint,
helping the team monitor progress.


-------------------------------------------------------------------------------------
DotNet vs DotNet Core
-------------------------------------------------------------------------------------
1. Introduction to .NET Framework
Basics of .NET Framework
Question: What is the .NET Framework, and why is it important?
Answer: The .NET Framework is a software development platform developed by Microsoft that provides
a controlled programming environment for building and running Windows applications. It includes a
large class library (FCL) and supports languages like C#, VB.NET, and F#. It is important because it
offers simplified development for desktop, web, and cloud applications with managed execution, memory
management, and security.

CLR (Common Language Runtime)
Question: What is the role of the Common Language Runtime (CLR) in .NET Framework?
Answer: The CLR is the execution engine of the .NET Framework, responsible for running applications
and providing services like memory management (garbage collection), security, exception handling, and
thread management.

Assemblies
Question: What are assemblies in .NET Framework?
Answer: Assemblies are the building blocks of .NET applications. They contain compiled code in the
form of IL (Intermediate Language), metadata, and resources like images. Assemblies are
either DLL (Dynamic Link Libraries) or EXE (Executable) files.

3. .NET Core Overview
Cross-Platform Capabilities
Question: What is .NET Core, and how is it different from the .NET Framework?
Answer: .NET Core is a cross-platform, open-source framework for building applications that run on
Windows, Linux, and macOS. It differs from the .NET Framework in that it is modular, lightweight, and
designed to support cloud-based, microservices, and containerized applications. .NET Core uses NuGet
packages for delivering libraries and tools, whereas the .NET Framework has a larger monolithic design.

Command-Line Interface (CLI)
Question: What is the .NET Core CLI, and how is it used?
Answer: The .NET Core CLI is a cross-platform command-line interface used to develop, build, run, and
publish .NET Core applications. It provides commands like dotnet new (to create projects), dotnet
build , dotnet run , and dotnet publish .

Modular Design
Question: How is the modular design of .NET Core different from .NET Framework?
Answer: .NET Core uses a modular approach where only the required NuGet packages are included in
the application, reducing the size of the application and its dependencies. The .NET Framework includes
a large, monolithic base class library, even if only part of it is used by the application.

5. .NET (formerly .NET Core)
Unified Platform
Question: What is the new .NET (formerly .NET Core), and what are its key features?
Answer: The new .NET (starting with .NET 5) is a unified platform that combines .NET Framework,
.NET Core, and Xamarin into a single product. It offers cross-platform capabilities, better performance,
and a smaller memory footprint. It is designed for all types of applications, including web, desktop,
mobile, and cloud-based applications.

.NET Standard
Question: What is .NET Standard, and why is it important?
Answer: .NET Standard is a formal specification of APIs that all .NET implementations must support. It
allows code sharing across different .NET platforms like .NET Core, .NET Framework, Xamarin, and
Unity, ensuring a consistent development experience across different environments.

7. Garbage Collection and Memory Management
Garbage Collection
Question: How does garbage collection work in the .NET Framework and .NET Core?
Answer: Garbage collection (GC) in .NET automatically manages memory by reclaiming objects that are
no longer referenced by the application. The .NET GC is non-deterministic, meaning it runs at
unspecified times, but it is optimized for performance. The GC operates in generations (Gen 0, Gen 1,
Gen 2) to manage short-lived and long-lived objects efficiently.

Finalization and IDisposable
Question: What is the difference between finalization and implementing IDisposable in .NET?
Answer: Finalization is used to release unmanaged resources when the object is garbage collected.
The IDisposable interface allows deterministic disposal of resources by calling Dispose() explicitly
or using the using statement. Finalization is slower because the garbage collector must run twice to
clean up the object, while Dispose() allows immediate resource cleanup.

9. Libraries and Frameworks in .NET
Base Class Library (BCL)
Question: What is the Base Class Library (BCL) in .NET?
Answer: The BCL is a subset of the .NET Framework Class Library (FCL) that provides fundamental
classes like collections, I/O, strings, and types. It serves as the foundation for all .NET applications by
offering essential functionality such as data types, file operations, and basic networking.

NuGet Packages
Question: What is NuGet, and how does it relate to .NET Core and .NET?
Answer: NuGet is a package manager for .NET that allows developers to share and consume reusable
components (packages). In .NET Core and .NET, libraries and dependencies are distributed as NuGet
packages, making applications modular and lightweight.

11. Cross-Platform Development with .NET Core
Cross-Platform Development
Question: How does .NET Core enable cross-platform development?
Answer: .NET Core allows developers to build and run applications on multiple operating systems like
Windows, Linux, and macOS. The cross-platform runtime and libraries in .NET Core ensure that the
same application code can be compiled and executed on different platforms without modification.

Docker and .NET Core
Question: How is Docker used with .NET Core applications?
Answer: Docker is used to containerize .NET Core applications, enabling them to run consistently across
different environments. A Dockerfile is used to create a container image for the application, and it can be
deployed on any system running Docker. The lightweight nature of .NET Core makes it ideal for
microservices and containerized deployments.

13. .NET Core and Web Development
ASP.NET Core
Question: What is ASP.NET Core, and how does it differ from ASP.NET in the .NET Framework?
Answer: ASP.NET Core is a lightweight, cross-platform framework for building modern web
applications, APIs, and microservices. Unlike ASP.NET in the .NET Framework, ASP.NET Core is
modular, allowing developers to use only the necessary components. It also offers improved performance,
better integration with modern cloud and container-based architectures, and simplified configuration.

Middleware in ASP.NET Core
Question: What is middleware in ASP.NET Core, and how does it function?
Answer: Middleware in ASP.NET Core is a pipeline of components that handle HTTP requests and
responses. Each middleware component can process requests, modify responses, or pass the request to the
next middleware in the pipeline. Common middleware includes authentication, logging, and error
handling.

15. Performance and Optimization
Performance Improvements in .NET Core and .NET
Question: What performance improvements does .NET Core offer over .NET Framework?
Answer: .NET Core offers significant performance improvements over the .NET Framework, including
better memory management, faster garbage collection, and optimizations for JIT (Just-In-Time)
compilation. It also introduces new features like span-based types ( Span<T> , Memory<T> ) for high
performance memory manipulation.

Kestrel Web Server
Question: What is the Kestrel web server in ASP.NET Core, and why is it important?
Answer: Kestrel is a cross-platform, high-performance web server used by ASP.NET Core applications.
It is designed to be lightweight and fast, suitable for running applications in production environments.
Kestrel can be used as a standalone web server or in conjunction with IIS or Nginx.

17. Dependency Injection (DI) in .NET Core
Built-in Dependency Injection
Question: How is dependency injection (DI) implemented in .NET Core?
Answer: .NET Core has built-in support for dependency injection (DI). Services are registered in
the Startup.ConfigureServices() method and injected into controllers, classes, or services through
constructor injection. Services can be registered with different lifetimes
( Transient , Scoped , Singleton ).

Service Lifetimes
Question: What are the different service lifetimes available in .NET Core DI?
Answer: The three service lifetimes in .NET Core are:
Transient: A new instance of the service is created every time it is requested.
Scoped: A new instance of the service is created for each request.
Singleton: A single instance of the service is created and shared across the application.

19. Asynchronous Programming
Async and Await in .NET
Question: How do async and await work in .NET and .NET Core?
Answer: async and await enable asynchronous programming in .NET by allowing methods to run
without blocking the calling thread. This is particularly useful for I/O-bound operations like reading files,
database access, or web service calls, improving application responsiveness and scalability.

Task-Based Asynchronous Pattern (TAP):
Question: What is the Task-Based Asynchronous Pattern (TAP) in .NET?
Answer: The Task-Based Asynchronous Pattern (TAP) is the preferred model for asynchronous
programming in .NET. It uses Task and Task<T> types to represent asynchronous operations.
TAP simplifies writing asynchronous code with async and await keywords, enabling better
exception handling and code readability. Tasks are executed asynchronously without blocking
the main thread.

21. Security in .NET and .NET Core
Authentication and Authorization
Question: How is authentication and authorization handled in ASP.NET Core?
Answer: ASP.NET Core uses middleware for authentication and authorization. Authentication
schemes like JWT Bearer tokens, cookies, and OAuth are handled via middleware components.
Authorization policies and roles are defined using the [Authorize] attribute or custom policies,
which control access to different parts of the application.

Data Protection APIs
Question: What is the Data Protection API in ASP.NET Core?
Answer: The Data Protection API in ASP.NET Core is used to securely store sensitive data, such
as authentication tokens, passwords, or personal information. It encrypts data and provides
built-in mechanisms to manage encryption keys and securely store them across different
environments.

23. Microservices and Cloud Development
Microservices Architecture with .NET Core
Question: How is .NET Core suited for microservices architecture?
Answer: .NET Core is ideal for microservices architecture due to its modularity, lightweight
footprint, cross-platform capabilities, and fast startup times. It supports containerization with
Docker and integrates well with cloud platforms like Azure, allowing services to be deployed and
scaled independently.

Azure Integration with .NET Core
Question: How is .NET Core integrated with Microsoft Azure for cloud development?
Answer: .NET Core has built-in integration with Microsoft Azure, supporting services like Azure
App Service, Azure Functions, Azure Storage, and Azure Cosmos DB. Applications built on .NET
Core can easily be deployed and managed in the Azure cloud environment, leveraging Azure’s
infrastructure for scalability, security, and monitoring.

25. Cross-Platform Tools and Development
Developing on Linux and macOS
Question: How do you develop .NET Core applications on Linux and macOS?
Answer: .NET Core is cross-platform, allowing development on Linux and macOS using IDEs like
Visual Studio Code, JetBrains Rider, or command-line tools like the .NET Core CLI ( dotnet ). The
same application code can be built and executed across different platforms without
modification.

Docker and Kubernetes with .NET Core
Question: How do Docker and Kubernetes work with .NET Core applications?
Answer: Docker allows .NET Core applications to be containerized and run consistently across
different environments. Kubernetes can be used to orchestrate and manage the deployment of
.NET Core applications in a microservices architecture, providing features like scaling, load
balancing, and automatic failover.

27. Versioning and Compatibility
.NET Versioning
Question: How does versioning work in .NET Core and .NET?
Answer: .NET Core and .NET follow a versioning system where new major versions (e.g., .NET 5,
.NET 6) introduce new features and capabilities while maintaining backward compatibility. Each
release includes improvements in performance, new APIs, and sometimes breaking changes that
require code adjustments.

Long-Term Support (LTS)
Question: What is the Long-Term Support (LTS) policy for .NET Core and .NET?
Answer: LTS versions of .NET Core and .NET are supported for at least three years, receiving
regular security updates and critical fixes. LTS versions are recommended for production
environments, while Current releases may receive feature updates but have a shorter support
lifecycle.

29. Frameworks and Libraries in .NET
.NET MAUI (Multi-platform App UI)
Question: What is .NET MAUI, and how is it used for cross-platform app development?
Answer: .NET MAUI (Multi-platform App UI) is the evolution of Xamarin.Forms, enabling
developers to build cross-platform applications that run on Windows, macOS, iOS, and Android
with a single codebase. It allows developers to share UI, business logic, and services across
platforms while maintaining platform-specific customizations.

Blazor
Question: What is Blazor in .NET, and how does it enable web development?
Answer: Blazor is a web framework in .NET that allows developers to build interactive web
applications using C# instead of JavaScript. It runs on both the client (Blazor WebAssembly) and
the server (Blazor Server). Blazor WebAssembly enables .NET code to run directly in the browser
using WebAssembly, while Blazor Server hosts the application logic on the server.

31. Deployment Strategies
Deployment with .NET Core
Question: What are the different deployment strategies for .NET Core applications?
Answer: .NET Core applications can be deployed using two primary strategies:

Framework-Dependent Deployment (FDD): The application is dependent on the presence
of .NET Core runtime on the host machine.

Self-Contained Deployment (SCD): The application includes the .NET Core runtime,
allowing it to run independently of the host environment. This is useful for scenarios where
the target system does not have .NET Core installed.

Running .NET Applications in Azure
Question: How do you deploy .NET applications to Azure?
Answer: .NET applications can be deployed to Azure using various methods, such as:
Azure App Service: A platform-as-a-service (PaaS) offering to host web applications.
Azure Kubernetes Service (AKS): For containerized .NET Core applications in Docker.
Azure Functions: For serverless functions written in .NET. Deployment tools like Azure
DevOps and GitHub Actions can automate the build and deployment process.

33. Migration from .NET Framework to .NET Core
Key Considerations for Migration
Question: What are the key considerations when migrating an application from .NET Framework
to .NET Core?
Answer: When migrating from .NET Framework to .NET Core, you need to consider:
Platform dependencies: Ensure any Windows-specific APIs are replaced with cross-platform
alternatives.
Third-party libraries: Ensure dependencies are compatible with .NET Core.
App architecture: Refactor the application to use .NET Core features such as Dependency
Injection and ASP.NET Core.
Testing and validation: Comprehensive testing to ensure feature parity and performance
improvements.

Migration Tools
Question: Are there tools available to assist with migrating from .NET Framework to .NET Core?
Answer: Yes, tools like the .NET Portability Analyzer and the .NET Upgrade Assistant can help
identify APIs that need to be updated and provide step-by-step guidance on migrating from
.NET Framework to .NET Core.

35. Best Practices for .NET Core Development
Code Optimization
Question: What are some best practices for optimizing .NET Core applications?
Answer: Best practices for optimizing .NET Core applications include:
Use AsNoTracking() for read-only queries to improve performance.
Avoid synchronous I/O in asynchronous code.
Use Span<T> and Memory<T> for high-performance memory access.
Leverage caching to reduce database calls.
Optimize middleware by placing lightweight middleware early in the pipeline.

Logging and Monitoring
Question: How is logging and monitoring handled in .NET Core applications?
Answer: Logging in .NET Core is built-in and can be configured using the ILogger interface.
You can log information to different providers such as the console, files, or external logging
platforms like Serilog, NLog, or Azure Application Insights. Monitoring can be integrated with
Azure Monitor for performance tracking and error reporting.

------------------------------------------------------------------
All Questions
------------------------------------------------------------------
1. C# Questions
   
1.1 Explain the use of ref and out keywords in C# method parameters. When should each be used?
Detailed Answer: The ref and out keywords in C# allow methods to modify parameters passed to them, with
each serving a different purpose.
ref : When a parameter is passed with the ref keyword, it allows both the caller and method to access and
modify an existing value. The parameter must be initialized before being passed to the method,
as ref signifies that the method might read and modify the existing value.
out : The out keyword allows a method to return multiple values through its parameters.
Unlike ref , out parameters don’t need to be initialized by the caller before passing to the method, but the
method must assign a value before it completes execution.
Use Cases: Use ref when a value needs to be updated and returned to the caller. Use out when returning
multiple values from a method is required.

1.2 How would you load data partially from a database to display on a screen in a C# application?
Detailed Answer: To load data partially (or implement pagination), use Skip and Take methods in LINQ to SQL
or Entity Framework queries. This approach allows for loading a manageable subset of data at a time, which is
especially helpful with large datasets.
Example: If displaying data page by page, use dbContext.Records.Skip(pageNumber *
pageSize).Take(pageSize) to fetch only the required page of data.
Considerations: Implementing efficient pagination is essential to reduce memory and CPU load, ensuring
faster response times and a better user experience.

1.3 A developer needs to implement only 9 out of 10 methods in an interface due to project needs. How can this be
resolved while adhering to SOLID principles?
Detailed Answer: This scenario points to the Interface Segregation Principle (ISP) of SOLID, which suggests that
interfaces should be small and specific to the client’s needs rather than large and general.
Solution: The developer can refactor the interface into smaller, more specific interfaces, each with only the
required methods. For example, instead of an IShape interface with all methods, smaller interfaces
like IDrawable and ITransformable can be created.
Alternate Solution: If the interface is from a third-party library and cannot be refactored, the developer may
implement the interface and provide minimal or placeholder implementations (e.g.,
throwing NotImplementedException ) for unnecessary methods, though this isn’t ideal.

1.4 The code throws an OutOfMemoryException when reading data from a database in batches into a .NET List. How
can this be resolved?
Detailed Answer: To avoid OutOfMemoryException , especially when working with large datasets, it’s best to use a
streaming or lazy-loading approach.
Streaming: Instead of loading all data into a list at once, process items as they are retrieved, such as by
using yield return or returning an IEnumerable collection.
Batch Processing: Process data in smaller batches that can be released from memory after processing,
avoiding the accumulation of data in memory. Additionally, if Entity Framework is used, consider disabling
tracking ( AsNoTracking ) to reduce memory usage.

1.5 How can you add a method to a sealed class from a third-party library to convert its data to a specific format?
Detailed Answer: Since sealed classes cannot be inherited, extension methods provide a practical way to add
functionality. Extension methods allow adding static methods to existing sealed classes without modifying the
source.
Implementation: Define an extension method in a static class that operates on the sealed class type. For
example, public static string ToFormattedString(this ThirdPartyClass obj) { /* conversion logic */
} .
Page - 1
Advantages: Extension methods are non-intrusive, enabling you to add functionality without access to the
original code.

2. .NET Core
2.1 What are the common approaches for implementing Web API versioning in .NET Core?
Detailed Answer: API versioning helps manage different versions of an API to avoid breaking changes for existing
clients.
Approaches:
Query String Versioning: Add version information as a query parameter, e.g., api/products?version=1 .
URL Path Versioning: Version is added in the URL path, e.g., api/v1/products .
Header Versioning: The client specifies the version in a custom header.
Media Type Versioning: Use Accept headers with custom media types to specify the version.
Tooling: The Microsoft.AspNetCore.Mvc.Versioning package simplifies versioning in .NET Core by allowing
easy configuration and management of versioned routes.

2.2 What steps should be taken to troubleshoot a 500 Internal Server Error in a .NET Core application?
Detailed Answer:
Enable Developer Exception Page: In development,
enable app.UseDeveloperExceptionPage() in Startup.cs to view detailed error messages.
Check Logs: Inspect logs in the configured logging provider (e.g., files, database) to locate detailed error
information.
Error Handling Middleware: Add global error-handling middleware to catch and log exceptions before they
return to the client.
Dependency and Configuration Check: Verify that all required services, configurations, and dependencies are
correctly set up.

2.3 How can you configure multiple logging sources (file, Splunk, database) in a .NET Core application?
Detailed Answer: .NET Core’s built-in logging framework supports multiple providers, which can be configured
in Startup.cs or appsettings.json .
Setup: In ConfigureServices , use AddLogging to add providers like AddFile , AddSplunk , and AddDatabase .
Each provider can be customized with its own configuration in appsettings.json .
Example: Add "Logging": { "LogLevel": { "Default": "Warning" }, "File": { ... }, "Splunk": { ... }
} to appsettings.json to configure different providers.

2.4 For a class with 100 methods used across multiple controller actions, what dependency injection lifetime scope
would you choose?
Detailed Answer: The choice depends on the intended usage and memory footprint of the class.
Scoped Lifetime: Creates a new instance per HTTP request, ensuring isolation across requests. Suitable if
data/state shouldn’t persist across requests.
Singleton Lifetime: Provides a single instance for the application’s lifecycle, useful if the state needs to be
shared across requests. However, avoid this for large objects with high memory usage.

2.5 How would you configure different data stores for different tenants in a .NET Core application?
Detailed Answer:
Tenant Identification: Identify the tenant based on criteria such as domain name, headers, or API tokens.
Page - 2
Custom Configuration Provider: Implement a custom configuration provider that loads connection strings
and settings for each tenant.
Multi-Tenancy Libraries: Some libraries, like Finbuckle.MultiTenant , provide pre-built solutions for
managing multi-tenant data stores.

3. Web API
3.1 What HTTP status code is appropriate for a long-running Web API call?
Detailed Answer: Use a 202 Accepted status code for long-running API calls to inform the client that the request
is being processed asynchronously. Follow up with status update endpoints to provide the client with progress or
completion updates.

3.2 How can you apply conditional validation in a Web API, where validation depends on another property’s value?
Detailed Answer:
Custom Validation Attribute: Write a custom validation attribute that checks the value of another property to
apply conditional logic.
Model-Level Validation: Implement IValidatableObject in the model and apply custom validation logic
based on property dependencies.
FluentValidation: Libraries like FluentValidation provide a powerful syntax for building conditional
validation rules.

3.3 Describe the scope and examples of unit tests and integration tests for a Web API that transfers funds between
accounts.
Detailed Answer:
Unit Tests: Test individual methods, such as TransferFunds , to verify fund transfer logic, input validation, and
boundary conditions.
Integration Tests: Validate that all components (API endpoints, services, database interactions) work together
correctly. Test scenarios like successful transfer, insufficient funds, and transaction rollbacks.

4. Event-Driven Development
4.1 For a notification system that sends notifications by email and SMS upon user registration, would you use a
queue or topic? Why?
Detailed Answer: Use a topic because it allows broadcasting a single message to multiple consumers (Email and
SMS services) simultaneously. Queues are more suitable for point-to-point messaging, where each message is
consumed by only one receiver.

4.2 Compare Kafka and RabbitMQ in terms of use cases and strengths.
Detailed Answer:
Kafka: Best for high-throughput, low-latency streaming, commonly used in data pipelines and real-time
analytics.
RabbitMQ: Focused on managing complex message routing, often used for event-driven microservices.

4.3 Describe the lifecycle management of messages in Kafka.
Detailed Answer: Kafka retains messages for a specified time or until a size limit is reached (retention policy). Log
compaction retains only the latest record for each key, managing storage efficiently.

5. Development Methodology
5.1 Do you approach your work with a design-first or code-first mindset? Which tools do you use for designing APIs
or components?
Detailed Answer:
Design-First Approach: Prioritize planning and designing APIs before implementation. Tools like Swagger or
OpenAPI are used to define and document APIs, ensuring clarity for stakeholders.
Code-First Approach: Use tools like Entity Framework Code-First for rapid prototyping, where code drives the
model definition.








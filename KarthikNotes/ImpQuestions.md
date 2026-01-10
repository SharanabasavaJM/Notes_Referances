1.	Handling Complex Batch Operations:
o	Question: "Describe your approach to managing a batch database update operation, particularly when dealing with high concurrency. How would you handle scenarios where data might be missing or improperly logged in a high-traffic environment?"
o	Notes: The client seemed focused on reliability and error handling, especially around parallel processing and retry mechanisms.

2.	API Design for Large Data Retrieval:
o	Question: "If you were tasked with creating an API endpoint to handle large data requests, what considerations would you make to ensure efficient data delivery and avoid straining network performance?"
o	Notes: Emphasis on data chunking, pagination, and response compression. Discussed options like asynchronous streaming and caching.

3.	Robust Error Handling in APIs:
o	Question: "How would you implement comprehensive error handling in API requests to ensure users receive clear, actionable feedback?"
o	Notes: The client asked about handling both client and server-side errors, possibly through standardized ProblemDetails responses and logging for detailed error tracking.

4.	Database Concurrency and Consistency:
o	Question: "When performing large concurrent database transactions, how do you ensure data consistency and handle potential race conditions?"
o	Notes: They were interested in techniques like row versioning, isolation levels, and the use of retry policies to manage concurrent writes without losing data integrity.

5.	Asynchronous Programming Best Practices:
o	Question: "What are your preferred best practices when implementing asynchronous code in .NET?"
o	Notes: The interviewer seemed focused on minimizing thread-blocking operations, proper task cancellation handling, and avoiding common pitfalls like Task.Result in asynchronous contexts.

6.	Error Handling in Multi-API Call Methods:
o	Question: "Imagine you have a method that calls multiple APIs. How would you ensure each API call is handled gracefully in case of failures, and that the method returns a reliable result?"
o	Notes: They mentioned resilience strategies, such as using try-catch blocks around each API call, retry policies, and logging errors for failed requests.

7.	Scalable System Design:
o	Question: "Describe your approach to designing a scalable and resilient system. What specific patterns and architectural principles would you apply?"
o	Notes: They wanted details on principles like microservices, load balancing, and the use of cloud-native features for horizontal scaling.

8.	Rate Limiting and Data Chunking:
o	Question: "How would you implement rate limiting and data chunking in an API intended for high-traffic use to prevent server overload?"
o	Notes: Discussion included token bucket algorithms for rate limiting and breaking down large responses into smaller data packets to enhance performance.

9.	Notification System with SOLID Principles:
o	Question: "How would you design a notification system (for Email, SMS, Push notifications) that adheres to SOLID principles?"
o	Notes: They wanted a clear separation of notification types and the application of dependency inversion to decouple the notification system from specific implementations.

10.	Filtering, Sorting, and Pagination in eCommerce API:
o	Question: "In an eCommerce application with a large product catalog, how would you manage dynamic filtering, sorting, and pagination?"
o	Notes: Focus on making the API flexible enough to support various filtering types (e.g., exact match, starts with), sorting criteria, and efficient pagination to handle large datasets.

11.	Retry Mechanism for Unreliable External Services:
o	Question: "If an external service is unreliable and prone to intermittent failures, how would you implement a retry mechanism that minimizes impact on the user experience?"
o	Notes: They highlighted interest in retry logic with exponential backoff, circuit breaker patterns, and configurable retry counts to maintain system resilience without overloading the external service.

-------------------------------------------------------------------------------------------------------------------------------------

1. Describe the architecture of your last project. What technologies and tools did you use?
Answer: My last project followed a layered architecture including Presentation Layer (Angular), Business Logic Layer (.NET Core Web API), and Data Access Layer (EF Core). We hosted services on Azure App Services, used Azure SQL Database, and integrated Azure Blob Storage for files. DevOps pipelines were implemented using Azure DevOps for CI/CD.

2. How do you configure a DbContext in EF Core?
Answer: We create a class inheriting from DbContext, define DbSet<TEntity> properties, and override OnModelCreating() for custom configurations. It is registered in Startup.cs using services.AddDbContext<>() method with connection string from appsettings.json.

3. What are the key advantages of .NET Core?
Answer:
•	Cross-platform support
•	Improved performance
•	Lightweight and modular
•	Built-in dependency injection
•	Side-by-side versioning

4. What is middleware in .NET Core?
Answer: Middleware is software assembled into an application pipeline to handle requests and responses. Examples include authentication, logging, CORS, and exception handling.

5. How do you create a custom middleware in ASP.NET Core?
Answer:
1.	Create a class with a constructor accepting RequestDelegate and an Invoke method.
2.	Write your logic in Invoke.
3.	Register the middleware in Startup.cs using app.UseMiddleware<>().

6. What is the purpose of MVC Filters?
Answer: Filters are used to run code before or after specific stages in the request processing pipeline. Examples include AuthorizationFilter, ActionFilter, ResultFilter, and ExceptionFilter.

7. Difference between Filters and Middleware?
Answer:
•	Middleware is global and runs for all requests; filters are scoped to controllers/actions.
•	Middleware has access to both request and response early; filters operate closer to MVC execution.

8. What are SOLID Principles?
Answer:
•	S: Single Responsibility Principle
•	O: Open/Closed Principle
•	L: Liskov Substitution Principle
•	I: Interface Segregation Principle
•	D: Dependency Inversion Principle

9. SQL: What are cursors?
Answer: Cursors allow row-by-row processing of query results. They are slower than set-based operations and are used in scenarios requiring iterative logic.

10. SQL: What are triggers?
Answer: Triggers are special stored procedures executed automatically in response to events like INSERT, UPDATE, or DELETE on a table.

11. SQL: How do you optimize stored procedures?
Answer:
•	Use proper indexes
•	Avoid SELECT *
•	Use EXISTS instead of IN
•	Avoid unnecessary cursors
•	Use SET NOCOUNT ON

12. SQL: Select returns too many rows, causing latency. How do you resolve?
Answer:
•	Apply proper filtering (WHERE clause)
•	Use pagination
•	Optimize indexes
•	Review execution plan for bottlenecks

13. What are Microservices? How are they different from Monolithic apps?
Answer: Microservices are independent services communicating over HTTP. Monolithic apps are single units. Microservices allow independent scaling, deployment, and fault isolation.

14. What triggers have you used in Azure Functions?
Answer:
•	HTTP Trigger
•	Timer Trigger
•	Queue Trigger
•	Blob Trigger
•	Service Bus Trigger

15. Advantages of Azure Functions over Web API?
Answer:
•	Serverless (no infrastructure management)
•	Pay-per-execution pricing
•	Built-in integration with Azure services
•	Auto-scaling

16. How do you check logs in Azure Portal?
Answer:
•	Application Insights
•	Azure Monitor
•	Log Analytics Query in Log Workspace

17. What authentication methods have you used?
Answer:
•	JWT (Bearer Token)
•	OAuth 2.0
•	Azure AD Authentication (MSAL)

18. Code Challenge: FizzBuzz
Answer:
for (int i = 1; i <= n; i++)
{
    if (i % 15 == 0) Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0) Console.WriteLine("Fizz");
    else if (i % 5 == 0) Console.WriteLine("Buzz");
    else Console.WriteLine(i);
}

-------------------------------------------------------------------------------------------------------------------------------------

1. How do you implement Dependency Injection in ASP.NET Core?
Answer: Dependency Injection (DI) is built into ASP.NET Core. We register services in Startup.cs using services.AddScoped(), AddTransient(), or AddSingleton(), and inject them through constructors into controllers or other classes.

2. Explain the Repository Pattern. How have you used it?
Answer: The Repository Pattern abstracts data access logic. It decouples the business logic from EF Core queries. I created interfaces like IUserRepository and implemented them using EF Core. This allowed easier unit testing and better separation of concerns.

3. How do you handle configuration settings in ASP.NET Core?
Answer: We use appsettings.json for configuration and bind values to POCO classes using IConfiguration. For secrets, User Secrets and Azure Key Vault can be used in production.

4. What is the difference between IHostedService and BackgroundService in .NET Core?
Answer:
•	IHostedService is an interface to run background tasks.
•	BackgroundService is an abstract class that implements IHostedService with a long-running ExecuteAsync() method. We use it for scheduled jobs or message queue listeners.

5. How do you secure sensitive API data in Web API?
Answer:
•	Use HTTPS (SSL)
•	Authenticate using OAuth2/JWT
•	Apply input validation and output encoding
•	Use DataProtection APIs for encryption
•	Avoid exposing internal structure via verbose errors

6. What are the different return types from a Web API Controller?
Answer:
•	IActionResult
•	ActionResult<T>
•	Specific types like Ok(), BadRequest(), NotFound(), etc.
•	Custom objects

7. What is a DTO and why do we use it?
Answer: A Data Transfer Object (DTO) is used to shape data sent across layers, especially from API to client. It avoids exposing domain models and can reduce over-fetching of data.

8. What is the difference between FirstOrDefault and SingleOrDefault in LINQ?
Answer:
•	FirstOrDefault: Returns the first matching record or null.
•	SingleOrDefault: Expects exactly one record. Throws exception if multiple records exist.

9. How do you implement pagination in Web API?
Answer: Use query parameters like pageNumber and pageSize. Use Skip((pageNumber - 1) * pageSize).Take(pageSize) in LINQ. Return metadata like total pages and current page.

10. What is Azure Key Vault and how have you used it?
Answer: Azure Key Vault stores secrets, keys, and certificates securely. We can access secrets using Managed Identity and configure apps to fetch values securely at runtime.

11. What is the difference between Azure App Service and Azure Function?
Answer:
•	App Service: For hosting web apps with full control
•	Azure Function: Event-driven, serverless compute; ideal for small units of logic

12. What is Entity Framework Core Migration?
Answer: Migrations allow EF Core to track schema changes. We use commands like Add-Migration, Update-Database to generate and apply SQL scripts that sync model and database.

13. How do you handle exception handling globally in ASP.NET Core?
Answer: Use UseExceptionHandler() middleware. Create a custom error-handling middleware or use filters like ExceptionFilterAttribute for MVC.

14. Explain the use of AutoMapper in your projects.
Answer: AutoMapper is used to map between DTOs and domain models. We define mapping profiles and inject IMapper to convert data automatically, reducing manual mapping code.

15. Code Challenge: Reverse a string in C#.
Answer:
public string ReverseString(string input)
{
    char[] chars = input.ToCharArray();
		Array.Reverse(chars);
		return new string(chars);
}

-------------------------------------------------------------------------------------------------------------------------------------

1. What is the difference between synchronous and asynchronous programming in .NET?
Answer: Synchronous code blocks execution until the task completes. Asynchronous code uses async and await keywords, allowing non-blocking operations which improve scalability, especially for I/O-bound tasks.

2. How do you implement logging in ASP.NET Core?
Answer: ASP.NET Core uses built-in ILogger<T> interface. We configure providers like Console, Debug, Application Insights, or Serilog in Program.cs or appsettings.json.

3. What is Kestrel in ASP.NET Core?
Answer: Kestrel is a cross-platform web server built into ASP.NET Core. It is lightweight and high-performance, used as the default web server in ASP.NET Core applications.

4. What is the purpose of app.UseRouting() and app.UseEndpoints()?
Answer:
•	UseRouting() enables route matching.
•	UseEndpoints() executes the matched endpoint. They must be used in the correct order in the middleware pipeline to route requests properly.

5. What are Value Types and Reference Types in C#?
Answer:
•	Value Types store data directly (e.g., int, bool, structs)
•	Reference Types store a reference to the data's memory location (e.g., class, string, array)

6. How does IQueryable differ from IEnumerable?
Answer:
•	IEnumerable executes queries immediately and processes data in memory.
•	IQueryable builds expression trees and executes queries on the data source, supporting deferred execution and server-side filtering.

7. What is Model Binding in ASP.NET Core?
Answer: Model binding maps data from HTTP requests (form, query string, route) to action method parameters or model properties. It simplifies reading request data in controllers.

8. What are some common HTTP status codes you use in Web APIs?
Answer:
•	200 OK – Request successful
•	201 Created – Resource created
•	400 Bad Request – Validation errors
•	401 Unauthorized – Authentication failed
•	404 Not Found – Resource not found
•	500 Internal Server Error – Unexpected error

9. How do you validate a model in ASP.NET Core?
Answer: Use Data Annotations (e.g., [Required], [StringLength]) and call ModelState.IsValid in controllers. Custom validators can be created by implementing IValidatableObject or using FluentValidation.

10. What is the difference between Put and Patch HTTP methods?
Answer:
•	PUT replaces the entire resource.
•	PATCH updates partial resource data. Useful for performance when only some fields need updating.

11. How do you manage secrets and sensitive settings in development and production?
Answer:
•	Local Dev: Use User Secrets
•	Production: Store in Azure Key Vault and access via Managed Identity
•	Never hardcode sensitive data in source code

12. How do you scale an application in Azure App Service?
Answer:
•	Vertically: Change service plan to a higher tier
•	Horizontally: Enable autoscaling based on CPU, memory, or queue length
•	Use deployment slots for zero-downtime deployments

13. What is the role of Startup.cs in ASP.NET Core?
Answer: It configures services (ConfigureServices) and the middleware pipeline (Configure). It plays a critical role in defining the application behavior and dependency injection setup.

14. How do you test Web APIs?
Answer:
•	Unit Test: Use xUnit/NUnit and Moq
•	Integration Test: Use TestServer and HttpClient
•	Postman or Swagger UI for manual testing

15. Code Challenge: Check if a number is a palindrome
Answer:
public bool IsPalindrome(int number)
{
    int original = number, reversed = 0;
    while (number > 0)
    {
        int digit = number % 10;
        reversed = reversed * 10 + digit;
        number /= 10;
    }
    return original == reversed;
}

-------------------------------------------------------------------------------------------------------------------------------------

1. What is a Memory Leak in .NET and how can you detect it?
Answer: A memory leak occurs when objects are not properly disposed or dereferenced, preventing the garbage collector from reclaiming memory. Tools like Visual Studio Diagnostic Tools or dotMemory help detect such leaks.

2. What is the difference between Task.Run and async/await?
Answer: Task.Run is used to offload CPU-bound work to a separate thread, while async/await is ideal for non-blocking I/O operations. Overusing Task.Run can result in unnecessary thread creation.

3. How do you implement Role-based Authorization in ASP.NET Core?
Answer: Use the [Authorize(Roles = "Admin")] attribute or configure policies in Startup.cs with AddAuthorization. Assign roles via claims or Identity framework.

4. What are the key differences between .NET Core and .NET Framework?
Answer:
•	.NET Core is cross-platform, modular, and open-source
•	.NET Framework is Windows-only and monolithic
•	.NET Core supports CLI tools and is more performance-oriented

5. What is the difference between transient, scoped, and singleton lifetimes?
Answer:
•	Transient: A new instance every time it's requested
•	Scoped: One instance per request scope
•	Singleton: A single instance throughout the application lifetime

6. How do you implement Soft Delete in EF Core?
Answer: Add a boolean IsDeleted field in the model. Override SaveChanges() or use global query filters to exclude soft-deleted records in queries.

7. What are the benefits of using Swagger in Web API?
Answer:
•	Auto-generates API documentation
•	Provides test UI for endpoints
•	Helps consumers understand request/response schema
•	Useful for client code generation

8. What is CORS and how do you enable it in ASP.NET Core?
Answer: CORS (Cross-Origin Resource Sharing) allows a web app from one domain to access resources from another. It is configured using services.AddCors() and app.UseCors() in Startup.cs.

9. What are Action Results in ASP.NET Core MVC?
Answer: Action results are return types from controller actions that represent HTTP responses, e.g., Ok(), BadRequest(), Content(), Json(), File().

10. How do you implement Rate Limiting in a Web API?
Answer: Use middleware or tools like AspNetCoreRateLimit NuGet package. Configure rate limit policies based on IP, endpoint, or user identity.

11. How do you perform unit testing with EF Core?
Answer: Use InMemoryDatabase provider for EF Core, mock DbContext or use repository abstraction, and test against expected state or behavior.

12. Explain Managed Identity in Azure.
Answer: Managed Identity allows Azure resources to authenticate to services (like Key Vault, Storage) without managing credentials. Enabled through Azure Portal or ARM templates.

13. What are Durable Functions in Azure?
Answer: Durable Functions are stateful workflows built on Azure Functions using Orchestrator, Activity, and Client functions. Ideal for long-running operations and chaining.

14. How do you optimize LINQ queries for performance?
Answer:
•	Filter early using Where
•	Use projection (Select) to reduce data transfer
•	Avoid in-memory operations by using IQueryable
•	Use indexes in DB and avoid ToList() until necessary

15. Code Challenge: Remove duplicates from a list of integers
Answer:
public List<int> RemoveDuplicates(List<int> numbers)
{
    return numbers.Distinct().ToList();
}

-------------------------------------------------------------------------------------------------------------------------------------

1. What is the difference between ViewData, ViewBag, and TempData in ASP.NET Core MVC?
Answer:
•	ViewData: Dictionary for passing data from controller to view; works during a single request.
•	ViewBag: Dynamic wrapper over ViewData.
•	TempData: Stores data between requests using session; used for redirection scenarios.

2. What is the purpose of the ConfigureServices method in ASP.NET Core?
Answer: It is used to register application services and configure DI container. Services like EF Core, Identity, CORS, and custom services are added here.

3. Explain the concept of Middleware Ordering.
Answer: Middleware is executed in the order registered in the pipeline. Incorrect ordering can break request processing. E.g., UseRouting() must come before UseEndpoints().

4. What is the difference between Abstract Class and Interface in C#?
Answer:
•	Abstract Class: Can have implementations and fields; supports constructors.
•	Interface: Only method/property signatures; no implementation (prior to C# 8).

5. How do you apply caching in ASP.NET Core?
Answer:
•	In-Memory Caching using IMemoryCache
•	Distributed Caching (e.g., Redis)
•	Response Caching using middleware and [ResponseCache] attribute

6. What is SignalR and where would you use it?
Answer: SignalR is a library for real-time web functionality (e.g., chat, notifications). It abstracts WebSockets, SSE, and Long Polling behind a single API.

7. How do you handle concurrency in EF Core?
Answer:
•	Use RowVersion column and [Timestamp] attribute
•	Handle DbUpdateConcurrencyException to retry or alert users

8. What are Global Query Filters in EF Core?
Answer: They allow automatic application of filters (like IsDeleted) to all queries involving an entity. Configured in OnModelCreating().

9. Explain CQRS and where would you apply it.
Answer: Command Query Responsibility Segregation separates read and write operations. Used in systems with high read/write complexity or requiring separate scalability paths.

10. What is the difference between Configuration and Options pattern in ASP.NET Core?
Answer:
•	Configuration: Access values directly via IConfiguration
•	Options Pattern: Bind sections to strongly typed classes using IOptions<T>; encourages better structure and testability

11. How do you consume a REST API in C#?
Answer: Use HttpClient with GetAsync, PostAsync, or SendAsync. Use HttpRequestMessage for advanced scenarios. Always wrap in using block or inject via DI to avoid socket exhaustion.

12. What is Azure Application Insights?
Answer: It is a monitoring and telemetry service. It tracks exceptions, requests, dependencies, and performance counters to diagnose issues in live environments.

13. What are ARM Templates in Azure?
Answer: Azure Resource Manager (ARM) templates define infrastructure as code using JSON. They are used for automated, repeatable deployments of Azure resources.

14. How would you troubleshoot a high CPU usage in Azure App Service?
Answer:
•	Analyze Application Insights telemetry
•	Review logs and memory dump using Kudu console
•	Use Profiler or Diagnose & Solve Problems blade in Azure Portal
•	Optimize application code and DB queries

15. Code Challenge: Count the frequency of each character in a string
Answer:
public Dictionary<char, int> GetCharacterFrequency(string input)
{
    return input.GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());
}

-----------------------------------------------------------------------------------------------------------------------------------

Day 01 Meeting notes:
•	Introduction to Ignite Hour Session: Karthik introduced the Ignite Hour session, explaining that it is a daily technical preparation session aimed at making participants ready for client interviews. He emphasized the importance of being prepared for client interviews and mentioned that the session would follow a task-based approach.
o	Session Purpose: Karthik explained that the Ignite Hour session is designed to prepare participants for client interviews by discussing important technical topics and providing tasks and assessments to ensure readiness.
o	Session Frequency: The session will be held daily, five days a week, for one hour each day, specifically targeting bench associates to help them get deployed into projects.
o	Support and Participation: Karthik requested participants to stay on mute during the session as it is being recorded for future reference. He also encouraged active participation by answering questions to maintain the flow of the session.

•	Focus on .NET Framework: Karthik announced that the session would focus on the .NET framework, starting with C# and covering important technical concepts quickly. He mentioned that the session is primarily for bench associates and those not allocated to a project.
o	Primary Audience: The session is intended for bench associates and those not currently allocated to a project, specifically targeting .NET developers.
o	Initial Focus: The session will begin with C#, covering essential concepts of the .NET framework to ensure participants have a strong foundational understanding.
o	Exclusions: Participants from the Power Platform or those already allocated to projects are not required to attend these sessions.

•	Explanation of .NET Framework: Karthik provided an overview of the .NET framework, explaining its components such as CLR (Common Language Runtime), FCL (Framework Class Library), and the different types of applications that can be built using the .NET framework.
o	Overview: Karthik described the .NET framework as a software development platform developed by Microsoft to build and run various types of applications, including Windows, web, and mobile applications.
o	Key Components: The .NET framework includes the CLR, which handles memory management, security, and exception handling, and the FCL, which provides reusable libraries and supports multiple programming languages like C#, VB.NET, and F#.
o	Application Types: The framework supports the development of different types of applications, such as Windows applications, web applications, mobile applications, and services.

•	Key Components of .NET Framework: Karthik discussed the key components of the .NET framework, including CLR, FCL, ASP.NET, ADO.NET, Windows Forms, WPF, and WCF. He explained the purpose of each component and their importance in the framework.
o	CLR: The Common Language Runtime (CLR) is responsible for executing applications and providing services like memory management, type safety, security enforcement, and exception handling.
o	FCL: The Framework Class Library (FCL) includes a collection of reusable classes, interfaces, and value types that expedite the development process by providing pre-built functionalities.
o	ASP.NET: ASP.NET is used for building web applications and services, providing a robust framework for developing dynamic web pages and web services.
o	ADO.NET: ADO.NET is used for database access and manipulation, allowing developers to interact with databases and perform CRUD operations efficiently.
o	Windows Forms, WPF, WCF: Windows Forms is used for creating desktop applications, WPF (Windows Presentation Foundation) for modern desktop UI development, and WCF (Windows Communication Foundation) for building service-oriented applications.

•	Common Language Runtime (CLR): Karthik explained the role of CLR in the .NET framework, highlighting its responsibilities such as memory management, type safety, security enforcement, and exception handling. He emphasized the importance of understanding these concepts for interviews.
o	Memory Management: CLR handles memory management through automatic garbage collection, ensuring efficient memory allocation and deallocation.
o	Type Safety: CLR enforces type safety, ensuring that code adheres to type rules and preventing type errors during execution.
o	Security: CLR provides security enforcement by managing code access security and ensuring that code runs within the defined security boundaries.
o	Exception Handling: CLR manages exception handling, providing a structured way to handle runtime errors and maintain application stability.

•	Garbage Collection: Karthik discussed the concept of garbage collection in the .NET framework, explaining its role in freeing unused memory automatically. He mentioned the importance of understanding garbage collection for interviews and provided examples of its key concepts.
o	Automatic Memory Management: Garbage collection automatically reclaims memory occupied by objects that are no longer in use, ensuring efficient memory utilization.
o	Generations: Garbage collection operates in generations (Gen 0, Gen 1, Gen 2), with short-lived objects in Gen 0, survivors in Gen 1, and long-lived objects in Gen 2.
o	Phases: The garbage collection process includes marking live objects, sweeping dead objects, and compacting memory to optimize space utilization.
o	Manual Collection: While manual garbage collection can be triggered using GC.Collect(), it is generally discouraged as the CLR handles it more efficiently.

•	JIT Compiler: Karthik explained the role of the JIT (Just-In-Time) compiler in the .NET framework, describing how it translates intermediate language to native machine code at runtime. He also mentioned the different types of JIT compilers and their purposes.
o	JIT Compilation: The JIT compiler translates intermediate language (IL) to native machine code at runtime, optimizing execution based on the current environment.
o	Types of JIT: There are three types of JIT compilers: Normal JIT, which compiles methods as they are called; EconoJIT, used for low-memory devices; and PreJIT, which precompiles the entire application at installation.
o	Intermediate Language: Code written in C# is compiled into intermediate language (IL), which is then stored in assemblies (.dll or .exe) and converted to machine code by the JIT compiler at runtime.

•	Object-Oriented Programming Principles: Karthik introduced the object-oriented programming principles, including inheritance, polymorphism, encapsulation, and abstraction. He provided examples and explained the importance of understanding these concepts for interviews.
o	OOP Principles: Karthik covered the four main OOP principles: inheritance, polymorphism, encapsulation, and abstraction, emphasizing their importance in software development and interviews.
o	Inheritance: Inheritance allows a class to reuse fields, properties, and methods of another class, promoting code reusability and establishing an "is a" relationship.
o	Polymorphism: Polymorphism enables methods to behave differently based on the object type, with compile-time polymorphism achieved through method overloading and runtime polymorphism through method overriding.
o	Encapsulation: Encapsulation involves hiding internal data and providing controlled access through public methods, enhancing data protection and reducing complexity.
o	Abstraction: Abstraction hides internal complexity and exposes only the necessary parts, simplifying system interaction and focusing on essential details.

•	Inheritance and Access Specifiers: Karthik discussed inheritance and access specifiers in C#, explaining their importance in code reusability and the "is a" relationship. He provided examples and highlighted common interview questions related to these topics.

•	Polymorphism: Karthik explained the concept of polymorphism, including compile-time polymorphism (method overloading) and runtime polymorphism (method overriding). He discussed the use of virtual and override keywords and provided examples.

•	Encapsulation: Karthik discussed encapsulation, explaining its role in hiding internal data and providing controlled access. He provided examples and emphasized the importance of understanding encapsulation for interviews.

•	Abstraction: Karthik explained the concept of abstraction, highlighting its role in hiding internal complexity and exposing only necessary parts. He discussed the difference between encapsulation and abstraction and provided examples.

•	Conclusion and Next Steps: Karthik concluded the session by summarizing the key topics covered and announcing the next topics to be discussed in future sessions. He encouraged participants to actively engage in the sessions and prepare for interviews.

**Day 02 Meeting notes:**
•	Introduction to Ignite Hour Session: Karthik welcomed everyone to the second day of the Ignite Hour session, emphasizing that the session is designed to prepare participants for interviews. He mentioned that the session would cover fundamentals, interview questions, assessments, and hands-on training.
o	Session Purpose: Karthik reiterated that the Ignite Hour session is designed to prepare participants for interviews, focusing on fundamentals, interview questions, assessments, and hands-on training.
o	Training Approach: Karthik explained that the session would not be a typical classroom or online training but would involve quick discussions on fundamentals, interview questions, and hands-on activities.
o	Hands-on Training: Karthik mentioned that participants would be given half-completed code to finish, particularly after completing the basics, to provide practical experience.

•	Overview of SOLID Principles: Karthik introduced the SOLID principles, explaining that they are object-oriented design principles. He listed the principles: Single Responsibility Principle (SRP), Open/Closed Principle (OCP), Liskov Substitution Principle (LSP), Interface Segregation Principle (ISP), and Dependency Inversion Principle (DIP).
o	Introduction to SOLID: Karthik introduced the SOLID principles as fundamental object-oriented design principles essential for writing maintainable and scalable code.
o	Principles Listed: Karthik listed the five SOLID principles: Single Responsibility Principle (SRP), Open/Closed Principle (OCP), Liskov Substitution Principle (LSP), Interface Segregation Principle (ISP), and Dependency Inversion Principle (DIP).

•	Single Responsibility Principle (SRP): Karthik explained the Single Responsibility Principle, stating that a class should have only one responsibility and one reason to change. He provided an example of a restaurant where the chef cooks the food and the waiter serves it, emphasizing that each role has a specific responsibility.
o	SRP Definition: Karthik defined the Single Responsibility Principle (SRP) as the principle that a class should have only one responsibility and one reason to change.
o	Restaurant Example: Karthik used the example of a restaurant where the chef cooks the food and the waiter serves it to illustrate that each role should have a specific responsibility.
o	Class Responsibility: Karthik emphasized that a class should have only one responsibility to avoid SRP violations, ensuring that it has only one reason to change.

•	Applying SRP in Code: Karthik demonstrated how to apply SRP in code by creating separate classes for generating reports, saving to the database, and sending emails. He explained that each class should have a single responsibility to avoid SRP violations.
o	Code Example: Karthik provided a code example where a report class initially had multiple responsibilities: generating reports, saving to the database, and sending emails.
o	SRP Violation: Karthik explained that the initial report class violated SRP because it had multiple responsibilities, making it prone to changes for different reasons.
o	Refactoring: Karthik demonstrated refactoring the code by creating separate classes: ReportGenerator, ReportSaver, and ReportEmailSender, each with a single responsibility.
o	Implementation: Karthik showed how to implement the refactored classes, ensuring that each class had only one responsibility, thus adhering to SRP.

•	Open/Closed Principle (OCP): Karthik discussed the Open/Closed Principle, explaining that software entities should be open for extension but closed for modification. He provided an example of a restaurant menu that can be extended with new dishes without redesigning the entire restaurant.
o	OCP Definition: Karthik defined the Open/Closed Principle (OCP) as the principle that software entities should be open for extension but closed for modification.
o	Restaurant Example: Karthik used the example of a restaurant menu that can be extended with new dishes without redesigning the entire restaurant to illustrate OCP.
o	Extension without Modification: Karthik emphasized that new behaviors should be added without changing existing code, ensuring that the software remains stable and maintainable.

•	Applying OCP in Code: Karthik demonstrated how to apply OCP in code by using polymorphism and interfaces. He created an interface for discounts and implemented it in different customer classes, allowing new customer types to be added without modifying existing code.
o	Code Example: Karthik provided a code example where a discount calculator initially had hardcoded conditions for different customer types, violating OCP.
o	OCP Violation: Karthik explained that the initial discount calculator violated OCP because adding new customer types required modifying the existing code.
o	Refactoring: Karthik demonstrated refactoring the code by creating an IDiscount interface and implementing it in different customer classes, allowing new customer types to be added without modifying existing code.
o	Implementation: Karthik showed how to implement the refactored classes, ensuring that the discount calculator adhered to OCP by being open for extension but closed for modification.

•	Liskov Substitution Principle (LSP): Karthik explained the Liskov Substitution Principle, stating that objects of a superclass should be replaceable with objects of its subclasses without breaking the application. He provided an example of a driver's license that allows driving different types of cars without needing new rules.
o	LSP Definition: Karthik defined the Liskov Substitution Principle (LSP) as the principle that objects of a superclass should be replaceable with objects of its subclasses without breaking the application.
o	Driver's License Example: Karthik used the example of a driver's license that allows driving different types of cars without needing new rules to illustrate LSP.
o	Superclass Replacement: Karthik emphasized that a superclass should be replaceable with its subclasses without causing runtime errors or unexpected behavior.

•	Applying LSP in Code: Karthik demonstrated how to apply LSP in code by creating an abstract class for flying birds and implementing it in specific bird classes. He explained that subclasses should be able to replace the superclass without causing runtime errors.
o	Code Example: Karthik provided a code example where a Bird class had a fly method, and subclasses like Sparrow and Ostrich inherited from it.
o	LSP Violation: Karthik explained that the initial implementation violated LSP because Ostrich, which cannot fly, was forced to implement the fly method, causing runtime errors.
o	Refactoring: Karthik demonstrated refactoring the code by creating an abstract class FlyingBird and implementing it in specific bird classes like Sparrow, ensuring that only birds that can fly inherit from it.
o	Implementation: Karthik showed how to implement the refactored classes, ensuring that subclasses could replace the superclass without causing runtime errors, thus adhering to LSP.

•	Interface Segregation Principle (ISP): Karthik discussed the Interface Segregation Principle, explaining that clients should not be forced to depend on interfaces they do not use. He provided an example of a coffee machine that should not grind beans when only hot water is needed.
o	ISP Definition: Karthik defined the Interface Segregation Principle (ISP) as the principle that clients should not be forced to depend on interfaces they do not use.
o	Coffee Machine Example: Karthik used the example of a coffee machine that should not grind beans when only hot water is needed to illustrate ISP.
o	Interface Focus: Karthik emphasized that interfaces should be small and focused, ensuring that clients only depend on the methods they actually use.

•	Applying ISP in Code: Karthik demonstrated how to apply ISP in code by splitting a large interface into smaller, more focused interfaces. He explained that this approach prevents clients from being forced to implement unnecessary methods.

•	Dependency Inversion Principle (DIP): Karthik explained the Dependency Inversion Principle, stating that high-level modules should not depend on low-level modules. Both should depend on abstractions. He provided an example of a generic wall socket that works with various devices.

•	Applying DIP in Code: Karthik demonstrated how to apply DIP in code by using dependency injection and interfaces. He created an interface for logging and implemented it in different logger classes, allowing the File Manager class to depend on the abstraction rather than a specific logger class.

•	Encouragement for Collaborative Learning: Karthik encouraged participants to collaborate and share their knowledge with each other. He suggested that they conduct their own sessions and discussions to enhance their learning and prepare for interviews.
Follow-up tasks:

•	OCP Code Implementation: Complete the discount calculator code implementation to ensure it works with any IDiscount without changing the existing code. (the team)

•	OCP Example Submission: Submit examples of real-world analogies for the Open-Closed Principle in the text chat after the session. (the team)

•	LSP Code Implementation: Provide a solution for the discount calculator code to ensure it adheres to the Open-Closed Principle. (the team)

•	Collaborative Learning Session: Organize and conduct collaborative learning sessions on important interview topics such as design patterns and repository patterns. (the team)


**Day 03 Meeting notes:**
•	Delegate Basics: Karthik explained the basics of delegates, including their syntax and usage. They discussed how delegates are type-safe pointers to methods and can reference any method matching the signature. Karthik provided examples of creating and using delegates in C#.
o	Delegate Syntax: Karthik explained that delegates are type-safe pointers to methods and can reference any method matching the signature. He demonstrated the basic syntax of creating a delegate by first writing the method signature and then adding the delegate keyword in front of it. For example, to create a delegate called MapDelegate that takes two integer arguments and returns an integer, you would write: `public delegate int MapDelegate(int a, int b);`.
o	Delegate Usage: Karthik provided an example of using delegates in a class called Calculator, which has methods for addition and multiplication. He showed how to create a delegate variable, reference the methods, and invoke them. For instance, `MapDelegate op = new MapDelegate(cal.Add);` and then invoking it with `op.Invoke(2, 3);`.
o	Instance and Static Methods: Karthik clarified that delegates can point to both instance and static methods. He emphasized that delegates are not limited to instance methods and can be used to reference static methods as well.

•	Multicast Delegates: Karthik demonstrated how to create and use multicast delegates, which can point to multiple methods. They explained that the return value of the last method in a multicast delegate is always returned.
o	Creating Multicast Delegates: Karthik explained how to create multicast delegates by adding multiple methods to a delegate instance using the `+=` operator. For example, `op += cal.Multiply;` adds the Multiply method to the delegate instance.
o	Invoking Multicast Delegates: Karthik demonstrated that when a multicast delegate is invoked, all the methods it references are called in the order they were added. The return value of the last method in the invocation list is returned. For example, if both Add and Multiply methods are added to the delegate, invoking it will call both methods, and the result of the Multiply method will be returned.

•	Benefits of Delegates: Karthik highlighted the benefits of using delegates, such as decoupling the method caller from the method implementation and their usefulness in callbacks and event handling.
o	Decoupling Method Caller: Karthik explained that delegates help decouple the method caller from the method implementation. This means that the method implementation can be done separately, and the caller can invoke the method without knowing its details. This is particularly useful in scenarios where the method implementation might change, but the caller remains the same.
o	Callbacks and Event Handling: Karthik mentioned that delegates are very useful for callbacks and event handling. They allow methods to be passed as arguments and invoked at a later time, which is essential for implementing callbacks and handling events in a flexible and decoupled manner.

•	Events in C#: Karthik introduced the concept of events in C#, explaining that events are built on top of delegates and allow for the publish-subscribe pattern. They provided an example of passing messages between components using events.
o	Events and Delegates: Karthik explained that events in C# are built on top of delegates and are used to implement the publish-subscribe pattern. This pattern allows one component to publish an event, and other components to subscribe to it and respond when the event is raised.
o	Publish-Subscribe Pattern: Karthik provided an example of using events to pass messages between components in a Windows application. He described a scenario with two forms, where data entered in a text box on Form 1 is passed to Form 2 when a button is clicked. Form 1 acts as the publisher, and Form 2 subscribes to the event to receive the data.

•	Event Handling Example: Karthik provided a detailed example of event handling in C#, demonstrating how to create and use events to pass messages between components. They explained the importance of encapsulating methods using delegates and events.
o	Creating Events: Karthik demonstrated how to create an event in a class by first defining a delegate and then declaring an event of that delegate type. For example, `public delegate void ClickHandler();` and `public event ClickHandler OnClick;`.
o	Subscribing to Events: Karthik showed how to subscribe to an event by adding a method to the event's invocation list using the `+=` operator. For example, `button.OnClick += handler.ShowMessage;` subscribes the ShowMessage method to the OnClick event.
o	Raising Events: Karthik explained that only the class that declares the event can raise it. He demonstrated raising an event by invoking the event delegate, for example, `OnClick?.Invoke();`.

•	Differences Between Delegates and Events: Karthik discussed the differences between delegates and events, emphasizing that events add a layer of protection and only the class that declares the event can invoke it. They also explained how to subscribe and unsubscribe from events.
o	Layer of Protection: Karthik emphasized that events add a layer of protection over delegates. While delegates can be invoked by any class, events can only be raised by the class that declares them, providing better encapsulation and control.
o	Subscribing and Unsubscribing: Karthik explained how to subscribe to an event using the `+=` operator and unsubscribe using the `-=` operator. For example, `eventHandler += MethodName;` subscribes to the event, and `eventHandler -= MethodName;` unsubscribes from it.

•	Func, Action, and Predicate Delegates: Karthik explained the differences between Func, Action, and Predicate delegates. They discussed the scenarios in which each type of delegate is used and provided examples of their usage in C#.

•	Predicate Delegate Example: Karthik provided an example of using a Predicate delegate with a collection to filter even numbers. They explained the importance of Predicate delegates in filtering and their usage in collections.

•	Preparation for Next Session: Karthik assigned the participants to review the provided C# reference materials and watch specific videos on Task Parallel Library and async/await concepts. They emphasized the importance of understanding these concepts for the next session.
o	Review Materials: Karthik provided reference materials covering basic C# concepts, including syntax, access specifiers, constructors, and more. He emphasized the importance of reviewing these materials to strengthen foundational knowledge.
o	Task Parallel Library: Karthik assigned participants to watch videos on the Task Parallel Library (TPL) and async/await concepts.

Follow-up tasks:

•	Open-Close Principle Assignment: Complete the assignment on the open-close principle. (The team)

•	C# Fundamentals Video Link: Paste the video link for C# fundamentals in the chat. (The team)

•	Language Fundamentals Video: Watch the language fundamentals video before the next session. (The team)

•	Task Parallel Library and Async Await Videos: Watch the 16th and 17th videos on Task Parallel Library and Async Await before the next session. (The team)

•	IEnumerable vs IEnumerator: Understand the concept of IEnumerable vs IEnumerator and be prepared to discuss it in the next session. (The team)

•	C# Reference Files: Download and keep the provided C# reference files for future use. (The team)

**Day 04 Meeting notes:**
•	Introduction to LINQ: Karthik introduced the concept of LINQ (Language Integrated Query) and its benefits, such as cleaner code, type safety, and Intellisense. They explained that LINQ allows querying data collections, including objects, databases, and XML.
o	Definition and Benefits: Karthik explained that LINQ stands for Language Integrated Query, which allows querying data collections such as objects, databases, and XML. The benefits include cleaner code, type safety, and Intellisense, especially when using Visual Studio or Visual Studio Code with extensions.
o	In-Memory Collections: Karthik highlighted that LINQ works on in-memory collections like List of T, ArrayList, and other generic collections. It also works on external sources like Entity Framework or XML.

•	LINQ Syntax Variants: Karthik discussed the two syntax variants of LINQ: query syntax and method syntax (fluent style). They provided examples of both styles and highlighted the advantages of method syntax for chaining and grouping.
o	Query Syntax: Karthik provided an example of query syntax, which is SQL-like. For instance, to get product names where the price is greater than 100: `var results = from p in products where p.price > 100 select p.name`.
o	Method Syntax: Karthik explained method syntax (fluent style) and its advantages for chaining and grouping. An example provided was: `var results = products.Where(p => p.price > 100).Select(p => p.name)`.

•	LINQ Operations: Karthik explained the most frequently used LINQ operations, including filtering, projection, sorting, grouping, and joining. They provided examples of each operation and emphasized the importance of practising these concepts.
o	Filtering: Karthik explained filtering using the `Where` method to filter records. Example: `products.Where(p => p.price > 100)`.
o	Projection: Projection was explained using the `Select` method to select specific fields. Example: `products.Select(p => p.name)`.
o	Sorting: Sorting was demonstrated using the `OrderBy` and `ThenBy` methods. Example: `products.OrderBy(p => p.name).ThenByDescending(p => p.price)`.
o	Grouping: Karthik mentioned the importance of understanding grouping and joining operations in LINQ, encouraging participants to practice these concepts.

•	Deferred Execution in LINQ: Karthik discussed the concept of deferred execution in LINQ, explaining that LINQ queries are not executed until the result is enumerated. They provided examples and highlighted the importance of understanding deferred execution for performance optimization.
o	Deferred Execution: Karthik explained that deferred execution means LINQ queries are not executed until the result is enumerated. This is important for performance optimization.
o	Example: An example was provided: `var result = products.Where(p => p.price > 100);` This query is not executed until it is enumerated, such as in a `foreach` loop.

•	Immediate Execution Methods: Karthik explained the methods that trigger immediate execution in LINQ, such as ToList, Count, and First. They emphasized the importance of avoiding multiple ToList calls to prevent performance issues.
o	Immediate Execution: Karthik explained that methods like `ToList`, `Count`, and `First` trigger immediate execution of LINQ queries.
o	Performance Issues: Emphasis was placed on avoiding multiple `ToList` calls within queries to prevent performance issues, as each call results in a database call in Entity Framework.

•	Difference Between LINQ to Objects and LINQ to Entities: Karthik explained the difference between LINQ to Objects and LINQ to Entities. LINQ to Objects runs in memory on collections, while LINQ to Entities translates queries to SQL and executes them on a database.
o	LINQ to Objects: Karthik explained that LINQ to Objects runs in memory on collections like lists and arrays.
o	LINQ to Entities: LINQ to Entities translates queries to SQL and executes them on a database, making it suitable for database operations.

•	Optimizing Entity Framework Core Performance: Karthik provided tips for optimizing the performance of Entity Framework Core queries, such as using early projection, avoiding multiple ToList calls, and using the AsNoTracking method.
o	Early Projection: Karthik recommended using early projection to fetch only the required fields, improving performance.
o	Avoid Multiple ToList: It was emphasized to avoid multiple `ToList` calls within queries to prevent performance degradation.
o	AsNoTracking: Karthik mentioned using the `AsNoTracking` method for read-only operations to improve performance by disabling change tracking.

•	Exception Handling Best Practices: Karthik discussed best practices for exception handling, including catching specific exceptions first, not swallowing exceptions silently, preserving the stack trace when rethrowing, and using custom exceptions for business logic errors.
o	Specific Exceptions: Karthik advised catching specific exceptions first before more generic ones to handle errors accurately.
o	Not Swallowing Exceptions: It was emphasized not to swallow exceptions silently but to log or rethrow them properly.
o	Preserving Stack Trace: Karthik explained the importance of preserving the stack trace when rethrowing exceptions for better debugging.
o	Custom Exceptions: Using custom exceptions for business logic errors was recommended to separate business errors from technical errors.

•	Introduction to Modern .NET: Karthik introduced the concept of modern .NET, which includes versions 5, 6, 7, and 8. They explained the evolution from .NET Core to modern .NET and highlighted the key features and differences.
o	Evolution: Karthik explained the evolution from .NET Core to modern .NET, starting with .NET 5, which merged .NET Core and Mono into a unified platform.
o	Key Features: Key features of modern .NET include cross-platform support, high performance, and modular architecture.

•	.NET Core Project Structure: Karthik explained the typical project structure in .NET Core, including files such as Program.cs, Startup.cs, Controllers, Models, Views, appsettings.json, and Middleware. They highlighted the importance of understanding these components.
o	Program.cs: Karthik explained that Program.cs is the entry point of the application, containing startup code, host building, and service registrations.
o	Startup.cs: In older versions, Startup.cs contained the ConfigureServices and Configure methods, but in modern .NET, this logic is moved to Program.cs.
o	Controllers: Controllers contain API endpoints, while Models define domain data models, and Views support Razor UI for MVC applications.
o	Appsettings.json: Appsettings.json is used for configuration settings like database connections, similar to web.config in classic ASP.NET.

•	Best Practices for .NET Core: Karthik discussed best practices for .NET Core development, including using dependency injection, asynchronous programming, applying middleware properly, preferring minimal APIs, and securely managing configuration and secrets.
o	Dependency Injection: Karthik emphasized the importance of using dependency injection, which is built-in and standard in .NET Core.
o	Asynchronous Programming: Asynchronous programming using async and await was recommended for better performance and responsiveness.
o	Middleware: Proper application of middleware for exception handling, logging, and authentication was highlighted as a best practice.

•	Importance of Completing Ocean Assessments: Karthik emphasized the importance of completing Ocean assessments for career development and faster deployment. They encouraged participants to complete their assessments and prepare for the next steps in their careers.

•	Conclusion and Next Steps: Karthik concluded the session by summarizing the topics covered and announcing that the next session will focus on ASP.NET MVC. They encouraged participants to continue practising and preparing for their assessments.
Follow-up tasks:

•	LINQ Operators Practice: Review the PDF on LINQ operators and practise using them in Visual Studio. (The team)

•	Deferred Execution Understanding: Study the concept of deferred execution in LINQ and its implications on performance. (The team)

•	Entity Framework Core Queries: Learn how to optimise performance in Entity Framework Core by using projections early and avoiding multiple ToList calls. (The team)

•	Ocean Training: Complete the Ocean assessment and ensure all learning hours are logged. (The team)

•	Modern .NET Versions: Familiarise with the differences between .NET Framework, .NET Core, and modern .NET versions. (The team)

•	Exception Handling Best Practices: Review and implement best practices for exception handling, including specific exception catching and preserving stack traces. (The team)

•	Minimal API in .NET 6: Explore the concept of minimal API introduced in .NET 6 and understand its benefits for microservices. (The team)


**Day 05 Meeting notes:**
•	ASP.NET MVC Life Cycle: Karthik explained the ASP.NET MVC life cycle, detailing the steps from routing to response. They discussed the importance of understanding the process of how an HTTP request is processed from the browser to the server and back to the client. Karthik also highlighted the significance of each step, including routing, MVC handler execution, controller creation, action selection, model binding, action execution, result execution, and response.
o	Lifecycle Steps: Karthik outlined the ASP.NET MVC life cycle, starting with routing, followed by MVC handler execution, controller creation, action selection, model binding, action execution, result execution, and finally, the response being sent back to the client.
o	Routing: The first step in the ASP.NET MVC life cycle is routing, where the URL is matched against the configured routes defined in the route config file. If no route matches, a 404 error is returned.
o	MVC Handler Execution: In the MVC handler execution step, the request is passed to the MVC handler, which initializes the controller factory.
o	Controller Creation: The controller factory, specifically the IController factory, finds and creates the appropriate controller object.
o	Action Selection: Action selection involves the action invoker finding the right method inside the controller based on routing and HTTP verbs.
o	Model Binding: Model binding maps inputs from query strings, route values, and form fields to action method parameters.
o	Action Execution: During action execution, the action method is invoked and can return various results, such as view result, JSON result, and redirect result.
o	Result Execution: In result execution, the view is rendered using the Razor engine, and the final HTML response is sent back to the browser.

•	Routing in ASP.NET MVC: Karthik discussed the routing process in ASP.NET MVC, explaining that the URL needs to match the configured route defined in the route config file. They also mentioned the default routing pattern and the 404 error returned if no route matches.
o	URL Matching: Karthik explained that the URL needs to match the configured route defined in the route config file, specifically in the route config dot CS file.
o	Default Routing Pattern: The default routing pattern in ASP.NET MVC is controller/action/ID, where the ID is optional.
o	404 Error: If no route matches the URL, a 404 error is returned to the client.

•	Controller Creation and Action Selection: Karthik explained the process of controller creation and action selection in ASP.NET MVC. They mentioned the role of the IController factory in finding and creating the appropriate controller object and the action invoker in finding the right method inside the controller based on routing and HTTP verbs.
o	Controller Factory: The IController factory is responsible for finding and creating the appropriate controller object during the controller creation step.
o	Action Invoker: The action invoker finds the right method inside the controller based on routing and HTTP verbs during the action selection step.

•	Model Binding: Karthik described model binding in ASP.NET MVC, explaining that it maps inputs from query strings, route values, and form fields to action method parameters. They emphasized the importance of understanding this concept for interviews.
o	Input Mapping: Model binding maps inputs from query strings, route values, and form fields to action method parameters in ASP.NET MVC.
o	Importance: Karthik emphasized the importance of understanding model binding for interviews, as it is a key concept in ASP.NET MVC.

•	Action Execution and Result Execution: Karthik discussed the action execution and result execution steps in the ASP.NET MVC life cycle. They explained that the action method can return various results, such as view result, JSON result, and redirect result, and that the view is rendered using the Razor engine.
o	Action Method Results: The action method in ASP.NET MVC can return various results, including view result, JSON result, and redirect result.
o	View Rendering: During result execution, the view is rendered using the Razor engine, and the final HTML response is sent back to the browser.

•	Razor Views and Strongly Typed Views: Karthik introduced Razor views and strongly typed views in ASP.NET MVC. They explained that Razor views use Razor syntax to intermingle C# with HTML and that strongly typed views are associated with a specific model type using the @model directive.
o	Razor Syntax: Razor views use Razor syntax, which allows for the intermingling of C# with HTML using the @ symbol.
o	Strongly Typed Views: Strongly typed views are associated with a specific model type using the @model directive, allowing for compile-time checking and Intellisense support.

•	Validation in ASP.NET MVC: Karthik discussed validation in ASP.NET MVC, explaining that it ensures incoming data satisfies defined rules before processing. They mentioned the use of data annotations like required and range attributes and the role of model state in storing validation results.
o	Data Annotations: Validation in ASP.NET MVC uses data annotations like required and range attributes to ensure incoming data satisfies defined rules before processing.
o	Model State: Model state stores the results of validation checks, and the model state is valid property is used to determine if the data is valid.

•	Action Filters and Authorization Filters: Karthik explained the concept of filters in ASP.NET MVC, including action filters and authorization filters. They discussed the different types of filters, such as action filters, result filters, exception filters, and authorization filters, and their role in executing custom logic before or after controller actions.
o	Filter Types: Karthik explained the different types of filters in ASP.NET MVC, including action filters, result filters, exception filters, and authorization filters.
o	Custom Logic: Filters allow for the execution of custom logic before or after controller actions in ASP.NET MVC.

•	Order of Filter Execution: Karthik highlighted the importance of understanding the order of filter execution in the request pipeline. They mentioned that filters are executed based on their type and order, and multiple filters can be applied to a single action.
o	Execution Order: Karthik explained that filters in ASP.NET MVC are executed based on their type and order in the request pipeline.
o	Multiple Filters: Multiple filters can be applied to a single action, and they are executed in a specific order based on their type.

•	ASP.NET MVC Interview Preparation: Karthik emphasized the importance of preparing for ASP.NET MVC interviews by studying the provided materials and practising the concepts discussed. They mentioned that the provided PDFs contain 100 questions covering various aspects of ASP.NET MVC, which will help in cracking any interview.
o	Study Materials: Karthik emphasized the importance of studying the provided PDFs, which contain 100 questions covering various aspects of ASP.NET MVC.
o	Practice: Karthik encouraged practising the concepts discussed in the meeting to prepare for ASP.NET MVC interviews effectively.

Follow-up tasks:
•	Ocean Assessments Preparation: Prepare for the ocean assessments as per the nomination email received. (All Participants)

•	ASP.NET MVC Lifecycle: Create a simple example demonstrating the ASP.NET MVC lifecycle, including routing, controller creation, and action execution. (All Participants)

•	ASP.NET MVC Interview Questions: Review the ASP.NET MVC interview questions PDF shared via email and prepare for potential questions. (All Participants)

•	Razor Views and Strongly Typed Views: Practise writing code examples for Razor views and strongly typed views, including model binding and data annotations. (All Participants)

•	Action Filters Example: Practise writing code for creating and using custom action filters in ASP.NET MVC. (All Participants)

•	PDF Verification: Share your screen to verify the receipt and content of the PDFs shared via email. (All Participants)

**Day 06 Meeting notes:**
•	Introduction to Modern MVC: Karthik introduced the session by discussing the transition from classic ASP.NET MVC to modern ASP.NET Core MVC, focusing on routing.
o	Introduction: Karthik welcomed everyone and mentioned that the session would focus on modern MVC, specifically ASP.NET Core MVC, transitioning from the classic ASP.NET MVC discussed previously.
o	Modern MVC: Karthik explained that modern MVC refers to ASP.NET Core MVC and highlighted the importance of understanding routing in this context.

•	Types of Routing: Karthik explained the two types of routing in ASP.NET Core MVC: conventional routing and attribute routing, highlighting their differences and usage.
o	Conventional Routing: Karthik described conventional routing as pattern-based, where routes are defined in a specific pattern such as "controller/action/id".
o	Attribute Routing: Karthik explained that attribute routing is applied at the controller or action level using attributes, providing more control over the routing process.
o	Usage: Karthik emphasized the importance of understanding both routing types for interviews, noting that conventional routing is defined in routeconfig.cs in classic MVC and in program.cs in modern MVC.

•	Routing Configuration: Karthik discussed where routing configurations are defined in modern MVC, specifically in the program.cs file, and the default patterns for conventional routing.
o	Program.cs: Karthik highlighted that in modern MVC, routing configurations are defined in the program.cs file, unlike in classic MVC where they are defined in routeconfig.cs.
o	Default Pattern: Karthik explained the default pattern for conventional routing as "controller/action/id", with "Home" as the default controller and "Index" as the default action, and noted that the ID is optional.

•	Attribute Routing Precedence: Karthik clarified that attribute routing takes precedence over conventional routing when both are configured, and emphasized the importance of not overlapping routes to avoid ambiguity.
o	Precedence: Karthik stated that attribute routing takes precedence over conventional routing when both are configured, due to its higher precedence.
o	Ambiguity: Karthik warned against overlapping routes as it can cause ambiguity, stressing the need for clear and distinct route definitions.

•	Enabling Middleware for Routing: Karthik explained the necessity of enabling specific middleware in the program.cs file, such as app.UseRouting and app.UseEndpoints, for routing to function correctly.
o	Middleware: Karthik emphasized the importance of enabling app.UseRouting and app.UseEndpoints middleware in the program.cs file for routing to function correctly in ASP.NET Core MVC.
o	UseEndpoints: Karthik explained that app.UseEndpoints is used to define endpoints, specifying the default route pattern as "controller/action/id" with "Index" as the default action and ID as optional.

•	Dependency Injection in Controllers: Karthik discussed the use of dependency injection in ASP.NET Core MVC controllers, highlighting the built-in DI system and the process of registering services in the program.cs file.
o	Built-in DI: Karthik explained that ASP.NET Core MVC has a built-in dependency injection (DI) system, unlike classic MVC which requires third-party libraries for DI.
o	Service Registration: Karthik detailed the process of registering services in the program.cs file using methods like AddScoped, AddTransient, and AddSingleton, and explained their differences.
o	Controller Instantiation: Karthik noted that in ASP.NET Core MVC, controllers are instantiated via the DI container, whereas in classic MVC, it is done manually through a controller factory.

•	Model Validation and Custom Attributes: Karthik explained the automatic validation of action parameters and model properties in ASP.NET Core MVC, and demonstrated how to create a custom validation attribute.
o	Automatic Validation: Karthik explained that ASP.NET Core MVC automatically validates action parameters and model properties against validation attributes before executing controller actions.
o	Custom Attribute: Karthik demonstrated how to create a custom validation attribute called "MustBeEvenNumberAttribute" by inheriting from ValidationAttribute and overriding the IsValid method.

•	Partial Views vs. View Components: Karthik differentiated between partial views and view components, explaining their respective uses and the scenarios in which each should be employed.
o	Partial Views: Karthik described partial views as reusable pieces of UI without logic, used primarily for rendering views.
o	View Components: Karthik explained that view components are reusable, independent units containing both UI and logic, similar to mini controllers.
o	Usage Scenarios: Karthik advised using partial views for reusable UI without logic and view components for reusable UI with logic.

•	Preparation for Barclays Interview: Karthik emphasized the importance of preparing for the Barclays interview by completing the provided 100 questions on ASP.NET Core MVC and C# scenario-based questions, and watching the related video links.

•	Internal Evaluation for Interview Readiness: Karthik announced plans for an internal evaluation to assess the readiness of participants for the Barclays interview, and encouraged interested individuals to put their names forward.





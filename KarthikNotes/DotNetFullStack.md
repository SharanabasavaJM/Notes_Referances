Topics
--------------------------------------------------------
C# (Core Language Skills) 
- OOP Principles (Inheritance, Polymorphism, Encapsulation, Abstraction)
- Interfaces vs Abstract Classes
- Delegates, Events, Func/Action/Predicate
- Exception Handling best practices
- Async / Await (Task-based async programming)
- LINQ (Basics and Complex queries)
- Collections & Generics
 
.NET Core (Framework Knowledge) 
- Dependency Injection (Built-in in Core)
- Middleware Pipeline (Ordering, Custom Middleware)
- Configuration and AppSettings Management
- Logging (ILogger, Structured logging concepts)
- Environment-based behavior (Development, Production)
 
ASP.NET MVC (Classic MVC) 
- MVC Lifecycle (Request to Response)
- Razor Views vs Strongly Typed Views
- Model Binding and Validation
- Action Filters and Authorization Filters
 
ASP.NET Core MVC (Modern MVC) 
- Routing (Attribute Routing, Conventional Routing)
- Dependency Injection in Controllers
- Model Validation and Custom Validation Attributes
- ViewComponents and Partial Views
 
ASP.NET Core Web API 
- RESTful API Design (Idempotency, Statelessness)
- HTTP Verbs and Status Codes Usage
- Authentication and Authorization (JWT Token Basics)
- Model Binding in Web API (FromBody, FromQuery)
- Exception Handling (UseExceptionHandler Middleware)
- Versioning of APIs (URL-based, Header-based)
 
Entity Framework Core 
- Code First vs Database First Approach
- Migrations (Add, Update, Remove models/tables)
- LINQ to Entities (Queries, Joins, Projections)
- Tracking vs No-Tracking Queries
- Lazy Loading vs Eager Loading
- Transaction Management
 
Azure Fundamentals 
- Azure Regions, Subscriptions, Resource Groups
- Azure Storage
- App Service, SQL Database, Blob Storage overview
- Azure Key Vault, App Insights basics
- Azure AD basics (only for understanding Authentication)
 
Azure PaaS Offerings (Deep) 
- Azure App Service (Deployment, Scaling)
- Azure SQL Database (DTU vs vCore Models)
- Application Gateway, Azure Load Balancer Basics
- App Insights integration with .NET Core Apps
- Managed Identity Basics (accessing KeyVault from API)
- API Management
 
CI/CD Fundamentals 
- DevOps Pipelines Overview (Azure DevOps, GitHub Actions)
- Build and Release Pipeline Basics
- Web App Deployment using Pipelines
- Simple YAML Pipelines for Web API
- Importance of Unit Tests in Build Validation
 
T-SQL (SQL Server Basics) 
- Joins (Inner, Left, Right, Full)
- Stored Procedures vs Inline Queries
- CTEs (Common Table Expressions)
- Error Handling (Try-Catch in SQL)
- Index Basics (Clustered, Non-Clustered)
- Transactions and Isolation Levels



-------------------------------------------------------------------------------------------------------------
.Net Core WebAPI
-------------------------------------------------------------------------------------------------------------
1. Introduction to .NET Core Web API
Basics of .NET Core Web API
Question: What is a .NET Core Web API, and how is it different from a traditional web application?
Answer: A .NET Core Web API is a framework for building HTTP services that can be consumed by web
browsers, mobile apps, or other applications. Unlike traditional web applications, which return HTML
pages, Web APIs return data in formats like JSON or XML, enabling communication between client and
server applications.

RESTful Services
Question: What does it mean to build a RESTful Web API, and what are the key principles?
Answer: REST (Representational State Transfer) is an architectural style for creating scalable web
services. A RESTful Web API adheres to key principles like:
Statelessness: Each request from a client must contain all the necessary information.
Use of HTTP methods: Methods like GET, POST, PUT, DELETE are used according to their
intended purpose.
Uniform interface: Resource-based URLs (e.g., /api/products ).
Client-Server separation.

3. Routing in .NET Core Web API
Attribute Routing vs Convention-Based Routing
Question: What is the difference between attribute-based routing and convention-based routing in .NET Core Web API?
Answer:
Convention-based routing (defined in Startup.cs ) uses a centralized route template for all
controllers.
Attribute-based routing (defined directly in controllers) allows more flexibility by specifying
routes at the action or controller level using [Route] attributes.
csharp Copy code
[Route("api/[controller]")] public class ProductsController : ControllerBase {
[HttpGet("{id}")] public IActionResult GetProduct(int id) { } }

Route Constraints
Question: What are route constraints in .NET Core Web API, and how are they used?
Answer: Route constraints restrict the parameters that can be passed in the route. For example, restricting
a route to accept only integer values:
csharp Copy code
[Route("api/products/{id:int}")] public IActionResult GetProduct(int id) { }

3. HTTP Methods and Status Codes
Using HTTP Methods
Question: How are HTTP methods like GET, POST, PUT, and DELETE mapped to actions in .NET Core
Web API?
Answer: HTTP methods are mapped to controller actions using attributes:
GET for retrieving data ( [HttpGet] ).
POST for creating resources ( [HttpPost] ).
PUT for updating resources ( [HttpPut] ).
DELETE for removing resources ( [HttpDelete] ).

Status Codes
Question: How do you return proper HTTP status codes in .NET Core Web API?
Answer: You can return appropriate status codes using predefined helper methods like:
Ok() for 200 (Success),
NotFound() for 404 (Resource not found),
BadRequest() for 400 (Client error),
Created() for 201 (Resource created),
NoContent() for 204 (Successful but no content returned).
csharp
if (product == null) return NotFound(); return Ok(product);
Copy code

4. Model Binding and Validation
Model Binding
Question: How does model binding work in .NET Core Web API?
Answer: Model binding in .NET Core Web API automatically maps data from HTTP requests (query
strings, form data, or JSON bodies) to action method parameters or model classes. It simplifies the
process of extracting data from HTTP requests into strongly-typed objects.

Model Validation
Question: How do you perform model validation in .NET Core Web API?
Answer: You can use data annotations like [Required] , [StringLength] , and [Range] on model
properties. Model validation is triggered automatically, and validation errors can be checked
using ModelState.IsValid . If the model is invalid, you can return a BadRequest() response with
validation errors.
csharp Copy code
[HttpPost] public IActionResult CreateProduct([FromBody] Product model) 
{ 
  if(!ModelState.IsValid) return BadRequest(ModelState); 
  return CreatedAtAction("GetProduct", new { id = model.Id }, model); 
}

5. Dependency Injection in .NET Core Web API
Built-in Dependency Injection
Question: How does dependency injection work in .NET Core Web API, and why is it important?
Answer: Dependency injection (DI) is built into .NET Core, allowing services to be injected into
controllers or other services through constructor injection. It promotes loose coupling and testability.
Services are registered in Startup.cs using AddTransient() , AddScoped() , or AddSingleton() for
different lifetimes.
csharp Copy code
public class ProductsController : ControllerBase { private readonly IProductService
_productService; public ProductsController(IProductService productService) {
_productService = productService; } }

Service Lifetimes
Question: What are the different service lifetimes in .NET Core DI?
Answer:
Transient: Services are created every time they are requested.
Scoped: Services are created once per request.
Singleton: Services are created once and reused throughout the application's lifetime.

6. Middleware in .NET Core Web API
Custom Middleware
Question: How do you create custom middleware in .NET Core Web API?
Answer: Custom middleware is a component that handles HTTP requests and responses. Middleware is
added to the pipeline in Startup.cs . You create custom middleware by implementing a class with
an Invoke or InvokeAsync method that takes an HttpContext as a parameter.
csharp Copy code
public class CustomMiddleware { private readonly RequestDelegate _next; public
CustomMiddleware(RequestDelegate next) { _next = next; } public async Task
InvokeAsync(HttpContext context) { // Custom logic await _next(context); // Call
the next middleware in the pipeline } }

Adding Middleware to the Pipeline
Question: How do you add middleware to the request pipeline in .NET Core?
Answer: Middleware components are added to the pipeline using app.UseMiddleware<T>() or
predefined methods like app.UseAuthentication() , app.UseRouting() , etc., in
the Configure method of Startup.cs .
csharp Copy code
public void Configure(IApplicationBuilder app) {
app.UseMiddleware<CustomMiddleware>(); app.UseRouting(); app.UseEndpoints(endpoints
=> { endpoints.MapControllers(); }); }

7. Authentication and Authorization
JWT Authentication
Question: How is JWT authentication implemented in .NET Core Web API?
Answer: JWT (JSON Web Token) authentication is implemented by configuring the authentication
middleware in Startup.cs to validate tokens. Tokens are usually issued by an identity provider and are
included in the request headers ( Authorization: Bearer <token> ).
csharp Copy code
public void ConfigureServices(IServiceCollection services) {
services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options => { options.TokenValidationParameters = new
TokenValidationParameters { ValidateIssuer = true, ValidateAudience = true,
ValidateLifetime = true, ValidateIssuerSigningKey = true, ValidIssuer =
"yourIssuer", ValidAudience = "yourAudience", IssuerSigningKey = new
SymmetricSecurityKey(Encoding.UTF8.GetBytes("yourSecretKey")) }; }); }

Role-Based Authorization
Question: How do you implement role-based authorization in .NET Core Web API?
Answer: Role-based authorization is implemented by decorating controller actions
with [Authorize(Roles = "Admin, Manager")] . This ensures that only users in the specified roles can
access the endpoint.
csharp
[Authorize(Roles = "Admin")] [HttpPost("create")] public IActionResult
CreateProduct(Product model) { }

9. Error Handling in .NET Core Web API
Global Error Handling
Question: How do you implement global error handling in .NET Core Web API?
Answer: You can implement global error handling using exception-handling middleware.
In Startup.cs , you can add middleware to catch exceptions globally and return appropriate HTTP
responses.
csharp Copy code
public void Configure(IApplicationBuilder app) { app.UseExceptionHandler(errorApp
=> { errorApp.Run(async context => { context.Response.StatusCode = 500; await
context.Response.WriteAsync("An unexpected error occurred."); }); }); }

Returning Custom Error Responses
Question: How do you return custom error responses in .NET Core Web API?
Answer: Custom error responses can be returned using the Problem() or BadRequest() methods,
which allow you to format error messages with relevant information. For more control, custom exceptions
can be created and handled using middleware or filters.
csharp Copy code
if (!ModelState.IsValid) { return BadRequest(new { message = "Invalid data", errors
= ModelState.Values.SelectMany(e => e.Errors) }); }

11. Versioning in .NET Core Web API
API Versioning
Question: How is API versioning implemented in .NET Core Web API?
Answer: API versioning allows multiple versions of an API to coexist. It can be implemented
using the Microsoft.AspNetCore.Mvc.Versioning NuGet package. You can configure versioning
via query strings, URL segments, or headers. Once added, you can annotate your controllers
with version attributes.
[ApiVersion("1.0")] [Route("api/v{version:apiVersion}/products")] public class
ProductsV1Controller : ControllerBase { [HttpGet] public IActionResult GetV1() {
return Ok("Version 1"); } } [ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/products")] public class ProductsV2Controller :
ControllerBase { [HttpGet] public IActionResult GetV2() { return Ok("Version 2"); }
}

Configuring API Versioning
Question: How do you configure API versioning in .NET Core Web API?
Answer: You configure API versioning in the Startup.cs by registering the versioning service:
csharp
public void ConfigureServices(IServiceCollection services) {
services.AddApiVersioning(options => { options.DefaultApiVersion = new
ApiVersion(1, 0); options.AssumeDefaultVersionWhenUnspecified = true;
options.ReportApiVersions = true; }); }

12. CORS (Cross-Origin Resource Sharing)
Enabling CORS
Question: How do you enable CORS in .NET Core Web API, and why is it necessary?
Answer: CORS allows resources to be requested from another domain, which is typically
restricted by web browsers for security reasons. To enable CORS in .NET Core Web API, you need
to configure CORS policies in Startup.cs .
public void ConfigureServices(IServiceCollection services) {
services.AddCors(options => { options.AddPolicy("AllowAll", builder =>
builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); }); } public void
Configure(IApplicationBuilder app) { app.UseCors("AllowAll"); }

CORS Policies
Question: What is the significance of configuring CORS policies, and how do you apply them
selectively?
Answer: CORS policies can be configured to allow or restrict access to specific domains,
methods, or headers. You can apply CORS selectively by applying a policy at the controller or
action level.
[EnableCors("AllowSpecificOrigins")] [HttpGet] public IActionResult GetProduct() {
return Ok(); }

11 Asynchronous Programming in .NET Core Web API
Using async and await
Question: How do you implement asynchronous operations in .NET Core Web API?
Answer: Asynchronous programming improves scalability by freeing up threads while awaiting
external resources like database calls or API requests. In .NET Core Web API, you use
the async keyword on actions, and the await keyword for I/O-bound operations like database
queries.
[HttpGet("{id}")] public async Task<IActionResult> GetProduct(int id) { var product
= await _productService.GetProductAsync(id); if (product == null) return
NotFound(); return Ok(product); }

Benefits of Asynchronous Programming
Question: What are the benefits of using asynchronous programming in .NET Core Web API?
Answer: Asynchronous programming allows more efficient use of resources, improves
scalability, and reduces thread blocking during I/O-bound operations, such as database access
or external API calls. This leads to better performance and responsiveness in high-load
applications.

12. Logging and Monitoring
Built-in Logging
Question: How does logging work in .NET Core Web API, and what are some best practices?
Answer: .NET Core provides built-in support for logging through ILogger and third-party
providers (e.g., Serilog, NLog). Logging can be used to track errors, warnings, and informational
messages.
private readonly ILogger<ProductsController> _logger; public
ProductsController(ILogger<ProductsController> logger) { _logger = logger; } public
IActionResult GetProduct(int id) { _logger.LogInformation("Fetching product with ID
{id}", id); // Other logic }

Structured Logging
Question: What is structured logging, and why is it important in .NET Core Web API?
Answer: Structured logging captures log data as key-value pairs, enabling better querying,
filtering, and analysis of log entries. This is useful for diagnostics and monitoring in production
environments, where logs may need to be analyzed for specific data points like user IDs or
request paths.

14. Health Checks in .NET Core Web API
Implementing Health Checks
Question: How do you implement health checks in .NET Core Web API?
Answer: Health checks monitor the health of the application, such as database connectivity or
service dependencies. In .NET Core, health checks can be implemented using
the Microsoft.Extensions.Diagnostics.HealthChecks package.
public void ConfigureServices(IServiceCollection services) {
services.AddHealthChecks() .AddCheck<CustomHealthCheck>("CustomCheck")
.AddSqlServer(Configuration.GetConnectionString("DefaultConnection")); } public
void Configure(IApplicationBuilder app) { app.UseHealthChecks("/health"); }

Creating Custom Health Checks
Question: How do you create custom health checks in .NET Core Web API?
Answer: Custom health checks can be created by implementing the IHealthCheck interface.
This allows you to define custom logic to verify the health of any service or resource.
csharp Copy code
public class CustomHealthCheck : IHealthCheck { public Task<HealthCheckResult>
CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken =
default) { bool healthCheckResultHealthy = true; if (healthCheckResultHealthy) {
return Task.FromResult(HealthCheckResult.Healthy("A healthy result.")); } return
Task.FromResult(HealthCheckResult.Unhealthy("An unhealthy result.")); } }

16. Rate Limiting in .NET Core Web API
Implementing Rate Limiting
Question: How can rate limiting be implemented in .NET Core Web API?
Answer: Rate limiting controls the number of requests a user or client can make within a specific
time window, preventing abuse or overuse of resources. This can be implemented using third
party libraries like AspNetCoreRateLimit or through custom middleware that tracks client
request counts.

Using Middleware for Rate Limiting
Question: How would you create custom middleware to limit the number of requests in .NET
Core Web API?
Answer: You can create custom middleware that tracks the number of requests from each client
(identified by IP address or API key) and throttles requests if the limit is exceeded.
public class RateLimitingMiddleware { private readonly RequestDelegate _next;
private static Dictionary<string, int> _requestCounts = new Dictionary<string, int>
(); public RateLimitingMiddleware(RequestDelegate next) { _next = next; } public
async Task Invoke(HttpContext context) { var clientIp =
context.Connection.RemoteIpAddress.ToString(); if
(_requestCounts.ContainsKey(clientIp)) { _requestCounts[clientIp]++; } else {
_requestCounts[clientIp] = 1; } if (_requestCounts[clientIp] > 100) { // Example
limit context.Response.StatusCode = 429; // Too Many Requests await
context.Response.WriteAsync("Rate limit exceeded."); return; } await
_next(context); } }


-------------------------------------------------------------------------------------------------------------
.Net Core WebAPI - 2
-------------------------------------------------------------------------------------------------------------

1. Introduction to Web API
Basics of Web API
Question: What is ASP.NET Web API, and how does it differ from ASP.NET MVC?
Answer: ASP.NET Web API is a framework for building HTTP-based services that can be consumed by a
wide variety of clients, including browsers and mobile devices. While ASP.NET MVC is primarily used
to return views (HTML), Web API is used to return data (typically JSON or XML). It focuses on RESTful
services and is stateless, unlike ASP.NET MVC.

RESTful Services
Question: What are RESTful services, and how are they implemented in Web API?
Answer: RESTful services follow the principles of Representational State Transfer (REST), where each
resource (like users, orders) is identified by a URI and operations are performed using HTTP methods
such as GET, POST, PUT, and DELETE. Web API maps these HTTP methods to controller actions.

2. HTTP Methods in Web API
Mapping HTTP Methods to Controller Actions
Question: How does Web API map HTTP methods (GET, POST, PUT, DELETE) to controller actions?
Answer: In Web API, HTTP methods are mapped to controller actions based on method names or
attributes like [HttpGet] , [HttpPost] , [HttpPut] , and [HttpDelete] . Web API automatically
maps actions with common names like Get() , Post() , Put() , and Delete() to the respective HTTP
methods.
[HttpGet] public IEnumerable<Product> GetProducts() { return
_productService.GetAll(); }

Custom HTTP Method Mapping
Question: How can you map custom HTTP methods to controller actions in Web API?
Answer: You can map custom HTTP methods using attributes like [AcceptVerbs("PATCH", "HEAD")] .
This allows you to handle non-standard HTTP methods or map multiple methods to a single action.
csharp Copy code
[AcceptVerbs("PATCH")] public IHttpActionResult UpdatePartially(int id,
JsonPatchDocument<Product> patchDoc) { // Handle partial update }

4. Routing in Web API
Attribute Routing
Question: How is attribute routing implemented in Web API?
Answer: Attribute routing allows defining routes directly on controller actions using attributes
like [Route] and [RoutePrefix] . It provides greater control over the URI structure and is more
flexible than conventional routing.
[Route("api/products/{id:int}")] public IHttpActionResult GetProductById(int id) {
var product = _productService.GetById(id); return Ok(product); }

Conventional Routing
Question: What is conventional routing in Web API, and how is it configured?
Answer: Conventional routing in Web API is defined in the WebApiConfig.cs file using
the MapHttpRoute method. It follows a pattern like api/{controller}/{id} , where the controller and
action are inferred from the URL.
csharp Copy code
config.Routes.MapHttpRoute( name: "DefaultApi", routeTemplate:
"api/{controller}/{id}", defaults: new { id = RouteParameter.Optional } );

6. Action Results and Responses
Returning Data in Web API
Question: How do you return data in Web API from a controller action?
Answer: Data in Web API is returned using IHttpActionResult or directly as a type
like IEnumerable<T> . Common responses include Ok() (HTTP 200), NotFound() (HTTP 404),
and BadRequest() (HTTP 400). These methods help return both data and HTTP status codes.
public IHttpActionResult GetProduct(int id) { var product =
_productService.GetById(id); if (product == null) { return NotFound(); } return
Ok(product); }

JSON and XML Formatting
Question: How does Web API handle JSON and XML formatting of responses?
Answer: By default, Web API returns JSON or XML based on the Accept header sent by the client. It
uses media type formatters to convert objects into JSON or XML. You can configure which formatters to
use in HttpConfiguration .
config.Formatters.JsonFormatter.SerializerSettings.Formatting =
Formatting.Indented;
Copy code

8. Model Binding in Web API
Model Binding from HTTP Requests
Question: How does Web API bind data from HTTP requests to action method parameters?
Answer: Web API automatically binds data from the request body (for POST and PUT) or query strings
(for GET) to action method parameters. This process is called model binding and works for primitive
types, complex types, and collections.
public IHttpActionResult CreateProduct([FromBody] Product product) { if
(ModelState.IsValid) { _productService.Create(product); return
CreatedAtRoute("DefaultApi", new { id = product.Id }, product); } return
BadRequest(ModelState); }

Binding Complex Types
Question: How do you bind complex types in Web API from HTTP requests?
Answer: Complex types are typically bound from the request body for POST and PUT requests. The
request body is automatically deserialized into the specified complex type. You can
use [FromBody] explicitly to bind from the request body.
public IHttpActionResult UpdateProduct([FromBody] Product product) {
_productService.Update(product); return Ok(); }

10. Error Handling in Web API
Global Exception Handling
Question: How do you implement global exception handling in Web API?
Answer: Global exception handling is implemented using ExceptionHandler or ExceptionFilter .
You can create a custom exception handler by inheriting from ExceptionHandler and registering it
in HttpConfiguration .
public class GlobalExceptionHandler : ExceptionHandler { public override void
Handle(ExceptionHandlerContext context) { context.Result = new
ResponseMessageResult(context.Request.CreateErrorResponse(HttpStatusCode.InternalServe
"An error occurred")); } } config.Services.Replace(typeof(IExceptionHandler), new
GlobalExceptionHandler());

Action-Specific Error Handling
Question: How do you handle exceptions within individual Web API actions?
Answer: You can handle exceptions within specific Web API actions using try-catch blocks. Additionally,
you can return specific error responses like BadRequest() or NotFound() .
public IHttpActionResult GetProduct(int id) { try { var product =
_productService.GetById(id); if (product == null) { return NotFound(); } return
Ok(product); } catch (Exception ex) { return InternalServerError(ex); } }

12. Authorization and Security in Web API
Basic Authentication
Question: How do you implement basic authentication in Web API?
Answer: Basic authentication can be implemented using a
custom AuthorizeAttribute or AuthenticationFilter that checks the Authorization header for
valid credentials.
public class BasicAuthenticationAttribute : AuthorizationFilterAttribute { public
override void OnAuthorization(HttpActionContext actionContext) { var authHeader =
actionContext.Request.Headers.Authorization; if (authHeader == null ||
authHeader.Scheme != "Basic") { actionContext.Response =
actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized); return; } //
Check credentials } }

Token-Based Authentication (JWT)
Question: How do you implement JWT (JSON Web Token) authentication in Web API?
Answer: JWT-based authentication is implemented by validating the token in
the Authorization header of HTTP requests. You can use libraries
like System.IdentityModel.Tokens.Jwt to validate and issue JWT tokens.
var tokenHandler = new JwtSecurityTokenHandler(); var tokenDescriptor = new
SecurityTokenDescriptor { Subject = new ClaimsIdentity(new Claim[] { new
Claim(ClaimTypes.Name, user.Name) }), Expires = DateTime.UtcNow.AddDays(7),
SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
SecurityAlgorithms.HmacSha256Signature) }; var token =
tokenHandler.CreateToken(tokenDescriptor); return tokenHandler.WriteToken(token);

14. CORS (Cross-Origin Resource Sharing)
Enabling CORS
Question: How do you enable CORS in Web API?
Answer: CORS (Cross-Origin Resource Sharing) allows web applications from one domain to make
requests to APIs on another domain. In Web API, you enable CORS using the EnableCorsAttribute or
through configuration in HttpConfiguration .
csharp Copy code
config.EnableCors(new EnableCorsAttribute("https://example.com", "*", "*"));

15. Versioning in Web API
API Versioning
Question: How do you implement versioning in Web API?
Answer: API versioning can be implemented using various approaches such as:
URL Versioning: Adding the version number to the URL (e.g., api/v1/products ).
Query String Versioning: Passing the version number as a query parameter
(e.g., api/products?version=1 ).

Header Versioning: Including the version in a custom HTTP header.
For URL versioning, the route template is updated to include the version:
[Route("api/v1/products")] public class ProductsV1Controller : ApiController {
public IEnumerable<Product> GetProducts() { return _productService.GetAll(); } }

Versioning via Header
Question: How do you implement header-based versioning in Web API?
Answer: Header-based versioning can be implemented by checking for a custom version header
in the request and routing the request to the appropriate controller.
public class ApiVersionHandler : DelegatingHandler { protected override async
Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken
cancellationToken) { if (request.Headers.Contains("api-version")) { var version =
request.Headers.GetValues("api-version").FirstOrDefault(); // Logic for routing
based on version } return await base.SendAsync(request, cancellationToken); } }

17. Testing in Web API
Unit Testing Controllers
Question: How do you unit test Web API controllers?
Answer: Unit testing Web API controllers involves testing the action methods to ensure they
return the correct HttpResponseMessage or IHttpActionResult . Mocking frameworks like Moq
can be used to mock dependencies and isolate the controller logic.

[TestMethod] public void GetProduct_ReturnsOk() { var mockService = new
Mock<IProductService>(); mockService.Setup(service =>
service.GetById(1)).Returns(new Product { Id = 1 }); var controller = new
ProductsController(mockService.Object); var result = controller.GetProduct(1) as
OkNegotiatedContentResult<Product>; Assert.IsNotNull(result); Assert.AreEqual(1,
result.Content.Id); }

Integration Testing
Question: How do you perform integration testing for a Web API?
Answer: Integration testing involves testing the Web API endpoints in a real or in-memory
environment, ensuring the components work together. You can use HttpClient to send
requests to the API and verify responses.

[TestMethod] public async Task GetProducts_ReturnsProducts() { var client = new
HttpClient { BaseAddress = new Uri("http://localhost:5000") }; var response = await
client.GetAsync("api/products"); response.EnsureSuccessStatusCode(); var products =
await response.Content.ReadAsAsync<IEnumerable<Product>>();
Assert.IsTrue(products.Any()); }


18. Throttling and Rate Limiting
Implementing Rate Limiting
Question: How do you implement rate limiting in Web API?
Answer: Rate limiting can be implemented by restricting the number of requests a client can
make to the API in a given time window. You can use third-party libraries
like AspNetCoreRateLimit or implement it manually by tracking client requests and applying
logic to throttle excessive requests.
public class RateLimitHandler : DelegatingHandler { private static
Dictionary<string, int> _requestCounts = new Dictionary<string, int>(); protected
override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
CancellationToken cancellationToken) { var clientIp = request.GetClientIpAddress();
if (_requestCounts.ContainsKey(clientIp) && _requestCounts[clientIp] >= 100) {
return request.CreateResponse(HttpStatusCode.TooManyRequests, "Rate limit
exceeded"); } _requestCounts[clientIp] = _requestCounts.ContainsKey(clientIp) ?
_requestCounts[clientIp] + 1 : 1; return await base.SendAsync(request,
cancellationToken); } }

19. Logging and Monitoring
Logging in Web API
Question: How do you implement logging in Web API?
Answer: Logging can be implemented using logging frameworks like NLog, Serilog, or the built
in ILogger in ASP.NET Core. You can log important events, errors, and request details by
injecting a logger into your controllers or using middleware to log each request.

public class ProductsController : ApiController { private readonly
ILogger<ProductsController> _logger; public
ProductsController(ILogger<ProductsController> logger) { _logger = logger; } public
IHttpActionResult GetProducts() { _logger.LogInformation("Fetching all products");
return Ok(_productService.GetAll()); } }

Monitoring with Application Insights
Question: How do you integrate Application Insights for monitoring in Web API?
Answer: Application Insights can be integrated into a Web API project to monitor application
performance, request statistics, exceptions, and more. You install the Application Insights SDK
and configure it to track telemetry data.

public class ProductsController : ApiController { private readonly TelemetryClient
_telemetry; public ProductsController() { _telemetry = new TelemetryClient(); }
public IHttpActionResult GetProducts() { _telemetry.TrackEvent("GetProducts
called"); return Ok(_productService.GetAll()); } }

21. Dependency Injection (DI) in Web API
Implementing Dependency Injection
Question: How do you implement dependency injection in Web API?
Answer: Dependency Injection in Web API can be implemented using libraries like Unity,
Autofac, or Ninject, or by using the built-in DI support in ASP.NET Core. Services are registered
in Startup.cs and injected into controllers via constructors.

public class ProductsController : ApiController { private readonly IProductService
_productService; public ProductsController(IProductService productService) {
_productService = productService; } }

Registering Services in ASP.NET Core
Question: How do you register services for dependency injection in ASP.NET Core Web API?
Answer: Services are registered in the Startup.ConfigureServices method
using services.AddScoped() , services.AddSingleton() , or services.AddTransient() . These
define the lifetime of the service.

public void ConfigureServices(IServiceCollection services) {
services.AddScoped<IProductService, ProductService>(); }

22. Caching in Web API
Implementing Response Caching
Question: How do you implement response caching in Web API?
Answer: Response caching is implemented to store a copy of the response and reuse it for
subsequent requests. In ASP.NET Core, this can be done using the ResponseCache attribute
or Cache-Control headers.
[ResponseCache(Duration = 60)] public IHttpActionResult GetProducts() { return
Ok(_productService.GetAll()); }

Using In-Memory Caching
Question: How do you implement in-memory caching in Web API?
Answer: In-memory caching is used to store frequently accessed data in memory to avoid
querying the database repeatedly. You can use IMemoryCache in ASP.NET Core for this purpose.

public class ProductsController : ApiController { private readonly IMemoryCache
_cache; public ProductsController(IMemoryCache cache) { _cache = cache; } public
IHttpActionResult GetProducts() { if (!_cache.TryGetValue("products", out
List<Product> products)) { products = _productService.GetAll();
_cache.Set("products", products, TimeSpan.FromMinutes(5)); } return Ok(products); }
}

24. OData in Web API
Implementing OData Queries
Question: How do you implement OData queries in Web API?
Answer: OData is implemented in Web API to enable advanced querying options such as
filtering, sorting, and paging. You can install the OData package and decorate controller actions
with [EnableQuery] to allow OData query options.

[EnableQuery] public IQueryable<Product> GetProducts() { return
_productService.GetAll().AsQueryable(); }



-------------------------------------------------------------------------------------------------------------
.Net Core WebAPI - 3
-------------------------------------------------------------------------------------------------------------
1   ASP.NET Core Web API Interview Questions by Karthik M
2   ======================================================
3   
4   
5   Q1. What is ASP.NET Core Web API?
6   
7   Answer:
8   ASP.NET Core Web API is a lightweight, cross-platform framework for building RESTful 
services over HTTP.
9   It enables communication between different systems (like browsers, mobile apps, other 
servers) using standard HTTP verbs (GET, POST, PUT, DELETE).
10   
11   Basic Controller:
12   
13   [ApiController]
14   [Route("api/[controller]")]
15   public class ProductsController : ControllerBase
16   {
17       [HttpGet]
18       public IEnumerable<Product> GetAll()
19       {
20           // Fetch products from database
21           return productService.GetAll();
22       }
23   }
24   
25   Note: ASP.NET Core Web API uses ControllerBase (instead of Controller) because there are 
no Views, only data responses.
26   
27   
28   
29   
30   Q2. What is the difference between Controller and ControllerBase in ASP.NET Core?
31   
32   Answer:
33   
34   
35   Controller ControllerBase
36   ===============================================================================
37   Inherits from ControllerBase Base class
38   Supports both Views (MVC) and APIs Supports only APIs (no Views)
39   Used when building web applications with UI Used for building Web APIs only
40   
41   Example:
42   
43   public class HomeController : Controller → For MVC (Views + APIs)
44   public class ProductController : ControllerBase → For pure APIs
45   
46   
47   
48   
49   Q3. What is the [ApiController] attribute?
50   
51   Answer:
52   The [ApiController] attribute tells ASP.NET Core that the controller is used for Web API 
purposes.
53   
54   Benefits:
55   
56   a. Automatic Model Validation
57   b. Automatic 400 Bad Request response
58   c. Attribute Routing enforced
59   d. Binding source inference (from body, route, query)
60   
61   Example:
62   
63   [ApiController]
64   [Route("api/[controller]")]
65   public class OrdersController : ControllerBase
66   {
67       [HttpPost]
68       public IActionResult CreateOrder(Order order)
69       {
70           // ModelState automatically validated
71           return Ok();
72       }
73   }
74   
75   Note: Without [ApiController], you would need to manually check ModelState.IsValid.
76   
77   
78   
79   Q4. What is routing in ASP.NET Core Web API?
80   
81   Answer:
82   Routing is the mechanism by which incoming HTTP requests are matched to actions in 
controllers.
83   
84   Attribute Routing Example:
85   
86   [Route("api/products")]
87   public class ProductsController : ControllerBase
88   {
89       [HttpGet("{id}")]
90       public IActionResult GetProductById(int id)
91       {
92           // Fetch product
93           return Ok();
94       }
95   }
96   
97   Note: URL like api/products/5 would automatically map to the GetProductById action.
98   
99   
100   
101   Q5. How do you return different HTTP Status Codes from a Controller?
102   
103   Answer:
104   Use built-in helper methods like Ok(), BadRequest(), NotFound(), Created(), etc.
105   
106   Example:
107   
108   [HttpGet("{id}")]
109   public IActionResult GetProduct(int id)
110   {
111       var product = repository.Get(id);
112       if (product == null)
113           return NotFound();
114   
115       return Ok(product);
116   }
117   
118   Note: This ensures the client gets correct status codes (like 200, 404, etc.).
119   
120   
121   
122   
123   Q6. What is Dependency Injection (DI) and how is it used in Web API?
124   
125   Answer:
126   Dependency Injection is a design pattern where dependencies (services) are injected into 
a class instead of the class creating them.
127   
128   Register service in Program.cs:
129   builder.Services.AddScoped<IProductService, ProductService>();
130   
131   Use constructor injection:
132   private readonly IProductService _service;
133   public ProductsController(IProductService service)
134   {
135       _service = service;
136   }
137   
138   Note: This makes your code loosely coupled, testable, and maintainable.
139   
140   
141   
142   
143   
144   Q7. How do you return JSON from an API method?
145   
146   Answer:
147   By default, ASP.NET Core Web API serializes your responses into JSON.
148   
149   Example:
150   
151   [HttpGet]
152   public IActionResult Get()
153   {
154       var user = new { Name = "Karthik", Age = 30 };
155       return Ok(user);
156   }
157   
158   Note: No need for manual JSON serialization — it uses System.Text.Json (or 
Newtonsoft.Json optionally).
159   
160   
161   
162   
163   Q8. What is Model Binding in Web API?
164   
165   Answer:
166   Model Binding maps incoming HTTP request data (route data, query string, body) into C# 
action parameters.
167   
168   Example:
169   
170   [HttpPost]
171   public IActionResult CreateProduct([FromBody] Product product)
172   {
173       // product object populated automatically from JSON body
174   }
175   
176   Binding Sources:
177   
178   a. [FromRoute]
179   b. [FromQuery]
180   c. [FromBody]
181   d. [FromForm]
182   e. [FromHeader]
183   
184   
185   
186   
187   Q9. What is the difference between IActionResult and ActionResult<T>?
188   
189   Answer:
190   
191   
192   IActionResult ActionResult<T>
193   ==================================================================================
194   Can return any type of response Returns a specific type along with HTTP status
195   Less type-safe Type-safe
196   
197   Example:
198   
199   public IActionResult GetProduct(int id)
200   
201   vs
202   
203   public ActionResult<Product> GetProduct(int id)
204   
205   Note: Using ActionResult<Product> allows you to return either a Product (200 OK) or 
other error codes cleanly.
206   
207   
208   
209   Q10. How do you validate incoming request data in Web API?
210   
211   Answer:
212   
213   a. Use Data Annotations in Models (like [Required], [MaxLength], [Range]).
214   b. Use [ApiController] attribute to auto-check ModelState.
215   c. Handle invalid data gracefully.
216   
217   Model:
218   
219   public class Product
220   {
221       [Required]
222       public string Name { get; set; }
223   
224       [Range(1, 10000)]
225       public decimal Price { get; set; }
226   }
227   
228   Controller:
229   
230   [HttpPost]
231   public IActionResult Create(Product product)
232   {
233       if (!ModelState.IsValid)
234           return BadRequest(ModelState);
235   
236       return Ok();
237   }
238   
239   Note: In most cases, with [ApiController], you don't need to write ModelState.IsValid 
manually — it auto returns 400!
240   
241   
242   Q11. How do you secure a Web API using JWT (JSON Web Token)?
243   
244   Answer:
245   
246   1. Install NuGet package:
247   Microsoft.AspNetCore.Authentication.JwtBearer
248   
249   2. Configure authentication in Program.cs:
250   builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
251       .AddJwtBearer(options =>
252       {
253           options.TokenValidationParameters = new TokenValidationParameters
254           {
255               ValidateIssuer = true,
256               ValidateAudience = true,
257               ValidateLifetime = true,
258               IssuerSigningKey = new 
SymmetricSecurityKey(Encoding.UTF8.GetBytes("YourSecretKey"))
259           };
260       });
261   
262   3. Protect API endpoints:
263   
264   [Authorize]
265   [HttpGet]
266   public IActionResult GetSecretData()
267   {
268       return Ok("This is protected");
269   }
270   
271   Note: The client must pass a valid JWT token in the Authorization header.
272   
273   
274   
275   
276   
277   Q12. How can you enable CORS in Web API?
278   
279   Answer:
280   CORS (Cross-Origin Resource Sharing) allows your Web API to be accessed from different 
domains.
281   
282   Register CORS in Program.cs:
283   
284   builder.Services.AddCors(options =>
285   {
286       options.AddPolicy("AllowAll", builder =>
287       {
288           builder.AllowAnyOrigin()
289               .AllowAnyMethod()
290               .AllowAnyHeader();
291       });
292   });
293   
294   Add it to the HTTP pipeline:
295   app.UseCors("AllowAll");
296   
297   Now your API can accept requests from any domain.
298   Important: For production, restrict origins instead of AllowAnyOrigin().
299   
300   
301   
302   
303   Q13. How do you implement API Versioning in ASP.NET Core?
304   
305   Answer:
306   
307   Install package:
308   Microsoft.AspNetCore.Mvc.Versioning
309   
310   Configure it:
311   builder.Services.AddApiVersioning(options =>
312   {
313       options.AssumeDefaultVersionWhenUnspecified = true;
314       options.DefaultApiVersion = new ApiVersion(1, 0);
315       options.ReportApiVersions = true;
316   });
317   
318   Use attributes:
319   
320   [ApiVersion("1.0")]
321   [Route("api/v{version:apiVersion}/products")]
322   public class ProductsV1Controller : ControllerBase
323   
324   Now, you can manage multiple versions of your APIs cleanly.
325   
326   
327   
328   
329   
330   Q14. What is IActionFilter and how to create a custom one?
331   
332   Answer:
333   Action Filters run before and after an action method executes.
334   
335   Custom filter:
336   public class LogActionFilter : IActionFilter
337   {
338       public void OnActionExecuting(ActionExecutingContext context)
339       {
340           Console.WriteLine("Action Starting: " + context.ActionDescriptor.DisplayName);
341       }
342   
343       public void OnActionExecuted(ActionExecutedContext context)
344       {
345           Console.WriteLine("Action Ended: " + context.ActionDescriptor.DisplayName);
346       }
347   }
348   
349   Apply it:
350   [ServiceFilter(typeof(LogActionFilter))]
351   public class ProductsController : ControllerBase
352   
353   Or globally in Program.cs.
354   
355   
356   
357   
358   
359   Q15. How do you return custom error responses in Web API?
360   
361   Answer:
362   You can use ProblemDetails:
363   return Problem(detail: "Invalid Request", statusCode: 400);
364   
365   Or create a custom response:
366   return BadRequest(new { ErrorCode = 1001, ErrorMessage = "Product not found" });
367   
368   Note: Customizing error responses improves client debugging and UX.
369   
370   
371   
372   
373   
374   Q16. What is the difference between FromBody and FromQuery?
375   
376   Answer:
377   
378   
379   Attribute Purpose
380   ================================================
381   [FromBody] Bind data from HTTP body (JSON)
382   [FromQuery] Bind data from URL query string
383   
384   
385   Example:
386   
387   [HttpPost]
388   public IActionResult CreateProduct([FromBody] Product product)
389   
390   [HttpGet]
391   public IActionResult GetProduct([FromQuery] int id)
392   
393   
394   
395   
396   
397   Q17. How can you log information in ASP.NET Core Web API?
398   
399   Answer:
400   Use built-in ILogger<T> service.
401   
402   Inject logger:
403   private readonly ILogger<ProductsController> _logger;
404   public ProductsController(ILogger<ProductsController> logger)
405   {
406       _logger = logger;
407   }
408   
409   Use it:
410   _logger.LogInformation("Fetching all products");
411   
412   Note: Logging supports multiple sinks like Console, File, Azure Monitor, etc.
413   
414   
415   
416   
417   Q18. How do you implement file upload in Web API?
418   
419   Answer:
420   Accept files as IFormFile.
421   
422   Controller:
423   
424   [HttpPost("upload")]
425   public async Task<IActionResult> UploadFile(IFormFile file)
426   {
427       if (file == null || file.Length == 0)
428           return BadRequest("No file selected");
429   
430       var path = Path.Combine("uploads", file.FileName);
431   
432       using (var stream = new FileStream(path, FileMode.Create))
433       {
434           await file.CopyToAsync(stream);
435       }
436   
437       return Ok("Uploaded Successfully");
438   }
439   
440   Important: Ensure you configure large request body size if needed.
441   
442   
443   
444   
445   Q19. How do you enable Swagger (OpenAPI) in Web API?
446   
447   Answer:
448   
449   Install package:
450   Swashbuckle.AspNetCore
451   
452   Configure in Program.cs:
453   builder.Services.AddEndpointsApiExplorer();
454   builder.Services.AddSwaggerGen();
455   
456   Add middleware:
457   app.UseSwagger();
458   app.UseSwaggerUI();
459   
460   Note: Run the app and open /swagger endpoint to see your API documentation 
auto-generated!
461   
462   
463   
464   
465   
466   Q20. What is the difference between 204 No Content and 200 OK?
467   
468   Answer:
469   
470   Status Code Meaning
471   200 OK Success, with content in response body
472   204 No Content Success, but no content returned
473   
474   Example:
475   
476   return Ok(product); → Returns 200 OK with product data.
477   return NoContent(); → Returns 204 No Content (useful after Delete operations).
478   
479   
480   
481   
482   
483   Q21. How do you implement global exception handling in ASP.NET Core Web API?
484   
485   Answer:
486   Use a custom middleware to catch unhandled exceptions.
487   
488   Example:
489   
490   public class ExceptionMiddleware
491   {
492       private readonly RequestDelegate _next;
493       private readonly ILogger<ExceptionMiddleware> _logger;
494   
495       public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
496       {
497           _next = next;
498           _logger = logger;
499       }
500   
501       public async Task InvokeAsync(HttpContext context)
502       {
503           try
504           {
505               await _next(context);
506           }
507           catch (Exception ex)
508           {
509               _logger.LogError(ex, "Unhandled Exception");
510               context.Response.StatusCode = 500;
511               await context.Response.WriteAsync("Internal Server Error");
512           }
513       }
514   }
515   
516   Register it:
517   app.UseMiddleware<ExceptionMiddleware>();
518   
519   Note: This way, your entire API has centralized error handling!
520   
521   
522   
523   
524   
525   Q22. What is the use of [FromRoute], [FromQuery], [FromBody] attributes?
526   
527   Answer:
528   These attributes tell ASP.NET Core explicitly where to bind the parameter data from.
529   
530   Examples:
531   
532   [HttpGet("{id}")]
533   public IActionResult GetProduct([FromRoute] int id)
534   
535   [HttpGet("search")]
536   public IActionResult SearchProduct([FromQuery] string name)
537   
538   [HttpPost]
539   public IActionResult AddProduct([FromBody] Product product)
540   
541   Note: It improves clarity and prevents ambiguous binding.
542   
543   
544   
545   
546   Q23. How do you perform Dependency Injection for multiple services of the same interface?
547   
548   Answer:
549   You can inject IEnumerable<T> to get all registered services.
550   
551   Example:
552   
553   builder.Services.AddTransient<INotificationService, EmailService>();
554   builder.Services.AddTransient<INotificationService, SmsService>();
555   
556   Inject:
557   
558   public class NotificationManager
559   {
560       private readonly IEnumerable<INotificationService> _services;
561   
562       public NotificationManager(IEnumerable<INotificationService> services)
563       {
564           _services = services;
565       }
566   }
567   
568   Note: You can then iterate through services to call methods.
569   
570   
571   
572   
573   Q24. How can you restrict Web API to only HTTPS requests?
574   
575   Answer:
576   Force HTTPS redirection:
577   
578   builder.Services.AddHttpsRedirection(options =>
579   {
580       options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
581       options.HttpsPort = 5001;
582   });
583   
584   Add middleware:
585   app.UseHttpsRedirection();
586   
587   Note: Now your API will reject any HTTP calls and enforce HTTPS!
588   
589   
590   
591   
592   Q25. What is ModelState and when should you use it manually?
593   
594   Answer:
595   ModelState contains the state of the model binding and validation process.
596   
597   Normally with [ApiController], model validation errors are automatically handled.
598   If you are not using [ApiController], you must manually check:
599   
600   if (!ModelState.IsValid)
601   {
602       return BadRequest(ModelState);
603   }
604   
605   Note: ModelState ensures only valid data enters your business logic.
606   
607   
608   
609   
610   
611   Q26. How do you implement Rate Limiting in ASP.NET Core Web API?
612   
613   Answer:
614   Use third-party libraries like AspNetCoreRateLimit.
615   
616   Example basic rule:
617   Max 100 requests per 1 minute per client.
618   
619   You configure it in appsettings.json and register services like:
620   builder.Services.AddMemoryCache();
621   builder.Services.Configure<IpRateLimitOptions>(Configuration.GetSection("IpRateLimiting")
);
622   builder.Services.AddInMemoryRateLimiting();
623   builder.Services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
624   
625   Note: Protects your API from abuse.
626   
627   
628   
629   
630   Q27. What is Content Negotiation in ASP.NET Core Web API?
631   
632   Answer:
633   Content negotiation means the server selects the best format (JSON, XML, etc.) based on 
what client accepts.
634   
635   Example:
636   
637   Request Header: Accept: application/xml
638   
639   ASP.NET Core Web API will respond with XML if XML formatter is added:
640   builder.Services.AddControllers().AddXmlSerializerFormatters();
641   
642   Note: Otherwise, JSON is the default.
643   
644   
645   
646   Q28. How do you implement soft delete in Web API?
647   
648   Answer:
649   Soft delete means marking the record as deleted without physically removing it.
650   
651   Entity:
652   
653   public class Product
654   {
655       public int Id { get; set; }
656       public string Name { get; set; }
657       public bool IsDeleted { get; set; }
658   }
659   
660   Instead of deleting:
661   product.IsDeleted = true;
662   dbContext.SaveChanges();
663   
664   Query only non-deleted records:
665   dbContext.Products.Where(p => !p.IsDeleted);
666   
667   
668   
669   
670   Q29. How can you handle large file uploads efficiently in Web API?
671   
672   Answer:
673   
674   Increase limits:
675   builder.Services.Configure<FormOptions>(options =>
676   {
677       options.MultipartBodyLengthLimit = 209715200; // 200 MB
678   });
679   
680   Use streaming:
681   Instead of loading into memory, read stream directly.
682   
683   using var stream = file.OpenReadStream();
684   using var destination = File.Create(path);
685   await stream.CopyToAsync(destination);
686   
687   Note: This avoids memory overflow for large files.
688   
689   
690   
691   
692   Q30. How do you inject configuration settings into Controllers?
693   
694   Answer:
695   Inject IConfiguration.
696   
697   Example:
698   
699   private readonly IConfiguration _config;
700   public ProductsController(IConfiguration config)
701   {
702       _config = config;
703   }
704   
705   Usage:
706   var connectionString = _config.GetConnectionString("DefaultConnection");
707   
708   Note: You can access appsettings.json or environment variables easily!
709   
710   
711   
712   
713   Q31. How do you send custom headers from a Web API response?
714   
715   Answer:
716   You can add custom headers to the HTTP response like this:
717   
718   [HttpGet]
719   public IActionResult GetProduct()
720   {
721       Response.Headers.Add("X-Custom-Header", "KarthikAPI");
722       return Ok(new { Message = "Success" });
723   }
724   
725   Note: Useful for sending metadata, version info, correlation IDs, etc.
726   
727   
728   
729   
730   
731   Q32. How can you consume a Web API using HttpClient in .NET?
732   
733   Answer:
734   Example client:
735   
736   var client = new HttpClient();
737   var response = await client.GetAsync("https://localhost:5001/api/products");
738   if (response.IsSuccessStatusCode)
739   {
740       var content = await response.Content.ReadAsStringAsync();
741       Console.WriteLine(content);
742   }
743   
744   Note: HttpClient is the standard way to call external APIs from your code.
745   
746   
747   
748   
749   
750   Q33. What is middleware in ASP.NET Core?
751   
752   Answer:
753   Middleware is software that's assembled into an app pipeline to handle requests and 
responses.
754   
755   Example custom middleware:
756   public class HelloMiddleware
757   {
758       private readonly RequestDelegate _next;
759   
760       public HelloMiddleware(RequestDelegate next)
761       {
762           _next = next;
763       }
764   
765       public async Task InvokeAsync(HttpContext context)
766       {
767           await context.Response.WriteAsync("Hello from Middleware! ");
768           await _next(context);
769       }
770   }
771   
772   Register it:
773   app.UseMiddleware<HelloMiddleware>();
774   
775   
776   
777   
778   Q34. What are the different return types supported by Web API methods?
779   
780   Answer:
781   Common return types:
782   
783   a. IActionResult
784   b. ActionResult<T>
785   c. Task<IActionResult>
786   d. Task<ActionResult<T>>
787   e. Direct object (e.g., Product)
788   f. HttpResponse (advanced)
789   
790   Example:
791   public ActionResult<Product> Get(int id)
792   
793   Asynchronous:
794   public async Task<ActionResult<Product>> GetAsync(int id)
795   
796   
797   
798   
799   Q35. What is the difference between synchronous and asynchronous Web API methods?
800   
801   Answer:
802   
803   
804   Synchronous Asynchronous
805   =====================================================================
806   Blocks the thread Frees the thread
807   Less scalable under load Highly scalable
808   Good for quick operations Best for I/O, DB calls, file access
809   
810   Example async method:
811   
812   [HttpGet]
813   public async Task<IActionResult> GetProducts()
814   {
815       var products = await _service.GetAllAsync();
816       return Ok(products);
817   }
818   
819   Note: Async/await should be preferred in production Web APIs!
820   
821   
822   
823   
824   
825   
826   Q36. How do you unit test a Web API Controller?
827   
828   Answer:
829   Use Mocking frameworks like Moq + Xunit.
830   
831   Example basic unit test:
832   
833   var mockService = new Mock<IProductService>();
834   mockService.Setup(x => x.GetAll()).Returns(new List<Product> { new Product { Id = 1, 
Name = "Sample" } });
835   
836   var controller = new ProductsController(mockService.Object);
837   var result = controller.GetAll();
838   
839   Assert.IsType<OkObjectResult>(result);
840   
841   Note: Always mock dependencies and test controller logic independently.
842   
843   
844   
845   
846   
847   Q37. How do you use Token-based Authentication in Web API?
848   
849   Answer:
850   Generate JWT Token after login:
851   
852   var tokenHandler = new JwtSecurityTokenHandler();
853   var key = Encoding.ASCII.GetBytes("YourSecretKey");
854   var tokenDescriptor = new SecurityTokenDescriptor
855   {
856       Subject = new ClaimsIdentity(new Claim[]
857       {
858           new Claim(ClaimTypes.Name, user.Id.ToString())
859       }),
860       Expires = DateTime.UtcNow.AddHours(1),
861       SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), 
SecurityAlgorithms.HmacSha256Signature)
862   };
863   var token = tokenHandler.CreateToken(tokenDescriptor);
864   return tokenHandler.WriteToken(token);
865   
866   Note: Clients must pass this token in the Authorization: Bearer <token> header for 
secured API calls.
867   
868   
869   
870   
871   
872   
873   Q38. What is Kestrel in ASP.NET Core?
874   
875   Answer:
876   Kestrel is the built-in cross-platform web server for ASP.NET Core applications.
877   
878   Features:
879   a. Lightweight, high-performance
880   b. Used as an edge server or behind reverse proxy (e.g., IIS, Nginx)
881   c. Can handle both HTTP/1.x and HTTP/2
882   
883   Note: ASP.NET Core apps always run inside Kestrel, whether self-hosted or behind a proxy.
884   
885   
886   
887   
888   
889   Q39. What is the difference between AddSingleton, AddScoped, and AddTransient services?
890   
891   Answer:
892   
893   
894   Lifetime Scope Usage
895   =====================================================================================
896   Singleton One instance for entire app Configurations, stateless services
897   Scoped One instance per HTTP request Database contexts
898   Transient New instance every time requested Lightweight services
899   
900   
901   Example:
902   
903   builder.Services.AddSingleton<IMyService, MyService>();
904   builder.Services.AddScoped<IMyDbContext, MyDbContext>();
905   builder.Services.AddTransient<ILogicHelper, LogicHelper>();
906   
907   Note: Choosing the right lifetime impacts memory and performance.
908   
909   
910   
911   
912   Q40. How do you use Swagger to test secured APIs (with JWT Token)?
913   
914   Answer:
915   
916   Add security definition in Program.cs:
917   
918   builder.Services.AddSwaggerGen(c =>
919   {
920       c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
921       {
922           In = ParameterLocation.Header,
923           Description = "Please enter JWT with Bearer into field",
924           Name = "Authorization",
925           Type = SecuritySchemeType.ApiKey
926       });
927   
928       c.AddSecurityRequirement(new OpenApiSecurityRequirement
929       {
930           {
931               new OpenApiSecurityScheme
932               {
933                   Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, 
Id = "Bearer" }
934               },
935               new string[] { }
936           }
937       });
938   });
939   
940   Note: Now, Swagger UI will show an Authorize button to paste the token. It Helps easily 
test secured endpoints during development!
941   
942   
943   
944   
945   
946   
947   Q41. What are Route Constraints in Web API and how do you use them?
948   
949   Answer:
950   Route constraints restrict the format of parameters.
951   
952   Example:
953   
954   [HttpGet("product/{id:int}")]
955   public IActionResult GetProduct(int id)
956   {
957       return Ok(id);
958   }
959   
960   Other constraints: string, bool, datetime, guid, minlength, maxlength, etc.
961   
962   Note: Helps validate route data before reaching the action method!
963   
964   
965   
966   
967   Q42. What is the difference between UseAuthorization and UseAuthentication middleware?
968   
969   Answer:
970   
971   Middleware Purpose
972   UseAuthentication Validates token or credentials
973   UseAuthorization Checks user permissions after authentication
974   
975   Order matters:
976   app.UseAuthentication();
977   app.UseAuthorization();
978   
979   Note: Without proper order, authorization might fail unexpectedly.
980   
981   
982   
983   
984   Q43. How do you create a custom authorization policy in ASP.NET Core?
985   
986   Answer:
987   
988   Define policy in Program.cs:
989   builder.Services.AddAuthorization(options =>
990   {
991       options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
992   });
993   
994   Protect action:
995   [Authorize(Policy = "AdminOnly")]
996   [HttpGet("admin-data")]
997   public IActionResult GetAdminData()
998   {
999       return Ok("Secret Data");
1000   }
1001   
1002   Note: You can create powerful fine-grained security controls using policies.
1003   
1004   
1005   
1006   
1007   Q44. What are Minimal APIs introduced in .NET 6 and .NET 7?
1008   
1009   Answer:
1010   Minimal APIs allow creating Web APIs without Controllers.
1011   
1012   Example:
1013   
1014   var builder = WebApplication.CreateBuilder(args);
1015   var app = builder.Build();
1016   
1017   app.MapGet("/hello", () => "Hello World!");
1018   app.Run();
1019   
1020   Note: Great for small, lightweight APIs and microservices.
1021   
1022   
1023   
1024   
1025   Q45. How do you bind complex types from the URL in Web API?
1026   
1027   Answer:
1028   Bind from query parameters:
1029   
1030   [HttpGet]
1031   public IActionResult Search([FromQuery] ProductFilter filter)
1032   
1033   Where ProductFilter is:
1034   
1035   public class ProductFilter
1036   {
1037       public string Name { get; set; }
1038       public int? CategoryId { get; set; }
1039   }
1040   
1041   Note: Supports advanced filtering, sorting, and searching via query strings.
1042   
1043   
1044   
1045   
1046   Q46. How can you handle circular references in Web API responses (like in EF Core)?
1047   
1048   Answer:
1049   Configure JSON options to ignore cycles:
1050   
1051   builder.Services.AddControllers().AddJsonOptions(x =>
1052   {
1053       x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
1054   });
1055   
1056   Note: Prevents serialization errors like Self referencing loop detected when returning 
entity models.
1057   
1058   
1059   
1060   
1061   Q47. What are Filters in ASP.NET Core Web API?
1062   
1063   Answer:
1064   Filters allow you to run code before or after key pipeline stages.
1065   
1066   Types:
1067   
1068   a. Authorization filters
1069   b. Resource filters
1070   c. Action filters
1071   d. Exception filters
1072   e. Result filters
1073   
1074   Example Action Filter:
1075   
1076   public class LogFilter : ActionFilterAttribute
1077   {
1078       public override void OnActionExecuting(ActionExecutingContext context)
1079       {
1080           Console.WriteLine("Action is starting...");
1081       }
1082   }
1083   
1084   Apply:
1085   
1086   [ServiceFilter(typeof(LogFilter))]
1087   
1088   
1089   
1090   
1091   Q48. How do you configure multiple environments (Development, Staging, Production) in 
ASP.NET Core?
1092   
1093   Answer:
1094   Use launchSettings.json or set ASPNETCORE_ENVIRONMENT variable.
1095   
1096   Access inside code:
1097   
1098   if (env.IsDevelopment())
1099   {
1100       // Enable detailed error page
1101   }
1102   else
1103   {
1104       // Generic error page
1105   }
1106   
1107   You can inject IWebHostEnvironment anywhere:
1108   
1109   private readonly IWebHostEnvironment _env;
1110   public HomeController(IWebHostEnvironment env)
1111   {
1112       _env = env;
1113   }
1114   
1115   Note: Enables environment-specific behavior easily.
1116   
1117   
1118   
1119   
1120   Q49. How do you send validation error responses in a standard format?
1121   
1122   Answer:
1123   Custom middleware:
1124   
1125   public class ValidationExceptionMiddleware
1126   {
1127       private readonly RequestDelegate _next;
1128   
1129       public ValidationExceptionMiddleware(RequestDelegate next)
1130       {
1131           _next = next;
1132       }
1133   
1134       public async Task InvokeAsync(HttpContext context)
1135       {
1136           try
1137           {
1138               await _next(context);
1139           }
1140           catch (ValidationException ex)
1141           {
1142               context.Response.StatusCode = 400;
1143               await context.Response.WriteAsJsonAsync(new { Error = ex.Message });
1144           }
1145       }
1146   }
1147   
1148   Note: Makes client-side error handling much easier.
1149   
1150   
1151   
1152   
1153   
1154   
1155   Q50. What is a DTO and why should you use it in Web APIs?
1156   
1157   Answer:
1158   DTO = Data Transfer Object
1159   
1160   Use DTOs to:
1161   
1162   Hide internal domain models
1163   
1164   Avoid exposing sensitive data
1165   
1166   Customize API response shape
1167   
1168   Improve performance
1169   
1170   Example DTO:
1171   
1172   public class ProductDto
1173   {
1174       public string Name { get; set; }
1175       public decimal Price { get; set; }
1176   }
1177   
1178   Controller:
1179   
1180   [HttpGet("{id}")]
1181   public ActionResult<ProductDto> Get(int id)
1182   {
1183       var product = _context.Products.Find(id);
1184       if (product == null) return NotFound();
1185   
1186       return new ProductDto
1187       {
1188           Name = product.Name,
1189           Price = product.Price
1190       };
1191   }
1192   
1193   Note: DTOs are a best practice for secure, clean, and future-proof Web APIs.
1194   
1195   
1196   Q51. How do you return a file (like PDF, Excel) from an API?
1197   
1198   Answer:
1199   Use File() helper method:
1200   
1201   [HttpGet("download")]
1202   public IActionResult DownloadFile()
1203   {
1204       var bytes = System.IO.File.ReadAllBytes("files/sample.pdf");
1205       return File(bytes, "application/pdf", "downloaded_sample.pdf");
1206   }
1207   
1208   Note: Automatically sets the correct content type and download prompt.
1209   
1210   
1211   
1212   Q52. What is the purpose of ProducesResponseType attribute?
1213   
1214   Answer:
1215   Documents possible HTTP responses.
1216   
1217   Example:
1218   
1219   [HttpGet("{id}")]
1220   [ProducesResponseType(StatusCodes.Status200OK)]
1221   [ProducesResponseType(StatusCodes.Status404NotFound)]
1222   public IActionResult GetProduct(int id)
1223   {
1224       ...
1225   }
1226   
1227   Note: It helps tools like Swagger generate better API documentation.
1228   
1229   
1230   
1231   
1232   Q53. What is the difference between IHostedService and BackgroundService?
1233   
1234   Answer:
1235   
1236   
1237   Feature IHostedService BackgroundService
1238   =========================================================================================
==
1239   What it is Interface Abstract class
1240   Control You implement everything manually Gives a ready-to-override 
ExecuteAsync
1241   Use case Cron jobs, event listeners Long-running background tasks
1242   
1243   
1244   Example of BackgroundService:
1245   
1246   public class Worker : BackgroundService
1247   {
1248       protected override async Task ExecuteAsync(CancellationToken stoppingToken)
1249       {
1250           while (!stoppingToken.IsCancellationRequested)
1251           {
1252               Console.WriteLine("Running...");
1253               await Task.Delay(1000, stoppingToken);
1254           }
1255       }
1256   }
1257   
1258   
1259   
1260   Q54. What is the purpose of UseEndpoints middleware?
1261   
1262   Answer:
1263   It maps HTTP routes to corresponding handlers (Controllers, Razor Pages, etc).
1264   
1265   Example:
1266   
1267   app.UseRouting();
1268   app.UseAuthentication();
1269   app.UseAuthorization();
1270   app.UseEndpoints(endpoints =>
1271   {
1272       endpoints.MapControllers();
1273   });
1274   
1275   Note: Always needed to activate routing after authentication and authorization.
1276   
1277   
1278   
1279   
1280   Q55. How do you validate an incoming model manually without [ApiController]?
1281   
1282   Answer:
1283   You must check ModelState manually:
1284   
1285   [HttpPost]
1286   public IActionResult AddProduct(Product product)
1287   {
1288       if (!ModelState.IsValid)
1289           return BadRequest(ModelState);
1290   
1291       _context.Products.Add(product);
1292       _context.SaveChanges();
1293   
1294       return Ok();
1295   }
1296   
1297   Note:  With [ApiController], validation happens automatically.
1298   
1299   
1300   
1301   
1302   
1303   Q56. What is the purpose of IHttpContextAccessor?
1304   
1305   Answer:
1306   It allows you to access HttpContext outside of Controllers, for example inside Services.
1307   
1308   Inject and use:
1309   
1310   private readonly IHttpContextAccessor _httpContextAccessor;
1311   public MyService(IHttpContextAccessor httpContextAccessor)
1312   {
1313       _httpContextAccessor = httpContextAccessor;
1314   }
1315   
1316   var userId = 
_httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
1317   
1318   Note: Useful for accessing user claims, headers, session, etc., in deep layers.
1319   
1320   
1321   
1322   
1323   
1324   Q57. How do you customize model validation error messages?
1325   
1326   Answer:
1327   Using Data Annotations:
1328   
1329   public class Product
1330   {
1331       [Required(ErrorMessage = "Product name is mandatory")]
1332       public string Name { get; set; }
1333   
1334       [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
1335       public decimal Price { get; set; }
1336   }
1337   
1338   Note: Custom error messages make APIs much more user-friendly.
1339   
1340   
1341   
1342   
1343   Q58. How do you create an API that returns pagination results?
1344   
1345   Answer:
1346   Standard pagination:
1347   
1348   [HttpGet]
1349   public IActionResult GetProducts(int page = 1, int pageSize = 10)
1350   {
1351       var skip = (page - 1) * pageSize;
1352       var products = _context.Products.Skip(skip).Take(pageSize).ToList();
1353       return Ok(products);
1354   }
1355   
1356   Note: Always return total count and current page info in real APIs!
1357   
1358   
1359   
1360   
1361   
1362   Q59. How do you implement Caching in ASP.NET Core Web API?
1363   
1364   Answer:
1365   
1366   1. Response Caching:
1367   
1368   Add middleware:
1369   app.UseResponseCaching();
1370   
1371   Controller:
1372   
1373   [HttpGet]
1374   [ResponseCache(Duration = 60)]
1375   public IActionResult GetProducts()
1376   {
1377       return Ok(_service.GetProducts());
1378   }
1379   
1380   Note: Caches full HTTP response.
1381   
1382   2. Memory Caching:
1383   
1384   Register service:
1385   builder.Services.AddMemoryCache();
1386   
1387   Use:
1388   private readonly IMemoryCache _cache;
1389   public MyService(IMemoryCache cache)
1390   {
1391       _cache = cache;
1392   }
1393   
1394   _cache.Set("key", value, TimeSpan.FromMinutes(10));
1395   
1396   
1397   
1398   
1399   Q60. What is the default maximum request body size in ASP.NET Core?
1400   
1401   Answer:
1402   
1403   Default maximum size = 30 MB (for Kestrel).
1404   
1405   For IIS, it’s controlled by maxRequestLength and maxAllowedContentLength.
1406   
1407   You can increase it in Kestrel:
1408   
1409   builder.WebHost.ConfigureKestrel(serverOptions =>
1410   {
1411       serverOptions.Limits.MaxRequestBodySize = 104857600; // 100 MB
1412   });
1413   
1414   Note:  Important when uploading files, images, large JSON payloads.
1415   
1416   
1417   
1418   
1419   Q61. How do you implement Global Exception Handling in Web API?
1420   
1421   Answer:
1422   Use a custom middleware:
1423   
1424   public class ExceptionMiddleware
1425   {
1426       private readonly RequestDelegate _next;
1427   
1428       public ExceptionMiddleware(RequestDelegate next)
1429       {
1430           _next = next;
1431       }
1432   
1433       public async Task InvokeAsync(HttpContext context)
1434       {
1435           try
1436           {
1437               await _next(context);
1438           }
1439           catch (Exception ex)
1440           {
1441               context.Response.StatusCode = 500;
1442               await context.Response.WriteAsJsonAsync(new { Error = ex.Message });
1443           }
1444       }
1445   }
1446   
1447   Register it:
1448   app.UseMiddleware<ExceptionMiddleware>();
1449   
1450   Note:  Centralizes error handling for your entire API.
1451   
1452   
1453   
1454   
1455   Q62. How can you upload files using ASP.NET Core Web API?
1456   
1457   Answer:
1458   Controller method:
1459   
1460   [HttpPost("upload")]
1461   public async Task<IActionResult> UploadFile(IFormFile file)
1462   {
1463       if (file == null || file.Length == 0)
1464           return BadRequest("No file selected");
1465   
1466       var path = Path.Combine("uploads", file.FileName);
1467   
1468       using (var stream = new FileStream(path, FileMode.Create))
1469       {
1470           await file.CopyToAsync(stream);
1471       }
1472   
1473       return Ok("File uploaded successfully");
1474   }
1475   
1476   Note: Don't forget to increase MaxRequestBodySize if needed!
1477   
1478   
1479   
1480   
1481   
1482   Q63. How can you implement Soft Delete in a Web API with Entity Framework Core?
1483   
1484   Answer:
1485   Entity:
1486   
1487   public class Product
1488   {
1489       public int Id { get; set; }
1490       public string Name { get; set; }
1491       public bool IsDeleted { get; set; }
1492   }
1493   
1494   Soft delete method:
1495   
1496   public IActionResult Delete(int id)
1497   {
1498       var product = _context.Products.Find(id);
1499       if (product == null) return NotFound();
1500   
1501       product.IsDeleted = true;
1502       _context.SaveChanges();
1503   
1504       return NoContent();
1505   }
1506   
1507   Note: This way, you don’t physically remove records — good for audit trails!
1508   
1509   
1510   
1511   
1512   
1513   
1514   Q64. What is the difference between FromQuery, FromBody, and FromRoute attributes?
1515   
1516   Answer:
1517   
1518   
1519   Attribute Source of data
1520   =================================
1521   [FromQuery] URL query parameters
1522   [FromBody] HTTP request body
1523   [FromRoute] URL route parameters
1524   
1525   Example:
1526   
1527   [HttpPost("product/{id}")]
1528   public IActionResult UpdateProduct([FromRoute] int id, [FromBody] Product product, 
[FromQuery] string source)
1529   
1530   Note: Understanding these helps handle multi-source data correctly!
1531   
1532   
1533   
1534   
1535   
1536   
1537   Q65. How can you return a 201 Created response with a location header?
1538   
1539   Answer:
1540   Use CreatedAtAction().
1541   
1542   Example:
1543   
1544   [HttpPost]
1545   public IActionResult Create(Product product)
1546   {
1547       _context.Products.Add(product);
1548       _context.SaveChanges();
1549   
1550       return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
1551   }
1552   
1553   Note: Correct way to indicate resource creation according to REST standards!
1554   
1555   
1556   
1557   
1558   
1559   Q66. What is the purpose of [BindProperty] attribute in ASP.NET Core?
1560   
1561   Answer:
1562   Primarily used in Razor Pages but can apply to APIs too.
1563   
1564   It binds request values automatically:
1565   
1566   [BindProperty]
1567   public Product Product { get; set; }
1568   
1569   In Razor Pages:
1570   
1571   public async Task<IActionResult> OnPostAsync()
1572   {
1573       _context.Products.Add(Product);
1574       await _context.SaveChangesAsync();
1575       return RedirectToPage("./Index");
1576   }
1577   
1578   Note: Simplifies data binding in page models.
1579   
1580   
1581   
1582   
1583   
1584   
1585   Q67. What are Action Results and Non-Action Results in Web API?
1586   
1587   Answer:
1588   
1589   Action Results: Returns HTTP-specific responses (e.g., Ok(), NotFound(), BadRequest()).
1590   Non-Action Results: Directly return object without wrapping (e.g., string, int).
1591   
1592   Examples:
1593   
1594   Action Result:
1595   public ActionResult<Product> Get(int id)
1596   
1597   Non-Action Result:
1598   public Product GetProduct(int id)
1599   
1600   Note: Action Results are more flexible and recommended for APIs!
1601   
1602   
1603   
1604   
1605   
1606   Q68. How do you expose multiple versions of a Web API?
1607   
1608   Answer:
1609   Use API versioning.
1610   
1611   Install package:
1612   
1613   Microsoft.AspNetCore.Mvc.Versioning
1614   
1615   Setup:
1616   
1617   builder.Services.AddApiVersioning(options =>
1618   {
1619       options.AssumeDefaultVersionWhenUnspecified = true;
1620       options.DefaultApiVersion = new ApiVersion(1, 0);
1621       options.ReportApiVersions = true;
1622   });
1623   
1624   Controller:
1625   
1626   [ApiVersion("1.0")]
1627   [Route("api/v{version:apiVersion}/[controller]")]
1628   
1629   Note: Supports version via URL, query string, headers!
1630   
1631   
1632   
1633   
1634   
1635   Q69. How can you enable CORS (Cross-Origin Resource Sharing) globally?
1636   
1637   Answer:
1638   
1639   1. Configure CORS:
1640   
1641   builder.Services.AddCors(options =>
1642   {
1643       options.AddPolicy("AllowAll", builder =>
1644       {
1645           builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
1646       });
1647   });
1648   
1649   2. Apply:
1650   app.UseCors("AllowAll");
1651   
1652   Note: CORS is mandatory when APIs are called from different domains.
1653   
1654   
1655   
1656   Q70. How do you pass complex objects in query strings safely?
1657   
1658   Answer:
1659   Serialize the object to JSON, then URL encode it.
1660   
1661   Client-side:
1662   
1663   let obj = { name: "karthik", age: 25 };
1664   let queryString = encodeURIComponent(JSON.stringify(obj));
1665   fetch(/api/users?data=${queryString});
1666   
1667   Server-side:
1668   
1669   [HttpGet]
1670   public IActionResult GetUser([FromQuery] string data)
1671   {
1672       var user = JsonSerializer.Deserialize<User>(data);
1673       return Ok(user);
1674   }
1675   
1676   Note: Not best practice for very large objects — prefer POST with body instead!
1677   
1678   
1679   
1680   Q71. What is Dependency Injection in ASP.NET Core?
1681   
1682   Answer:
1683   Dependency Injection (DI) means giving an object what it needs (dependencies) instead of 
letting it create them.
1684   
1685   Example:
1686   
1687   public interface IMessageService
1688   {
1689       string GetMessage();
1690   }
1691   
1692   public class EmailService : IMessageService
1693   {
1694       public string GetMessage() => "Email sent!";
1695   }
1696   
1697   Controller:
1698   
1699   public class HomeController : ControllerBase
1700   {
1701       private readonly IMessageService _service;
1702   
1703       public HomeController(IMessageService service)
1704       {
1705           _service = service;
1706       }
1707   
1708       [HttpGet]
1709       public string Index() => _service.GetMessage();
1710   }
1711   
1712   Register service:
1713   builder.Services.AddScoped<IMessageService, EmailService>();
1714   
1715   Note: Promotes loose coupling and easy testing.
1716   
1717   
1718   
1719   
1720   Q72. What are the different lifetimes for services in ASP.NET Core?
1721   
1722   Answer:
1723   
1724   
1725   Lifetime Description
1726   =============================================
1727   Singleton One instance for the entire app
1728   Scoped One instance per request
1729   Transient New instance every time injected
1730   
1731   
1732   Examples:
1733   
1734   builder.Services.AddSingleton<MyService>();
1735   builder.Services.AddScoped<MyService>();
1736   builder.Services.AddTransient<MyService>();
1737   
1738   Note: Choose wisely — wrong lifetime can lead to bugs or memory leaks!
1739   
1740   
1741   
1742   
1743   
1744   Q73. How can you protect APIs with API Key Authentication?
1745   
1746   Answer:
1747   
1748   1. Create a Middleware:
1749   
1750   public class ApiKeyMiddleware
1751   {
1752       private readonly RequestDelegate _next;
1753       private const string APIKEY = "X-API-KEY";
1754   
1755       public ApiKeyMiddleware(RequestDelegate next)
1756       {
1757           _next = next;
1758       }
1759   
1760       public async Task Invoke(HttpContext context)
1761       {
1762           if (!context.Request.Headers.TryGetValue(APIKEY, out var extractedApiKey))
1763           {
1764               context.Response.StatusCode = 401;
1765               await context.Response.WriteAsync("API Key missing");
1766               return;
1767           }
1768   
1769           if (extractedApiKey != "MySuperSecretApiKey")
1770           {
1771               context.Response.StatusCode = 403;
1772               await context.Response.WriteAsync("Invalid API Key");
1773               return;
1774           }
1775   
1776           await _next(context);
1777       }
1778   }
1779   
1780   2. Register:
1781   app.UseMiddleware<ApiKeyMiddleware>();
1782   
1783   Note: Light-weight security mechanism for private APIs.
1784   
1785   
1786   
1787   
1788   
1789   Q74. How do you limit request rates (Throttling) in Web APIs?
1790   
1791   Answer:
1792   a. Use third-party middleware like:
1793   b. AspNetCoreRateLimit
1794   c. Custom Middleware
1795   
1796   Basic example:
1797   
1798   app.UseRateLimiter(new RateLimiterOptions
1799   {
1800       PermitLimit = 5,
1801       Window = TimeSpan.FromMinutes(1)
1802   });
1803   
1804   Note: Prevents abuse and protects server resources.
1805   
1806   
1807   
1808   
1809   
1810   Q75. What is Content Negotiation in ASP.NET Core Web API?
1811   
1812   Answer:
1813   It decides whether the client wants:
1814   
1815   a. JSON
1816   b. XML
1817   c. or some other format
1818   
1819   Example:
1820   If the client sends Accept: application/xml, Web API can automatically return XML.
1821   
1822   To enable XML:
1823   builder.Services.AddControllers().AddXmlSerializerFormatters();
1824   
1825   Note: Smart APIs support both JSON and XML based on client preferences.
1826   
1827   
1828   
1829   
1830   
1831   Q76. How do you send an email inside ASP.NET Core Web API?
1832   
1833   Answer:
1834   Using SmtpClient:
1835   
1836   var client = new SmtpClient("smtp.gmail.com")
1837   {
1838       Port = 587,
1839       Credentials = new NetworkCredential("yourEmail@gmail.com", "password"),
1840       EnableSsl = true,
1841   };
1842   
1843   await client.SendMailAsync("from@gmail.com", "to@gmail.com", "subject", "body");
1844   
1845   Note: For production, always use secured, environment-based configurations.
1846   
1847   
1848   
1849   
1850   
1851   Q77. How do you secure sensitive data like connection strings in ASP.NET Core?
1852   
1853   Answer:
1854   Use Secret Manager during development:
1855   
1856   dotnet user-secrets init
1857   dotnet user-secrets set "ConnectionStrings:Default" "Server=mydb..."
1858   
1859   Or Environment Variables in production.
1860   
1861   Note: Never hardcode sensitive data inside appsettings.json!
1862   
1863   
1864   
1865   
1866   
1867   Q78. How can you trigger code before the server shuts down?
1868   
1869   Answer:
1870   Implement IHostedService or use ApplicationLifetime events.
1871   
1872   Example:
1873   
1874   app.Lifetime.ApplicationStopping.Register(() =>
1875   {
1876       Console.WriteLine("Application is shutting down...");
1877   });
1878   
1879   Note: Useful for graceful shutdown tasks like closing connections.
1880   
1881   
1882   
1883   
1884   
1885   Q79. How do you bind nested complex objects from JSON?
1886   
1887   Answer:
1888   Model classes:
1889   
1890   public class Order
1891   {
1892       public int Id { get; set; }
1893       public Customer Customer { get; set; }
1894   }
1895   
1896   public class Customer
1897   {
1898       public string Name { get; set; }
1899       public string Email { get; set; }
1900   }
1901   
1902   POST JSON:
1903   
1904   {
1905     "id": 1,
1906     "customer": { "name": "Karthik", "email": "kar@example.com" }
1907   }
1908   
1909   Note: Web API automatically binds deeply nested structures!
1910   
1911   
1912   
1913   
1914   
1915   
1916   Q80. What are some common status codes returned by APIs and their meanings?
1917   
1918   Answer:
1919   
1920   
1921   StatusCode Meaning
1922   ======================================================================
1923   200 OK Request successful
1924   201 Created Resource created successfully
1925   400 Bad Request Client error
1926   401 Unauthorized Authentication needed
1927   403 Forbidden Access denied
1928   404 Not Found Resource not found
1929   500 Internal Server Error Server crash or unexpected error
1930   
1931   Note: Using proper status codes makes APIs professional and client-friendly.
1932   
1933   
1934   
1935   Q81. How do you use Middleware to modify request and response globally?
1936   
1937   Answer:
1938   Example of a simple custom Middleware:
1939   
1940   public class RequestResponseLoggingMiddleware
1941   {
1942       private readonly RequestDelegate _next;
1943   
1944       public RequestResponseLoggingMiddleware(RequestDelegate next)
1945       {
1946           _next = next;
1947       }
1948   
1949       public async Task Invoke(HttpContext context)
1950       {
1951           Console.WriteLine($"Request Path: {context.Request.Path}");
1952   
1953           await _next(context);
1954   
1955           Console.WriteLine($"Response Status Code: {context.Response.StatusCode}");
1956       }
1957   }
1958   
1959   Register in Program.cs:
1960   app.UseMiddleware<RequestResponseLoggingMiddleware>();
1961   
1962   Note: Useful for logging, security, global header modifications.
1963   
1964   
1965   
1966   
1967   Q82. What is Minimal API in .NET 6+?
1968   
1969   Answer:
1970   Minimal API allows you to define API endpoints without Controllers.
1971   
1972   Example:
1973   
1974   var builder = WebApplication.CreateBuilder(args);
1975   var app = builder.Build();
1976   
1977   app.MapGet("/hello", () => "Hello World!");
1978   
1979   app.Run();
1980   
1981   Note: Perfect for small microservices or lightweight APIs!
1982   
1983   
1984   
1985   
1986   
1987   
1988   Q83. How to upload multiple files in ASP.NET Core Web API?
1989   
1990   Answer:
1991   Controller:
1992   
1993   [HttpPost("upload-multiple")]
1994   public async Task<IActionResult> UploadFiles(List<IFormFile> files)
1995   {
1996       foreach (var file in files)
1997       {
1998           var path = Path.Combine("uploads", file.FileName);
1999           using (var stream = new FileStream(path, FileMode.Create))
2000           {
2001               await file.CopyToAsync(stream);
2002           }
2003       }
2004       return Ok("Files uploaded successfully");
2005   }
2006   
2007   Note: Important to set enctype="multipart/form-data" on client forms.
2008   
2009   
2010   
2011   
2012   
2013   
2014   
2015   Q84. How do you create strongly typed appsettings.json configuration?
2016   
2017   Answer:
2018   Define POCO class:
2019   
2020   public class MySettings
2021   {
2022       public string SiteTitle { get; set; }
2023       public int RefreshInterval { get; set; }
2024   }
2025   
2026   In Program.cs:
2027   builder.Services.Configure<MySettings>(builder.Configuration.GetSection("MySettings"));
2028   
2029   Inject and use:
2030   private readonly MySettings _settings;
2031   public MyController(IOptions<MySettings> options)
2032   {
2033       _settings = options.Value;
2034   }
2035   
2036   Note: Clean and safe way to handle configuration values.
2037   
2038   
2039   
2040   
2041   
2042   Q85. How do you return a custom error model instead of default error in API?
2043   
2044   Answer:
2045   Custom error response:
2046   
2047   [HttpGet("get")]
2048   public IActionResult Get()
2049   {
2050       return BadRequest(new { Message = "Invalid request", ErrorCode = 4001 });
2051   }
2052   
2053   Note: Always preferred for API-first designs where clients expect structured errors.
2054   
2055   
2056   
2057   
2058   
2059   Q86. What is the difference between 401 and 403 HTTP status codes?
2060   
2061   Answer:
2062   
2063   
2064   Status Code Meaning
2065   ==========================================================
2066   401 Unauthorized User not authenticated
2067   403 Forbidden User authenticated but not authorized
2068   
2069   
2070   Note: "Unauthorized" = Login needed, "Forbidden" = Login done but no permission!
2071   
2072   
2073   
2074   
2075   
2076   Q87. How do you implement Retry Policies for API calls in ASP.NET Core?
2077   
2078   Answer:
2079   Use Polly NuGet package:
2080   
2081   builder.Services.AddHttpClient("RetryApi")
2082       .AddTransientHttpErrorPolicy(policy =>
2083           policy.WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(2)));
2084   
2085   Note: Automatically retries failed HTTP requests due to timeout, server error, etc.
2086   
2087   
2088   
2089   
2090   
2091   Q88. What are Fluent Validation libraries in ASP.NET Core?
2092   
2093   Answer:
2094   
2095   a. Third-party validation framework
2096   b. More expressive than DataAnnotations
2097   
2098   Install FluentValidation:
2099   builder.Services.AddFluentValidationAutoValidation();
2100   
2101   Create validator:
2102   public class ProductValidator : AbstractValidator<Product>
2103   {
2104       public ProductValidator()
2105       {
2106           RuleFor(x => x.Name).NotEmpty();
2107           RuleFor(x => x.Price).GreaterThan(0);
2108       }
2109   }
2110   
2111   Note: Clean, powerful and testable model validation.
2112   
2113   
2114   
2115   
2116   
2117   Q89. How to add HSTS (HTTP Strict Transport Security) in ASP.NET Core?
2118   
2119   Answer:
2120   Add in Program.cs:
2121   
2122   app.UseHsts();
2123   
2124   Or configure:
2125   
2126   app.UseHsts(hsts =>
2127   {
2128       hsts.MaxAge = TimeSpan.FromDays(365);
2129       hsts.IncludeSubDomains();
2130       hsts.Preload();
2131   });
2132   
2133   Note: Forces browsers to use HTTPS instead of HTTP, even if typed manually.
2134   
2135   
2136   
2137   
2138   
2139   Q90. How do you implement Health Checks in ASP.NET Core Web API?
2140   
2141   Answer:
2142   Configure:
2143   
2144   builder.Services.AddHealthChecks();
2145   
2146   Map endpoint:
2147   app.MapHealthChecks("/health");
2148   
2149   Browser:
2150   https://localhost:5001/health
2151   
2152   Note: Easy way to monitor API uptime for DevOps and Kubernetes readiness.
2153   
2154   
2155   Q91. How do you implement Role-Based Authorization in Web API?
2156   
2157   Answer:
2158   Add roles to policies:
2159   
2160   builder.Services.AddAuthorization(options =>
2161   {
2162       options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
2163   });
2164   
2165   Use in Controller:
2166   
2167   [Authorize(Roles = "Admin")]
2168   [HttpGet("admin")]
2169   public IActionResult AdminArea()
2170   {
2171       return Ok("Welcome Admin");
2172   }
2173   
2174   Note: Ensures that only users with specific roles can access certain API endpoints.
2175   
2176   
2177   Q92. What is the difference between Claims and Roles?
2178   
2179   Answer:
2180   
2181   Aspect Role Claim
2182   ======================================================
2183   Purpose Authorization   Any info about user (email, age, department)
2184   Type String value  Key-Value pair (flexible)
2185   Example Admin", "User"   "Department" = "Finance", "Age" = 30
2186   
2187   
2188   Note: Roles are specific to permission, while Claims are broader user metadata.
2189   
2190   
2191   
2192   
2193   Q93. How do you consume a third-party Web API inside ASP.NET Core?
2194   
2195   Answer:
2196   Using HttpClientFactory:
2197   
2198   builder.Services.AddHttpClient();
2199   
2200   In Controller:
2201   private readonly IHttpClientFactory _clientFactory;
2202   
2203   public MyController(IHttpClientFactory clientFactory)
2204   {
2205       _clientFactory = clientFactory;
2206   }
2207   
2208   [HttpGet]
2209   public async Task<IActionResult> GetData()
2210   {
2211       var client = _clientFactory.CreateClient();
2212       var response = await client.GetAsync("https://api.example.com/data");
2213       var data = await response.Content.ReadAsStringAsync();
2214       return Ok(data);
2215   }
2216   
2217   Note: Clean way to consume REST APIs inside your project.
2218   
2219   
2220   
2221   
2222   Q94. How do you configure Swagger UI only for Development Environment?
2223   
2224   Answer:
2225   In Program.cs:
2226   
2227   if (app.Environment.IsDevelopment())
2228   {
2229       app.UseSwagger();
2230       app.UseSwaggerUI();
2231   }
2232   
2233   Note: Prevents exposing sensitive API docs on production servers.
2234   
2235   
2236   
2237   
2238   
2239   
2240   Q95. What are Filters in Web API and types of Filters?
2241   
2242   Answer:
2243   
2244   
2245   Type Purpose
2246   ==================================================
2247   Authorization Authorize before controller action
2248   Resource Runs before and after controller
2249   Action Runs before and after an action
2250   Exception Handles unhandled exceptions
2251   Result Runs before/after writing response
2252   
2253   Note:  Filters add cross-cutting concerns like logging, caching, validation globally.
2254   
2255   
2256   
2257   
2258   Q96. How do you implement Custom Action Filters?
2259   
2260   Answer:
2261   Create filter:
2262   
2263   public class LogActionFilter : ActionFilterAttribute
2264   {
2265       public override void OnActionExecuting(ActionExecutingContext context)
2266       {
2267           Console.WriteLine("Before action executes");
2268       }
2269   }
2270   
2271   Use on Controller or Action:
2272   
2273   [LogActionFilter]
2274   [HttpGet]
2275   public IActionResult Get()
2276   {
2277       return Ok();
2278   }
2279   
2280   Note: Custom filters allow plugging custom behavior into the action pipeline.
2281   
2282   
2283   
2284   
2285   
2286   Q97. How do you generate JWT tokens manually without Identity framework?
2287   
2288   Answer:
2289   Example:
2290   
2291   var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecretKey"));
2292   var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
2293   
2294   var token = new JwtSecurityToken(
2295       issuer: "myapi.com",
2296       audience: "myapi.com",
2297       claims: new[] { new Claim(ClaimTypes.Name, "Karthik") },
2298       expires: DateTime.Now.AddMinutes(30),
2299       signingCredentials: credentials
2300   );
2301   
2302   string jwt = new JwtSecurityTokenHandler().WriteToken(token);
2303   
2304   Note: Manual control over token contents, expiry, and claims!
2305   
2306   
2307   
2308   Q98. What is Caching in Web API and why is it important?
2309   
2310   Answer:
2311   Caching stores previously generated responses to serve faster next time.
2312   
2313   Types:
2314   
2315   In-Memory Caching: Cached inside API memory.
2316   Distributed Caching: Cached externally (e.g., Redis).
2317   
2318   Add memory cache:
2319   builder.Services.AddMemoryCache();
2320   
2321   Use in Controller:
2322   private readonly IMemoryCache _cache;
2323   
2324   public MyController(IMemoryCache cache)
2325   {
2326       _cache = cache;
2327   }
2328   
2329   [HttpGet]
2330   public IActionResult GetData()
2331   {
2332       if (!_cache.TryGetValue("data", out string data))
2333       {
2334           data = "Database Data";
2335           _cache.Set("data", data, TimeSpan.FromMinutes(5));
2336       }
2337       return Ok(data);
2338   }
2339   
2340   Note: Boosts performance and reduces database/API load.
2341   
2342   
2343   
2344   
2345   Q99. How to validate incoming JSON against a JSON Schema?
2346   
2347   Answer:
2348   Use NJsonSchema or FluentValidation libraries.
2349   
2350   Example using FluentValidation:
2351   builder.Services.AddFluentValidationAutoValidation();
2352   
2353   Create a Validator class:
2354   public class ProductValidator : AbstractValidator<Product>
2355   {
2356       public ProductValidator()
2357       {
2358           RuleFor(x => x.Name).NotEmpty();
2359           RuleFor(x => x.Price).GreaterThan(0);
2360       }
2361   }
2362   
2363   Note: Ensures request payloads are correct before processing!
2364   
2365   
2366   
2367   
2368   Q100. How to handle large file uploads in ASP.NET Core Web API?
2369   
2370   Answer:
2371   Increase request size limit:
2372   
2373   builder.WebHost.ConfigureKestrel(options =>
2374   {
2375       options.Limits.MaxRequestBodySize = 50 * 1024 * 1024; // 50 MB
2376   });
2377   
2378   Or use [RequestSizeLimit] attribute:
2379   
2380   [RequestSizeLimit(52428800)]
2381   [HttpPost("upload-large")]
2382   public async Task<IActionResult> UploadLargeFile(IFormFile file)
2383   {
2384       // process file
2385       return Ok();
2386   }
2387   
2388   Note: Prevents server crashes when large files are uploaded!
2389   

-------------------------------------------------------------------------------------------------------------
.Net Core MVC - 1
-------------------------------------------------------------------------------------------------------------
1. Introduction to ASP.NET Core MVC
Basics of ASP.NET Core MVC
Question: What is ASP.NET Core MVC, and how does it differ from ASP.NET MVC?
Answer: ASP.NET Core MVC is a modern, lightweight, and modular framework for building web
applications and APIs using the Model-View-Controller pattern. It differs from the classic ASP.NET
MVC by being cross-platform, having better performance, and being fully integrated with ASP.NET Core,
which supports cloud-based, microservices, and containerized environments.

Core Features of ASP.NET Core MVC
Question: What are the key features of ASP.NET Core MVC?
Answer: Key features include:
Cross-platform support (Windows, Linux, macOS).
Built-in dependency injection.
Razor Pages for simplified page-focused development.
Tag Helpers for cleaner HTML generation.
Built-in routing and middleware.
Strong integration with modern front-end frameworks and tools.

3. Middleware and Request Pipeline
Middleware in ASP.NET Core MVC
Question: What is middleware in ASP.NET Core, and how does it work in the request pipeline?
Answer: Middleware is a component that processes HTTP requests and responses in the ASP.NET Core
request pipeline. Each middleware component can either handle a request, modify it, or pass it to the next
middleware in the pipeline. Common middleware components include authentication, authorization,
logging, and error handling.

Adding Middleware
Question: How do you add middleware to the request pipeline in ASP.NET Core MVC?
Answer: Middleware is added in the Startup.Configure method using extension methods such
as UseRouting , UseAuthentication , UseAuthorization , and UseEndpoints . Middleware
components are executed in the order they are added.

5. Routing in ASP.NET Core MVC
Conventional Routing
Question: What is conventional routing in ASP.NET Core MVC, and how is it configured?
Answer: Conventional routing defines URL patterns that map to controllers and actions. It is typically
configured in the Startup.Configure method using UseEndpoints() and MapControllerRoute() .
csharp Copy code
app.UseEndpoints(endpoints => { endpoints.MapControllerRoute( name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}"); });

Attribute Routing
Question: What is attribute routing, and how does it work in ASP.NET Core MVC?
Answer: Attribute routing allows developers to define routes directly on controller actions using
attributes. This provides more control and flexibility over route definitions and is useful for RESTful
APIs.
csharp Copy code
[Route("products/{id}")] public IActionResult ProductDetails(int id) { // Retrieve
product details }

7. Controllers and Actions
Controllers in ASP.NET Core MVC
Question: What is the role of a controller in ASP.NET Core MVC?
Answer: A controller in ASP.NET Core MVC handles incoming HTTP requests, processes them (usually
by interacting with a model), and returns an appropriate response. The response can be a view, JSON
data, or an HTTP status code.

Action Results
Question: What are the different types of action results in ASP.NET Core MVC?
Answer: Action results represent the response from a controller action. Common action results include:
ViewResult: Renders a view to the response.
JsonResult: Returns JSON data.
ContentResult: Returns plain text or other content.
RedirectResult: Redirects to a different action or URL.
FileResult: Returns a file download.

Asynchronous Actions
Question: How do you create asynchronous controller actions in ASP.NET Core MVC?
Answer: Asynchronous actions are created using the async keyword and await keyword. This allows
the action to handle I/O-bound operations without blocking the main thread.
csharp
public async Task<IActionResult> GetData() { var data = await
_dataService.GetDataAsync(); return View(data); }
Copy code

9. Views and Razor Pages
Razor View Engine
Question: What is the Razor view engine in ASP.NET Core MVC, and why is it used?
Answer: The Razor view engine is a syntax for embedding C# code into HTML in a concise and readable
way. It uses the @ symbol to switch between HTML and C# code. Razor is commonly used to build
dynamic views in ASP.NET Core MVC applications.

Strongly Typed Views
Question: What are strongly typed views in ASP.NET Core MVC?
Answer: Strongly typed views are views that are bound to a specific model type. This allows for
IntelliSense, type checking, and more maintainable code when accessing model properties in the view.
csharp Copy code
@model MyApp.Models.Product <h1>@Model.ProductName</h1>

Razor Pages
Question: What are Razor Pages in ASP.NET Core, and how do they differ from MVC?
Answer: Razor Pages are a page-based development model in ASP.NET Core, similar to MVC but with a
simpler structure. Each page has a corresponding .cshtml file and a page model class. Razor Pages are
more suited for scenarios where the focus is on pages rather than complex application logic and routing.

11. Model Binding and Validation
Model Binding
Question: How does model binding work in ASP.NET Core MVC?
Answer: Model binding automatically maps data from HTTP requests (form data, query strings, route
data, etc.) to action method parameters or model properties. ASP.NET Core MVC handles type
conversion and validation as part of the binding process.

Data Annotations
Question: How do data annotations work for model validation in ASP.NET Core MVC?
Answer: Data annotations are attributes applied to model properties to define validation rules. Common
attributes include [Required] , [StringLength] , [Range] , and [EmailAddress] . ASP.NET Core
MVC automatically validates models based on these attributes when an action method is invoked.

Custom Validation
Question: How do you implement custom validation in ASP.NET Core MVC?
Answer: Custom validation can be implemented by creating a custom attribute that inherits
from ValidationAttribute and overriding the IsValid method.
csharp Copy code
public class CustomAgeAttribute : ValidationAttribute { protected override
ValidationResult IsValid(object value, ValidationContext validationContext) { int
age = (int)value; return age >= 18 ? ValidationResult.Success : new
ValidationResult("Age must be 18 or older."); } }

13. Tag Helpers and HTML Helpers
Tag Helpers
Question: What are Tag Helpers in ASP.NET Core MVC?
Answer: Tag Helpers are server-side components that generate HTML dynamically. They provide an
easier and more readable syntax compared to HTML Helpers, allowing developers to work with HTML
and Razor syntax in a seamless way. Common Tag Helpers include asp-action , asp-controller ,
and asp-for .

HTML Helpers
Question: What are HTML Helpers in ASP.NET Core MVC, and how do they work?
Answer: HTML Helpers are methods used to generate HTML elements in Razor views. They are used to
generate form elements like text boxes, checkboxes, and dropdowns. Examples
include Html.TextBoxFor() , Html.DropDownListFor() , and Html.ValidationMessageFor() .

15. Dependency Injection in ASP.NET Core MVC
Built-in Dependency Injection
Question: How is dependency injection implemented in ASP.NET Core MVC?
Answer: ASP.NET Core MVC has built-in support for dependency injection (DI). Services are registered
in the Startup.ConfigureServices method, and dependencies are injected into controllers or services
using constructor injection.
csharp
services.AddTransient<IDataService, DataService>();

Service Lifetimes
Question: What are the different service lifetimes available in ASP.NET Core MVC?
Answer: The three main service lifetimes in ASP.NET Core are:
Transient: A new instance is created every time the service is requested.
Scoped: A new instance is created per HTTP request.
Singleton: A single instance is created and shared across the application.
Copy code

17. Authentication and Authorization
Authentication in ASP.NET Core MVC
Question: How does authentication work in ASP.NET Core MVC?
Answer: ASP.NET Core MVC uses middleware for authentication. Common authentication schemes
include cookies, JWT Bearer tokens, and OAuth. You configure authentication
in Startup.ConfigureServices using services.AddAuthentication() and define authentication
schemes like CookieAuthenticationDefaults.AuthenticationScheme .

Authorization
Question: How is role-based authorization implemented in ASP.NET Core MVC?
Answer: Role-based authorization is implemented using the [Authorize] attribute. You can restrict
access to certain actions or controllers based on user roles by specifying roles in the attribute.
csharp Copy code
[Authorize(Roles = "Admin")] public IActionResult AdminDashboard() { // Only
accessible to users with the "Admin" role }

19. Error Handling and Logging
Global Error Handling
Question: How do you implement global error handling in ASP.NET Core MVC?
Answer: Global error handling can be implemented using
the UseExceptionHandler() middleware in the Startup.Configure method. This middleware
catches unhandled exceptions and redirects them to a custom error page.
csharp
app.UseExceptionHandler("/Home/Error");
app.UseStatusCodePagesWithReExecute("/Home/StatusCode", "?code={0}");

Logging in ASP.NET Core MVC
Copy code
Question: How is logging implemented in ASP.NET Core MVC?
Answer: Logging is built into ASP.NET Core and is implemented using the ILogger interface.
You can configure logging providers (e.g., console, file, Azure Application Insights) in
the Startup.ConfigureServices method. Logging can be injected into controllers and services
via constructor injection.
csharp Copy code
public class HomeController { private readonly ILogger<HomeController> _logger;
public HomeController(ILogger<HomeController> logger) { _logger = logger; } public
IActionResult Index() { _logger.LogInformation("Index page accessed"); return
View(); } }

21. Asynchronous Programming in ASP.NET Core MVC
Asynchronous Action Methods
Question: How do asynchronous action methods work in ASP.NET Core MVC?
Answer: Asynchronous action methods use async and await to perform non-blocking
operations, allowing the server to handle more requests. This is particularly useful for I/O-bound
operations like database access or API calls.
csharp
public async Task<IActionResult> GetData() { var data = await
_dataService.GetDataAsync(); return View(data); }

Task-Based Asynchronous Pattern (TAP)
Copy code
Question: What is the Task-Based Asynchronous Pattern (TAP) in ASP.NET Core?
Answer: TAP is the standard model for writing asynchronous code in .NET, where asynchronous
methods return Task or Task<T> . It allows for better scalability by freeing up threads when
waiting for I/O operations, enabling the server to handle more requests concurrently.

23. Unit Testing in ASP.NET Core MVC
Unit Testing Controllers
Question: How do you unit test controllers in ASP.NET Core MVC?
Answer: Unit testing controllers involves testing the action methods to ensure they return the
correct ActionResult . You can use mocking frameworks like Moq to mock dependencies and
isolate the controller's behavior.
csharp Copy code
[Fact] public void Index_ReturnsViewResult() { var mockService = new
Mock<IDataService>(); var controller = new HomeController(mockService.Object); var
result = controller.Index() as ViewResult; Assert.NotNull(result); }

Mocking Dependencies
Question: How do you mock dependencies in ASP.NET Core MVC for unit testing?
Answer: You can mock dependencies using a mocking framework like Moq. Mocking allows you
to simulate the behavior of services and repositories, isolating the logic in the controller for unit
testing.
csharp
var mockService = new Mock<IDataService>(); mockService.Setup(service =>
service.GetDataAsync()).ReturnsAsync(new List<Data>());
Copy code

25. Performance Optimization
Caching in ASP.NET Core MVC
Question: How do you implement caching in ASP.NET Core MVC?
Answer: ASP.NET Core MVC supports caching through response caching, in-memory caching,
and distributed caching. You can use the [ResponseCache] attribute to cache HTTP responses
or IMemoryCache for in-memory caching of data.
csharp Copy code
[ResponseCache(Duration = 60)] public IActionResult Index() { return View(); }

Using AsNoTracking
Question: What is AsNoTracking() in ASP.NET Core MVC, and when should it be used?
Answer: AsNoTracking() is used in Entity Framework Core to improve performance for read
only queries by disabling change tracking. It is ideal for scenarios where data is fetched without
the intention to modify it.
csharp
var products = context.Products.AsNoTracking().ToList();
Copy code

27. Globalization and Localization
Localization in ASP.NET Core MVC
Question: How do you implement localization in ASP.NET Core MVC?
Answer: Localization is implemented by adding resource files for different languages and
configuring the localization services in Startup.ConfigureServices . You can
use IStringLocalizer and IViewLocalizer to retrieve localized strings in views and
controllers.
csharp Copy code
public void ConfigureServices(IServiceCollection services) {
services.AddLocalization(options => options.ResourcesPath = "Resources");
services.AddControllersWithViews() .AddViewLocalization()
.AddDataAnnotationsLocalization(); }

Globalization
Question: How do you enable globalization in ASP.NET Core MVC?
Answer: Globalization involves configuring the RequestLocalizationMiddleware to handle
culture-specific data like date formats, numbers, and currencies. You can define supported
cultures in the Startup.Configure method.
csharp Copy code
app.UseRequestLocalization(new RequestLocalizationOptions { DefaultRequestCulture =
new RequestCulture("en-US"), SupportedCultures = new List<CultureInfo> { new
CultureInfo("en-US"), new CultureInfo("fr-FR") }, SupportedUICultures = new
List<CultureInfo> { new CultureInfo("en-US"), new CultureInfo("fr-FR") } });

29. API Development with ASP.NET Core MVC
Building REST APIs
Question: How do you build a REST API using ASP.NET Core MVC?
Answer: REST APIs are built using controllers that return data (typically in JSON format) instead
of views. You use JsonResult or Ok() methods to return responses, and routing is configured
with attribute routing to match HTTP verbs (GET, POST, PUT, DELETE).
csharp
[HttpGet] public IActionResult GetAllProducts() { var products =
_productService.GetAll(); return Ok(products); }

API Versioning
Copy code
Question: How do you implement API versioning in ASP.NET Core?
Answer: API versioning can be implemented using
the Microsoft.AspNetCore.Mvc.Versioning package. You define API versions using attributes
like [ApiVersion("1.0")] and [Route("api/v{version:apiVersion}/[controller]")] , and
configure versioning in Startup.ConfigureServices .
csharp Copy code
services.AddApiVersioning(options => { options.AssumeDefaultVersionWhenUnspecified
= true; options.DefaultApiVersion = new ApiVersion(1, 0); });

-------------------------------------------------------------------------------------------------------------
.Net Core MVC - 2
-------------------------------------------------------------------------------------------------------------
1. Introduction to ASP.NET MVC
MVC Architecture
Question: What is ASP.NET MVC, and how does it differ from ASP.NET Web Forms?
Answer: ASP.NET MVC is a framework for building web applications using the Model-View-Controller
architecture. It differs from Web Forms by providing better control over HTML, no ViewState, and
support for Test-Driven Development (TDD). Web Forms is event-driven, while MVC follows a request
response model.

Components of MVC
Question: What are the three main components of the MVC architecture, and what are their roles?
Answer:
Model: Represents the data and business logic of the application.
View: Displays the data (UI) and sends user input to the controller.
Controller: Handles user input, interacts with the model, and returns the appropriate view.

3. Controllers in ASP.NET MVC
Controller Basics
Question: What is the role of a controller in ASP.NET MVC?
Answer: A controller in MVC handles incoming HTTP requests, interacts with the model to process the
data, and returns the appropriate view to the user.

Action Methods
Question: What are action methods in ASP.NET MVC?
Answer: Action methods are methods in a controller class that handle requests and return responses. Each
action method typically corresponds to a unique URL or route.
Question: How do you specify an action method for different HTTP verbs (GET, POST, PUT,
DELETE)?
Answer: You use attributes like [HttpGet] , [HttpPost] , [HttpPut] , and [HttpDelete] to specify
which HTTP verb an action method responds to.
csharp Copy code
[HttpPost] public ActionResult SubmitForm() { // Handle form submission }

5. Routing in ASP.NET MVC
Default Routing
Question: How does routing work in ASP.NET MVC?
Answer: Routing maps incoming URLs to controller actions. The default route is defined in
the RouteConfig file, mapping URLs to the {controller}/{action}/{id} pattern:
csharp Copy code
routes.MapRoute( name: "Default", url: "{controller}/{action}/{id}", defaults: new
{ controller = "Home", action = "Index", id = UrlParameter.Optional } );

Attribute Routing
Question: What is attribute routing, and how is it used in ASP.NET MVC?
Answer: Attribute routing allows you to define routes using attributes directly on action methods and
controllers, providing more control and clarity.
csharp Copy code
[Route("products/{id}")] public ActionResult Details(int id) { // Show product
details }

7. Models in ASP.NET MVC
Model Binding
Question: What is model binding in ASP.NET MVC?
Answer: Model binding automatically maps data from HTTP requests (form fields, query strings, etc.) to
action method parameters or model properties. MVC handles type conversion and validation
automatically.

Strongly Typed Models
Question: What is a strongly-typed view in ASP.NET MVC?
Answer: A strongly-typed view is a view that is bound to a specific model type. The model is passed
from the controller to the view, enabling IntelliSense and type safety when accessing model properties.

ViewModels
Question: What is a ViewModel, and how is it used in ASP.NET MVC?
Answer: A ViewModel is a class that contains data specifically for displaying in a view. It can combine
properties from multiple models or contain additional properties needed for the view. It helps decouple
the view from the domain model.

9. Views in ASP.NET MVC
Razor View Engine
Question: What is the Razor view engine, and how does it differ from the traditional ASPX view engine?
Answer: The Razor view engine is a lightweight markup engine introduced in MVC 3. It uses
the @ symbol to embed C# code into HTML. Razor syntax is more concise and readable compared to the
traditional ASPX engine, which uses <%= %> for code rendering.

Partial Views
Question: What is a partial view in ASP.NET MVC, and how is it used?
Answer: A partial view is a reusable view that renders a portion of the page. It can be included in other
views using the @Html.Partial() or @Html.RenderPartial() methods. It’s useful for rendering
common UI components like navigation bars or forms.

Layouts
Question: What is a layout page in ASP.NET MVC?
Answer: A layout page defines a common structure (e.g., header, footer) for multiple views. It’s similar to
a master page in Web Forms. Views can inherit a layout to ensure a consistent structure across pages:
csharp
@Layout = "~/Views/Shared/_Layout.cshtml";
Copy code

11. Data Annotations and Validation
Model Validation
Question: How does model validation work in ASP.NET MVC?
Answer: Model validation is achieved using data annotations. Attributes
like [Required] , [StringLength] , [Range] , and [EmailAddress] are applied to model properties,
and MVC automatically checks these validations when binding data in a form.

Custom Validation
Question: How do you create custom validation in ASP.NET MVC?
Answer: You can create custom validation by implementing the IValidatableObject interface or
creating a custom attribute by inheriting from ValidationAttribute and overriding
the IsValid method.
csharp Copy code
public class CustomAgeAttribute : ValidationAttribute { protected override
ValidationResult IsValid(object value, ValidationContext validationContext) { int
age = (int)value; if (age < 18) { return new ValidationResult("Age must be at least
18."); } return ValidationResult.Success; } }

13. Action Results and View Results
ActionResult
Question: What is ActionResult in ASP.NET MVC?
Answer: ActionResult is the base class for all action method return types. It can represent different
kinds of responses, such as HTML views ( ViewResult ), JSON data ( JsonResult ), file downloads
( FileResult ), or redirects ( RedirectResult ).

ViewResult
Question: How does ViewResult work in ASP.NET MVC?
Answer: ViewResult is a type of ActionResult that renders a view. It is the most common return type
in an MVC controller, typically used to display HTML:
csharp
return View("Index");

JSON and File Results
Copy code
Question: How do you return JSON data from an action method in ASP.NET MVC?
Answer: You can return JSON data using the Json() method. This is useful for AJAX requests:
csharp Copy code
return Json(new { Name = "John", Age = 25 });
Question: How do you return a file in ASP.NET MVC?
Answer: You can return a file using the FileResult class, which allows users to download a file from
the server:
csharp Copy code
return File(filePath, "application/pdf", "document.pdf");

15. Filters in ASP.NET MVC
Action Filters
Question: What are action filters in ASP.NET MVC?
Answer: Action filters allow you to run code before or after an action method executes. Common filters
include AuthorizeAttribute , HandleErrorAttribute , and OutputCacheAttribute . Custom filters
can be created by inheriting from ActionFilterAttribute .

Types of Filters
Question: What are the different types of filters in ASP.NET MVC?
Answer:
Authorization Filters: Handle user authentication and authorization.
Action Filters: Execute logic before or after action methods.
Result Filters: Execute code before or after a view result is processed.
Exception Filters: Handle exceptions raised during action execution.

Creating Custom Filters
Question: How do you create a custom filter in ASP.NET MVC?
Answer: Custom filters are created by inheriting
from ActionFilterAttribute or IActionFilter and overriding
the OnActionExecuting or OnActionExecuted methods:
csharp Copy code
public class CustomLogAttribute : ActionFilterAttribute { public override void
OnActionExecuting(ActionExecutingContext filterContext) { // Custom logic before
the action executes } }

17. Authentication and Authorization in ASP.NET MVC
Forms Authentication
Question: How does forms authentication work in ASP.NET MVC?
Answer: Forms authentication redirects unauthorized users to a login page. After login, an authentication
ticket (cookie) is created to identify the user. This is configured in the Web.config :
xml Copy code
<authentication mode="Forms"> <forms loginUrl="~/Account/Login" timeout="30" />
</authentication>

Role-Based Authorization
Question: How is role-based authorization implemented in ASP.NET MVC?
Answer: Role-based authorization allows you to restrict access to controller actions based on
the user's role. You use the [Authorize] attribute to define roles that are allowed access:
csharp Copy code
[Authorize(Roles = "Admin")] public ActionResult AdminDashboard() { // Only users
in the "Admin" role can access this action return View(); }

Custom Authentication
Question: How do you implement custom authentication in ASP.NET MVC?
Answer: Custom authentication can be implemented by creating your own logic to validate
users and set the authentication ticket manually. This is done
using FormsAuthentication.SetAuthCookie or FormsAuthenticationTicket to create an
authentication cookie after verifying user credentials.

18. State Management in ASP.NET MVC
TempData, ViewData, and ViewBag
Question: What is the difference between TempData , ViewData , and ViewBag in ASP.NET MVC?
Answer:
ViewData: A dictionary object used to pass data from the controller to the view. Data is
available only for the current request.
ViewBag: A dynamic wrapper around ViewData that allows data to be accessed with
properties instead of keys. Data is also available only for the current request.
TempData: Used to store data temporarily between multiple requests (e.g., after a redirect).
It is based on Session and persists until read.

Session Management
Question: How does session management work in ASP.NET MVC?
Answer: Session management in MVC works similarly to Web Forms. You can store and retrieve
data across multiple requests using the Session object:
csharp Copy code
Session["UserName"] = "John"; string name = Session["UserName"].ToString();

20. AJAX and jQuery in ASP.NET MVC
AJAX Helpers
Question: What are AJAX helpers in ASP.NET MVC, and how do they work?
Answer: AJAX helpers are used to perform asynchronous requests in an MVC application
without refreshing the page. Common helpers
include Ajax.BeginForm and Ajax.ActionLink for making asynchronous form submissions and
links:
csharp Copy code
@using (Ajax.BeginForm("SubmitForm", new AjaxOptions { UpdateTargetId = "result"
})) { <input type="submit" value="Submit" /> }

jQuery Integration
Question: How is jQuery used in ASP.NET MVC?
Answer: jQuery can be used to perform client-side tasks such as DOM manipulation, AJAX calls,
and event handling in ASP.NET MVC. You can make an AJAX request using jQuery like this:
javascript
$.ajax({ url: '/Home/GetData', type: 'GET', success: function(data) {
$('#result').html(data); } });
Copy code

22. Dependency Injection (DI) in ASP.NET MVC
DI in MVC
Question: How does Dependency Injection work in ASP.NET MVC?
Answer: Dependency Injection (DI) is implemented in ASP.NET MVC using Inversion of Control
(IoC) containers. Popular containers include Unity, Ninject, and Autofac. These frameworks
manage the lifetime of dependencies and inject them into controllers or services.
csharp Copy code
public class HomeController : Controller { private readonly IMyService _myService;
public HomeController(IMyService myService) { _myService = myService; } }

Setting up DI
Question: How do you set up dependency injection in ASP.NET MVC?
Answer: You register your dependencies in the IoC container during application startup
in Global.asax . For example, using Unity:
csharp Copy code
var container = new UnityContainer(); container.RegisterType<IMyService, MyService>
(); DependencyResolver.SetResolver(new UnityDependencyResolver(container));

24. Unit Testing in ASP.NET MVC
Unit Testing Controllers
Question: How do you unit test controllers in ASP.NET MVC?
Answer: Unit testing controllers in ASP.NET MVC involves testing the action methods
independently of other components. You can mock dependencies and test the return type and
data of the action method. For example:
csharp Copy code
[TestMethod] public void Index_ReturnsViewResult() { var controller = new
HomeController(); var result = controller.Index() as ViewResult;
Assert.IsNotNull(result); }

Mocking Dependencies
Question: How do you mock dependencies in ASP.NET MVC for unit testing?
Answer: Dependencies like services or repositories can be mocked using frameworks like Moq
or NSubstitute. You inject these mocked objects into your controllers to isolate the unit of work
being tested.
csharp
var mockService = new Mock<IMyService>(); var controller = new
HomeController(mockService.Object);
Copy code

26. Performance Optimization in ASP.NET MVC
Output Caching
Question: How do you implement output caching in ASP.NET MVC?
Answer: Output caching stores the result of a controller action and serves it from the cache for
subsequent requests. This can be implemented using the [OutputCache] attribute:
csharp Copy code
[OutputCache(Duration = 60, VaryByParam = "none")] public ActionResult Index() {
return View(); }

Bundling and Minification
Question: What is bundling and minification in ASP.NET MVC, and how does it improve
performance?
Answer: Bundling combines multiple JavaScript and CSS files into a single file, and minification
reduces file size by removing unnecessary characters like whitespace. These techniques reduce
the number of HTTP requests and file sizes, improving page load times.
csharp Copy code
BundleConfig.RegisterBundles(BundleTable.Bundles);

28. Handling Exceptions in ASP.NET MVC
Global Exception Handling
Question: How do you handle global exceptions in ASP.NET MVC?
Answer: Global exceptions can be handled by overriding the OnException method in a
controller or by using the HandleError attribute. You can also use global filters to catch and log
exceptions:
csharp Copy code
protected override void OnException(ExceptionContext filterContext) { // Log the
error filterContext.ExceptionHandled = true; filterContext.Result =
RedirectToAction("Error"); }

Custom Error Pages
Question: How do you configure custom error pages in ASP.NET MVC?
Answer: Custom error pages can be configured using the HandleError attribute or in
the Web.config file:
xml Copy code
<customErrors mode="On"> <error statusCode="404" redirect="~/Error/NotFound" />
<error statusCode="500" redirect="~/Error/ServerError" /> </customErrors>

30. Entity Framework Integration in ASP.NET MVC
Using Entity Framework
Question: How do you integrate Entity Framework in an ASP.NET MVC application?
Answer: Entity Framework is used as an ORM to interact with the database in an MVC
application. You can inject a DbContext into a repository or directly into a controller for data
access.
csharp Copy code
public class ApplicationDbContext : DbContext { public DbSet<Product> Products {
get; set; } }

Lazy Loading and Eager Loading
Question: What is the difference between lazy loading and eager loading in Entity Framework?
Answer:
Lazy Loading: Related data is loaded when it is accessed, reducing the initial query load but
potentially causing additional database queries.
Eager Loading: Related data is loaded along with the main entity using Include() ,
reducing the number of queries but increasing the size of the initial query.

32. Advanced Concepts in ASP.NET MVC
Areas in ASP.NET MVC
Question: What are areas in ASP.NET MVC, and why are they used?
Answer: Areas in ASP.NET MVC help organize large applications by dividing them into smaller
functional sections, each with its own controllers, views, and models. This allows for better
separation of concerns and code organization.

Asynchronous Controllers
Question: How do asynchronous controllers work in ASP.NET MVC?
Answer: Asynchronous controllers handle long-running tasks without blocking the request
thread, improving application scalability. You can define an asynchronous action method using
the async and await keywords:
csharp
public async Task<ActionResult> GetData() { var data = await
service.GetDataAsync(); return View(data); }
Copy code

-------------------------------------------------------------------------------------------------------------
.Net Core MVC - 3
-------------------------------------------------------------------------------------------------------------
1   ASP.NET MVC Interview Questions by Karthik M
2   ============================================
3   
4   Q1. What is ASP.NET MVC? How is it different from ASP.NET Web Forms?
5   
6   Answer:
7   
8   ASP.NET MVC stands for Model-View-Controller, a design pattern that separates an 
application into three components:
9   
10   a. Model: Handles application data and business logic.
11   b. View: Represents the UI part of the application.
12   c. Controller: Responds to user inputs and interacts with the Model and View.
13   
14   Differences from Web Forms:
15   -------------------------
16   a. No ViewState in MVC, so pages are lightweight.
17   b. MVC gives full control over HTML, while Web Forms use server controls.
18   c. MVC follows the Separation of Concerns principle.
19   d. MVC applications are more easily testable than Web Forms.
20   
21   
22   
23   
24   Q2. Explain the ASP.NET MVC Request Life Cycle.
25   
26   Answer:
27   The ASP.NET MVC Request Life Cycle involves these key steps:
28   
29   Step - 1 
30   Routing: URL is matched to a route defined in RouteConfig.
31   
32   Step - 2 
33   Controller Initialization: Appropriate Controller is instantiated.
34   
35   Step - 3 
36   Action Execution: The action method is invoked.
37   
38   Step - 4
39   Result Execution: ActionResult (like ViewResult) is returned.
40   
41   Step - 5
42   View Rendering: The View is rendered and returned to the browser.
43   
44   
45   
46   Q3. What is a Controller in MVC?
47   
48   Answer:
49   A Controller handles incoming HTTP requests and returns responses. Controllers inherit 
from the Controller base class.
50   
51   Example:
52   public class ProductController : Controller
53   {
54       public ActionResult Details(int id)
55       {
56           // Fetch product by id
57           return View();
58       }
59   }
60   
61   
62   
63   
64   Q4. What is an Action Method in MVC?
65   
66   Answer:
67   Action Methods are public methods inside a Controller class that handle HTTP requests.
68   
69   Example:
70   public ActionResult About()
71   {
72       return View();
73   }
74   
75   An Action Method must be:
76   a. Public
77   b. Non-static
78   c. Not decorated with [NonAction] attribute
79   
80   
81   
82   Q5. What is Routing in ASP.NET MVC?
83   
84   Answer:
85   Routing defines how URLs map to controller actions. It is configured in RouteConfig.cs.
86   
87   Example:
88   routes.MapRoute(
89       name: "Default",
90       url: "{controller}/{action}/{id}",
91       defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
92   );
93   
94   Thus, the URL /Product/Details/5 calls ProductController's Details method with id = 5.
95   
96   
97   
98   Q6. How can you pass data from Controller to View in MVC?
99   
100   Answer:
101   Three common ways to pass data:
102   
103   a. ViewBag (dynamic): ViewBag.Message = "Hello World";
104   b. ViewData (dictionary): ViewData["Message"] = "Hello World";
105   c. Model (strongly typed): return View(productList);
106   
107   In the View, you can access:
108   
109   a. @ViewBag.Message
110   b. @ViewData["Message"]
111   c. @Model.PropertyName
112   
113   
114   
115   
116   Q7. What is the difference between ViewBag, ViewData, and TempData?
117   
118   Answer:
119   
120   a. ViewBag: Dynamic wrapper around ViewData, lives for the current request.
121   b. ViewData: Dictionary object, also lives only for the current request.
122   c. TempData: Uses Session to persist data for one more request (useful after redirects).
123   
124   Example using TempData:
125   TempData["SuccessMessage"] = "Record Saved Successfully!";
126   
127   
128   
129   Q8. What is a Strongly Typed View?
130   
131   Answer:
132   A Strongly Typed View is a View that is bound to a specific Model class.
133   
134   At the top of the Razor View, you declare the model:
135   @model MyApp.Models.Product
136   
137   Then you can access properties with IntelliSense:
138   @Model.ProductName
139   @Model.Price
140   
141   This makes development strongly typed, compile-time checked, and more efficient.
142   
143   
144   
145   Q9. What is Razor View Engine in ASP.NET MVC?
146   
147   Answer:
148   Razor is the View Engine that allows mixing C# code with HTML easily.
149   Syntax uses @ to indicate C# code.
150   
151   Example:
152   @foreach (var item in Model.Products)
153   {
154       <p>@item.Name</p>
155   }
156   
157   Advantages:
158   
159   a. Cleaner syntax
160   b. Faster rendering
161   c. No need for <% %> syntax like older Web Forms
162   
163   
164   Q10. What is the difference between Html.Partial() and Html.RenderPartial()?
165   
166   Answer:
167   
168   Html.Partial() returns a string that represents HTML content.
169   
170   Html.RenderPartial() writes HTML directly to the response stream — slightly faster.
171   
172   Example using Html.Partial():
173   @Html.Partial("_ProductPartial", productList)
174   
175   Example using Html.RenderPartial():
176   @{ Html.RenderPartial("_ProductPartial", productList); }
177   
178   Use Html.Partial() when you need the output returned. Use Html.RenderPartial() for 
slightly better performance when you don't need the returned HTML.
179   
180   
181   
182   Q11. What are different types of Action Results in MVC?
183   
184   Answer:
185   Action Results represent different types of responses that a controller action can 
return.
186   
187   Common types:
188   
189   a. ViewResult — returns HTML and markup (using Views).
190   b. PartialViewResult — returns a partial View.
191   c. RedirectResult — redirects to another URL.
192   d. RedirectToRouteResult — redirects to another route.
193   e. JsonResult — returns JSON-formatted data.
194   f. FileResult — returns a file to download.
195   g. ContentResult — returns plain text.
196   
197   
198   Example returning a JSON:
199   return Json(new { id = 1, name = "Product1" }, JsonRequestBehavior.AllowGet);
200   
201   
202   
203   
204   
205   Q12. How can you restrict an action method to be invoked only by POST request?
206   
207   Answer:
208   Use the [HttpPost] attribute above the Action Method.
209   
210   Example:
211   [HttpPost]
212   public ActionResult Save(Product model)
213   {
214       // Save logic
215       return RedirectToAction("Index");
216   }
217   
218   Similarly, use [HttpGet] for GET requests.
219   
220   
221   
222   
223   Q13. What is the difference between RedirectToAction() and Redirect()?
224   
225   Answer:
226   
227   RedirectToAction("Index") redirects to a specific action inside a controller.
228   
229   Redirect("http://example.com") redirects to a specified URL.
230   
231   Example using RedirectToAction:
232   return RedirectToAction("Index", "Home");
233   
234   Example using Redirect:
235   return Redirect("https://www.google.com");
236   
237   RedirectToAction is route-based; Redirect is URL-based.
238   
239   
240   
241   Q14. What is the use of the [NonAction] attribute in MVC?
242   
243   Answer:
244   The [NonAction] attribute is used to mark a public method in a controller that should 
not be treated as an Action Method.
245   
246   Example:
247   public class ProductController : Controller
248   {
249       [NonAction]
250       public void HelperMethod()
251       {
252           // Not an action
253       }
254   }
255   
256   
257   
258   Q15. What are Filters in MVC?
259   
260   Answer:
261   Filters are attributes that add extra behavior to action methods or controllers.
262   
263   Types of filters:
264   
265   a. Authorization filters (e.g., [Authorize])
266   b. Action filters (e.g., [OnActionExecuting])
267   c. Result filters (e.g., [OnResultExecuting])
268   d. Exception filters (e.g., [HandleError])
269   
270   Example:
271   [Authorize]
272   public ActionResult Dashboard()
273   {
274       return View();
275   }
276   
277   
278   
279   
280   Q16. What is the difference between TempData, ViewData, and ViewBag?
281   
282   Answer:
283   
284   
285   Aspect ViewData ViewBag TempData
286   =================================================================================
287   Type Dictionary Dynamic Dictionary
288   Life Span Current Request Current Request Persists until next 
request
289   Usage ViewData["key"] ViewBag.key TempData["key"]
290   Use Case Passing data to View Passing data to View Passing data across Redirects
291   
292   
293   
294   Q17. What is Model Binding in MVC?
295   
296   Answer:
297   Model Binding maps incoming request data (Form, Query String, Route Data) to action 
method parameters.
298   
299   Example:
300   public ActionResult Save(Product model)
301   {
302       // Model Binding automatically fills model properties
303       return View();
304   }
305   
306   If the posted form has input fields named ProductName, Price, they are automatically 
mapped to the Product object.
307   
308   
309   
310   
311   Q18. How can you validate a model in ASP.NET MVC?
312   
313   Answer:
314   Use Data Annotations on the model properties and call ModelState.IsValid in the 
controller.
315   
316   Example:
317   public class Product
318   {
319       [Required]
320       public string ProductName { get; set; }
321   
322       [Range(1, 10000)]
323       public decimal Price { get; set; }
324   }
325   
326   Controller code:
327   if (ModelState.IsValid)
328   {
329       // Save Product
330   }
331   
332   
333   
334   
335   
336   
337   Q19. What is the difference between View() and PartialView() in MVC?
338   
339   Answer:
340   
341   View() renders the full View including Layout.
342   
343   PartialView() renders only a section of a page, without Layout.
344   
345   Example:
346   return View("Index");
347   
348   return PartialView("_ProductList", products);
349   
350   Partial Views are useful for AJAX updates and reusable UI parts.
351   
352   
353   
354   
355   
356   
357   Q20. How do you implement Custom Error Handling in MVC?
358   
359   Answer:
360   You can use:
361   
362   [HandleError] attribute on controllers/actions
363   
364   customErrors section in web.config
365   
366   Example with [HandleError]:
367   [HandleError(View = "Error")]
368   public class ProductController : Controller
369   {
370       public ActionResult Create()
371       {
372           throw new Exception("Something went wrong!");
373       }
374   }
375   
376   Also, configure in web.config:
377   <customErrors mode="On" defaultRedirect="~/Home/Error" />
378   
379   
380   
381   Q21. What is a View in MVC?
382   
383   Answer:
384   A View is the user interface (UI) component in MVC architecture. It presents data to the 
user and accepts input.
385   
386   Example View (Index.cshtml):
387   @model MyApp.Models.Product
388   
389   <h2>Product Details</h2> <p>Name: @Model.ProductName</p> <p>Price: @Model.Price</p>
390   The View uses the data passed from the Controller and renders it as HTML.
391   
392   
393   
394   Q22. What is Razor Syntax in ASP.NET MVC?
395   
396   Answer:
397   Razor is the syntax used to embed server-side C# code into HTML markup easily.
398   
399   Syntax Examples:
400   
401   Inline expressions: @Model.ProductName
402   
403   Loop example:
404   @foreach (var item in Model.Products)
405   {
406       <p>@item.Name</p>
407   }
408   
409   Rules:
410   
411   a. Code statements start with @
412   b. No need for <% %> like older ASP.NET Web Forms.
413   
414   
415   Q23. How do you create a strongly typed View?
416   
417   Answer:
418   At the top of the View, declare the model type using @model:
419   
420   @model MyApp.Models.Employee
421   
422   Then you can access the Model properties with IntelliSense:
423   
424   <p>@Model.EmployeeName</p> <p>@Model.Salary</p>
425   Strongly typed Views ensure type safety and better productivity.
426   
427   
428   
429   
430   Q24. What are HTML Helpers in MVC?
431   
432   Answer:
433   HTML Helpers are methods that simplify rendering standard HTML elements.
434   
435   Common examples:
436   
437   @Html.TextBoxFor(m => m.ProductName)
438   
439   @Html.LabelFor(m => m.ProductName)
440   
441   @Html.DropDownListFor(m => m.CategoryId, categoryList)
442   
443   They help generate clean and consistent HTML controls in Views.
444   
445   
446   
447   
448   Q25. What is the difference between Html.TextBox() and Html.TextBoxFor()?
449   
450   Answer:
451   
452   Html.TextBox() is loosely typed (string-based), no IntelliSense.
453   Example: @Html.TextBox("ProductName")
454   
455   Html.TextBoxFor() is strongly typed (model-based), compile-time checked.
456   Example: @Html.TextBoxFor(m => m.ProductName)
457   
458   Prefer TextBoxFor() for strong typing and error checking.
459   
460   
461   
462   
463   Q26. How do you create a DropDownList using HTML Helpers?
464   
465   Answer:
466   You can create a DropDownList using Html.DropDownListFor().
467   
468   Example:
469   @Html.DropDownListFor(m => m.CategoryId, new SelectList(Model.Categories, "CategoryId", 
"CategoryName"))
470   
471   Here:
472   
473   m => m.CategoryId is the model property bound.
474   
475   Model.Categories is the source list.
476   
477   
478   
479   Q27. What is ViewStart file in MVC?
480   
481   Answer:
482   The _ViewStart.cshtml file contains code that should run before every View is rendered.
483   
484   Example content of _ViewStart.cshtml:
485   
486   @{ Layout = "~/Views/Shared/_Layout.cshtml"; }
487   
488   It sets a default Layout for all Views, so you don’t have to set Layout individually in 
every View.
489   
490   
491   
492   
493   Q28. What is the purpose of Layout pages in MVC?
494   
495   Answer:
496   Layout pages are like Master Pages in Web Forms.
497   They allow you to define a common structure (e.g., header, footer, navigation) and reuse 
it across multiple Views.
498   
499   Example Layout (_Layout.cshtml):
500   
501   <!DOCTYPE html> 
502   <html> 
503   <head> 
504   <title>@ViewBag.Title</title> 
505   </head> 
506   <body> @RenderBody() </body> 
507   </html>
508   
509   Each View is injected into @RenderBody() placeholder at runtime.
510   
511   
512   
513   
514   Q29. How do you render a Partial View manually inside a View?
515   
516   Answer:
517   Use either:
518   
519   @Html.Partial("_ProductPartial") (returns HTML string)
520   
521   @{ Html.RenderPartial("_ProductPartial"); } (writes directly to response)
522   
523   Both render _ProductPartial.cshtml inside the parent View.
524   
525   Use Partial Views when you want to reuse pieces of UI.
526   
527   
528   
529   
530   Q30. How do you perform form submissions in MVC?
531   
532   Answer:
533   You create a form using Html.BeginForm().
534   
535   Example:
536   
537   @using (Html.BeginForm("Save", "Product", FormMethod.Post))
538   {
539       @Html.LabelFor(m => m.ProductName)
540       @Html.TextBoxFor(m => m.ProductName)
541   
542       <input type="submit" value="Save" />
543   }
544   
545   When the user submits the form, it posts the data to Save action in ProductController.
546   
547   
548   
549   Q31. What is ModelState in ASP.NET MVC?
550   
551   Answer:
552   ModelState is a property of the Controller that holds the state of model binding and 
validation.
553   
554   Typically, you check if the model is valid before proceeding:
555   
556   if (ModelState.IsValid)
557   {
558       // Save to database
559   }
560   else
561   {
562       // Return validation errors to View
563   }
564   
565   It automatically tracks validation errors based on Data Annotations applied to Model 
properties.
566   
567   
568   
569   
570   Q32. What is Data Annotation in MVC?
571   
572   Answer:
573   Data Annotations are attributes applied to Model properties to enforce validation rules.
574   
575   Example:
576   
577   public class Product
578   {
579       [Required(ErrorMessage = "Product Name is required")]
580       public string ProductName { get; set; }
581   
582       [Range(1, 10000)]
583       public decimal Price { get; set; }
584   }
585   
586   When you post data, MVC will automatically validate these rules.
587   
588   
589   
590   
591   
592   Q33. How do you create custom validation attributes in MVC?
593   
594   Answer:
595   You create a class by inheriting from ValidationAttribute and override IsValid().
596   
597   Example:
598   
599   public class NoZeroPriceAttribute : ValidationAttribute
600   {
601       public override bool IsValid(object value)
602       {
603           decimal price = (decimal)value;
604           return price != 0;
605       }
606   }
607   
608   Apply it to a property:
609   
610   [NoZeroPrice(ErrorMessage = "Price cannot be zero")]
611   public decimal Price { get; set; }
612   
613   
614   
615   
616   
617   Q34. What is Unobtrusive JavaScript validation in MVC?
618   
619   Answer:
620   Unobtrusive Validation separates JavaScript behavior from HTML markup, resulting in 
cleaner code.
621   
622   To enable it:
623   
624   Include jQuery and jQuery Validation libraries.
625   
626   Set these keys in web.config:
627   
628   <appSettings> 
629   <add key="ClientValidationEnabled" value="true" /> 
630   <add key="UnobtrusiveJavaScriptEnabled" value="true" /> 
631   </appSettings>
632   
633   It automatically enables client-side validation based on Data Annotations.
634   
635   
636   
637   
638   Q35. How do you perform server-side validation in MVC?
639   
640   Answer:
641   Server-side validation is done by checking ModelState.IsValid in Controller Actions.
642   
643   Example:
644   
645   [HttpPost]
646   public ActionResult Save(Product model)
647   {
648       if (ModelState.IsValid)
649       {
650           // Save data
651       }
652       return View(model);
653   }
654   
655   Even if client-side validation is disabled, server-side validation ensures data 
integrity.
656   
657   
658   
659   Q36. What are strongly typed HTML helpers?
660   
661   Answer:
662   Strongly typed helpers are bound to a specific Model property.
663   
664   Example:
665   
666   @Html.TextBoxFor(m => m.ProductName)
667   @Html.EditorFor(m => m.Price)
668   @Html.DisplayFor(m => m.ProductName)
669   
670   Advantages:
671   
672   a. Compile-time checking
673   b. IntelliSense support
674   c. Less prone to typos
675   
676   
677   
678   Q37. How do you return JSON from an MVC Controller?
679   
680   Answer:
681   You can use the JsonResult return type.
682   
683   Example:
684   
685   public JsonResult GetProduct(int id)
686   {
687       var product = new Product { Id = id, Name = "Pen", Price = 100 };
688       return Json(product, JsonRequestBehavior.AllowGet);
689   }
690   
691   This will serialize the product object to JSON and return it to the client.
692   
693   
694   
695   
696   Q38. What is Dependency Injection (DI) in MVC?
697   
698   Answer:
699   Dependency Injection is a design pattern to inject dependencies into classes rather than 
having them instantiate the dependencies themselves.
700   
701   Benefits:
702   
703   Loose coupling
704   Easier testing
705   Better maintainability
706   
707   In ASP.NET Core MVC, built-in DI is configured using:
708   
709   services.AddScoped<IProductService, ProductService>();
710   
711   In traditional MVC, you can use libraries like Unity, Ninject, Autofac for DI.
712   
713   
714   
715   Q39. How do you implement custom Dependency Injection in ASP.NET MVC?
716   
717   Answer:
718   You create your own dependency resolver by implementing IDependencyResolver.
719   
720   Example:
721   
722   public class CustomResolver : IDependencyResolver
723   {
724       public object GetService(Type serviceType)
725       {
726           // Instantiate services here
727           return new ProductService();
728       }
729   
730       public IEnumerable<object> GetServices(Type serviceType)
731       {
732           return new List<object>();
733       }
734   }
735   
736   And register it in Global.asax:
737   
738   DependencyResolver.SetResolver(new CustomResolver());
739   
740   
741   
742   
743   
744   Q40. What is Bundling and Minification in MVC?
745   
746   Answer:
747   Bundling and Minification are performance techniques to:
748   
749   Bundle multiple CSS or JS files into one file.
750   
751   Minify (remove whitespaces and comments) the file content.
752   
753   Example in BundleConfig.cs:
754   
755   bundles.Add(new ScriptBundle("/bundles/jquery").Include(
756       "/Scripts/jquery-{version}.js"
757   ));
758   
759   bundles.Add(new StyleBundle("/Content/css").Include(
760       "/Content/bootstrap.css",
761       "~/Content/site.css"
762   ));
763   
764   It reduces the number of requests and improves page load time.
765   
766   
767   Q41. How do you enable Bundling and Minification in MVC?
768   
769   Answer:
770   By default, Bundling and Minification happen only in Release mode.
771   
772   You can force them manually in BundleConfig.cs by setting:
773   BundleTable.EnableOptimizations = true;
774   
775   And then register bundles inside Application_Start() in Global.asax:
776   BundleConfig.RegisterBundles(BundleTable.Bundles);
777   
778   This combines and compresses CSS and JS for faster page loads.
779   
780   
781   
782   
783   Q42. What is the use of AntiForgeryToken in MVC?
784   
785   Answer:
786   Anti-Forgery Tokens prevent Cross-Site Request Forgery (CSRF) attacks.
787   
788   In the View:
789   
790   @using (Html.BeginForm())
791   {
792       @Html.AntiForgeryToken()
793       // Form fields
794   }
795   
796   In the Controller:
797   
798   [HttpPost]
799   [ValidateAntiForgeryToken]
800   public ActionResult Save(Product model)
801   {
802       // Save logic
803   }
804   
805   The server checks that the token submitted matches the one generated, ensuring the 
request is genuine.
806   
807   
808   
809   
810   Q43. What is the [AllowAnonymous] attribute in MVC?
811   
812   Answer:
813   [AllowAnonymous] allows unauthenticated users to access specific actions or controllers 
even if the entire application requires authentication.
814   
815   Example:
816   
817   [Authorize]
818   public class DashboardController : Controller
819   {
820       public ActionResult Index() { return View(); }
821   
822       [AllowAnonymous]
823       public ActionResult Help() { return View(); }
824   }
825   
826   Here, Dashboard/Help can be accessed without logging in.
827   
828   
829   
830   
831   
832   Q44. How do you handle 404 errors in MVC?
833   
834   Answer:
835   You can handle 404 errors globally by updating web.config:
836   
837   <system.web>
838       <customErrors mode="On" defaultRedirect="~/Error/General">
839           <error statusCode="404" redirect="~/Error/NotFound"/>
840       </customErrors>
841   </system.web>
842   
843   You can also create an ErrorController with NotFound and General actions to handle these 
gracefully.
844   
845   
846   
847   
848   Q45. What is Areas in ASP.NET MVC?
849   
850   Answer:
851   Areas allow you to divide a large MVC application into smaller functional sections, each 
with its own Controllers, Views, and Models.
852   
853   For example:
854   
855   Admin Area
856   Customer Area
857   Billing Area
858   
859   Each Area has its own AreaRegistration.cs file where its routes are registered.
860   
861   Example:
862   
863   context.MapRoute(
864       "Admin_default",
865       "Admin/{controller}/{action}/{id}",
866       new { action = "Index", id = UrlParameter.Optional }
867   );
868   
869   
870   
871   
872   Q46. What is Output Caching in MVC?
873   
874   Answer:
875   Output Caching stores the response of a Controller action and reuses it for subsequent 
requests, boosting performance.
876   
877   Example:
878   
879   [OutputCache(Duration = 60)]
880   public ActionResult Index()
881   {
882       // This View will be cached for 60 seconds
883       return View();
884   }
885   
886   Benefits:
887   
888   a. Reduces server processing
889   b. Improves load time
890   
891   
892   
893   Q47. What is Child Action Only in MVC?
894   
895   Answer:
896   [ChildActionOnly] attribute restricts an action method to be called only from another 
View, not directly via URL.
897   
898   Example:
899   
900   [ChildActionOnly]
901   public ActionResult Menu()
902   {
903       return PartialView("_Menu");
904   }
905   
906   You render it inside another View like:
907   
908   @Html.Action("Menu")
909   
910   If a user tries to directly access /Home/Menu, they will get an error.
911   
912   
913   
914   
915   
916   Q48. How do you use Authorize attribute with Roles?
917   
918   Answer:
919   You can specify roles allowed to access a controller or action.
920   
921   Example:
922   
923   [Authorize(Roles = "Admin,Manager")]
924   public ActionResult ManageUsers()
925   {
926       return View();
927   }
928   
929   Only users in the "Admin" or "Manager" roles can access ManageUsers.
930   
931   
932   
933   
934   
935   
936   Q49. How can you send JSON data from JavaScript to an MVC controller?
937   
938   Answer:
939   Using jQuery $.ajax() method:
940   
941   $.ajax({
942       url: '/Product/Save',
943       type: 'POST',
944       data: JSON.stringify({ Id: 1, Name: "Pen" }),
945       contentType: 'application/json; charset=utf-8',
946       success: function(response) {
947           alert(response);
948       }
949   });
950   
951   Controller:
952   
953   [HttpPost]
954   public JsonResult Save(Product product)
955   {
956       // Save product
957       return Json("Success");
958   }
959   
960   
961   
962   
963   
964   Q50. What is TempData Keep() and Peek() in MVC?
965   
966   Answer:
967   
968   TempData.Keep() preserves data for another request manually.
969   TempData.Peek() reads data without marking it for deletion.
970   
971   Example:
972   
973   string message = TempData.Peek("Message") as string;
974   TempData.Keep("Message");
975   
976   Normally, TempData gets cleared after one read, but Keep() and Peek() allow retaining it.
977   
978   
979   
980   
981   Q51. How do you make an Ajax call in MVC to update part of a page?
982   
983   Answer:
984   Use jQuery $.ajax() to call an action and update a div without refreshing the full page.
985   
986   Example:
987   
988   $.ajax({
989       url: '/Product/GetProductList',
990       type: 'GET',
991       success: function (data) {
992           $('#productDiv').html(data);
993       }
994   });
995   
996   In your View:
997   
998   <div id="productDiv"></div>
999   Controller:
1000   
1001   public ActionResult GetProductList()
1002   {
1003       return PartialView("_ProductListPartial", products);
1004   }
1005   
1006   
1007   
1008   Q52. What is the difference between ViewBag and TempData in MVC?
1009   
1010   Answer:
1011   
1012   
1013   Aspect ViewBag TempData
1014   =====================================================================
1015   Life Span Current HTTP Request Current + Next Request
1016   Usage Dynamic property (ViewBag.Name) Dictionary-based (TempData["Name"])
1017   Purpose Pass data from Controller to View Pass data between Controllers
1018   
1019   
1020   Q53. What are the different types of Filters in MVC?
1021   
1022   Answer:
1023   
1024   a. Authorization Filters — Implement IAuthorizationFilter.
1025   b. Action Filters — Implement IActionFilter.
1026   c. Result Filters — Implement IResultFilter.
1027   d. Exception Filters — Implement IExceptionFilter.
1028   
1029   You can create custom filters by inheriting ActionFilterAttribute and overriding methods 
like OnActionExecuting() and OnResultExecuting().
1030   
1031   Example:
1032   
1033   public class CustomActionFilter : ActionFilterAttribute
1034   {
1035       public override void OnActionExecuting(ActionExecutingContext filterContext)
1036       {
1037           // Your custom logic
1038       }
1039   }
1040   
1041   
1042   
1043   
1044   Q54. What is Web API and how is it different from MVC?
1045   
1046   Answer:
1047   
1048   
1049   Aspect MVC Web API
1050   ===================================================================================
1051   Purpose Return Views (HTML) Return Data (JSON, XML)
1052   Return Type ActionResult/ViewResult HttpResponseMessage/IHttpActionResult
1053   Use Case Web Applications RESTful Services
1054   
1055   
1056   MVC is ideal for UI-rendered apps.
1057   Web API is used for services consumed by clients like mobile apps, SPA (Single Page 
Applications), etc.
1058   
1059   
1060   
1061   
1062   
1063   Q55. How can you secure Web API endpoints?
1064   
1065   Answer:
1066   Options include:
1067   
1068   a. Basic Authentication
1069   b. Token-based Authentication (JWT)
1070   c. OAuth
1071   d. API Key validation
1072   e. Custom Authorization Filters
1073   
1074   Example Basic Authentication setup:
1075   
1076   [Authorize]
1077   public class ProductsController : ApiController
1078   {
1079       // Secure API
1080   }
1081   
1082   You also configure authentication handlers in Startup.cs for ASP.NET Core.
1083   
1084   
1085   
1086   
1087   Q56. How to prevent Cross-Site Scripting (XSS) in MVC?
1088   
1089   Answer:
1090   MVC automatically encodes output. Use:
1091   
1092   @Html.Encode(Model.ProductName)
1093   
1094   Or directly in Razor:
1095   
1096   <p>@Model.ProductName</p>
1097   To disable encoding (if absolutely required):
1098   
1099   @Html.Raw(Model.Description)
1100   
1101   Always validate and sanitize inputs to prevent XSS attacks.
1102   
1103   
1104   
1105   
1106   Q57. How can you call a Web API from MVC?
1107   
1108   Answer:
1109   You can use HttpClient inside a controller.
1110   
1111   Example:
1112   
1113   HttpClient client = new HttpClient();
1114   client.BaseAddress = new Uri("https://api.example.com/");
1115   HttpResponseMessage response = await client.GetAsync("api/products");
1116   if (response.IsSuccessStatusCode)
1117   {
1118       var products = await response.Content.ReadAsAsync<IEnumerable<Product>>();
1119   }
1120   
1121   This helps MVC applications consume external APIs.
1122   
1123   
1124   
1125   
1126   Q58. What is the use of Route Constraints in MVC?
1127   
1128   Answer:
1129   Route Constraints restrict which URLs match a route based on pattern matching.
1130   
1131   Example:
1132   
1133   routes.MapRoute(
1134       "Default",
1135       "{controller}/{action}/{id}",
1136       new { controller = "Home", action = "Index", id = UrlParameter.Optional },
1137       new { id = @"\d+" } // id must be numeric
1138   );
1139   
1140   This ensures that id must be digits only (regular expression constraint).
1141   
1142   
1143   
1144   
1145   Q59. How do you handle Global Exception Handling in MVC?
1146   
1147   Answer:
1148   You can create a custom filter:
1149   
1150   public class GlobalExceptionFilter : FilterAttribute, IExceptionFilter
1151   {
1152       public void OnException(ExceptionContext filterContext)
1153       {
1154           filterContext.ExceptionHandled = true;
1155           filterContext.Result = new ViewResult { ViewName = "Error" };
1156       }
1157   }
1158   
1159   Register it globally:
1160   
1161   GlobalFilters.Filters.Add(new GlobalExceptionFilter());
1162   Or configure in web.config using customErrors.
1163   
1164   
1165   
1166   
1167   Q60. How can you create a Custom Route Handler in MVC?
1168   
1169   Answer:
1170   Create a class that implements IRouteHandler:
1171   
1172   public class CustomRouteHandler : IRouteHandler
1173   {
1174       public IHttpHandler GetHttpHandler(RequestContext requestContext)
1175       {
1176           return new MyHttpHandler();
1177       }
1178   }
1179   
1180   Then map it in RouteConfig.cs:
1181   
1182   routes.Add(new Route("customroute/{id}", new CustomRouteHandler()));
1183   
1184   This gives you complete control over how specific requests are processed.
1185   
1186   
1187   
1188   
1189   Q61. How do you implement Dependency Injection in MVC without using third-party 
libraries?
1190   
1191   Answer:
1192   You can manually inject dependencies using constructor injection.
1193   
1194   Example Controller:
1195   
1196   public class ProductController : Controller
1197   {
1198       private readonly IProductService _productService;
1199   
1200       public ProductController(IProductService productService)
1201       {
1202           _productService = productService;
1203       }
1204   
1205       public ActionResult Index()
1206       {
1207           var products = _productService.GetProducts();
1208           return View(products);
1209       }
1210   }
1211   
1212   You instantiate dependencies in a custom IDependencyResolver implementation.
1213   
1214   
1215   
1216   
1217   Q62. What is Unit Testing in MVC and how is it achieved?
1218   
1219   Answer:
1220   Unit Testing in MVC involves testing Controllers independently of Views and external 
systems.
1221   
1222   Tools commonly used:
1223   NUnit, MSTest, or xUnit for writing tests
1224   Moq for mocking dependencies
1225   
1226   Example Test:
1227   
1228   [TestMethod]
1229   public void Index_Returns_View_With_Products()
1230   {
1231       // Arrange
1232       var mockService = new Mock<IProductService>();
1233       mockService.Setup(s => s.GetProducts()).Returns(new List<Product>());
1234       var controller = new ProductController(mockService.Object);
1235   
1236       // Act
1237       var result = controller.Index() as ViewResult;
1238   
1239       // Assert
1240       Assert.IsNotNull(result);
1241   }
1242   
1243   
1244   
1245   
1246   Q63. How to restrict access to certain controllers only to Admins in MVC?
1247   
1248   Answer:
1249   Use the [Authorize(Roles="Admin")] attribute on the controller or action.
1250   
1251   Example:
1252   
1253   [Authorize(Roles = "Admin")]
1254   public class AdminDashboardController : Controller
1255   {
1256       public ActionResult Index()
1257       {
1258           return View();
1259       }
1260   }
1261   
1262   Only users in the Admin role can access this Controller.
1263   
1264   
1265   
1266   
1267   
1268   Q64. What are TempData, ViewData, and ViewBag — and when do you use each?
1269   
1270   Answer:
1271   
1272   
1273   Feature ViewData ViewBag TempData
1274   =========================================================================================
==
1275   Type Dictionary (string, object) Dynamic Property Dictionary (string, 
object)
1276   Lifetime Current Request Current Request Current + Next Request
1277   Purpose Pass data to View Pass data to View Pass data across 
Redirects
1278   Syntax ViewData["Name"] ViewBag.Name TempData["Name"]
1279   
1280   
1281   Use ViewData/ViewBag for passing data to Views, and TempData to persist data across 
redirects.
1282   
1283   
1284   
1285   
1286   Q65. What is the difference between RedirectToAction and Redirect in MVC?
1287   
1288   Answer:
1289   
1290   RedirectToAction() redirects to another action within MVC (using routing).
1291   Redirect() sends an HTTP redirect to a URL.
1292   
1293   Example RedirectToAction:
1294   return RedirectToAction("Index", "Home");
1295   
1296   Example Redirect:
1297   return Redirect("https://www.example.com");
1298   
1299   Note: RedirectToAction is preferred inside MVC because it respects route mappings.
1300   
1301   
1302   
1303   
1304   
1305   Q66. What is the difference between Session and TempData?
1306   
1307   Answer:
1308   
1309   Aspect Session TempData
1310   =========================================================================================
=====================
1311   Lifetime Until Browser Closes/Timeout Only Current + Next 
Request
1312   Purpose Store large user data (e.g., Profile, Cart) Store small messages 
(e.g., success/error)
1313   Accessibility Controller, View, other layers Mainly for 
Controller/View
1314   
1315   Session is bigger and longer-lived. TempData is short-lived and light-weight.
1316   
1317   
1318   
1319   
1320   Q67. How do you use OutputCache with parameters in MVC?
1321   
1322   Answer:
1323   You can cache based on parameters using the VaryByParam property.
1324   
1325   Example:
1326   
1327   [OutputCache(Duration = 60, VaryByParam = "id")]
1328   public ActionResult Details(int id)
1329   {
1330       return View();
1331   }
1332   
1333   Here, caching is done separately for each id value passed.
1334   
1335   
1336   
1337   
1338   Q68. What is ActionName Attribute in MVC?
1339   
1340   Answer:
1341   [ActionName] allows you to rename the URL path of an action without changing the method 
name.
1342   
1343   Example:
1344   
1345   [ActionName("Details")]
1346   public ActionResult ShowDetails(int id)
1347   {
1348       return View();
1349   }
1350   
1351   The URL will map to /ControllerName/Details even though the method is called ShowDetails.
1352   
1353   
1354   
1355   
1356   Q69. What is the use of ValidateInput(false) in MVC?
1357   
1358   Answer:
1359   ValidateInput(false) disables the ASP.NET MVC request validation for the current action, 
allowing potentially unsafe input (like HTML).
1360   
1361   Example:
1362   
1363   [HttpPost]
1364   [ValidateInput(false)]
1365   public ActionResult Save(string content)
1366   {
1367       // Save HTML content
1368       return View();
1369   }
1370   
1371   Warning: Use this carefully. Always sanitize user input to prevent XSS.
1372   
1373   
1374   
1375   
1376   Q70. What are NonAction Methods in MVC?
1377   
1378   Answer:
1379   Methods marked with [NonAction] are NOT considered Controller Actions and cannot be 
invoked via URLs.
1380   
1381   Example:
1382   
1383   public class ProductController : Controller
1384   {
1385       [NonAction]
1386       public string HelperMethod()
1387       {
1388           return "Helper Logic";
1389       }
1390   }
1391   
1392   HelperMethod() cannot be accessed by routing — it is only used internally within the 
controller.
1393   
1394   
1395   
1396   Q71. What is a Partial View in MVC?
1397   
1398   Answer:
1399   A Partial View is like a reusable sub-View that can be embedded inside a View.
1400   
1401   Creating a Partial View:
1402   _Views/Shared/_ProductSummary.cshtml
1403   
1404   Inside a normal View:
1405   @Html.Partial("_ProductSummary", product)
1406   
1407   Or, if you want it to run controller logic:
1408   @Html.Action("Summary", "Product")
1409   
1410   Note: Partial Views are ideal for modular UI components like headers, footers, product 
cards, etc.
1411   
1412   
1413   
1414   Q72. What are Tag Helpers in ASP.NET Core MVC?
1415   
1416   Answer:
1417   Tag Helpers allow you to use server-side code directly inside HTML tags for better 
readability.
1418   
1419   Example:
1420   
1421   <input asp-for="Email" class="form-control" />
1422   This will automatically bind to the Email property of the Model.
1423   
1424   You no longer need to use Html.TextBoxFor() or Html.EditorFor().
1425   Tag Helpers feel more like HTML-native syntax and are easier to maintain.
1426   
1427   
1428   
1429   Q73. How do you post a file to MVC Controller?
1430   
1431   Answer:
1432   Form setup:
1433   
1434   <form action="/Upload/Submit" method="post" enctype="multipart/form-data"> 
1435   <input type="file" name="file" /> <button type="submit">Upload</button> 
1436   </form>
1437   
1438   Controller:
1439   
1440   [HttpPost]
1441   public ActionResult Submit(HttpPostedFileBase file)
1442   {
1443       if (file != null && file.ContentLength > 0)
1444       {
1445           var path = Path.Combine(Server.MapPath("~/Uploads"), 
Path.GetFileName(file.FileName));
1446           file.SaveAs(path);
1447       }
1448       return RedirectToAction("Index");
1449   }
1450   
1451   You must set enctype="multipart/form-data" in the form for file uploads to work.
1452   
1453   
1454   
1455   
1456   Q74. What is Authorization Filter and Authentication Filter in MVC?
1457   
1458   Answer:
1459   Authentication Filter: Ensures the user is authenticated (e.g., logged in).
1460   Authorization Filter: Ensures the user is authorized (e.g., has correct roles or 
permissions).
1461   
1462   Example Authorization filter:
1463   
1464   [Authorize(Roles = "Admin")]
1465   public class AdminController : Controller
1466   {
1467       public ActionResult Index()
1468       {
1469           return View();
1470       }
1471   }
1472   
1473   Note: In ASP.NET MVC 5, Authentication Filters were introduced separately for better 
separation of concerns.
1474   
1475   
1476   
1477   Q75. How to implement Forms Authentication in MVC?
1478   
1479   Answer:
1480   Set <authentication mode="Forms"> in web.config.
1481   
1482   web.config:
1483   
1484   <authentication mode="Forms"> 
1485   <forms loginUrl="~/Account/Login" timeout="30" /> 
1486   </authentication>
1487   
1488   Login Controller Action:
1489   
1490   [HttpPost]
1491   public ActionResult Login(string username, string password)
1492   {
1493       if (IsValidUser(username, password))
1494       {
1495           FormsAuthentication.SetAuthCookie(username, false);
1496           return RedirectToAction("Index", "Home");
1497       }
1498       return View();
1499   }
1500   
1501   This enables cookie-based login without needing ASP.NET Identity.
1502   
1503   
1504   
1505   
1506   Q76. What is RoutePrefix Attribute in MVC?
1507   
1508   Answer:
1509   [RoutePrefix] allows you to define a common route prefix for all actions in a controller.
1510   
1511   Example:
1512   
1513   [RoutePrefix("admin/products")]
1514   public class ProductAdminController : Controller
1515   {
1516       [Route("list")]
1517       public ActionResult ListProducts()
1518       {
1519           return View();
1520       }
1521   }
1522   
1523   This action would be accessible via /admin/products/list.
1524   
1525   It helps organize and simplify your route configurations.
1526   
1527   
1528   
1529   
1530   Q77. How do you handle concurrent updates in MVC applications?
1531   
1532   Answer:
1533   Use Optimistic Concurrency:
1534   
1535   a. Include a hidden RowVersion field in the View.
1536   b. Compare RowVersion in the database before updating.
1537   c. If mismatch occurs, prompt user to reload data.
1538   
1539   Example View:
1540   
1541   @Html.HiddenFor(m => m.RowVersion)
1542   
1543   Example Update Action:
1544   
1545   if (dbEntry.RowVersion != model.RowVersion)
1546   {
1547       // Conflict detected
1548   }
1549   
1550   
1551   
1552   
1553   Q78. What is AntiXSS and how is it handled in MVC?
1554   
1555   Answer:
1556   AntiXSS libraries help prevent Cross-Site Scripting (XSS) attacks by encoding data 
properly.
1557   MVC already uses the AntiXSS encoder internally (in newer versions) to sanitize all 
outputs.
1558   
1559   You should:
1560   a. Always use @Model.Property in Views.
1561   b. Avoid @Html.Raw() unless absolutely needed.
1562   c. Validate user input manually if raw HTML must be allowed.
1563   
1564   
1565   
1566   
1567   Q79. What is ContentResult in MVC?
1568   
1569   Answer:
1570   ContentResult returns plain text, HTML, XML, or JSON as response instead of a View.
1571   
1572   Example:
1573   
1574   public ContentResult HelloWorld()
1575   {
1576       return Content("Hello, World!");
1577   }
1578   
1579   You can also set content type:
1580   return Content("<h1>Hello</h1>", "text/html");
1581   
1582   Note: This is useful for returning small dynamic responses without rendering a full View.
1583   
1584   
1585   
1586   
1587   Q81. How to implement custom Model Binder in MVC?
1588   
1589   Answer:
1590   Create a class that implements IModelBinder:
1591   
1592   public class CustomDateBinder : IModelBinder
1593   {
1594       public object BindModel(ControllerContext controllerContext, ModelBindingContext 
bindingContext)
1595       {
1596           var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
1597           DateTime date;
1598           if (DateTime.TryParse(value.AttemptedValue, out date))
1599               return date;
1600           return null;
1601       }
1602   }
1603   
1604   Register it in Global.asax:
1605   ModelBinders.Binders.Add(typeof(DateTime), new CustomDateBinder());
1606   
1607   Now, MVC will use your binder whenever it encounters a DateTime binding.
1608   
1609   
1610   
1611   Q82. What is Cross-Site Request Forgery (CSRF) and how does MVC prevent it?
1612   
1613   Answer:
1614   CSRF is an attack where unauthorized commands are transmitted from a user that the 
website trusts.
1615   
1616   MVC prevents it using AntiForgeryToken:
1617   
1618   @using (Html.BeginForm())
1619   {
1620       @Html.AntiForgeryToken()
1621       // Form fields
1622   }
1623   
1624   Controller must have:
1625   
1626   [HttpPost]
1627   [ValidateAntiForgeryToken]
1628   public ActionResult Save(DataModel model)
1629   {
1630       // Secure Save Logic
1631   }
1632   
1633   This ensures form submissions are genuine.
1634   
1635   
1636   
1637   Q83. How to implement Attribute Routing in MVC?
1638   
1639   Answer:
1640   Enable it in RouteConfig.cs:
1641   routes.MapMvcAttributeRoutes();
1642   
1643   Then decorate actions or controllers:
1644   [Route("products/all")]
1645   public ActionResult ListProducts()
1646   {
1647       return View();
1648   }
1649   
1650   You can also add parameters:
1651   [Route("products/{id:int}")]
1652   
1653   Note: Attribute routing gives you more control and cleaner URLs compared to 
convention-based routing.
1654   
1655   
1656   
1657   Q84. What is Html.RenderAction and Html.Action difference?
1658   
1659   Answer:
1660   
1661   Feature Html.Action Html.RenderAction
1662   =========================================================================================
============
1663   Return Type Returns MvcHtmlString (can use in Razor) Directly writes to Response 
stream
1664   Usage @Html.Action("ChildAction") @{ 
Html.RenderAction("ChildAction"); }
1665   Performance Slightly slower Slightly faster
1666   
1667   
1668   Note: Use RenderAction if you don't need to manipulate the output in Razor.
1669   
1670   
1671   
1672   Q85. How do you maintain session in ASP.NET MVC?
1673   
1674   Answer:
1675   Session is maintained using Session object:
1676   
1677   Session["Username"] = "Karthik";
1678   
1679   Retrieve it later:
1680   string username = Session["Username"] as string;
1681   
1682   Important:
1683   
1684   a. Sessions can be InProc (in memory), StateServer, or SQL Server-based.
1685   b. Use Session carefully to avoid heavy memory usage.
1686   
1687   
1688   
1689   
1690   Q86. Difference between Server.Transfer and Response.Redirect?
1691   
1692   Answer:
1693   
1694   
1695   Feature Server.Transfer Response.Redirect
1696   Action Transfers request internally Redirects to a new URL
1697   Browser URL Remains the same Changes to new URL
1698   Performance Faster (no extra round trip) Slower (new HTTP request)
1699   
1700   Note: Server.Transfer is rarely used in MVC. Response.Redirect is more common when you 
need to move to a different URL.
1701   
1702   
1703   
1704   
1705   Q87. How do you create strongly typed views in MVC?
1706   
1707   Answer:
1708   At the top of the View, declare the Model type:
1709   
1710   @model MyProject.Models.Product
1711   
1712   Then use:
1713   
1714   @Html.DisplayFor(m => m.Name)
1715   @Html.EditorFor(m => m.Price)
1716   
1717   Strongly typed views provide:
1718   
1719   a. IntelliSense support
1720   b. Compile-time checking
1721   c. Better maintainability
1722   
1723   
1724   
1725   
1726   Q88. How do you validate a Model using Data Annotations?
1727   
1728   Answer:
1729   In Model class:
1730   
1731   public class Product
1732   {
1733       [Required]
1734       public string Name { get; set; }
1735   
1736       [Range(1, 1000)]
1737       public decimal Price { get; set; }
1738   }
1739   
1740   In Controller:
1741   
1742   if (ModelState.IsValid)
1743   {
1744       // Save to database
1745   }
1746   
1747   MVC will automatically validate based on the annotations.
1748   
1749   
1750   
1751   
1752   Q89. What is Razor View Engine?
1753   
1754   Answer:
1755   Razor is a markup syntax that lets you embed server-side code into web pages using @.
1756   
1757   Example:
1758   
1759   <p>Hello, @Model.Name</p>
1760   
1761   Benefits:
1762   
1763   a. Lightweight and clean
1764   b. Easy to read
1765   c. Intellisense support
1766   d. Faster than old WebForms syntax
1767   
1768   Note: Razor engine compiles Views into C# classes behind the scenes.
1769   
1770   
1771   
1772   
1773   Q90. How do you pass data from Controller to View in MVC?
1774   
1775   Answer:
1776   You can use:
1777   a. ViewBag: ViewBag.Message = "Hello";
1778   b. ViewData: ViewData["Message"] = "Hello";
1779   c. TempData (for redirect scenarios)
1780   d. Model (preferred for large structured data)
1781   
1782   Example:
1783   
1784   return View(model);
1785   
1786   And in View:
1787   @Model.PropertyName
1788   
1789   Note: Passing strongly typed Models is considered the best practice.
1790   
1791   
1792   
1793   
1794   Q91. What are View Components in ASP.NET Core MVC?
1795   
1796   Answer:
1797   View Components are similar to Partial Views but with more power:
1798   
1799   They have their own logic (like mini-controllers).
1800   
1801   They don’t participate in routing.
1802   
1803   Create a View Component:
1804   public class CartSummaryViewComponent : ViewComponent
1805   {
1806       public IViewComponentResult Invoke()
1807       {
1808           var cartCount = 5; // Fetch from DB or Session
1809           return View(cartCount);
1810       }
1811   }
1812   
1813   Invoke it in a View:
1814   @await Component.InvokeAsync("CartSummary")
1815   
1816   Note: Perfect for building dynamic widgets like shopping carts, side menus, etc.
1817   
1818   
1819   
1820   
1821   Q92. What is Middleware in ASP.NET Core MVC?
1822   
1823   Answer:
1824   Middleware is software that sits in the request pipeline to handle HTTP requests and 
responses.
1825   
1826   Example custom middleware:
1827   
1828   public class RequestLoggerMiddleware
1829   {
1830       private readonly RequestDelegate _next;
1831   
1832       public RequestLoggerMiddleware(RequestDelegate next)
1833       {
1834           _next = next;
1835       }
1836   
1837       public async Task Invoke(HttpContext context)
1838       {
1839           Console.WriteLine("Request: " + context.Request.Path);
1840           await _next(context);
1841       }
1842   }
1843   
1844   Configure in Startup.cs:
1845   app.UseMiddleware<RequestLoggerMiddleware>();
1846   
1847   Middlewares are key for Cross-Cutting Concerns (logging, authentication, error handling).
1848   
1849   
1850   
1851   Q93. What is the difference between AddMvc() and AddControllersWithViews()?
1852   
1853   Answer:
1854   
1855   
1856   Aspect AddMvc() AddControllersWithViews()
1857   Services Added Controller + View + API + Razor Pages Controller + View Only
1858   Razor Pages Support Yes No
1859   Use When Building MVC + Razor Pages app Building pure MVC app
1860   
1861   
1862   Note: In newer ASP.NET Core versions, prefer AddControllersWithViews() if you are only 
doing MVC (no Razor Pages).
1863   
1864   
1865   
1866   Q94. How can you validate complex nested Models in MVC?
1867   
1868   Answer:
1869   Use IValidatableObject in the parent Model:
1870   
1871   public class Order : IValidatableObject
1872   {
1873       public Customer CustomerInfo { get; set; }
1874       public List<Product> Products { get; set; }
1875   
1876       public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
1877       {
1878           if (Products.Count == 0)
1879               yield return new ValidationResult("At least one product is required.");
1880       }
1881   }
1882   
1883   This allows you to define cross-field validation inside your Model itself.
1884   
1885   
1886   
1887   Q95. What is the Repository Pattern in MVC?
1888   
1889   Answer:
1890   Repository Pattern abstracts data access logic from business logic.
1891   
1892   Example interface:
1893   
1894   public interface IProductRepository
1895   {
1896       IEnumerable<Product> GetAll();
1897       Product GetById(int id);
1898   }
1899   
1900   Concrete implementation:
1901   
1902   public class ProductRepository : IProductRepository
1903   {
1904       public IEnumerable<Product> GetAll()
1905       {
1906           // Fetch from DB
1907       }
1908   }
1909   
1910   Controller uses Repository:
1911   
1912   private readonly IProductRepository _repo;
1913   public ProductController(IProductRepository repo)
1914   {
1915       _repo = repo;
1916   }
1917   
1918   Advantages:
1919   a. Loose coupling
1920   b. Easier testing
1921   c. Code reuse
1922   
1923   Q96. How do you handle multiple Submit buttons in MVC forms?
1924   
1925   Answer:
1926   Use name and value attributes and detect in Controller:
1927   
1928   <form method="post"> 
1929   <button name="action" value="Save">Save</button> 
1930   <button name="action" value="Cancel">Cancel</button> 
1931   </form>
1932   
1933   Controller:
1934   
1935   [HttpPost]
1936   public ActionResult Submit(string action)
1937   {
1938       if (action == "Save")
1939           // Save logic
1940       else if (action == "Cancel")
1941           // Cancel logic
1942       return View();
1943   }
1944   
1945   Simple and effective way to differentiate buttons.
1946   
1947   
1948   
1949   
1950   Q97. What is Kestrel in ASP.NET Core?
1951   
1952   Answer:
1953   Kestrel is the cross-platform web server used internally by ASP.NET Core.
1954   
1955   a. Lightweight
1956   b. High-performance
1957   c. Handles HTTP traffic
1958   d. Can be used directly or behind IIS, Nginx, Apache, etc.
1959   
1960   You configure it in Program.cs:
1961   builder.WebHost.UseKestrel();
1962   
1963   
1964   
1965   Q98. What is API Versioning in Web API?
1966   
1967   Answer:
1968   API Versioning allows you to maintain multiple versions of your Web APIs without 
      breaking existing clients.
1969   
1970   Install package:
1971   Microsoft.AspNetCore.Mvc.Versioning
1972   
1973   Configure in Startup.cs:
1974   services.AddApiVersioning(options =>
1975   {
1976       options.AssumeDefaultVersionWhenUnspecified = true;
1977       options.DefaultApiVersion = new ApiVersion(1, 0);
1978   });
1979   
1980   Decorate Controllers:
1981   [ApiVersion("1.0")]
1982   [Route("api/v{version:apiVersion}/products")]
1983   public class ProductsV1Controller : ControllerBase
1984   
1985   Now you can support /api/v1/products.
1986   
1987   
1988   
1989   
1990   Q99. What are Razor Pages in ASP.NET Core MVC?
1991   
1992   Answer:
1993   Razor Pages are a new way of building Web UIs in ASP.NET Core:
1994   
1995   a. Page-focused
1996   b. File-based (.cshtml + .cshtml.cs)
1997   c. No need for separate Controller classes
1998   
1999   Example page:
2000   
2001   /Pages/Products.cshtml
2002   
2003   @page
2004   @model ProductsModel
2005   
2006   <h2>Products</h2>
2007   PageModel (Products.cshtml.cs):
2008   
2009   public class ProductsModel : PageModel
2010   {
2011       public void OnGet()
2012       {
2013           // Load products
2014       }
2015   }
2016   
2017   Note: Perfect for simple CRUD apps!
2018   
2019   
2020   
2021   
2022   Q100. What are the best practices you should follow in ASP.NET MVC?
2023   
2024   Answer:
2025   
2026   a. Always validate user input both on client and server side.
2027   b. Use strongly-typed views, avoid using ViewBag/ViewData unless necessary.
2028   c. Avoid putting business logic in Controllers; use Services.
2029   d. Secure your application with AntiForgeryTokens.
2030   e. Use Dependency Injection for better testability.
2031   f. Apply appropriate Filters (Authorization, Exception Handling).
2032   g. Optimize performance with Output Caching and Bundling.
2033   h. Keep Controllers thin, Services thick (Fat Model - Thin Controller principle).
2034   i. Use Repository Pattern and Unit of Work for data access abstraction.
2035   j. Implement proper error handling and logging (Exception Filters, Global.asax).
2036   











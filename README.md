# AspnetMicroservices
AspnetMicroservices

![image](https://user-images.githubusercontent.com/16746699/148365581-775209a3-1ebc-434c-b95b-d46756aff3d6.png)

Steps

docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d


Endpoints:

    Catalog API -> http://host.docker.internal:8000/swagger/index.html

    Basket API -> http://host.docker.internal:8001/swagger/index.html

    Discount API -> http://host.docker.internal:8002/swagger/index.html

    Ordering API -> http://host.docker.internal:8004/swagger/index.html

    Shopping.Aggregator -> http://host.docker.internal:8005/swagger/index.html

    API Gateway -> http://host.docker.internal:8010/Catalog

    Rabbit Management Dashboard -> http://host.docker.internal:15672 -- guest/guest

    Portainer -> http://host.docker.internal:9000 -- admin/admin1234

    pgAdmin PostgreSQL -> http://host.docker.internal:5050 -- onlinestudio22@gmail.com/admin1234

    Elasticsearch -> http://host.docker.internal:9200

    Kibana -> http://host.docker.internal:5601

    Web Status -> http://host.docker.internal:8007

    Web UI -> http://host.docker.internal:8006

    Launch http://host.docker.internal:8007 --health check
    Launch http://host.docker.internal:8006 -- WebUI




Catalog microservice;

    .NET Core 6 Web API application
    REST API principles, CRUD operations
    MongoDB
    Repository Pattern Implementation
    Swagger

Basket microservice;

    .NET Core 6 Web API application
    REST API CRUD operations
    Redis
    Consume Discount Grpc Service for inter-service sync communication to calculate product final price
    MassTransit and RabbitMQ Integration
    Swagger

Discount microservice;

    .NET Core 6 Web API application
    Grpc Server application
    Dapper for micro-orm
    PostgreSQL
    Swagger

Microservices Communication

    gRPC Communication
    RabbitMQ Message-Broker Service async
    Using MassTransit for abstraction over RabbitMQ Message-Broker system
    Swagger

Ordering Microservice

    Implementing DDD, CQRS, and Clean Architecture, Mediator pattern
    MediatR, FluentValidation + AutoMapper packages
    MassTransit-RabbitMQ Configuration -> interchangeable service bus pattern
    SqlServer
    Entity Framework Core ORM and auto migrate
    Swagger

API Gateway Ocelot Microservice

    Implement API Gateways with Ocelot
    Sample microservices/containers to reroute through the API Gateways
    Shopping.Aggregator -> Gateway aggregation pattern 

WebUI ShoppingApp Microservice

    ASP.NET Core Web Application with Bootstrap 4 and Razor
    Ocelot APIs with HttpClientFactory and Polly
    Blazor and React Implementations

Monitoring

   Elastic Stack (ELK); Elasticsearch, Logstash, Kibana and SeriLog for Microservices
   HealthChecks feature in back-end ASP.NET microservices
   Watchdog

Resilience

   IHttpClientFactory
   Polly
   Retry and Circuit Breaker patterns

Ancillary Containers

   Portainer 
   MongoClient
   pgAdmin


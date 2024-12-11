using Projects;

var builder = DistributedApplication.CreateBuilder(args);
builder.AddProject<MicroServiceWirhAspireProductWebApi>("product-webapi");
builder.AddProject<MicroServiceWirhAspireCategoryWebApi>("category-webapi");
builder.AddProject<MicroServiceWirhAspireGatewayWebApi>("gateway-webapi");
builder.Build().Run();

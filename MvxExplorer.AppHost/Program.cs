var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.MvxExplorer_ApiService>("apiservice");

builder.AddProject<Projects.MvxExplorer_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();

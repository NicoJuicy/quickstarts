using Dapr.Workflow;
using Monitor;
using Monitor.Activities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDaprWorkflow(options =>
{
    options.RegisterWorkflow<MonitorWorkflow>();
    options.RegisterActivity<CheckStatus>();
});
var app = builder.Build();

app.MapPost("/start/{counter}", async (
    int counter,
    DaprWorkflowClient workflowClient) =>
{
    var instanceId = await workflowClient.ScheduleNewWorkflowAsync(
        name: nameof(MonitorWorkflow),
        input: counter);

    return Results.Accepted(instanceId);
});

app.Run();

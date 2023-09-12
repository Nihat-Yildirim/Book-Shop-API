using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting.Json;
using Serilog.Sinks.MSSqlServer;
using Serilog.Sinks.MSSqlServer.Sinks.MSSqlServer.Options;
using System.Collections.ObjectModel;
using System.Data;

namespace BookShopAPI.API.Extensions
{
    public static class HostBuilderExtensions
    {
        public static void ConfigureLogger(this IHostBuilder host, WebApplicationBuilder application)
        {
            SinkOptions sinkOptions = new();
            sinkOptions.AutoCreateSqlTable = true;
            sinkOptions.TableName = "Logs";

            ColumnOptions columnOptions = new()
            {
                AdditionalColumns = new Collection<SqlColumn>
                {
                    new SqlColumn{DataType = SqlDbType.VarChar , ColumnName = "UserName", AllowNull = true},
                    new SqlColumn{DataType = SqlDbType.VarChar , ColumnName = "ExceptionStackTrace", AllowNull = true},
                    new SqlColumn{DataType = SqlDbType.VarChar , ColumnName = "SimpleMessage", AllowNull=true},
                }
            };

            columnOptions.Store.Remove(StandardColumn.MessageTemplate);
            columnOptions.Store.Remove(StandardColumn.Properties);

            Logger logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(new JsonFormatter(), $"Logs/ImportantLogs/important.json", restrictedToMinimumLevel: LogEventLevel.Warning)
                .WriteTo.File($"Logs/AllLogs/all-.log", rollingInterval: RollingInterval.Day)
                .WriteTo.MSSqlServer(application.Configuration.GetConnectionString("SQLConnection"), sinkOptions: sinkOptions, columnOptions: columnOptions)
                .MinimumLevel.Information()
                .Enrich.FromLogContext()
                .CreateLogger();

            logger.Information("Uygulama çalışmaya başladı");
            host.UseSerilog(logger);
        }
    }
}
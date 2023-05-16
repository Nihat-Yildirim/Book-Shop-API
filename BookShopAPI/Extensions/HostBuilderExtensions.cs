using Microsoft.Extensions.Hosting;
using Autofac.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.DependencyResolvers.Autofac;
using Serilog.Core;
using Serilog;
using Core.Utilities.Configurations;
using Serilog.Sinks.MSSqlServer.Sinks.MSSqlServer.Options;
using Serilog.Sinks.MSSqlServer;
using System.Data;
using System.Collections.ObjectModel;
using Core.CrossCuttingConcerns.Logging.Serilog;

namespace BookShopAPI.Extensions
{
    public static class HostBuilderExtensions
    {
        public static void ConfigureAutofacProviderFactory(this IHostBuilder host)
        {
            host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterModule(new AutoFacBusinessModule());
                });
        }

        public static void ConfigureLogger(this IHostBuilder host)
        {
            var sinkOptions = new SinkOptions();
            sinkOptions.AutoCreateSqlTable = true;
            sinkOptions.TableName = "Logs";

            var columnOptions = new ColumnOptions
            {
                AdditionalColumns = new Collection<SqlColumn>
                {
                    new SqlColumn{DataType = SqlDbType.VarChar,ColumnName = "UserName",AllowNull = true},
                    new SqlColumn{DataType = SqlDbType.VarChar,ColumnName = "MethodName",AllowNull = true},
                    new SqlColumn{DataType = SqlDbType.VarChar,ColumnName = "ExceptionStackTrace",AllowNull = true},
                    new SqlColumn{DataType = SqlDbType.VarChar,ColumnName = "SimpleMessage",AllowNull = true}
                }
            };

            columnOptions.Store.Remove(StandardColumn.MessageTemplate);
            columnOptions.Store.Remove(StandardColumn.Properties);

            Logger logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.MSSqlServer(Connection.ConnectionString,sinkOptions: sinkOptions, columnOptions: columnOptions)
                .MinimumLevel.Information()
                .Enrich.FromLogContext()
                .CreateLogger();

            host.UseSerilog(logger);

            SerilogLogger.ConfigureLogger(logger);
        }
    }
}
#if NETCOREAPP3_1
using System;
using System.Linq;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Magicodes.SwaggerUI
{

    public class SwaggerEnumSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type == null)
            {
                return;
            }

            var type = Nullable.GetUnderlyingType(context.Type) ?? context.Type;
            if (!type.IsEnum || schema.Extensions.ContainsKey("x-enumNames"))
            {
                return;
            }

            var enumNames = new OpenApiArray();
            enumNames.AddRange(Enum.GetNames(type).Select(_ => new OpenApiString(_)));
            schema.Extensions.Add("x-enumNames", enumNames);
            schema.Extensions.Add(
                "x-ms-enum",
                new OpenApiObject
                {
                    ["name"] = new OpenApiString(type.Name),
                    ["modelAsString"] = new OpenApiBoolean(true)
                }
            );
        }
    }
}
#endif

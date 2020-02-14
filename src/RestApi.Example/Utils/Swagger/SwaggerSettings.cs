using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace RestApi.Example.Utils.Swagger
{
    /// <summary>
    /// Swagger Configuration
    /// </summary>
    public class SwaggerSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerSettings"/> class.
        /// </summary>
        public SwaggerSettings()
        {
            Name = "REST API Example";
            Title = "REST API Example";
            Description = "REST API Versions";

        }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        public string Title { get;  }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets or sets document Name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets or sets swagger Info.
        /// </summary>
        public OpenApiInfo GetOpenApiInfo(string version, bool isDeprecated)
        {
            return new OpenApiInfo
            {
                Description = Description + (isDeprecated ? " - DEPRECATED" : ""),
                Title = Title,
                Version = version
            };
        }

        /// <summary>
        /// Gets or sets RoutePrefix.
        /// </summary>
        public string RoutePrefix { get; set; }

        /// <summary>
        /// Gets Route Prefix with tailing slash.
        /// </summary>
        public string RoutePrefixWithSlash =>
            string.IsNullOrWhiteSpace(RoutePrefix)
                ? string.Empty
                : RoutePrefix + "/";
    }
}
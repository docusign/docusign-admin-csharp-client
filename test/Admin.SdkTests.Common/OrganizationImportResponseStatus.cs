using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Admin.SdkTests.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrganizationImportResponseStatus
    {
        unknown,
        queued,
        processed_with_issues,
        processed_with_errors,
        failed,
        completed,
        in_process,
        timed_out_queued,
    }
}

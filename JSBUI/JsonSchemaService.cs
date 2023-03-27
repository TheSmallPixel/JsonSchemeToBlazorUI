using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSBUI
{

    public class JsonSchemaService
    {
        public JsonSchema LoadSchema(string jsonSchema)
        {
            return JsonConvert.DeserializeObject<JsonSchema>(jsonSchema);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSBUI
{

    public class JsonSchema
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public List<string> Required { get; set; }
        public Dictionary<string, JsonSchemaProperty> Properties { get; set; }
    }

    public class JsonSchemaProperty : JsonSchema
    {
        public string Description { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public List<string> Enum { get; set; }
    }
}

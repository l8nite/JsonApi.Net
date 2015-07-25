﻿using System.Collections.Generic;
using System.Linq;

namespace JsonApi.Components
{
    public class JsonApiErrors : List<JsonApiError>
    {
        public string Message
        {
            get { return string.Join("\n", this.Select(e => e.Message)); }
        }
    }
}
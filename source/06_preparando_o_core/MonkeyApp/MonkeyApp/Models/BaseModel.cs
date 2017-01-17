using System;

namespace MonkeyApp.Models
{
    public class BaseModel
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();
    }
}

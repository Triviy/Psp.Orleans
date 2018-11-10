using Newtonsoft.Json;

namespace Psp.Core.Messages
{
    public class PspMessage
    {
        public override string ToString()
        {
            return $"{GetType().Name}: {JsonConvert.SerializeObject(this)}";
        }
    }
}
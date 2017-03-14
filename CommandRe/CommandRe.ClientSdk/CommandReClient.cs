using System;

namespace CommandRe.ClientSdk
{
    public class CommandReClient
    {
        private IOptionsBuilder _options { get; set; }
        public CommandReClient(IOptionsBuilder options)
        {
            _options = options;
        }

        public void InsertNode(string eventType, object obj)
        {
            //Call CommandRe API
        }
    }
}

namespace KukSoft.ToolKit.Logger.Public
{
    public class StandardLogFormatter : ILogFormatter
    {
        private readonly ILogFormatter _formatter;

        public StandardLogFormatter() 
            => _formatter = new Logger.StandardLogFormatter();

        public string Format(LogMessage message) 
            => _formatter.Format(message);
    }
}

using System.Linq;

namespace SwissKnife.Audit
{
    class AuditFailureFormater
    {
        public string Format(IAuditFailure error) => Format(error, 0);

        private string Format(IAuditFailure error, int indent)
        {
            string message = "~> " + error.Message + "\r\n";
            string space = string.Empty;
            indent++;

            for (int i = 0; i < indent; i++)
            {
                space += "  ";
            }

            return error.Failures.Aggregate(message, (c, f) => c + space + Format(f, indent));
        }
    }
}
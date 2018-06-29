namespace SwissKnife.Audit
{
    class StandardAuditor<TObject> : Auditor<TObject>
    {
        protected override void Checklist(TObject obj) { }
    }
}
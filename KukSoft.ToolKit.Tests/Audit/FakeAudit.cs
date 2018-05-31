using KukSoft.ToolKit.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KukSoft.ToolKit.Audit.Tests
{
    class FakeAudit : Auditor<Vector2D>
    {
        protected override void Checklist(Vector2D obj)
        {
            MustPass(v => v.Y > 0, "Y muss positiv sein");
            MustPass(v => v.X > 0, "X muss positiv sein");

            SubSequence(new FakeAudit2(), 42, "hallo");
        }
    }
    class FakeAudit2 :Auditor<int>
    {
        protected override void Checklist(int zahl)
        {
            MustPass(i => i < 0, "zahl muss negativ sein.");
        }
    }
}

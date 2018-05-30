using System;

namespace KukSoft.ToolKit.DataTypes.Public
{
    public class Switch<TObject> : ISwitch<TObject>
    {
        private readonly ISwitch<TObject> _switch;

        public Switch(TObject obj)
        {
            _switch = new DataTypes.Switch<TObject>(obj);
        }

        public ISwitch<TObject> Case(Func<TObject, bool> condition, Action<TObject> callback)
            => _switch.Case(condition, callback);

        public ISwitch<TObject> Case(TObject candidate, Action<TObject> callback)
            => _switch.Case(candidate, callback);

        public void Otherwise(Action<TObject> callback)
            => _switch.Otherwise(callback);
    }
}

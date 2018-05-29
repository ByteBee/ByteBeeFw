using System;

namespace KukSoft.ToolKit.DataTypes
{
    public interface ISwitch<TObject>
    {
        ISwitch<TObject> Case(Func<TObject, bool> condition, Action<TObject> callback);
        ISwitch<TObject> Case(TObject candidate, Action<TObject> callback);
        void Otherwise(Action<TObject> callback);
    }
}
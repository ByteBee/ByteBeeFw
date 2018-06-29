using System;

namespace SwissKnife.DataTypes
{
    public interface ISwitch<TObject>
    {
        ISwitch<TObject> Case(Func<TObject, bool> condition, Action<TObject> callback);
        ISwitch<TObject> Case(TObject candidate, Action<TObject> callback);
        void Otherwise(Action<TObject> callback);
    }

    public class Switch<TObject> : ISwitch<TObject>
    {
        private TObject _object;
        private bool _anyTrueCase;

        public Switch(TObject obj)
        {
            _object = obj;
        }

        public ISwitch<TObject> Case(Func<TObject, bool> condition, Action<TObject> callback)
        {
            if (!_anyTrueCase && condition(_object))
            {
                callback(_object);
                _anyTrueCase = true;
            }
            return this;
        }

        public ISwitch<TObject> Case(TObject candidate, Action<TObject> callback)
            => Case(obj => Equals(obj, candidate), callback);

        public void Otherwise(Action<TObject> callback)
        {
            if (!_anyTrueCase)
            {
                callback(_object);
            }
        }
    }
}

using System;

namespace ByteBee.Core.Utilities
{
    public interface ISwitch<TObject>
    {
        ISwitch<TObject> When(Func<TObject, bool> condition, Action<TObject> callback);
        ISwitch<TObject> When(TObject candidate, Action<TObject> callback);
        void Otherwise(Action<TObject> callback);
    }

    public class Switch<TObject> : ISwitch<TObject>
    {
        private TObject _object;
        private bool _anyTrueCase;
        /// <inheritdoc />
        public Switch(TObject obj)
        {
            _object = obj;
        }
        /// <inheritdoc />
        public ISwitch<TObject> When(Func<TObject, bool> condition, Action<TObject> callback)
        {
            if (!_anyTrueCase && condition(_object))
            {
                callback(_object);
                _anyTrueCase = true;
            }
            return this;
        }
        /// <inheritdoc />
        public ISwitch<TObject> When(TObject candidate, Action<TObject> callback)
            => When(obj => Equals(obj, candidate), callback);
        /// <inheritdoc />
        public void Otherwise(Action<TObject> callback)
        {
            if (!_anyTrueCase)
            {
                callback(_object);
            }
        }
    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace ByteBee.MessageBus.Impl
{
    public abstract class AbstractMessageBus : IMessageBus
    {
        private readonly ConcurrentDictionary<Type, HashSet<WeakReference>> _subscribers =
            new ConcurrentDictionary<Type, HashSet<WeakReference>>();

        private readonly object _monitor = new object();

        /// <inheritdoc />
        public void Publish<TMessage>(TMessage message) where TMessage : IMessage
        {
            Type type = typeof(IHandle<>).MakeGenericType(typeof(TMessage));
            HashSet<WeakReference> allSubscribers = GetSubscribers(type);
            HashSet<WeakReference> deadSubscribers = GetDeathSubscribers(allSubscribers);

            HashSet<WeakReference> subscribers = CleanDeadSubsriber(deadSubscribers, allSubscribers);

            InvokeMessagesOnSubscribers(message, allSubscribers);
        }

        private HashSet<WeakReference> GetDeathSubscribers(HashSet<WeakReference> subscribers)
        {
            var removable = new HashSet<WeakReference>();

            foreach (WeakReference subscriber in subscribers)
            {
                if (!subscriber.IsAlive)
                {
                    removable.Add(subscriber);
                }
            }

            return removable;
        }

        private HashSet<WeakReference> CleanDeadSubsriber(HashSet<WeakReference> deadSubscribers, HashSet<WeakReference> allSubscribers)
        {
            if (deadSubscribers.Any())
            {
                foreach (WeakReference toRemove in deadSubscribers)
                {
                    allSubscribers.Remove(toRemove);
                }
            }

            return allSubscribers;
        }

        private void InvokeMessagesOnSubscribers<TMessage>(TMessage message, HashSet<WeakReference> subscribers)
            where TMessage : IMessage
        {
            foreach (WeakReference subscriber in subscribers)
            {
                if (subscriber.IsAlive)
                {
                    var subscriberTarget = (IHandle<TMessage>)subscriber.Target;
                    Invoke(message, subscriberTarget);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TMessage"></typeparam>
        protected abstract void Invoke<TMessage>(TMessage message, IHandle<TMessage> subscriber) where TMessage : IMessage;

        /// <inheritdoc />
        public void Register(object subscriber)
        {
            IEnumerable<Type> subscriberTypes = GetSubscriberTypes(subscriber);

            foreach (Type type in subscriberTypes)
            {
                GetSubscribers(type)
                    .Add(new WeakReference(subscriber));
            }
        }

        private IEnumerable<Type> GetSubscriberTypes(object subscriber) => subscriber
            .GetType().GetInterfaces()
            .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IHandle<>));

        private HashSet<WeakReference> GetSubscribers(Type type)
        {
            HashSet<WeakReference> subscribers;
            lock (_monitor)
            {
                if (!_subscribers.TryGetValue(type, out subscribers))
                {
                    subscribers = new HashSet<WeakReference>();
                    _subscribers.TryAdd(type, subscribers);
                }
            }

            return subscribers;
        }
    }
}
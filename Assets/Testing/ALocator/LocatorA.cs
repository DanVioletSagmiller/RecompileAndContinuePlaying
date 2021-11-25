namespace A
{
    // Review: https://youtu.be/Dwj6Ryodty4?list=PLnRmXj9gwMNeFwWtX8ay6UG7mH6pRyggA)
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public interface ILocatorA
    {
        void Set<Abstraction>(Func<Abstraction> constructor) where Abstraction : class;
        void Set<Abstraction>(Abstraction value) where Abstraction : class;
        void Set<Abstraction, T>() where T : Abstraction where Abstraction : class;
        Abstraction Get<Abstraction>() where Abstraction : class;

    }

    [UnityEngine.DefaultExecutionOrder(-1000)]
    public class LocatorA : MonoBehaviour, ILocatorA
    {
        public static ILocatorA Instance;

        private Dictionary<Type, Func<object>> Map = new Dictionary<Type, Func<object>>();

        private void Awake()
        {
            Instance = this;
        }

        public void Set<Abstraction>(Func<Abstraction> constructor) where Abstraction : class
        {
            var type = typeof(Abstraction);
            if (Map.ContainsKey(type))
            {
                Map[type] = () =>
                {
                    Abstraction result = constructor();
                    Set<Abstraction>(result);
                    return result;
                };
            }
            else
            {
                Map.Add(type, () =>
                {
                    Abstraction result = constructor();
                    Set<Abstraction>(result);
                    return result;
                });
            }
        }

        public void Set<Abstraction>(Abstraction value) where Abstraction : class
        {
            var type = typeof(Abstraction);
            if (Map.ContainsKey(type))
            {
                Map[type] = () =>
                {
                    return value;
                };
            }
            else
            {
                Map.Add(type, () =>
                {
                    return value;
                });
            }
        }

        public void Set<Abstraction, T>() where T : Abstraction where Abstraction : class
        {
            var type = typeof(Abstraction);
            if (Map.ContainsKey(type))
            {
                Map[type] = () =>
                {
                    Abstraction result = Activator.CreateInstance<Abstraction>();
                    Set<Abstraction>(result);
                    return result;
                };
            }
            else
            {
                Map.Add(type, () =>
                {
                    Abstraction result = Activator.CreateInstance<Abstraction>();
                    Set<Abstraction>(result);
                    return result;
                });
            }
        }

        public Abstraction Get<Abstraction>() where Abstraction : class
        {
            var type = typeof(Abstraction);
            if (Map.ContainsKey(type))
            {
                return (Abstraction)Map[type]();
            }
            else
            {
                throw new NullReferenceException(nameof(LocatorA) + " has not been provided a setup for " + typeof(Abstraction));
            }
        }
    }
}
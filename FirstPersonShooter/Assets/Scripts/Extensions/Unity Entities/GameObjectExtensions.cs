using UnityEngine;

namespace Extensions
{
    public static class GameObjectExtensions
    {
        public static void HandleComponent<T>(this GameObject gameObject, System.Action<T> handler)
        {
            var component = gameObject.GetComponent<T>();
            if (component != null)
                handler?.Invoke(component);
        }

        public static bool ContainsComponent<T>(this GameObject gameObject)
        {
            return gameObject.GetComponent<T>() != null ? true : false;
        }
    }
}
using UnityEngine;

namespace Extensions
{
    public static class TransformExtensions
    {
        public static void HandleComponent<T>(this Transform transform, System.Action<T> handler)
        {
            var component = transform.GetComponent<T>();
            if (component != null)
                handler?.Invoke(component);
        }

        public static bool ContainsComponent<T>(this Transform transform)
        {
            return transform.GetComponent<T>() != null ? true : false;
        }
    }
}

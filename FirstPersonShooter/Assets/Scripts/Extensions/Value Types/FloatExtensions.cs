namespace Extensions
{
    public static class FloatExtensions
    {
        public static bool Compare(this float value, float other, float epsilon = 0.0001f)
        {
            float difference = UnityEngine.Mathf.Abs(value * epsilon);

            return UnityEngine.Mathf.Abs(value - other) <= difference;
        }
    }
}

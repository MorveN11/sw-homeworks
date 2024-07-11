namespace CalcValidator


{
    public static class Validator
    {
        public static bool AreEqual<T>(T value1, T value2) where T : notnull
        {
            return value1.Equals(value2);
        }
    }
}

namespace Spark.Cores
{
    public class KeyValue
    {
        public string Key { get; set; }
        public object Value { get; set; }

        public KeyValue()
        {
        }
        public KeyValue(string key,object value)
        {
            Key = key;
            Value = value;
        }
    }
}

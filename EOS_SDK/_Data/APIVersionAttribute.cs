namespace EOS_SDK._Data
{
    [AttributeUsage(AttributeTargets.Struct)]
    public class APIVersionAttribute : Attribute
    {
        public int APIVersion { get; init; }

        public APIVersionAttribute(int _APIVersion) 
        {
            APIVersion = _APIVersion;
        }
    }
}

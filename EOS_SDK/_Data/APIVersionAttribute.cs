namespace EOS_SDK._Data
{
    [AttributeUsage(AttributeTargets.Struct)]
    public class APIVersionAttribute : Attribute
    {
        public APIVersionAttribute(int APIVersion) 
        { 
        }
    }
}

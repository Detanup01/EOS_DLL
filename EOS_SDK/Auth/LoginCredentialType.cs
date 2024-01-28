namespace EOS_SDK.Auth
{
    public enum LoginCredentialType : int
    {
        Password = 0,
        ExchangeCode = 1,
        PersistentAuth = 2,
        DeviceCode = 3,
        Developer = 4,
        RefreshToken = 5,
        AccountPortal = 6,
        ExternalAuth = 7
    }
}
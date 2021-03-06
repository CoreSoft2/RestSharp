using System.Runtime.Serialization;

namespace PivotSecurity.Authenticators.OAuth
{
    [DataContract]
    public enum OAuthSignatureMethod
    {
        HmacSha1,
        HmacSha256,
        PlainText,
        RsaSha1
    }
}

using System.Text;

namespace EOS_SDK.JWT;

public class JwtHeader
{
    public JwtHeader()
    {
    
    }
    public JwtHeader(string alg)
    {
        Alg = alg;
    }

    public JwtHeader(string alg, Dictionary<string, string> otherHeaders)
    {
        Alg = alg;
        OtherHeaders = otherHeaders;
    }

    public string JWTType { get; internal set; } = "JWT";

    public string Alg { get; internal set; } = "RS256";

    public Dictionary<string, string> OtherHeaders { get; set; } = [];

    public void ClearType()
    {
        JWTType = string.Empty;
    }


    public void Write(Stream stream)
    {
        string ToWrite = "{";
        ToWrite += $"\"alg\":\"{Alg}\"";
        if (JWTType != string.Empty)
        {
            ToWrite += $",\"typ\":\"{JWTType}\"";
        }
        foreach (var item in OtherHeaders)
        {
            ToWrite += $",\"{item.Key}\":\"{item.Value}\"";
        }
        ToWrite += "}";
        var b64 = LitJWT.Base64.EncodeToBase64UrlString(Encoding.UTF8.GetBytes(ToWrite));
        if (b64.Contains("=="))
            b64 = b64.Replace("==","");
        stream.Write(Encoding.UTF8.GetBytes(b64));
        stream.Flush();
    }

    public byte[] Write()
    {
        string ToWrite = "{";
        ToWrite += $"\"alg\":\"{Alg}\"";
        if (JWTType != string.Empty)
        {
            ToWrite += $",\"typ\":\"{JWTType}\"";
        }
        foreach (var item in OtherHeaders)
        {
            ToWrite += $",\"{item.Key}\":\"{item.Value}\"";
        }
        ToWrite += "}";
        var b64 = LitJWT.Base64.EncodeToBase64UrlString(Encoding.UTF8.GetBytes(ToWrite));
        if (b64.Contains("=="))
            b64 = b64.Replace("==", "");
        return Encoding.UTF8.GetBytes(b64);
    }

    public void Read(byte[] bytes)
    {
        var header = Encoding.UTF8.GetString(bytes);
        header = header.Replace("{", "").Replace("}", "");
        var splitted = header.Split("\",\"");
        foreach (var item in splitted)
        {
            var kvs = item.Split("\":\"");
            if (kvs[0][0] == '"')
                kvs[0] = kvs[0][1..];
            if (kvs[1][kvs[1].Length - 1] == '"')
                kvs[1] = kvs[1][..(kvs[1].Length - 1)];

            if (kvs[0] == "alg")
            {
                Alg = kvs[1];
                continue;
            }

            if (kvs[0] == "typ")
            {
                JWTType = kvs[1];
                continue;
            }
            Console.WriteLine(kvs[0] + " " + kvs[1]);
            OtherHeaders.Add(kvs[0], kvs[1]);
        }
    }

    public override string ToString()
    {
        return $"JWTType: {JWTType}, Alg: {Alg}\nOtherHeaders: {string.Join(" ", OtherHeaders)}";
    }
}

namespace SimpleAdapterCSharp;
// Adaptee -> THe interface that is incompatible with the target interface
public abstract class IXmlParser<T>
{
    public abstract T Parse(string data);
    public abstract String ConvertToXml(T obj);
}
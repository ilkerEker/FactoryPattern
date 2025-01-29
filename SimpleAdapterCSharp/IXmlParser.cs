namespace SimpleAdapterCSharp;
// Adaptee -> THe interface that is incompatible with the target interface
public interface IXmlParser<T>
{
    T Parse(string data);
    String ConvertToXml(T obj);
}
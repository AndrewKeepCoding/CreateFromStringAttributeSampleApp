using Windows.Foundation.Metadata;

namespace CreateFromStringAttributeSampleApp;

[CreateFromString(MethodName = nameof(CreateFromString))]
public record Person(string FirstName, string LastName, int Age)
{
    public static Person CreateFromString(string sourceString)
    {
        string[] parts = sourceString.Split(',');
        int length = parts.Length;
        Person person = new(
            FirstName: length > 0
                ? parts[0]
                : string.Empty,
            LastName: length > 1
                ? parts[1]
                : string.Empty,
            Age: length > 2 && int.TryParse(parts[2], out int age) is true
                ? age
                : 0);
        return person;
    }
}

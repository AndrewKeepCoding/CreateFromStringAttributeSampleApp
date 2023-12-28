using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace CreateFromStringAttributeSampleApp;

public sealed partial class PersonCard : UserControl
{
    public static readonly DependencyProperty PersonProperty =
        DependencyProperty.Register(
            nameof(Person),
            typeof(Person),
            typeof(PersonCard),
            new PropertyMetadata(default));

    public PersonCard()
    {
        this.InitializeComponent();
    }

    public Person Person
    {
        get => (Person)GetValue(PersonProperty);
        set => SetValue(PersonProperty, value);
    }
}

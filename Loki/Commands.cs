using System.Windows.Input;

namespace Loki
{
    public static class Commands
    {
        public static RoutedUICommand RevertCharacter =
            new RoutedUICommand("Revert", nameof(RevertCharacter), typeof(Commands));

        public static RoutedUICommand SaveCharacter =
            new RoutedUICommand("Save", nameof(RevertCharacter), typeof(Commands));
    }
}

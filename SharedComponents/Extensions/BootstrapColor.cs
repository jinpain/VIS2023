namespace SharedComponents.Extensions
{
    public static class BootstrapColor
    {
        public enum BootstrapColorType
        {
            Primary,
            Secondary,
            Success,
            Danger,
            Warning,
            Info,
            Light,
            Dark
        }

        public static string GetTextColor(BootstrapColorType type)
        {
            return type switch
            {
                BootstrapColorType.Primary => "text-primary",
                BootstrapColorType.Secondary => "text-secondary",
                BootstrapColorType.Success => "text-success",
                BootstrapColorType.Danger => "text-danger",
                BootstrapColorType.Warning => "text-warning",
                BootstrapColorType.Info => "text-info",
                BootstrapColorType.Light => "text-light",
                BootstrapColorType.Dark => "text-dark",
                _ => "text-dark",
            };
        }
    }
}

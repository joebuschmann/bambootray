namespace Halltom.Bamboo.Tray.Services
{
    using Halltom.Bamboo.Tray.Domain.Settings;

    public interface ISettingsService
    {
        TraySettings TraySettings { get; set; }

        bool SaveTraySettings();
    }
}

using BambooTray.Domain.Settings;

namespace BambooTray.Services
{
    public interface ISettingsService
    {
        TraySettings TraySettings { get; set; }

        bool SaveTraySettings();
    }
}

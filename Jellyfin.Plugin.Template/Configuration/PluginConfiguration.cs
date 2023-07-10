using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.PhantomManga.Configuration
{
    /// <summary>
    /// Plugin configuration.
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
        /// </summary>
        public PluginConfiguration() {
            // set default options here
            TrueFalseSetting = true;
            AnInteger = 2;
            AString = "string";
        }

        /// <summary>
        /// Gets or sets a value indicating whether some true or false setting is enabled..
        /// </summary>
        public bool TrueFalseSetting { get; set; }

        /// <summary>
        /// Gets or sets an integer setting.
        /// </summary>
        public int AnInteger { get; set; }

        /// <summary>
        /// Gets or sets a string setting.
        /// </summary>
        public string AString { get; set; }
    }
}

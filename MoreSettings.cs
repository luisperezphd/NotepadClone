using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Drawing.Printing;

namespace MyNotepad.Properties {
    partial class Settings {
        // If you used [ApplicationScopedSetting()] instead of [UserScopedSetting()] you would NOT be able to persist any data changes!
        [UserScopedSetting]
        [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Binary)]
        public MoreSettings MoreSettings {
            get {
                var MoreSettings = ((MoreSettings)this["MoreSettings"]);

                if (MoreSettings == null) {
                    this["MoreSettings"] = MoreSettings = new MoreSettings();
                }

                return MoreSettings;
            }
            set {
                this["MoreSettings"] = (MoreSettings)value;
            }
        }
    }
}

namespace MyNotepad {
    [Serializable]
    public class MoreSettings {
        public PrinterSettings PrinterSettings { get; set; }
        public PageSettings PageSettings { get; set; }
    }
}

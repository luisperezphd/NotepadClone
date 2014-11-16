using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MyNotepad {
    public static class HelperExtensions {
        public static string FormatUsingObject(this string @this, object poObject) {
            var sFormatted = @this;

            foreach (var oProperty in TypeDescriptor.GetProperties(poObject).Cast<PropertyDescriptor>()) {
                sFormatted = sFormatted.Replace("{" + oProperty.Name + "}", oProperty.GetValue(poObject).ToStringOrNull());
            }

            return sFormatted;
        }

        public static string ToStringOrNull(this object @this) {
            if (@this == null) return null;
            return @this.ToString();
        }

        public static bool IsEmpty(this string @this) {
            return string.IsNullOrWhiteSpace(@this);
        }
    }
}

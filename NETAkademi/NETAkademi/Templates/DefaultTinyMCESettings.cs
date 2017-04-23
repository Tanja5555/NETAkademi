using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core.PropertySettings;
using EPiServer.Editor.TinyMCE;
using EPiServer.ServiceLocation;

//EPiServer.SpecializedProperties.PropertyXhtmlString

namespace NETAkademi.Templates
{
    [ServiceConfiguration(ServiceType = typeof(PropertySettings))]
    public class DefaultTinyMCESettings : PropertySettings<TinyMCESettings>
    {
        public DefaultTinyMCESettings()
        {
            IsDefault = true;
            DisplayName = "Default settings from code";
            Description = "This is the default settings as defined in code.";
        }

        public override TinyMCESettings GetPropertySettings()
        {
            var settings = new TinyMCESettings();

            var toolbarRow1 = new ToolbarRow(new List<string>() {
                TinyMCEButtons.StyleSelect,
                TinyMCEButtons.Bold,
                TinyMCEButtons.Italic,
                TinyMCEButtons.StrikeThrough,
                TinyMCEButtons.Separator,
                TinyMCEButtons.JustifyLeft,
                TinyMCEButtons.JustifyCenter,
                TinyMCEButtons.JustifyRight,
                TinyMCEButtons.JustifyFull,
                TinyMCEButtons.Separator,
                TinyMCEButtons.BulletedList,
                TinyMCEButtons.NumericList,
                TinyMCEButtons.Indent,
                TinyMCEButtons.Outdent
            });
            var toolbarRow2 = new ToolbarRow(new List<string>()
            {
                TinyMCEButtons.Undo,
                TinyMCEButtons.Redo,
                TinyMCEButtons.Separator,
                TinyMCEButtons.Cut,
                TinyMCEButtons.Copy,
                TinyMCEButtons.Paste,
                TinyMCEButtons.Separator,
                TinyMCEButtons.EPiServerLink,
                TinyMCEButtons.Unlink,
                TinyMCEButtons.Image,
                TinyMCEButtons.Media,
                TinyMCEButtons.EPiServerQuote,
                TinyMCEButtons.EPiServerPersonalizedContent,
                TinyMCEButtons.Code
            });

            settings.ToolbarRows.Add(toolbarRow1);
            settings.ToolbarRows.Add(toolbarRow2);

            settings.Height = 20;
            settings.Width = 200;

            return settings;
        }

        public override System.Guid ID

        {
            get { return new System.Guid("a6fe936f-190d-45e2-b83c-ccc0501a7312"); }
        }
    }
}
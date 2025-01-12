using System;
using Consolonia.Core.Styles;

namespace Consolonia.Themes.TurboVision.Templates
{
    public class TurboVisionTheme : ResourceIncludeBase
    {
        public TurboVisionTheme(Uri baseUri) : base(baseUri)
        {
        }

        public TurboVisionTheme(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override Uri Uri => new(@"avares://Consolonia.Themes.TurboVision/Templates/TurboVision.axaml");
    }
}
using SharpShell.Attributes;
using SharpShell.SharpDeskBand;
using System.Runtime.InteropServices;

namespace WebSearchDeskBand
{
    /// <summary>
    /// A simple DeskBank extension which shows a Web Search bar.
    /// </summary>
    /// <seealso cref="SharpShell.SharpDeskBand.SharpDeskBand" />
    [ComVisible(true)]
    [DisplayName("Web Search")]
    [Guid("3F8FA992-BB12-4007-BD8E-AD7F6D1D9BA4")]
    public class WebSearchDeskBand : SharpDeskBand
    {
        /// <summary>
        /// This function should return a new instance of the desk band's user interface,
        /// which will simply be a usercontrol.
        /// </summary>
        /// <returns></returns>
        protected override System.Windows.Forms.UserControl CreateDeskBand()
        {
            return new DeskBandUI();
        }

        /// <summary>
        /// Gets the band options.
        /// </summary>
        /// <returns>
        /// The band options. See <see cref="T:SharpShell.SharpDeskBand.BandOptions" /> for more details.
        /// </returns>
        protected override BandOptions GetBandOptions()
        {
            return new BandOptions
                   {
                       HasVariableHeight = false,
                       IsSunken = false,
                       ShowTitle = true,
                       Title = "Web Search",
                       UseBackgroundColour = false,
                       AlwaysShowGripper = true
                   };
        }
   }
}

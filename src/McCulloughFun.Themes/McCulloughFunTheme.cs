using MudBlazor;

namespace McCulloughFun.Themes
{
    public class McCulloughFunTheme : MudTheme
    {
        private const string _primaryBlue = "#4FA1FF";
        private const string _secondaryBlue = "#1A3656";
        public McCulloughFunTheme()
        {
            Palette = new Palette()
            {
                Primary = _primaryBlue,
                AppbarBackground = "#FFFFFF"
            };

            Shadows = new Shadow();
            Typography = new Typography();
            LayoutProperties = new LayoutProperties();
            ZIndex = new ZIndex();
        }
    }
}
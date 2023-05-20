namespace ProjectUI.UIComponents;

public class MenuColorTable : ProfessionalColorTable
{
    public MenuColorTable(bool isMainMenu, Color primaryColor)
    {
        if (isMainMenu)
        {
            ToolStripDropDownBackground = Color.FromArgb(37, 39, 60);
            Color.FromArgb(32, 33, 51);
            MenuBorder = Color.FromArgb(32, 33, 51);
            MenuItemBorder = primaryColor;
            MenuItemSelected = primaryColor;
        }
        else
        {
            ToolStripDropDownBackground = Color.White;
            MenuBorder = Color.LightGray;
            MenuItemBorder = primaryColor;
            MenuItemSelected = primaryColor;
        }
    }

    #region -> Overrides
    public override Color ToolStripDropDownBackground { get; }
    public override Color MenuBorder { get; }
    public override Color MenuItemBorder { get; }
    public override Color MenuItemSelected { get; }
    public override Color ImageMarginGradientBegin { get; }
    public override Color ImageMarginGradientMiddle { get; }
    public override Color ImageMarginGradientEnd { get; }
    #endregion
}

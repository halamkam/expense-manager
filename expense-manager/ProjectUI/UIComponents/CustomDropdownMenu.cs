using System.ComponentModel;

namespace ProjectUI.UIComponents;

public class CustomDropdownMenu : ContextMenuStrip
{
    private Bitmap _menuItemHeaderSize;

    public CustomDropdownMenu(IContainer container)
        : base(container) { }

    #region -> Properties

    [Browsable(false)]
    public bool IsMainMenu { get; set; }

    [Browsable(false)]
    public int MenuItemHeight { get; set; } = 25;

    [Browsable(false)]
    public Color MenuItemTextColor { get; set; } = Color.Empty;

    [Browsable(false)]
    public Color PrimaryColor { get; set; } = Color.Empty;
    #endregion

    #region -> Methods
    private void LoadMenuItemHeight()
    {
        _menuItemHeaderSize = IsMainMenu ? new Bitmap(25, 45) : new Bitmap(20, MenuItemHeight);

        foreach (ToolStripMenuItem menuItemL1 in Items)
        {
            menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
            menuItemL1.Image ??= _menuItemHeaderSize;

            foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
            {
                menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                menuItemL2.Image ??= _menuItemHeaderSize;

                foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems)
                {
                    menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
                    menuItemL3.Image ??= _menuItemHeaderSize;

                    foreach (ToolStripMenuItem menuItemL4 in menuItemL3.DropDownItems)
                    {
                        menuItemL4.ImageScaling = ToolStripItemImageScaling.None;
                        menuItemL4.Image ??= _menuItemHeaderSize;
                    }
                }
            }
        }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        if (DesignMode) return;
        Renderer = new MenuRenderer(IsMainMenu, PrimaryColor, MenuItemTextColor);
        LoadMenuItemHeight();
    }
    #endregion
}

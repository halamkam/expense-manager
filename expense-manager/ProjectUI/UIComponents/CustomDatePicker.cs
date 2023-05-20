using System.Drawing.Drawing2D;

namespace ProjectUI.UIComponents;

public sealed class CustomDatePicker : DateTimePicker
{
    #region -> Fields
    private Color _skinColor = Color.MediumSlateBlue;
    private Color _textColor = Color.White;
    private Color _borderColor = Color.PaleVioletRed;
    private int _borderSize;
    private bool _droppedDown;
    private Image _calendarIcon = Properties.Resources.calendarWhite;
    private RectangleF _iconButtonArea;
    private const int CalendarIconWidth = 34;
    private const int ArrowIconWidth = 17;
    #endregion

    public CustomDatePicker()
    {
        SetStyle(ControlStyles.UserPaint, true);
        MinimumSize = new Size(0, 35);
        Font = new Font(Font.Name, 9.5F);
    }

    #region -> Properties
    public Color SkinColor
    {
        get => _skinColor;
        set
        {
            _skinColor = value;
            _calendarIcon = _skinColor.GetBrightness() >= 0.6F ? Properties.Resources.calendarDark : Properties.Resources.calendarWhite;
            Invalidate();
        }
    }

    public Color TextColor
    {
        get => _textColor;
        set
        {
            _textColor = value;
            Invalidate();
        }
    }

    public Color BorderColor
    {
        get => _borderColor;
        set
        {
            _borderColor = value;
            Invalidate();
        }
    }

    public int BorderSize
    {
        get => _borderSize;
        set
        {
            _borderSize = value;
            Invalidate();
        }
    }
    #endregion

    #region -> Methods
    protected override void OnDropDown(EventArgs eventargs)
    {
        base.OnDropDown(eventargs);
        _droppedDown = true;
    }
    protected override void OnCloseUp(EventArgs eventargs)
    {
        base.OnCloseUp(eventargs);
        _droppedDown = false;
    }
    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);
        e.Handled = true;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        using var graphics = CreateGraphics();
        using var penBorder = new Pen(_borderColor, _borderSize);
        using var skinBrush = new SolidBrush(_skinColor);
        using var openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64));
        using var textBrush = new SolidBrush(_textColor);
        using var textFormat = new StringFormat();
        var clientArea = new RectangleF(0, 0, Width - 0.5F, Height - 0.5F);
        var iconArea = new RectangleF(clientArea.Width - CalendarIconWidth, 0, CalendarIconWidth, clientArea.Height);
        penBorder.Alignment = PenAlignment.Inset;
        textFormat.LineAlignment = StringAlignment.Center;

        // Draw surface
        graphics.FillRectangle(skinBrush, clientArea);
        // Draw text
        graphics.DrawString("   " + Text, Font, textBrush, clientArea, textFormat);
        // Draw open calendar icon highlight
        if (_droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
        // Draw border 
        if (_borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
        // Draw icon
        graphics.DrawImage(_calendarIcon, Width - _calendarIcon.Width - 9, (Height - _calendarIcon.Height) / 2);
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        var iconWidth = GetIconButtonWidth();
        _iconButtonArea = new RectangleF(Width - iconWidth, 0, iconWidth, Height);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        Cursor = _iconButtonArea.Contains(e.Location) ? Cursors.Hand : Cursors.Default;
    }

    private int GetIconButtonWidth()
    {
        var textWidth = TextRenderer.MeasureText(Text, Font).Width;
        return textWidth <= Width - (CalendarIconWidth + 20) ? CalendarIconWidth : ArrowIconWidth;
    }
    #endregion
}

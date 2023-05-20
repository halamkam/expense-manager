using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ProjectUI.UIComponents;

public sealed class CustomButton : Button
{
    # region -> Fields
    private int _borderSize;
    private int _borderRadius = 20;
    private Color _borderColor = Color.PaleVioletRed;

    #endregion

    public CustomButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Size = new Size(150, 40);
        BackColor = Color.MediumSlateBlue;
        ForeColor = Color.White;
        Resize += Button_Resize!;
    }

    # region -> Properties
    [Category("CustomButton Properties")]
    public int BorderSize
    {
        get => _borderSize;
        set
        {
            _borderSize = value;
            Invalidate();
        }
    }

    [Category("CustomButton Properties")]
    public int BorderRadius
    {
        get => _borderRadius;
        set
        {
            _borderRadius = value;
            Invalidate();
        }
    }

    [Category("CustomButton Properties")]
    public Color BorderColor
    {
        get => _borderColor;
        set
        {
            _borderColor = value;
            Invalidate();
        }
    }
    [Category("CustomButton Properties")]
    public Color BackgroundColor
    {
        get => BackColor;
        set => BackColor = value;
    }

    [Category("CustomButton Properties")]
    public Color TextColor
    {
        get => ForeColor;
        set => ForeColor = value;
    }

    #endregion

    #region -> Methods

    private void Button_Resize(object sender, EventArgs e)
    {
        if (_borderRadius > Height)
            _borderRadius = Height;
    }

    private static GraphicsPath GetFigurePath(Rectangle rect, float radius)
    {
        var path = new GraphicsPath();
        var curveSize = radius * 2F;

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        var rectSurface = ClientRectangle;
        var rectBorder = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize);
        var smoothSize = 2;
        if (_borderSize > 0)
            smoothSize = _borderSize;

        if (_borderRadius > 2)  // Rounded button
        {
            using var pathSurface = GetFigurePath(rectSurface, _borderRadius);
            using var pathBorder = GetFigurePath(rectBorder, _borderRadius - _borderSize);
            using var penSurface = new Pen(Parent.BackColor, smoothSize);
            using var penBorder = new Pen(_borderColor, _borderSize);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Button surface
            Region = new Region(pathSurface);

            // Draw surface border for HD result
            pevent.Graphics.DrawPath(penSurface, pathSurface);

            // Button border                    
            if (_borderSize >= 1)
                // Draw control border
                pevent.Graphics.DrawPath(penBorder, pathBorder);
        }
        else // Normal button
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.None;

            // Button surface
            Region = new Region(rectSurface);

            // Button border
            if (_borderSize < 1) return;

            using var penBorder = new Pen(_borderColor, _borderSize);
            penBorder.Alignment = PenAlignment.Inset;
            pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
        }
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        Parent.BackColorChanged += Container_BackColorChanged!;
    }

    private void Container_BackColorChanged(object sender, EventArgs e)
    {
        Invalidate();
    }

    #endregion
}


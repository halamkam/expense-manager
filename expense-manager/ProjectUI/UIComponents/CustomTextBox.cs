using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ProjectUI.UIComponents;

[DefaultEvent("TextChanged")]
public partial class CustomTextBox : UserControl
{
    # region -> Fields

    private Color _borderColor = Color.MediumSlateBlue;
    private int _borderSize = 2;
    private bool _underlinedStyle;
    private Color _borderFocusColor = Color.HotPink;
    private bool _isFocused;

    private int _borderRadius;
    private Color _placeholderColor = Color.DarkGray;
    private string _placeholderText = "";
    private bool _isPlaceholder;
    private bool _isPasswordChar;

    # endregion

    public CustomTextBox()
    {
        InitializeComponent();
    }

    # region -> Events

    public new event EventHandler? TextChanged;

    # endregion

    #region -> Properties

    [Category("Custom TextBox Properties")]
    public Color BorderColor
    {
        get => _borderColor;
        set
        {
            _borderColor = value;
            Invalidate();
        }
    }

    [Category("Custom TextBox Properties")]
    public int BorderSize
    {
        get => _borderSize;
        set
        {
            _borderSize = value;
            Invalidate();
        }
    }

    [Category("Custom TextBox Properties")]
    public bool UnderlinedStyle
    {
        get => _underlinedStyle;
        set
        {
            _underlinedStyle = value;
            Invalidate();
        }
    }

    [Category("Custom TextBox Properties")]
    public bool PasswordChar
    {
        get => _isPasswordChar;
        set
        {
            _isPasswordChar = value;
            TextBox.UseSystemPasswordChar = value;
        }
    }

    [Category("Custom TextBox Properties")]
    public bool Multiline
    {
        get => TextBox.Multiline;
        set => TextBox.Multiline = value;
    }

    [Category("Custom TextBox Properties")]
    public override Color BackColor
    {
        get => base.BackColor;
        set
        {
            base.BackColor = value;
            TextBox.BackColor = value;
        }
    }

    [Category("Custom TextBox Properties")]
    public override Color ForeColor
    {
        get => base.ForeColor;
        set
        {
            base.ForeColor = value;
            TextBox.ForeColor = value;
        }
    }

    [Category("Custom TextBox Properties")]
    public override Font Font
    {
        get => base.Font;
        set
        {
            base.Font = value;
            TextBox.Font = value;

            if (DesignMode)
            {
                UpdateControlHeight();
            }
        }
    }

    [Category("Custom TextBox Properties")]
    public override string Text
    {
        get
        {
            if (_isPlaceholder)
            {
                return "";
            }
            return TextBox.Text;
        }
        set
        {
            TextBox.Text = value;
            SetPlaceholder();
        }
    }

    [Category("Custom TextBox Properties")]
    public Color BorderFocusColor
    {
        get => _borderFocusColor;
        set
        {
            _borderFocusColor = value;
            if (_isPlaceholder)
            {
                TextBox.ForeColor = value;
            }
        }
    }

    [Category("Custom TextBox Properties")]
    public int BorderRadius
    {
        get => _borderRadius;
        set
        {
            if (value < 0) return;
            _borderRadius = value;
            Invalidate(); // Redraw control
        }
    }

    [Category("Custom TextBox Properties")]
    public string PlaceholderText
    {
        get => _placeholderText;
        set
        {
            _placeholderText = value;
            TextBox.Text = "";
            SetPlaceholder();
        }
    }

    [Category("Custom TextBox Properties")]
    public Color PlaceholderColor
    {
        get => _placeholderColor;
        set
        {
            _placeholderColor = value;
            if (_isPasswordChar)
            {
                TextBox.ForeColor = value;
            }
        }
    }

    #endregion

    # region -> Overriden methods

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graph = e.Graphics;
        if (_borderRadius > 1)  // Rounded TextBox
        {
            // Fields
            var rectBorderSmooth = ClientRectangle;
            var rectBorder = Rectangle.Inflate(rectBorderSmooth, -_borderSize, -_borderSize);
            var smoothSize = _borderSize > 0 ? _borderSize : 1;
            using GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, _borderRadius);
            using GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - _borderSize);
            using Pen penBorderSmooth = new Pen(Parent.BackColor, smoothSize);
            using Pen penBorder = new Pen(_borderColor, _borderSize);

            // Drawing
            Region = new Region(pathBorderSmooth);  // Set the rounded region of UserControl
            if (_borderRadius > 15) SetTextBoxRoundedRegion();  // Set the rounded region of TextBox component
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            penBorder.Alignment = PenAlignment.Center;
            if (_isFocused) penBorder.Color = _borderFocusColor;

            if (_underlinedStyle) // Line Style
            {
                // Draw border smoothing
                graph.DrawPath(penBorderSmooth, pathBorderSmooth);

                // Draw border
                graph.SmoothingMode = SmoothingMode.None;
                graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
            }
            else  // Normal Style
            {
                // Draw border smoothing
                graph.DrawPath(penBorderSmooth, pathBorderSmooth);

                // Draw border
                graph.DrawPath(penBorder, pathBorder);
            }
        }
        else  // Square/Normal TextBox
        {
            // Draw border
            using var penBorder = new Pen(_borderColor, _borderSize);
            Region = new Region(ClientRectangle);
            penBorder.Alignment = PenAlignment.Inset;
            if (_isFocused) penBorder.Color = _borderFocusColor;

            if (_underlinedStyle)  // Line Style
                graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
            else  // Normal Style
                graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        if (DesignMode)
        {
            UpdateControlHeight();
        }
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        UpdateControlHeight();
    }

    # endregion

    #region -> Private methods

    private void SetPlaceholder()
    {
        if (!string.IsNullOrEmpty(TextBox.Text) || _placeholderText == "") return;
        _isPlaceholder = true;
        TextBox.Text = _placeholderText;
        TextBox.ForeColor = _placeholderColor;
        if (_isPasswordChar)
        {
            TextBox.UseSystemPasswordChar = false;
        }
    }

    private void RemovePlaceholder()
    {
        if (!_isPlaceholder || _placeholderText == "") return;
        _isPlaceholder = false;
        TextBox.Text = "";
        TextBox.ForeColor = ForeColor;
        if (_isPasswordChar)
        {
            TextBox.UseSystemPasswordChar = true;
        }
    }

    private void SetTextBoxRoundedRegion()
    {
        GraphicsPath pathTxt;

        if (Multiline)
        {
            pathTxt = GetFigurePath(TextBox.ClientRectangle, _borderRadius - _borderSize);
            TextBox.Region = new Region(pathTxt);
        }

        else
        {
            pathTxt = GetFigurePath(TextBox.ClientRectangle, _borderSize * 2);
            TextBox.Region = new Region(pathTxt);
        }
    }

    private static GraphicsPath GetFigurePath(Rectangle rect, int radius)
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

    private void UpdateControlHeight()
    {
        if (TextBox.Multiline == false)
        {
            var txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
            TextBox.Multiline = true;
            TextBox.MinimumSize = new Size(0, txtHeight);
            TextBox.Multiline = false;

            Height = TextBox.Height + Padding.Top + Padding.Bottom;
        }
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        TextChanged?.Invoke(sender, e);
    }

    private void TextBox_Click(object sender, EventArgs e)
    {
        OnClick(e);
    }

    private void TextBox_MouseEnter(object sender, EventArgs e)
    {
        OnMouseEnter(e);
    }

    private void TextBox_MouseLeave(object sender, EventArgs e)
    {
        OnMouseLeave(e);
    }

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        OnKeyPress(e);
    }

    private void TextBox_Enter(object sender, EventArgs e)
    {
        _isFocused = true;
        Invalidate();
        RemovePlaceholder();
    }

    private void TextBox_Leave(object sender, EventArgs e)
    {
        _isFocused = false;
        Invalidate();
        SetPlaceholder();
    }

    # endregion
}

using System.Drawing;
using System.Windows.Forms;

public class MiTabControl : TabControl
{
    public enum Style
    {
        Flat,
        Line
    }

    // Colores de fondo
    private Style _TabStyle;
    private Color _BottomBackColor = Color.Black;
    private Color _BottomForeColor = Color.White;
    private Color _LineBackColor = Color.FromArgb(74, 134, 160);
    private Color _LineForeColor = Color.White;

    public Style TabStyle
    {
        get
        {
            return _TabStyle;
        }
        set
        {
            _TabStyle = value;
            Invalidate();
        }
    }

    public Color BottomBackColor
    {
        get
        {
            return _BottomBackColor;
        }
        set
        {
            _BottomBackColor = value;
            Invalidate();
        }
    }

    public Color BottomForeColor
    {
        get
        {
            return _BottomForeColor;
        }
        set
        {
            _BottomForeColor = value;
            Invalidate();
        }
    }

    public Color LineBackColor
    {
        get
        {
            return _LineBackColor;
        }
        set
        {
            _LineBackColor = value;
            Invalidate();
        }
    }

    public Color LineForeColor
    {
        get
        {
            return _LineForeColor;
        }
        set
        {
            _LineForeColor = value;
            Invalidate();
        }
    }

    public MiTabControl()
    {
        SetStyle(ControlStyles.UserPaint, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        SetStyle(ControlStyles.ResizeRedraw, true);

        SizeMode = TabSizeMode.Fixed;
        ItemSize = new Size(220, 50);
        TabStyle = Style.Line;
    }

    protected override void CreateHandle()
    {
        base.CreateHandle();
        if (Alignment == TabAlignment.Left || Alignment == TabAlignment.Right)
        {
            Alignment = TabAlignment.Top;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        using (Bitmap bitmap = new Bitmap(Width, Height))
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Parent.BackColor);

                for (int i = 0; i < TabCount; i++)
                {
                    Rectangle tabRect = GetTabRect(i);

                    if (i == SelectedIndex)
                    {
                        switch (TabStyle)
                        {
                            case Style.Flat:
                                g.FillRectangle(new SolidBrush(BottomBackColor), tabRect);
                                break;
                            case Style.Line:
                                g.DrawLine(new Pen(LineBackColor, 4), 0, tabRect.Bottom, Width, tabRect.Bottom);
                                g.FillRectangle(new SolidBrush(LineForeColor), new Rectangle(tabRect.Left, tabRect.Bottom - 1, ItemSize.Width, 4));
                                break;
                        }

                        if (ImageList != null)
                        {
                            try
                            {
                                if (ImageList.Images[TabPages[i].ImageIndex] != null)
                                {
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(tabRect.Location.X + 8, tabRect.Location.Y + 6));
                                    g.DrawString("    " + TabPages[i].Text, Font, new SolidBrush(Color.FromKnownColor(KnownColor.WhiteSmoke)), tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                                }
                                else
                                {
                                    g.DrawString(TabPages[i].Text, Font, new SolidBrush(Color.FromKnownColor(KnownColor.WhiteSmoke)), tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                                }
                            }
                            catch
                            {
                                g.DrawString(TabPages[i].Text, Font, new SolidBrush(Color.FromKnownColor(KnownColor.WhiteSmoke)), tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                            }
                        }
                        else
                        {
                            g.DrawString(TabPages[i].Text, Font, new SolidBrush(Color.FromKnownColor(KnownColor.WhiteSmoke)), tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }
                    }
                    else
                    {
                        if (ImageList != null)
                        {
                            try
                            {
                                if (ImageList.Images[TabPages[i].ImageIndex] != null)
                                {
                                    g.DrawImage(ImageList.Images[TabPages[i].ImageIndex], new Point(tabRect.Location.X + 8, tabRect.Location.Y + 6));
                                    g.DrawString("    " + TabPages[i].Text, Font, new SolidBrush(Color.FromKnownColor(KnownColor.WhiteSmoke)), tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                                }
                                else
                                {
                                    g.DrawString(TabPages[i].Text, Font, new SolidBrush(Color.FromKnownColor(KnownColor.WhiteSmoke)), tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                                }
                            }
                            catch
                            {
                                g.DrawString(TabPages[i].Text, Font, new SolidBrush(Color.FromKnownColor(KnownColor.WhiteSmoke)), tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                            }
                        }
                        else
                        {
                            g.DrawString(TabPages[i].Text, Font, new SolidBrush(Color.FromKnownColor(KnownColor.WhiteSmoke)), tabRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                        }
                    }
                }
                base.OnPaint(e);
                e.Graphics.DrawImage(bitmap.Clone() as Image, 0, 0);
            }
        }
    }
}




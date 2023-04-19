﻿using PinControl.MAUI.Helpers.Extensions;

namespace PinControl.MAUI.Views.Components.CodeViewer.Base;
public abstract class ShowCodeViewer : CodeViewer
{
    protected const double FONT_SIZE = 32;
    protected const string FONT_FAMILY = "OpenSansRegular";

    public double FontSize
    {
        get { return (double)GetValue(FontSizeProperty); }
        set { SetValue(FontSizeProperty, value); }
    }

    public Color TextColor
    {
        get { return (Color)GetValue(TextColorProperty); }
        set { SetValue(TextColorProperty, value); }
    }

    public string FontFamily
    {
        get { return (string)GetValue(FontFamilyProperty); }
        set { SetValue(FontFamilyProperty, value); }
    }

    public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(nameof(FontSize), typeof(double), typeof(ShowCodeViewer), FONT_SIZE, propertyChanged: OnPropertyChanged);
    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(ShowCodeViewer), Color.FromArgb(Application.Current.IsLightMode() ? "#FFFFFF" : "#000000"), propertyChanged: OnPropertyChanged);
    public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(ShowCodeViewer), FONT_FAMILY, propertyChanged: OnPropertyChanged);

    protected Label CreateLabel(char? codeChar = null)
    {
        return new Label
        {
            TextColor = TextColor,
            FontSize = FontSize,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Text = codeChar.HasValue ? $"{codeChar}" : string.Empty,
            FontFamily = FontFamily
        };
    }
}
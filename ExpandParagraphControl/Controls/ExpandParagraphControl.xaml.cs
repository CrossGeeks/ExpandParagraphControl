using System.Windows.Input;
using Xamarin.Forms;

namespace ExpandParagraphControl.Controls
{
    public partial class ExpandParagraphControl : ContentView
    {
        public ExpandParagraphControl() => InitializeComponent();

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(ExpandParagraphControl));
        public static readonly BindableProperty DefaultButtonTitleProperty = BindableProperty.Create(nameof(DefaultButtonTitle), typeof(string), typeof(ExpandParagraphControl), defaultValue: "More");
        public static readonly BindableProperty ExpandedButtonTitleProperty = BindableProperty.Create(nameof(ExpandedButtonTitle), typeof(string), typeof(ExpandParagraphControl), defaultValue: "Hide");
        public static readonly BindableProperty DefaultVisibleLinesProperty = BindableProperty.Create(nameof(DefaultVisibleLines), typeof(int), typeof(ExpandParagraphControl), defaultValue: 3);
        public static readonly BindableProperty IsExpandedProperty = BindableProperty.Create(nameof(IsExpanded), typeof(bool), typeof(ExpandParagraphControl), defaultBindingMode: BindingMode.OneTime);
        public static readonly BindableProperty TextFontSizePoperty = BindableProperty.Create(nameof(TextFontSize), typeof(double), typeof(ExpandParagraphControl));
        public static readonly BindableProperty TextFontAttributessPoperty = BindableProperty.Create(nameof(TextFontAttributes), typeof(FontAttributes), typeof(ExpandParagraphControl));
        public static readonly BindableProperty TextColorPoperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(ExpandParagraphControl));
        public static readonly BindableProperty ButtonTextColorPoperty = BindableProperty.Create(nameof(ButtonTextColor), typeof(Color), typeof(ExpandParagraphControl));

        private static object GetDefaultMoreCommand(BindableObject bindable)
                  => new Command(() => ((ExpandParagraphControl)bindable).IsExpanded = !((ExpandParagraphControl)bindable).IsExpanded);

        public static readonly BindableProperty MoreCommandProperty = BindableProperty.Create(nameof(MoreCommand), typeof(ICommand), typeof(ExpandParagraphControl),
                defaultBindingMode: BindingMode.OneWay, defaultValueCreator: GetDefaultMoreCommand);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        [TypeConverter(typeof(FontSizeConverter))]
        public double TextFontSize
        {
            get => (double)GetValue(TextFontSizePoperty);
            set => SetValue(TextFontSizePoperty, value);
        }

        [TypeConverter(typeof(FontAttributesConverter))]
        public FontAttributes TextFontAttributes
        {
            get => (FontAttributes)GetValue(TextFontAttributessPoperty);
            set => SetValue(TextFontAttributessPoperty, value);
        }

        public Color TextColor
        {
            get => (Color)GetValue(TextColorPoperty);
            set => SetValue(TextColorPoperty, value);
        }

        public Color ButtonTextColor
        {
            get => (Color)GetValue(ButtonTextColorPoperty);
            set => SetValue(ButtonTextColorPoperty, value);
        }

        public string DefaultButtonTitle
        {
            get => (string)GetValue(DefaultButtonTitleProperty);
            set => SetValue(DefaultButtonTitleProperty, value);
        }

        public string ExpandedButtonTitle
        {
            get => (string)GetValue(ExpandedButtonTitleProperty);
            set => SetValue(ExpandedButtonTitleProperty, value);
        }

        public int DefaultVisibleLines
        {
            get => (int)GetValue(DefaultVisibleLinesProperty);
            set => SetValue(DefaultVisibleLinesProperty, value);
        }

        public bool IsExpanded
        {
            get => (bool)GetValue(IsExpandedProperty);
            set => SetValue(IsExpandedProperty, value);
        }

        public ICommand MoreCommand
        {
            get => (ICommand)GetValue(MoreCommandProperty);
            set => SetValue(MoreCommandProperty, value);
        }
    }
}

class DisplayBox
{
    public int Left, Top;
    public int Width;
    private ConsoleColor ForegroundColor;
    private ConsoleColor BackgroundColor;

    public void Create(int left, int top, int width, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
    {
        Left = left;
        Top = top;
        Width = width;
        ForegroundColor = foregroundColor;
        BackgroundColor = backgroundColor;
    }

    internal void ShowText(string text)
    {
        Show();

        if (text == "")
            text = "0";

        Console.SetCursorPosition(Left + Width - text.Length - 1, Top + 1);
        Console.Write(text);

        Console.ResetColor();
    }

    public void Show()
    {
        var s = new string(' ', Width);

        Console.ForegroundColor = ForegroundColor;
        Console.BackgroundColor = BackgroundColor;

        Console.SetCursorPosition(Left, Top);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left, Top + 1);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left, Top + 2);
        Console.WriteLine(s);
    }
}
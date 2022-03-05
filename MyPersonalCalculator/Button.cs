class Button
{
    public int Left, Top;
    public string Text;

    public void Create(int left, int top, string text)
    {
        Left = left;
        Top = top;
        Text = text;
    }

    public void SetColor(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
    {
        Console.ForegroundColor = foregroundColor;
        Console.BackgroundColor = backgroundColor;
    }

    public void Show()
    {
        Console.SetCursorPosition(Left, Top);
        Console.Write("      ");
        Console.SetCursorPosition(Left, Top + 1);
        var displayText = Text.Length == 1 ? $"{Text} " : Text;
        Console.Write($"  {displayText}  ");
        Console.SetCursorPosition(Left, Top + 2);
        Console.Write("      ");
    }
}
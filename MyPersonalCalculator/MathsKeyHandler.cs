public class MathsKeyHandler
{
    string buffer = "";

    internal void StartCheckingKeys(DisplayBox displayBox)
    {
        ConsoleKeyInfo keyInfo;

        do
        {
            keyInfo = Console.ReadKey(true);    // Why is the purpose of true

            if (keyInfo.KeyChar >= '0' && keyInfo.KeyChar <= '9')
                NumberKeyPressed(keyInfo.KeyChar);
            else if (keyInfo.KeyChar == '.')
                DotKeyPressed();
            else if (keyInfo.Key == ConsoleKey.Backspace)
                BackSpacePressed();
            else if (keyInfo.Key == ConsoleKey.Delete)
                ClearKeyPressed();
            else if (keyInfo.KeyChar >= '*' && keyInfo.KeyChar <= '/')
            {
                if (keyInfo.KeyChar == ',')
                    Console.Write('\a');
                else if (buffer.Length > 1 && buffer[buffer.Length - 2] >= '*' && buffer[buffer.Length - 2] <= '/')
                    Console.Write('\a');
                else
                    buffer += " " + keyInfo.KeyChar + " ";
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
                buffer = Evaluation.Eval(buffer).ToString();
            else
                continue;

            displayBox.ShowText(buffer);

        } while (keyInfo.Key != ConsoleKey.Escape);
    }

    private void ClearKeyPressed()
    {
        buffer = "";
    }

    private void NumberKeyPressed(char keyChar)
    {
        buffer += keyChar;
    }

    private void BackSpacePressed()
    {
        if (buffer != "")
            buffer = buffer.Substring(0, buffer.Length - 1);
        else
            Console.Write('\a');
    }

    private void DotKeyPressed()
    {
        if (buffer.Contains('.'))
            Console.Write('\a');
        else
            buffer += '.';
    }
}
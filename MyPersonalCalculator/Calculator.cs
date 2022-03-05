class Calculator
{
    DisplayBox displayBox;
    Button buttonPercent, buttonClearEverything, buttonClear, buttonBack;
    Button buttonReciprocal, buttonSquare;
    private Button buttonSquareRoot;
    private Button buttonDivide;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button buttonInto;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button buttonMinus;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button buttonPlus;
    private Button buttonPlusMinus;
    private Button button0;
    private Button buttonDot;
    private Button buttonEquals;
    private MathsKeyHandler handler;

    public void Start()
    {

        DisplayBackground();
        ShowDisplayBox();
        ShowAllButtons();

        // What is this for
        //Console.ReadKey();
        handler = new MathsKeyHandler();
        handler.StartCheckingKeys(displayBox);
    }

    private void DisplayBackground()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        var s = new string(' ', 31); //increse or decrese outer width of calculator

        for (int row = 2; row <= 32; row++)
        {
            Console.SetCursorPosition(17, row);
            Console.Write(s);
        }

        Console.SetCursorPosition(19, 3);
        Console.Write("WAI IT CALCULATOR");

        Console.ResetColor();
    }

    private Button CreateAButton(int left, int top, string text)
    {
        var button = new Button();

        button.Create(left, top, text);
        button.SetColor(ConsoleColor.White, ConsoleColor.Black);
        button.Show();

        return button;
    }

    private void ShowAllButtons()
    {
        buttonPercent = CreateAButton(19, 9, "%");
        buttonClearEverything = CreateAButton(26, 9, "CE");
        buttonClear = CreateAButton(33, 9, "C");
        buttonBack = CreateAButton(40, 9, "<=");

        buttonReciprocal = CreateAButton(19, 13, "/x");
        buttonSquare = CreateAButton(26, 13, "x2");
        buttonSquareRoot = CreateAButton(33, 13, "2x");
        buttonDivide = CreateAButton(40, 13, "/");

        button7 = CreateAButton(19, 17, "7");
        button8 = CreateAButton(26, 17, "8");
        button9 = CreateAButton(33, 17, "9");
        buttonInto = CreateAButton(40, 17, "*");

        button4 = CreateAButton(19, 21, "4");
        button5 = CreateAButton(26, 21, "5");
        button6 = CreateAButton(33, 21, "6");
        buttonMinus = CreateAButton(40, 21, "-");

        button1 = CreateAButton(19, 25, "1");
        button2 = CreateAButton(26, 25, "2");
        button3 = CreateAButton(33, 25, "3");
        buttonPlus = CreateAButton(40, 25, "+");

        buttonPlusMinus = CreateAButton(19, 29, "+-");
        button0 = CreateAButton(26, 29, "0");
        buttonDot = CreateAButton(33, 29, ".");
        buttonEquals = CreateAButton(40, 29, "=");

        Console.ResetColor();
    }

    private void ShowDisplayBox()
    {
        displayBox = new DisplayBox();
        displayBox.Create(19, 5, 27, ConsoleColor.Black, ConsoleColor.Gray);
        displayBox.Show();
        displayBox.ShowText("");
        Console.ResetColor();
    }
}

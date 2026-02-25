public class Button
{
    public bool IsPressed;
    public int TimesPressed;

    public void Press()
    {
        IsPressed = IsPressed? false : true;
        TimesPressed++;
    }

    public string Info()
    {
        return $"Button is {(IsPressed? "" : "not ")}pressed.\nPressed {TimesPressed} times.";
    }
}
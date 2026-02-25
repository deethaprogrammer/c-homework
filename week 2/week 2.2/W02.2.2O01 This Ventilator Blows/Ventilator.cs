class Ventilator
{
    public int Speed = 0;
    public List<Button> Buttons = [
        new Button(), new Button(), new Button(), new Button()
    ];

    public Ventilator() { }

    public void PressButton(int number)
    {
        if (number < 0 || number >= Buttons.Count)
        {
            return;
        }
        
        Speed = number;
    }

    public string Blow() => Speed switch
    {
        <= 0 => "Off",
           1 => "~~~",
           2 => "^^^",
        >= 3 => "===",
    };
}

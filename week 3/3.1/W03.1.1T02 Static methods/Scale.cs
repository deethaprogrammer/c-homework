public class Scale
{
    public bool UseKg = true;

    public static double ConvertKgToLbs(double kg) => kg * 2.2;
    public string GetWeight(double weight)
    {
        return UseKg? $"{weight} kg" : $"{ConvertKgToLbs(weight)} lbs";
    }
}
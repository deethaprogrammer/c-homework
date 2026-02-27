public class CarFactory
{
    public readonly int ProduceLimitOflimit;

    public CarFactory(int producelimitoflimit)
    {
        this.ProduceLimitOflimit = producelimitoflimit;
    }
    public LimitedEditionCar ProduceLimitedEditionCar()
    {
        if (LimitedEditionCar.Counter < ProduceLimitOflimit)
        {
            return new LimitedEditionCar();
        }
        return null;
    }
}
public class Player
{
    public string Name;
    public int HealthPoints;
    public int Power;

    public Player(string Name, int Power)
    {
        this.Name = Name;
        this.Power = Power;
        this.HealthPoints = 100;
    }
    
    public bool IsAlive()
    {
        return this.HealthPoints > 0;
    }

    public void TakeDamage(int damage)
    {
        this.HealthPoints -= damage;
        if (this.HealthPoints < 0)
        {
            this.HealthPoints = 0;
        }
    }
}
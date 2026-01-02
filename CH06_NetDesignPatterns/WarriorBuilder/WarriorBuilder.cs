using WarriorFactory;

public abstract class WarriorBuilder
{
    protected WarriorPost _warrior = new WarriorPost();
    public void CreateNew(string type)
    {
        _warrior = new WarriorPost
        {
            Type = type
        };
    }

    public WarriorPost GetResult()
    {
        return _warrior;
    }

    //kroki budowy – każdy builder musi je zdefiniować
    public abstract void Register();     //krok 1: zapis
    public abstract void GiveWeapon();   //krok 2: broń
    public abstract void Train();        //krok 3: trening
}

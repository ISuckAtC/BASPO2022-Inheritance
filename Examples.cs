class Creature
{
    public int hp;
    public int baseDamage;
    public int currentDamage {get {return baseDamage;}}

    public Creature(int hp, int baseDamage)
    {
        this.hp = hp;
        this.baseDamage = baseDamage;
    }
    public virtual void Attack(Creature target)
    {
        target.TakeDamage(this, currentDamage);
    }

    public virtual void TakeDamage(Creature source, int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {

    }
}
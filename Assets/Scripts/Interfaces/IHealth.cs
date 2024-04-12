using System.Collections;
using System.Collections.Generic;

interface IHealth
{
    public void TakeDamage(int incomingDamage);
    public void Heal(int incomingHealing);
    public IEnumerator RegenerateHealth();
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHealth : MonoBehaviour, IHealth
{
    EntitySO _entity;
    [SerializeField] int _baseHealth = 0;
    [SerializeField] int _maxHealth = 0;
    [SerializeField] float _regenerationRate = 15f;
    [SerializeField] float _regenerationAmount = 0;

    [SerializeField] int currentDefence = 0;
    void Start()
    {
        _entity = gameObject.GetComponent<SetEntitySO>().GetEntity;
        _baseHealth = _maxHealth = _entity.health;
        _regenerationAmount = _entity.healthRegeneration;
        StartCoroutine(RegenerateHealth());

        currentDefence = _entity.defence;
    }

    public void TakeDamage(int incomingDamage)
    {
        var finalDamage = incomingDamage > currentDefence ? incomingDamage - currentDefence: 0;
        _baseHealth -= finalDamage;
        if (_baseHealth <= 0)
            Defeated();
    }

    public void Heal(int incomingHealing)
    {
        _baseHealth = Mathf.Clamp(_baseHealth + incomingHealing, 0, _maxHealth);
    }
    public virtual void Defeated()
    {
        Debug.Log($"{gameObject.name} was defeated");
        StopCoroutine(RegenerateHealth());
    }

    public IEnumerator RegenerateHealth()
    {
        while (true)
        {
            yield return new WaitForSeconds(_regenerationRate);
            // Debug.Log("Regenerating");
            var regeneratedHealth = (int)((float)_baseHealth * _regenerationAmount) + _baseHealth;
            _baseHealth = Mathf.Clamp(regeneratedHealth, 0, _maxHealth);
        }
    }
}
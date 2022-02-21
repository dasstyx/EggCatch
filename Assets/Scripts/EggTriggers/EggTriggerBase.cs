using System;
using UnityEngine;

public abstract class EggTriggerBase : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent<Egg>(out var egg))
        {
            HandleEgg(egg);
        }
    }

    protected abstract void HandleEgg(Egg egg);
}
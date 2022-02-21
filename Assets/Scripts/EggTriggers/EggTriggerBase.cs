using EggCatch.Eggs;
using UnityEngine;

namespace EggCatch.EggTriggers
{
    public abstract class EggTriggerBase : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.TryGetComponent<PhysicsEgg>(out var egg))
            {
                HandleEgg(egg);
            }
        }

        protected abstract void HandleEgg(PhysicsEgg egg);
    }
}
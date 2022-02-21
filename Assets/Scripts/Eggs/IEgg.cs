using UnityEngine;

namespace EggCatch.Eggs
{
    public interface IEgg
    {
        void Init(int poseToCatch, Vector2 destination);
        bool CheckCought(int pose);
    }
}
using UnityEngine;

public interface IEgg
{
    void Init(int poseToCatch, Vector2 destination);
    bool CheckCought(int pose);
}
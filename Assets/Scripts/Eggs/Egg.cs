using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Egg : MonoBehaviour
{
    [SerializeField] private float _travelSpeed;
    private int _poseToCatch;
    private Rigidbody2D _rigidbody;
    private Vector2 _travelDestination;

    public void Init(int poseToCatch, Vector2 destination)
    {
        _poseToCatch = poseToCatch;
        _travelDestination = destination;
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.isKinematic = true;
        TravelAlongPath();
    }

    public bool CheckCought(int pose)
    {
        Destroy(gameObject);
        return true;
        // if (pose == _poseToCatch)
        // {
        //     Destroy(gameObject);
        //     return true;
        // }
        //
        // return false;
    }

    private void TravelAlongPath()
    {
        transform
            .DOMove(_travelDestination, _travelSpeed)
            .onComplete += TurnPhysicsOn;
    }

    private void TurnPhysicsOn()
    {
        _rigidbody.isKinematic = false;
    }
}
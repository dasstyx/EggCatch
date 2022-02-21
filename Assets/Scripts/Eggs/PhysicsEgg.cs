using DG.Tweening;
using UnityEngine;

namespace EggCatch.Eggs
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PhysicsEgg : MonoBehaviour, IEgg
    {
        [SerializeField] private float _travelSpeed;
        private Rigidbody2D _rigidbody;
        private Vector2 _travelDestination;

        public void Init(int poseToCatch, Vector2 destination)
        {
            _travelDestination = destination;
            _rigidbody = GetComponent<Rigidbody2D>();
            _rigidbody.isKinematic = true;
            TravelAlongPath();
        }

        public bool CheckCought(int pose)
        {
            Destroy(gameObject);
            return true;
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
}
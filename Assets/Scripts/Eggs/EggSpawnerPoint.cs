using UnityEngine;

namespace EggCatch.Eggs
{
    public class EggSpawnerPoint : MonoBehaviour
    {
        [SerializeField] private Transform _destinationTransform;
        public Vector2 Destination => _destinationTransform.position;
        public Vector2 Position => transform.position;

        private void Start()
        {
            if (_destinationTransform == null)
            {
                _destinationTransform = transform.GetChild(0);
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            Gizmos.DrawCube(Position, new Vector3(1, 1, 1));

            if (_destinationTransform != null)
            {
                Gizmos.color = new Color(0, 0, 1, 0.5f);
                Gizmos.DrawCube(Destination, new Vector3(1, 1, 1));
            }
        }
    }
}
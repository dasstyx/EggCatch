using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = System.Random;

public class EggAllSpawners : MonoBehaviour
{
    [SerializeField] private float _spawnCooldown = 1;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private EggSpawnerPoint[] _spawners;
    private Game _game;

    public void Init(Game game)
    {
        _game = game;
        StartCoroutine(InfiniteSpawn());
    }

    private WaitForSeconds GetWaitYield()
    {
        return new WaitForSeconds(_spawnCooldown);
    }

    private IEnumerator InfiniteSpawn()
    {
        yield return null;
        var random = new Random();
        while (_game.IsPlaying)
        {
            var spawnerIndex = random.Next(0, _spawners.Length);
            var spawnerPoint = _spawners[spawnerIndex];

            var go = Instantiate(_prefab, spawnerPoint.Position, quaternion.identity);
            var egg = go.GetComponent<PhysicsEgg>();
            egg.Init(spawnerIndex, spawnerPoint.Destination);

            yield return GetWaitYield();
        }
    }
}
using EggCatch.EggTriggers;
using UnityEngine;

namespace EggCatch.Player
{
    public class PlayerPoseHandler : MonoBehaviour, IPlayerPoseHandler
    {
        [SerializeField] private GameObject[] _posesObjects;
        private int _currentPose = 1;
        private HandTrigger[] _handTriggers;

        public void Init(int initialPose, CatcherScore score)
        {
            _handTriggers = new HandTrigger[_posesObjects.Length];

            for (var i = 0; i < _posesObjects.Length; i++)
            {
                var poseObj = _posesObjects[i];
                poseObj.SetActive(false);
                var hand = poseObj.GetComponentInChildren<HandTrigger>();
                hand.Init(score);

                _handTriggers[i] = hand;
            }

            UpdatePose(initialPose);
        }

        public void UpdatePose(int pose)
        {
            SetPose(false, _currentPose);
            SetPose(true, pose);
            _currentPose = pose;
        }

        private void SetPose(bool active, int pose)
        {
            var fixedPose = pose - 1;
            _posesObjects[fixedPose].SetActive(active);
            _handTriggers[fixedPose].UpdatePos(pose);
        }
    }
}
using UnityEngine;

namespace EggCatch.Player
{
    public class Player : MonoBehaviour
    {
        private int _currentPose = 1;
        private int _maxPoses;
        private int _poseIgnoreHorizontal = 1;
        private bool _right;

        private CatcherScore _score;
        private IPlayerPoseHandler playerPoseHandler;

        public void Init(int maxPoses, CatcherScore score)
        {
            _maxPoses = maxPoses;
            _score = score;
            playerPoseHandler = GetComponent<IPlayerPoseHandler>();
            playerPoseHandler.Init(_currentPose, _score);
        }

        public void Up()
        {
            _poseIgnoreHorizontal--;
            FinishMove();
        }

        public void Down()
        {
            _poseIgnoreHorizontal++;
            FinishMove();
        }

        public void Right()
        {
            _right = true;
            FinishMove();
        }

        public void Left()
        {
            _right = false;
            FinishMove();
        }

        private void FinishMove()
        {
            var rightPosesStart = _maxPoses / 2;
            _poseIgnoreHorizontal = Mathf.Clamp(_poseIgnoreHorizontal, 1, _maxPoses / 2);

            if (_right)
            {
                ChangePose(_poseIgnoreHorizontal + rightPosesStart);
            }
            else
            {
                ChangePose(_currentPose = _poseIgnoreHorizontal);
            }

            playerPoseHandler.UpdatePose(_currentPose);
        }

        private void ChangePose(int pose)
        {
            _currentPose = pose;
        }
    }
}
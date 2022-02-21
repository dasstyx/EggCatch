namespace EggCatch.Player
{
    public interface IPlayerPoseHandler
    {
        void UpdatePose(int pose);
        void Init(int initialPose, CatcherScore score);
    }
}
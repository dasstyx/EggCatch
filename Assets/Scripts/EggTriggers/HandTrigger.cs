using EggCatch.Eggs;

namespace EggCatch.EggTriggers
{
    public class HandTrigger : EggTriggerBase
    {
        private int _pose;
        private CatcherScore _score;

        public void Init(CatcherScore score)
        {
            _score = score;
        }

        public void UpdatePos(int pose)
        {
            _pose = pose;
        }

        protected override void HandleEgg(PhysicsEgg egg)
        {
            egg.CheckCought(_pose);
            _score.PlusScore();
        }
    }
}
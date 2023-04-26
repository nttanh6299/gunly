namespace Game.Server.Achievement
{
    public class GetMasterCondition : BaseUserRecord
    {
        public GetMasterCondition(GamePlayer player, int type)
			: base(player, type)
        {
			AddTrigger(player);
        }

        public override void AddTrigger(GamePlayer player)
        {
			player.AcademyEvent += academyEvent;
        }

        private void academyEvent(GamePlayer friendly, int type)
        {
			if (type == 0)
			{
				m_player.AchievementInventory.UpdateUserAchievement(m_type, 1, 1);
			}
        }

        public override void RemoveTrigger(GamePlayer player)
        {
			player.AcademyEvent -= academyEvent;
        }
    }
}

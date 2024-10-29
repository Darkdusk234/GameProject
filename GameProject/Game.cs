namespace GameProject
{
    internal class Game
    {
        List<Level> levels = new List<Level>();

        public void AddLevel(Level level)
        {
            levels.Add(level);
        }

        public void AddLevel(Level level, int levelIndex)
        {
            levels.Insert(levelIndex, level);
        }
    }
}

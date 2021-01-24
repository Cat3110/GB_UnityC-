namespace RollnBall
{
    public sealed class GameInitializator
    {
        #region

        public GameInitializator(GameController gameController, PlayerData playerData, CameraData cameraData)
        {
            new PlayerInitializator(gameController, playerData);
            new CameraInitializator(gameController, cameraData);
        }

        #endregion
    }
}
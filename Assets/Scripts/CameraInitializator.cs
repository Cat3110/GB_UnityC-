namespace RollnBall
{
    public sealed class CameraInitializator
    {
        #region ClassLifeCycles

        public CameraInitializator(GameController gameController, CameraData cameraData)
        {
            var cameraModel = new CameraModel(cameraData.cameraStruct);
            gameController.AddUpdatable(new CameraController(cameraModel));
        }

        #endregion
    }
}
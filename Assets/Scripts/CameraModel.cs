namespace RollnBall
{
    public sealed class CameraModel
    {
        #region PrivateData

        private readonly CameraStruct _cameraStruct;

        #endregion

        
        #region Properties

        public CameraStruct CameraStruct => _cameraStruct;

        #endregion


        #region ClassLifeCycles

        public CameraModel(CameraStruct cameraStruct)
        {
            _cameraStruct = cameraStruct;
        }

        #endregion
    }
}
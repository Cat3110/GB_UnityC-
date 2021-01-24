using UnityEngine;


namespace RollnBall
{
    public sealed class CameraController : IUpdatable
    {
        #region PrivateData

        private CameraModel _cameraModel;
        private Camera _camera;
        private Vector3 _objectToFollowPosition;

        #endregion


        #region ClassLifeCycles

        public CameraController(CameraModel cameraModel)
        {
            _cameraModel = cameraModel;
            _camera = Camera.main;
        }

        #endregion


        #region Methods

        public void UpdateTick()
        {
            _objectToFollowPosition =
                _cameraModel.CameraStruct.objectToFollow.playerStruct.playerView.transform.position;
            _camera.transform.position = _objectToFollowPosition + _cameraModel.CameraStruct.offset;
            _camera.transform.LookAt(_objectToFollowPosition);
        }

        #endregion
    }
}
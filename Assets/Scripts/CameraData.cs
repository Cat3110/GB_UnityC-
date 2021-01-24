using UnityEngine;


namespace RollnBall
{
    [CreateAssetMenu(fileName = "CameraData", menuName = "Data/CameraData")]
    public sealed class CameraData : ScriptableObject
    {
        #region Field

        public CameraStruct cameraStruct;

        #endregion
    }
}
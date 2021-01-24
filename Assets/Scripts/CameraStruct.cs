using System;
using UnityEngine;


namespace RollnBall
{
    [Serializable]
    public struct CameraStruct
    {
        public PlayerData objectToFollow;
        public Vector3 offset;
    }
}
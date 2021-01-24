using UnityEngine;
using System;


namespace RollnBall
{
    [Serializable]
    public struct PlayerStruct
    {
        public GameObject playerPrefab;
        public GameObject playerView;
        public Vector3 startPosition;
        public float speed;
    }
}
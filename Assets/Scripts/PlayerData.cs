using UnityEngine;


namespace RollnBall
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/PlayerData")]
    public sealed class PlayerData : ScriptableObject
    {
        #region Field

        public PlayerStruct playerStruct;

        #endregion

    }
}
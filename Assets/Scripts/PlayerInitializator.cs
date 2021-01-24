using UnityEngine;


namespace RollnBall
{
    public sealed class PlayerInitializator
    {
        #region ClassLifeCycles

        public PlayerInitializator(GameController gameController, PlayerData playerData)
        {
            var spawnedPlayer = Object.Instantiate(playerData.playerStruct.playerPrefab,
                playerData.playerStruct.startPosition,
                Quaternion.identity);

            var playerStruct = playerData.playerStruct;
            playerStruct.playerView = spawnedPlayer;

            playerData.playerStruct = playerStruct;

            var playerModel = new PlayerModel(playerStruct);
            gameController.AddUpdatable(new PlayerController(playerModel));
        }

        #endregion
    }
}
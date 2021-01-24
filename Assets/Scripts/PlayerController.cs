using UnityEngine;


namespace RollnBall
{
    public sealed class PlayerController : IUpdatable
    {
        #region PrivateData

        private PlayerModel _playerModel;

        #endregion

        
        #region ClassLifeCycles

        public PlayerController(PlayerModel playerModel)
        {
            _playerModel = playerModel;
        }
        
        #endregion


        #region Methods

        public void UpdateTick()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _playerModel.PlayerStruct.playerView.GetComponent<Rigidbody>().AddForce(movement * _playerModel.PlayerStruct.speed);
        }

        #endregion
    }
}
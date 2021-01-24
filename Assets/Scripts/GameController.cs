using UnityEngine;
using System.Collections.Generic;


namespace RollnBall
{
    public sealed class GameController : MonoBehaviour
    {
        #region PrivateData

        [SerializeField] private PlayerData _playerData;
        [SerializeField] private CameraData _cameraData;

        private List<IUpdatable> _iUpdatables = new List<IUpdatable>();

        #endregion


        #region Fields

        public Pill pill;

        #endregion
        
        
        #region UnityMethods

        private void Start()
        {
            new GameInitializator(this, _playerData, _cameraData);
            pill.onInteraction += AddPoints;
        }

        private void Update()
        {
            for (int i = 0; i < _iUpdatables.Count; i++)
            {
                _iUpdatables[i].UpdateTick();
            }
        }

        #endregion


        #region Methods

        public void AddUpdatable(IUpdatable iUpdatable)
        {
            _iUpdatables.Add(iUpdatable);
        }

        public void AddPoints()
        {
            Debug.Log("Points were added");
        }

        #endregion
    }
}
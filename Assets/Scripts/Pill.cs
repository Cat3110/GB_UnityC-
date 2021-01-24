using UnityEngine;

namespace RollnBall
{
    public class Pill : InteractiveObject
    {
        #region PrivateData

        [SerializeField] private GameObject _pill;

        #endregion


        #region Methods

        protected override void Interaction()
        {
            base.Interaction();
        }

        #endregion

    }
}
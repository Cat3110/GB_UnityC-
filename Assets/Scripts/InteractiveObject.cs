using System;
using System.Security.Cryptography;
using UnityEngine;


namespace RollnBall
{
    public class InteractiveObject : MonoBehaviour
    {
        #region UnityMethods

        private void OnTriggerEnter(Collider other)
        {
            if(!other.CompareTag("Player"))
                return;
            Interaction();
            Destroy(gameObject);
        }

        #endregion
        
        #region Methods

        protected virtual void Interaction()
        {
            
        }

        #endregion

    }
}
using System;
using UnityEngine;


namespace RollnBall
{
    public class Pill : InteractiveObject
    {        
        #region Fields

        public GameController GameController;
        
        public delegate void MethodContainer();

        public event MethodContainer onInteraction;

        #endregion


        #region Methods

        protected override void Interaction()
        {
            base.Interaction();
            onInteraction?.Invoke();
        }

        #endregion

    }
}
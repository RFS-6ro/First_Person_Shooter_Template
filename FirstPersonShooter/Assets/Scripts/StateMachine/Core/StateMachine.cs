using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public abstract class StateMachine
    {
        protected State _currentState;

        public void AddTransition(State from, State to)
        {

        }
    }
}

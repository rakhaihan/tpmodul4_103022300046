using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300046
{
    internal class DoorMachine
    {
        public enum State {Terkunci, Terbuka };
        public enum Trigger { BukaPintu, KunciPintu};


        struct transition
        {
            public State prevState;
            public State nextState;
            public Trigger trigger;

            public transition(State prevState, State nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        transition[] transitions =
        {
            new transition(State.Terbuka, State.Terkunci, Trigger.KunciPintu),
            new transition(State.Terkunci, State.Terbuka, Trigger.BukaPintu)
        };


        public State currentState = State.Terkunci;
        
        public State getNextState(State prevState, Trigger trigger)
        {
            State nextState = prevState;

            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].prevState == prevState && transitions[i].trigger ==  trigger)
                    nextState = transitions[i].nextState;
            }

            return nextState;
        }

        public void activate(Trigger trigger)
        {
            State nextState = getNextState(currentState, trigger);
            currentState = nextState;  
        }



    }
}

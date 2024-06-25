namespace DataStructures.Stack
{
    public class StateMachine
    {
        public Stack<int> stateStack;
        public int currentState;

        public StateMachine(int initialState)
        {
            currentState = initialState;
            stateStack = new Stack<int>();
        }

        public void PushState(int state)
        {
            stateStack.Push(currentState);
            currentState = state;
        }

        public void PopState()
        {
            if (stateStack.Count > 0)
                currentState = stateStack.Pop();

            else
                Console.WriteLine("Error: Trying to pop from empty state stack.");

        }
    }
}

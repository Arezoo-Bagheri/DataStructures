namespace DataStructures.Stack
{
    public class StateMachineExecutor : IStateMachineActions
    {
        private StateMachine stateMachine;

        public StateMachineExecutor(StateMachine sm)
        {
            stateMachine = sm;
        }

        public void ExecuteAction(string action)
        {
            Console.WriteLine($"Performing action '{action}' in state {stateMachine.currentState}");
        }
    }
}

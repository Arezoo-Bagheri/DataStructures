namespace DataStructures.Stack
{
    public class StateMachineExecutor : IStateMachineActions
    {
        private StateMachine _stateMachine;

        public StateMachineExecutor(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void ExecuteAction(string action)
        {
            Console.WriteLine($"Performing action '{action}' in state {_stateMachine.currentState}");
        }
    }
}

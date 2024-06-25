namespace DataStructures.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            StateMachine machine = new StateMachine(1);
            IStateMachineActions executor = new StateMachineExecutor(machine);

            executor.ExecuteAction("Initialize");

            machine.PushState(2);
            executor.ExecuteAction("Performing state 2 action");

            machine.PushState(3);
            executor.ExecuteAction("Performing state 3 action");

            machine.PopState();
            executor.ExecuteAction("Back to state 2 action");

            machine.PopState();
            executor.ExecuteAction("Back to state 1 action");

        }
    }
}

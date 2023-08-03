public abstract class BaseState
{
    //instance of enemy clas
    public StateMachine stateMachine;

    public abstract void Enter();
    public abstract void Perform();
    public abstract void Exit();

}
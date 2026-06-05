using System;

[Serializable]
public class FSMState
{
    public string ID;
    public FSMAction[] Actions;
    public FSMTransition[] Transitions;

    public void UpdateState()
    {
        ExecuteActions();
    }

    private void ExecuteActions()
    {
        for(int i = 0; i < Actions.Length; i++)
        {
            Actions[i].Act();
        }
    }
}

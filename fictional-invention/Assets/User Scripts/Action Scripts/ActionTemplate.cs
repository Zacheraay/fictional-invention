using UnityEngine;

public abstract class ActionTemplate {
    public Action action { get; private set; }
    public KeyCode key { get; set; }
    public InputType input { get; set; }
    protected bool execute_next = false;

    public bool execute() {
        bool return_value = execute_next;
        inputActionType();
        return return_value;
    }

    protected abstract void inputActionType();
}

public class SingleAction : ActionTemplate {
    protected override void inputActionType() {
        if (input.GetType() == typeof(HoldInput)) {
            this.execute_next = ((HoldInput) input).heldForDuration();
        } else {
            this.execute_next = input.isActive();
        }
    }
}

public class ContinuousAction : ActionTemplate {
    protected override void inputActionType() {
        if (input.GetType() == typeof(HoldInput)) {
            execute_next = input.isActive();
        } else if (input.isActive()) {
            execute_next = !execute_next;
        }
    }
}

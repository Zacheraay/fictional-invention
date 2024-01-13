using UnityEngine;

[CreateAssetMenu(fileName = "New Action", menuName = "ScriptableObject/Action")]
public class Action : ScriptableObject {
    public ActionCode action_code;
    public ActionType action_type;
    public KeyCode key;
    public KeyCode DEFAULT_KEY;
    public InputCode input_type;
    public InputCode DEFAULT_INPUT;
    private InputStrategy input;

    public void setInputStrategy(InputStrategy input) {
        this.input = input;
    }

    private bool enabled = false;
    public bool isEnabled() {
        bool return_value = this.enabled;
        inputActionBehavior();
        return return_value;
    }

    public void keyPressed() {
        input.press();
    }

    public void keyReleased() {
        input.release();
    }

    private void inputActionBehavior() {
        if (action_type == ActionType.Single)
            singleBehavior();
        else if (action_type == ActionType.Continuous)
            continuousBehavior();
    }

    private void singleBehavior() {
        if (input.GetType() == typeof(HoldInput)) {
            this.enabled = ((HoldInput) input).heldForDuration();
        } else {
            this.enabled = input.isActive();
        }
    }

    private void continuousBehavior() {
        if (input.GetType() == typeof(HoldInput)) {
            this.enabled = input.isActive();
        } else if (input.isActive()) {
            this.enabled = !this.enabled;
        }
    }
}

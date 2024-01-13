using UnityEngine;

public class HoldInput : InputStrategy {
    private static float DEFAULT_HOLD_DURATION = 0.5f;
    private float start_of_hold = 0f;
    public override void press() {
        this.active = true;
        start_of_hold = Time.time;
    }

    public override void release() {
        this.active = false;
    }

    public override bool isActive() {
        return this.active;
    }

    public bool heldForDuration() {
        if (!isActive() || Time.time < start_of_hold + DEFAULT_HOLD_DURATION)
            return false;
        this.active = false;
        return true;
    }
}

using UnityEngine;

public class DoubleTapStrategy : InputStrategy {
    private static float DEFAULT_DOUBLE_TAP_INTERVAL = 0.5f;
    private float next_press = 0f;
    public override void press() {
        if (Time.time > next_press)
            next_press = Time.time + DEFAULT_DOUBLE_TAP_INTERVAL;
        else {
            next_press = 0f;
            this.active = true;
        }
    }

    public override void release() {
        return;
    }

    public override bool isActive() {
        return this.setFalse();
    }
}

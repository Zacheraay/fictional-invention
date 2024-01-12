public class PressInput : InputType {
    public override void press() {
        this.active = true;
    }

    public override void release() {
        return;
    }

    public override bool isActive() {
        return this.setFalse();
    }
}

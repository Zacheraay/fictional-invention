public class PressStrategy : InputStrategy {
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

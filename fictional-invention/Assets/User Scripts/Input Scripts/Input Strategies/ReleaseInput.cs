public class ReleaseInput : InputStrategy {
    public override void press() {
        return;
    }

    public override void release() {
        this.active = true;
    }

    public override bool isActive() {
        return this.setFalse();
    }
}

public class HoldStrategy : InputStrategy {
    public override void press() {
        this.active = true;
    }

    public override void release() {
        this.active = false;
    }

    public override bool isActive() {
        return this.active;
    }
}

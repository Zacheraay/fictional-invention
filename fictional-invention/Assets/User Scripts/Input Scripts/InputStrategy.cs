public abstract class InputStrategy {
    protected bool active = false;
    public abstract void press();
    public abstract void release();
    
    public virtual bool isActive() {
        return this.active;
    }

    protected bool setFalse() {
        bool temp = active;
        this.active = false;
        return temp;
    }
}

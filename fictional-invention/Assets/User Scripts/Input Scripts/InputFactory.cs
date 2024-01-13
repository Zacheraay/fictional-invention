public class InputFactory {
    public InputStrategy createInput(InputCode strategy) {
        switch(strategy) {
            case InputCode.Press:
                return new PressInput();
            case InputCode.Release:
                return new ReleaseInput();
            case InputCode.Hold:
                return new HoldInput();
            case InputCode.DoubleTap:
                return new DoubleTapInput();
            default:
                return null;
        }
    }
}

public class InputFactory {
    public InputType createInputStrategy(string strategy) {
        switch(strategy) {
            case "press":
                return new PressInput();
            case "release":
                return new ReleaseInput();
            case "hold":
                return new HoldInput();
            case "double tap":
                return new DoubleTapInput();
            default:
                return null;
        }
    }
}

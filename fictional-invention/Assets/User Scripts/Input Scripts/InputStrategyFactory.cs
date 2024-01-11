public class InputStrategyFactory {
    public InputStrategy createInputStrategy(string strategy) {
        switch(strategy) {
            case "press":
                return new PressStrategy();
            case "release":
                return new ReleaseStrategy();
            case "hold":
                return new HoldStrategy();
            case "double tap":
                return new DoubleTapStrategy();
            default:
                return null;
        }
    }
}

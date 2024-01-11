using UnityEngine;

public class ActionControl {
    public string key { get; set; }
    public InputStrategy input { get; set; }

    public ActionControl(string key, InputStrategy input) {
         this.key = key;
         this.input = input;
    }

    public bool isActive() {
        return input.isActive();
    }
}

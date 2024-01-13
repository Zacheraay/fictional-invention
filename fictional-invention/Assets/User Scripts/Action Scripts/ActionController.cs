using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PlasticGui.WorkspaceWindow;
using Unity.VisualScripting.YamlDotNet.Core.Tokens;
using UnityEngine;

public class ActionController : MonoBehaviour {
    [SerializeField]
    private List<Action> actions = new List<Action>();
    private List<KeyCode> used_keys = new List<KeyCode>();
    private List<KeyCode> down_keys = new List<KeyCode>();
    private InputFactory input_factory = new InputFactory();

    private void Start() {
        initializeActions();
    }

    private void Update() {
        foreach(KeyCode key in used_keys) {
            if (Input.GetKeyDown(key)) {
                down_keys.Add(key);
                getActionsByKey(key).ForEach(action => action.keyPressed());
            }
        }
        foreach(KeyCode key in down_keys.ToList()) {
            if (Input.GetKeyUp(key)) {
                down_keys.Remove(key);
                getActionsByKey(key).ForEach(action => action.keyReleased());
            }
        }
    }

    private void FixedUpdate() {
        foreach(Action action in actions) {
            if (action.isEnabled())
                Debug.Log(action.action_code);
        }
    }

    private void initializeActions() {
        foreach(Action action in actions) {
            InputStrategy input = input_factory.createInput(action.input_type);
            action.setInputStrategy(input);
            used_keys.Add(action.key);
        }
    }

    private bool getActionByCode(ActionCode action_code) {
        return actions.Find(action => action.action_code == action_code).isEnabled();
    }

    private List<Action> getActionsByKey(KeyCode key) {
        return actions.Where(action => action.key == key).ToList();
    }
}

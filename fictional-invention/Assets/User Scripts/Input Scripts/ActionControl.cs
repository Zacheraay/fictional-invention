using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionControl : MonoBehaviour
{
    private InputStrategy input;
    private string key;

    public void setInput(InputStrategy input)
    {
        this.input = input;
    }

    public string getKey() {
        return this.key;
    }
}

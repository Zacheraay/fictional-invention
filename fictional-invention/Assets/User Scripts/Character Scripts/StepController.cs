using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepController : MonoBehaviour
{
    private StepState front_foot;
    private StepState back_foot;
    [SerializeField]
    private StepState left_foot;
    [SerializeField]
    private StepState right_foot;

    void Start()
    {
        front_foot = left_foot;
        back_foot = right_foot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

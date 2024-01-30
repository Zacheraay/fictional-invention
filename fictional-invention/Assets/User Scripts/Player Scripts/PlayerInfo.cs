using UnityEngine;

public class PlayerInfo : MonoBehaviour {
    [SerializeField]
    private Transform center_mass;

    public Vector3 getCenterMass() {
        return center_mass.position;
    }
}

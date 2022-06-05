using UnityEngine;

public class WallsEvents : MonoBehaviour
{
    [SerializeField] private bool hideWall;
    MeshRenderer _meshRendering;
    BoxCollider _boxCollider;
    private void Awake()
    {
        _meshRendering = GetComponent<MeshRenderer>();
        _boxCollider = GetComponent<BoxCollider>();
    }
    private void OnEnable()
    {
        Debug.Log(this.gameObject + " Listen event ON_WALLS_TRIGGERED");
        LampTrigger.ON_WALLS_TRIGGERED += WallChanging;
    }
    private void OnDisable()
    {
        LampTrigger.ON_WALLS_TRIGGERED -= WallChanging;
    }

    void WallChanging()
    {
        if (hideWall)
        {
            _meshRendering.enabled = false;
            _boxCollider.enabled = false;
            // this.gameObject.SetActive(false);
        }
        else
        {
            _meshRendering.enabled = true;
            _boxCollider.enabled = true;
            // this.gameObject.SetActive(true);
        }
        Debug.Log(this.gameObject.name + " TRIGGERED " + hideWall);
    }
}

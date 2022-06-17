using UnityEngine;

public class Totem : MonoBehaviour
{
    [SerializeField] private Interlayer interlayer;
    private float time = 0;
    [SerializeField] private int number = 0;
    [SerializeField] private GameObject glowingTotem;
    /*
     * Компоненты погасшего тотема
     */
    private MeshRenderer meshRenderer;
    private BoxCollider boxCollider;
    //private MeshRenderer glowingTotemMeshRenderer;
    //private BoxCollider glowingTotemBoxCollider;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        boxCollider = GetComponent<BoxCollider>();
        //glowingTotemMeshRenderer = glowingTotem.GetComponent<MeshRenderer>();
        //glowingTotemBoxCollider = glowingTotem.GetComponent<BoxCollider>();
    }

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E) && time < Time.time)
        {
            lightTotem();
            interlayer.click(this);
            time = Time.time + 1;
            EventManager.getOnExitFlameTrigger().Invoke();
        }
    }
    void OnTriggerEnter()
    {
        EventManager.getOnEnterFlameTrigger().Invoke();
    }

    void OnTriggerExit()
    {
        EventManager.getOnExitFlameTrigger().Invoke();
    }

    public void lightTotem()
    {
        meshRenderer.enabled = false;
        boxCollider.enabled = false;
        glowingTotem.SetActive(true);
    }

    public void extinguishTotem()
    {
        meshRenderer.enabled = true;
        boxCollider.enabled = true;
        glowingTotem.SetActive(false);
    }

    public int getNumber()
    {
        return number;
    }
}

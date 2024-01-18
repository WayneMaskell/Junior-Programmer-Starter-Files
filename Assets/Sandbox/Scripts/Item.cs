using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IGrabbable
{
    private MeshRenderer m_Renderer;

    private Color defaultColour;

    public string itemName;


    public void OnDrop()
    {
        transform.SetParent(null);
        Debug.Log($"{itemName} has been Dropped");
    }

    public void OnGrab(Transform grabPoint)
    {
        transform.SetParent(grabPoint);
        Debug.Log($"{itemName} has been Grabbed");
    }

    public void OnHoverEnter()
    {
        m_Renderer.material.color = Color.yellow;
        Debug.Log($"{itemName} has been found");
    }

    public void OnHoverExit()
    {
        m_Renderer.material.color = defaultColour;
        Debug.Log($"{itemName} has been left alone");
    }

    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        defaultColour = m_Renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

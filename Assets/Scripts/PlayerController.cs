using UnityEngine;
namespace Golf
{
public class Plaercontroller : MonoBehaviour
{
    public Transform stick;
    public float max_Angel = 30;
    void Update()
    {
        var angle = stick.localEulerAngles;
        if(Input.GetMouseButton(0))
        {
            
        }
    }
}
}

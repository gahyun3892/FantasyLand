using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

public class LookItem : MonoBehaviour
{

    public void OnLookItemBox(bool isLookAt)
        {
            Debug.Log(isLookAt);
        MoveCtrl.isStopped = isLookAt;
        }

    public void OnPosterEnter(PointerEventData eventData)
    {
        MoveCtrl.isStopped = true;
    }

    public void OnPosterExit(PointerEventData eventData)
    {
        MoveCtrl.isStopped = false;
    }

    public void OnGvrPointerHover(PointerEventData eventData)
    {
        Debug.Log("Reticle On");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public abstract class Interactable : MonoBehaviour
{
    //Add or remove InteractionEvent component to this gameObject.
    public bool useEvents;
    [SerializeField]
    public string promptMessage;

    public virtual string OnLook()
    {
        return promptMessage;
    }

    public void BaseInteract()
    {
        if (useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }

    protected virtual void Interact()
    {
        //We wont have any code written in this function
        //this is a template function to be overriden by our subclasses
    }

}

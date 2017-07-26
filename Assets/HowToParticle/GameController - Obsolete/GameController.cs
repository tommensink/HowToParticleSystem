using UnityEngine.Events;
using UnityEngine.VR.WSA.Input;
using UnityEngine;
using HoloToolkit.Unity.InputModule;


public class GameController : MonoBehaviour, IInputClickHandler
{
    [Tooltip("On click event")]
    public UnityEvent OnClickEvent;

    private GestureRecognizer recognizer;

    // Use this for initialization
    void Start () {
        Debug.Log("Start GameController", gameObject);

        recognizer = new GestureRecognizer();
        recognizer.SetRecognizableGestures(GestureSettings.Tap);
        recognizer.TappedEvent += MyTapEventHandler;
        recognizer.StartCapturingGestures();
    }

    // Update is called once per frame
    void Update () {
/*
        if (Input.GetButton("Fire1")) // Ctrl key or Left mouse
        {
            if (OnClickEvent != null) { OnClickEvent.Invoke(); }
        }
*/
    }

    private void MyTapEventHandler(InteractionSourceKind source, int tapCount, Ray headRay)
    {
        Debug.Log("MyTapEventHandler", gameObject);
        if (OnClickEvent != null) { OnClickEvent.Invoke(); }
    }

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("OnInputClicked", gameObject);
        if (OnClickEvent != null) { OnClickEvent.Invoke(); }
    }

}

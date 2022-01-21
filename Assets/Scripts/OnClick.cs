using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class OnClick : MonoBehaviour
{
    public UnityEvent _onEnterOver,_onExitOver;
    public UnityEvent<EmplacementVide> _onClick;
    public EmplacementVide batiment;

    public void OnMouseDown()
    {
        _onClick.Invoke(batiment);
    }

    public void OnMouseEnter()
    {
        _onEnterOver.Invoke();
    }

    private void OnMouseExit()
    {
        _onExitOver.Invoke();
    }


}

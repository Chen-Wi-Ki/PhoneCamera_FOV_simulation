using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera1ViewSwitchEvent : MonoBehaviour
{
    public Camera _camera;
    public Dropdown _dropdown;
    int _resolution;

    public void ViewSwitch()
    {
        _resolution = _dropdown.value;
        switch (_resolution)
        {
            case (0):
                _camera.rect=new Rect(new Vector2 (0.75f,0), new Vector2 (0.25f,0.425f));
                break;
            case (1):
                _camera.rect = new Rect(new Vector2(0.75f, 0), new Vector2(0.25f, 0.5f));
                break;
            case (2):
                _camera.rect = new Rect(new Vector2(0.75f, 0), new Vector2(0.25f, 0.55f));
                break;
            case (3):
                _camera.rect = new Rect(new Vector2(0.75f, 0), new Vector2(0.25f, 0.5925f));
                break;
            case (4):
                _camera.rect = new Rect(new Vector2(0, 0), new Vector2(0, 0));
                break;

        }
    }
}

using UnityEngine;

public class Quit : MonoBehaviour, IInteractable
{
    /// <summary>
    /// Exits the application on button click
    /// </summary>
    public void OnClick() => Application.Quit();
}

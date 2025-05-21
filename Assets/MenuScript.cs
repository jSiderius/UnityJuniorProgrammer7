using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void SaveColor()
    {
        GlobalData.Instance.SetColor(GameObject.Find("ColorPicker").GetComponent<ColorPicker>().SelectedColor);
    }

    public void LoadColor()
    {
        GlobalData.Instance.LoadColor();
    }
}


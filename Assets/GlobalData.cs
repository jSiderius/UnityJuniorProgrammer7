using UnityEngine;

public class GlobalData : MonoBehaviour
{

    public static GlobalData Instance { get; private set; }
    public Color color; // = new Color(0,0,0,1);

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadColor();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveColor()
    {
        PlayerPrefs.SetFloat("R", color.r);
        PlayerPrefs.SetFloat("G", color.g);
        PlayerPrefs.SetFloat("B", color.b);
        PlayerPrefs.SetFloat("A", color.a);
        PlayerPrefs.Save();
    }

    public void LoadColor()
    {
        float r = PlayerPrefs.GetFloat("R", 1f);
        float g = PlayerPrefs.GetFloat("G", 1f);
        float b = PlayerPrefs.GetFloat("B", 1f);
        float a = PlayerPrefs.GetFloat("A", 1f);
        color = new Color(r, g, b, a);

    }

    public void SetColor(Color c)
    {
        color = c;
        SaveColor();
    }
}
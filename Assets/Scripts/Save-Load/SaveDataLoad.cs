using UnityEngine;
using System.IO;

public class MiniSLXScript
{
    //Variables para modificar:
    private readonly string dataPath = Application.persistentDataPath + "/playerData.json"; //<-- Ruta de guardado, cambiar solo el nombre del archivo: Ej: "\archivoGuardado.dat"
    private readonly static string key = "���§¶∞¶•¶ª���§§∞§∞ƒç©∂ß∫∫���©f∂©©©©∂∂∂∂ƒçf��"; //<-- Clave para la encriptaci�n XOR. **IMPORTANTE NO COMPARTIR CON NADIE**


    public void SaveData(PlayerData data, bool encrypt) //<-- Funci�n de guardado de datos
    {
        string jsonData = JsonUtility.ToJson(data);
        string contentToSave;

        if (encrypt)
        {
            contentToSave = XORCipher(jsonData);
        }
        else
        {
            contentToSave = jsonData;
        }

        File.WriteAllText(dataPath, contentToSave);
        Debug.Log(dataPath);
    }

    public PlayerData LoadData(bool decrypt) //<-- Funci�n de carga de datos
    {
        string contentToLoad = File.ReadAllText(dataPath);
        string loadedData;

        if (decrypt)
        {
            loadedData = XORCipher(contentToLoad);
        }
        else
        {
            loadedData = contentToLoad;
        }

        return JsonUtility.FromJson<PlayerData>(loadedData);
    }

    static string XORCipher(string data)
    {
        int dataLen = data.Length;
        int keyLen = key.Length;
        char[] output = new char[dataLen];

        for (int i = 0; i < dataLen; ++i)
        {
            output[i] = (char)(data[i] ^ key[i % keyLen]);
        }

        return new string(output);
    }
}

public class PlayerData //Clase de datos a guardar. Incluir todas las variables que se quieran guardar, CON ACCESO PUBLICO (Ej: public int nombreVariable; )
{
    
}


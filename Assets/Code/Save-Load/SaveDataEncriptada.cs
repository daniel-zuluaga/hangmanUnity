using UnityEngine;
using System.IO;

public class SaveDataEncriptada
{
    private string dataPath = Application.persistentDataPath + "/dataPlayer.json"; //<-- Ruta de guardado, cambiar solo el nombre del archivo: Ej: "\archivoGuardado.dat"
    private static string key = "%&∞§§∞¶√çç©ç¥¨~ııiıı¥ƒ†∂®∂®ç©√∫��bjnmn¶•¶•¶§∞¢¢§§¢���"; //<-- Clave para la encriptaci�n XOR. **IMPORTANTE NO COMPARTIR CON NADIE**

    public void SaveData(PlayerMoney data, bool encrypt) //<-- Funci�n de guardado de datos
    {
        string jsonData = JsonUtility.ToJson(data);
        string contentToSave = "";

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

    public PlayerMoney LoadData(bool decrypt) //<-- Funci�n de carga de datos
    {
        if (File.Exists(dataPath))
        {
            string contentToLoad = File.ReadAllText(dataPath);
            string loadedData = "";

            if (decrypt)
            {
                loadedData = XORCipher(contentToLoad);
            }
            else
            {
                loadedData = contentToLoad;
            }

            return JsonUtility.FromJson<PlayerMoney>(loadedData);
        }
        else
        {
            Debug.Log("El archivo no existe");
            return null;
        }
    }

    private static string XORCipher(string data)
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


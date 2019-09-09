using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace hydroger.data
{

    // Save and load data from save files.
    public static class SaveSystem
    {
        public static void Save(Data data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/data.hr";
            FileStream stream = new FileStream(path, FileMode.Create);

            GameData gameData = new GameData(data);

            formatter.Serialize(stream, gameData);
            stream.Close();

        }

        public static GameData Load()
        {
            string path = Application.persistentDataPath + "/data.hr";
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                GameData gameData = formatter.Deserialize(stream) as GameData;

                stream.Close();

                return gameData;
            }
            else
            {
                return null;
            }
        }
    }

}

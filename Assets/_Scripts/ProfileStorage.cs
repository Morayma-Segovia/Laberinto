using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class ProfileStorage : MonoBehaviour
{
    public static ProfileData s_currentProfile;
    private static string s_indexPath = Application.streamingAssetsPath + "/Profiles/_ProfileIndex_.xml";

    public static void CreateNewGame(string profileName)
    {
        s_currentProfile = new ProfileData(profileName, true, 0, 0, 0, 0);
        string path = Application.streamingAssetsPath + "/Profiles/" + s_currentProfile.filename;
        SaveFile<ProfileData>(path, s_currentProfile);

        var index = GetProfileIndex();
        index.profileFileNames.Add(s_currentProfile.filename);

        SaveFile<ProfileIndex>(s_indexPath, index);
    }
    
    public static ProfileIndex GetProfileIndex()
    {
        if (File.Exists(s_indexPath) == false)
        {
            return new ProfileIndex();
        }

        return LoadFile<ProfileIndex>(s_indexPath);
    }

    public static void LoadProfile(string filename)
    {
        var path = Application.streamingAssetsPath + "/Profile/" + filename;
        s_currentProfile = LoadFile<ProfileData>(path);
    }
    public static void StoragePlayerProfile(GameObject player)
    {
        s_currentProfile.x = player.transform.position.x;
        s_currentProfile.y = player.transform.position.y;
        s_currentProfile.z = player.transform.position.z;
        
        s_currentProfile.newGame = false;

        var path = Application.streamingAssetsPath + "/Profile/" + s_currentProfile.filename;
        SaveFile<ProfileData>(path, s_currentProfile);
    }
    public static void DeleteProfile(string filename)
    {
        var path = Application.streamingAssetsPath + "/Profile/" + filename;
        File.Delete(path);

        var index = LoadFile<ProfileIndex>(s_indexPath);
        index.profileFileNames.Remove(filename);

        SaveFile<ProfileIndex>(s_indexPath, index);
    }

    static void SaveFile<T>(string path, T data)
    {
        var profileWriter = new StreamWriter(path);
        var profileSerializer = new XmlSerializer(typeof(T));
        profileSerializer.Serialize(profileWriter, data);
        profileWriter.Dispose();
    }
    static T LoadFile<T>(string path)
    {
        var profileReader = new StreamReader(path);
        var serializer = new XmlSerializer(typeof(T));
        var obj = (T)serializer.Deserialize(profileReader);
        profileReader.Dispose();
        
        return obj;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Library {

    static private Dictionary<int, string> fileNameKey = new Dictionary<int, string>();
    static private Dictionary<int, int> option1 = new Dictionary<int, int>(), option2 = new Dictionary<int, int>(),
                                        option3 = new Dictionary<int, int>(), option4 = new Dictionary<int, int>();
    static private Dictionary<int, Vector2> option1Pos = new Dictionary<int, Vector2>(),
                                        option2Pos = new Dictionary<int, Vector2>(),
                                        option3Pos = new Dictionary<int, Vector2>(),
                                        option4Pos = new Dictionary<int, Vector2>();
    static private Dictionary<int, float> option1Time = new Dictionary<int, float>(),
                                        option2Time = new Dictionary<int, float>(),
                                        option3Time = new Dictionary<int, float>(),
                                        option4Time = new Dictionary<int, float>();
    static private Dictionary<int, int> endingDictionary = new Dictionary<int, int>();

    static Library()
    {
        SetKeys();
        SetOptions();
        SetButtonPositions();
        SetOptionTimes();
        SetEndings();
    }

    public static void SetKeys()
    {
        fileNameKey.Add(1, "A Date With Markiplier");
        fileNameKey.Add(2, "Pay");
        fileNameKey.Add(3, "Don't Pay");
        fileNameKey.Add(4, "Attack");
        fileNameKey.Add(5, "Don't Attack");
        fileNameKey.Add(6, "Dig");
        fileNameKey.Add(7, "Exit");
        fileNameKey.Add(8, "Freedom");
        fileNameKey.Add(9, "Horror");
        fileNameKey.Add(10, "Leave");
        fileNameKey.Add(11, "Left");
        fileNameKey.Add(12, "No");
        fileNameKey.Add(13, "PBJ");
        fileNameKey.Add(14, "Pick Lock");
        fileNameKey.Add(15, "Right");
        fileNameKey.Add(16, "Road");
        fileNameKey.Add(17, "Romance");
        fileNameKey.Add(18, "Shiny");
        fileNameKey.Add(19, "Split Up");
        fileNameKey.Add(20, "Stay Together");
        fileNameKey.Add(21, "Tuna");
        fileNameKey.Add(22, "Yes");
        fileNameKey.Add(23, "Relax");
        fileNameKey.Add(24, "Don't Blink");
        fileNameKey.Add(25, "Don't Move");
    }

    public static void SetOptions()
    {
        option1.Add(1, 2);
        option2.Add(1, 3);

        option1.Add(2, 9);
        option2.Add(2, 17);

        option1.Add(3, 4);
        option2.Add(3, 5);

        option1.Add(4, 16);
        option2.Add(4, 18);

        option1.Add(5, 6);
        option2.Add(5, 14);

        option1.Add(6, 1);

        option1.Add(7, 5);

        option1.Add(8, 11);
        option2.Add(8, 15);

        option1.Add(9, 8);
        option2.Add(9, 23);
        option3.Add(9, 24);
        option4.Add(9, 25);

        option1.Add(10, 22);
        option2.Add(10, 12);

        option1.Add(11, 1);

        option1.Add(12, 1);

        option1.Add(13, 1);

        option1.Add(14, 19);
        option2.Add(14, 20);

        option1.Add(15, 1);

        option1.Add(16, 21);
        option2.Add(16, 13);

        option1.Add(17, 9);
        option2.Add(17, 10);

        option1.Add(18, 1);

        option1.Add(19, 1);

        option1.Add(20, 7);
        option2.Add(20, 3);

        option1.Add(21, 1);

        option1.Add(22, 1);
    }

    public static void SetButtonPositions()
    {
        //time :52
        option1Pos.Add(1, new Vector2(-73, 182));
        option2Pos.Add(1, new Vector2(-73, -172));

        //time 1:30
        option1Pos.Add(2, new Vector2(0, 0));
        option2Pos.Add(2, new Vector2(0, 0));

        //time 1:07
        option1Pos.Add(3, new Vector2(0, 0));
        option2Pos.Add(3, new Vector2(0, 0));

        //time 1:12
        option1Pos.Add(4, new Vector2(0, 0));
        option2Pos.Add(4, new Vector2(0, 0));

        //time 1:44
        option1Pos.Add(5, new Vector2(0, 0));
        option2Pos.Add(5, new Vector2(0, 0));

        //time 9:48
        option1Pos.Add(6, new Vector2(0, 0));

        //time 1:03
        option1Pos.Add(7, new Vector2(0, 0));
        option2Pos.Add(7, new Vector2(0, 0));

        //time 1:18
        option1Pos.Add(8, new Vector2(0, 0));
        option2Pos.Add(8, new Vector2(0, 0));

        //time 2:04
        option1Pos.Add(9, new Vector2(0, 0));
        option2Pos.Add(9, new Vector2(0, 0));
        option3Pos.Add(9, new Vector2(0, 0));
        option4Pos.Add(9, new Vector2(0, 0));

        //time 1:01
        option1Pos.Add(10, new Vector2(0, 0));
        option2Pos.Add(10, new Vector2(0, 0));

        //time :52
        option1Pos.Add(11, new Vector2(0, 0));
        option2Pos.Add(11, new Vector2(0, 0));

        //time 1:31
        option1Pos.Add(12, new Vector2(0, 0));
        option2Pos.Add(12, new Vector2(0, 0));

        //time 1:15
        option1Pos.Add(13, new Vector2(0, 0));
        option2Pos.Add(13, new Vector2(0, 0));

        //time 1:00
        option1Pos.Add(14, new Vector2(0, 0));
        option2Pos.Add(14, new Vector2(0, 0));

        //time 1:13
        option1Pos.Add(15, new Vector2(0, 0));
        option2Pos.Add(15, new Vector2(0, 0));

        //time :56
        option1Pos.Add(16, new Vector2(0, 0));
        option2Pos.Add(16, new Vector2(0, 0));

        //time 1:41
        option1Pos.Add(17, new Vector2(0, 0));
        option2Pos.Add(17, new Vector2(0, 0));

        //time 1:04
        option1Pos.Add(18, new Vector2(0, 0));
        option2Pos.Add(18, new Vector2(0, 0));

        //time :17
        option1Pos.Add(19, new Vector2(0, 0));
        option2Pos.Add(19, new Vector2(0, 0));

        //time 1:04
        option1Pos.Add(20, new Vector2(0, 0));
        //time 1:16
        option2Pos.Add(20, new Vector2(0, 0));

        //time :58
        option1Pos.Add(21, new Vector2(0, 0));
        option2Pos.Add(21, new Vector2(0, 0));

        //time 1:48
        option1Pos.Add(22, new Vector2(0, 0));
        option2Pos.Add(22, new Vector2(0, 0));
    }

    public static void SetOptionTimes()
    {
        //time :52
        option1Time.Add(1, 52f);
        option2Time.Add(1, 52f);
        option3Time.Add(1, 52f);
        option4Time.Add(1, 52f);

        //time 1:30
        option1Time.Add(2, 90f);
        option2Time.Add(2, 90f);
        option3Time.Add(2, 90f);
        option4Time.Add(2, 90f);

        //time 1:07
        option1Time.Add(3, 67f);
        option2Time.Add(3, 67f);
        option3Time.Add(3, 67f);
        option4Time.Add(3, 67f);

        //time 1:12
        option1Time.Add(4, 72f);
        option2Time.Add(4, 72f);
        option3Time.Add(4, 72f);
        option4Time.Add(4, 72f);

        //time 1:44
        option1Time.Add(5, 104f);
        option2Time.Add(5, 104f);
        option3Time.Add(5, 104f);
        option4Time.Add(5, 104f);

        //time 9:48
        option1Time.Add(6, 588f);
        option2Time.Add(6, 588f);
        option3Time.Add(6, 588f);
        option4Time.Add(6, 588f);

        //time 1:03
        option1Time.Add(7, 63f);
        option2Time.Add(7, 63f);
        option3Time.Add(7, 63f);
        option4Time.Add(7, 63f);

        //time 1:18
        option1Time.Add(8, 78f);
        option2Time.Add(8, 78f);
        option3Time.Add(8, 78f);
        option4Time.Add(8, 78f);

        //time 2:04
        option1Time.Add(9, 124f);
        option2Time.Add(9, 124f);
        option3Time.Add(9, 124f);
        option4Time.Add(9, 124f);

        //time 1:01
        option1Time.Add(10, 61f);
        option2Time.Add(10, 61f);
        option3Time.Add(10, 61f);
        option4Time.Add(10, 61f);

        //time :52
        option1Time.Add(11, 52f);
        option2Time.Add(11, 52f);
        option3Time.Add(11, 52f);
        option4Time.Add(11, 52f);

        //time 1:31
        option1Time.Add(12, 91f);
        option2Time.Add(12, 91f);
        option3Time.Add(12, 91f);
        option4Time.Add(12, 91f);

        //time 1:15
        option1Time.Add(13, 75f);
        option2Time.Add(13, 75f);
        option3Time.Add(13, 75f);
        option4Time.Add(13, 75f);

        //time 1:00
        option1Time.Add(14, 60f);
        option2Time.Add(14, 60f);
        option3Time.Add(14, 60f);
        option4Time.Add(14, 60f);

        //time 1:13
        option1Time.Add(15, 73f);
        option2Time.Add(15, 73f);
        option3Time.Add(15, 73f);
        option4Time.Add(15, 73f);

        //time :56
        option1Time.Add(16, 56f);
        option2Time.Add(16, 56f);
        option3Time.Add(16, 56f);
        option4Time.Add(16, 56f);

        //time 1:41
        option1Time.Add(17, 101f);
        option2Time.Add(17, 101f);
        option3Time.Add(17, 101f);
        option4Time.Add(17, 101f);

        //time 1:04
        option1Time.Add(18, 64f);
        option2Time.Add(18, 64f);
        option3Time.Add(18, 64f);
        option4Time.Add(18, 64f);

        //time :17
        option1Time.Add(19, 17f);
        option2Time.Add(19, 17f);
        option3Time.Add(19, 17f);
        option4Time.Add(19, 17f);

        //time 1:04
        option1Time.Add(20, 64);
        //time 1:16
        option2Time.Add(20, 76f);
        option3Time.Add(20, 76f);
        option4Time.Add(20, 76f);

        //time :58
        option1Time.Add(21, 58f);
        option2Time.Add(21, 58f);
        option3Time.Add(21, 58f);
        option4Time.Add(21, 58f);

        //time 1:48
        option1Time.Add(22, 108f);
        option2Time.Add(22, 108f);
        option3Time.Add(22, 108f);
        option4Time.Add(22, 108f);
    }

    public static void SetEndings()
    {
        endingDictionary.Add(22, 1);
        endingDictionary.Add(12, 2);
        endingDictionary.Add(15, 3);
        endingDictionary.Add(11, 4);
        endingDictionary.Add(13, 5);
        endingDictionary.Add(21, 6);
        endingDictionary.Add(18, 7);
        endingDictionary.Add(6, 8);
        endingDictionary.Add(19, 9);

        //secret ending not implemented yet
        endingDictionary.Add(26, 10);
    }

    public static string GetFileName(int key)
    {
        string str = fileNameKey[key];
        return str;
    }

    public static Dictionary<int, int> GetOption1()
    {
        return option1;
    }
    public static Dictionary<int, int> GetOption2()
    {
        return option2;
    }
    public static Dictionary<int, int> GetOption3()
    {
        return option3;
    }
    public static Dictionary<int, int> GetOption4()
    {
        return option4;
    }

    public static int GetOption(int key, int option)
    {
        switch(option)
        {
            case 1:
                return GetOption1()[key];
            case 2:
                return GetOption2()[key];
            case 3:
                return GetOption3()[key];
            case 4:
                return GetOption4()[key];
            default:
                return GetOption1()[key];
        };
    }

    public static float GetOptionTime(int key, int option)
    {
        switch (option)
        {
            case 1:
                return option1Time[key];
            case 2:
                return option2Time[key];
            case 3:
                return option3Time[key];
            case 4:
                return option4Time[key];
            default:
                return option1Time[key];
        };
    }

    public static Vector2 GetOptionPos(int key, int option)
    {
        switch (option)
        {
            case 1:
                if (option1Pos.ContainsKey(key))
                    return option1Pos[key];
                break;
            case 2:
                if (option2Pos.ContainsKey(key))
                    return option2Pos[key];
                break;
            case 3:
                if (option3Pos.ContainsKey(key))
                    return option3Pos[key];
                break;
            case 4:
                if (option4Pos.ContainsKey(key))
                    return option4Pos[key];
                break;
            default:
                break;
        };

        return Vector2.zero;
    }

    public static Dictionary<int, string> GetStarting()
    {
        return fileNameKey;
    }

    public static bool DoesKeyExist(int key, Dictionary<int, float> dic)
    {
        if (dic.ContainsKey(key))
            return true;
        else
            return false;
    }

    public static bool DoesKeyExist(int key, Dictionary<int, int> dic)
    {
        if (dic.ContainsKey(key))
            return true;
        else
            return false;
    }

    public static bool DoesKeyExist(int key, Dictionary<int, string> dic)
    {
        if (dic.ContainsKey(key))
            return true;
        else
            return false;
    }

    public static bool DoesKeyExist(int key, Dictionary<int, Vector2> dic)
    {
        if (dic.ContainsKey(key))
            return true;
        else
            return false;
    }

    public static Dictionary<int, float> GetOptionTimeDictionary(int i)
    {
        switch (i)
        {
            case 1:
                return option1Time;
            case 2:
                return option2Time;
            case 3:
                return option3Time;
            case 4:
                return option4Time;
            default:
                return option1Time;
        };
    }

    public static Dictionary<int, Vector2> GetOptionPosDictionary(int i)
    {
        switch (i)
        {
            case 1:
                return option1Pos;
            case 2:
                return option2Pos;
            case 3:
                return option3Pos;
            case 4:
                return option4Pos;
            default:
                return option1Pos;
        };
    }

    public static Dictionary<int, int> GetEndingDictionary()
    {
        return endingDictionary;
    }
}

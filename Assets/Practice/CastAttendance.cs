using UdonSharp;
using UnityEngine;
//using UnityEngine.UI;
using System.IO;
using VRC.SDKBase;
using VRC.Udon;

public class CastAttendance : UdonSharpBehaviour
{
    //---- parameter ------------------------------------------
    //public int N_cast;
    private string[] castName;
    private TextAsset csvFile;
    //---------------------------------------------------------

    private void ReadCSV()
    {
        csvFile = Resources.Load("castlist.csv") as TextAsset;
        if (csvFile == null)
        {
            Debug.LogError("Failed to load 'castlist' from Resources.");
            return; // 何らかの対処を行うか、処理を中断する
        }
        StringReader reader = new StringReader(csvFile.text);

        int arraySize = 0; // 配列のサイズを管理する変数

        // サイズをカウント
        while (reader.Peek() != -1)
        {
            reader.ReadLine();
            arraySize++;
        }

        // 配列を初期化
        castName = new string[arraySize];

        // リーダーを初期化
        reader = new StringReader(csvFile.text);

        int index = 0; // 配列に要素を追加するためのインデックス

        // 要素を追加
        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            castName[index] = line;
            index++;
        }



    }

    // ワールドにジョインしたキャストの確認
    private void JoinCastCheck()
    {
        
    } 
    
    //----- 出勤表の動作 ---------------------------------------
    // 出勤表の名前を有効にする
    private void EnableCastName()
    {

    }

    // 出勤表の名前を無効にする
    private void DisableCastName()
    {

    }
    //---------------------------------------------------------
    
    //以下デバック用コード
}

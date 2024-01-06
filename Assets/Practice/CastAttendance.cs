using UdonSharp;
using UnityEngine;
//using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class CastAttendance : UdonSharpBehaviour
{
    //---- parameter ------------------------------------------
    public int N_cast = 21; //キャスト人数
    public string[] castName; //キャストの名前一覧
    //---------------------------------------------------------
    
    // N_castに数値を入れると、その分だけテキスト入力ができるstringがInspectorに表示されます
    

    void Start()
    {
        // N_castが変更された時に、castNameのサイズを更新する
        if (N_cast < 0)
        {
            N_cast = 0;
        }

        // 配列のサイズを変更
        string[] newArray = new string[N_cast];
        for (int i = 0; i < Mathf.Min(N_cast, castName.Length); i++)
        {
            newArray[i] = castName[i];
        }

        // 旧い配列を新しいものに置き換え
        castName = newArray;
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

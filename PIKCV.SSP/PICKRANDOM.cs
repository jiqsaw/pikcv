using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Collections;
using System.IO;
using System.Text;



[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedAggregate(Format.UserDefined, MaxByteSize = 8000, IsInvariantToNulls = true)]
public struct PICKRANDOM : IBinarySerialize
{
    private string m_strValues;

    public void Init()
    {
        m_strValues = "";
        // Put your code here
    }

    public void Accumulate(SqlString Value)
    {
        if (Value.IsNull)
        {
            return;
        }
        if (m_strValues == "")
        {
            m_strValues += Value.ToString();
        }
        else
        {
            m_strValues += "|" + Value.ToString();
        }
        // Put your code here
    }

    public void Merge(PICKRANDOM Group)
    {
        //foreach (object obj in Group.m_arrValues)
        //{
        //    m_arrValues.Add(obj);
        //}
        if (m_strValues == "")
        {
            m_strValues += Group;
        }
        else
        {
            m_strValues += "|" + Group;
        }

        // Put your code here
    }

    public SqlString Terminate()
    {
        // Put your code here
        if (m_strValues == "")
        {
            return null;
        }
        else if (m_strValues.IndexOf('|') == -1)
        {
            return new SqlString(m_strValues);
        }
        else
        {

            Random objRandom = new Random();
            string[] strRet = m_strValues.Split('|');
            return new SqlString(strRet[objRandom.Next(1, strRet.Length + 1) - 1].ToString());
        }
    }

    public void Read(BinaryReader r)
    {
        //r.ReadString()

        if (r == null)
        {
            return;
        }

        if (m_strValues == null)
        {
            m_strValues = "";
        }

        m_strValues = r.ReadString();

        //if (str.Length > 0)
        //{
        //    for (int i = 0; i < str.Length;i++)
        //    {
        //        m_arrValues.Add(str[i]);
        //    }
        //}
    }

    public void Write(BinaryWriter w)
    {
        //string str = "";

        //if (m_arrValues.Count > 0)
        //{
        //    for (int i = 0; i < m_arrValues.Count; i++)
        //    {
        //        if (i == 0)
        //        {
        //            str += m_arrValues[i].ToString();
        //        }
        //        else
        //        {
        //            str += "|" + m_arrValues[i].ToString();
        //        }
        //    }
        //}

        w.Write(m_strValues);
    }

}

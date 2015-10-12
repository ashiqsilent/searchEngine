﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;
/// <summary>
/// Summary description for Helper
/// </summary>
public class Helper
{
	public Helper()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string generateSearchUrl(string name, string cat, string country) {

        if (name == "") {
            name = "all";
        }
        else
        {
            name = encode(name);
        }
        cat = encode(cat);
        country = encode(country);
        return "~/searchResult/" + name + "/" + cat + "/" + country;
    }

    public string encode(string str)
    {
        str.Trim();
        str = str.ToLower();
        str = str.Replace(" ", "_");
        str = str.Replace(".", "");
        str = str.Replace("&", "and");
        return str;
    }

    public bool findReg(string s) {
        Regex r = new Regex("^[a-zA-Z0-9]*$");
        return r.IsMatch(s);
    }

    public string GetMD5HashData(string data)
    {
        MD5 m = MD5.Create();
        byte[] hashData = m.ComputeHash(Encoding.Default.GetBytes(data));
        StringBuilder returnValue = new StringBuilder();
        for (int i = 0; i < hashData.Length; i++)
        {
            returnValue.Append(hashData[i].ToString());
        }

        // return hexadecimal string
        return returnValue.ToString();
    }

    public bool ValidateMD5HashData(string inputData, string storedHashData)
    {
        //hash input text and save it string variable
        string getHashInputData = GetMD5HashData(inputData);

        if (string.Compare(getHashInputData, storedHashData) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string generateDetailsURL(object id, object name)
    {
        string n = name.ToString();
        n.Trim();
        n = n.ToLower();
        n = n.Replace(" ", "_");
        n = n.Replace(".", "");
        n = n.Replace("&", "and");
        return "~/details/" + id.ToString() + "/" + n;

    }
}
﻿
using System;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace ConectionMySQL
{
  public class DBConnection
  {
    private DBConnection()
    {
      
    }
    private string databaseName= String.Empty;

    public string DatabaseName
    {
      get { return databaseName; }
      set { databaseName = value; }
    }
    private string Password { get; set; }
    private MySqlConnection connection = null;

    public MySqlConnection Connection
    {
      get
      {
        return connection;
      }
    }

    private static DBConnection _instance = null;

    public static DBConnection Instance()
    {
      if ( _instance==null)
        _instance=new DBConnection();
      return _instance;
    }

    public bool IsConnect()
    {
      if (connection == null)
      {
        if (String.IsNullOrEmpty(databaseName))
          return false;
        string connstring = String.Format("Server=localhost;database={0};UID=root; password=root",databaseName);
        connection= new MySqlConnection(connstring);
        connection.Open();
      }

      return true;
    }

    public void Close()
    {
      connection.Close();
    }
  }
  }

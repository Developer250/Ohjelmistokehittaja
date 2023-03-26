﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Hotellivarausjarjestelma
{
    internal class CLIENT
    {
        CONNECT conn = new CONNECT();

        public bool insertClient(String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES(@fnm, @lnm, @phn, @cnt)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();
            //`first_name`, `lasdt_name`, `phone`, `country`
           command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
           command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
           command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = phone;
           command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = country;

            conn.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        public bool editClient(int id, String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `clients` SET `first_name` =@fnm, `last_name` =@lnm, `phone` =@phn, `country` =@cnt WHERE `id` =@cid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            //@cid, @fnm,@lnm, @phn, @cnt
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@tp", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = country;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELCET *  FROM `clients`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `clients` WHERE `id`= @cid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            //@number
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = id;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }
}

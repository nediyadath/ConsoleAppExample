
using GenSpark4ConsoleApp.Abstraction;
using GenSpark4ConsoleApp.DAL;
using GenSpark4ConsoleApp.Models;
using GenSpark4ConsoleApp.Mycode;
using GenSpark4ConsoleApp.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace GenSpark4ConsoleApp
{
    class Program
    {
        //Inheritance, Polymorphism, Encapsulation, Abstraction

        static void Main(string[] args)
        {
            CRUD c = new CRUD();
            c.AddPatient("Nirmal", "Fever");
        }
    }


    public enum DOW
    {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat
    }



public class CRUD
{
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString());

        public void AddPatient(string name, string ailment)
    {
        SqlCommand cmd = new SqlCommand("spAddPatient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@ailment", ailment);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

    }

}
public interface IA
{
    void M1();
}

public class Test : IA
{
    public void M1() { }
}
}

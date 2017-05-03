#region Imports

using System;
using System.Runtime.Remoting.Messaging;
using MySql.Data;
using MySql.Data.MySqlClient;
#endregion
namespace SSOPointOfSale
{
    public sealed class Employee
    {
        #region Singleton Class Setup
        // Employee Singleton, used so whole program can reference the single Employee object
        static readonly Employee instance = new Employee();
        static Employee()
        {
        }
        Employee()
        {
        }
        public static Employee Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion
        #region Employee Class member variables
        // Private singleton member variables
        private string employeeId;
        private string employeePassword;
        private string employeeFirstName;
        private string employeeLastName;
        private string employeeName;
        #endregion
        #region Employee verification and Name from Id functions
        /**
         * Check Employee Id and Employee Password against database
         */
        public bool verifyIdandPassword(string empid, string emppass)
        {
            DeeBee connect = new DeeBee();
            int intempid;
            if (int.TryParse(empid, out intempid))
            {
                if (connect.IsConnect())
                {
                    //suppose col0 and col1 are defined as VARCHAR in the DB
                    string query = string.Format("select employeeId, password from employee where employeeId = {0} and password = '{1}'", empid, emppass);
                    var cmd = new MySqlCommand(query, connect.Connection);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string someStringFromColumnZero = reader.GetString(0);
                        string someStringFromColumnOne = reader.GetString(1);
                        if (someStringFromColumnZero != null && someStringFromColumnOne != null) { return true; }
                    }
                }
            }
            return false; // Incorrect employee Id and/or password

            // PSEUDO CODE ISH
            //return ((checkbase to check employee status == ACTIVE) && (checkdeebee if employee Id and Password == CORRECT)) ? true : false;
        }
        /**
         * Return Employee firstName and Employee lastName based on Employee Id
         */
        public string getEmployeeNameFromId(string empid)
        {
            // NOTE: do database check here
            //return (employee id exists in database) ? return empFirstName + empLastName : string.Empty; 


            // NOTE: for now just return Employee Id so the rest of the system works correctly. 
            return empid;
        }
        #endregion
    }
}

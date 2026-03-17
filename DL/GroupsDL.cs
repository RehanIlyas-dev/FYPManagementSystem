using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using FYPManagementSystem.Models;

namespace FYPManagementSystem.DataLayer
{
    public class GroupsDL
    {
        public DataTable GetUnassignedStudents()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"SELECT p.Id, s.RegistrationNo AS 'Reg No', CONCAT(p.FirstName, ' ', p.LastName) AS 'Name' FROM student s JOIN person p ON s.Id = p.Id WHERE s.Id NOT IN (SELECT StudentId FROM groupstudent WHERE Status = 3)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception) { }
            }
            return dt;
        }

        public bool CreateGroup(GroupModel group)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                using (MySqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string groupQuery = "INSERT INTO `group` (Created_On) VALUES (@date); SELECT LAST_INSERT_ID();";
                        MySqlCommand cmdGroup = new MySqlCommand(groupQuery, con, transaction);
                        cmdGroup.Parameters.AddWithValue("@date", group.CreatedOn);
                        
                        int newGroupId = Convert.ToInt32(cmdGroup.ExecuteScalar());

                        foreach (int studentId in group.StudentIds)
                        {
                            string linkQuery = "INSERT INTO groupstudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@gId, @sId, 3, @date)";
                            MySqlCommand cmdLink = new MySqlCommand(linkQuery, con, transaction);
                            cmdLink.Parameters.AddWithValue("@gId", newGroupId);
                            cmdLink.Parameters.AddWithValue("@sId", studentId);
                            cmdLink.Parameters.AddWithValue("@date", group.CreatedOn);
                            
                            cmdLink.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable GetGroups()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"SELECT 
                                        g.Id AS 'Group Id', 
                                        g.Created_On AS 'Created On',
                                        GROUP_CONCAT(s.RegistrationNo SEPARATOR ', ') AS 'Students'
                                     FROM `group` g
                                     JOIN groupstudent gs ON g.Id = gs.GroupId
                                     JOIN student s ON gs.StudentId = s.Id
                                     WHERE gs.Status = 3
                                     GROUP BY g.Id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception) { }
            }
            return dt;
        }

        public bool DeleteGroup(int groupId)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                using (MySqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string deleteLinks = "DELETE FROM groupstudent WHERE GroupId=@gId";
                        MySqlCommand cmdLinks = new MySqlCommand(deleteLinks, con, transaction);
                        cmdLinks.Parameters.AddWithValue("@gId", groupId);
                        cmdLinks.ExecuteNonQuery();

                        string deleteGroup = "DELETE FROM `group` WHERE Id=@gId";
                        MySqlCommand cmdGroup = new MySqlCommand(deleteGroup, con, transaction);
                        cmdGroup.Parameters.AddWithValue("@gId", groupId);
                        cmdGroup.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable GetGroupStudents(int groupId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"SELECT StudentId FROM groupstudent WHERE GroupId=@gId AND Status=3";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@gId", groupId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception) { }
            }
            return dt;
        }

        public bool UpdateGroupMembers(GroupModel group)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                using (MySqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        string deleteOld = "DELETE FROM groupstudent WHERE GroupId=@gId";
                        MySqlCommand cmdDel = new MySqlCommand(deleteOld, con, transaction);
                        cmdDel.Parameters.AddWithValue("@gId", group.Id);
                        cmdDel.ExecuteNonQuery();

                        foreach (int studentId in group.StudentIds)
                        {
                            string insert = "INSERT INTO groupstudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@gId, @sId, 3, @date)";
                            MySqlCommand cmdIns = new MySqlCommand(insert, con, transaction);
                            cmdIns.Parameters.AddWithValue("@gId", group.Id);
                            cmdIns.Parameters.AddWithValue("@sId", studentId);
                            cmdIns.Parameters.AddWithValue("@date", DateTime.Now);
                            cmdIns.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable GetAllStudentsForUpdate(int currentGroupId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"SELECT p.Id, s.RegistrationNo AS 'Reg No', CONCAT(p.FirstName, ' ', p.LastName) AS 'Name' 
                                     FROM student s 
                                     JOIN person p ON s.Id = p.Id 
                                     WHERE s.Id NOT IN (SELECT StudentId FROM groupstudent WHERE Status = 3)
                                     OR s.Id IN (SELECT StudentId FROM groupstudent WHERE GroupId = @gId AND Status = 3)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@gId", currentGroupId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception) { }
            }
            return dt;
        }
    }
}
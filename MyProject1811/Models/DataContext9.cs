using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace _5AdoDotNet.Models
{
public class DataContext
{
string conSr = "Server=.; Database=EmpDeptDB; User id=sa; password=Reset1234";
string commandText;
public List<Dept> GetDepts()
{
List<Dept> listDept = new List<Dept>();
commandText = "select * from Dept";
SqlDataAdapter da = new SqlDataAdapter(commandText, conSr);
DataTable dt = new DataTable();
da.Fill(dt);
foreach (DataRow dr in dt.Rows)
    {
Dept obj = new Dept();
obj.DeptNo = (int)dr["DeptNo"];
obj.DName = (string)dr["DName"];
obj.Location = (string)dr["Location"];
listDept.Add(obj);
}
return listDept;
}
public Dept GetDept(int n)
{
Dept obj = new Dept();
commandText = "select * from Dept where DeptNo=" + n;
SqlConnection con = new SqlConnection(conSr);
SqlCommand cmd = new SqlCommand(commandText, con);
con.Open();
    SqlDataReader dr = cmd.ExecuteReader();
if (dr.HasRows == true)
{
dr.Read();
obj.DeptNo = (int)dr["DeptNo"];
obj.DName = (string)dr["DName"];
obj.Location = (string)dr["Location"];
}
dr.Close();
con.Close();
return obj;
}
    public void AddDept(Dept obj)
{
commandText = string.Format("Insert INTO Dept Values({0},'{1}','{2}')",
obj.DeptNo, obj.DName, obj.Location);
SqlConnection cn = new SqlConnection(conSr);
SqlCommand cmd = new SqlCommand(commandText, cn);
cn.Open();
cmd.ExecuteNonQuery();
cn.Close();
}
public void EditDept(Dept Obj)
{
commandText = string.Format("Update dept set DName='{0}',Location='{1}'where DeptNo={2}", Obj.DName, Obj.Location, Obj.DeptNo);
SqlConnection cn = new SqlConnection(conSr);
SqlCommand cmd = new SqlCommand(commandText, cn);
cn.Open();
cmd.ExecuteNonQuery();
cn.Close();
}
    public void DeleteDept(int n)
{
commandText = string.Format("delete from dept where DeptNo={0}", n);
SqlConnection cn = new SqlConnection(conSr);
SqlCommand cmd = new SqlCommand(commandText, cn);
cn.Open();
cmd.ExecuteNonQuery();
cn.Close();
}
}
}
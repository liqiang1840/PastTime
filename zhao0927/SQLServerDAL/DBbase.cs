using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

/// <summary>
/// DBbase 的摘要说明
/// </summary>
public class DBbase
{
    public DBbase()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
        //该源码下载自www.51aspx.com(５1ａｓｐｘ．ｃｏｍ)

    }
    #region 定义连接字符串strCon
    /// <summary>
    /// 定义连接字符串strCon
    /// </summary>
    public static string strCon = ConfigurationSettings.AppSettings["constr"];
    //public static string strCon = System.Configuration.ConfigurationSettings.AppSettings["conStr"].ToString();
    #endregion

    #region 实例化连接对象con
    /// <summary>
    /// 实例化连接对象con
    /// </summary>
    SqlConnection con = new SqlConnection(strCon);
    #endregion

    #region 检测连接是否打开
    /// <summary>
    /// 检测连接的方法CheckConnection(),若连接是关闭的则打开SqlConnection连接
    /// </summary>
    public void CheckConnection()
    {
        if (this.con.State == ConnectionState.Closed)
        {
            this.con.Open();
        }
    }
    #endregion

    #region 执行语句返回DataSet数据集
    /// <summary>
    /// 执行语句返回DataSet数据集
    /// </summary>
    /// <param name="strSQL">要执行的SQL语句</param>
    /// <returns>DataSet集合</returns>
    public DataSet ReturnDataSet(string strSQL)
    {
        CheckConnection();
        try
        {
            SqlDataAdapter sda = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
    #endregion

    #region 执行语句返回DataRow
    /// <summary>
    ///  执行语句返回DataRow
    /// </summary>
    /// <param name="strSQL"> 要执行的SQL语句</param>
    /// <returns>返回DataRow对象</returns>
    public DataRow GetDataRow(string strSQL)
    {
        CheckConnection();
        try
        {
            SqlDataAdapter sda = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0].Rows[0];
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
    #endregion

    #region 执行SQL语句或存储过程的方法ExecuteNonQuery()
    /// <summary>
    /// 执行存储过程或SQL语句的方法ExecuteNonQuery(),执行成功返回true,否则返回false
    /// </summary>
    /// <param name="IsPro">为true是执行存储过程,false执行SQL语句</param>
    /// <param name="strSQL">要执行的SQL语句</param>
    /// <returns>执行成功返回true,否则返回false</returns>
    public bool ExecuteNonQuery(bool IsPro, string strSQL)
    {
        CheckConnection();
        try
        {
            SqlCommand com = new SqlCommand(strSQL, con);
            if (IsPro)
            {
                com.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                com.CommandType = CommandType.Text;
            }
            com.CommandText = strSQL;
            com.ExecuteNonQuery();
            con.Close();
            return true;
        }
        catch
        {
            return false;
        }
    }
    #endregion

    #region 执行SQL语句的方法ExecuteNonQuery()
    /// <summary>
    /// 执行SQL语句的方法ExecuteNonQuery()
    /// </summary>
    /// <param name="strSQL">要执行的SQL语句</param>
    public void ExecuteNonQuery(string strSQL)
    {
        CheckConnection();
        try
        {
            SqlCommand com = new SqlCommand(strSQL, con);
            com.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
    #endregion

    #region 执行语句返回DataTable的方法
    /// <summary>
    /// 执行语句返回DataTable的方法
    /// </summary>
    /// <param name="strSQL">要执行的SQL语句</param>
    /// <returns>返回DataTable对象</returns>
    public DataTable ReturnTable(string strSQL)
    {
        CheckConnection();
        try
        {
            SqlDataAdapter sda = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }
    #endregion

    #region 执行语句返回SqlDataReader对象
    /// <summary>
    /// 执行语句返回SqlDataReader对象
    /// </summary>
    /// <param name="strSQL">待执行的语句</param>
    /// <returns>SqlDataReader对象</returns>
    public SqlDataReader ReturnDataReader(string strSQL)
    {
        CheckConnection();
        try
        {
            SqlCommand com = new SqlCommand(strSQL, con);
            SqlDataReader myReader = com.ExecuteReader();
            return myReader;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
        }
    }
    #endregion

    #region 执行语句,返回该语句查询出的数据行的总数
    /// <summary>
    /// 执行语句,返回该语句查询出的数据行的总数
    /// </summary>
    /// <param name="strSQL">要执行的SQL语句</param>
    /// <returns>整型值－－数据总行数</returns>
    public int ReturnRowCount(string strSQL)
    {
        CheckConnection();
        try
        {
            SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0].Rows.Count;
        }
        catch
        {
            return 0;
        }
    }

    public int ReturnUserCount(string username, string password)
    {
        CheckConnection();
        try
        {
            SqlCommand cmd = new SqlCommand("ReturnUserCount ", con);
            SqlParameter[] paras = { new SqlParameter("@username ", username), new SqlParameter("@password", password) };
            cmd.Parameters.AddRange(paras);
            cmd.CommandType = CommandType.StoredProcedure;
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch
        {
            return 0;
        }
    }
    #endregion
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(
        ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString
    );

    void Display()
    {
        SqlDataAdapter da = new SqlDataAdapter(
            "SELECT * FROM Department", con
        );

        DataTable dt = new DataTable();
        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Display();
        }
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand(
            "INSERT INTO Department VALUES (@id, @name)", con
        );

        cmd.Parameters.AddWithValue("@id", txtID.Text);
        cmd.Parameters.AddWithValue("@name", txtName.Text);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Display();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand(
            "UPDATE Department SET DeptName=@name WHERE DeptID=@id", con
        );

        cmd.Parameters.AddWithValue("@id", txtID.Text);
        cmd.Parameters.AddWithValue("@name", txtName.Text);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Display();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand(
            "DELETE FROM Department WHERE DeptID=@id", con
        );

        cmd.Parameters.AddWithValue("@id", txtID.Text);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Display();
    }
}

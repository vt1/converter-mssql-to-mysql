using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace ConverterProgram
{
    class Converter : Form
    {
        SqlServer sqlServer;
        List<string> tables;
        List<News> newsArray;            

        public Converter()
        {
            sqlServer = new SqlServer();            
            //tables = GetTables();
            newsArray = new List<News>();
            getData();            
        }


        public void getData()
        {
            string query = @"Select ID, NewsID, CategoryID, LangID, Title, PubDate, ShortText,
                            FullText, SourceUrl, IsActive, Tags FROM News";
            SqlCommand cmd = new SqlCommand(query, sqlServer.getSqlConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = Int32.Parse(reader["ID"].ToString());
                int newsId = Int32.Parse(reader["NewsID"].ToString());
                int categoryID = Int32.Parse(reader["CategoryID"].ToString());
                int langID = Int32.Parse(reader["LangID"].ToString());
                string title = reader["Title"].ToString();
                string stringPubDate = reader["PubDate"].ToString();
                DateTime pubDate = Convert.ToDateTime(stringPubDate);
                string shortText = reader["ShortText"].ToString();
                string fullText = reader["FullText"].ToString();
                string sourceUrl = reader["SourceUrl"].ToString();
                bool booleanIsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                int isActive = Convert.ToInt32(booleanIsActive);
                string tags = reader["Tags"].ToString();

                News news = new News(id,newsId,categoryID,langID,title,pubDate,shortText,fullText,sourceUrl,isActive,tags);                
                newsArray.Add(news);
            }                             
        }

        //public List<string> GetTables()
        //{
        //    DataTable schema = sqlServer.getSqlConnection().GetSchema("Tables");
        //    List<string> TableNames = new List<string>();
        //    foreach (DataRow row in schema.Rows)
        //    {
        //        TableNames.Add(row[2].ToString());

        //    }
        //    return TableNames;
        //}



        private void InitializeComponent()
        {            
            this.SuspendLayout();
            // 
            // Converter
            // 
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Name = "Converter";
            this.Load += new System.EventHandler(this.Converter_Load);
            this.ResumeLayout(false);

        }

        private void Converter_Load(object sender, EventArgs e)
        {
            int a = 1;
        }      
    }
}
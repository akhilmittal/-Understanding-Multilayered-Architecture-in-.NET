using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class StudentDAL
    {
        public DataSet FetchSelectedStudents()
        {
            string sqlCommand = "select * from Student where Studentid<5";
            DataSet dataSet = SqlHelper.ExecuteDataset(SqlHelper.CONN_STRING, CommandType.Text, sqlCommand);
            return dataSet;
        }

    }
}

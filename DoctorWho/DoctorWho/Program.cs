using DoctorWho.Db;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace DoctorWho
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new DoctorWhoCoreDbContext())
            {
                var viewResult = context.ViewEpisodes.ToList();

                var sqlCommander = new SqlCommander();

                #region Exec procedure

                var storedProcedureResult = sqlCommander.ExecuteSqlCommand("EXECUTE spSummariseEpisodes");

                var firstTable = storedProcedureResult.Tables[0].ToList<Table1>();
                var secondTable = storedProcedureResult.Tables[1].ToList<Table2>();

                #endregion

                #region Func exec

                var scalarFunctionResult = sqlCommander.ExecuteSqlCommand("SELECT dbo.fnEnemies(1) as result");

                var funcResult = scalarFunctionResult.Tables[0].ToList<FuncResult>();

                #endregion
            }
        }
    }

    internal class FuncResult
    {
        public string result { get; set; }
    }

    internal class Table1
    {
        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public int CompanionAppearing { get; set; }
    }

    internal class Table2
    {
        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public int EnemyAppearing { get; set; }
    }

    public static class DataTableExtensions
    {
        public static List<T> ToList<T>(this DataTable dt)
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            var columnNames = dt.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName)
                .ToList();
            var objectProperties = typeof(T).GetProperties(flags);
            var targetList = dt.AsEnumerable().Select(dataRow =>
            {
                var instanceOfT = Activator.CreateInstance<T>();

                foreach (var properties in objectProperties.Where(properties => columnNames.Contains(properties.Name) && dataRow[properties.Name] != DBNull.Value))
                {
                    properties.SetValue(instanceOfT, dataRow[properties.Name], null);
                }
                return instanceOfT;
            }).ToList();

            return targetList;
        }
    }
}

using DM.GraphQlDemo.Entities;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace DM.GraphQlDemo.Data
{
    public class ReportsRepository
    {
        private static readonly Lazy<Report[]> _reports = new Lazy<Report[]>(() =>
        {
            using var s = Assembly.GetExecutingAssembly().GetManifestResourceStream("DM.GraphQlDemo.Data.reports.json");
            var sr = new StreamReader(s);

            string jr = sr.ReadToEnd();

            var jo = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            Report[] result = JsonSerializer.Deserialize<Report[]>(jr, jo);

            return result;
        });

        private Report[] Reports => _reports.Value;

        public Report[] GetAllReports() => Reports;

        public Report GetReportById(int oid) => Reports.FirstOrDefault(x => x.Oid == oid);

        public Column[] GetColumns() => Reports
            .SelectMany(x => x.Columns)
            .ToArray();

        public Column GetColumn(int oid) => GetColumns()
            .FirstOrDefault(x => x.Oid == oid);

        public Column[] GetColumnsByReport(int reportOid) => GetReportById(reportOid)?.Columns;
    }
}

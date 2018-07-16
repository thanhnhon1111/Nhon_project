#region Assembly Excel.dll, v2.0.50727
// C:\Users\STV02\Desktop\Readxls\Readxls\bin\Debug\Excel.dll
#endregion

using System;
using System.Data;
using System.IO;

namespace Excel1
{
        public interface IExcelDataReader : IDataReader, IDisposable, IDataRecord
        {
            string ExceptionMessage { get; }
            bool IsFirstRowAsColumnNames { get; set; }
            bool IsValid { get; }
            string Name { get; }
            int ResultsCount { get; }

            DataSet AsDataSet();
            DataSet AsDataSet(bool convertOADateTime);
            void Initialize(Stream fileStream);
        }

}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GeoBaha.My;

namespace GeoBaha.GeoBahaDataSetTableAdapters
{
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class Factors40401TableAdapter : Component
	{
		private SqlConnection _connection;

		private SqlTransaction _transaction;

		private SqlCommand[] _commandCollection;

		private bool _clearBeforeFill;

		[field: AccessedThroughProperty("_adapter")]
        public virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected internal SqlDataAdapter Adapter
		{
			get
			{
				if (_adapter == null)
				{
					InitAdapter();
				}
				return _adapter;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlConnection Connection
		{
			get
			{
				if (_connection == null)
				{
					InitConnection();
				}
				return _connection;
			}
			set
			{
				_connection = value;
				if (Adapter.InsertCommand != null)
				{
					Adapter.InsertCommand.Connection = value;
				}
				if (Adapter.DeleteCommand != null)
				{
					Adapter.DeleteCommand.Connection = value;
				}
				if (Adapter.UpdateCommand != null)
				{
					Adapter.UpdateCommand.Connection = value;
				}
				for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
				{
					if (CommandCollection[i] != null)
					{
						CommandCollection[i].Connection = value;
					}
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlTransaction Transaction
		{
			get
			{
				return _transaction;
			}
			set
			{
				_transaction = value;
				for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
				{
					CommandCollection[i].Transaction = _transaction;
				}
				if (Adapter != null && Adapter.DeleteCommand != null)
				{
					Adapter.DeleteCommand.Transaction = _transaction;
				}
				if (Adapter != null && Adapter.InsertCommand != null)
				{
					Adapter.InsertCommand.Transaction = _transaction;
				}
				if (Adapter != null && Adapter.UpdateCommand != null)
				{
					Adapter.UpdateCommand.Transaction = _transaction;
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected SqlCommand[] CommandCollection
		{
			get
			{
				if (_commandCollection == null)
				{
					InitCommandCollection();
				}
				return _commandCollection;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool ClearBeforeFill
		{
			get
			{
				return _clearBeforeFill;
			}
			set
			{
				_clearBeforeFill = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Factors40401TableAdapter()
		{
			ClearBeforeFill = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			_adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "Factors40401";
			dataTableMapping.ColumnMappings.Add("Id", "Id");
			dataTableMapping.ColumnMappings.Add("SanadNo", "SanadNo");
			dataTableMapping.ColumnMappings.Add("a1", "a1");
			dataTableMapping.ColumnMappings.Add("a2", "a2");
			dataTableMapping.ColumnMappings.Add("a3", "a3");
			dataTableMapping.ColumnMappings.Add("a4", "a4");
			dataTableMapping.ColumnMappings.Add("a5", "a5");
			dataTableMapping.ColumnMappings.Add("a6", "a6");
			dataTableMapping.ColumnMappings.Add("a7", "a7");
			dataTableMapping.ColumnMappings.Add("a8", "a8");
			dataTableMapping.ColumnMappings.Add("b", "b");
			dataTableMapping.ColumnMappings.Add("fopf", "fopf");
			dataTableMapping.ColumnMappings.Add("SalMali", "SalMali");
			dataTableMapping.ColumnMappings.Add("Soori", "Soori");
			dataTableMapping.ColumnMappings.Add("Ghaleb", "Ghaleb");
			dataTableMapping.ColumnMappings.Add("Eslah", "Eslah");
			dataTableMapping.ColumnMappings.Add("EslahTime", "EslahTime");
			_adapter.TableMappings.Add(dataTableMapping);
			_adapter.InsertCommand = new SqlCommand();
			_adapter.InsertCommand.Connection = Connection;
			_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Factors40401] ([SanadNo], [a1], [a2], [a3], [a4], [a5], [a6], [a7], [a8], [b], [fopf], [SalMali], [Soori], [Ghaleb], [Eslah], [EslahTime]) VALUES (@SanadNo, @a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @b, @fopf, @SalMali, @Soori, @Ghaleb, @Eslah, @EslahTime)";
			_adapter.InsertCommand.CommandType = CommandType.Text;
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SanadNo", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SanadNo", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@a1", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "a1", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@a2", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "a2", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@a3", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "a3", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@a4", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "a4", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@a5", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "a5", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@a6", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "a6", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@a7", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "a7", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@a8", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "a8", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@b", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "b", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "fopf", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SalMali", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SalMali", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Soori", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Soori", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Ghaleb", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Ghaleb", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Eslah", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Eslah", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@EslahTime", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "EslahTime", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			_connection = new SqlConnection();
			_connection.ConnectionString = MySettings.Default.GeoBahaConnectionString;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			_commandCollection = new SqlCommand[1];
			_commandCollection[0] = new SqlCommand();
			_commandCollection[0].Connection = Connection;
			_commandCollection[0].CommandText = "SELECT Id, SanadNo, a1, a2, a3, a4, a5, a6, a7, a8, b, fopf, SalMali, Soori, Ghaleb, Eslah, EslahTime FROM dbo.Factors40401";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.Factors40401DataTable dataTable)
		{
			Adapter.SelectCommand = CommandCollection[0];
			if (ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return Adapter.Fill(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual GeoBahaDataSet.Factors40401DataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.Factors40401DataTable factors40401DataTable = new GeoBahaDataSet.Factors40401DataTable();
			Adapter.Fill(factors40401DataTable);
			return factors40401DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet.Factors40401DataTable dataTable)
		{
			return Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet dataSet)
		{
			return Adapter.Update(dataSet, "Factors40401");
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow dataRow)
		{
			return Adapter.Update(new DataRow[1] { dataRow });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow[] dataRows)
		{
			return Adapter.Update(dataRows);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Insert, true)]
		public virtual int Insert(string SanadNo, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string b, bool? fopf, string SalMali, bool? Soori, bool? Ghaleb, string Eslah, DateTime? EslahTime)
		{
			if (SanadNo == null)
			{
				throw new ArgumentNullException("SanadNo");
			}
			Adapter.InsertCommand.Parameters[0].Value = SanadNo;
			if (a1 == null)
			{
				throw new ArgumentNullException("a1");
			}
			Adapter.InsertCommand.Parameters[1].Value = a1;
			if (a2 == null)
			{
				throw new ArgumentNullException("a2");
			}
			Adapter.InsertCommand.Parameters[2].Value = a2;
			if (a3 == null)
			{
				throw new ArgumentNullException("a3");
			}
			Adapter.InsertCommand.Parameters[3].Value = a3;
			if (a4 == null)
			{
				throw new ArgumentNullException("a4");
			}
			Adapter.InsertCommand.Parameters[4].Value = a4;
			if (a5 == null)
			{
				throw new ArgumentNullException("a5");
			}
			Adapter.InsertCommand.Parameters[5].Value = a5;
			if (a6 == null)
			{
				throw new ArgumentNullException("a6");
			}
			Adapter.InsertCommand.Parameters[6].Value = a6;
			if (a7 == null)
			{
				throw new ArgumentNullException("a7");
			}
			Adapter.InsertCommand.Parameters[7].Value = a7;
			if (a8 == null)
			{
				throw new ArgumentNullException("a8");
			}
			Adapter.InsertCommand.Parameters[8].Value = a8;
			if (b == null)
			{
				throw new ArgumentNullException("b");
			}
			Adapter.InsertCommand.Parameters[9].Value = b;
			if (fopf.HasValue)
			{
				Adapter.InsertCommand.Parameters[10].Value = fopf.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			if (SalMali == null)
			{
				Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[11].Value = SalMali;
			}
			if (Soori.HasValue)
			{
				Adapter.InsertCommand.Parameters[12].Value = Soori.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
			}
			if (Ghaleb.HasValue)
			{
				Adapter.InsertCommand.Parameters[13].Value = Ghaleb.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
			}
			if (Eslah == null)
			{
				Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[14].Value = Eslah;
			}
			if (EslahTime.HasValue)
			{
				Adapter.InsertCommand.Parameters[15].Value = EslahTime.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
			}
			ConnectionState state = Adapter.InsertCommand.Connection.State;
			if ((Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				Adapter.InsertCommand.Connection.Open();
			}
			try
			{
				return Adapter.InsertCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					Adapter.InsertCommand.Connection.Close();
				}
			}
		}
	}
}

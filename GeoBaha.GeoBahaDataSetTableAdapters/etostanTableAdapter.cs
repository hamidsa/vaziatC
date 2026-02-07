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
	public class etostanTableAdapter : Component
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
		public etostanTableAdapter()
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
			dataTableMapping.DataSetTable = "etostan";
			dataTableMapping.ColumnMappings.Add("identradif", "identradif");
			dataTableMapping.ColumnMappings.Add("okod", "okod");
			dataTableMapping.ColumnMappings.Add("oname", "oname");
			dataTableMapping.ColumnMappings.Add("fehrest", "fehrest");
			dataTableMapping.ColumnMappings.Add("okod_old", "okod_old");
			_adapter.TableMappings.Add(dataTableMapping);
			_adapter.InsertCommand = new SqlCommand();
			_adapter.InsertCommand.Connection = Connection;
			_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[etostan] ([okod], [oname], [fehrest], [okod_old]) VALUES (@okod, @oname, @fehrest, @okod_old)";
			_adapter.InsertCommand.CommandType = CommandType.Text;
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@okod", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "okod", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@oname", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "oname", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@fehrest", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "fehrest", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@okod_old", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "okod_old", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
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
			_commandCollection[0].CommandText = "SELECT identradif, okod, oname, fehrest, okod_old FROM dbo.etostan";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.etostanDataTable dataTable)
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
		public virtual GeoBahaDataSet.etostanDataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.etostanDataTable etostanDataTable = new GeoBahaDataSet.etostanDataTable();
			Adapter.Fill(etostanDataTable);
			return etostanDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet.etostanDataTable dataTable)
		{
			return Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet dataSet)
		{
			return Adapter.Update(dataSet, "etostan");
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
		public virtual int Insert(decimal okod, string oname, string fehrest, decimal? okod_old)
		{
			Adapter.InsertCommand.Parameters[0].Value = okod;
			if (oname == null)
			{
				throw new ArgumentNullException("oname");
			}
			Adapter.InsertCommand.Parameters[1].Value = oname;
			if (fehrest == null)
			{
				throw new ArgumentNullException("fehrest");
			}
			Adapter.InsertCommand.Parameters[2].Value = fehrest;
			if (okod_old.HasValue)
			{
				Adapter.InsertCommand.Parameters[3].Value = okod_old.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
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

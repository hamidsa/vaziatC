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
	public class etbakhshTableAdapter : Component
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
		public etbakhshTableAdapter()
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
			dataTableMapping.DataSetTable = "etbakhsh";
			dataTableMapping.ColumnMappings.Add("identradif", "identradif");
			dataTableMapping.ColumnMappings.Add("okod", "okod");
			dataTableMapping.ColumnMappings.Add("shkod", "shkod");
			dataTableMapping.ColumnMappings.Add("bkod", "bkod");
			dataTableMapping.ColumnMappings.Add("bname", "bname");
			dataTableMapping.ColumnMappings.Add("zarib", "zarib");
			dataTableMapping.ColumnMappings.Add("fehrest", "fehrest");
			dataTableMapping.ColumnMappings.Add("oname", "oname");
			dataTableMapping.ColumnMappings.Add("shname", "shname");
			dataTableMapping.ColumnMappings.Add("okod_old", "okod_old");
			dataTableMapping.ColumnMappings.Add("shkod_old", "shkod_old");
			dataTableMapping.ColumnMappings.Add("bkod_old", "bkod_old");
			dataTableMapping.ColumnMappings.Add("zarib_Old", "zarib_Old");
			_adapter.TableMappings.Add(dataTableMapping);
			_adapter.InsertCommand = new SqlCommand();
			_adapter.InsertCommand.Connection = Connection;
			_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[etbakhsh] ([identradif], [okod], [shkod], [bkod], [bname], [zarib], [fehrest], [oname], [shname], [okod_old], [shkod_old], [bkod_old], [zarib_Old]) VALUES (@identradif, @okod, @shkod, @bkod, @bname, @zarib, @fehrest, @oname, @shname, @okod_old, @shkod_old, @bkod_old, @zarib_Old)";
			_adapter.InsertCommand.CommandType = CommandType.Text;
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@identradif", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "identradif", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@okod", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "okod", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@shkod", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "shkod", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@bkod", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "bkod", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@bname", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "bname", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@zarib", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "zarib", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@fehrest", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "fehrest", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@oname", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "oname", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@shname", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "shname", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@okod_old", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "okod_old", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@shkod_old", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "shkod_old", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@bkod_old", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "bkod_old", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@zarib_Old", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "zarib_Old", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
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
			_commandCollection[0].CommandText = "SELECT identradif, okod, shkod, bkod, bname, zarib, fehrest, oname, shname, okod_old, shkod_old, bkod_old, zarib_Old FROM dbo.etbakhsh";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.etbakhshDataTable dataTable)
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
		public virtual GeoBahaDataSet.etbakhshDataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.etbakhshDataTable etbakhshDataTable = new GeoBahaDataSet.etbakhshDataTable();
			Adapter.Fill(etbakhshDataTable);
			return etbakhshDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet.etbakhshDataTable dataTable)
		{
			return Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet dataSet)
		{
			return Adapter.Update(dataSet, "etbakhsh");
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
		public virtual int Insert(decimal? identradif, decimal? okod, decimal? shkod, decimal? bkod, string bname, string zarib, string fehrest, string oname, string shname, decimal? okod_old, decimal? shkod_old, decimal? bkod_old, string zarib_Old)
		{
			if (identradif.HasValue)
			{
				Adapter.InsertCommand.Parameters[0].Value = identradif.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (okod.HasValue)
			{
				Adapter.InsertCommand.Parameters[1].Value = okod.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			if (shkod.HasValue)
			{
				Adapter.InsertCommand.Parameters[2].Value = shkod.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			if (bkod.HasValue)
			{
				Adapter.InsertCommand.Parameters[3].Value = bkod.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			if (bname == null)
			{
				Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[4].Value = bname;
			}
			if (zarib == null)
			{
				Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[5].Value = zarib;
			}
			if (fehrest == null)
			{
				Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[6].Value = fehrest;
			}
			if (oname == null)
			{
				Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[7].Value = oname;
			}
			if (shname == null)
			{
				Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[8].Value = shname;
			}
			if (okod_old.HasValue)
			{
				Adapter.InsertCommand.Parameters[9].Value = okod_old.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			if (shkod_old.HasValue)
			{
				Adapter.InsertCommand.Parameters[10].Value = shkod_old.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			if (bkod_old.HasValue)
			{
				Adapter.InsertCommand.Parameters[11].Value = bkod_old.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
			}
			if (zarib_Old == null)
			{
				Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[12].Value = zarib_Old;
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

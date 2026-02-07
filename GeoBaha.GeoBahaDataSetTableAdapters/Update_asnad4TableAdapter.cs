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
	public class Update_asnad4TableAdapter : Component
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
		public Update_asnad4TableAdapter()
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
			dataTableMapping.DataSetTable = "Update_asnad4";
			dataTableMapping.ColumnMappings.Add("recnum", "recnum");
			dataTableMapping.ColumnMappings.Add("sanadnum", "sanadnum");
			dataTableMapping.ColumnMappings.Add("fopf", "fopf");
			dataTableMapping.ColumnMappings.Add("Sharh", "Sharh");
			dataTableMapping.ColumnMappings.Add("darsad", "darsad");
			dataTableMapping.ColumnMappings.Add("maghtoo", "maghtoo");
			dataTableMapping.ColumnMappings.Add("mablagh", "mablagh");
			dataTableMapping.ColumnMappings.Add("mablaghk", "mablaghk");
			dataTableMapping.ColumnMappings.Add("Salmali", "Salmali");
			dataTableMapping.ColumnMappings.Add("IjadSystem", "IjadSystem");
			dataTableMapping.ColumnMappings.Add("EslahSystem", "EslahSystem");
			dataTableMapping.ColumnMappings.Add("TimeIjad", "TimeIjad");
			dataTableMapping.ColumnMappings.Add("TimeEslah", "TimeEslah");
			_adapter.TableMappings.Add(dataTableMapping);
			_adapter.InsertCommand = new SqlCommand();
			_adapter.InsertCommand.Connection = Connection;
			_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Update_asnad4] ([recnum], [sanadnum], [fopf], [Sharh], [darsad], [maghtoo], [mablagh], [mablaghk], [Salmali], [IjadSystem], [EslahSystem], [TimeIjad], [TimeEslah]) VALUES (@recnum, @sanadnum, @fopf, @Sharh, @darsad, @maghtoo, @mablagh, @mablaghk, @Salmali, @IjadSystem, @EslahSystem, @TimeIjad, @TimeEslah)";
			_adapter.InsertCommand.CommandType = CommandType.Text;
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@recnum", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "recnum", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "sanadnum", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "fopf", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Sharh", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Sharh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@darsad", SqlDbType.Float, 0, ParameterDirection.Input, 0, 0, "darsad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@maghtoo", SqlDbType.Float, 0, ParameterDirection.Input, 0, 0, "maghtoo", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mablagh", SqlDbType.Float, 0, ParameterDirection.Input, 0, 0, "mablagh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mablaghk", SqlDbType.Float, 0, ParameterDirection.Input, 0, 0, "mablaghk", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Salmali", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Salmali", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@IjadSystem", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "IjadSystem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@EslahSystem", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "EslahSystem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeIjad", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "TimeIjad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeEslah", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "TimeEslah", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
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
			_commandCollection[0].CommandText = "SELECT recnum, sanadnum, fopf, Sharh, darsad, maghtoo, mablagh, mablaghk, Salmali, IjadSystem, EslahSystem, TimeIjad, TimeEslah FROM dbo.Update_asnad4";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.Update_asnad4DataTable dataTable)
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
		public virtual GeoBahaDataSet.Update_asnad4DataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.Update_asnad4DataTable update_asnad4DataTable = new GeoBahaDataSet.Update_asnad4DataTable();
			Adapter.Fill(update_asnad4DataTable);
			return update_asnad4DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet.Update_asnad4DataTable dataTable)
		{
			return Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet dataSet)
		{
			return Adapter.Update(dataSet, "Update_asnad4");
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
		public virtual int Insert(decimal recnum, decimal sanadnum, bool fopf, string Sharh, double? darsad, double? maghtoo, double? mablagh, double? mablaghk, string Salmali, string IjadSystem, string EslahSystem, DateTime? TimeIjad, DateTime? TimeEslah)
		{
			Adapter.InsertCommand.Parameters[0].Value = recnum;
			Adapter.InsertCommand.Parameters[1].Value = sanadnum;
			Adapter.InsertCommand.Parameters[2].Value = fopf;
			if (Sharh == null)
			{
				Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[3].Value = Sharh;
			}
			if (darsad.HasValue)
			{
				Adapter.InsertCommand.Parameters[4].Value = darsad.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			if (maghtoo.HasValue)
			{
				Adapter.InsertCommand.Parameters[5].Value = maghtoo.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			if (mablagh.HasValue)
			{
				Adapter.InsertCommand.Parameters[6].Value = mablagh.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			if (mablaghk.HasValue)
			{
				Adapter.InsertCommand.Parameters[7].Value = mablaghk.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			if (Salmali == null)
			{
				Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[8].Value = Salmali;
			}
			if (IjadSystem == null)
			{
				Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[9].Value = IjadSystem;
			}
			if (EslahSystem == null)
			{
				Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[10].Value = EslahSystem;
			}
			if (TimeIjad.HasValue)
			{
				Adapter.InsertCommand.Parameters[11].Value = TimeIjad.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
			}
			if (TimeEslah.HasValue)
			{
				Adapter.InsertCommand.Parameters[12].Value = TimeEslah.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
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

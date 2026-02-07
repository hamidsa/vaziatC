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
	public class DELETE_etkarfarTableAdapter : Component
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
		public DELETE_etkarfarTableAdapter()
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
			dataTableMapping.DataSetTable = "DELETE_etkarfar";
			dataTableMapping.ColumnMappings.Add("indentradif", "indentradif");
			dataTableMapping.ColumnMappings.Add("radif", "radif");
			dataTableMapping.ColumnMappings.Add("kknum", "kknum");
			dataTableMapping.ColumnMappings.Add("kname", "kname");
			dataTableMapping.ColumnMappings.Add("adres", "adres");
			dataTableMapping.ColumnMappings.Add("tel", "tel");
			dataTableMapping.ColumnMappings.Add("ShomareEghtesadi", "ShomareEghtesadi");
			dataTableMapping.ColumnMappings.Add("ShomareSabtYaMelli", "ShomareSabtYaMelli");
			dataTableMapping.ColumnMappings.Add("okod", "okod");
			dataTableMapping.ColumnMappings.Add("Oname", "Oname");
			dataTableMapping.ColumnMappings.Add("ShahrKod", "ShahrKod");
			dataTableMapping.ColumnMappings.Add("ShahrName", "ShahrName");
			dataTableMapping.ColumnMappings.Add("KodPosti", "KodPosti");
			dataTableMapping.ColumnMappings.Add("IjadSystem", "IjadSystem");
			dataTableMapping.ColumnMappings.Add("EslahSystem", "EslahSystem");
			dataTableMapping.ColumnMappings.Add("TimeIjad", "TimeIjad");
			dataTableMapping.ColumnMappings.Add("TimeEslah", "TimeEslah");
			dataTableMapping.ColumnMappings.Add("DeleteSystem", "DeleteSystem");
			dataTableMapping.ColumnMappings.Add("TimeDelete", "TimeDelete");
			_adapter.TableMappings.Add(dataTableMapping);
			_adapter.InsertCommand = new SqlCommand();
			_adapter.InsertCommand.Connection = Connection;
			_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[DELETE_etkarfar] ([indentradif], [radif], [kknum], [kname], [adres], [tel], [ShomareEghtesadi], [ShomareSabtYaMelli], [okod], [Oname], [ShahrKod], [ShahrName], [KodPosti], [IjadSystem], [EslahSystem], [TimeIjad], [TimeEslah], [DeleteSystem], [TimeDelete]) VALUES (@indentradif, @radif, @kknum, @kname, @adres, @tel, @ShomareEghtesadi, @ShomareSabtYaMelli, @okod, @Oname, @ShahrKod, @ShahrName, @KodPosti, @IjadSystem, @EslahSystem, @TimeIjad, @TimeEslah, @DeleteSystem, @TimeDelete)";
			_adapter.InsertCommand.CommandType = CommandType.Text;
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@indentradif", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "indentradif", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@radif", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "radif", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@kknum", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "kknum", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@kname", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "kname", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "adres", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "tel", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ShomareEghtesadi", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "ShomareEghtesadi", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ShomareSabtYaMelli", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "ShomareSabtYaMelli", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@okod", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "okod", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Oname", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Oname", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ShahrKod", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "ShahrKod", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ShahrName", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "ShahrName", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@KodPosti", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "KodPosti", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@IjadSystem", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "IjadSystem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@EslahSystem", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "EslahSystem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeIjad", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "TimeIjad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeEslah", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "TimeEslah", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DeleteSystem", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "DeleteSystem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeDelete", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "TimeDelete", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
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
			_commandCollection[0].CommandText = "SELECT indentradif, radif, kknum, kname, adres, tel, ShomareEghtesadi, ShomareSabtYaMelli, okod, Oname, ShahrKod, ShahrName, KodPosti, IjadSystem, EslahSystem, TimeIjad, TimeEslah, DeleteSystem, TimeDelete FROM dbo.DELETE_etkarfar";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.DELETE_etkarfarDataTable dataTable)
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
		public virtual GeoBahaDataSet.DELETE_etkarfarDataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.DELETE_etkarfarDataTable dELETE_etkarfarDataTable = new GeoBahaDataSet.DELETE_etkarfarDataTable();
			Adapter.Fill(dELETE_etkarfarDataTable);
			return dELETE_etkarfarDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet.DELETE_etkarfarDataTable dataTable)
		{
			return Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet dataSet)
		{
			return Adapter.Update(dataSet, "DELETE_etkarfar");
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
		public virtual int Insert(decimal indentradif, string radif, decimal kknum, string kname, string adres, string tel, string ShomareEghtesadi, string ShomareSabtYaMelli, string okod, string Oname, string ShahrKod, string ShahrName, string KodPosti, string IjadSystem, string EslahSystem, DateTime? TimeIjad, DateTime? TimeEslah, string DeleteSystem, DateTime? TimeDelete)
		{
			Adapter.InsertCommand.Parameters[0].Value = indentradif;
			if (radif == null)
			{
				Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[1].Value = radif;
			}
			Adapter.InsertCommand.Parameters[2].Value = kknum;
			if (kname == null)
			{
				throw new ArgumentNullException("kname");
			}
			Adapter.InsertCommand.Parameters[3].Value = kname;
			if (adres == null)
			{
				Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[4].Value = adres;
			}
			if (tel == null)
			{
				Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[5].Value = tel;
			}
			if (ShomareEghtesadi == null)
			{
				Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[6].Value = ShomareEghtesadi;
			}
			if (ShomareSabtYaMelli == null)
			{
				Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[7].Value = ShomareSabtYaMelli;
			}
			if (okod == null)
			{
				Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[8].Value = okod;
			}
			if (Oname == null)
			{
				Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[9].Value = Oname;
			}
			if (ShahrKod == null)
			{
				Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[10].Value = ShahrKod;
			}
			if (ShahrName == null)
			{
				Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[11].Value = ShahrName;
			}
			if (KodPosti == null)
			{
				Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[12].Value = KodPosti;
			}
			if (IjadSystem == null)
			{
				Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[13].Value = IjadSystem;
			}
			if (EslahSystem == null)
			{
				Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[14].Value = EslahSystem;
			}
			if (TimeIjad.HasValue)
			{
				Adapter.InsertCommand.Parameters[15].Value = TimeIjad.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
			}
			if (TimeEslah.HasValue)
			{
				Adapter.InsertCommand.Parameters[16].Value = TimeEslah.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
			}
			if (DeleteSystem == null)
			{
				Adapter.InsertCommand.Parameters[17].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[17].Value = DeleteSystem;
			}
			if (TimeDelete.HasValue)
			{
				Adapter.InsertCommand.Parameters[18].Value = TimeDelete.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[18].Value = DBNull.Value;
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

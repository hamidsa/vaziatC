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
	public class DELETE_asnad2TableAdapter : Component
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
		public DELETE_asnad2TableAdapter()
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
			dataTableMapping.DataSetTable = "DELETE_asnad2";
			dataTableMapping.ColumnMappings.Add("recnum", "recnum");
			dataTableMapping.ColumnMappings.Add("radif", "radif");
			dataTableMapping.ColumnMappings.Add("sanadnum", "sanadnum");
			dataTableMapping.ColumnMappings.Add("itemnum", "itemnum");
			dataTableMapping.ColumnMappings.Add("sharhitem", "sharhitem");
			dataTableMapping.ColumnMappings.Add("mablagh", "mablagh");
			dataTableMapping.ColumnMappings.Add("groupnum", "groupnum");
			dataTableMapping.ColumnMappings.Add("groupname", "groupname");
			dataTableMapping.ColumnMappings.Add("fasl", "fasl");
			dataTableMapping.ColumnMappings.Add("vahed", "vahed");
			dataTableMapping.ColumnMappings.Add("ghvahed", "ghvahed");
			dataTableMapping.ColumnMappings.Add("shvahed", "shvahed");
			dataTableMapping.ColumnMappings.Add("total", "total");
			dataTableMapping.ColumnMappings.Add("darsad", "darsad");
			dataTableMapping.ColumnMappings.Add("setarehdar", "setarehdar");
			dataTableMapping.ColumnMappings.Add("itemdarsad", "itemdarsad");
			dataTableMapping.ColumnMappings.Add("itemname", "itemname");
			dataTableMapping.ColumnMappings.Add("molahezat", "molahezat");
			dataTableMapping.ColumnMappings.Add("fopf", "fopf");
			dataTableMapping.ColumnMappings.Add("SalMali", "SalMali");
			dataTableMapping.ColumnMappings.Add("IjadSystem", "IjadSystem");
			dataTableMapping.ColumnMappings.Add("EslahSystem", "EslahSystem");
			dataTableMapping.ColumnMappings.Add("TimeIjad", "TimeIjad");
			dataTableMapping.ColumnMappings.Add("TimeEslah", "TimeEslah");
			dataTableMapping.ColumnMappings.Add("DeleteSystem", "DeleteSystem");
			dataTableMapping.ColumnMappings.Add("TimeDelete", "TimeDelete");
			_adapter.TableMappings.Add(dataTableMapping);
			_adapter.InsertCommand = new SqlCommand();
			_adapter.InsertCommand.Connection = Connection;
			_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[DELETE_asnad2] ([recnum], [radif], [sanadnum], [itemnum], [sharhitem], [mablagh], [groupnum], [groupname], [fasl], [vahed], [ghvahed], [shvahed], [total], [darsad], [setarehdar], [itemdarsad], [itemname], [molahezat], [fopf], [SalMali], [IjadSystem], [EslahSystem], [TimeIjad], [TimeEslah], [DeleteSystem], [TimeDelete]) VALUES (@recnum, @radif, @sanadnum, @itemnum, @sharhitem, @mablagh, @groupnum, @groupname, @fasl, @vahed, @ghvahed, @shvahed, @total, @darsad, @setarehdar, @itemdarsad, @itemname, @molahezat, @fopf, @SalMali, @IjadSystem, @EslahSystem, @TimeIjad, @TimeEslah, @DeleteSystem, @TimeDelete)";
			_adapter.InsertCommand.CommandType = CommandType.Text;
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@recnum", SqlDbType.Decimal, 0, ParameterDirection.Input, 10, 0, "recnum", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@radif", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "radif", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "sanadnum", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@itemnum", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "itemnum", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sharhitem", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "sharhitem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mablagh", SqlDbType.Float, 0, ParameterDirection.Input, 0, 0, "mablagh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@groupnum", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "groupnum", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@groupname", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "groupname", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@fasl", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "fasl", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@vahed", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "vahed", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ghvahed", SqlDbType.Float, 0, ParameterDirection.Input, 0, 0, "ghvahed", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@shvahed", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "shvahed", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@total", SqlDbType.Float, 0, ParameterDirection.Input, 0, 0, "total", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@darsad", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "darsad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@setarehdar", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "setarehdar", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@itemdarsad", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "itemdarsad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@itemname", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "itemname", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@molahezat", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "molahezat", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "fopf", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SalMali", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SalMali", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
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
			_commandCollection[0].CommandText = "SELECT recnum, radif, sanadnum, itemnum, sharhitem, mablagh, groupnum, groupname, fasl, vahed, ghvahed, shvahed, total, darsad, setarehdar, itemdarsad, itemname, molahezat, fopf, SalMali, IjadSystem, EslahSystem, TimeIjad, TimeEslah, DeleteSystem, TimeDelete FROM dbo.DELETE_asnad2";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.DELETE_asnad2DataTable dataTable)
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
		public virtual GeoBahaDataSet.DELETE_asnad2DataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.DELETE_asnad2DataTable dELETE_asnad2DataTable = new GeoBahaDataSet.DELETE_asnad2DataTable();
			Adapter.Fill(dELETE_asnad2DataTable);
			return dELETE_asnad2DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet.DELETE_asnad2DataTable dataTable)
		{
			return Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet dataSet)
		{
			return Adapter.Update(dataSet, "DELETE_asnad2");
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
		public virtual int Insert(decimal recnum, string radif, decimal sanadnum, string itemnum, string sharhitem, double mablagh, string groupnum, string groupname, string fasl, decimal vahed, double ghvahed, string shvahed, double total, bool darsad, bool setarehdar, decimal itemdarsad, string itemname, string molahezat, bool fopf, string SalMali, string IjadSystem, string EslahSystem, DateTime? TimeIjad, DateTime? TimeEslah, string DeleteSystem, DateTime? TimeDelete)
		{
			Adapter.InsertCommand.Parameters[0].Value = recnum;
			if (radif == null)
			{
				throw new ArgumentNullException("radif");
			}
			Adapter.InsertCommand.Parameters[1].Value = radif;
			Adapter.InsertCommand.Parameters[2].Value = sanadnum;
			if (itemnum == null)
			{
				throw new ArgumentNullException("itemnum");
			}
			Adapter.InsertCommand.Parameters[3].Value = itemnum;
			if (sharhitem == null)
			{
				throw new ArgumentNullException("sharhitem");
			}
			Adapter.InsertCommand.Parameters[4].Value = sharhitem;
			Adapter.InsertCommand.Parameters[5].Value = mablagh;
			if (groupnum == null)
			{
				throw new ArgumentNullException("groupnum");
			}
			Adapter.InsertCommand.Parameters[6].Value = groupnum;
			if (groupname == null)
			{
				throw new ArgumentNullException("groupname");
			}
			Adapter.InsertCommand.Parameters[7].Value = groupname;
			if (fasl == null)
			{
				throw new ArgumentNullException("fasl");
			}
			Adapter.InsertCommand.Parameters[8].Value = fasl;
			Adapter.InsertCommand.Parameters[9].Value = vahed;
			Adapter.InsertCommand.Parameters[10].Value = ghvahed;
			if (shvahed == null)
			{
				throw new ArgumentNullException("shvahed");
			}
			Adapter.InsertCommand.Parameters[11].Value = shvahed;
			Adapter.InsertCommand.Parameters[12].Value = total;
			Adapter.InsertCommand.Parameters[13].Value = darsad;
			Adapter.InsertCommand.Parameters[14].Value = setarehdar;
			Adapter.InsertCommand.Parameters[15].Value = itemdarsad;
			if (itemname == null)
			{
				throw new ArgumentNullException("itemname");
			}
			Adapter.InsertCommand.Parameters[16].Value = itemname;
			if (molahezat == null)
			{
				throw new ArgumentNullException("molahezat");
			}
			Adapter.InsertCommand.Parameters[17].Value = molahezat;
			Adapter.InsertCommand.Parameters[18].Value = fopf;
			if (SalMali == null)
			{
				throw new ArgumentNullException("SalMali");
			}
			Adapter.InsertCommand.Parameters[19].Value = SalMali;
			if (IjadSystem == null)
			{
				Adapter.InsertCommand.Parameters[20].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[20].Value = IjadSystem;
			}
			if (EslahSystem == null)
			{
				Adapter.InsertCommand.Parameters[21].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[21].Value = EslahSystem;
			}
			if (TimeIjad.HasValue)
			{
				Adapter.InsertCommand.Parameters[22].Value = TimeIjad.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[22].Value = DBNull.Value;
			}
			if (TimeEslah.HasValue)
			{
				Adapter.InsertCommand.Parameters[23].Value = TimeEslah.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[23].Value = DBNull.Value;
			}
			if (DeleteSystem == null)
			{
				Adapter.InsertCommand.Parameters[24].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[24].Value = DeleteSystem;
			}
			if (TimeDelete.HasValue)
			{
				Adapter.InsertCommand.Parameters[25].Value = TimeDelete.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[25].Value = DBNull.Value;
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

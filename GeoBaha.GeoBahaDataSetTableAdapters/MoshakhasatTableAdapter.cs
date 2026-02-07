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
	public class MoshakhasatTableAdapter : Component
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
		public MoshakhasatTableAdapter()
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
			dataTableMapping.DataSetTable = "Moshakhasat";
			dataTableMapping.ColumnMappings.Add("ShName", "ShName");
			dataTableMapping.ColumnMappings.Add("CodeEghtesadi", "CodeEghtesadi");
			dataTableMapping.ColumnMappings.Add("OnvanSanad", "OnvanSanad");
			dataTableMapping.ColumnMappings.Add("NameAmel", "NameAmel");
			dataTableMapping.ColumnMappings.Add("EsmRamz", "EsmRamz");
			dataTableMapping.ColumnMappings.Add("MatnNameh", "MatnNameh");
			dataTableMapping.ColumnMappings.Add("AvarezShahrdari", "AvarezShahrdari");
			dataTableMapping.ColumnMappings.Add("AvarezArzeshAfzoode", "AvarezArzeshAfzoode");
			dataTableMapping.ColumnMappings.Add("Semat", "Semat");
			dataTableMapping.ColumnMappings.Add("OnvanMabna", "OnvanMabna");
			_adapter.TableMappings.Add(dataTableMapping);
			_adapter.InsertCommand = new SqlCommand();
			_adapter.InsertCommand.Connection = Connection;
			_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Moshakhasat] ([ShName], [CodeEghtesadi], [OnvanSanad], [NameAmel], [EsmRamz], [MatnNameh], [AvarezShahrdari], [AvarezArzeshAfzoode], [Semat], [OnvanMabna]) VALUES (@ShName, @CodeEghtesadi, @OnvanSanad, @NameAmel, @EsmRamz, @MatnNameh, @AvarezShahrdari, @AvarezArzeshAfzoode, @Semat, @OnvanMabna)";
			_adapter.InsertCommand.CommandType = CommandType.Text;
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ShName", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "ShName", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@CodeEghtesadi", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "CodeEghtesadi", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@OnvanSanad", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "OnvanSanad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NameAmel", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NameAmel", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@EsmRamz", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "EsmRamz", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MatnNameh", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MatnNameh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@AvarezShahrdari", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "AvarezShahrdari", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@AvarezArzeshAfzoode", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "AvarezArzeshAfzoode", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Semat", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Semat", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@OnvanMabna", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "OnvanMabna", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
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
			_commandCollection[0].CommandText = "SELECT ShName, CodeEghtesadi, OnvanSanad, NameAmel, EsmRamz, MatnNameh, AvarezShahrdari, AvarezArzeshAfzoode, Semat, OnvanMabna FROM dbo.Moshakhasat";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.MoshakhasatDataTable dataTable)
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
		public virtual GeoBahaDataSet.MoshakhasatDataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.MoshakhasatDataTable moshakhasatDataTable = new GeoBahaDataSet.MoshakhasatDataTable();
			Adapter.Fill(moshakhasatDataTable);
			return moshakhasatDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet.MoshakhasatDataTable dataTable)
		{
			return Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet dataSet)
		{
			return Adapter.Update(dataSet, "Moshakhasat");
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
		public virtual int Insert(string ShName, string CodeEghtesadi, string OnvanSanad, string NameAmel, string EsmRamz, string MatnNameh, string AvarezShahrdari, string AvarezArzeshAfzoode, string Semat, string OnvanMabna)
		{
			if (ShName == null)
			{
				Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[0].Value = ShName;
			}
			if (CodeEghtesadi == null)
			{
				Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[1].Value = CodeEghtesadi;
			}
			if (OnvanSanad == null)
			{
				Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[2].Value = OnvanSanad;
			}
			if (NameAmel == null)
			{
				Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[3].Value = NameAmel;
			}
			if (EsmRamz == null)
			{
				Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[4].Value = EsmRamz;
			}
			if (MatnNameh == null)
			{
				Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[5].Value = MatnNameh;
			}
			if (AvarezShahrdari == null)
			{
				Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[6].Value = AvarezShahrdari;
			}
			if (AvarezArzeshAfzoode == null)
			{
				Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[7].Value = AvarezArzeshAfzoode;
			}
			if (Semat == null)
			{
				Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[8].Value = Semat;
			}
			if (OnvanMabna == null)
			{
				Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[9].Value = OnvanMabna;
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

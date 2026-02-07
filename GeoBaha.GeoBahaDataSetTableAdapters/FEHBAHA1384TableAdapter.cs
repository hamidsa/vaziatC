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
	public class FEHBAHA1384TableAdapter : Component
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
		public FEHBAHA1384TableAdapter()
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
			dataTableMapping.DataSetTable = "FEHBAHA1384";
			dataTableMapping.ColumnMappings.Add("radif", "radif");
			dataTableMapping.ColumnMappings.Add("shomar", "shomar");
			dataTableMapping.ColumnMappings.Add("Sharh", "Sharh");
			dataTableMapping.ColumnMappings.Add("Fasl", "Fasl");
			dataTableMapping.ColumnMappings.Add("vkod", "vkod");
			dataTableMapping.ColumnMappings.Add("Vahed", "Vahed");
			dataTableMapping.ColumnMappings.Add("baha", "baha");
			dataTableMapping.ColumnMappings.Add("darsad", "darsad");
			dataTableMapping.ColumnMappings.Add("setareh", "setareh");
			dataTableMapping.ColumnMappings.Add("ItemNoa", "ItemNoa");
			dataTableMapping.ColumnMappings.Add("ItemDarsad", "ItemDarsad");
			dataTableMapping.ColumnMappings.Add("GroupNo", "GroupNo");
			dataTableMapping.ColumnMappings.Add("GroupName", "GroupName");
			dataTableMapping.ColumnMappings.Add("Selection", "Selection");
			_adapter.TableMappings.Add(dataTableMapping);
			_adapter.InsertCommand = new SqlCommand();
			_adapter.InsertCommand.Connection = Connection;
			_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[FEHBAHA1384] ([radif], [shomar], [Sharh], [Fasl], [vkod], [Vahed], [baha], [darsad], [setareh], [ItemNoa], [ItemDarsad], [GroupNo], [GroupName], [Selection]) VALUES (@radif, @shomar, @Sharh, @Fasl, @vkod, @Vahed, @baha, @darsad, @setareh, @ItemNoa, @ItemDarsad, @GroupNo, @GroupName, @Selection)";
			_adapter.InsertCommand.CommandType = CommandType.Text;
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@radif", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "radif", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@shomar", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "shomar", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Sharh", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Sharh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Fasl", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Fasl", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@vkod", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "vkod", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Vahed", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Vahed", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@baha", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "baha", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@darsad", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "darsad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@setareh", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "setareh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ItemNoa", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ItemNoa", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ItemDarsad", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ItemDarsad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@GroupNo", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "GroupNo", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@GroupName", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "GroupName", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Selection", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Selection", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
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
			_commandCollection[0].CommandText = "SELECT radif, shomar, Sharh, Fasl, vkod, Vahed, baha, darsad, setareh, ItemNoa, ItemDarsad, GroupNo, GroupName, Selection FROM dbo.FEHBAHA1384";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.FEHBAHA1384DataTable dataTable)
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
		public virtual GeoBahaDataSet.FEHBAHA1384DataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.FEHBAHA1384DataTable fEHBAHA1384DataTable = new GeoBahaDataSet.FEHBAHA1384DataTable();
			Adapter.Fill(fEHBAHA1384DataTable);
			return fEHBAHA1384DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet.FEHBAHA1384DataTable dataTable)
		{
			return Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet dataSet)
		{
			return Adapter.Update(dataSet, "FEHBAHA1384");
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
		public virtual int Insert(string radif, string shomar, string Sharh, string Fasl, decimal? vkod, string Vahed, string baha, bool? darsad, bool? setareh, string ItemNoa, string ItemDarsad, string GroupNo, string GroupName, bool? Selection)
		{
			if (radif == null)
			{
				Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[0].Value = radif;
			}
			if (shomar == null)
			{
				throw new ArgumentNullException("shomar");
			}
			Adapter.InsertCommand.Parameters[1].Value = shomar;
			if (Sharh == null)
			{
				throw new ArgumentNullException("Sharh");
			}
			Adapter.InsertCommand.Parameters[2].Value = Sharh;
			if (Fasl == null)
			{
				throw new ArgumentNullException("Fasl");
			}
			Adapter.InsertCommand.Parameters[3].Value = Fasl;
			if (vkod.HasValue)
			{
				Adapter.InsertCommand.Parameters[4].Value = vkod.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			if (Vahed == null)
			{
				throw new ArgumentNullException("Vahed");
			}
			Adapter.InsertCommand.Parameters[5].Value = Vahed;
			if (baha == null)
			{
				throw new ArgumentNullException("baha");
			}
			Adapter.InsertCommand.Parameters[6].Value = baha;
			if (darsad.HasValue)
			{
				Adapter.InsertCommand.Parameters[7].Value = darsad.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			if (setareh.HasValue)
			{
				Adapter.InsertCommand.Parameters[8].Value = setareh.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			if (ItemNoa == null)
			{
				throw new ArgumentNullException("ItemNoa");
			}
			Adapter.InsertCommand.Parameters[9].Value = ItemNoa;
			if (ItemDarsad == null)
			{
				Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[10].Value = ItemDarsad;
			}
			if (GroupNo == null)
			{
				Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[11].Value = GroupNo;
			}
			if (GroupName == null)
			{
				Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[12].Value = GroupName;
			}
			if (Selection.HasValue)
			{
				Adapter.InsertCommand.Parameters[13].Value = Selection.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
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

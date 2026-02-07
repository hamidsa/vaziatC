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
	public class Select_SanadTableAdapter : Component
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
		public Select_SanadTableAdapter()
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
			dataTableMapping.DataSetTable = "Select_Sanad";
			dataTableMapping.ColumnMappings.Add("recnum", "recnum");
			dataTableMapping.ColumnMappings.Add("radif", "radif");
			dataTableMapping.ColumnMappings.Add("sanadnum", "sanadnum");
			dataTableMapping.ColumnMappings.Add("karnum", "karnum");
			dataTableMapping.ColumnMappings.Add("pkod", "pkod");
			dataTableMapping.ColumnMappings.Add("sanaddatey", "sanaddatey");
			dataTableMapping.ColumnMappings.Add("sanaddatem", "sanaddatem");
			dataTableMapping.ColumnMappings.Add("sanaddated", "sanaddated");
			dataTableMapping.ColumnMappings.Add("fehkod", "fehkod");
			dataTableMapping.ColumnMappings.Add("forpf", "forpf");
			dataTableMapping.ColumnMappings.Add("mablaghk", "mablaghk");
			dataTableMapping.ColumnMappings.Add("pname1", "pname1");
			dataTableMapping.ColumnMappings.Add("karkod1", "karkod1");
			dataTableMapping.ColumnMappings.Add("karname1", "karname1");
			dataTableMapping.ColumnMappings.Add("Karname2", "Karname2");
			dataTableMapping.ColumnMappings.Add("fehrest", "fehrest");
			dataTableMapping.ColumnMappings.Add("noeSanad", "noeSanad");
			dataTableMapping.ColumnMappings.Add("Salmali", "Salmali");
			dataTableMapping.ColumnMappings.Add("zarib", "zarib");
			dataTableMapping.ColumnMappings.Add("Nameh", "Nameh");
			dataTableMapping.ColumnMappings.Add("fehrestfile", "fehrestfile");
			dataTableMapping.ColumnMappings.Add("Pname2", "Pname2");
			dataTableMapping.ColumnMappings.Add("Ronevwsht", "Ronevwsht");
			dataTableMapping.ColumnMappings.Add("Printed", "Printed");
			dataTableMapping.ColumnMappings.Add("IjadSystem", "IjadSystem");
			dataTableMapping.ColumnMappings.Add("EslahSystem", "EslahSystem");
			dataTableMapping.ColumnMappings.Add("TimeIjad", "TimeIjad");
			dataTableMapping.ColumnMappings.Add("TimeEslah", "TimeEslah");
			dataTableMapping.ColumnMappings.Add("Soori", "Soori");
			_adapter.TableMappings.Add(dataTableMapping);
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
			_commandCollection[0].CommandText = "dbo.Select_Sanad";
			_commandCollection[0].CommandType = CommandType.StoredProcedure;
			_commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[0].Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[0].Parameters.Add(new SqlParameter("@forpf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[0].Parameters.Add(new SqlParameter("@Salmali", SqlDbType.VarChar, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.Select_SanadDataTable dataTable, int? sanadnum, bool? forpf, string Salmali)
		{
			Adapter.SelectCommand = CommandCollection[0];
			if (sanadnum.HasValue)
			{
				Adapter.SelectCommand.Parameters[1].Value = sanadnum.Value;
			}
			else
			{
				Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			if (forpf.HasValue)
			{
				Adapter.SelectCommand.Parameters[2].Value = forpf.Value;
			}
			else
			{
				Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			if (Salmali == null)
			{
				Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				Adapter.SelectCommand.Parameters[3].Value = Salmali;
			}
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
		public virtual GeoBahaDataSet.Select_SanadDataTable GetData(int? sanadnum, bool? forpf, string Salmali)
		{
			Adapter.SelectCommand = CommandCollection[0];
			if (sanadnum.HasValue)
			{
				Adapter.SelectCommand.Parameters[1].Value = sanadnum.Value;
			}
			else
			{
				Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			if (forpf.HasValue)
			{
				Adapter.SelectCommand.Parameters[2].Value = forpf.Value;
			}
			else
			{
				Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			if (Salmali == null)
			{
				Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				Adapter.SelectCommand.Parameters[3].Value = Salmali;
			}
			GeoBahaDataSet.Select_SanadDataTable select_SanadDataTable = new GeoBahaDataSet.Select_SanadDataTable();
			Adapter.Fill(select_SanadDataTable);
			return select_SanadDataTable;
		}
	}
}

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
	public class Baravord10205TableAdapter : Component
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
		public Baravord10205TableAdapter()
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
			dataTableMapping.DataSetTable = "Baravord10205";
			dataTableMapping.ColumnMappings.Add("sanadnum", "sanadnum");
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
			_commandCollection[0].CommandText = "SELECT sanadnum FROM dbo.Baravord10205";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.Baravord10205DataTable dataTable)
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
		public virtual GeoBahaDataSet.Baravord10205DataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.Baravord10205DataTable baravord10205DataTable = new GeoBahaDataSet.Baravord10205DataTable();
			Adapter.Fill(baravord10205DataTable);
			return baravord10205DataTable;
		}
	}
}

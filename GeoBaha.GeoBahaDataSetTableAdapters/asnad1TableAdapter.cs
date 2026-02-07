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
	public class asnad1TableAdapter : Component
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
		public asnad1TableAdapter()
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
			dataTableMapping.DataSetTable = "asnad1";
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
			dataTableMapping.ColumnMappings.Add("OnvanCode", "OnvanCode");
			dataTableMapping.ColumnMappings.Add("Ghaleb", "Ghaleb");
			_adapter.TableMappings.Add(dataTableMapping);
			_adapter.InsertCommand = new SqlCommand();
			_adapter.InsertCommand.Connection = Connection;
			_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[asnad1] ([radif], [sanadnum], [karnum], [pkod], [sanaddatey], [sanaddatem], [sanaddated], [fehkod], [forpf], [mablaghk], [pname1], [karkod1], [karname1], [Karname2], [fehrest], [noeSanad], [Salmali], [zarib], [Nameh], [fehrestfile], [Pname2], [Ronevwsht], [Printed], [IjadSystem], [EslahSystem], [TimeIjad], [TimeEslah], [Soori], [OnvanCode], [Ghaleb]) VALUES (@radif, @sanadnum, @karnum, @pkod, @sanaddatey, @sanaddatem, @sanaddated, @fehkod, @forpf, @mablaghk, @pname1, @karkod1, @karname1, @Karname2, @fehrest, @noeSanad, @Salmali, @zarib, @Nameh, @fehrestfile, @Pname2, @Ronevwsht, @Printed, @IjadSystem, @EslahSystem, @TimeIjad, @TimeEslah, @Soori, @OnvanCode, @Ghaleb)";
			_adapter.InsertCommand.CommandType = CommandType.Text;
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@radif", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "radif", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "sanadnum", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@karnum", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "karnum", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@pkod", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "pkod", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sanaddatey", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "sanaddatey", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sanaddatem", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "sanaddatem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@sanaddated", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "sanaddated", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@fehkod", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "fehkod", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@forpf", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "forpf", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@mablaghk", SqlDbType.Float, 0, ParameterDirection.Input, 0, 0, "mablaghk", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@pname1", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "pname1", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@karkod1", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "karkod1", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@karname1", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "karname1", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Karname2", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Karname2", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@fehrest", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "fehrest", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@noeSanad", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "noeSanad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Salmali", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Salmali", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@zarib", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "zarib", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Nameh", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Nameh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@fehrestfile", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "fehrestfile", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pname2", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Pname2", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Ronevwsht", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Ronevwsht", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Printed", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Printed", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@IjadSystem", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "IjadSystem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@EslahSystem", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "EslahSystem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeIjad", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "TimeIjad", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TimeEslah", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "TimeEslah", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Soori", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Soori", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@OnvanCode", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "OnvanCode", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_adapter.InsertCommand.Parameters.Add(new SqlParameter("@Ghaleb", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "Ghaleb", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
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
			_commandCollection[0].CommandText = "SELECT recnum, radif, sanadnum, karnum, pkod, sanaddatey, sanaddatem, sanaddated, fehkod, forpf, mablaghk, pname1, karkod1, karname1, Karname2, fehrest, noeSanad, Salmali, zarib, Nameh, fehrestfile, Pname2, Ronevwsht, Printed, IjadSystem, EslahSystem, TimeIjad, TimeEslah, Soori, OnvanCode, Ghaleb FROM dbo.asnad1";
			_commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(GeoBahaDataSet.asnad1DataTable dataTable)
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
		public virtual GeoBahaDataSet.asnad1DataTable GetData()
		{
			Adapter.SelectCommand = CommandCollection[0];
			GeoBahaDataSet.asnad1DataTable asnad1DataTable = new GeoBahaDataSet.asnad1DataTable();
			Adapter.Fill(asnad1DataTable);
			return asnad1DataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet.asnad1DataTable dataTable)
		{
			return Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(GeoBahaDataSet dataSet)
		{
			return Adapter.Update(dataSet, "asnad1");
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
		public virtual int Insert(string radif, decimal sanadnum, string karnum, decimal pkod, string sanaddatey, string sanaddatem, string sanaddated, decimal fehkod, bool forpf, double mablaghk, string pname1, decimal karkod1, string karname1, string Karname2, string fehrest, string noeSanad, string Salmali, string zarib, string Nameh, string fehrestfile, string Pname2, string Ronevwsht, bool Printed, string IjadSystem, string EslahSystem, DateTime? TimeIjad, DateTime? TimeEslah, int? Soori, string OnvanCode, bool? Ghaleb)
		{
			if (radif == null)
			{
				throw new ArgumentNullException("radif");
			}
			Adapter.InsertCommand.Parameters[0].Value = radif;
			Adapter.InsertCommand.Parameters[1].Value = sanadnum;
			if (karnum == null)
			{
				throw new ArgumentNullException("karnum");
			}
			Adapter.InsertCommand.Parameters[2].Value = karnum;
			Adapter.InsertCommand.Parameters[3].Value = pkod;
			if (sanaddatey == null)
			{
				throw new ArgumentNullException("sanaddatey");
			}
			Adapter.InsertCommand.Parameters[4].Value = sanaddatey;
			if (sanaddatem == null)
			{
				throw new ArgumentNullException("sanaddatem");
			}
			Adapter.InsertCommand.Parameters[5].Value = sanaddatem;
			if (sanaddated == null)
			{
				throw new ArgumentNullException("sanaddated");
			}
			Adapter.InsertCommand.Parameters[6].Value = sanaddated;
			Adapter.InsertCommand.Parameters[7].Value = fehkod;
			Adapter.InsertCommand.Parameters[8].Value = forpf;
			Adapter.InsertCommand.Parameters[9].Value = mablaghk;
			if (pname1 == null)
			{
				throw new ArgumentNullException("pname1");
			}
			Adapter.InsertCommand.Parameters[10].Value = pname1;
			Adapter.InsertCommand.Parameters[11].Value = karkod1;
			if (karname1 == null)
			{
				throw new ArgumentNullException("karname1");
			}
			Adapter.InsertCommand.Parameters[12].Value = karname1;
			if (Karname2 == null)
			{
				Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[13].Value = Karname2;
			}
			if (fehrest == null)
			{
				throw new ArgumentNullException("fehrest");
			}
			Adapter.InsertCommand.Parameters[14].Value = fehrest;
			if (noeSanad == null)
			{
				throw new ArgumentNullException("noeSanad");
			}
			Adapter.InsertCommand.Parameters[15].Value = noeSanad;
			if (Salmali == null)
			{
				throw new ArgumentNullException("Salmali");
			}
			Adapter.InsertCommand.Parameters[16].Value = Salmali;
			if (zarib == null)
			{
				throw new ArgumentNullException("zarib");
			}
			Adapter.InsertCommand.Parameters[17].Value = zarib;
			if (Nameh == null)
			{
				Adapter.InsertCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[18].Value = Nameh;
			}
			if (fehrestfile == null)
			{
				throw new ArgumentNullException("fehrestfile");
			}
			Adapter.InsertCommand.Parameters[19].Value = fehrestfile;
			if (Pname2 == null)
			{
				Adapter.InsertCommand.Parameters[20].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[20].Value = Pname2;
			}
			if (Ronevwsht == null)
			{
				throw new ArgumentNullException("Ronevwsht");
			}
			Adapter.InsertCommand.Parameters[21].Value = Ronevwsht;
			Adapter.InsertCommand.Parameters[22].Value = Printed;
			if (IjadSystem == null)
			{
				Adapter.InsertCommand.Parameters[23].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[23].Value = IjadSystem;
			}
			if (EslahSystem == null)
			{
				Adapter.InsertCommand.Parameters[24].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[24].Value = EslahSystem;
			}
			if (TimeIjad.HasValue)
			{
				Adapter.InsertCommand.Parameters[25].Value = TimeIjad.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[25].Value = DBNull.Value;
			}
			if (TimeEslah.HasValue)
			{
				Adapter.InsertCommand.Parameters[26].Value = TimeEslah.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[26].Value = DBNull.Value;
			}
			if (Soori.HasValue)
			{
				Adapter.InsertCommand.Parameters[27].Value = Soori.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[27].Value = DBNull.Value;
			}
			if (OnvanCode == null)
			{
				Adapter.InsertCommand.Parameters[28].Value = DBNull.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[28].Value = OnvanCode;
			}
			if (Ghaleb.HasValue)
			{
				Adapter.InsertCommand.Parameters[29].Value = Ghaleb.Value;
			}
			else
			{
				Adapter.InsertCommand.Parameters[29].Value = DBNull.Value;
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

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using GeoBaha.My;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha.GeoBahaDataSetTableAdapters
{
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class QueriesTableAdapter : Component
	{
		private IDbCommand[] _commandCollection;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected IDbCommand[] CommandCollection
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
		private void InitCommandCollection()
		{
			_commandCollection = new IDbCommand[55];
			_commandCollection[0] = new SqlCommand();
			((SqlCommand)_commandCollection[0]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[0]).CommandText = "dbo.[_AvarezAdd]";
			((SqlCommand)_commandCollection[0]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[0]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[1] = new SqlCommand();
			((SqlCommand)_commandCollection[1]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[1]).CommandText = "dbo.[_ChSanadOwner]";
			((SqlCommand)_commandCollection[1]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[1]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[1]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[1]).Parameters.Add(new SqlParameter("@IjadSystem", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[1]).Parameters.Add(new SqlParameter("@factor", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[1]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.VarChar, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[2] = new SqlCommand();
			((SqlCommand)_commandCollection[2]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[2]).CommandText = "dbo.[_ForJahd5]";
			((SqlCommand)_commandCollection[2]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[2]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[3] = new SqlCommand();
			((SqlCommand)_commandCollection[3]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[3]).CommandText = "dbo.[_FormatInteger]";
			((SqlCommand)_commandCollection[3]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[3]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[3]).Parameters.Add(new SqlParameter("@Mi", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[4] = new SqlCommand();
			((SqlCommand)_commandCollection[4]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[4]).CommandText = "dbo.[_Sanad84to87]";
			((SqlCommand)_commandCollection[4]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[4]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[5] = new SqlCommand();
			((SqlCommand)_commandCollection[5]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[5]).CommandText = "dbo.[_TedadSanadRooz]";
			((SqlCommand)_commandCollection[5]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[5]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[6] = new SqlCommand();
			((SqlCommand)_commandCollection[6]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[6]).CommandText = "dbo.BackupDB";
			((SqlCommand)_commandCollection[6]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[6]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[7] = new SqlCommand();
			((SqlCommand)_commandCollection[7]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[7]).CommandText = "dbo.DeleteSanad";
			((SqlCommand)_commandCollection[7]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[7]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[7]).Parameters.Add(new SqlParameter("@Sanadnum", SqlDbType.Char, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[7]).Parameters.Add(new SqlParameter("@Salmali", SqlDbType.Char, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[7]).Parameters.Add(new SqlParameter("@fehfile", SqlDbType.Char, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[7]).Parameters.Add(new SqlParameter("@Forpf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[8] = new SqlCommand();
			((SqlCommand)_commandCollection[8]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[8]).CommandText = "dbo.Fehrestbaha";
			((SqlCommand)_commandCollection[8]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[8]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[8]).Parameters.Add(new SqlParameter("@fehbahaname", SqlDbType.Char, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[9] = new SqlCommand();
			((SqlCommand)_commandCollection[9]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[9]).CommandText = "dbo.Insert_Tabdil";
			((SqlCommand)_commandCollection[9]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[9]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[9]).Parameters.Add(new SqlParameter("@sanadnum1", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[9]).Parameters.Add(new SqlParameter("@sanadnum2", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[9]).Parameters.Add(new SqlParameter("@forpf1", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[9]).Parameters.Add(new SqlParameter("@forpf2", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[9]).Parameters.Add(new SqlParameter("@Salmali1", SqlDbType.VarChar, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[9]).Parameters.Add(new SqlParameter("@Salmali2", SqlDbType.VarChar, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[9]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[10] = new SqlCommand();
			((SqlCommand)_commandCollection[10]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[10]).CommandText = "dbo.IUD_Asnad1";
			((SqlCommand)_commandCollection[10]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@recnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@radif", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@karnum", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@pkod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@sanaddatey", SqlDbType.VarChar, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@sanaddatem", SqlDbType.VarChar, 2, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@sanaddated", SqlDbType.VarChar, 2, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@fehkod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@forpf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@mablaghk", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@pname1", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@karkod1", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@karname1", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@Karname2", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@fehrest", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@noeSanad", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@Salmali", SqlDbType.VarChar, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@zarib", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@Nameh", SqlDbType.VarChar, 4000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@fehrestfile", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@Pname2", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@Ronevwsht", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@Printed", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@Soori", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[10]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[11] = new SqlCommand();
			((SqlCommand)_commandCollection[11]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[11]).CommandText = "dbo.IUD_Asnad2";
			((SqlCommand)_commandCollection[11]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@recnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@radif", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@itemnum", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@sharhitem", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@mablagh", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@groupnum", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@groupname", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@fasl", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@vahed", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@ghvahed", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@shvahed", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@total", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@darsad", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@setarehdar", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@itemdarsad", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@itemname", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@molahezat", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@SalMali", SqlDbType.VarChar, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@KodDafaterVaBakhsh", SqlDbType.VarChar, 3, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@NameDafaterVaBakhsh", SqlDbType.VarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@KodGroup", SqlDbType.VarChar, 3, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[11]).Parameters.Add(new SqlParameter("@NameGroup", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[12] = new SqlCommand();
			((SqlCommand)_commandCollection[12]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[12]).CommandText = "dbo.IUD_Asnad4";
			((SqlCommand)_commandCollection[12]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@recnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@Sharh", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@darsad", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@maghtoo", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@mablagh", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@mablaghk", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@Salmali", SqlDbType.VarChar, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[12]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[13] = new SqlCommand();
			((SqlCommand)_commandCollection[13]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[13]).CommandText = "dbo.IUD_Bakhsh";
			((SqlCommand)_commandCollection[13]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@identradif", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@okod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@shkod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@bkod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@bname", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@zarib", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@fehrest", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[13]).Parameters.Add(new SqlParameter("@bkodOUT", SqlDbType.Decimal, 9, ParameterDirection.InputOutput, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[14] = new SqlCommand();
			((SqlCommand)_commandCollection[14]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[14]).CommandText = "dbo.IUD_Fehrestbaha";
			((SqlCommand)_commandCollection[14]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@chshomar", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@shomar", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@sharh", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@fasl", SqlDbType.VarChar, 5, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@vkod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@vahed", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@baha", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@darsad", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@setareh", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@fehfile", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[14]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[15] = new SqlCommand();
			((SqlCommand)_commandCollection[15]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[15]).CommandText = "dbo.IUD_Karfarma";
			((SqlCommand)_commandCollection[15]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@kknum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@kname", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@adres", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@tel", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@ShomareEghtesadi", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@ShomareSabtYaMelli", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@ShahrKod", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@ShahrName", SqlDbType.VarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@KodPosti", SqlDbType.VarChar, 20, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[15]).Parameters.Add(new SqlParameter("@kknumOUT", SqlDbType.Decimal, 9, ParameterDirection.InputOutput, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[16] = new SqlCommand();
			((SqlCommand)_commandCollection[16]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[16]).CommandText = "dbo.IUD_Ostan";
			((SqlCommand)_commandCollection[16]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[16]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[16]).Parameters.Add(new SqlParameter("@okod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[16]).Parameters.Add(new SqlParameter("@oname", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[16]).Parameters.Add(new SqlParameter("@fehrest", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[16]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[16]).Parameters.Add(new SqlParameter("@okodOUT", SqlDbType.Decimal, 9, ParameterDirection.InputOutput, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[17] = new SqlCommand();
			((SqlCommand)_commandCollection[17]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[17]).CommandText = "dbo.IUD_Projects";
			((SqlCommand)_commandCollection[17]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@pkod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@pname", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@padres", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@ptel", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@bakhshkod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@fehrest", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@fehname", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[17]).Parameters.Add(new SqlParameter("@pkodOUT", SqlDbType.Decimal, 9, ParameterDirection.InputOutput, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[18] = new SqlCommand();
			((SqlCommand)_commandCollection[18]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[18]).CommandText = "dbo.IUD_Sarfasl";
			((SqlCommand)_commandCollection[18]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@faslnum", SqlDbType.VarChar, 2, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@faslname", SqlDbType.VarChar, 150, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@fasltext", SqlDbType.Text, int.MaxValue, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@faslzarib", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@fehname", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@KodBakhshPishfarz", SqlDbType.VarChar, 3, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@NameBakhshPishfarz", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[18]).Parameters.Add(new SqlParameter("@kodOUT", SqlDbType.Decimal, 9, ParameterDirection.InputOutput, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[19] = new SqlCommand();
			((SqlCommand)_commandCollection[19]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[19]).CommandText = "dbo.IUD_Shahrha";
			((SqlCommand)_commandCollection[19]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[19]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[19]).Parameters.Add(new SqlParameter("@okod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[19]).Parameters.Add(new SqlParameter("@shkod", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[19]).Parameters.Add(new SqlParameter("@shname", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[19]).Parameters.Add(new SqlParameter("@fehrest", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[19]).Parameters.Add(new SqlParameter("@InsUpd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[19]).Parameters.Add(new SqlParameter("@shkodOUT", SqlDbType.Decimal, 9, ParameterDirection.InputOutput, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[20] = new SqlCommand();
			((SqlCommand)_commandCollection[20]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[20]).CommandText = "dbo.JamSanadMablagh";
			((SqlCommand)_commandCollection[20]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[20]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[20]).Parameters.Add(new SqlParameter("@sanadnumber", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[20]).Parameters.Add(new SqlParameter("@FactorOrPF", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[20]).Parameters.Add(new SqlParameter("@fehname", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[20]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[20]).Parameters.Add(new SqlParameter("@Zaribbakhsh", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[21] = new SqlCommand();
			((SqlCommand)_commandCollection[21]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[21]).CommandText = "dbo.ListTableRowCounts";
			((SqlCommand)_commandCollection[21]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[21]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[22] = new SqlCommand();
			((SqlCommand)_commandCollection[22]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[22]).CommandText = "dbo.Load_Cmbo";
			((SqlCommand)_commandCollection[22]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[22]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[22]).Parameters.Add(new SqlParameter("@strField", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[22]).Parameters.Add(new SqlParameter("@strTable", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[22]).Parameters.Add(new SqlParameter("@strWhere", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[23] = new SqlCommand();
			((SqlCommand)_commandCollection[23]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[23]).CommandText = "dbo.MablaghKoliSanad";
			((SqlCommand)_commandCollection[23]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[23]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[23]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[23]).Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[23]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Char, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[23]).Parameters.Add(new SqlParameter("@fehname", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[23]).Parameters.Add(new SqlParameter("@Zaribbakhsh", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[24] = new SqlCommand();
			((SqlCommand)_commandCollection[24]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[24]).CommandText = "dbo.Mohasebe_Asnad4";
			((SqlCommand)_commandCollection[24]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[24]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[24]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[24]).Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[24]).Parameters.Add(new SqlParameter("@Salmali", SqlDbType.Char, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[24]).Parameters.Add(new SqlParameter("@fehname", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[24]).Parameters.Add(new SqlParameter("@Zaribbakhsh", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[25] = new SqlCommand();
			((SqlCommand)_commandCollection[25]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[25]).CommandText = "dbo.PaksaziAvarez";
			((SqlCommand)_commandCollection[25]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[25]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[26] = new SqlCommand();
			((SqlCommand)_commandCollection[26]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[26]).CommandText = "dbo.RecNumber_Asnad2";
			((SqlCommand)_commandCollection[26]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[26]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[26]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[26]).Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[26]).Parameters.Add(new SqlParameter("@SalMali", SqlDbType.Char, 4, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[27] = new SqlCommand();
			((SqlCommand)_commandCollection[27]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[27]).CommandText = "dbo.SanadKholase";
			((SqlCommand)_commandCollection[27]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[27]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[27]).Parameters.Add(new SqlParameter("@sanadnumber", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[27]).Parameters.Add(new SqlParameter("@FactorOrPF", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[27]).Parameters.Add(new SqlParameter("@fehname", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[27]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[27]).Parameters.Add(new SqlParameter("@Zaribbakhsh", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[28] = new SqlCommand();
			((SqlCommand)_commandCollection[28]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[28]).CommandText = "dbo.SanadKholaseChap";
			((SqlCommand)_commandCollection[28]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[28]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[28]).Parameters.Add(new SqlParameter("@sanadnumber", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[28]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[29] = new SqlCommand();
			((SqlCommand)_commandCollection[29]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[29]).CommandText = "dbo.SanadKholaseIjad";
			((SqlCommand)_commandCollection[29]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[29]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[29]).Parameters.Add(new SqlParameter("@sanadnumber", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[29]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[30] = new SqlCommand();
			((SqlCommand)_commandCollection[30]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[30]).CommandText = "dbo.SanadSayerAghlam";
			((SqlCommand)_commandCollection[30]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[30]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[30]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[30]).Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[30]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[31] = new SqlCommand();
			((SqlCommand)_commandCollection[31]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[31]).CommandText = "dbo.Search_Asnad";
			((SqlCommand)_commandCollection[31]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[31]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[31]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[32] = new SqlCommand();
			((SqlCommand)_commandCollection[32]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[32]).CommandText = "dbo.Select_Asnad3";
			((SqlCommand)_commandCollection[32]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[32]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[33] = new SqlCommand();
			((SqlCommand)_commandCollection[33]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[33]).CommandText = "dbo.Select_Bakhsh";
			((SqlCommand)_commandCollection[33]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[33]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[34] = new SqlCommand();
			((SqlCommand)_commandCollection[34]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[34]).CommandText = "dbo.Select_fehrest";
			((SqlCommand)_commandCollection[34]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[34]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[35] = new SqlCommand();
			((SqlCommand)_commandCollection[35]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[35]).CommandText = "dbo.Select_Karfarma";
			((SqlCommand)_commandCollection[35]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[35]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[36] = new SqlCommand();
			((SqlCommand)_commandCollection[36]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[36]).CommandText = "dbo.Select_MablaghSanad";
			((SqlCommand)_commandCollection[36]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[36]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[36]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Char, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[36]).Parameters.Add(new SqlParameter("@fopf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[36]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[37] = new SqlCommand();
			((SqlCommand)_commandCollection[37]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[37]).CommandText = "dbo.Select_Ostan";
			((SqlCommand)_commandCollection[37]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[37]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[38] = new SqlCommand();
			((SqlCommand)_commandCollection[38]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[38]).CommandText = "dbo.Select_shahrha";
			((SqlCommand)_commandCollection[38]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[38]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[39] = new SqlCommand();
			((SqlCommand)_commandCollection[39]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[39]).CommandText = "dbo.Select_YesNo";
			((SqlCommand)_commandCollection[39]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[39]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[40] = new SqlCommand();
			((SqlCommand)_commandCollection[40]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[40]).CommandText = "dbo.SelectAsnad";
			((SqlCommand)_commandCollection[40]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[40]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[40]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Char, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[40]).Parameters.Add(new SqlParameter("@forpf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[41] = new SqlCommand();
			((SqlCommand)_commandCollection[41]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[41]).CommandText = "dbo.SelectSanad";
			((SqlCommand)_commandCollection[41]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[41]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[41]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Char, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[41]).Parameters.Add(new SqlParameter("@forpf", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[41]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[42] = new SqlCommand();
			((SqlCommand)_commandCollection[42]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[42]).CommandText = "dbo.ArzeshAfzoode";
			((SqlCommand)_commandCollection[42]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[42]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[42]).Parameters.Add(new SqlParameter("@SanadNum", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[42]).Parameters.Add(new SqlParameter("@Tarikh", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[43] = new SqlCommand();
			((SqlCommand)_commandCollection[43]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[43]).CommandText = "dbo.DarsadNahaeesanadBeKol";
			((SqlCommand)_commandCollection[43]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[43]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Float, 8, ParameterDirection.ReturnValue, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[43]).Parameters.Add(new SqlParameter("@sanadnumber", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[43]).Parameters.Add(new SqlParameter("@FactorOrPF", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[43]).Parameters.Add(new SqlParameter("@fehname", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[43]).Parameters.Add(new SqlParameter("@salmali", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[44] = new SqlCommand();
			((SqlCommand)_commandCollection[44]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[44]).CommandText = "dbo.DecryptPassword";
			((SqlCommand)_commandCollection[44]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[44]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.VarChar, 1000, ParameterDirection.ReturnValue, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[44]).Parameters.Add(new SqlParameter("@UPassword", SqlDbType.VarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[45] = new SqlCommand();
			((SqlCommand)_commandCollection[45]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[45]).CommandText = "dbo.DLE";
			((SqlCommand)_commandCollection[45]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[45]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Char, 10, ParameterDirection.ReturnValue, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[45]).Parameters.Add(new SqlParameter("@ShamsiDate", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[46] = new SqlCommand();
			((SqlCommand)_commandCollection[46]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[46]).CommandText = "dbo.DLF";
			((SqlCommand)_commandCollection[46]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[46]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Char, 10, ParameterDirection.ReturnValue, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[46]).Parameters.Add(new SqlParameter("@MiladiDate", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[47] = new SqlCommand();
			((SqlCommand)_commandCollection[47]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[47]).CommandText = "dbo.Formatint";
			((SqlCommand)_commandCollection[47]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[47]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.VarChar, 25, ParameterDirection.ReturnValue, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[47]).Parameters.Add(new SqlParameter("@Mi", SqlDbType.BigInt, 8, ParameterDirection.Input, 19, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[48] = new SqlCommand();
			((SqlCommand)_commandCollection[48]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[48]).CommandText = "dbo.MablaghItem";
			((SqlCommand)_commandCollection[48]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[48]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.BigInt, 8, ParameterDirection.ReturnValue, 19, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[48]).Parameters.Add(new SqlParameter("@ItemNum", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[48]).Parameters.Add(new SqlParameter("@FehBaha", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[49] = new SqlCommand();
			((SqlCommand)_commandCollection[49]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[49]).CommandText = "dbo.NumToFarsiString";
			((SqlCommand)_commandCollection[49]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[49]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.VarChar, 1000, ParameterDirection.ReturnValue, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[49]).Parameters.Add(new SqlParameter("@str", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[50] = new SqlCommand();
			((SqlCommand)_commandCollection[50]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[50]).CommandText = "dbo.RND";
			((SqlCommand)_commandCollection[50]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[50]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[50]).Parameters.Add(new SqlParameter("@RNDS", SqlDbType.Real, 4, ParameterDirection.Input, 24, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[51] = new SqlCommand();
			((SqlCommand)_commandCollection[51]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[51]).CommandText = "dbo.SanadMablagh";
			((SqlCommand)_commandCollection[51]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[51]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.BigInt, 8, ParameterDirection.ReturnValue, 19, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[51]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[52] = new SqlCommand();
			((SqlCommand)_commandCollection[52]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[52]).CommandText = "dbo.SanadMablagh2";
			((SqlCommand)_commandCollection[52]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[52]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.BigInt, 8, ParameterDirection.ReturnValue, 19, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[52]).Parameters.Add(new SqlParameter("@sanadnum", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[53] = new SqlCommand();
			((SqlCommand)_commandCollection[53]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[53]).CommandText = "dbo.strtostr2";
			((SqlCommand)_commandCollection[53]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[53]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.NVarChar, 1000, ParameterDirection.ReturnValue, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[53]).Parameters.Add(new SqlParameter("@stringstart", SqlDbType.NVarChar, 1000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			_commandCollection[54] = new SqlCommand();
			((SqlCommand)_commandCollection[54]).Connection = new SqlConnection(MySettings.Default.GeoBahaConnectionString);
			((SqlCommand)_commandCollection[54]).CommandText = "dbo.zaribTo1";
			((SqlCommand)_commandCollection[54]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)_commandCollection[54]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Float, 8, ParameterDirection.ReturnValue, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[54]).Parameters.Add(new SqlParameter("@zarib", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[54]).Parameters.Add(new SqlParameter("@check", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[54]).Parameters.Add(new SqlParameter("@fehname", SqlDbType.NVarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
			((SqlCommand)_commandCollection[54]).Parameters.Add(new SqlParameter("@fasl", SqlDbType.VarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int _AvarezAdd()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[0];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int _ChSanadOwner(string sanadnum, string IjadSystem, bool? factor, string salmali)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[1];
			if (sanadnum == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = sanadnum;
			}
			if (IjadSystem == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = IjadSystem;
			}
			if (factor.HasValue)
			{
				sqlCommand.Parameters[3].Value = factor.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			if (salmali == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = salmali;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int _ForJahd5()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[2];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int _FormatInteger(long? Mi)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[3];
			if (Mi.HasValue)
			{
				sqlCommand.Parameters[1].Value = Mi.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int _Sanad84to87()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[4];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int _TedadSanadRooz()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[5];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int BackupDB()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[6];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int DeleteSanad(string Sanadnum, string Salmali, string fehfile, bool? Forpf)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[7];
			if (Sanadnum == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = Sanadnum;
			}
			if (Salmali == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = Salmali;
			}
			if (fehfile == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = fehfile;
			}
			if (Forpf.HasValue)
			{
				sqlCommand.Parameters[4].Value = Forpf.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fehrestbaha(string fehbahaname)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[8];
			if (fehbahaname == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = fehbahaname;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Insert_Tabdil(decimal? sanadnum1, decimal? sanadnum2, bool? forpf1, bool? forpf2, string Salmali1, string Salmali2, int? InsUpd)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[9];
			if (sanadnum1.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnum1.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (sanadnum2.HasValue)
			{
				sqlCommand.Parameters[2].Value = sanadnum2.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (forpf1.HasValue)
			{
				sqlCommand.Parameters[3].Value = forpf1.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			if (forpf2.HasValue)
			{
				sqlCommand.Parameters[4].Value = forpf2.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			if (Salmali1 == null)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = Salmali1;
			}
			if (Salmali2 == null)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = Salmali2;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[7].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Asnad1(decimal? recnum, string radif, decimal? sanadnum, string karnum, decimal? pkod, string sanaddatey, string sanaddatem, string sanaddated, decimal? fehkod, bool? forpf, double? mablaghk, string pname1, decimal? karkod1, string karname1, string Karname2, string fehrest, string noeSanad, string Salmali, string zarib, string Nameh, string fehrestfile, string Pname2, string Ronevwsht, bool? Printed, int? Soori, int? InsUpd)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[10];
			if (recnum.HasValue)
			{
				sqlCommand.Parameters[1].Value = recnum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (radif == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = radif;
			}
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[3].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			if (karnum == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = karnum;
			}
			if (pkod.HasValue)
			{
				sqlCommand.Parameters[5].Value = pkod.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			if (sanaddatey == null)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = sanaddatey;
			}
			if (sanaddatem == null)
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = sanaddatem;
			}
			if (sanaddated == null)
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = sanaddated;
			}
			if (fehkod.HasValue)
			{
				sqlCommand.Parameters[9].Value = fehkod.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			if (forpf.HasValue)
			{
				sqlCommand.Parameters[10].Value = forpf.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			if (mablaghk.HasValue)
			{
				sqlCommand.Parameters[11].Value = mablaghk.Value;
			}
			else
			{
				sqlCommand.Parameters[11].Value = DBNull.Value;
			}
			if (pname1 == null)
			{
				sqlCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[12].Value = pname1;
			}
			if (karkod1.HasValue)
			{
				sqlCommand.Parameters[13].Value = karkod1.Value;
			}
			else
			{
				sqlCommand.Parameters[13].Value = DBNull.Value;
			}
			if (karname1 == null)
			{
				sqlCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[14].Value = karname1;
			}
			if (Karname2 == null)
			{
				sqlCommand.Parameters[15].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[15].Value = Karname2;
			}
			if (fehrest == null)
			{
				sqlCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[16].Value = fehrest;
			}
			if (noeSanad == null)
			{
				sqlCommand.Parameters[17].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[17].Value = noeSanad;
			}
			if (Salmali == null)
			{
				sqlCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[18].Value = Salmali;
			}
			if (zarib == null)
			{
				sqlCommand.Parameters[19].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[19].Value = zarib;
			}
			if (Nameh == null)
			{
				sqlCommand.Parameters[20].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[20].Value = Nameh;
			}
			if (fehrestfile == null)
			{
				sqlCommand.Parameters[21].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[21].Value = fehrestfile;
			}
			if (Pname2 == null)
			{
				sqlCommand.Parameters[22].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[22].Value = Pname2;
			}
			if (Ronevwsht == null)
			{
				sqlCommand.Parameters[23].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[23].Value = Ronevwsht;
			}
			if (Printed.HasValue)
			{
				sqlCommand.Parameters[24].Value = Printed.Value;
			}
			else
			{
				sqlCommand.Parameters[24].Value = DBNull.Value;
			}
			if (Soori.HasValue)
			{
				sqlCommand.Parameters[25].Value = Soori.Value;
			}
			else
			{
				sqlCommand.Parameters[25].Value = DBNull.Value;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[26].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[26].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Asnad2(decimal? recnum, string radif, decimal? sanadnum, string itemnum, string sharhitem, double? mablagh, string groupnum, string groupname, string fasl, decimal? vahed, double? ghvahed, string shvahed, double? total, bool? darsad, bool? setarehdar, decimal? itemdarsad, string itemname, string molahezat, bool? fopf, string SalMali, int? InsUpd, string KodDafaterVaBakhsh, string NameDafaterVaBakhsh, string KodGroup, string NameGroup)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[11];
			if (recnum.HasValue)
			{
				sqlCommand.Parameters[1].Value = recnum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (radif == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = radif;
			}
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[3].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			if (itemnum == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = itemnum;
			}
			if (sharhitem == null)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = sharhitem;
			}
			if (mablagh.HasValue)
			{
				sqlCommand.Parameters[6].Value = mablagh.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			if (groupnum == null)
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = groupnum;
			}
			if (groupname == null)
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = groupname;
			}
			if (fasl == null)
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = fasl;
			}
			if (vahed.HasValue)
			{
				sqlCommand.Parameters[10].Value = vahed.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			if (ghvahed.HasValue)
			{
				sqlCommand.Parameters[11].Value = ghvahed.Value;
			}
			else
			{
				sqlCommand.Parameters[11].Value = DBNull.Value;
			}
			if (shvahed == null)
			{
				sqlCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[12].Value = shvahed;
			}
			if (total.HasValue)
			{
				sqlCommand.Parameters[13].Value = total.Value;
			}
			else
			{
				sqlCommand.Parameters[13].Value = DBNull.Value;
			}
			if (darsad.HasValue)
			{
				sqlCommand.Parameters[14].Value = darsad.Value;
			}
			else
			{
				sqlCommand.Parameters[14].Value = DBNull.Value;
			}
			if (setarehdar.HasValue)
			{
				sqlCommand.Parameters[15].Value = setarehdar.Value;
			}
			else
			{
				sqlCommand.Parameters[15].Value = DBNull.Value;
			}
			if (itemdarsad.HasValue)
			{
				sqlCommand.Parameters[16].Value = itemdarsad.Value;
			}
			else
			{
				sqlCommand.Parameters[16].Value = DBNull.Value;
			}
			if (itemname == null)
			{
				sqlCommand.Parameters[17].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[17].Value = itemname;
			}
			if (molahezat == null)
			{
				sqlCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[18].Value = molahezat;
			}
			if (fopf.HasValue)
			{
				sqlCommand.Parameters[19].Value = fopf.Value;
			}
			else
			{
				sqlCommand.Parameters[19].Value = DBNull.Value;
			}
			if (SalMali == null)
			{
				sqlCommand.Parameters[20].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[20].Value = SalMali;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[21].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[21].Value = DBNull.Value;
			}
			if (KodDafaterVaBakhsh == null)
			{
				sqlCommand.Parameters[22].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[22].Value = KodDafaterVaBakhsh;
			}
			if (NameDafaterVaBakhsh == null)
			{
				sqlCommand.Parameters[23].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[23].Value = NameDafaterVaBakhsh;
			}
			if (KodGroup == null)
			{
				sqlCommand.Parameters[24].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[24].Value = KodGroup;
			}
			if (NameGroup == null)
			{
				sqlCommand.Parameters[25].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[25].Value = NameGroup;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Asnad4(decimal? recnum, decimal? sanadnum, bool? fopf, string Sharh, double? darsad, double? maghtoo, double? mablagh, double? mablaghk, string Salmali, int? InsUpd)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[12];
			if (recnum.HasValue)
			{
				sqlCommand.Parameters[1].Value = recnum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[2].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (fopf.HasValue)
			{
				sqlCommand.Parameters[3].Value = fopf.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			if (Sharh == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = Sharh;
			}
			if (darsad.HasValue)
			{
				sqlCommand.Parameters[5].Value = darsad.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			if (maghtoo.HasValue)
			{
				sqlCommand.Parameters[6].Value = maghtoo.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			if (mablagh.HasValue)
			{
				sqlCommand.Parameters[7].Value = mablagh.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			if (mablaghk.HasValue)
			{
				sqlCommand.Parameters[8].Value = mablaghk.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			if (Salmali == null)
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = Salmali;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[10].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Bakhsh(decimal? identradif, decimal? okod, decimal? shkod, decimal? bkod, string bname, string zarib, string fehrest, int? InsUpd, ref decimal? bkodOUT)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[13];
			if (identradif.HasValue)
			{
				sqlCommand.Parameters[1].Value = identradif.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (okod.HasValue)
			{
				sqlCommand.Parameters[2].Value = okod.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (shkod.HasValue)
			{
				sqlCommand.Parameters[3].Value = shkod.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			if (bkod.HasValue)
			{
				sqlCommand.Parameters[4].Value = bkod.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			if (bname == null)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = bname;
			}
			if (zarib == null)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = zarib;
			}
			if (fehrest == null)
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = fehrest;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[8].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			if (bkodOUT.HasValue)
			{
				sqlCommand.Parameters[9].Value = bkodOUT.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			int result;
			try
			{
				result = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[9].Value == null || (object)sqlCommand.Parameters[9].Value.GetType() == typeof(DBNull))
			{
				bkodOUT = null;
			}
			else
			{
				bkodOUT = Conversions.ToDecimal(sqlCommand.Parameters[9].Value);
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Fehrestbaha(string chshomar, string shomar, string sharh, string fasl, decimal? vkod, string vahed, string baha, bool? darsad, bool? setareh, string fehfile, int? InsUpd)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[14];
			if (chshomar == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = chshomar;
			}
			if (shomar == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = shomar;
			}
			if (sharh == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = sharh;
			}
			if (fasl == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = fasl;
			}
			if (vkod.HasValue)
			{
				sqlCommand.Parameters[5].Value = vkod.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			if (vahed == null)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = vahed;
			}
			if (baha == null)
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = baha;
			}
			if (darsad.HasValue)
			{
				sqlCommand.Parameters[8].Value = darsad.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			if (setareh.HasValue)
			{
				sqlCommand.Parameters[9].Value = setareh.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			if (fehfile == null)
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = fehfile;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[11].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[11].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Karfarma(decimal? kknum, string kname, string adres, string tel, string ShomareEghtesadi, string ShomareSabtYaMelli, string ShahrKod, string ShahrName, string KodPosti, int? InsUpd, ref decimal? kknumOUT)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[15];
			if (kknum.HasValue)
			{
				sqlCommand.Parameters[1].Value = kknum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (kname == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = kname;
			}
			if (adres == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = adres;
			}
			if (tel == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = tel;
			}
			if (ShomareEghtesadi == null)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = ShomareEghtesadi;
			}
			if (ShomareSabtYaMelli == null)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = ShomareSabtYaMelli;
			}
			if (ShahrKod == null)
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = ShahrKod;
			}
			if (ShahrName == null)
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = ShahrName;
			}
			if (KodPosti == null)
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = KodPosti;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[10].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			if (kknumOUT.HasValue)
			{
				sqlCommand.Parameters[11].Value = kknumOUT.Value;
			}
			else
			{
				sqlCommand.Parameters[11].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			int result;
			try
			{
				result = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[11].Value == null || (object)sqlCommand.Parameters[11].Value.GetType() == typeof(DBNull))
			{
				kknumOUT = null;
			}
			else
			{
				kknumOUT = Conversions.ToDecimal(sqlCommand.Parameters[11].Value);
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Ostan(decimal? okod, string oname, string fehrest, int? InsUpd, ref decimal? okodOUT)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[16];
			if (okod.HasValue)
			{
				sqlCommand.Parameters[1].Value = okod.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (oname == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = oname;
			}
			if (fehrest == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = fehrest;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[4].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			if (okodOUT.HasValue)
			{
				sqlCommand.Parameters[5].Value = okodOUT.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			int result;
			try
			{
				result = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[5].Value == null || (object)sqlCommand.Parameters[5].Value.GetType() == typeof(DBNull))
			{
				okodOUT = null;
			}
			else
			{
				okodOUT = Conversions.ToDecimal(sqlCommand.Parameters[5].Value);
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Projects(decimal? pkod, string pname, string padres, string ptel, decimal? bakhshkod, string fehrest, string fehname, int? InsUpd, ref decimal? pkodOUT)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[17];
			if (pkod.HasValue)
			{
				sqlCommand.Parameters[1].Value = pkod.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (pname == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = pname;
			}
			if (padres == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = padres;
			}
			if (ptel == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = ptel;
			}
			if (bakhshkod.HasValue)
			{
				sqlCommand.Parameters[5].Value = bakhshkod.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			if (fehrest == null)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = fehrest;
			}
			if (fehname == null)
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = fehname;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[8].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			if (pkodOUT.HasValue)
			{
				sqlCommand.Parameters[9].Value = pkodOUT.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			int result;
			try
			{
				result = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[9].Value == null || (object)sqlCommand.Parameters[9].Value.GetType() == typeof(DBNull))
			{
				pkodOUT = null;
			}
			else
			{
				pkodOUT = Conversions.ToDecimal(sqlCommand.Parameters[9].Value);
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Sarfasl(int? id, string faslnum, string faslname, string fasltext, bool? faslzarib, string fehname, string KodBakhshPishfarz, string NameBakhshPishfarz, int? InsUpd, ref decimal? kodOUT)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[18];
			if (id.HasValue)
			{
				sqlCommand.Parameters[1].Value = id.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (faslnum == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = faslnum;
			}
			if (faslname == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = faslname;
			}
			if (fasltext == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = fasltext;
			}
			if (faslzarib.HasValue)
			{
				sqlCommand.Parameters[5].Value = faslzarib.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			if (fehname == null)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = fehname;
			}
			if (KodBakhshPishfarz == null)
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = KodBakhshPishfarz;
			}
			if (NameBakhshPishfarz == null)
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = NameBakhshPishfarz;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[9].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			if (kodOUT.HasValue)
			{
				sqlCommand.Parameters[10].Value = kodOUT.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			int result;
			try
			{
				result = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[10].Value == null || (object)sqlCommand.Parameters[10].Value.GetType() == typeof(DBNull))
			{
				kodOUT = null;
			}
			else
			{
				kodOUT = Conversions.ToDecimal(sqlCommand.Parameters[10].Value);
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int IUD_Shahrha(decimal? okod, decimal? shkod, string shname, string fehrest, int? InsUpd, ref decimal? shkodOUT)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[19];
			if (okod.HasValue)
			{
				sqlCommand.Parameters[1].Value = okod.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (shkod.HasValue)
			{
				sqlCommand.Parameters[2].Value = shkod.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (shname == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = shname;
			}
			if (fehrest == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = fehrest;
			}
			if (InsUpd.HasValue)
			{
				sqlCommand.Parameters[5].Value = InsUpd.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			if (shkodOUT.HasValue)
			{
				sqlCommand.Parameters[6].Value = shkodOUT.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			int result;
			try
			{
				result = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[6].Value == null || (object)sqlCommand.Parameters[6].Value.GetType() == typeof(DBNull))
			{
				shkodOUT = null;
			}
			else
			{
				shkodOUT = Conversions.ToDecimal(sqlCommand.Parameters[6].Value);
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int JamSanadMablagh(int? sanadnumber, bool? FactorOrPF, string fehname, int? salmali, double? Zaribbakhsh)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[20];
			if (sanadnumber.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnumber.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (FactorOrPF.HasValue)
			{
				sqlCommand.Parameters[2].Value = FactorOrPF.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (fehname == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = fehname;
			}
			if (salmali.HasValue)
			{
				sqlCommand.Parameters[4].Value = salmali.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			if (Zaribbakhsh.HasValue)
			{
				sqlCommand.Parameters[5].Value = Zaribbakhsh.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int ListTableRowCounts()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[21];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Load_Cmbo(string strField, string strTable, string strWhere)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[22];
			if (strField == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = strField;
			}
			if (strTable == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = strTable;
			}
			if (strWhere == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = strWhere;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int MablaghKoliSanad(int? sanadnum, bool? fopf, string salmali, string fehname, double? Zaribbakhsh)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[23];
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (fopf.HasValue)
			{
				sqlCommand.Parameters[2].Value = fopf.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (salmali == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = salmali;
			}
			if (fehname == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = fehname;
			}
			if (Zaribbakhsh.HasValue)
			{
				sqlCommand.Parameters[5].Value = Zaribbakhsh.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Mohasebe_Asnad4(decimal? sanadnum, bool? fopf, string Salmali, string fehname, double? Zaribbakhsh)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[24];
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (fopf.HasValue)
			{
				sqlCommand.Parameters[2].Value = fopf.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (Salmali == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = Salmali;
			}
			if (fehname == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = fehname;
			}
			if (Zaribbakhsh.HasValue)
			{
				sqlCommand.Parameters[5].Value = Zaribbakhsh.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int PaksaziAvarez()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[25];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int RecNumber_Asnad2(decimal? sanadnum, bool? fopf, string SalMali)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[26];
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (fopf.HasValue)
			{
				sqlCommand.Parameters[2].Value = fopf.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (SalMali == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = SalMali;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SanadKholase(int? sanadnumber, bool? FactorOrPF, string fehname, int? salmali, double? Zaribbakhsh)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[27];
			if (sanadnumber.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnumber.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (FactorOrPF.HasValue)
			{
				sqlCommand.Parameters[2].Value = FactorOrPF.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (fehname == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = fehname;
			}
			if (salmali.HasValue)
			{
				sqlCommand.Parameters[4].Value = salmali.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			if (Zaribbakhsh.HasValue)
			{
				sqlCommand.Parameters[5].Value = Zaribbakhsh.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SanadKholaseChap(int? sanadnumber, int? salmali)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[28];
			if (sanadnumber.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnumber.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (salmali.HasValue)
			{
				sqlCommand.Parameters[2].Value = salmali.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SanadKholaseIjad(int? sanadnumber, int? salmali)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[29];
			if (sanadnumber.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnumber.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (salmali.HasValue)
			{
				sqlCommand.Parameters[2].Value = salmali.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SanadSayerAghlam(int? sanadnum, bool? fopf, int? salmali)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[30];
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (fopf.HasValue)
			{
				sqlCommand.Parameters[2].Value = fopf.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (salmali.HasValue)
			{
				sqlCommand.Parameters[3].Value = salmali.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Search_Asnad(string sanadnum)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[31];
			if (sanadnum == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = sanadnum;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Select_Asnad3()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[32];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Select_Bakhsh()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[33];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Select_fehrest()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[34];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Select_Karfarma()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[35];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Select_MablaghSanad(string salmali, bool? fopf, decimal? sanadnum)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[36];
			if (salmali == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = salmali;
			}
			if (fopf.HasValue)
			{
				sqlCommand.Parameters[2].Value = fopf.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[3].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Select_Ostan()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[37];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Select_shahrha()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[38];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Select_YesNo()
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[39];
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SelectAsnad(string salmali, bool? forpf)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[40];
			if (salmali == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = salmali;
			}
			if (forpf.HasValue)
			{
				sqlCommand.Parameters[2].Value = forpf.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SelectSanad(string salmali, bool? forpf, decimal? sanadnum)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[41];
			if (salmali == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = salmali;
			}
			if (forpf.HasValue)
			{
				sqlCommand.Parameters[2].Value = forpf.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[3].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				return sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int? ArzeshAfzoode(string SanadNum, string Tarikh)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[42];
			if (SanadNum == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = SanadNum;
			}
			if (Tarikh == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = Tarikh;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			return (sqlCommand.Parameters[0].Value != null && (object)sqlCommand.Parameters[0].Value.GetType() != typeof(DBNull)) ? new int?(Conversions.ToInteger(sqlCommand.Parameters[0].Value)) : ((int?)null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual double? DarsadNahaeesanadBeKol(int? sanadnumber, bool? FactorOrPF, string fehname, int? salmali)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[43];
			if (sanadnumber.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnumber.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (FactorOrPF.HasValue)
			{
				sqlCommand.Parameters[2].Value = FactorOrPF.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (fehname == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = fehname;
			}
			if (salmali.HasValue)
			{
				sqlCommand.Parameters[4].Value = salmali.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			return (sqlCommand.Parameters[0].Value != null && (object)sqlCommand.Parameters[0].Value.GetType() != typeof(DBNull)) ? new double?(Conversions.ToDouble(sqlCommand.Parameters[0].Value)) : ((double?)null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual string DecryptPassword(string UPassword)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[44];
			if (UPassword == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = UPassword;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[0].Value == null || (object)sqlCommand.Parameters[0].Value.GetType() == typeof(DBNull))
			{
				return null;
			}
			return Conversions.ToString(sqlCommand.Parameters[0].Value);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual string DLE(string ShamsiDate)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[45];
			if (ShamsiDate == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = ShamsiDate;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[0].Value == null || (object)sqlCommand.Parameters[0].Value.GetType() == typeof(DBNull))
			{
				return null;
			}
			return Conversions.ToString(sqlCommand.Parameters[0].Value);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual string DLF(DateTime? MiladiDate)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[46];
			if (MiladiDate.HasValue)
			{
				sqlCommand.Parameters[1].Value = MiladiDate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[0].Value == null || (object)sqlCommand.Parameters[0].Value.GetType() == typeof(DBNull))
			{
				return null;
			}
			return Conversions.ToString(sqlCommand.Parameters[0].Value);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual string Formatint(long? Mi)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[47];
			if (Mi.HasValue)
			{
				sqlCommand.Parameters[1].Value = Mi.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[0].Value == null || (object)sqlCommand.Parameters[0].Value.GetType() == typeof(DBNull))
			{
				return null;
			}
			return Conversions.ToString(sqlCommand.Parameters[0].Value);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual long? MablaghItem(string ItemNum, string FehBaha)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[48];
			if (ItemNum == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = ItemNum;
			}
			if (FehBaha == null)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = FehBaha;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			return (sqlCommand.Parameters[0].Value != null && (object)sqlCommand.Parameters[0].Value.GetType() != typeof(DBNull)) ? new long?(Conversions.ToLong(sqlCommand.Parameters[0].Value)) : ((long?)null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual string NumToFarsiString(string str)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[49];
			if (str == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = str;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[0].Value == null || (object)sqlCommand.Parameters[0].Value.GetType() == typeof(DBNull))
			{
				return null;
			}
			return Conversions.ToString(sqlCommand.Parameters[0].Value);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int? RND(float? RNDS)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[50];
			if (RNDS.HasValue)
			{
				sqlCommand.Parameters[1].Value = RNDS.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			return (sqlCommand.Parameters[0].Value != null && (object)sqlCommand.Parameters[0].Value.GetType() != typeof(DBNull)) ? new int?(Conversions.ToInteger(sqlCommand.Parameters[0].Value)) : ((int?)null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual long? SanadMablagh(decimal? sanadnum)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[51];
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			return (sqlCommand.Parameters[0].Value != null && (object)sqlCommand.Parameters[0].Value.GetType() != typeof(DBNull)) ? new long?(Conversions.ToLong(sqlCommand.Parameters[0].Value)) : ((long?)null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual long? SanadMablagh2(decimal? sanadnum)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[52];
			if (sanadnum.HasValue)
			{
				sqlCommand.Parameters[1].Value = sanadnum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			return (sqlCommand.Parameters[0].Value != null && (object)sqlCommand.Parameters[0].Value.GetType() != typeof(DBNull)) ? new long?(Conversions.ToLong(sqlCommand.Parameters[0].Value)) : ((long?)null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual string strtostr2(string stringstart)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[53];
			if (stringstart == null)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = stringstart;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			if (sqlCommand.Parameters[0].Value == null || (object)sqlCommand.Parameters[0].Value.GetType() == typeof(DBNull))
			{
				return null;
			}
			return Conversions.ToString(sqlCommand.Parameters[0].Value);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual double? zaribTo1(double? zarib, bool? check, string fehname, string fasl)
		{
			SqlCommand sqlCommand = (SqlCommand)CommandCollection[54];
			if (zarib.HasValue)
			{
				sqlCommand.Parameters[1].Value = zarib.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			if (check.HasValue)
			{
				sqlCommand.Parameters[2].Value = check.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			if (fehname == null)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = fehname;
			}
			if (fasl == null)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = fasl;
			}
			ConnectionState state = sqlCommand.Connection.State;
			if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				sqlCommand.Connection.Open();
			}
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					sqlCommand.Connection.Close();
				}
			}
			return (sqlCommand.Parameters[0].Value != null && (object)sqlCommand.Parameters[0].Value.GetType() != typeof(DBNull)) ? new double?(Conversions.ToDouble(sqlCommand.Parameters[0].Value)) : ((double?)null);
		}
	}
}

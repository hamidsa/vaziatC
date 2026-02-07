#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha.GeoBahaDataSetTableAdapters
{
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapterManager")]
	public class TableAdapterManager : Component
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public enum UpdateOrderOption
		{
			InsertUpdateDelete,
			UpdateInsertDelete
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private class SelfReferenceComparer : IComparer<DataRow>
		{
			private DataRelation _relation;

			private int _childFirst;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal SelfReferenceComparer(DataRelation relation, bool childFirst)
			{
				_relation = relation;
				if (childFirst)
				{
					_childFirst = -1;
				}
				else
				{
					_childFirst = 1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private DataRow GetRoot(DataRow row, ref int distance)
			{
				Debug.Assert(row != null);
				DataRow result = row;
				distance = 0;
				IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
				dictionary[row] = row;
				DataRow parentRow = row.GetParentRow(_relation, DataRowVersion.Default);
				checked
				{
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						distance++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
					}
					if (distance == 0)
					{
						dictionary.Clear();
						dictionary[row] = row;
						parentRow = row.GetParentRow(_relation, DataRowVersion.Original);
						while (parentRow != null && !dictionary.ContainsKey(parentRow))
						{
							distance++;
							result = parentRow;
							dictionary[parentRow] = parentRow;
							parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
						}
					}
					return result;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Compare(DataRow row1, DataRow row2)
			{
				if (object.ReferenceEquals(row1, row2))
				{
					return 0;
				}
				if (row1 == null)
				{
					return -1;
				}
				if (row2 == null)
				{
					return 1;
				}
				int distance = 0;
				DataRow root = GetRoot(row1, ref distance);
				int distance2 = 0;
				DataRow root2 = GetRoot(row2, ref distance2);
				if (object.ReferenceEquals(root, root2))
				{
					return checked(_childFirst * distance.CompareTo(distance2));
				}
				Debug.Assert(root.Table != null && root2.Table != null);
				if (root.Table.Rows.IndexOf(root) < root2.Table.Rows.IndexOf(root2))
				{
					return -1;
				}
				return 1;
			}

			int IComparer<DataRow>.Compare(DataRow row1, DataRow row2)
			{
				//ILSpy generated this explicit interface implementation from .override directive in Compare
				return this.Compare(row1, row2);
			}
		}

		private UpdateOrderOption _updateOrder;

		private asnad1TableAdapter _asnad1TableAdapter;

		private asnad2TableAdapter _asnad2TableAdapter;

		private asnad4TableAdapter _asnad4TableAdapter;

		private AsnadAnavinTableAdapter _asnadAnavinTableAdapter;

		private DafaterVaBakhshhaTableAdapter _dafaterVaBakhshhaTableAdapter;

		private DELETE_asnad1TableAdapter _dELETE_asnad1TableAdapter;

		private DELETE_asnad2TableAdapter _dELETE_asnad2TableAdapter;

		private DELETE_asnad4TableAdapter _dELETE_asnad4TableAdapter;

		private DELETE_etkarfarTableAdapter _dELETE_etkarfarTableAdapter;

		private empty_fehrestBahaTableAdapter _empty_fehrestBahaTableAdapter;

		private etbakhshTableAdapter _etbakhshTableAdapter;

		private etkarfarTableAdapter _etkarfarTableAdapter;

		private etostanTableAdapter _etostanTableAdapter;

		private etprojTableAdapter _etprojTableAdapter;

		private etshahrTableAdapter _etshahrTableAdapter;

		private etvahedTableAdapter _etvahedTableAdapter;

		private Factor_aTableAdapter _factor_aTableAdapter;

		private Factor_bTableAdapter _factor_bTableAdapter;

		private Factors40401TableAdapter _factors40401TableAdapter;

		private FEH1268279393TableAdapter _fEH1268279393TableAdapter;

		private FEHBAHA1384TableAdapter _fEHBAHA1384TableAdapter;

		private FEHBAHA1387TableAdapter _fEHBAHA1387TableAdapter;

		private FEHBAHA1391TableAdapter _fEHBAHA1391TableAdapter;

		private FEHBAHA1393TableAdapter _fEHBAHA1393TableAdapter;

		private FEHBAHA1397TableAdapter _fEHBAHA1397TableAdapter;

		private FEHBAHA1399TableAdapter _fEHBAHA1399TableAdapter;

		private fehrestTableAdapter _fehrestTableAdapter;

		private FEHSond1397TableAdapter _fEHSond1397TableAdapter;

		private FosoolTableAdapter _fosoolTableAdapter;

		private GhalebTableAdapter _ghalebTableAdapter;

		private MatnNameTableAdapter _matnNameTableAdapter;

		private MoshakhasatTableAdapter _moshakhasatTableAdapter;

		private SarfaslTableAdapter _sarfaslTableAdapter;

		private ServerNameTableAdapter _serverNameTableAdapter;

		private SystemsTableAdapter _systemsTableAdapter;

		private Update_asnad1TableAdapter _update_asnad1TableAdapter;

		private Update_asnad2TableAdapter _update_asnad2TableAdapter;

		private Update_asnad4TableAdapter _update_asnad4TableAdapter;

		private yesnoTableAdapter _yesnoTableAdapter;

		private ZarayebTableAdapter _zarayebTableAdapter;

		private ZarayebBakhshnameTableAdapter _zarayebBakhshnameTableAdapter;

		private ZarayebMantagheTableAdapter _zarayebMantagheTableAdapter;

		private bool _backupDataSetBeforeUpdate;

		private IDbConnection _connection;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public UpdateOrderOption UpdateOrder
		{
			get
			{
				return _updateOrder;
			}
			set
			{
				_updateOrder = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public asnad1TableAdapter asnad1TableAdapter
		{
			get
			{
				return _asnad1TableAdapter;
			}
			set
			{
				_asnad1TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public asnad2TableAdapter asnad2TableAdapter
		{
			get
			{
				return _asnad2TableAdapter;
			}
			set
			{
				_asnad2TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public asnad4TableAdapter asnad4TableAdapter
		{
			get
			{
				return _asnad4TableAdapter;
			}
			set
			{
				_asnad4TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public AsnadAnavinTableAdapter AsnadAnavinTableAdapter
		{
			get
			{
				return _asnadAnavinTableAdapter;
			}
			set
			{
				_asnadAnavinTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public DafaterVaBakhshhaTableAdapter DafaterVaBakhshhaTableAdapter
		{
			get
			{
				return _dafaterVaBakhshhaTableAdapter;
			}
			set
			{
				_dafaterVaBakhshhaTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public DELETE_asnad1TableAdapter DELETE_asnad1TableAdapter
		{
			get
			{
				return _dELETE_asnad1TableAdapter;
			}
			set
			{
				_dELETE_asnad1TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public DELETE_asnad2TableAdapter DELETE_asnad2TableAdapter
		{
			get
			{
				return _dELETE_asnad2TableAdapter;
			}
			set
			{
				_dELETE_asnad2TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public DELETE_asnad4TableAdapter DELETE_asnad4TableAdapter
		{
			get
			{
				return _dELETE_asnad4TableAdapter;
			}
			set
			{
				_dELETE_asnad4TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public DELETE_etkarfarTableAdapter DELETE_etkarfarTableAdapter
		{
			get
			{
				return _dELETE_etkarfarTableAdapter;
			}
			set
			{
				_dELETE_etkarfarTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public empty_fehrestBahaTableAdapter empty_fehrestBahaTableAdapter
		{
			get
			{
				return _empty_fehrestBahaTableAdapter;
			}
			set
			{
				_empty_fehrestBahaTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public etbakhshTableAdapter etbakhshTableAdapter
		{
			get
			{
				return _etbakhshTableAdapter;
			}
			set
			{
				_etbakhshTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public etkarfarTableAdapter etkarfarTableAdapter
		{
			get
			{
				return _etkarfarTableAdapter;
			}
			set
			{
				_etkarfarTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public etostanTableAdapter etostanTableAdapter
		{
			get
			{
				return _etostanTableAdapter;
			}
			set
			{
				_etostanTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public etprojTableAdapter etprojTableAdapter
		{
			get
			{
				return _etprojTableAdapter;
			}
			set
			{
				_etprojTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public etshahrTableAdapter etshahrTableAdapter
		{
			get
			{
				return _etshahrTableAdapter;
			}
			set
			{
				_etshahrTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public etvahedTableAdapter etvahedTableAdapter
		{
			get
			{
				return _etvahedTableAdapter;
			}
			set
			{
				_etvahedTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public Factor_aTableAdapter Factor_aTableAdapter
		{
			get
			{
				return _factor_aTableAdapter;
			}
			set
			{
				_factor_aTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public Factor_bTableAdapter Factor_bTableAdapter
		{
			get
			{
				return _factor_bTableAdapter;
			}
			set
			{
				_factor_bTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public Factors40401TableAdapter Factors40401TableAdapter
		{
			get
			{
				return _factors40401TableAdapter;
			}
			set
			{
				_factors40401TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public FEH1268279393TableAdapter FEH1268279393TableAdapter
		{
			get
			{
				return _fEH1268279393TableAdapter;
			}
			set
			{
				_fEH1268279393TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public FEHBAHA1384TableAdapter FEHBAHA1384TableAdapter
		{
			get
			{
				return _fEHBAHA1384TableAdapter;
			}
			set
			{
				_fEHBAHA1384TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public FEHBAHA1387TableAdapter FEHBAHA1387TableAdapter
		{
			get
			{
				return _fEHBAHA1387TableAdapter;
			}
			set
			{
				_fEHBAHA1387TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public FEHBAHA1391TableAdapter FEHBAHA1391TableAdapter
		{
			get
			{
				return _fEHBAHA1391TableAdapter;
			}
			set
			{
				_fEHBAHA1391TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public FEHBAHA1393TableAdapter FEHBAHA1393TableAdapter
		{
			get
			{
				return _fEHBAHA1393TableAdapter;
			}
			set
			{
				_fEHBAHA1393TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public FEHBAHA1397TableAdapter FEHBAHA1397TableAdapter
		{
			get
			{
				return _fEHBAHA1397TableAdapter;
			}
			set
			{
				_fEHBAHA1397TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public FEHBAHA1399TableAdapter FEHBAHA1399TableAdapter
		{
			get
			{
				return _fEHBAHA1399TableAdapter;
			}
			set
			{
				_fEHBAHA1399TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public fehrestTableAdapter fehrestTableAdapter
		{
			get
			{
				return _fehrestTableAdapter;
			}
			set
			{
				_fehrestTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public FEHSond1397TableAdapter FEHSond1397TableAdapter
		{
			get
			{
				return _fEHSond1397TableAdapter;
			}
			set
			{
				_fEHSond1397TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public FosoolTableAdapter FosoolTableAdapter
		{
			get
			{
				return _fosoolTableAdapter;
			}
			set
			{
				_fosoolTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public GhalebTableAdapter GhalebTableAdapter
		{
			get
			{
				return _ghalebTableAdapter;
			}
			set
			{
				_ghalebTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public MatnNameTableAdapter MatnNameTableAdapter
		{
			get
			{
				return _matnNameTableAdapter;
			}
			set
			{
				_matnNameTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public MoshakhasatTableAdapter MoshakhasatTableAdapter
		{
			get
			{
				return _moshakhasatTableAdapter;
			}
			set
			{
				_moshakhasatTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public SarfaslTableAdapter SarfaslTableAdapter
		{
			get
			{
				return _sarfaslTableAdapter;
			}
			set
			{
				_sarfaslTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public ServerNameTableAdapter ServerNameTableAdapter
		{
			get
			{
				return _serverNameTableAdapter;
			}
			set
			{
				_serverNameTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public SystemsTableAdapter SystemsTableAdapter
		{
			get
			{
				return _systemsTableAdapter;
			}
			set
			{
				_systemsTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public Update_asnad1TableAdapter Update_asnad1TableAdapter
		{
			get
			{
				return _update_asnad1TableAdapter;
			}
			set
			{
				_update_asnad1TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public Update_asnad2TableAdapter Update_asnad2TableAdapter
		{
			get
			{
				return _update_asnad2TableAdapter;
			}
			set
			{
				_update_asnad2TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public Update_asnad4TableAdapter Update_asnad4TableAdapter
		{
			get
			{
				return _update_asnad4TableAdapter;
			}
			set
			{
				_update_asnad4TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public yesnoTableAdapter yesnoTableAdapter
		{
			get
			{
				return _yesnoTableAdapter;
			}
			set
			{
				_yesnoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public ZarayebTableAdapter ZarayebTableAdapter
		{
			get
			{
				return _zarayebTableAdapter;
			}
			set
			{
				_zarayebTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public ZarayebBakhshnameTableAdapter ZarayebBakhshnameTableAdapter
		{
			get
			{
				return _zarayebBakhshnameTableAdapter;
			}
			set
			{
				_zarayebBakhshnameTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public ZarayebMantagheTableAdapter ZarayebMantagheTableAdapter
		{
			get
			{
				return _zarayebMantagheTableAdapter;
			}
			set
			{
				_zarayebMantagheTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool BackupDataSetBeforeUpdate
		{
			get
			{
				return _backupDataSetBeforeUpdate;
			}
			set
			{
				_backupDataSetBeforeUpdate = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public IDbConnection Connection
		{
			get
			{
				if (_connection != null)
				{
					return _connection;
				}
				if (_asnad1TableAdapter != null && _asnad1TableAdapter.Connection != null)
				{
					return _asnad1TableAdapter.Connection;
				}
				if (_asnad2TableAdapter != null && _asnad2TableAdapter.Connection != null)
				{
					return _asnad2TableAdapter.Connection;
				}
				if (_asnad4TableAdapter != null && _asnad4TableAdapter.Connection != null)
				{
					return _asnad4TableAdapter.Connection;
				}
				if (_asnadAnavinTableAdapter != null && _asnadAnavinTableAdapter.Connection != null)
				{
					return _asnadAnavinTableAdapter.Connection;
				}
				if (_dafaterVaBakhshhaTableAdapter != null && _dafaterVaBakhshhaTableAdapter.Connection != null)
				{
					return _dafaterVaBakhshhaTableAdapter.Connection;
				}
				if (_dELETE_asnad1TableAdapter != null && _dELETE_asnad1TableAdapter.Connection != null)
				{
					return _dELETE_asnad1TableAdapter.Connection;
				}
				if (_dELETE_asnad2TableAdapter != null && _dELETE_asnad2TableAdapter.Connection != null)
				{
					return _dELETE_asnad2TableAdapter.Connection;
				}
				if (_dELETE_asnad4TableAdapter != null && _dELETE_asnad4TableAdapter.Connection != null)
				{
					return _dELETE_asnad4TableAdapter.Connection;
				}
				if (_dELETE_etkarfarTableAdapter != null && _dELETE_etkarfarTableAdapter.Connection != null)
				{
					return _dELETE_etkarfarTableAdapter.Connection;
				}
				if (_empty_fehrestBahaTableAdapter != null && _empty_fehrestBahaTableAdapter.Connection != null)
				{
					return _empty_fehrestBahaTableAdapter.Connection;
				}
				if (_etbakhshTableAdapter != null && _etbakhshTableAdapter.Connection != null)
				{
					return _etbakhshTableAdapter.Connection;
				}
				if (_etkarfarTableAdapter != null && _etkarfarTableAdapter.Connection != null)
				{
					return _etkarfarTableAdapter.Connection;
				}
				if (_etostanTableAdapter != null && _etostanTableAdapter.Connection != null)
				{
					return _etostanTableAdapter.Connection;
				}
				if (_etprojTableAdapter != null && _etprojTableAdapter.Connection != null)
				{
					return _etprojTableAdapter.Connection;
				}
				if (_etshahrTableAdapter != null && _etshahrTableAdapter.Connection != null)
				{
					return _etshahrTableAdapter.Connection;
				}
				if (_etvahedTableAdapter != null && _etvahedTableAdapter.Connection != null)
				{
					return _etvahedTableAdapter.Connection;
				}
				if (_factor_aTableAdapter != null && _factor_aTableAdapter.Connection != null)
				{
					return _factor_aTableAdapter.Connection;
				}
				if (_factor_bTableAdapter != null && _factor_bTableAdapter.Connection != null)
				{
					return _factor_bTableAdapter.Connection;
				}
				if (_factors40401TableAdapter != null && _factors40401TableAdapter.Connection != null)
				{
					return _factors40401TableAdapter.Connection;
				}
				if (_fEH1268279393TableAdapter != null && _fEH1268279393TableAdapter.Connection != null)
				{
					return _fEH1268279393TableAdapter.Connection;
				}
				if (_fEHBAHA1384TableAdapter != null && _fEHBAHA1384TableAdapter.Connection != null)
				{
					return _fEHBAHA1384TableAdapter.Connection;
				}
				if (_fEHBAHA1387TableAdapter != null && _fEHBAHA1387TableAdapter.Connection != null)
				{
					return _fEHBAHA1387TableAdapter.Connection;
				}
				if (_fEHBAHA1391TableAdapter != null && _fEHBAHA1391TableAdapter.Connection != null)
				{
					return _fEHBAHA1391TableAdapter.Connection;
				}
				if (_fEHBAHA1393TableAdapter != null && _fEHBAHA1393TableAdapter.Connection != null)
				{
					return _fEHBAHA1393TableAdapter.Connection;
				}
				if (_fEHBAHA1397TableAdapter != null && _fEHBAHA1397TableAdapter.Connection != null)
				{
					return _fEHBAHA1397TableAdapter.Connection;
				}
				if (_fEHBAHA1399TableAdapter != null && _fEHBAHA1399TableAdapter.Connection != null)
				{
					return _fEHBAHA1399TableAdapter.Connection;
				}
				if (_fehrestTableAdapter != null && _fehrestTableAdapter.Connection != null)
				{
					return _fehrestTableAdapter.Connection;
				}
				if (_fEHSond1397TableAdapter != null && _fEHSond1397TableAdapter.Connection != null)
				{
					return _fEHSond1397TableAdapter.Connection;
				}
				if (_fosoolTableAdapter != null && _fosoolTableAdapter.Connection != null)
				{
					return _fosoolTableAdapter.Connection;
				}
				if (_ghalebTableAdapter != null && _ghalebTableAdapter.Connection != null)
				{
					return _ghalebTableAdapter.Connection;
				}
				if (_matnNameTableAdapter != null && _matnNameTableAdapter.Connection != null)
				{
					return _matnNameTableAdapter.Connection;
				}
				if (_moshakhasatTableAdapter != null && _moshakhasatTableAdapter.Connection != null)
				{
					return _moshakhasatTableAdapter.Connection;
				}
				if (_sarfaslTableAdapter != null && _sarfaslTableAdapter.Connection != null)
				{
					return _sarfaslTableAdapter.Connection;
				}
				if (_serverNameTableAdapter != null && _serverNameTableAdapter.Connection != null)
				{
					return _serverNameTableAdapter.Connection;
				}
				if (_systemsTableAdapter != null && _systemsTableAdapter.Connection != null)
				{
					return _systemsTableAdapter.Connection;
				}
				if (_update_asnad1TableAdapter != null && _update_asnad1TableAdapter.Connection != null)
				{
					return _update_asnad1TableAdapter.Connection;
				}
				if (_update_asnad2TableAdapter != null && _update_asnad2TableAdapter.Connection != null)
				{
					return _update_asnad2TableAdapter.Connection;
				}
				if (_update_asnad4TableAdapter != null && _update_asnad4TableAdapter.Connection != null)
				{
					return _update_asnad4TableAdapter.Connection;
				}
				if (_yesnoTableAdapter != null && _yesnoTableAdapter.Connection != null)
				{
					return _yesnoTableAdapter.Connection;
				}
				if (_zarayebTableAdapter != null && _zarayebTableAdapter.Connection != null)
				{
					return _zarayebTableAdapter.Connection;
				}
				if (_zarayebBakhshnameTableAdapter != null && _zarayebBakhshnameTableAdapter.Connection != null)
				{
					return _zarayebBakhshnameTableAdapter.Connection;
				}
				if (_zarayebMantagheTableAdapter != null && _zarayebMantagheTableAdapter.Connection != null)
				{
					return _zarayebMantagheTableAdapter.Connection;
				}
				return null;
			}
			set
			{
				_connection = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int TableAdapterInstanceCount
		{
			get
			{
				int num = 0;
				checked
				{
					if (_asnad1TableAdapter != null)
					{
						num++;
					}
					if (_asnad2TableAdapter != null)
					{
						num++;
					}
					if (_asnad4TableAdapter != null)
					{
						num++;
					}
					if (_asnadAnavinTableAdapter != null)
					{
						num++;
					}
					if (_dafaterVaBakhshhaTableAdapter != null)
					{
						num++;
					}
					if (_dELETE_asnad1TableAdapter != null)
					{
						num++;
					}
					if (_dELETE_asnad2TableAdapter != null)
					{
						num++;
					}
					if (_dELETE_asnad4TableAdapter != null)
					{
						num++;
					}
					if (_dELETE_etkarfarTableAdapter != null)
					{
						num++;
					}
					if (_empty_fehrestBahaTableAdapter != null)
					{
						num++;
					}
					if (_etbakhshTableAdapter != null)
					{
						num++;
					}
					if (_etkarfarTableAdapter != null)
					{
						num++;
					}
					if (_etostanTableAdapter != null)
					{
						num++;
					}
					if (_etprojTableAdapter != null)
					{
						num++;
					}
					if (_etshahrTableAdapter != null)
					{
						num++;
					}
					if (_etvahedTableAdapter != null)
					{
						num++;
					}
					if (_factor_aTableAdapter != null)
					{
						num++;
					}
					if (_factor_bTableAdapter != null)
					{
						num++;
					}
					if (_factors40401TableAdapter != null)
					{
						num++;
					}
					if (_fEH1268279393TableAdapter != null)
					{
						num++;
					}
					if (_fEHBAHA1384TableAdapter != null)
					{
						num++;
					}
					if (_fEHBAHA1387TableAdapter != null)
					{
						num++;
					}
					if (_fEHBAHA1391TableAdapter != null)
					{
						num++;
					}
					if (_fEHBAHA1393TableAdapter != null)
					{
						num++;
					}
					if (_fEHBAHA1397TableAdapter != null)
					{
						num++;
					}
					if (_fEHBAHA1399TableAdapter != null)
					{
						num++;
					}
					if (_fehrestTableAdapter != null)
					{
						num++;
					}
					if (_fEHSond1397TableAdapter != null)
					{
						num++;
					}
					if (_fosoolTableAdapter != null)
					{
						num++;
					}
					if (_ghalebTableAdapter != null)
					{
						num++;
					}
					if (_matnNameTableAdapter != null)
					{
						num++;
					}
					if (_moshakhasatTableAdapter != null)
					{
						num++;
					}
					if (_sarfaslTableAdapter != null)
					{
						num++;
					}
					if (_serverNameTableAdapter != null)
					{
						num++;
					}
					if (_systemsTableAdapter != null)
					{
						num++;
					}
					if (_update_asnad1TableAdapter != null)
					{
						num++;
					}
					if (_update_asnad2TableAdapter != null)
					{
						num++;
					}
					if (_update_asnad4TableAdapter != null)
					{
						num++;
					}
					if (_yesnoTableAdapter != null)
					{
						num++;
					}
					if (_zarayebTableAdapter != null)
					{
						num++;
					}
					if (_zarayebBakhshnameTableAdapter != null)
					{
						num++;
					}
					if (_zarayebMantagheTableAdapter != null)
					{
						num++;
					}
					return num;
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateUpdatedRows(GeoBahaDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
		{
			int num = 0;
			checked
			{
				if (_update_asnad4TableAdapter != null)
				{
					DataRow[] updatedRows = dataSet.Update_asnad4.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows = GetRealUpdatedRows(updatedRows, allAddedRows);
					if (updatedRows != null && 0 < updatedRows.Length)
					{
						num += _update_asnad4TableAdapter.Update(updatedRows);
						allChangedRows.AddRange(updatedRows);
					}
				}
				if (_update_asnad2TableAdapter != null)
				{
					DataRow[] updatedRows2 = dataSet.Update_asnad2.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows2 = GetRealUpdatedRows(updatedRows2, allAddedRows);
					if (updatedRows2 != null && 0 < updatedRows2.Length)
					{
						num += _update_asnad2TableAdapter.Update(updatedRows2);
						allChangedRows.AddRange(updatedRows2);
					}
				}
				if (_update_asnad1TableAdapter != null)
				{
					DataRow[] updatedRows3 = dataSet.Update_asnad1.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows3 = GetRealUpdatedRows(updatedRows3, allAddedRows);
					if (updatedRows3 != null && 0 < updatedRows3.Length)
					{
						num += _update_asnad1TableAdapter.Update(updatedRows3);
						allChangedRows.AddRange(updatedRows3);
					}
				}
				if (_zarayebBakhshnameTableAdapter != null)
				{
					DataRow[] updatedRows4 = dataSet.ZarayebBakhshname.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows4 = GetRealUpdatedRows(updatedRows4, allAddedRows);
					if (updatedRows4 != null && 0 < updatedRows4.Length)
					{
						num += _zarayebBakhshnameTableAdapter.Update(updatedRows4);
						allChangedRows.AddRange(updatedRows4);
					}
				}
				if (_zarayebTableAdapter != null)
				{
					DataRow[] updatedRows5 = dataSet.Zarayeb.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows5 = GetRealUpdatedRows(updatedRows5, allAddedRows);
					if (updatedRows5 != null && 0 < updatedRows5.Length)
					{
						num += _zarayebTableAdapter.Update(updatedRows5);
						allChangedRows.AddRange(updatedRows5);
					}
				}
				if (_yesnoTableAdapter != null)
				{
					DataRow[] updatedRows6 = dataSet.yesno.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows6 = GetRealUpdatedRows(updatedRows6, allAddedRows);
					if (updatedRows6 != null && 0 < updatedRows6.Length)
					{
						num += _yesnoTableAdapter.Update(updatedRows6);
						allChangedRows.AddRange(updatedRows6);
					}
				}
				if (_systemsTableAdapter != null)
				{
					DataRow[] updatedRows7 = dataSet.Systems.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows7 = GetRealUpdatedRows(updatedRows7, allAddedRows);
					if (updatedRows7 != null && 0 < updatedRows7.Length)
					{
						num += _systemsTableAdapter.Update(updatedRows7);
						allChangedRows.AddRange(updatedRows7);
					}
				}
				if (_matnNameTableAdapter != null)
				{
					DataRow[] updatedRows8 = dataSet.MatnName.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows8 = GetRealUpdatedRows(updatedRows8, allAddedRows);
					if (updatedRows8 != null && 0 < updatedRows8.Length)
					{
						num += _matnNameTableAdapter.Update(updatedRows8);
						allChangedRows.AddRange(updatedRows8);
					}
				}
				if (_ghalebTableAdapter != null)
				{
					DataRow[] updatedRows9 = dataSet.Ghaleb.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows9 = GetRealUpdatedRows(updatedRows9, allAddedRows);
					if (updatedRows9 != null && 0 < updatedRows9.Length)
					{
						num += _ghalebTableAdapter.Update(updatedRows9);
						allChangedRows.AddRange(updatedRows9);
					}
				}
				if (_fosoolTableAdapter != null)
				{
					DataRow[] updatedRows10 = dataSet.Fosool.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows10 = GetRealUpdatedRows(updatedRows10, allAddedRows);
					if (updatedRows10 != null && 0 < updatedRows10.Length)
					{
						num += _fosoolTableAdapter.Update(updatedRows10);
						allChangedRows.AddRange(updatedRows10);
					}
				}
				if (_serverNameTableAdapter != null)
				{
					DataRow[] updatedRows11 = dataSet.ServerName.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows11 = GetRealUpdatedRows(updatedRows11, allAddedRows);
					if (updatedRows11 != null && 0 < updatedRows11.Length)
					{
						num += _serverNameTableAdapter.Update(updatedRows11);
						allChangedRows.AddRange(updatedRows11);
					}
				}
				if (_sarfaslTableAdapter != null)
				{
					DataRow[] updatedRows12 = dataSet.Sarfasl.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows12 = GetRealUpdatedRows(updatedRows12, allAddedRows);
					if (updatedRows12 != null && 0 < updatedRows12.Length)
					{
						num += _sarfaslTableAdapter.Update(updatedRows12);
						allChangedRows.AddRange(updatedRows12);
					}
				}
				if (_moshakhasatTableAdapter != null)
				{
					DataRow[] updatedRows13 = dataSet.Moshakhasat.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows13 = GetRealUpdatedRows(updatedRows13, allAddedRows);
					if (updatedRows13 != null && 0 < updatedRows13.Length)
					{
						num += _moshakhasatTableAdapter.Update(updatedRows13);
						allChangedRows.AddRange(updatedRows13);
					}
				}
				if (_zarayebMantagheTableAdapter != null)
				{
					DataRow[] updatedRows14 = dataSet.ZarayebMantaghe.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows14 = GetRealUpdatedRows(updatedRows14, allAddedRows);
					if (updatedRows14 != null && 0 < updatedRows14.Length)
					{
						num += _zarayebMantagheTableAdapter.Update(updatedRows14);
						allChangedRows.AddRange(updatedRows14);
					}
				}
				if (_fEHSond1397TableAdapter != null)
				{
					DataRow[] updatedRows15 = dataSet.FEHSond1397.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows15 = GetRealUpdatedRows(updatedRows15, allAddedRows);
					if (updatedRows15 != null && 0 < updatedRows15.Length)
					{
						num += _fEHSond1397TableAdapter.Update(updatedRows15);
						allChangedRows.AddRange(updatedRows15);
					}
				}
				if (_empty_fehrestBahaTableAdapter != null)
				{
					DataRow[] updatedRows16 = dataSet.empty_fehrestBaha.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows16 = GetRealUpdatedRows(updatedRows16, allAddedRows);
					if (updatedRows16 != null && 0 < updatedRows16.Length)
					{
						num += _empty_fehrestBahaTableAdapter.Update(updatedRows16);
						allChangedRows.AddRange(updatedRows16);
					}
				}
				if (_dELETE_etkarfarTableAdapter != null)
				{
					DataRow[] updatedRows17 = dataSet.DELETE_etkarfar.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows17 = GetRealUpdatedRows(updatedRows17, allAddedRows);
					if (updatedRows17 != null && 0 < updatedRows17.Length)
					{
						num += _dELETE_etkarfarTableAdapter.Update(updatedRows17);
						allChangedRows.AddRange(updatedRows17);
					}
				}
				if (_dELETE_asnad4TableAdapter != null)
				{
					DataRow[] updatedRows18 = dataSet.DELETE_asnad4.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows18 = GetRealUpdatedRows(updatedRows18, allAddedRows);
					if (updatedRows18 != null && 0 < updatedRows18.Length)
					{
						num += _dELETE_asnad4TableAdapter.Update(updatedRows18);
						allChangedRows.AddRange(updatedRows18);
					}
				}
				if (_etostanTableAdapter != null)
				{
					DataRow[] updatedRows19 = dataSet.etostan.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows19 = GetRealUpdatedRows(updatedRows19, allAddedRows);
					if (updatedRows19 != null && 0 < updatedRows19.Length)
					{
						num += _etostanTableAdapter.Update(updatedRows19);
						allChangedRows.AddRange(updatedRows19);
					}
				}
				if (_etkarfarTableAdapter != null)
				{
					DataRow[] updatedRows20 = dataSet.etkarfar.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows20 = GetRealUpdatedRows(updatedRows20, allAddedRows);
					if (updatedRows20 != null && 0 < updatedRows20.Length)
					{
						num += _etkarfarTableAdapter.Update(updatedRows20);
						allChangedRows.AddRange(updatedRows20);
					}
				}
				if (_etbakhshTableAdapter != null)
				{
					DataRow[] updatedRows21 = dataSet.etbakhsh.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows21 = GetRealUpdatedRows(updatedRows21, allAddedRows);
					if (updatedRows21 != null && 0 < updatedRows21.Length)
					{
						num += _etbakhshTableAdapter.Update(updatedRows21);
						allChangedRows.AddRange(updatedRows21);
					}
				}
				if (_dELETE_asnad2TableAdapter != null)
				{
					DataRow[] updatedRows22 = dataSet.DELETE_asnad2.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows22 = GetRealUpdatedRows(updatedRows22, allAddedRows);
					if (updatedRows22 != null && 0 < updatedRows22.Length)
					{
						num += _dELETE_asnad2TableAdapter.Update(updatedRows22);
						allChangedRows.AddRange(updatedRows22);
					}
				}
				if (_asnad4TableAdapter != null)
				{
					DataRow[] updatedRows23 = dataSet.asnad4.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows23 = GetRealUpdatedRows(updatedRows23, allAddedRows);
					if (updatedRows23 != null && 0 < updatedRows23.Length)
					{
						num += _asnad4TableAdapter.Update(updatedRows23);
						allChangedRows.AddRange(updatedRows23);
					}
				}
				if (_asnad2TableAdapter != null)
				{
					DataRow[] updatedRows24 = dataSet.asnad2.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows24 = GetRealUpdatedRows(updatedRows24, allAddedRows);
					if (updatedRows24 != null && 0 < updatedRows24.Length)
					{
						num += _asnad2TableAdapter.Update(updatedRows24);
						allChangedRows.AddRange(updatedRows24);
					}
				}
				if (_asnad1TableAdapter != null)
				{
					DataRow[] updatedRows25 = dataSet.asnad1.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows25 = GetRealUpdatedRows(updatedRows25, allAddedRows);
					if (updatedRows25 != null && 0 < updatedRows25.Length)
					{
						num += _asnad1TableAdapter.Update(updatedRows25);
						allChangedRows.AddRange(updatedRows25);
					}
				}
				if (_dELETE_asnad1TableAdapter != null)
				{
					DataRow[] updatedRows26 = dataSet.DELETE_asnad1.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows26 = GetRealUpdatedRows(updatedRows26, allAddedRows);
					if (updatedRows26 != null && 0 < updatedRows26.Length)
					{
						num += _dELETE_asnad1TableAdapter.Update(updatedRows26);
						allChangedRows.AddRange(updatedRows26);
					}
				}
				if (_dafaterVaBakhshhaTableAdapter != null)
				{
					DataRow[] updatedRows27 = dataSet.DafaterVaBakhshha.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows27 = GetRealUpdatedRows(updatedRows27, allAddedRows);
					if (updatedRows27 != null && 0 < updatedRows27.Length)
					{
						num += _dafaterVaBakhshhaTableAdapter.Update(updatedRows27);
						allChangedRows.AddRange(updatedRows27);
					}
				}
				if (_asnadAnavinTableAdapter != null)
				{
					DataRow[] updatedRows28 = dataSet.AsnadAnavin.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows28 = GetRealUpdatedRows(updatedRows28, allAddedRows);
					if (updatedRows28 != null && 0 < updatedRows28.Length)
					{
						num += _asnadAnavinTableAdapter.Update(updatedRows28);
						allChangedRows.AddRange(updatedRows28);
					}
				}
				if (_etprojTableAdapter != null)
				{
					DataRow[] updatedRows29 = dataSet.etproj.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows29 = GetRealUpdatedRows(updatedRows29, allAddedRows);
					if (updatedRows29 != null && 0 < updatedRows29.Length)
					{
						num += _etprojTableAdapter.Update(updatedRows29);
						allChangedRows.AddRange(updatedRows29);
					}
				}
				if (_fEHBAHA1393TableAdapter != null)
				{
					DataRow[] updatedRows30 = dataSet.FEHBAHA1393.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows30 = GetRealUpdatedRows(updatedRows30, allAddedRows);
					if (updatedRows30 != null && 0 < updatedRows30.Length)
					{
						num += _fEHBAHA1393TableAdapter.Update(updatedRows30);
						allChangedRows.AddRange(updatedRows30);
					}
				}
				if (_fEHBAHA1391TableAdapter != null)
				{
					DataRow[] updatedRows31 = dataSet.FEHBAHA1391.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows31 = GetRealUpdatedRows(updatedRows31, allAddedRows);
					if (updatedRows31 != null && 0 < updatedRows31.Length)
					{
						num += _fEHBAHA1391TableAdapter.Update(updatedRows31);
						allChangedRows.AddRange(updatedRows31);
					}
				}
				if (_fEHBAHA1387TableAdapter != null)
				{
					DataRow[] updatedRows32 = dataSet.FEHBAHA1387.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows32 = GetRealUpdatedRows(updatedRows32, allAddedRows);
					if (updatedRows32 != null && 0 < updatedRows32.Length)
					{
						num += _fEHBAHA1387TableAdapter.Update(updatedRows32);
						allChangedRows.AddRange(updatedRows32);
					}
				}
				if (_fehrestTableAdapter != null)
				{
					DataRow[] updatedRows33 = dataSet.fehrest.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows33 = GetRealUpdatedRows(updatedRows33, allAddedRows);
					if (updatedRows33 != null && 0 < updatedRows33.Length)
					{
						num += _fehrestTableAdapter.Update(updatedRows33);
						allChangedRows.AddRange(updatedRows33);
					}
				}
				if (_fEHBAHA1399TableAdapter != null)
				{
					DataRow[] updatedRows34 = dataSet.FEHBAHA1399.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows34 = GetRealUpdatedRows(updatedRows34, allAddedRows);
					if (updatedRows34 != null && 0 < updatedRows34.Length)
					{
						num += _fEHBAHA1399TableAdapter.Update(updatedRows34);
						allChangedRows.AddRange(updatedRows34);
					}
				}
				if (_fEHBAHA1397TableAdapter != null)
				{
					DataRow[] updatedRows35 = dataSet.FEHBAHA1397.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows35 = GetRealUpdatedRows(updatedRows35, allAddedRows);
					if (updatedRows35 != null && 0 < updatedRows35.Length)
					{
						num += _fEHBAHA1397TableAdapter.Update(updatedRows35);
						allChangedRows.AddRange(updatedRows35);
					}
				}
				if (_fEHBAHA1384TableAdapter != null)
				{
					DataRow[] updatedRows36 = dataSet.FEHBAHA1384.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows36 = GetRealUpdatedRows(updatedRows36, allAddedRows);
					if (updatedRows36 != null && 0 < updatedRows36.Length)
					{
						num += _fEHBAHA1384TableAdapter.Update(updatedRows36);
						allChangedRows.AddRange(updatedRows36);
					}
				}
				if (_factor_aTableAdapter != null)
				{
					DataRow[] updatedRows37 = dataSet.Factor_a.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows37 = GetRealUpdatedRows(updatedRows37, allAddedRows);
					if (updatedRows37 != null && 0 < updatedRows37.Length)
					{
						num += _factor_aTableAdapter.Update(updatedRows37);
						allChangedRows.AddRange(updatedRows37);
					}
				}
				if (_etvahedTableAdapter != null)
				{
					DataRow[] updatedRows38 = dataSet.etvahed.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows38 = GetRealUpdatedRows(updatedRows38, allAddedRows);
					if (updatedRows38 != null && 0 < updatedRows38.Length)
					{
						num += _etvahedTableAdapter.Update(updatedRows38);
						allChangedRows.AddRange(updatedRows38);
					}
				}
				if (_etshahrTableAdapter != null)
				{
					DataRow[] updatedRows39 = dataSet.etshahr.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows39 = GetRealUpdatedRows(updatedRows39, allAddedRows);
					if (updatedRows39 != null && 0 < updatedRows39.Length)
					{
						num += _etshahrTableAdapter.Update(updatedRows39);
						allChangedRows.AddRange(updatedRows39);
					}
				}
				if (_fEH1268279393TableAdapter != null)
				{
					DataRow[] updatedRows40 = dataSet.FEH1268279393.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows40 = GetRealUpdatedRows(updatedRows40, allAddedRows);
					if (updatedRows40 != null && 0 < updatedRows40.Length)
					{
						num += _fEH1268279393TableAdapter.Update(updatedRows40);
						allChangedRows.AddRange(updatedRows40);
					}
				}
				if (_factors40401TableAdapter != null)
				{
					DataRow[] updatedRows41 = dataSet.Factors40401.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows41 = GetRealUpdatedRows(updatedRows41, allAddedRows);
					if (updatedRows41 != null && 0 < updatedRows41.Length)
					{
						num += _factors40401TableAdapter.Update(updatedRows41);
						allChangedRows.AddRange(updatedRows41);
					}
				}
				if (_factor_bTableAdapter != null)
				{
					DataRow[] updatedRows42 = dataSet.Factor_b.Select(null, null, DataViewRowState.ModifiedCurrent);
					updatedRows42 = GetRealUpdatedRows(updatedRows42, allAddedRows);
					if (updatedRows42 != null && 0 < updatedRows42.Length)
					{
						num += _factor_bTableAdapter.Update(updatedRows42);
						allChangedRows.AddRange(updatedRows42);
					}
				}
				return num;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateInsertedRows(GeoBahaDataSet dataSet, List<DataRow> allAddedRows)
		{
			int num = 0;
			checked
			{
				if (_update_asnad4TableAdapter != null)
				{
					DataRow[] array = dataSet.Update_asnad4.Select(null, null, DataViewRowState.Added);
					if (array != null && 0 < array.Length)
					{
						num += _update_asnad4TableAdapter.Update(array);
						allAddedRows.AddRange(array);
					}
				}
				if (_update_asnad2TableAdapter != null)
				{
					DataRow[] array2 = dataSet.Update_asnad2.Select(null, null, DataViewRowState.Added);
					if (array2 != null && 0 < array2.Length)
					{
						num += _update_asnad2TableAdapter.Update(array2);
						allAddedRows.AddRange(array2);
					}
				}
				if (_update_asnad1TableAdapter != null)
				{
					DataRow[] array3 = dataSet.Update_asnad1.Select(null, null, DataViewRowState.Added);
					if (array3 != null && 0 < array3.Length)
					{
						num += _update_asnad1TableAdapter.Update(array3);
						allAddedRows.AddRange(array3);
					}
				}
				if (_zarayebBakhshnameTableAdapter != null)
				{
					DataRow[] array4 = dataSet.ZarayebBakhshname.Select(null, null, DataViewRowState.Added);
					if (array4 != null && 0 < array4.Length)
					{
						num += _zarayebBakhshnameTableAdapter.Update(array4);
						allAddedRows.AddRange(array4);
					}
				}
				if (_zarayebTableAdapter != null)
				{
					DataRow[] array5 = dataSet.Zarayeb.Select(null, null, DataViewRowState.Added);
					if (array5 != null && 0 < array5.Length)
					{
						num += _zarayebTableAdapter.Update(array5);
						allAddedRows.AddRange(array5);
					}
				}
				if (_yesnoTableAdapter != null)
				{
					DataRow[] array6 = dataSet.yesno.Select(null, null, DataViewRowState.Added);
					if (array6 != null && 0 < array6.Length)
					{
						num += _yesnoTableAdapter.Update(array6);
						allAddedRows.AddRange(array6);
					}
				}
				if (_systemsTableAdapter != null)
				{
					DataRow[] array7 = dataSet.Systems.Select(null, null, DataViewRowState.Added);
					if (array7 != null && 0 < array7.Length)
					{
						num += _systemsTableAdapter.Update(array7);
						allAddedRows.AddRange(array7);
					}
				}
				if (_matnNameTableAdapter != null)
				{
					DataRow[] array8 = dataSet.MatnName.Select(null, null, DataViewRowState.Added);
					if (array8 != null && 0 < array8.Length)
					{
						num += _matnNameTableAdapter.Update(array8);
						allAddedRows.AddRange(array8);
					}
				}
				if (_ghalebTableAdapter != null)
				{
					DataRow[] array9 = dataSet.Ghaleb.Select(null, null, DataViewRowState.Added);
					if (array9 != null && 0 < array9.Length)
					{
						num += _ghalebTableAdapter.Update(array9);
						allAddedRows.AddRange(array9);
					}
				}
				if (_fosoolTableAdapter != null)
				{
					DataRow[] array10 = dataSet.Fosool.Select(null, null, DataViewRowState.Added);
					if (array10 != null && 0 < array10.Length)
					{
						num += _fosoolTableAdapter.Update(array10);
						allAddedRows.AddRange(array10);
					}
				}
				if (_serverNameTableAdapter != null)
				{
					DataRow[] array11 = dataSet.ServerName.Select(null, null, DataViewRowState.Added);
					if (array11 != null && 0 < array11.Length)
					{
						num += _serverNameTableAdapter.Update(array11);
						allAddedRows.AddRange(array11);
					}
				}
				if (_sarfaslTableAdapter != null)
				{
					DataRow[] array12 = dataSet.Sarfasl.Select(null, null, DataViewRowState.Added);
					if (array12 != null && 0 < array12.Length)
					{
						num += _sarfaslTableAdapter.Update(array12);
						allAddedRows.AddRange(array12);
					}
				}
				if (_moshakhasatTableAdapter != null)
				{
					DataRow[] array13 = dataSet.Moshakhasat.Select(null, null, DataViewRowState.Added);
					if (array13 != null && 0 < array13.Length)
					{
						num += _moshakhasatTableAdapter.Update(array13);
						allAddedRows.AddRange(array13);
					}
				}
				if (_zarayebMantagheTableAdapter != null)
				{
					DataRow[] array14 = dataSet.ZarayebMantaghe.Select(null, null, DataViewRowState.Added);
					if (array14 != null && 0 < array14.Length)
					{
						num += _zarayebMantagheTableAdapter.Update(array14);
						allAddedRows.AddRange(array14);
					}
				}
				if (_fEHSond1397TableAdapter != null)
				{
					DataRow[] array15 = dataSet.FEHSond1397.Select(null, null, DataViewRowState.Added);
					if (array15 != null && 0 < array15.Length)
					{
						num += _fEHSond1397TableAdapter.Update(array15);
						allAddedRows.AddRange(array15);
					}
				}
				if (_empty_fehrestBahaTableAdapter != null)
				{
					DataRow[] array16 = dataSet.empty_fehrestBaha.Select(null, null, DataViewRowState.Added);
					if (array16 != null && 0 < array16.Length)
					{
						num += _empty_fehrestBahaTableAdapter.Update(array16);
						allAddedRows.AddRange(array16);
					}
				}
				if (_dELETE_etkarfarTableAdapter != null)
				{
					DataRow[] array17 = dataSet.DELETE_etkarfar.Select(null, null, DataViewRowState.Added);
					if (array17 != null && 0 < array17.Length)
					{
						num += _dELETE_etkarfarTableAdapter.Update(array17);
						allAddedRows.AddRange(array17);
					}
				}
				if (_dELETE_asnad4TableAdapter != null)
				{
					DataRow[] array18 = dataSet.DELETE_asnad4.Select(null, null, DataViewRowState.Added);
					if (array18 != null && 0 < array18.Length)
					{
						num += _dELETE_asnad4TableAdapter.Update(array18);
						allAddedRows.AddRange(array18);
					}
				}
				if (_etostanTableAdapter != null)
				{
					DataRow[] array19 = dataSet.etostan.Select(null, null, DataViewRowState.Added);
					if (array19 != null && 0 < array19.Length)
					{
						num += _etostanTableAdapter.Update(array19);
						allAddedRows.AddRange(array19);
					}
				}
				if (_etkarfarTableAdapter != null)
				{
					DataRow[] array20 = dataSet.etkarfar.Select(null, null, DataViewRowState.Added);
					if (array20 != null && 0 < array20.Length)
					{
						num += _etkarfarTableAdapter.Update(array20);
						allAddedRows.AddRange(array20);
					}
				}
				if (_etbakhshTableAdapter != null)
				{
					DataRow[] array21 = dataSet.etbakhsh.Select(null, null, DataViewRowState.Added);
					if (array21 != null && 0 < array21.Length)
					{
						num += _etbakhshTableAdapter.Update(array21);
						allAddedRows.AddRange(array21);
					}
				}
				if (_dELETE_asnad2TableAdapter != null)
				{
					DataRow[] array22 = dataSet.DELETE_asnad2.Select(null, null, DataViewRowState.Added);
					if (array22 != null && 0 < array22.Length)
					{
						num += _dELETE_asnad2TableAdapter.Update(array22);
						allAddedRows.AddRange(array22);
					}
				}
				if (_asnad4TableAdapter != null)
				{
					DataRow[] array23 = dataSet.asnad4.Select(null, null, DataViewRowState.Added);
					if (array23 != null && 0 < array23.Length)
					{
						num += _asnad4TableAdapter.Update(array23);
						allAddedRows.AddRange(array23);
					}
				}
				if (_asnad2TableAdapter != null)
				{
					DataRow[] array24 = dataSet.asnad2.Select(null, null, DataViewRowState.Added);
					if (array24 != null && 0 < array24.Length)
					{
						num += _asnad2TableAdapter.Update(array24);
						allAddedRows.AddRange(array24);
					}
				}
				if (_asnad1TableAdapter != null)
				{
					DataRow[] array25 = dataSet.asnad1.Select(null, null, DataViewRowState.Added);
					if (array25 != null && 0 < array25.Length)
					{
						num += _asnad1TableAdapter.Update(array25);
						allAddedRows.AddRange(array25);
					}
				}
				if (_dELETE_asnad1TableAdapter != null)
				{
					DataRow[] array26 = dataSet.DELETE_asnad1.Select(null, null, DataViewRowState.Added);
					if (array26 != null && 0 < array26.Length)
					{
						num += _dELETE_asnad1TableAdapter.Update(array26);
						allAddedRows.AddRange(array26);
					}
				}
				if (_dafaterVaBakhshhaTableAdapter != null)
				{
					DataRow[] array27 = dataSet.DafaterVaBakhshha.Select(null, null, DataViewRowState.Added);
					if (array27 != null && 0 < array27.Length)
					{
						num += _dafaterVaBakhshhaTableAdapter.Update(array27);
						allAddedRows.AddRange(array27);
					}
				}
				if (_asnadAnavinTableAdapter != null)
				{
					DataRow[] array28 = dataSet.AsnadAnavin.Select(null, null, DataViewRowState.Added);
					if (array28 != null && 0 < array28.Length)
					{
						num += _asnadAnavinTableAdapter.Update(array28);
						allAddedRows.AddRange(array28);
					}
				}
				if (_etprojTableAdapter != null)
				{
					DataRow[] array29 = dataSet.etproj.Select(null, null, DataViewRowState.Added);
					if (array29 != null && 0 < array29.Length)
					{
						num += _etprojTableAdapter.Update(array29);
						allAddedRows.AddRange(array29);
					}
				}
				if (_fEHBAHA1393TableAdapter != null)
				{
					DataRow[] array30 = dataSet.FEHBAHA1393.Select(null, null, DataViewRowState.Added);
					if (array30 != null && 0 < array30.Length)
					{
						num += _fEHBAHA1393TableAdapter.Update(array30);
						allAddedRows.AddRange(array30);
					}
				}
				if (_fEHBAHA1391TableAdapter != null)
				{
					DataRow[] array31 = dataSet.FEHBAHA1391.Select(null, null, DataViewRowState.Added);
					if (array31 != null && 0 < array31.Length)
					{
						num += _fEHBAHA1391TableAdapter.Update(array31);
						allAddedRows.AddRange(array31);
					}
				}
				if (_fEHBAHA1387TableAdapter != null)
				{
					DataRow[] array32 = dataSet.FEHBAHA1387.Select(null, null, DataViewRowState.Added);
					if (array32 != null && 0 < array32.Length)
					{
						num += _fEHBAHA1387TableAdapter.Update(array32);
						allAddedRows.AddRange(array32);
					}
				}
				if (_fehrestTableAdapter != null)
				{
					DataRow[] array33 = dataSet.fehrest.Select(null, null, DataViewRowState.Added);
					if (array33 != null && 0 < array33.Length)
					{
						num += _fehrestTableAdapter.Update(array33);
						allAddedRows.AddRange(array33);
					}
				}
				if (_fEHBAHA1399TableAdapter != null)
				{
					DataRow[] array34 = dataSet.FEHBAHA1399.Select(null, null, DataViewRowState.Added);
					if (array34 != null && 0 < array34.Length)
					{
						num += _fEHBAHA1399TableAdapter.Update(array34);
						allAddedRows.AddRange(array34);
					}
				}
				if (_fEHBAHA1397TableAdapter != null)
				{
					DataRow[] array35 = dataSet.FEHBAHA1397.Select(null, null, DataViewRowState.Added);
					if (array35 != null && 0 < array35.Length)
					{
						num += _fEHBAHA1397TableAdapter.Update(array35);
						allAddedRows.AddRange(array35);
					}
				}
				if (_fEHBAHA1384TableAdapter != null)
				{
					DataRow[] array36 = dataSet.FEHBAHA1384.Select(null, null, DataViewRowState.Added);
					if (array36 != null && 0 < array36.Length)
					{
						num += _fEHBAHA1384TableAdapter.Update(array36);
						allAddedRows.AddRange(array36);
					}
				}
				if (_factor_aTableAdapter != null)
				{
					DataRow[] array37 = dataSet.Factor_a.Select(null, null, DataViewRowState.Added);
					if (array37 != null && 0 < array37.Length)
					{
						num += _factor_aTableAdapter.Update(array37);
						allAddedRows.AddRange(array37);
					}
				}
				if (_etvahedTableAdapter != null)
				{
					DataRow[] array38 = dataSet.etvahed.Select(null, null, DataViewRowState.Added);
					if (array38 != null && 0 < array38.Length)
					{
						num += _etvahedTableAdapter.Update(array38);
						allAddedRows.AddRange(array38);
					}
				}
				if (_etshahrTableAdapter != null)
				{
					DataRow[] array39 = dataSet.etshahr.Select(null, null, DataViewRowState.Added);
					if (array39 != null && 0 < array39.Length)
					{
						num += _etshahrTableAdapter.Update(array39);
						allAddedRows.AddRange(array39);
					}
				}
				if (_fEH1268279393TableAdapter != null)
				{
					DataRow[] array40 = dataSet.FEH1268279393.Select(null, null, DataViewRowState.Added);
					if (array40 != null && 0 < array40.Length)
					{
						num += _fEH1268279393TableAdapter.Update(array40);
						allAddedRows.AddRange(array40);
					}
				}
				if (_factors40401TableAdapter != null)
				{
					DataRow[] array41 = dataSet.Factors40401.Select(null, null, DataViewRowState.Added);
					if (array41 != null && 0 < array41.Length)
					{
						num += _factors40401TableAdapter.Update(array41);
						allAddedRows.AddRange(array41);
					}
				}
				if (_factor_bTableAdapter != null)
				{
					DataRow[] array42 = dataSet.Factor_b.Select(null, null, DataViewRowState.Added);
					if (array42 != null && 0 < array42.Length)
					{
						num += _factor_bTableAdapter.Update(array42);
						allAddedRows.AddRange(array42);
					}
				}
				return num;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateDeletedRows(GeoBahaDataSet dataSet, List<DataRow> allChangedRows)
		{
			int num = 0;
			checked
			{
				if (_factor_bTableAdapter != null)
				{
					DataRow[] array = dataSet.Factor_b.Select(null, null, DataViewRowState.Deleted);
					if (array != null && 0 < array.Length)
					{
						num += _factor_bTableAdapter.Update(array);
						allChangedRows.AddRange(array);
					}
				}
				if (_factors40401TableAdapter != null)
				{
					DataRow[] array2 = dataSet.Factors40401.Select(null, null, DataViewRowState.Deleted);
					if (array2 != null && 0 < array2.Length)
					{
						num += _factors40401TableAdapter.Update(array2);
						allChangedRows.AddRange(array2);
					}
				}
				if (_fEH1268279393TableAdapter != null)
				{
					DataRow[] array3 = dataSet.FEH1268279393.Select(null, null, DataViewRowState.Deleted);
					if (array3 != null && 0 < array3.Length)
					{
						num += _fEH1268279393TableAdapter.Update(array3);
						allChangedRows.AddRange(array3);
					}
				}
				if (_etshahrTableAdapter != null)
				{
					DataRow[] array4 = dataSet.etshahr.Select(null, null, DataViewRowState.Deleted);
					if (array4 != null && 0 < array4.Length)
					{
						num += _etshahrTableAdapter.Update(array4);
						allChangedRows.AddRange(array4);
					}
				}
				if (_etvahedTableAdapter != null)
				{
					DataRow[] array5 = dataSet.etvahed.Select(null, null, DataViewRowState.Deleted);
					if (array5 != null && 0 < array5.Length)
					{
						num += _etvahedTableAdapter.Update(array5);
						allChangedRows.AddRange(array5);
					}
				}
				if (_factor_aTableAdapter != null)
				{
					DataRow[] array6 = dataSet.Factor_a.Select(null, null, DataViewRowState.Deleted);
					if (array6 != null && 0 < array6.Length)
					{
						num += _factor_aTableAdapter.Update(array6);
						allChangedRows.AddRange(array6);
					}
				}
				if (_fEHBAHA1384TableAdapter != null)
				{
					DataRow[] array7 = dataSet.FEHBAHA1384.Select(null, null, DataViewRowState.Deleted);
					if (array7 != null && 0 < array7.Length)
					{
						num += _fEHBAHA1384TableAdapter.Update(array7);
						allChangedRows.AddRange(array7);
					}
				}
				if (_fEHBAHA1397TableAdapter != null)
				{
					DataRow[] array8 = dataSet.FEHBAHA1397.Select(null, null, DataViewRowState.Deleted);
					if (array8 != null && 0 < array8.Length)
					{
						num += _fEHBAHA1397TableAdapter.Update(array8);
						allChangedRows.AddRange(array8);
					}
				}
				if (_fEHBAHA1399TableAdapter != null)
				{
					DataRow[] array9 = dataSet.FEHBAHA1399.Select(null, null, DataViewRowState.Deleted);
					if (array9 != null && 0 < array9.Length)
					{
						num += _fEHBAHA1399TableAdapter.Update(array9);
						allChangedRows.AddRange(array9);
					}
				}
				if (_fehrestTableAdapter != null)
				{
					DataRow[] array10 = dataSet.fehrest.Select(null, null, DataViewRowState.Deleted);
					if (array10 != null && 0 < array10.Length)
					{
						num += _fehrestTableAdapter.Update(array10);
						allChangedRows.AddRange(array10);
					}
				}
				if (_fEHBAHA1387TableAdapter != null)
				{
					DataRow[] array11 = dataSet.FEHBAHA1387.Select(null, null, DataViewRowState.Deleted);
					if (array11 != null && 0 < array11.Length)
					{
						num += _fEHBAHA1387TableAdapter.Update(array11);
						allChangedRows.AddRange(array11);
					}
				}
				if (_fEHBAHA1391TableAdapter != null)
				{
					DataRow[] array12 = dataSet.FEHBAHA1391.Select(null, null, DataViewRowState.Deleted);
					if (array12 != null && 0 < array12.Length)
					{
						num += _fEHBAHA1391TableAdapter.Update(array12);
						allChangedRows.AddRange(array12);
					}
				}
				if (_fEHBAHA1393TableAdapter != null)
				{
					DataRow[] array13 = dataSet.FEHBAHA1393.Select(null, null, DataViewRowState.Deleted);
					if (array13 != null && 0 < array13.Length)
					{
						num += _fEHBAHA1393TableAdapter.Update(array13);
						allChangedRows.AddRange(array13);
					}
				}
				if (_etprojTableAdapter != null)
				{
					DataRow[] array14 = dataSet.etproj.Select(null, null, DataViewRowState.Deleted);
					if (array14 != null && 0 < array14.Length)
					{
						num += _etprojTableAdapter.Update(array14);
						allChangedRows.AddRange(array14);
					}
				}
				if (_asnadAnavinTableAdapter != null)
				{
					DataRow[] array15 = dataSet.AsnadAnavin.Select(null, null, DataViewRowState.Deleted);
					if (array15 != null && 0 < array15.Length)
					{
						num += _asnadAnavinTableAdapter.Update(array15);
						allChangedRows.AddRange(array15);
					}
				}
				if (_dafaterVaBakhshhaTableAdapter != null)
				{
					DataRow[] array16 = dataSet.DafaterVaBakhshha.Select(null, null, DataViewRowState.Deleted);
					if (array16 != null && 0 < array16.Length)
					{
						num += _dafaterVaBakhshhaTableAdapter.Update(array16);
						allChangedRows.AddRange(array16);
					}
				}
				if (_dELETE_asnad1TableAdapter != null)
				{
					DataRow[] array17 = dataSet.DELETE_asnad1.Select(null, null, DataViewRowState.Deleted);
					if (array17 != null && 0 < array17.Length)
					{
						num += _dELETE_asnad1TableAdapter.Update(array17);
						allChangedRows.AddRange(array17);
					}
				}
				if (_asnad1TableAdapter != null)
				{
					DataRow[] array18 = dataSet.asnad1.Select(null, null, DataViewRowState.Deleted);
					if (array18 != null && 0 < array18.Length)
					{
						num += _asnad1TableAdapter.Update(array18);
						allChangedRows.AddRange(array18);
					}
				}
				if (_asnad2TableAdapter != null)
				{
					DataRow[] array19 = dataSet.asnad2.Select(null, null, DataViewRowState.Deleted);
					if (array19 != null && 0 < array19.Length)
					{
						num += _asnad2TableAdapter.Update(array19);
						allChangedRows.AddRange(array19);
					}
				}
				if (_asnad4TableAdapter != null)
				{
					DataRow[] array20 = dataSet.asnad4.Select(null, null, DataViewRowState.Deleted);
					if (array20 != null && 0 < array20.Length)
					{
						num += _asnad4TableAdapter.Update(array20);
						allChangedRows.AddRange(array20);
					}
				}
				if (_dELETE_asnad2TableAdapter != null)
				{
					DataRow[] array21 = dataSet.DELETE_asnad2.Select(null, null, DataViewRowState.Deleted);
					if (array21 != null && 0 < array21.Length)
					{
						num += _dELETE_asnad2TableAdapter.Update(array21);
						allChangedRows.AddRange(array21);
					}
				}
				if (_etbakhshTableAdapter != null)
				{
					DataRow[] array22 = dataSet.etbakhsh.Select(null, null, DataViewRowState.Deleted);
					if (array22 != null && 0 < array22.Length)
					{
						num += _etbakhshTableAdapter.Update(array22);
						allChangedRows.AddRange(array22);
					}
				}
				if (_etkarfarTableAdapter != null)
				{
					DataRow[] array23 = dataSet.etkarfar.Select(null, null, DataViewRowState.Deleted);
					if (array23 != null && 0 < array23.Length)
					{
						num += _etkarfarTableAdapter.Update(array23);
						allChangedRows.AddRange(array23);
					}
				}
				if (_etostanTableAdapter != null)
				{
					DataRow[] array24 = dataSet.etostan.Select(null, null, DataViewRowState.Deleted);
					if (array24 != null && 0 < array24.Length)
					{
						num += _etostanTableAdapter.Update(array24);
						allChangedRows.AddRange(array24);
					}
				}
				if (_dELETE_asnad4TableAdapter != null)
				{
					DataRow[] array25 = dataSet.DELETE_asnad4.Select(null, null, DataViewRowState.Deleted);
					if (array25 != null && 0 < array25.Length)
					{
						num += _dELETE_asnad4TableAdapter.Update(array25);
						allChangedRows.AddRange(array25);
					}
				}
				if (_dELETE_etkarfarTableAdapter != null)
				{
					DataRow[] array26 = dataSet.DELETE_etkarfar.Select(null, null, DataViewRowState.Deleted);
					if (array26 != null && 0 < array26.Length)
					{
						num += _dELETE_etkarfarTableAdapter.Update(array26);
						allChangedRows.AddRange(array26);
					}
				}
				if (_empty_fehrestBahaTableAdapter != null)
				{
					DataRow[] array27 = dataSet.empty_fehrestBaha.Select(null, null, DataViewRowState.Deleted);
					if (array27 != null && 0 < array27.Length)
					{
						num += _empty_fehrestBahaTableAdapter.Update(array27);
						allChangedRows.AddRange(array27);
					}
				}
				if (_fEHSond1397TableAdapter != null)
				{
					DataRow[] array28 = dataSet.FEHSond1397.Select(null, null, DataViewRowState.Deleted);
					if (array28 != null && 0 < array28.Length)
					{
						num += _fEHSond1397TableAdapter.Update(array28);
						allChangedRows.AddRange(array28);
					}
				}
				if (_zarayebMantagheTableAdapter != null)
				{
					DataRow[] array29 = dataSet.ZarayebMantaghe.Select(null, null, DataViewRowState.Deleted);
					if (array29 != null && 0 < array29.Length)
					{
						num += _zarayebMantagheTableAdapter.Update(array29);
						allChangedRows.AddRange(array29);
					}
				}
				if (_moshakhasatTableAdapter != null)
				{
					DataRow[] array30 = dataSet.Moshakhasat.Select(null, null, DataViewRowState.Deleted);
					if (array30 != null && 0 < array30.Length)
					{
						num += _moshakhasatTableAdapter.Update(array30);
						allChangedRows.AddRange(array30);
					}
				}
				if (_sarfaslTableAdapter != null)
				{
					DataRow[] array31 = dataSet.Sarfasl.Select(null, null, DataViewRowState.Deleted);
					if (array31 != null && 0 < array31.Length)
					{
						num += _sarfaslTableAdapter.Update(array31);
						allChangedRows.AddRange(array31);
					}
				}
				if (_serverNameTableAdapter != null)
				{
					DataRow[] array32 = dataSet.ServerName.Select(null, null, DataViewRowState.Deleted);
					if (array32 != null && 0 < array32.Length)
					{
						num += _serverNameTableAdapter.Update(array32);
						allChangedRows.AddRange(array32);
					}
				}
				if (_fosoolTableAdapter != null)
				{
					DataRow[] array33 = dataSet.Fosool.Select(null, null, DataViewRowState.Deleted);
					if (array33 != null && 0 < array33.Length)
					{
						num += _fosoolTableAdapter.Update(array33);
						allChangedRows.AddRange(array33);
					}
				}
				if (_ghalebTableAdapter != null)
				{
					DataRow[] array34 = dataSet.Ghaleb.Select(null, null, DataViewRowState.Deleted);
					if (array34 != null && 0 < array34.Length)
					{
						num += _ghalebTableAdapter.Update(array34);
						allChangedRows.AddRange(array34);
					}
				}
				if (_matnNameTableAdapter != null)
				{
					DataRow[] array35 = dataSet.MatnName.Select(null, null, DataViewRowState.Deleted);
					if (array35 != null && 0 < array35.Length)
					{
						num += _matnNameTableAdapter.Update(array35);
						allChangedRows.AddRange(array35);
					}
				}
				if (_systemsTableAdapter != null)
				{
					DataRow[] array36 = dataSet.Systems.Select(null, null, DataViewRowState.Deleted);
					if (array36 != null && 0 < array36.Length)
					{
						num += _systemsTableAdapter.Update(array36);
						allChangedRows.AddRange(array36);
					}
				}
				if (_yesnoTableAdapter != null)
				{
					DataRow[] array37 = dataSet.yesno.Select(null, null, DataViewRowState.Deleted);
					if (array37 != null && 0 < array37.Length)
					{
						num += _yesnoTableAdapter.Update(array37);
						allChangedRows.AddRange(array37);
					}
				}
				if (_zarayebTableAdapter != null)
				{
					DataRow[] array38 = dataSet.Zarayeb.Select(null, null, DataViewRowState.Deleted);
					if (array38 != null && 0 < array38.Length)
					{
						num += _zarayebTableAdapter.Update(array38);
						allChangedRows.AddRange(array38);
					}
				}
				if (_zarayebBakhshnameTableAdapter != null)
				{
					DataRow[] array39 = dataSet.ZarayebBakhshname.Select(null, null, DataViewRowState.Deleted);
					if (array39 != null && 0 < array39.Length)
					{
						num += _zarayebBakhshnameTableAdapter.Update(array39);
						allChangedRows.AddRange(array39);
					}
				}
				if (_update_asnad1TableAdapter != null)
				{
					DataRow[] array40 = dataSet.Update_asnad1.Select(null, null, DataViewRowState.Deleted);
					if (array40 != null && 0 < array40.Length)
					{
						num += _update_asnad1TableAdapter.Update(array40);
						allChangedRows.AddRange(array40);
					}
				}
				if (_update_asnad2TableAdapter != null)
				{
					DataRow[] array41 = dataSet.Update_asnad2.Select(null, null, DataViewRowState.Deleted);
					if (array41 != null && 0 < array41.Length)
					{
						num += _update_asnad2TableAdapter.Update(array41);
						allChangedRows.AddRange(array41);
					}
				}
				if (_update_asnad4TableAdapter != null)
				{
					DataRow[] array42 = dataSet.Update_asnad4.Select(null, null, DataViewRowState.Deleted);
					if (array42 != null && 0 < array42.Length)
					{
						num += _update_asnad4TableAdapter.Update(array42);
						allChangedRows.AddRange(array42);
					}
				}
				return num;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
		{
			if (updatedRows == null || updatedRows.Length < 1)
			{
				return updatedRows;
			}
			if (allAddedRows == null || allAddedRows.Count < 1)
			{
				return updatedRows;
			}
			List<DataRow> list = new List<DataRow>();
			foreach (DataRow item in updatedRows)
			{
				if (!allAddedRows.Contains(item))
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public virtual int UpdateAll(GeoBahaDataSet dataSet)
		{
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			if (!dataSet.HasChanges())
			{
				return 0;
			}
			if (_asnad1TableAdapter != null && !MatchTableAdapterConnection(_asnad1TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_asnad2TableAdapter != null && !MatchTableAdapterConnection(_asnad2TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_asnad4TableAdapter != null && !MatchTableAdapterConnection(_asnad4TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_asnadAnavinTableAdapter != null && !MatchTableAdapterConnection(_asnadAnavinTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_dafaterVaBakhshhaTableAdapter != null && !MatchTableAdapterConnection(_dafaterVaBakhshhaTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_dELETE_asnad1TableAdapter != null && !MatchTableAdapterConnection(_dELETE_asnad1TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_dELETE_asnad2TableAdapter != null && !MatchTableAdapterConnection(_dELETE_asnad2TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_dELETE_asnad4TableAdapter != null && !MatchTableAdapterConnection(_dELETE_asnad4TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_dELETE_etkarfarTableAdapter != null && !MatchTableAdapterConnection(_dELETE_etkarfarTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_empty_fehrestBahaTableAdapter != null && !MatchTableAdapterConnection(_empty_fehrestBahaTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_etbakhshTableAdapter != null && !MatchTableAdapterConnection(_etbakhshTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_etkarfarTableAdapter != null && !MatchTableAdapterConnection(_etkarfarTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_etostanTableAdapter != null && !MatchTableAdapterConnection(_etostanTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_etprojTableAdapter != null && !MatchTableAdapterConnection(_etprojTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_etshahrTableAdapter != null && !MatchTableAdapterConnection(_etshahrTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_etvahedTableAdapter != null && !MatchTableAdapterConnection(_etvahedTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_factor_aTableAdapter != null && !MatchTableAdapterConnection(_factor_aTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_factor_bTableAdapter != null && !MatchTableAdapterConnection(_factor_bTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_factors40401TableAdapter != null && !MatchTableAdapterConnection(_factors40401TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fEH1268279393TableAdapter != null && !MatchTableAdapterConnection(_fEH1268279393TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fEHBAHA1384TableAdapter != null && !MatchTableAdapterConnection(_fEHBAHA1384TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fEHBAHA1387TableAdapter != null && !MatchTableAdapterConnection(_fEHBAHA1387TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fEHBAHA1391TableAdapter != null && !MatchTableAdapterConnection(_fEHBAHA1391TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fEHBAHA1393TableAdapter != null && !MatchTableAdapterConnection(_fEHBAHA1393TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fEHBAHA1397TableAdapter != null && !MatchTableAdapterConnection(_fEHBAHA1397TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fEHBAHA1399TableAdapter != null && !MatchTableAdapterConnection(_fEHBAHA1399TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fehrestTableAdapter != null && !MatchTableAdapterConnection(_fehrestTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fEHSond1397TableAdapter != null && !MatchTableAdapterConnection(_fEHSond1397TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_fosoolTableAdapter != null && !MatchTableAdapterConnection(_fosoolTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_ghalebTableAdapter != null && !MatchTableAdapterConnection(_ghalebTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_matnNameTableAdapter != null && !MatchTableAdapterConnection(_matnNameTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_moshakhasatTableAdapter != null && !MatchTableAdapterConnection(_moshakhasatTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_sarfaslTableAdapter != null && !MatchTableAdapterConnection(_sarfaslTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_serverNameTableAdapter != null && !MatchTableAdapterConnection(_serverNameTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_systemsTableAdapter != null && !MatchTableAdapterConnection(_systemsTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_update_asnad1TableAdapter != null && !MatchTableAdapterConnection(_update_asnad1TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_update_asnad2TableAdapter != null && !MatchTableAdapterConnection(_update_asnad2TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_update_asnad4TableAdapter != null && !MatchTableAdapterConnection(_update_asnad4TableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_yesnoTableAdapter != null && !MatchTableAdapterConnection(_yesnoTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_zarayebTableAdapter != null && !MatchTableAdapterConnection(_zarayebTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_zarayebBakhshnameTableAdapter != null && !MatchTableAdapterConnection(_zarayebBakhshnameTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			if (_zarayebMantagheTableAdapter != null && !MatchTableAdapterConnection(_zarayebMantagheTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			IDbConnection connection = Connection;
			if (connection == null)
			{
				throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
			}
			bool flag = false;
			if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
			{
				connection.Close();
			}
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				flag = true;
			}
			IDbTransaction dbTransaction = connection.BeginTransaction();
			if (dbTransaction == null)
			{
				throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
			}
			List<DataRow> list = new List<DataRow>();
			List<DataRow> list2 = new List<DataRow>();
			List<DataAdapter> list3 = new List<DataAdapter>();
			Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
			int num = 0;
			DataSet dataSet2 = null;
			if (BackupDataSetBeforeUpdate)
			{
				dataSet2 = new DataSet();
				dataSet2.Merge(dataSet);
			}
			checked
			{
				try
				{
					if (_asnad1TableAdapter != null)
					{
						dictionary.Add(_asnad1TableAdapter, _asnad1TableAdapter.Connection);
						_asnad1TableAdapter.Connection = (SqlConnection)connection;
						_asnad1TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_asnad1TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_asnad1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_asnad1TableAdapter.Adapter);
						}
					}
					if (_asnad2TableAdapter != null)
					{
						dictionary.Add(_asnad2TableAdapter, _asnad2TableAdapter.Connection);
						_asnad2TableAdapter.Connection = (SqlConnection)connection;
						_asnad2TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_asnad2TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_asnad2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_asnad2TableAdapter.Adapter);
						}
					}
					if (_asnad4TableAdapter != null)
					{
						dictionary.Add(_asnad4TableAdapter, _asnad4TableAdapter.Connection);
						_asnad4TableAdapter.Connection = (SqlConnection)connection;
						_asnad4TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_asnad4TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_asnad4TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_asnad4TableAdapter.Adapter);
						}
					}
					if (_asnadAnavinTableAdapter != null)
					{
						dictionary.Add(_asnadAnavinTableAdapter, _asnadAnavinTableAdapter.Connection);
						_asnadAnavinTableAdapter.Connection = (SqlConnection)connection;
						_asnadAnavinTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_asnadAnavinTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_asnadAnavinTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_asnadAnavinTableAdapter.Adapter);
						}
					}
					if (_dafaterVaBakhshhaTableAdapter != null)
					{
						dictionary.Add(_dafaterVaBakhshhaTableAdapter, _dafaterVaBakhshhaTableAdapter.Connection);
						_dafaterVaBakhshhaTableAdapter.Connection = (SqlConnection)connection;
						_dafaterVaBakhshhaTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_dafaterVaBakhshhaTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_dafaterVaBakhshhaTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_dafaterVaBakhshhaTableAdapter.Adapter);
						}
					}
					if (_dELETE_asnad1TableAdapter != null)
					{
						dictionary.Add(_dELETE_asnad1TableAdapter, _dELETE_asnad1TableAdapter.Connection);
						_dELETE_asnad1TableAdapter.Connection = (SqlConnection)connection;
						_dELETE_asnad1TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_dELETE_asnad1TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_dELETE_asnad1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_dELETE_asnad1TableAdapter.Adapter);
						}
					}
					if (_dELETE_asnad2TableAdapter != null)
					{
						dictionary.Add(_dELETE_asnad2TableAdapter, _dELETE_asnad2TableAdapter.Connection);
						_dELETE_asnad2TableAdapter.Connection = (SqlConnection)connection;
						_dELETE_asnad2TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_dELETE_asnad2TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_dELETE_asnad2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_dELETE_asnad2TableAdapter.Adapter);
						}
					}
					if (_dELETE_asnad4TableAdapter != null)
					{
						dictionary.Add(_dELETE_asnad4TableAdapter, _dELETE_asnad4TableAdapter.Connection);
						_dELETE_asnad4TableAdapter.Connection = (SqlConnection)connection;
						_dELETE_asnad4TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_dELETE_asnad4TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_dELETE_asnad4TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_dELETE_asnad4TableAdapter.Adapter);
						}
					}
					if (_dELETE_etkarfarTableAdapter != null)
					{
						dictionary.Add(_dELETE_etkarfarTableAdapter, _dELETE_etkarfarTableAdapter.Connection);
						_dELETE_etkarfarTableAdapter.Connection = (SqlConnection)connection;
						_dELETE_etkarfarTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_dELETE_etkarfarTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_dELETE_etkarfarTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_dELETE_etkarfarTableAdapter.Adapter);
						}
					}
					if (_empty_fehrestBahaTableAdapter != null)
					{
						dictionary.Add(_empty_fehrestBahaTableAdapter, _empty_fehrestBahaTableAdapter.Connection);
						_empty_fehrestBahaTableAdapter.Connection = (SqlConnection)connection;
						_empty_fehrestBahaTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_empty_fehrestBahaTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_empty_fehrestBahaTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_empty_fehrestBahaTableAdapter.Adapter);
						}
					}
					if (_etbakhshTableAdapter != null)
					{
						dictionary.Add(_etbakhshTableAdapter, _etbakhshTableAdapter.Connection);
						_etbakhshTableAdapter.Connection = (SqlConnection)connection;
						_etbakhshTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_etbakhshTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_etbakhshTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_etbakhshTableAdapter.Adapter);
						}
					}
					if (_etkarfarTableAdapter != null)
					{
						dictionary.Add(_etkarfarTableAdapter, _etkarfarTableAdapter.Connection);
						_etkarfarTableAdapter.Connection = (SqlConnection)connection;
						_etkarfarTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_etkarfarTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_etkarfarTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_etkarfarTableAdapter.Adapter);
						}
					}
					if (_etostanTableAdapter != null)
					{
						dictionary.Add(_etostanTableAdapter, _etostanTableAdapter.Connection);
						_etostanTableAdapter.Connection = (SqlConnection)connection;
						_etostanTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_etostanTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_etostanTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_etostanTableAdapter.Adapter);
						}
					}
					if (_etprojTableAdapter != null)
					{
						dictionary.Add(_etprojTableAdapter, _etprojTableAdapter.Connection);
						_etprojTableAdapter.Connection = (SqlConnection)connection;
						_etprojTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_etprojTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_etprojTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_etprojTableAdapter.Adapter);
						}
					}
					if (_etshahrTableAdapter != null)
					{
						dictionary.Add(_etshahrTableAdapter, _etshahrTableAdapter.Connection);
						_etshahrTableAdapter.Connection = (SqlConnection)connection;
						_etshahrTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_etshahrTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_etshahrTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_etshahrTableAdapter.Adapter);
						}
					}
					if (_etvahedTableAdapter != null)
					{
						dictionary.Add(_etvahedTableAdapter, _etvahedTableAdapter.Connection);
						_etvahedTableAdapter.Connection = (SqlConnection)connection;
						_etvahedTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_etvahedTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_etvahedTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_etvahedTableAdapter.Adapter);
						}
					}
					if (_factor_aTableAdapter != null)
					{
						dictionary.Add(_factor_aTableAdapter, _factor_aTableAdapter.Connection);
						_factor_aTableAdapter.Connection = (SqlConnection)connection;
						_factor_aTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_factor_aTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_factor_aTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_factor_aTableAdapter.Adapter);
						}
					}
					if (_factor_bTableAdapter != null)
					{
						dictionary.Add(_factor_bTableAdapter, _factor_bTableAdapter.Connection);
						_factor_bTableAdapter.Connection = (SqlConnection)connection;
						_factor_bTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_factor_bTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_factor_bTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_factor_bTableAdapter.Adapter);
						}
					}
					if (_factors40401TableAdapter != null)
					{
						dictionary.Add(_factors40401TableAdapter, _factors40401TableAdapter.Connection);
						_factors40401TableAdapter.Connection = (SqlConnection)connection;
						_factors40401TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_factors40401TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_factors40401TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_factors40401TableAdapter.Adapter);
						}
					}
					if (_fEH1268279393TableAdapter != null)
					{
						dictionary.Add(_fEH1268279393TableAdapter, _fEH1268279393TableAdapter.Connection);
						_fEH1268279393TableAdapter.Connection = (SqlConnection)connection;
						_fEH1268279393TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fEH1268279393TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fEH1268279393TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fEH1268279393TableAdapter.Adapter);
						}
					}
					if (_fEHBAHA1384TableAdapter != null)
					{
						dictionary.Add(_fEHBAHA1384TableAdapter, _fEHBAHA1384TableAdapter.Connection);
						_fEHBAHA1384TableAdapter.Connection = (SqlConnection)connection;
						_fEHBAHA1384TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fEHBAHA1384TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fEHBAHA1384TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fEHBAHA1384TableAdapter.Adapter);
						}
					}
					if (_fEHBAHA1387TableAdapter != null)
					{
						dictionary.Add(_fEHBAHA1387TableAdapter, _fEHBAHA1387TableAdapter.Connection);
						_fEHBAHA1387TableAdapter.Connection = (SqlConnection)connection;
						_fEHBAHA1387TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fEHBAHA1387TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fEHBAHA1387TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fEHBAHA1387TableAdapter.Adapter);
						}
					}
					if (_fEHBAHA1391TableAdapter != null)
					{
						dictionary.Add(_fEHBAHA1391TableAdapter, _fEHBAHA1391TableAdapter.Connection);
						_fEHBAHA1391TableAdapter.Connection = (SqlConnection)connection;
						_fEHBAHA1391TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fEHBAHA1391TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fEHBAHA1391TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fEHBAHA1391TableAdapter.Adapter);
						}
					}
					if (_fEHBAHA1393TableAdapter != null)
					{
						dictionary.Add(_fEHBAHA1393TableAdapter, _fEHBAHA1393TableAdapter.Connection);
						_fEHBAHA1393TableAdapter.Connection = (SqlConnection)connection;
						_fEHBAHA1393TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fEHBAHA1393TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fEHBAHA1393TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fEHBAHA1393TableAdapter.Adapter);
						}
					}
					if (_fEHBAHA1397TableAdapter != null)
					{
						dictionary.Add(_fEHBAHA1397TableAdapter, _fEHBAHA1397TableAdapter.Connection);
						_fEHBAHA1397TableAdapter.Connection = (SqlConnection)connection;
						_fEHBAHA1397TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fEHBAHA1397TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fEHBAHA1397TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fEHBAHA1397TableAdapter.Adapter);
						}
					}
					if (_fEHBAHA1399TableAdapter != null)
					{
						dictionary.Add(_fEHBAHA1399TableAdapter, _fEHBAHA1399TableAdapter.Connection);
						_fEHBAHA1399TableAdapter.Connection = (SqlConnection)connection;
						_fEHBAHA1399TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fEHBAHA1399TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fEHBAHA1399TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fEHBAHA1399TableAdapter.Adapter);
						}
					}
					if (_fehrestTableAdapter != null)
					{
						dictionary.Add(_fehrestTableAdapter, _fehrestTableAdapter.Connection);
						_fehrestTableAdapter.Connection = (SqlConnection)connection;
						_fehrestTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fehrestTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fehrestTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fehrestTableAdapter.Adapter);
						}
					}
					if (_fEHSond1397TableAdapter != null)
					{
						dictionary.Add(_fEHSond1397TableAdapter, _fEHSond1397TableAdapter.Connection);
						_fEHSond1397TableAdapter.Connection = (SqlConnection)connection;
						_fEHSond1397TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fEHSond1397TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fEHSond1397TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fEHSond1397TableAdapter.Adapter);
						}
					}
					if (_fosoolTableAdapter != null)
					{
						dictionary.Add(_fosoolTableAdapter, _fosoolTableAdapter.Connection);
						_fosoolTableAdapter.Connection = (SqlConnection)connection;
						_fosoolTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_fosoolTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_fosoolTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_fosoolTableAdapter.Adapter);
						}
					}
					if (_ghalebTableAdapter != null)
					{
						dictionary.Add(_ghalebTableAdapter, _ghalebTableAdapter.Connection);
						_ghalebTableAdapter.Connection = (SqlConnection)connection;
						_ghalebTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_ghalebTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_ghalebTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_ghalebTableAdapter.Adapter);
						}
					}
					if (_matnNameTableAdapter != null)
					{
						dictionary.Add(_matnNameTableAdapter, _matnNameTableAdapter.Connection);
						_matnNameTableAdapter.Connection = (SqlConnection)connection;
						_matnNameTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_matnNameTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_matnNameTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_matnNameTableAdapter.Adapter);
						}
					}
					if (_moshakhasatTableAdapter != null)
					{
						dictionary.Add(_moshakhasatTableAdapter, _moshakhasatTableAdapter.Connection);
						_moshakhasatTableAdapter.Connection = (SqlConnection)connection;
						_moshakhasatTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_moshakhasatTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_moshakhasatTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_moshakhasatTableAdapter.Adapter);
						}
					}
					if (_sarfaslTableAdapter != null)
					{
						dictionary.Add(_sarfaslTableAdapter, _sarfaslTableAdapter.Connection);
						_sarfaslTableAdapter.Connection = (SqlConnection)connection;
						_sarfaslTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_sarfaslTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_sarfaslTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_sarfaslTableAdapter.Adapter);
						}
					}
					if (_serverNameTableAdapter != null)
					{
						dictionary.Add(_serverNameTableAdapter, _serverNameTableAdapter.Connection);
						_serverNameTableAdapter.Connection = (SqlConnection)connection;
						_serverNameTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_serverNameTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_serverNameTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_serverNameTableAdapter.Adapter);
						}
					}
					if (_systemsTableAdapter != null)
					{
						dictionary.Add(_systemsTableAdapter, _systemsTableAdapter.Connection);
						_systemsTableAdapter.Connection = (SqlConnection)connection;
						_systemsTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_systemsTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_systemsTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_systemsTableAdapter.Adapter);
						}
					}
					if (_update_asnad1TableAdapter != null)
					{
						dictionary.Add(_update_asnad1TableAdapter, _update_asnad1TableAdapter.Connection);
						_update_asnad1TableAdapter.Connection = (SqlConnection)connection;
						_update_asnad1TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_update_asnad1TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_update_asnad1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_update_asnad1TableAdapter.Adapter);
						}
					}
					if (_update_asnad2TableAdapter != null)
					{
						dictionary.Add(_update_asnad2TableAdapter, _update_asnad2TableAdapter.Connection);
						_update_asnad2TableAdapter.Connection = (SqlConnection)connection;
						_update_asnad2TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_update_asnad2TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_update_asnad2TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_update_asnad2TableAdapter.Adapter);
						}
					}
					if (_update_asnad4TableAdapter != null)
					{
						dictionary.Add(_update_asnad4TableAdapter, _update_asnad4TableAdapter.Connection);
						_update_asnad4TableAdapter.Connection = (SqlConnection)connection;
						_update_asnad4TableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_update_asnad4TableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_update_asnad4TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_update_asnad4TableAdapter.Adapter);
						}
					}
					if (_yesnoTableAdapter != null)
					{
						dictionary.Add(_yesnoTableAdapter, _yesnoTableAdapter.Connection);
						_yesnoTableAdapter.Connection = (SqlConnection)connection;
						_yesnoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_yesnoTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_yesnoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_yesnoTableAdapter.Adapter);
						}
					}
					if (_zarayebTableAdapter != null)
					{
						dictionary.Add(_zarayebTableAdapter, _zarayebTableAdapter.Connection);
						_zarayebTableAdapter.Connection = (SqlConnection)connection;
						_zarayebTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_zarayebTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_zarayebTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_zarayebTableAdapter.Adapter);
						}
					}
					if (_zarayebBakhshnameTableAdapter != null)
					{
						dictionary.Add(_zarayebBakhshnameTableAdapter, _zarayebBakhshnameTableAdapter.Connection);
						_zarayebBakhshnameTableAdapter.Connection = (SqlConnection)connection;
						_zarayebBakhshnameTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_zarayebBakhshnameTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_zarayebBakhshnameTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_zarayebBakhshnameTableAdapter.Adapter);
						}
					}
					if (_zarayebMantagheTableAdapter != null)
					{
						dictionary.Add(_zarayebMantagheTableAdapter, _zarayebMantagheTableAdapter.Connection);
						_zarayebMantagheTableAdapter.Connection = (SqlConnection)connection;
						_zarayebMantagheTableAdapter.Transaction = (SqlTransaction)dbTransaction;
						if (_zarayebMantagheTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							_zarayebMantagheTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							list3.Add(_zarayebMantagheTableAdapter.Adapter);
						}
					}
					if (UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
					{
						num += UpdateUpdatedRows(dataSet, list, list2);
						num += UpdateInsertedRows(dataSet, list2);
					}
					else
					{
						num += UpdateInsertedRows(dataSet, list2);
						num += UpdateUpdatedRows(dataSet, list, list2);
					}
					num += UpdateDeletedRows(dataSet, list);
					dbTransaction.Commit();
					if (0 < list2.Count)
					{
						DataRow[] array = new DataRow[list2.Count - 1 + 1];
						list2.CopyTo(array);
						foreach (DataRow dataRow in array)
						{
							dataRow.AcceptChanges();
						}
					}
					if (0 < list.Count)
					{
						DataRow[] array2 = new DataRow[list.Count - 1 + 1];
						list.CopyTo(array2);
						foreach (DataRow dataRow2 in array2)
						{
							dataRow2.AcceptChanges();
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					dbTransaction.Rollback();
					if (BackupDataSetBeforeUpdate)
					{
						Debug.Assert(dataSet2 != null);
						dataSet.Clear();
						dataSet.Merge(dataSet2);
					}
					else if (0 < list2.Count)
					{
						DataRow[] array3 = new DataRow[list2.Count - 1 + 1];
						list2.CopyTo(array3);
						foreach (DataRow dataRow3 in array3)
						{
							dataRow3.AcceptChanges();
							dataRow3.SetAdded();
						}
					}
					throw ex2;
				}
				finally
				{
					if (flag)
					{
						connection.Close();
					}
					if (_asnad1TableAdapter != null)
					{
						_asnad1TableAdapter.Connection = (SqlConnection)dictionary[_asnad1TableAdapter];
						_asnad1TableAdapter.Transaction = null;
					}
					if (_asnad2TableAdapter != null)
					{
						_asnad2TableAdapter.Connection = (SqlConnection)dictionary[_asnad2TableAdapter];
						_asnad2TableAdapter.Transaction = null;
					}
					if (_asnad4TableAdapter != null)
					{
						_asnad4TableAdapter.Connection = (SqlConnection)dictionary[_asnad4TableAdapter];
						_asnad4TableAdapter.Transaction = null;
					}
					if (_asnadAnavinTableAdapter != null)
					{
						_asnadAnavinTableAdapter.Connection = (SqlConnection)dictionary[_asnadAnavinTableAdapter];
						_asnadAnavinTableAdapter.Transaction = null;
					}
					if (_dafaterVaBakhshhaTableAdapter != null)
					{
						_dafaterVaBakhshhaTableAdapter.Connection = (SqlConnection)dictionary[_dafaterVaBakhshhaTableAdapter];
						_dafaterVaBakhshhaTableAdapter.Transaction = null;
					}
					if (_dELETE_asnad1TableAdapter != null)
					{
						_dELETE_asnad1TableAdapter.Connection = (SqlConnection)dictionary[_dELETE_asnad1TableAdapter];
						_dELETE_asnad1TableAdapter.Transaction = null;
					}
					if (_dELETE_asnad2TableAdapter != null)
					{
						_dELETE_asnad2TableAdapter.Connection = (SqlConnection)dictionary[_dELETE_asnad2TableAdapter];
						_dELETE_asnad2TableAdapter.Transaction = null;
					}
					if (_dELETE_asnad4TableAdapter != null)
					{
						_dELETE_asnad4TableAdapter.Connection = (SqlConnection)dictionary[_dELETE_asnad4TableAdapter];
						_dELETE_asnad4TableAdapter.Transaction = null;
					}
					if (_dELETE_etkarfarTableAdapter != null)
					{
						_dELETE_etkarfarTableAdapter.Connection = (SqlConnection)dictionary[_dELETE_etkarfarTableAdapter];
						_dELETE_etkarfarTableAdapter.Transaction = null;
					}
					if (_empty_fehrestBahaTableAdapter != null)
					{
						_empty_fehrestBahaTableAdapter.Connection = (SqlConnection)dictionary[_empty_fehrestBahaTableAdapter];
						_empty_fehrestBahaTableAdapter.Transaction = null;
					}
					if (_etbakhshTableAdapter != null)
					{
						_etbakhshTableAdapter.Connection = (SqlConnection)dictionary[_etbakhshTableAdapter];
						_etbakhshTableAdapter.Transaction = null;
					}
					if (_etkarfarTableAdapter != null)
					{
						_etkarfarTableAdapter.Connection = (SqlConnection)dictionary[_etkarfarTableAdapter];
						_etkarfarTableAdapter.Transaction = null;
					}
					if (_etostanTableAdapter != null)
					{
						_etostanTableAdapter.Connection = (SqlConnection)dictionary[_etostanTableAdapter];
						_etostanTableAdapter.Transaction = null;
					}
					if (_etprojTableAdapter != null)
					{
						_etprojTableAdapter.Connection = (SqlConnection)dictionary[_etprojTableAdapter];
						_etprojTableAdapter.Transaction = null;
					}
					if (_etshahrTableAdapter != null)
					{
						_etshahrTableAdapter.Connection = (SqlConnection)dictionary[_etshahrTableAdapter];
						_etshahrTableAdapter.Transaction = null;
					}
					if (_etvahedTableAdapter != null)
					{
						_etvahedTableAdapter.Connection = (SqlConnection)dictionary[_etvahedTableAdapter];
						_etvahedTableAdapter.Transaction = null;
					}
					if (_factor_aTableAdapter != null)
					{
						_factor_aTableAdapter.Connection = (SqlConnection)dictionary[_factor_aTableAdapter];
						_factor_aTableAdapter.Transaction = null;
					}
					if (_factor_bTableAdapter != null)
					{
						_factor_bTableAdapter.Connection = (SqlConnection)dictionary[_factor_bTableAdapter];
						_factor_bTableAdapter.Transaction = null;
					}
					if (_factors40401TableAdapter != null)
					{
						_factors40401TableAdapter.Connection = (SqlConnection)dictionary[_factors40401TableAdapter];
						_factors40401TableAdapter.Transaction = null;
					}
					if (_fEH1268279393TableAdapter != null)
					{
						_fEH1268279393TableAdapter.Connection = (SqlConnection)dictionary[_fEH1268279393TableAdapter];
						_fEH1268279393TableAdapter.Transaction = null;
					}
					if (_fEHBAHA1384TableAdapter != null)
					{
						_fEHBAHA1384TableAdapter.Connection = (SqlConnection)dictionary[_fEHBAHA1384TableAdapter];
						_fEHBAHA1384TableAdapter.Transaction = null;
					}
					if (_fEHBAHA1387TableAdapter != null)
					{
						_fEHBAHA1387TableAdapter.Connection = (SqlConnection)dictionary[_fEHBAHA1387TableAdapter];
						_fEHBAHA1387TableAdapter.Transaction = null;
					}
					if (_fEHBAHA1391TableAdapter != null)
					{
						_fEHBAHA1391TableAdapter.Connection = (SqlConnection)dictionary[_fEHBAHA1391TableAdapter];
						_fEHBAHA1391TableAdapter.Transaction = null;
					}
					if (_fEHBAHA1393TableAdapter != null)
					{
						_fEHBAHA1393TableAdapter.Connection = (SqlConnection)dictionary[_fEHBAHA1393TableAdapter];
						_fEHBAHA1393TableAdapter.Transaction = null;
					}
					if (_fEHBAHA1397TableAdapter != null)
					{
						_fEHBAHA1397TableAdapter.Connection = (SqlConnection)dictionary[_fEHBAHA1397TableAdapter];
						_fEHBAHA1397TableAdapter.Transaction = null;
					}
					if (_fEHBAHA1399TableAdapter != null)
					{
						_fEHBAHA1399TableAdapter.Connection = (SqlConnection)dictionary[_fEHBAHA1399TableAdapter];
						_fEHBAHA1399TableAdapter.Transaction = null;
					}
					if (_fehrestTableAdapter != null)
					{
						_fehrestTableAdapter.Connection = (SqlConnection)dictionary[_fehrestTableAdapter];
						_fehrestTableAdapter.Transaction = null;
					}
					if (_fEHSond1397TableAdapter != null)
					{
						_fEHSond1397TableAdapter.Connection = (SqlConnection)dictionary[_fEHSond1397TableAdapter];
						_fEHSond1397TableAdapter.Transaction = null;
					}
					if (_fosoolTableAdapter != null)
					{
						_fosoolTableAdapter.Connection = (SqlConnection)dictionary[_fosoolTableAdapter];
						_fosoolTableAdapter.Transaction = null;
					}
					if (_ghalebTableAdapter != null)
					{
						_ghalebTableAdapter.Connection = (SqlConnection)dictionary[_ghalebTableAdapter];
						_ghalebTableAdapter.Transaction = null;
					}
					if (_matnNameTableAdapter != null)
					{
						_matnNameTableAdapter.Connection = (SqlConnection)dictionary[_matnNameTableAdapter];
						_matnNameTableAdapter.Transaction = null;
					}
					if (_moshakhasatTableAdapter != null)
					{
						_moshakhasatTableAdapter.Connection = (SqlConnection)dictionary[_moshakhasatTableAdapter];
						_moshakhasatTableAdapter.Transaction = null;
					}
					if (_sarfaslTableAdapter != null)
					{
						_sarfaslTableAdapter.Connection = (SqlConnection)dictionary[_sarfaslTableAdapter];
						_sarfaslTableAdapter.Transaction = null;
					}
					if (_serverNameTableAdapter != null)
					{
						_serverNameTableAdapter.Connection = (SqlConnection)dictionary[_serverNameTableAdapter];
						_serverNameTableAdapter.Transaction = null;
					}
					if (_systemsTableAdapter != null)
					{
						_systemsTableAdapter.Connection = (SqlConnection)dictionary[_systemsTableAdapter];
						_systemsTableAdapter.Transaction = null;
					}
					if (_update_asnad1TableAdapter != null)
					{
						_update_asnad1TableAdapter.Connection = (SqlConnection)dictionary[_update_asnad1TableAdapter];
						_update_asnad1TableAdapter.Transaction = null;
					}
					if (_update_asnad2TableAdapter != null)
					{
						_update_asnad2TableAdapter.Connection = (SqlConnection)dictionary[_update_asnad2TableAdapter];
						_update_asnad2TableAdapter.Transaction = null;
					}
					if (_update_asnad4TableAdapter != null)
					{
						_update_asnad4TableAdapter.Connection = (SqlConnection)dictionary[_update_asnad4TableAdapter];
						_update_asnad4TableAdapter.Transaction = null;
					}
					if (_yesnoTableAdapter != null)
					{
						_yesnoTableAdapter.Connection = (SqlConnection)dictionary[_yesnoTableAdapter];
						_yesnoTableAdapter.Transaction = null;
					}
					if (_zarayebTableAdapter != null)
					{
						_zarayebTableAdapter.Connection = (SqlConnection)dictionary[_zarayebTableAdapter];
						_zarayebTableAdapter.Transaction = null;
					}
					if (_zarayebBakhshnameTableAdapter != null)
					{
						_zarayebBakhshnameTableAdapter.Connection = (SqlConnection)dictionary[_zarayebBakhshnameTableAdapter];
						_zarayebBakhshnameTableAdapter.Transaction = null;
					}
					if (_zarayebMantagheTableAdapter != null)
					{
						_zarayebMantagheTableAdapter.Connection = (SqlConnection)dictionary[_zarayebMantagheTableAdapter];
						_zarayebMantagheTableAdapter.Transaction = null;
					}
					if (0 < list3.Count)
					{
						DataAdapter[] array4 = new DataAdapter[list3.Count - 1 + 1];
						list3.CopyTo(array4);
						foreach (DataAdapter dataAdapter in array4)
						{
							dataAdapter.AcceptChangesDuringUpdate = true;
						}
					}
				}
				return num;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
		{
			Array.Sort(rows, new SelfReferenceComparer(relation, childFirst));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
		{
			if (_connection != null)
			{
				return true;
			}
			if (Connection == null || inputConnection == null)
			{
				return true;
			}
			if (string.Equals(Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal))
			{
				return true;
			}
			return false;
		}
	}
}

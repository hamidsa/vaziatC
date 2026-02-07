using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha.My
{
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_AsnadDetail m_Frm_AsnadDetail;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_AsnadGhaleb m_Frm_AsnadGhaleb;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_AsnadList m_Frm_AsnadList;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public frm_AsnadOnvan m_frm_AsnadOnvan;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_Calculate m_Frm_Calculate;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public frm_CopySanad m_frm_CopySanad;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_Enteghal m_Frm_Enteghal;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public frm_Factor_a m_frm_Factor_a;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public frm_Factor_b m_frm_Factor_b;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_Fehrest m_Frm_Fehrest;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_FehrestDetail m_Frm_FehrestDetail;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_ItemSelect m_Frm_ItemSelect;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_Karfarma m_Frm_Karfarma;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_Main m_Frm_Main;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public frm_PrintDialog m_frm_PrintDialog;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public frm_PrintSanad m_frm_PrintSanad;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_Project m_Frm_Project;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_ZarayebBakhshname m_Frm_ZarayebBakhshname;

			[EditorBrowsable(EditorBrowsableState.Never)]
			public Frm_ZarayebMantaghe m_Frm_ZarayebMantaghe;

			public Frm_AsnadDetail Frm_AsnadDetail
			{
				[DebuggerHidden]
				get
				{
					m_Frm_AsnadDetail = Create__Instance__(m_Frm_AsnadDetail);
					return m_Frm_AsnadDetail;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_AsnadDetail)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_AsnadDetail);
					}
				}
			}

			public Frm_AsnadGhaleb Frm_AsnadGhaleb
			{
				[DebuggerHidden]
				get
				{
					m_Frm_AsnadGhaleb = Create__Instance__(m_Frm_AsnadGhaleb);
					return m_Frm_AsnadGhaleb;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_AsnadGhaleb)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_AsnadGhaleb);
					}
				}
			}

			public Frm_AsnadList Frm_AsnadList
			{
				[DebuggerHidden]
				get
				{
					m_Frm_AsnadList = Create__Instance__(m_Frm_AsnadList);
					return m_Frm_AsnadList;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_AsnadList)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_AsnadList);
					}
				}
			}

			public frm_AsnadOnvan frm_AsnadOnvan
			{
				[DebuggerHidden]
				get
				{
					m_frm_AsnadOnvan = Create__Instance__(m_frm_AsnadOnvan);
					return m_frm_AsnadOnvan;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_frm_AsnadOnvan)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_frm_AsnadOnvan);
					}
				}
			}

			public Frm_Calculate Frm_Calculate
			{
				[DebuggerHidden]
				get
				{
					m_Frm_Calculate = Create__Instance__(m_Frm_Calculate);
					return m_Frm_Calculate;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_Calculate)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_Calculate);
					}
				}
			}

			public frm_CopySanad frm_CopySanad
			{
				[DebuggerHidden]
				get
				{
					m_frm_CopySanad = Create__Instance__(m_frm_CopySanad);
					return m_frm_CopySanad;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_frm_CopySanad)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_frm_CopySanad);
					}
				}
			}

			public Frm_Enteghal Frm_Enteghal
			{
				[DebuggerHidden]
				get
				{
					m_Frm_Enteghal = Create__Instance__(m_Frm_Enteghal);
					return m_Frm_Enteghal;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_Enteghal)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_Enteghal);
					}
				}
			}

			public frm_Factor_a frm_Factor_a
			{
				[DebuggerHidden]
				get
				{
					m_frm_Factor_a = Create__Instance__(m_frm_Factor_a);
					return m_frm_Factor_a;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_frm_Factor_a)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_frm_Factor_a);
					}
				}
			}

			public frm_Factor_b frm_Factor_b
			{
				[DebuggerHidden]
				get
				{
					m_frm_Factor_b = Create__Instance__(m_frm_Factor_b);
					return m_frm_Factor_b;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_frm_Factor_b)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_frm_Factor_b);
					}
				}
			}

			public Frm_Fehrest Frm_Fehrest
			{
				[DebuggerHidden]
				get
				{
					m_Frm_Fehrest = Create__Instance__(m_Frm_Fehrest);
					return m_Frm_Fehrest;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_Fehrest)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_Fehrest);
					}
				}
			}

			public Frm_FehrestDetail Frm_FehrestDetail
			{
				[DebuggerHidden]
				get
				{
					m_Frm_FehrestDetail = Create__Instance__(m_Frm_FehrestDetail);
					return m_Frm_FehrestDetail;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_FehrestDetail)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_FehrestDetail);
					}
				}
			}

			public Frm_ItemSelect Frm_ItemSelect
			{
				[DebuggerHidden]
				get
				{
					m_Frm_ItemSelect = Create__Instance__(m_Frm_ItemSelect);
					return m_Frm_ItemSelect;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_ItemSelect)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_ItemSelect);
					}
				}
			}

			public Frm_Karfarma Frm_Karfarma
			{
				[DebuggerHidden]
				get
				{
					m_Frm_Karfarma = Create__Instance__(m_Frm_Karfarma);
					return m_Frm_Karfarma;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_Karfarma)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_Karfarma);
					}
				}
			}

			public Frm_Main Frm_Main
			{
				[DebuggerHidden]
				get
				{
					m_Frm_Main = Create__Instance__(m_Frm_Main);
					return m_Frm_Main;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_Main)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_Main);
					}
				}
			}

			public frm_PrintDialog frm_PrintDialog
			{
				[DebuggerHidden]
				get
				{
					m_frm_PrintDialog = Create__Instance__(m_frm_PrintDialog);
					return m_frm_PrintDialog;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_frm_PrintDialog)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_frm_PrintDialog);
					}
				}
			}

			public frm_PrintSanad frm_PrintSanad
			{
				[DebuggerHidden]
				get
				{
					m_frm_PrintSanad = Create__Instance__(m_frm_PrintSanad);
					return m_frm_PrintSanad;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_frm_PrintSanad)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_frm_PrintSanad);
					}
				}
			}

			public Frm_Project Frm_Project
			{
				[DebuggerHidden]
				get
				{
					m_Frm_Project = Create__Instance__(m_Frm_Project);
					return m_Frm_Project;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_Project)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_Project);
					}
				}
			}

			public Frm_ZarayebBakhshname Frm_ZarayebBakhshname
			{
				[DebuggerHidden]
				get
				{
					m_Frm_ZarayebBakhshname = Create__Instance__(m_Frm_ZarayebBakhshname);
					return m_Frm_ZarayebBakhshname;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_ZarayebBakhshname)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_ZarayebBakhshname);
					}
				}
			}

			public Frm_ZarayebMantaghe Frm_ZarayebMantaghe
			{
				[DebuggerHidden]
				get
				{
					m_Frm_ZarayebMantaghe = Create__Instance__(m_Frm_ZarayebMantaghe);
					return m_Frm_ZarayebMantaghe;
				}
				[DebuggerHidden]
				set
				{
					if (value != m_Frm_ZarayebMantaghe)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Frm_ZarayebMantaghe);
					}
				}
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || Instance.IsDisposed)
				{
					if (m_FormBeingCreated != null)
					{
						if (m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
						}
					}
					else
					{
						m_FormBeingCreated = new Hashtable();
					}
					m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						ProjectData.SetProjectError(ex);
						return ex.InnerException != null;
					}).Invoke())
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = null;
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyForms);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyWebServices);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return new T();
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (m_ThreadStaticValue == null)
					{
						m_ThreadStaticValue = new T();
					}
					return m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}
		}

		private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

		private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

		private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

		private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

		private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return m_MyWebServicesObjectProvider.GetInstance;
			}
		}
	}
}

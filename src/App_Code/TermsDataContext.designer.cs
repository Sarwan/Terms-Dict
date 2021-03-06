﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TermsDb")]
public partial class TermsDataContextDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertClassification(Classification instance);
  partial void UpdateClassification(Classification instance);
  partial void DeleteClassification(Classification instance);
  partial void InsertTerm(Term instance);
  partial void UpdateTerm(Term instance);
  partial void DeleteTerm(Term instance);
  #endregion
	
	public TermsDataContextDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TermsDbConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public TermsDataContextDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public TermsDataContextDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public TermsDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public TermsDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Classification> Classifications
	{
		get
		{
			return this.GetTable<Classification>();
		}
	}
	
	public System.Data.Linq.Table<Term> Terms
	{
		get
		{
			return this.GetTable<Term>();
		}
	}
	
	public System.Data.Linq.Table<TermWithCategory> TermWithCategories
	{
		get
		{
			return this.GetTable<TermWithCategory>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Classification")]
public partial class Classification : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private byte _ID;
	
	private string _NameUyghur;
	
	private string _NameChinese;
	
	private EntitySet<Term> _Terms;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(byte value);
    partial void OnIDChanged();
    partial void OnNameUyghurChanging(string value);
    partial void OnNameUyghurChanged();
    partial void OnNameChineseChanging(string value);
    partial void OnNameChineseChanged();
    #endregion
	
	public Classification()
	{
		this._Terms = new EntitySet<Term>(new Action<Term>(this.attach_Terms), new Action<Term>(this.detach_Terms));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
	public byte ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameUyghur", DbType="NChar(255)")]
	public string NameUyghur
	{
		get
		{
			return this._NameUyghur;
		}
		set
		{
			if ((this._NameUyghur != value))
			{
				this.OnNameUyghurChanging(value);
				this.SendPropertyChanging();
				this._NameUyghur = value;
				this.SendPropertyChanged("NameUyghur");
				this.OnNameUyghurChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameChinese", DbType="NChar(255)")]
	public string NameChinese
	{
		get
		{
			return this._NameChinese;
		}
		set
		{
			if ((this._NameChinese != value))
			{
				this.OnNameChineseChanging(value);
				this.SendPropertyChanging();
				this._NameChinese = value;
				this.SendPropertyChanged("NameChinese");
				this.OnNameChineseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Classification_Term", Storage="_Terms", ThisKey="ID", OtherKey="Classification")]
	public EntitySet<Term> Terms
	{
		get
		{
			return this._Terms;
		}
		set
		{
			this._Terms.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Terms(Term entity)
	{
		this.SendPropertyChanging();
		entity.Classification1 = this;
	}
	
	private void detach_Terms(Term entity)
	{
		this.SendPropertyChanging();
		entity.Classification1 = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Term")]
public partial class Term : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Uyghur;
	
	private string _Chinese;
	
	private string _English;
	
	private byte _Classification;
	
	private EntityRef<Classification> _Classification1;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUyghurChanging(string value);
    partial void OnUyghurChanged();
    partial void OnChineseChanging(string value);
    partial void OnChineseChanged();
    partial void OnEnglishChanging(string value);
    partial void OnEnglishChanged();
    partial void OnClassificationChanging(byte value);
    partial void OnClassificationChanged();
    #endregion
	
	public Term()
	{
		this._Classification1 = default(EntityRef<Classification>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Uyghur", DbType="NChar(512)")]
	public string Uyghur
	{
		get
		{
			return this._Uyghur;
		}
		set
		{
			if ((this._Uyghur != value))
			{
				this.OnUyghurChanging(value);
				this.SendPropertyChanging();
				this._Uyghur = value;
				this.SendPropertyChanged("Uyghur");
				this.OnUyghurChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chinese", DbType="NChar(255)")]
	public string Chinese
	{
		get
		{
			return this._Chinese;
		}
		set
		{
			if ((this._Chinese != value))
			{
				this.OnChineseChanging(value);
				this.SendPropertyChanging();
				this._Chinese = value;
				this.SendPropertyChanged("Chinese");
				this.OnChineseChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_English", DbType="NChar(512)")]
	public string English
	{
		get
		{
			return this._English;
		}
		set
		{
			if ((this._English != value))
			{
				this.OnEnglishChanging(value);
				this.SendPropertyChanging();
				this._English = value;
				this.SendPropertyChanged("English");
				this.OnEnglishChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Classification", DbType="TinyInt NOT NULL")]
	public byte Classification
	{
		get
		{
			return this._Classification;
		}
		set
		{
			if ((this._Classification != value))
			{
				if (this._Classification1.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnClassificationChanging(value);
				this.SendPropertyChanging();
				this._Classification = value;
				this.SendPropertyChanged("Classification");
				this.OnClassificationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Classification_Term", Storage="_Classification1", ThisKey="Classification", OtherKey="ID", IsForeignKey=true)]
	public Classification Classification1
	{
		get
		{
			return this._Classification1.Entity;
		}
		set
		{
			Classification previousValue = this._Classification1.Entity;
			if (((previousValue != value) 
						|| (this._Classification1.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Classification1.Entity = null;
					previousValue.Terms.Remove(this);
				}
				this._Classification1.Entity = value;
				if ((value != null))
				{
					value.Terms.Add(this);
					this._Classification = value.ID;
				}
				else
				{
					this._Classification = default(byte);
				}
				this.SendPropertyChanged("Classification1");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TermWithCategory")]
public partial class TermWithCategory
{
	
	private int _ID;
	
	private string _Uyghur;
	
	private string _Chinese;
	
	private string _English;
	
	private string _CategoryUyghur;
	
	private string _CategoryChinese;
	
	public TermWithCategory()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this._ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Uyghur", DbType="NChar(512)")]
	public string Uyghur
	{
		get
		{
			return this._Uyghur;
		}
		set
		{
			if ((this._Uyghur != value))
			{
				this._Uyghur = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Chinese", DbType="NChar(255)")]
	public string Chinese
	{
		get
		{
			return this._Chinese;
		}
		set
		{
			if ((this._Chinese != value))
			{
				this._Chinese = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_English", DbType="NChar(512)")]
	public string English
	{
		get
		{
			return this._English;
		}
		set
		{
			if ((this._English != value))
			{
				this._English = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryUyghur", DbType="NChar(255)")]
	public string CategoryUyghur
	{
		get
		{
			return this._CategoryUyghur;
		}
		set
		{
			if ((this._CategoryUyghur != value))
			{
				this._CategoryUyghur = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryChinese", DbType="NChar(255)")]
	public string CategoryChinese
	{
		get
		{
			return this._CategoryChinese;
		}
		set
		{
			if ((this._CategoryChinese != value))
			{
				this._CategoryChinese = value;
			}
		}
	}
}
#pragma warning restore 1591

﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarla
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TarlaDB")]
	public partial class dcTarlaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSetting(Setting instance);
    partial void UpdateSetting(Setting instance);
    partial void DeleteSetting(Setting instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public dcTarlaDataContext() : 
				base(global::Tarla.Properties.Settings.Default.TarlaDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dcTarlaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcTarlaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcTarlaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcTarlaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Setting> Settings
		{
			get
			{
				return this.GetTable<Setting>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertLog")]
		public int InsertLog([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Login", DbType="NVarChar(20)")] string login)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId, login);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateLog")]
		public int UpdateLog([global::System.Data.Linq.Mapping.ParameterAttribute(Name="LogId", DbType="Int")] System.Nullable<int> logId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Logout", DbType="NVarChar(20)")] string logout)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), logId, logout);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLogId")]
		public int GetLogId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="LogId", DbType="Int")] ref System.Nullable<int> logId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Logout", DbType="NVarChar(20)")] string logout)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), logId, userId, logout);
			logId = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteUsers")]
		public int DeleteUsers([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CheckUserPass")]
		public int CheckUserPass([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Check", DbType="Bit")] ref System.Nullable<bool> check, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pass", DbType="NVarChar(20)")] string pass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), check, pass);
			check = ((System.Nullable<bool>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CheckUsersName")]
		public int CheckUsersName([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Check", DbType="Bit")] ref System.Nullable<bool> check, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(20)")] string name)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), check, name);
			check = ((System.Nullable<bool>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetLoginId")]
		public int GetLoginId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] ref System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="NVarChar(20)")] string user, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pass", DbType="NVarChar(20)")] string pass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, user, pass);
			id = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertSetting")]
		public int InsertSetting([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Company", DbType="NVarChar(100)")] string company, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FactorAddress", DbType="NVarChar(MAX)")] string factorAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FactortTell", DbType="NVarChar(20)")] string factortTell, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Theme", DbType="NVarChar(50)")] string theme, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FontSize", DbType="Float")] System.Nullable<double> fontSize)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), company, factorAddress, factortTell, theme, fontSize);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ExistsSetting")]
		public int ExistsSetting([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Exists", DbType="Bit")] ref System.Nullable<bool> exists)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), exists);
			exists = ((System.Nullable<bool>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ExistsUsers")]
		public int ExistsUsers([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Exist", DbType="Bit")] ref System.Nullable<bool> exist)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), exist);
			exist = ((System.Nullable<bool>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ExistsRoles")]
		public int ExistsRoles([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Exist", DbType="Bit")] ref System.Nullable<bool> exist)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), exist);
			exist = ((System.Nullable<bool>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertRole")]
		public int InsertRole([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RoleName", DbType="NVarChar(50)")] string roleName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Settings", DbType="Bit")] System.Nullable<bool> settings, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="Bit")] System.Nullable<bool> user, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bank", DbType="Bit")] System.Nullable<bool> bank, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Factor", DbType="Bit")] System.Nullable<bool> factor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), roleName, settings, user, bank, factor);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FillRolesById")]
		public ISingleResult<FillRolesByIdResult> FillRolesById([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RoleId", DbType="Int")] System.Nullable<int> roleId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), roleId);
			return ((ISingleResult<FillRolesByIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateRole")]
		public int UpdateRole([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RoleId", DbType="Int")] System.Nullable<int> roleId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RoleName", DbType="NVarChar(50)")] string roleName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Settings", DbType="Bit")] System.Nullable<bool> settings, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="Bit")] System.Nullable<bool> user, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bank", DbType="Bit")] System.Nullable<bool> bank, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Factor", DbType="Bit")] System.Nullable<bool> factor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), roleId, roleName, settings, user, bank, factor);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FillUsers")]
		public ISingleResult<FillUsersResult> FillUsers([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId);
			return ((ISingleResult<FillUsersResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FillUsersById")]
		public ISingleResult<FillUsersByIdResult> FillUsersById([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId);
			return ((ISingleResult<FillUsersByIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertUser")]
		public int InsertUser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RoleId", DbType="Int")] System.Nullable<int> roleId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fullname", DbType="NVarChar(30)")] string fullname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="NVarChar(20)")] string user, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pass", DbType="NVarChar(20)")] string pass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), roleId, fullname, user, pass);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateUsers")]
		public int UpdateUsers([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserId", DbType="Int")] System.Nullable<int> userId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RoleId", DbType="Int")] System.Nullable<int> roleId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fullname", DbType="NVarChar(30)")] string fullname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="NVarChar(20)")] string user, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pass", DbType="NVarChar(20)")] string pass)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId, roleId, fullname, user, pass);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FillRoles")]
		public ISingleResult<Role> FillRoles()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Role>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.FillSetting")]
		public ISingleResult<Setting> FillSetting()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Setting>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateSetting")]
		public int UpdateSetting([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Company", DbType="NVarChar(100)")] string company, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FactorAddress", DbType="NVarChar(MAX)")] string factorAddress, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FactortTell", DbType="NVarChar(20)")] string factortTell, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Theme", DbType="NVarChar(50)")] string theme, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FontSize", DbType="Float")] System.Nullable<double> fontSize)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), company, factorAddress, factortTell, theme, fontSize);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetUserPermissions")]
		public int GetUserPermissions([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> userId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Setting", DbType="Bit")] ref System.Nullable<bool> setting, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bank", DbType="Bit")] ref System.Nullable<bool> bank, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User", DbType="Bit")] ref System.Nullable<bool> user, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Factor", DbType="Bit")] ref System.Nullable<bool> factor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userId, setting, bank, user, factor);
			setting = ((System.Nullable<bool>)(result.GetParameterValue(1)));
			bank = ((System.Nullable<bool>)(result.GetParameterValue(2)));
			user = ((System.Nullable<bool>)(result.GetParameterValue(3)));
			factor = ((System.Nullable<bool>)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Setting")]
	public partial class Setting : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SettingId;
		
		private string _CompanyName;
		
		private string _FactorAddress;
		
		private string _FactorTel;
		
		private string _Theme;
		
		private System.Nullable<double> _FontSize;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSettingIdChanging(int value);
    partial void OnSettingIdChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnFactorAddressChanging(string value);
    partial void OnFactorAddressChanged();
    partial void OnFactorTelChanging(string value);
    partial void OnFactorTelChanged();
    partial void OnThemeChanging(string value);
    partial void OnThemeChanged();
    partial void OnFontSizeChanging(System.Nullable<double> value);
    partial void OnFontSizeChanged();
    #endregion
		
		public Setting()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SettingId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SettingId
		{
			get
			{
				return this._SettingId;
			}
			set
			{
				if ((this._SettingId != value))
				{
					this.OnSettingIdChanging(value);
					this.SendPropertyChanging();
					this._SettingId = value;
					this.SendPropertyChanged("SettingId");
					this.OnSettingIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(100)")]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactorAddress", DbType="NVarChar(MAX)")]
		public string FactorAddress
		{
			get
			{
				return this._FactorAddress;
			}
			set
			{
				if ((this._FactorAddress != value))
				{
					this.OnFactorAddressChanging(value);
					this.SendPropertyChanging();
					this._FactorAddress = value;
					this.SendPropertyChanged("FactorAddress");
					this.OnFactorAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactorTel", DbType="NVarChar(20)")]
		public string FactorTel
		{
			get
			{
				return this._FactorTel;
			}
			set
			{
				if ((this._FactorTel != value))
				{
					this.OnFactorTelChanging(value);
					this.SendPropertyChanging();
					this._FactorTel = value;
					this.SendPropertyChanged("FactorTel");
					this.OnFactorTelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Theme", DbType="NVarChar(50)")]
		public string Theme
		{
			get
			{
				return this._Theme;
			}
			set
			{
				if ((this._Theme != value))
				{
					this.OnThemeChanging(value);
					this.SendPropertyChanging();
					this._Theme = value;
					this.SendPropertyChanged("Theme");
					this.OnThemeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FontSize", DbType="Float")]
		public System.Nullable<double> FontSize
		{
			get
			{
				return this._FontSize;
			}
			set
			{
				if ((this._FontSize != value))
				{
					this.OnFontSizeChanging(value);
					this.SendPropertyChanging();
					this._FontSize = value;
					this.SendPropertyChanged("FontSize");
					this.OnFontSizeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Roles")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RoleId;
		
		private string _RoleName;
		
		private System.Nullable<bool> _SettingPermission;
		
		private System.Nullable<bool> _UserPermission;
		
		private System.Nullable<bool> _BankPermission;
		
		private System.Nullable<bool> _FactorPermission;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoleIdChanging(int value);
    partial void OnRoleIdChanged();
    partial void OnRoleNameChanging(string value);
    partial void OnRoleNameChanged();
    partial void OnSettingPermissionChanging(System.Nullable<bool> value);
    partial void OnSettingPermissionChanged();
    partial void OnUserPermissionChanging(System.Nullable<bool> value);
    partial void OnUserPermissionChanged();
    partial void OnBankPermissionChanging(System.Nullable<bool> value);
    partial void OnBankPermissionChanged();
    partial void OnFactorPermissionChanging(System.Nullable<bool> value);
    partial void OnFactorPermissionChanged();
    #endregion
		
		public Role()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="NVarChar(50)")]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this.OnRoleNameChanging(value);
					this.SendPropertyChanging();
					this._RoleName = value;
					this.SendPropertyChanged("RoleName");
					this.OnRoleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SettingPermission", DbType="Bit")]
		public System.Nullable<bool> SettingPermission
		{
			get
			{
				return this._SettingPermission;
			}
			set
			{
				if ((this._SettingPermission != value))
				{
					this.OnSettingPermissionChanging(value);
					this.SendPropertyChanging();
					this._SettingPermission = value;
					this.SendPropertyChanged("SettingPermission");
					this.OnSettingPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPermission", DbType="Bit")]
		public System.Nullable<bool> UserPermission
		{
			get
			{
				return this._UserPermission;
			}
			set
			{
				if ((this._UserPermission != value))
				{
					this.OnUserPermissionChanging(value);
					this.SendPropertyChanging();
					this._UserPermission = value;
					this.SendPropertyChanged("UserPermission");
					this.OnUserPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BankPermission", DbType="Bit")]
		public System.Nullable<bool> BankPermission
		{
			get
			{
				return this._BankPermission;
			}
			set
			{
				if ((this._BankPermission != value))
				{
					this.OnBankPermissionChanging(value);
					this.SendPropertyChanging();
					this._BankPermission = value;
					this.SendPropertyChanged("BankPermission");
					this.OnBankPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactorPermission", DbType="Bit")]
		public System.Nullable<bool> FactorPermission
		{
			get
			{
				return this._FactorPermission;
			}
			set
			{
				if ((this._FactorPermission != value))
				{
					this.OnFactorPermissionChanging(value);
					this.SendPropertyChanging();
					this._FactorPermission = value;
					this.SendPropertyChanged("FactorPermission");
					this.OnFactorPermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Users", ThisKey="RoleId", OtherKey="RoleId")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private System.Nullable<int> _RoleId;
		
		private string _Fullname;
		
		private string _LoginUser;
		
		private string _LoginPass;
		
		private EntityRef<Role> _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnRoleIdChanging(System.Nullable<int> value);
    partial void OnRoleIdChanged();
    partial void OnFullnameChanging(string value);
    partial void OnFullnameChanged();
    partial void OnLoginUserChanging(string value);
    partial void OnLoginUserChanged();
    partial void OnLoginPassChanging(string value);
    partial void OnLoginPassChanged();
    #endregion
		
		public User()
		{
			this._Role = default(EntityRef<Role>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="Int")]
		public System.Nullable<int> RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(30)")]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this.OnFullnameChanging(value);
					this.SendPropertyChanging();
					this._Fullname = value;
					this.SendPropertyChanged("Fullname");
					this.OnFullnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginUser", DbType="NVarChar(50)")]
		public string LoginUser
		{
			get
			{
				return this._LoginUser;
			}
			set
			{
				if ((this._LoginUser != value))
				{
					this.OnLoginUserChanging(value);
					this.SendPropertyChanging();
					this._LoginUser = value;
					this.SendPropertyChanged("LoginUser");
					this.OnLoginUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginPass", DbType="NVarChar(50)")]
		public string LoginPass
		{
			get
			{
				return this._LoginPass;
			}
			set
			{
				if ((this._LoginPass != value))
				{
					this.OnLoginPassChanging(value);
					this.SendPropertyChanging();
					this._LoginPass = value;
					this.SendPropertyChanged("LoginPass");
					this.OnLoginPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_User", Storage="_Role", ThisKey="RoleId", OtherKey="RoleId", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._RoleId = value.RoleId;
					}
					else
					{
						this._RoleId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Role");
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
	
	public partial class FillRolesByIdResult
	{
		
		private int _RoleId;
		
		private string _RoleName;
		
		private System.Nullable<bool> _SettingPermission;
		
		private System.Nullable<bool> _UserPermission;
		
		private System.Nullable<bool> _BankPermission;
		
		private System.Nullable<bool> _FactorPermission;
		
		public FillRolesByIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="Int NOT NULL")]
		public int RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					this._RoleId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleName", DbType="NVarChar(50)")]
		public string RoleName
		{
			get
			{
				return this._RoleName;
			}
			set
			{
				if ((this._RoleName != value))
				{
					this._RoleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SettingPermission", DbType="Bit")]
		public System.Nullable<bool> SettingPermission
		{
			get
			{
				return this._SettingPermission;
			}
			set
			{
				if ((this._SettingPermission != value))
				{
					this._SettingPermission = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPermission", DbType="Bit")]
		public System.Nullable<bool> UserPermission
		{
			get
			{
				return this._UserPermission;
			}
			set
			{
				if ((this._UserPermission != value))
				{
					this._UserPermission = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BankPermission", DbType="Bit")]
		public System.Nullable<bool> BankPermission
		{
			get
			{
				return this._BankPermission;
			}
			set
			{
				if ((this._BankPermission != value))
				{
					this._BankPermission = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FactorPermission", DbType="Bit")]
		public System.Nullable<bool> FactorPermission
		{
			get
			{
				return this._FactorPermission;
			}
			set
			{
				if ((this._FactorPermission != value))
				{
					this._FactorPermission = value;
				}
			}
		}
	}
	
	public partial class FillUsersResult
	{
		
		private int _UserId;
		
		private System.Nullable<int> _RoleId;
		
		private string _Fullname;
		
		private string _LoginUser;
		
		private string _LoginPass;
		
		public FillUsersResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="Int")]
		public System.Nullable<int> RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					this._RoleId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(30)")]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this._Fullname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginUser", DbType="NVarChar(50)")]
		public string LoginUser
		{
			get
			{
				return this._LoginUser;
			}
			set
			{
				if ((this._LoginUser != value))
				{
					this._LoginUser = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginPass", DbType="NVarChar(50)")]
		public string LoginPass
		{
			get
			{
				return this._LoginPass;
			}
			set
			{
				if ((this._LoginPass != value))
				{
					this._LoginPass = value;
				}
			}
		}
	}
	
	public partial class FillUsersByIdResult
	{
		
		private int _UserId;
		
		private System.Nullable<int> _RoleId;
		
		private string _Fullname;
		
		private string _LoginUser;
		
		private string _LoginPass;
		
		public FillUsersByIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="Int")]
		public System.Nullable<int> RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					this._RoleId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(30)")]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this._Fullname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginUser", DbType="NVarChar(50)")]
		public string LoginUser
		{
			get
			{
				return this._LoginUser;
			}
			set
			{
				if ((this._LoginUser != value))
				{
					this._LoginUser = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginPass", DbType="NVarChar(50)")]
		public string LoginPass
		{
			get
			{
				return this._LoginPass;
			}
			set
			{
				if ((this._LoginPass != value))
				{
					this._LoginPass = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

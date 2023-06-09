﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminGunny.Admin
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Db_Tank")]
	public partial class sendmailDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public sendmailDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Db_TankConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public sendmailDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sendmailDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sendmailDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sendmailDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Admin_SendAllItem")]
		public ISingleResult<SP_Admin_SendAllItemResult> SP_Admin_SendAllItem([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(1000)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Content", DbType="NVarChar(2000)")] string content, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID", DbType="Int")] System.Nullable<int> userID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gold", DbType="Int")] System.Nullable<int> gold, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Money", DbType="Int")] System.Nullable<int> money, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GiftToken", DbType="Int")] System.Nullable<int> giftToken, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Param", DbType="NVarChar(2000)")] string param)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), title, content, userID, gold, money, giftToken, param);
			return ((ISingleResult<SP_Admin_SendAllItemResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insert_Update_BallList")]
		public int SP_Insert_Update_BallList(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(200)")] string name, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Power", DbType="Float")] System.Nullable<double> power, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Radii", DbType="Int")] System.Nullable<int> radii, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FlyingPartical", DbType="NVarChar(200)")] string flyingPartical, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BombPartical", DbType="NVarChar(200)")] string bombPartical, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Crater", DbType="NVarChar(200)")] string crater, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AttackResponse", DbType="Int")] System.Nullable<int> attackResponse, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsSpin", DbType="Bit")] System.Nullable<bool> isSpin, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mass", DbType="Int")] System.Nullable<int> mass, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SpinVA", DbType="Float")] System.Nullable<double> spinVA, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SpinV", DbType="Int")] System.Nullable<int> spinV, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Amount", DbType="Int")] System.Nullable<int> amount, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Wind", DbType="Int")] System.Nullable<int> wind, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DragIndex", DbType="Int")] System.Nullable<int> dragIndex, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Weight", DbType="Int")] System.Nullable<int> weight, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Shake", DbType="Bit")] System.Nullable<bool> shake, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ShootSound", DbType="NVarChar(50)")] string shootSound, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BombSound", DbType="NVarChar(50)")] string bombSound, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Delay", DbType="Int")] System.Nullable<int> delay, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ActionType", DbType="Int")] System.Nullable<int> actionType, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="HasTunnel", DbType="Bit")] System.Nullable<bool> hasTunnel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> setUpdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, name, power, radii, flyingPartical, bombPartical, crater, attackResponse, isSpin, mass, spinVA, spinV, amount, wind, dragIndex, weight, shake, shootSound, bombSound, delay, actionType, hasTunnel, setUpdate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insert_Update_bombconfig")]
		public int SP_Insert_Update_bombconfig([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TemplateID", DbType="Int")] System.Nullable<int> templateID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Common", DbType="Int")] System.Nullable<int> common, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CommonAddWound", DbType="Int")] System.Nullable<int> commonAddWound, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CommonMultiBall", DbType="Int")] System.Nullable<int> commonMultiBall, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Special", DbType="Int")] System.Nullable<int> special, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SpecialII", DbType="Int")] System.Nullable<int> specialII, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> setUpdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), templateID, common, commonAddWound, commonMultiBall, special, specialII, setUpdate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insert_Update_Game_Map")]
		public int SP_Insert_Update_Game_Map(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(50)")] string name, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(2000)")] string description, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ForegroundWidth", DbType="Int")] System.Nullable<int> foregroundWidth, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ForegroundHeight", DbType="Int")] System.Nullable<int> foregroundHeight, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BackroundWidht", DbType="Int")] System.Nullable<int> backroundWidht, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BackroundHeight", DbType="Int")] System.Nullable<int> backroundHeight, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DeadWidth", DbType="Int")] System.Nullable<int> deadWidth, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DeadHeight", DbType="Int")] System.Nullable<int> deadHeight, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Weight", DbType="Int")] System.Nullable<int> weight, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DragIndex", DbType="Int")] System.Nullable<int> dragIndex, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ForePic", DbType="NVarChar(200)")] string forePic, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BackPic", DbType="NVarChar(200)")] string backPic, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DeadPic", DbType="NVarChar(200)")] string deadPic, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pic", DbType="NVarChar(200)")] string pic, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Remark", DbType="NVarChar(50)")] string remark, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BackMusic", DbType="NVarChar(200)")] string backMusic, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="PosX", DbType="NVarChar(200)")] string posX, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Type", DbType="Int")] System.Nullable<int> type, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="PosX1", DbType="NVarChar(200)")] string posX1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> setUpdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, name, description, foregroundWidth, foregroundHeight, backroundWidht, backroundHeight, deadWidth, deadHeight, weight, dragIndex, forePic, backPic, deadPic, pic, remark, backMusic, posX, type, posX1, setUpdate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insert_Update_NPC_Info")]
		public int SP_Insert_Update_NPC_Info(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(50)")] string name, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Level", DbType="Int")] System.Nullable<int> level, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Camp", DbType="Int")] System.Nullable<int> camp, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Type", DbType="Int")] System.Nullable<int> type, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="X", DbType="Int")] System.Nullable<int> x, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Y", DbType="Int")] System.Nullable<int> y, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Width", DbType="Int")] System.Nullable<int> width, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Height", DbType="Int")] System.Nullable<int> height, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Blood", DbType="Int")] System.Nullable<int> blood, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MoveMin", DbType="Int")] System.Nullable<int> moveMin, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MoveMax", DbType="Int")] System.Nullable<int> moveMax, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BaseDamage", DbType="Int")] System.Nullable<int> baseDamage, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BaseGuard", DbType="Int")] System.Nullable<int> baseGuard, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Defence", DbType="Int")] System.Nullable<int> defence, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Agility", DbType="Int")] System.Nullable<int> agility, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Lucky", DbType="Int")] System.Nullable<int> lucky, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Attack", DbType="Int")] System.Nullable<int> attack, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ModelID", DbType="NVarChar(1000)")] string modelID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ResourcesPath", DbType="NVarChar(1000)")] string resourcesPath, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DropRate", DbType="NVarChar(50)")] string dropRate, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Experience", DbType="Int")] System.Nullable<int> experience, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Delay", DbType="Int")] System.Nullable<int> delay, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Immunity", DbType="Int")] System.Nullable<int> immunity, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Alert", DbType="Int")] System.Nullable<int> alert, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Range", DbType="Int")] System.Nullable<int> range, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Preserve", DbType="Int")] System.Nullable<int> preserve, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Script", DbType="NVarChar(50)")] string script, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FireX", DbType="Int")] System.Nullable<int> fireX, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FireY", DbType="Int")] System.Nullable<int> fireY, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DropId", DbType="Int")] System.Nullable<int> dropId, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> setUpdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, name, level, camp, type, x, y, width, height, blood, moveMin, moveMax, baseDamage, baseGuard, defence, agility, lucky, attack, modelID, resourcesPath, dropRate, experience, delay, immunity, alert, range, preserve, script, fireX, fireY, dropId, setUpdate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insert_Update_Pve_Info")]
		public int SP_Insert_Update_Pve_Info(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(100)")] string name, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Type", DbType="Int")] System.Nullable<int> type, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="LevelLimits", DbType="Int")] System.Nullable<int> levelLimits, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SimpleTemplateIds", DbType="NVarChar(1024)")] string simpleTemplateIds, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NormalTemplateIds", DbType="NVarChar(1024)")] string normalTemplateIds, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="HardTemplateIds", DbType="NVarChar(1024)")] string hardTemplateIds, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TerrorTemplateIds", DbType="NVarChar(1024)")] string terrorTemplateIds, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pic", DbType="NVarChar(100)")] string pic, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(1024)")] string description, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="SimpleGameScript", DbType="NVarChar(100)")] string simpleGameScript, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NormalGameScript", DbType="NVarChar(100)")] string normalGameScript, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="HardGameScript", DbType="NVarChar(100)")] string hardGameScript, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TerrorGameScript", DbType="NVarChar(100)")] string terrorGameScript, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ordering", DbType="Int")] System.Nullable<int> ordering, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AdviceTips", DbType="NVarChar(100)")] string adviceTips, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> setUpdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, name, type, levelLimits, simpleTemplateIds, normalTemplateIds, hardTemplateIds, terrorTemplateIds, pic, description, simpleGameScript, normalGameScript, hardGameScript, terrorGameScript, ordering, adviceTips, setUpdate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insert_Update_Shop_Goods_Box")]
		public int SP_Insert_Update_Shop_Goods_Box(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DataId", DbType="Int")] System.Nullable<int> dataId, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TemplateId", DbType="Int")] System.Nullable<int> templateId, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsSelect", DbType="Bit")] System.Nullable<bool> isSelect, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsBind", DbType="Bit")] System.Nullable<bool> isBind, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ItemValid", DbType="Int")] System.Nullable<int> itemValid, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ItemCount", DbType="Int")] System.Nullable<int> itemCount, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="StrengthenLevel", DbType="Int")] System.Nullable<int> strengthenLevel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AttackCompose", DbType="Int")] System.Nullable<int> attackCompose, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DefendCompose", DbType="Int")] System.Nullable<int> defendCompose, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AgilityCompose", DbType="Int")] System.Nullable<int> agilityCompose, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="LuckCompose", DbType="Int")] System.Nullable<int> luckCompose, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Random", DbType="Int")] System.Nullable<int> random, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsTips", DbType="Bit")] System.Nullable<bool> isTips, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsLogs", DbType="Bit")] System.Nullable<bool> isLogs, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> setUpdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, dataId, templateId, isSelect, isBind, itemValid, itemCount, strengthenLevel, attackCompose, defendCompose, agilityCompose, luckCompose, random, isTips, isLogs, setUpdate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insert_Update_ShopItemList")]
		public int SP_Insert_Update_ShopItemList(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Float")] System.Nullable<double> iD, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ShopID", DbType="Float")] System.Nullable<double> shopID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="GroupID", DbType="Float")] System.Nullable<double> groupID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TemplateID", DbType="Float")] System.Nullable<double> templateID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BuyType", DbType="Float")] System.Nullable<double> buyType, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsContinue", DbType="Bit")] System.Nullable<bool> isContinue, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsBind", DbType="Float")] System.Nullable<double> isBind, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsVouch", DbType="Float")] System.Nullable<double> isVouch, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Label", DbType="Float")] System.Nullable<double> label, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Beat", DbType="Float")] System.Nullable<double> beat, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AUnit", DbType="Float")] System.Nullable<double> aUnit, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="APrice1", DbType="Float")] System.Nullable<double> aPrice1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AValue1", DbType="Float")] System.Nullable<double> aValue1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="APrice2", DbType="Float")] System.Nullable<double> aPrice2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AValue2", DbType="Float")] System.Nullable<double> aValue2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="APrice3", DbType="Float")] System.Nullable<double> aPrice3, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AValue3", DbType="Float")] System.Nullable<double> aValue3, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BUnit", DbType="Float")] System.Nullable<double> bUnit, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BPrice1", DbType="Float")] System.Nullable<double> bPrice1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BValue1", DbType="Float")] System.Nullable<double> bValue1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BPrice2", DbType="Float")] System.Nullable<double> bPrice2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BValue2", DbType="Float")] System.Nullable<double> bValue2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BPrice3", DbType="Float")] System.Nullable<double> bPrice3, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BValue3", DbType="Float")] System.Nullable<double> bValue3, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CUnit", DbType="Float")] System.Nullable<double> cUnit, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CPrice1", DbType="Float")] System.Nullable<double> cPrice1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CValue1", DbType="Float")] System.Nullable<double> cValue1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CPrice2", DbType="Float")] System.Nullable<double> cPrice2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CValue2", DbType="Float")] System.Nullable<double> cValue2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CPrice3", DbType="Float")] System.Nullable<double> cPrice3, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sort", DbType="Float")] System.Nullable<double> sort, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CValue3", DbType="Float")] System.Nullable<double> cValue3, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> setUpdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, shopID, groupID, templateID, buyType, isContinue, isBind, isVouch, label, beat, aUnit, aPrice1, aValue1, aPrice2, aValue2, aPrice3, aValue3, bUnit, bPrice1, bValue1, bPrice2, bValue2, bPrice3, bValue3, cUnit, cPrice1, cValue1, cPrice2, cValue2, cPrice3, sort, cValue3, setUpdate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_delete_Item_Fusion")]
		public int SP_delete_Item_Fusion([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FusionID", DbType="Int")] System.Nullable<int> fusionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fusionID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insert_Update_Item_Fusion")]
		public int SP_Insert_Update_Item_Fusion([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FusionID", DbType="Int")] System.Nullable<int> fusionID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Item1", DbType="Int")] System.Nullable<int> item1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Item2", DbType="Int")] System.Nullable<int> item2, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Item3", DbType="Int")] System.Nullable<int> item3, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Item4", DbType="Int")] System.Nullable<int> item4, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Formula", DbType="Int")] System.Nullable<int> formula, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Reward", DbType="Int")] System.Nullable<int> reward, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> setUpdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fusionID, item1, item2, item3, item4, formula, reward, setUpdate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_Insert_Update_TemplateAlllist")]
		public int SP_Insert_Update_TemplateAlllist(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TemplateID", DbType="Int")] System.Nullable<int> templateID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="NVarChar(50)")] string name, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CategoryID", DbType="Int")] System.Nullable<int> categoryID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(200)")] string description, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Attack", DbType="Int")] System.Nullable<int> attack, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Defence", DbType="Int")] System.Nullable<int> defence, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Agility", DbType="Int")] System.Nullable<int> agility, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Luck", DbType="Int")] System.Nullable<int> luck, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Level", DbType="Int")] System.Nullable<int> level, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Quality", DbType="Int")] System.Nullable<int> quality, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pic", DbType="NVarChar(200)")] string pic, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaxCount", DbType="Int")] System.Nullable<int> maxCount, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NeedSex", DbType="Int")] System.Nullable<int> needSex, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NeedLevel", DbType="Int")] System.Nullable<int> needLevel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CanStrengthen", DbType="Bit")] System.Nullable<bool> canStrengthen, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CanCompose", DbType="Bit")] System.Nullable<bool> canCompose, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CanDrop", DbType="Bit")] System.Nullable<bool> canDrop, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CanEquip", DbType="Bit")] System.Nullable<bool> canEquip, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CanUse", DbType="Bit")] System.Nullable<bool> canUse, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CanDelete", DbType="Bit")] System.Nullable<bool> canDelete, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Script", DbType="NVarChar(200)")] string script, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Data", DbType="NVarChar(1000)")] string data, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Colors", DbType="NVarChar(1000)")] string colors, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Property1", DbType="Int")] System.Nullable<int> property1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Property2", DbType="Int")] System.Nullable<int> property2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Property3", DbType="Int")] System.Nullable<int> property3, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Property4", DbType="Int")] System.Nullable<int> property4, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Property5", DbType="Int")] System.Nullable<int> property5, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Property6", DbType="Int")] System.Nullable<int> property6, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Property7", DbType="Int")] System.Nullable<int> property7, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Property8", DbType="Int")] System.Nullable<int> property8, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AddTime", DbType="DateTime")] System.Nullable<System.DateTime> addTime, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BindType", DbType="Int")] System.Nullable<int> bindType, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FusionType", DbType="Int")] System.Nullable<int> fusionType, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FusionRate", DbType="Int")] System.Nullable<int> fusionRate, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="FusionNeedRate", DbType="Int")] System.Nullable<int> fusionNeedRate, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Hole", DbType="NVarChar(50)")] string hole, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="RefineryLevel", DbType="Int")] System.Nullable<int> refineryLevel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReclaimValue", DbType="Int")] System.Nullable<int> reclaimValue, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReclaimType", DbType="Int")] System.Nullable<int> reclaimType, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CanRecycle", DbType="Int")] System.Nullable<int> canRecycle, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> setUpdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), templateID, name, categoryID, description, attack, defence, agility, luck, level, quality, pic, maxCount, needSex, needLevel, canStrengthen, canCompose, canDrop, canEquip, canUse, canDelete, script, data, colors, property1, property2, property3, property4, property5, property6, property7, property8, addTime, bindType, fusionType, fusionRate, fusionNeedRate, hole, refineryLevel, reclaimValue, reclaimType, canRecycle, setUpdate);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class SP_Admin_SendAllItemResult
	{
		
		private System.Nullable<decimal> _identity;
		
		public SP_Admin_SendAllItemResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[identity]", Storage="_identity", DbType="Decimal(38,0)")]
		public System.Nullable<decimal> identity
		{
			get
			{
				return this._identity;
			}
			set
			{
				if ((this._identity != value))
				{
					this._identity = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

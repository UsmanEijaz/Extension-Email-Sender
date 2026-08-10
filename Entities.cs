using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssExtension {

	public class ENNamesEntityConfiguration {
		private static object config;
		private static string PhysicalTableName {
			get {
				try {
					Type EntityConfiguration = Type.GetType("OutSystems.HubEdition.RuntimePlatform.Db.EntityConfiguration,OutSystems.HubEdition.RuntimePlatform");
					if (EntityConfiguration != null) {
						if (config == null) {
							config = EntityConfiguration.GetMethod("GetEntityConfiguration", BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { "8c6c02d1-511e-494b-aa89-f1959faf8227", "34bb9af4-55c4-4873-b0fe-40dcec8823ac", "Names", "[Services].[dbo].[Names]"}); 
						}
						return EntityConfiguration.GetProperty("PhysicalTableName").GetValue(config).ToString();
					} else {
						return "[Services].[dbo].[Names]"; 
					}
				} catch {
					return "[Services].[dbo].[Names]"; 
				}
			}
		}
		public static string GetPhysicalTableName() {
			return PhysicalTableName; 
		}
	}

	public sealed partial class ENNamesEntity {
		private static readonly System.Collections.Generic.Dictionary<string, string> entityAttributes = new System.Collections.Generic.Dictionary<string, string>() {
			{ "id", "Id"
			}
			, { "namear", "NameAr"
			}
		};
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return entityAttributes;
		}
		public static string AttributeDatabaseName(string attributeName) {
			string databaseName;
			entityAttributes.TryGetValue(attributeName, out databaseName);
			return databaseName;
		}
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return ENNamesEntityConfiguration.GetPhysicalTableName();
		}
	} // ENNamesEntity

	/// <summary>
	/// Entity <code>ENNamesEntityRecord</code> that represents the Service Studio entity
	///  <code>Names</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("Names", "9Jq7NMRVc0iw_kDc7IgjrA", "0QJsjB5RS0mqifGVn6+CJw", 0, "[Services].[dbo].[Names]", null)]
	[Serializable()]
	public partial struct ENNamesEntityRecord: ISerializable, ITypedRecord<ENNamesEntityRecord>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("0QJsjB5RS0mqifGVn6+CJw*p6_o6+Ui0UWl7FDM6PqGzg");
		internal static readonly GlobalObjectKey IdNameAr = GlobalObjectKey.Parse("0QJsjB5RS0mqifGVn6+CJw*NnA6377kykS4matflGnJJw");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Id", 50, false, true, false, true)]
		[System.Xml.Serialization.XmlElement("Id")]
		private string _ssId;
		public string ssId {
			get {
				return _ssId;
			}
			set {
				if ((_ssId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(2, true);
					_ssId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("NameAr", 255, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("NameAr")]
		private string _ssNameAr;
		public string ssNameAr {
			get {
				return _ssNameAr;
			}
			set {
				if ((_ssNameAr!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssNameAr = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENNamesEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssId = "";
			_ssNameAr = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssId = r.ReadText(index++, "Names.Id", "");
			ssNameAr = r.ReadText(index++, "Names.NameAr", "");
			ChangedAttributes = new BitArray(2, false);
			OptimizedAttributes = new BitArray(2, false);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(ENNamesEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENNamesEntityRecord a, ENNamesEntityRecord b) {
			if (a.ssId != b.ssId) return false;
			if (a.ssNameAr != b.ssNameAr) return false;
			return true;
		}

		public static bool operator != (ENNamesEntityRecord a, ENNamesEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENNamesEntityRecord)) return false;
			return (this == (ENNamesEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssId.GetHashCode()
				^ ssNameAr.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public ENNamesEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(2, true);
			OptimizedAttributes = new BitArray(2, false);
			_ssId = "";
			_ssNameAr = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssId = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssNameAr", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssNameAr' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssNameAr = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENNamesEntityRecord Duplicate() {
			ENNamesEntityRecord t;
			t._ssId = this._ssId;
			t._ssNameAr = this._ssNameAr;
			t.ChangedAttributes = new BitArray(2);
			t.OptimizedAttributes = new BitArray(2);
			for (int i = 0; i < 2; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Id")) VarValue.AppendAttribute(recordElem, "Id", ssId, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Id");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".NameAr")) VarValue.AppendAttribute(recordElem, "NameAr", ssNameAr, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "NameAr");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "id") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
			} else if (head == "namear") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".NameAr")) variable.Value = ssNameAr; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdNameAr)) {
				return ChangedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdNameAr)) {
				return OptimizedAttributes[1];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdId) {
				return ssId;
			} else if (key == IdNameAr) {
				return ssNameAr;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(2);
			OptimizedAttributes = new BitArray(2);
			if (other == null) return;
			ssId = (string) other.AttributeGet(IdId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
			ssNameAr = (string) other.AttributeGet(IdNameAr);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdNameAr);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdNameAr);
		}
		public bool IsDefault() {
			ENNamesEntityRecord defaultStruct = new ENNamesEntityRecord(null);
			if (this.ssId != defaultStruct.ssId) return false;
			if (this.ssNameAr != defaultStruct.ssNameAr) return false;
			return true;
		}
	} // ENNamesEntityRecord

} // OutSystems.NssExtension

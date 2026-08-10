using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssExtension {

	/// <summary>
	/// Structure <code>RCNamesRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCNamesRecord: ISerializable, ITypedRecord<RCNamesRecord> {
		internal static readonly GlobalObjectKey IdNames = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+v+HyF+V2Vq2t0B8mPnYg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Names")]
		public ENNamesEntityRecord ssENNames;


		public static implicit operator ENNamesEntityRecord(RCNamesRecord r) {
			return r.ssENNames;
		}

		public static implicit operator RCNamesRecord(ENNamesEntityRecord r) {
			RCNamesRecord res = new RCNamesRecord(null);
			res.ssENNames = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENNames.ChangedAttributes = value;
			}
			get {
				return ssENNames.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCNamesRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENNames = new ENNamesEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(2, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENNames.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENNames.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENNames.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENNames.Read(r, ref index);
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
		public void ReadIM(RCNamesRecord r) {
			this = r;
		}


		public static bool operator == (RCNamesRecord a, RCNamesRecord b) {
			if (a.ssENNames != b.ssENNames) return false;
			return true;
		}

		public static bool operator != (RCNamesRecord a, RCNamesRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCNamesRecord)) return false;
			return (this == (RCNamesRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENNames.GetHashCode()
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

		public RCNamesRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENNames = new ENNamesEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENNames", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENNames' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENNames = (ENNamesEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENNames.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENNames.InternalRecursiveSave();
		}


		public RCNamesRecord Duplicate() {
			RCNamesRecord t;
			t.ssENNames = (ENNamesEntityRecord) this.ssENNames.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENNames.ToXml(this, recordElem, "Names", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "names") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Names")) variable.Value = ssENNames; else variable.Optimized = true;
				variable.SetFieldName("names");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENNames.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENNames.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdNames) {
				return ssENNames;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENNames.FillFromOther((IRecord) other.AttributeGet(IdNames));
		}
		public bool IsDefault() {
			RCNamesRecord defaultStruct = new RCNamesRecord(null);
			if (this.ssENNames != defaultStruct.ssENNames) return false;
			return true;
		}
	} // RCNamesRecord

	/// <summary>
	/// Structure <code>RCTemplateParameterRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTemplateParameterRecord: ISerializable, ITypedRecord<RCTemplateParameterRecord> {
		internal static readonly GlobalObjectKey IdTemplateParameter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*t9P3XJNgEhBTSvfYPpmjPw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("TemplateParameter")]
		public STTemplateParameterStructure ssSTTemplateParameter;


		public static implicit operator STTemplateParameterStructure(RCTemplateParameterRecord r) {
			return r.ssSTTemplateParameter;
		}

		public static implicit operator RCTemplateParameterRecord(STTemplateParameterStructure r) {
			RCTemplateParameterRecord res = new RCTemplateParameterRecord(null);
			res.ssSTTemplateParameter = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCTemplateParameterRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTTemplateParameter = new STTemplateParameterStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTTemplateParameter.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTTemplateParameter.Read(r, ref index);
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
		public void ReadIM(RCTemplateParameterRecord r) {
			this = r;
		}


		public static bool operator == (RCTemplateParameterRecord a, RCTemplateParameterRecord b) {
			if (a.ssSTTemplateParameter != b.ssSTTemplateParameter) return false;
			return true;
		}

		public static bool operator != (RCTemplateParameterRecord a, RCTemplateParameterRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTemplateParameterRecord)) return false;
			return (this == (RCTemplateParameterRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTTemplateParameter.GetHashCode()
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

		public RCTemplateParameterRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTTemplateParameter = new STTemplateParameterStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTTemplateParameter", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTTemplateParameter' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTTemplateParameter = (STTemplateParameterStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTTemplateParameter.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTTemplateParameter.InternalRecursiveSave();
		}


		public RCTemplateParameterRecord Duplicate() {
			RCTemplateParameterRecord t;
			t.ssSTTemplateParameter = (STTemplateParameterStructure) this.ssSTTemplateParameter.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTTemplateParameter.ToXml(this, recordElem, "TemplateParameter", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "templateparameter") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TemplateParameter")) variable.Value = ssSTTemplateParameter; else variable.Optimized = true;
				variable.SetFieldName("templateparameter");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdTemplateParameter) {
				return ssSTTemplateParameter;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTTemplateParameter.FillFromOther((IRecord) other.AttributeGet(IdTemplateParameter));
		}
		public bool IsDefault() {
			RCTemplateParameterRecord defaultStruct = new RCTemplateParameterRecord(null);
			if (this.ssSTTemplateParameter != defaultStruct.ssSTTemplateParameter) return false;
			return true;
		}
	} // RCTemplateParameterRecord

	/// <summary>
	/// Structure <code>RCAttachmentsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAttachmentsRecord: ISerializable, ITypedRecord<RCAttachmentsRecord> {
		internal static readonly GlobalObjectKey IdAttachments = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S1TlywGZqZK1z5SXz2gpYQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Attachments")]
		public STAttachmentsStructure ssSTAttachments;


		public static implicit operator STAttachmentsStructure(RCAttachmentsRecord r) {
			return r.ssSTAttachments;
		}

		public static implicit operator RCAttachmentsRecord(STAttachmentsStructure r) {
			RCAttachmentsRecord res = new RCAttachmentsRecord(null);
			res.ssSTAttachments = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAttachmentsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAttachments = new STAttachmentsStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAttachments.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAttachments.Read(r, ref index);
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
		public void ReadIM(RCAttachmentsRecord r) {
			this = r;
		}


		public static bool operator == (RCAttachmentsRecord a, RCAttachmentsRecord b) {
			if (a.ssSTAttachments != b.ssSTAttachments) return false;
			return true;
		}

		public static bool operator != (RCAttachmentsRecord a, RCAttachmentsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAttachmentsRecord)) return false;
			return (this == (RCAttachmentsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAttachments.GetHashCode()
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

		public RCAttachmentsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAttachments = new STAttachmentsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAttachments", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAttachments' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAttachments = (STAttachmentsStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAttachments.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAttachments.InternalRecursiveSave();
		}


		public RCAttachmentsRecord Duplicate() {
			RCAttachmentsRecord t;
			t.ssSTAttachments = (STAttachmentsStructure) this.ssSTAttachments.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAttachments.ToXml(this, recordElem, "Attachments", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "attachments") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attachments")) variable.Value = ssSTAttachments; else variable.Optimized = true;
				variable.SetFieldName("attachments");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAttachments) {
				return ssSTAttachments;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAttachments.FillFromOther((IRecord) other.AttributeGet(IdAttachments));
		}
		public bool IsDefault() {
			RCAttachmentsRecord defaultStruct = new RCAttachmentsRecord(null);
			if (this.ssSTAttachments != defaultStruct.ssSTAttachments) return false;
			return true;
		}
	} // RCAttachmentsRecord
}
